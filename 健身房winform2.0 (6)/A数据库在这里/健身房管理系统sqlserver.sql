CREAT DATABASE 健身房管理系统
GO
USE [健身房管理系统]
GO
/****** Object:  Table [dbo].[AccountPassword]    Script Date: 2021/1/21 19:21:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccountPassword](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CoachAccount] [nvarchar](50) NULL,
	[CoachPassword] [nvarchar](50) NULL,
	[iSRead] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[confirm]    Script Date: 2021/1/21 19:21:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[confirm](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[confirm] [varchar](50) NULL,
	[datetimecon] [datetime] NULL,
	[isread] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[curriculum]    Script Date: 2021/1/21 19:21:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[curriculum](
	[curriculumTypeId] [int] IDENTITY(1,1) NOT NULL,
	[curriculumTypeName] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[curriculumTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Member]    Script Date: 2021/1/21 19:21:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Member](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Membername] [varchar](20) NULL,
	[MemberGender] [char](2) NULL,
	[MemberAddress] [varchar](40) NULL,
	[curriculumTypeId] [int] NULL,
	[DaysRemaining] [int] NULL,
	[Isclear] [int] NULL,
	[cardnumber] [int] NULL,
	[income] [int] NULL,
	[CoachAccount] [nvarchar](50) NULL,
	[CoachPassword] [nvarchar](50) NULL,
	[iSRead] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[confirm] ON 

INSERT [dbo].[confirm] ([ID], [confirm], [datetimecon], [isread]) VALUES (12, N'453', CAST(N'2021-01-11T14:33:19.000' AS DateTime), 1)
INSERT [dbo].[confirm] ([ID], [confirm], [datetimecon], [isread]) VALUES (13, N'PP', CAST(N'2021-01-12T13:40:09.000' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[confirm] OFF
SET IDENTITY_INSERT [dbo].[curriculum] ON 

INSERT [dbo].[curriculum] ([curriculumTypeId], [curriculumTypeName]) VALUES (1, N'力量训练')
INSERT [dbo].[curriculum] ([curriculumTypeId], [curriculumTypeName]) VALUES (2, N'瑜伽训练')
SET IDENTITY_INSERT [dbo].[curriculum] OFF
SET IDENTITY_INSERT [dbo].[Member] ON 

INSERT [dbo].[Member] ([ID], [Membername], [MemberGender], [MemberAddress], [curriculumTypeId], [DaysRemaining], [Isclear], [cardnumber], [income], [CoachAccount], [CoachPassword], [iSRead]) VALUES (56, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'55', N'55', 1)
INSERT [dbo].[Member] ([ID], [Membername], [MemberGender], [MemberAddress], [curriculumTypeId], [DaysRemaining], [Isclear], [cardnumber], [income], [CoachAccount], [CoachPassword], [iSRead]) VALUES (57, N'1', N'1 ', N'1', 1, 1, 0, 2, 600, NULL, NULL, NULL)
INSERT [dbo].[Member] ([ID], [Membername], [MemberGender], [MemberAddress], [curriculumTypeId], [DaysRemaining], [Isclear], [cardnumber], [income], [CoachAccount], [CoachPassword], [iSRead]) VALUES (58, N'5', N'5 ', N'5', 2, 5, 1, 5, 1500, NULL, NULL, NULL)
INSERT [dbo].[Member] ([ID], [Membername], [MemberGender], [MemberAddress], [curriculumTypeId], [DaysRemaining], [Isclear], [cardnumber], [income], [CoachAccount], [CoachPassword], [iSRead]) VALUES (59, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'666', N'666', 0)
INSERT [dbo].[Member] ([ID], [Membername], [MemberGender], [MemberAddress], [curriculumTypeId], [DaysRemaining], [Isclear], [cardnumber], [income], [CoachAccount], [CoachPassword], [iSRead]) VALUES (60, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'PP', N'PP', 1)
INSERT [dbo].[Member] ([ID], [Membername], [MemberGender], [MemberAddress], [curriculumTypeId], [DaysRemaining], [Isclear], [cardnumber], [income], [CoachAccount], [CoachPassword], [iSRead]) VALUES (61, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'7777', N'7777', 0)
INSERT [dbo].[Member] ([ID], [Membername], [MemberGender], [MemberAddress], [curriculumTypeId], [DaysRemaining], [Isclear], [cardnumber], [income], [CoachAccount], [CoachPassword], [iSRead]) VALUES (62, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'', N'', 0)
INSERT [dbo].[Member] ([ID], [Membername], [MemberGender], [MemberAddress], [curriculumTypeId], [DaysRemaining], [Isclear], [cardnumber], [income], [CoachAccount], [CoachPassword], [iSRead]) VALUES (63, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'4111', N'4111', 0)
INSERT [dbo].[Member] ([ID], [Membername], [MemberGender], [MemberAddress], [curriculumTypeId], [DaysRemaining], [Isclear], [cardnumber], [income], [CoachAccount], [CoachPassword], [iSRead]) VALUES (64, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'111', N'111', 0)
INSERT [dbo].[Member] ([ID], [Membername], [MemberGender], [MemberAddress], [curriculumTypeId], [DaysRemaining], [Isclear], [cardnumber], [income], [CoachAccount], [CoachPassword], [iSRead]) VALUES (65, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'1234', N'1234', 0)
INSERT [dbo].[Member] ([ID], [Membername], [MemberGender], [MemberAddress], [curriculumTypeId], [DaysRemaining], [Isclear], [cardnumber], [income], [CoachAccount], [CoachPassword], [iSRead]) VALUES (66, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N' 456', N' 456', 0)
INSERT [dbo].[Member] ([ID], [Membername], [MemberGender], [MemberAddress], [curriculumTypeId], [DaysRemaining], [Isclear], [cardnumber], [income], [CoachAccount], [CoachPassword], [iSRead]) VALUES (67, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'123456', N'123456', 0)
INSERT [dbo].[Member] ([ID], [Membername], [MemberGender], [MemberAddress], [curriculumTypeId], [DaysRemaining], [Isclear], [cardnumber], [income], [CoachAccount], [CoachPassword], [iSRead]) VALUES (68, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'shuxiang1', N'shuxiang1', 0)
INSERT [dbo].[Member] ([ID], [Membername], [MemberGender], [MemberAddress], [curriculumTypeId], [DaysRemaining], [Isclear], [cardnumber], [income], [CoachAccount], [CoachPassword], [iSRead]) VALUES (69, N'44545454213123231', N'男', N'河南省', 1, 5000, 1, 1, 300, NULL, NULL, NULL)
INSERT [dbo].[Member] ([ID], [Membername], [MemberGender], [MemberAddress], [curriculumTypeId], [DaysRemaining], [Isclear], [cardnumber], [income], [CoachAccount], [CoachPassword], [iSRead]) VALUES (70, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'22', N'22', 1)
SET IDENTITY_INSERT [dbo].[Member] OFF
ALTER TABLE [dbo].[Member]  WITH CHECK ADD FOREIGN KEY([curriculumTypeId])
REFERENCES [dbo].[curriculum] ([curriculumTypeId])
GO
