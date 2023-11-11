CREATE TABLE [dbo].[Job] (
    [JobId]           INT            IDENTITY (1, 1) NOT NULL,
    [JobDescription]  NVARCHAR (MAX) NULL,
    [Active]          BIT            NULL,
    [ExpRequired]     NVARCHAR (50)  NULL,
    [PrimarySkils]    NVARCHAR (50)  NULL,
    [Secondaryskills] NVARCHAR (50)  NULL,
    [ModifiedBy]      NVARCHAR (50)  NULL,
    [ModifiedDate]    DATETIME       NULL,
    PRIMARY KEY CLUSTERED ([JobId] ASC)
);

