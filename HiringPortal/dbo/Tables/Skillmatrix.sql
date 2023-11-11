CREATE TABLE [dbo].[Skillmatrix] (
    [Id]           INT IDENTITY (1, 1) NOT NULL,
    [CandidateID ] INT NULL,
    [SkillId]      INT NULL,
    [isPrimary]    BIT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

