CREATE TABLE [dbo].[JobApplication] (
    [ApplicantId]                INT            IDENTITY (1, 1) NOT NULL,
    [CandidateId]                INT            NOT NULL,
    [JobId]                      INT            NOT NULL,
    [CandidatePrimarySkillsetId] NVARCHAR (MAX) NULL,
    [ShortlistedForInterview]    BIT            NULL,
    [RoundOneStatus]             INT            NULL,
    [RoundOnePanel]              NVARCHAR (50)  NULL,
    [RoundTwoStatus]             NCHAR (10)     NULL,
    [RoundTwoPanel]              INT            NULL,
    [InterviewCleared]           BIT            NULL,
    [HMAppoval]                  BIT            NULL,
    [HringMangerId]              INT            NULL,
    [JobOffered]                 BIT            NULL,
    [ModifiedBy]                 NVARCHAR (50)  NULL,
    [ModifiedDate]               DATETIME       NULL,
    PRIMARY KEY CLUSTERED ([ApplicantId] ASC)
);

