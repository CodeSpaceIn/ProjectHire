CREATE TABLE [dbo].[InterviewPanel] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [Name ]        NVARCHAR (50) NULL,
    [EmailId]      NVARCHAR (50) NULL,
    [ModifiedBy]   NVARCHAR (50) NULL,
    [ModifiedDate] DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

