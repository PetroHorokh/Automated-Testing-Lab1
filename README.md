# Calculator

## Script for table 

CREATE TABLE [***Schema***].[***Name of table***](
[Input] [nchar](1) NOT NULL,
[Output] [int] NOT NULL
) ON [PRIMARY]
GO

INSERT [***Schema***].[***Name of table***] ([Input], [Output]) VALUES (N'(', 0)
GO

INSERT [***Schema***].[***Name of table***] ([Input], [Output]) VALUES (N')', 0)
GO

INSERT [***Schema***].[***Name of table***] ([Input], [Output]) VALUES (N'+', 1)
GO

INSERT [***Schema***].[***Name of table***] ([Input], [Output]) VALUES (N'-', 1)
GO

INSERT [***Schema***].[***Name of table***] ([Input], [Output]) VALUES (N'*', 2)
GO

INSERT [***Schema***].[***Name of table***] ([Input], [Output]) VALUES (N'/', 2)
GO

INSERT [***Schema***].[***Name of table***] ([Input], [Output]) VALUES (N'm', 4)
GO

INSERT [***Schema***].[***Name of table***] ([Input], [Output]) VALUES (N'p', 4)
GO

INSERT [***Schema***].[***Name of table***] ([Input], [Output]) VALUES (N'%', 3)
GO

INSERT [***Schema***].[***Name of table***] ([Input], [Output]) VALUES (N'k', 5)
GO

INSERT [***Schema***].[***Name of table***] ([Input], [Output]) VALUES (N',', 5)
GO
