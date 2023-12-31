USE [HiringPortal]
GO
/****** Object:  Table [dbo].[Candidate]    Script Date: 11/12/2023 10:11:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Candidate](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName ] [nvarchar](50) NULL,
	[LastName ] [nvarchar](50) NOT NULL,
	[EmailID ] [nvarchar](50) NULL,
	[PhoneNumber ] [numeric](10, 0) NULL,
	[Address] [nchar](10) NULL,
	[PrimarySkill] [nchar](10) NULL,
	[ModifiedBy] [nvarchar](50) NULL,
	[ModifiedDate] [datetime] NULL,
	[Active] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HiringManger]    Script Date: 11/12/2023 10:11:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HiringManger](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ManagerName] [nvarchar](50) NULL,
	[EmailId] [nvarchar](50) NULL,
	[ModifedBy] [nvarchar](50) NULL,
	[ModifiedDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[interviewLog]    Script Date: 11/12/2023 10:11:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[interviewLog](
	[InterviewId] [int] IDENTITY(1,1) NOT NULL,
	[ApplicantId] [int] NOT NULL,
	[InterviewRound] [int] NOT NULL,
	[InterviewPanel] [varchar](50) NOT NULL,
	[RoundType] [int] NOT NULL,
	[ScheduledDateTime] [datetime] NOT NULL,
	[STATUS] [int] NULL,
	[Feedback] [varchar](max) NULL,
	[CreatedDate] [int] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[ModifiedBy] [nvarchar](50) NULL,
	[ModifiedDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[InterviewId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InterviewPanel]    Script Date: 11/12/2023 10:11:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InterviewPanel](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name ] [nvarchar](50) NULL,
	[EmailId] [nvarchar](50) NULL,
	[ModifiedBy] [nvarchar](50) NULL,
	[ModifiedDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InterviewStatus]    Script Date: 11/12/2023 10:11:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InterviewStatus](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Status ] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job]    Script Date: 11/12/2023 10:11:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job](
	[JobId] [int] IDENTITY(1,1) NOT NULL,
	[JobDescription] [nvarchar](max) NULL,
	[Active] [bit] NULL,
	[ExpRequired] [nvarchar](50) NULL,
	[PrimarySkils] [nvarchar](50) NULL,
	[Secondaryskills] [nvarchar](50) NULL,
	[ModifiedBy] [nvarchar](50) NULL,
	[ModifiedDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[JobId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[JobApplication]    Script Date: 11/12/2023 10:11:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JobApplication](
	[ApplicantId] [int] IDENTITY(1,1) NOT NULL,
	[CandidateId] [int] NOT NULL,
	[JobId] [int] NOT NULL,
	[ApplicationStatus] [int] NOT NULL,
	[Recruiter] [int] NULL,
	[HMAppoval] [bit] NULL,
	[HringMangerId] [int] NULL,
	[JobOffered] [bit] NULL,
	[CreatedDate] [int] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[ModifiedBy] [nvarchar](50) NULL,
	[ModifiedDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ApplicantId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[JobSkillMatrix]    Script Date: 11/12/2023 10:11:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JobSkillMatrix](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[JobID] [int] NULL,
	[SkillId] [int] NULL,
	[isPrimary] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 11/12/2023 10:11:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nchar](10) NULL,
	[Password] [nchar](10) NULL,
	[isHR] [bit] NULL,
	[isManger] [bit] NULL,
	[ModifiedBy] [nvarchar](50) NULL,
	[ModifiedDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OnBoardingTracker]    Script Date: 11/12/2023 10:11:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OnBoardingTracker](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ApplicantId] [int] NOT NULL,
	[OfferInitiated] [bit] NULL,
	[CandiateAcceptance] [bit] NULL,
	[Status] [int] NULL,
	[InitiateOnBoarding] [bit] NULL,
	[Remarks] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoundType]    Script Date: 11/12/2023 10:11:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoundType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[ModifiedBy] [nvarchar](50) NULL,
	[ModifiedDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Skill]    Script Date: 11/12/2023 10:11:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Skill](
	[SkilId] [int] NOT NULL,
	[SkillName] [nvarchar](50) NULL,
	[ModifiedBy] [nchar](10) NULL,
	[ModifiedDate] [nchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[SkilId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Skillmatrix]    Script Date: 11/12/2023 10:11:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Skillmatrix](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CandidateID] [int] NULL,
	[SkillId] [int] NULL,
	[isPrimary] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Status]    Script Date: 11/12/2023 10:11:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Status] [varchar](50) NOT NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[ModifiedBy] [nvarchar](50) NULL,
	[ModifiedDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Candidate] ON 

INSERT [dbo].[Candidate] ([Id], [FirstName ], [LastName ], [EmailID ], [PhoneNumber ], [Address], [PrimarySkill], [ModifiedBy], [ModifiedDate], [Active]) VALUES (1, N'Hari ', N'Kiran', N'h@gmail.com', CAST(123654789 AS Numeric(10, 0)), NULL, N'1,2,3     ', NULL, NULL, 1)
INSERT [dbo].[Candidate] ([Id], [FirstName ], [LastName ], [EmailID ], [PhoneNumber ], [Address], [PrimarySkill], [ModifiedBy], [ModifiedDate], [Active]) VALUES (2, N'Sai', N'Ram', N'sai@gmail.com', CAST(123456987 AS Numeric(10, 0)), NULL, N'2,4       ', NULL, NULL, 1)
INSERT [dbo].[Candidate] ([Id], [FirstName ], [LastName ], [EmailID ], [PhoneNumber ], [Address], [PrimarySkill], [ModifiedBy], [ModifiedDate], [Active]) VALUES (3, N'Radhika ', N'P', N'p@gmail.com', CAST(147853695 AS Numeric(10, 0)), NULL, N'3,5       ', NULL, NULL, NULL)
INSERT [dbo].[Candidate] ([Id], [FirstName ], [LastName ], [EmailID ], [PhoneNumber ], [Address], [PrimarySkill], [ModifiedBy], [ModifiedDate], [Active]) VALUES (1002, N'KK', N'K', N'k@gmail.com', CAST(123456 AS Numeric(10, 0)), NULL, N'1,2,3,4   ', NULL, NULL, 1)
SET IDENTITY_INSERT [dbo].[Candidate] OFF
GO
SET IDENTITY_INSERT [dbo].[HiringManger] ON 

INSERT [dbo].[HiringManger] ([Id], [ManagerName], [EmailId], [ModifedBy], [ModifiedDate]) VALUES (1, N'Raja', N'Raja@gmail.com', N'dbuser', NULL)
INSERT [dbo].[HiringManger] ([Id], [ManagerName], [EmailId], [ModifedBy], [ModifiedDate]) VALUES (2, N'Harshita', N'Harishita@gmail.com', N'dbuser', NULL)
SET IDENTITY_INSERT [dbo].[HiringManger] OFF
GO
SET IDENTITY_INSERT [dbo].[InterviewPanel] ON 

INSERT [dbo].[InterviewPanel] ([Id], [Name ], [EmailId], [ModifiedBy], [ModifiedDate]) VALUES (1, N'Sahithi', N'sahithi@gmail.com', N'dbuser', NULL)
INSERT [dbo].[InterviewPanel] ([Id], [Name ], [EmailId], [ModifiedBy], [ModifiedDate]) VALUES (2, N'Radhika', N'Radhika@gmail.com', N'dbuser', NULL)
INSERT [dbo].[InterviewPanel] ([Id], [Name ], [EmailId], [ModifiedBy], [ModifiedDate]) VALUES (3, N'Venkatesh', N'Venky@gmail.com', N'dbuser', NULL)
SET IDENTITY_INSERT [dbo].[InterviewPanel] OFF
GO
SET IDENTITY_INSERT [dbo].[RoundType] ON 

INSERT [dbo].[RoundType] ([Id], [Name], [CreatedBy], [ModifiedBy], [ModifiedDate]) VALUES (1, N'Technical', N'dbuser', NULL, NULL)
INSERT [dbo].[RoundType] ([Id], [Name], [CreatedBy], [ModifiedBy], [ModifiedDate]) VALUES (2, N'Manger', N'dbuser', NULL, NULL)
INSERT [dbo].[RoundType] ([Id], [Name], [CreatedBy], [ModifiedBy], [ModifiedDate]) VALUES (3, N'HR', N'dbuser', NULL, NULL)
SET IDENTITY_INSERT [dbo].[RoundType] OFF
GO
INSERT [dbo].[Skill] ([SkilId], [SkillName], [ModifiedBy], [ModifiedDate]) VALUES (1, N'HTML', NULL, NULL)
INSERT [dbo].[Skill] ([SkilId], [SkillName], [ModifiedBy], [ModifiedDate]) VALUES (2, N'CSS', NULL, NULL)
INSERT [dbo].[Skill] ([SkilId], [SkillName], [ModifiedBy], [ModifiedDate]) VALUES (3, N'JAVA', NULL, NULL)
INSERT [dbo].[Skill] ([SkilId], [SkillName], [ModifiedBy], [ModifiedDate]) VALUES (4, N'SQL', NULL, NULL)
INSERT [dbo].[Skill] ([SkilId], [SkillName], [ModifiedBy], [ModifiedDate]) VALUES (5, N'.NET', NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Skillmatrix] ON 

INSERT [dbo].[Skillmatrix] ([Id], [CandidateID], [SkillId], [isPrimary]) VALUES (1, 1, 1, 1)
INSERT [dbo].[Skillmatrix] ([Id], [CandidateID], [SkillId], [isPrimary]) VALUES (2, 1, 2, 1)
INSERT [dbo].[Skillmatrix] ([Id], [CandidateID], [SkillId], [isPrimary]) VALUES (3, 1, 3, 1)
INSERT [dbo].[Skillmatrix] ([Id], [CandidateID], [SkillId], [isPrimary]) VALUES (4, 2, 2, 1)
INSERT [dbo].[Skillmatrix] ([Id], [CandidateID], [SkillId], [isPrimary]) VALUES (5, 2, 4, 1)
INSERT [dbo].[Skillmatrix] ([Id], [CandidateID], [SkillId], [isPrimary]) VALUES (6, 3, 3, 1)
INSERT [dbo].[Skillmatrix] ([Id], [CandidateID], [SkillId], [isPrimary]) VALUES (7, 3, 5, 1)
INSERT [dbo].[Skillmatrix] ([Id], [CandidateID], [SkillId], [isPrimary]) VALUES (8, 1002, 1, 1)
INSERT [dbo].[Skillmatrix] ([Id], [CandidateID], [SkillId], [isPrimary]) VALUES (9, 1002, 2, 1)
INSERT [dbo].[Skillmatrix] ([Id], [CandidateID], [SkillId], [isPrimary]) VALUES (10, 1002, 3, 1)
INSERT [dbo].[Skillmatrix] ([Id], [CandidateID], [SkillId], [isPrimary]) VALUES (11, 1002, 4, 1)
SET IDENTITY_INSERT [dbo].[Skillmatrix] OFF
GO
SET IDENTITY_INSERT [dbo].[Status] ON 

INSERT [dbo].[Status] ([Id], [Status], [CreatedBy], [ModifiedBy], [ModifiedDate]) VALUES (1, N'Initiated', N'dbuser', NULL, NULL)
INSERT [dbo].[Status] ([Id], [Status], [CreatedBy], [ModifiedBy], [ModifiedDate]) VALUES (2, N'InProgress', N'dbuser', NULL, NULL)
INSERT [dbo].[Status] ([Id], [Status], [CreatedBy], [ModifiedBy], [ModifiedDate]) VALUES (3, N'OnHold', N'dbuser', NULL, NULL)
INSERT [dbo].[Status] ([Id], [Status], [CreatedBy], [ModifiedBy], [ModifiedDate]) VALUES (4, N'InReview', N'dbuser', NULL, NULL)
INSERT [dbo].[Status] ([Id], [Status], [CreatedBy], [ModifiedBy], [ModifiedDate]) VALUES (5, N'Promoted', N'dbuser', NULL, NULL)
INSERT [dbo].[Status] ([Id], [Status], [CreatedBy], [ModifiedBy], [ModifiedDate]) VALUES (6, N'Accepted', N'dbuser', NULL, NULL)
INSERT [dbo].[Status] ([Id], [Status], [CreatedBy], [ModifiedBy], [ModifiedDate]) VALUES (7, N'Rejected', N'dbuser', NULL, NULL)
INSERT [dbo].[Status] ([Id], [Status], [CreatedBy], [ModifiedBy], [ModifiedDate]) VALUES (8, N'Declined', N'dbuser', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Status] OFF
GO
/****** Object:  StoredProcedure [dbo].[Sp_GetAllCandidatesSkillSet]    Script Date: 11/12/2023 10:11:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE  [dbo].[Sp_GetAllCandidatesSkillSet]   
    AS   

    SET NOCOUNT ON;  
	 SELECT  [Id]
      ,[CandidateID]
      ,[SkillId]
	  ,S.SkillName AS SkillName
      ,[isPrimary]
  FROM [dbo].[Skillmatrix] [SM]
  INNER JOIN  [dbo].Skill S ON S.SkilId = SM.SkillId
  where isPrimary =1
   
GO
