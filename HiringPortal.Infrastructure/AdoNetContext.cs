﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiringPortal.Infrastructure
{
    public class AdoNetContext : IDisposable
    {
        private IDbConnection _connection;
        private bool _ownsConnection;
        private IDbTransaction _transaction;

        public AdoNetContext(string connectionString, bool ownsConnection)
        {
            _connection = new SqlConnection(connectionString);
            _connection.Open();
            _ownsConnection = ownsConnection;
            _transaction = _connection.BeginTransaction();
        }
        public IDbCommand CreateCommand()
        {
            var command = _connection.CreateCommand();
            command.Transaction = _transaction;
            return command;
        }
        public void SaveChanges()
        {
            if (_transaction == null)
            {
                throw new InvalidOperationException("Transaction have already been already been commited. Check your transaction handling.");
            }
            _transaction.Commit();
            _transaction = null;
        }
        public void Dispose()
        {
            if (_transaction != null)
            {
                _transaction.Rollback();
                _transaction = null;
            }
            if (_connection != null && _ownsConnection)
            {
                _connection.Close();
                _connection = null;
            }
        }
    }
}