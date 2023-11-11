CREATE TABLE [dbo].[Candidate] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [FirstName]   NVARCHAR (50) NULL,
    [LastName]    NVARCHAR (50) NOT NULL,
    [EmailID]     NVARCHAR (50) NULL,
    [PhoneNumber] NCHAR(10)  NULL,
    [Address]      NCHAR (10)    NULL,
    [PrimarySkill] NCHAR (10)    NULL,
    [ModifiedBy]   NVARCHAR (50) NULL,
    [ModifiedDate] DATETIME      NULL,
    [Active]       BIT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

