SET IDENTITY_INSERT [dbo].[Candidate] ON
INSERT INTO [dbo].[Candidate] ([Id], [FirstName ], [LastName ], [EmailID ], [PhoneNumber ], [Address], [PrimarySkill], [ModifiedBy], [ModifiedDate], [Active]) VALUES (1, N'Hari ', N'Kiran', N'h@gmail.com', CAST(123654789 AS Decimal(10, 0)), NULL, N'1,2,3     ', NULL, NULL, 1)
INSERT INTO [dbo].[Candidate] ([Id], [FirstName ], [LastName ], [EmailID ], [PhoneNumber ], [Address], [PrimarySkill], [ModifiedBy], [ModifiedDate], [Active]) VALUES (2, N'Sai', N'Ram', N'sai@gmail.com', CAST(123456987 AS Decimal(10, 0)), NULL, N'2,4       ', NULL, NULL, 1)
INSERT INTO [dbo].[Candidate] ([Id], [FirstName ], [LastName ], [EmailID ], [PhoneNumber ], [Address], [PrimarySkill], [ModifiedBy], [ModifiedDate], [Active]) VALUES (3, N'Radhika ', N'P', N'p@gmail.com', CAST(147853695 AS Decimal(10, 0)), NULL, N'3,5       ', NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Candidate] OFF
