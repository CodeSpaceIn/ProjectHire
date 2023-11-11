CREATE TABLE [dbo].[Login] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [UserName]     NCHAR (10)    NULL,
    [Password]     NCHAR (10)    NULL,
    [isHR]         BIT           NULL,
    [isManger]     BIT           NULL,
    [ModifiedBy]   NVARCHAR (50) NULL,
    [ModifiedDate] DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

