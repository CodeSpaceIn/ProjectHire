CREATE TABLE [dbo].[HiringManger] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [ManagerName]  NVARCHAR (50) NULL,
    [EmailId]      NVARCHAR (50) NULL,
    [ModifedBy]    NVARCHAR (50) NULL,
    [ModifiedDate] DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

