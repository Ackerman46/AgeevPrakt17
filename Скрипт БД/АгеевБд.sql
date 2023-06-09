USE [AgeevBD]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 21.03.2023 18:10:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Family] [nvarchar](50) NOT NULL,
	[Frist name] [nvarchar](50) NOT NULL,
	[Last name] [nvarchar](50) NULL,
	[Group number] [smallint] NOT NULL,
	[academic discipline] [nvarchar](50) NOT NULL,
	[exercise
 num] [int] NOT NULL,
	[hard level] [smallint] NOT NULL,
	[grade] [smallint] NOT NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Students] ON 

INSERT [dbo].[Students] ([Id], [Family], [Frist name], [Last name], [Group number], [academic discipline], [exercise
 num], [hard level], [grade]) VALUES (15, N'Зуев', N'Глеб', N'Сергеевич', 33, N'РПМ', 9, 3, 1)
INSERT [dbo].[Students] ([Id], [Family], [Frist name], [Last name], [Group number], [academic discipline], [exercise
 num], [hard level], [grade]) VALUES (16, N'Агеев', N'Алексей', N'Олегович', 33, N'РПМ', 5, 2, 1)
INSERT [dbo].[Students] ([Id], [Family], [Frist name], [Last name], [Group number], [academic discipline], [exercise
 num], [hard level], [grade]) VALUES (17, N'Косаткин', N'Олег', N'Андреевич', 33, N'РПМ', 11, 3, 0)
INSERT [dbo].[Students] ([Id], [Family], [Frist name], [Last name], [Group number], [academic discipline], [exercise
 num], [hard level], [grade]) VALUES (18, N'Денисов', N'Олег', N'Капитошкович', 33, N'РПМ', 12, 3, 1)
INSERT [dbo].[Students] ([Id], [Family], [Frist name], [Last name], [Group number], [academic discipline], [exercise
 num], [hard level], [grade]) VALUES (19, N'Митрофанов', N'Роман', N'Симпович', 31, N'РПМ', 9, 3, 0)
INSERT [dbo].[Students] ([Id], [Family], [Frist name], [Last name], [Group number], [academic discipline], [exercise
 num], [hard level], [grade]) VALUES (20, N'Калитин', N'Сергей', N'Олегович', 32, N'ТтИПТ', 3, 2, 0)
INSERT [dbo].[Students] ([Id], [Family], [Frist name], [Last name], [Group number], [academic discipline], [exercise
 num], [hard level], [grade]) VALUES (21, N'Бадаев', N'Рамазан', N'Рашидович', 31, N'ССиТС', 10, 1, 0)
INSERT [dbo].[Students] ([Id], [Family], [Frist name], [Last name], [Group number], [academic discipline], [exercise
 num], [hard level], [grade]) VALUES (22, N'Халимов', N'Виктор', N'Денисович', 32, N'ТтИПТ', 20, 3, 1)
INSERT [dbo].[Students] ([Id], [Family], [Frist name], [Last name], [Group number], [academic discipline], [exercise
 num], [hard level], [grade]) VALUES (23, N'Гранин', N'Максим', N'Леонидович', 31, N'РПМ', 1, 3, 0)
INSERT [dbo].[Students] ([Id], [Family], [Frist name], [Last name], [Group number], [academic discipline], [exercise
 num], [hard level], [grade]) VALUES (24, N'Десятов', N'Владимир', N'Анатольевич', 32, N'СиТС', 4, 3, 1)
SET IDENTITY_INSERT [dbo].[Students] OFF
GO
