SET IDENTITY_INSERT [dbo].[Cars] ON
INSERT INTO [dbo].[Cars] ([CarId], [BrandId], [ColorId], [ModelYear], [DailyPrice], [Descriptions]) VALUES (1, 1, 2, 2011, CAST(850 AS Decimal(18, 0)), N'Kirada')
INSERT INTO [dbo].[Cars] ([CarId], [BrandId], [ColorId], [ModelYear], [DailyPrice], [Descriptions]) VALUES (3, 2, 4, 2018, CAST(1240 AS Decimal(18, 0)), N'Kiralik')
INSERT INTO [dbo].[Cars] ([CarId], [BrandId], [ColorId], [ModelYear], [DailyPrice], [Descriptions]) VALUES (5, 3, 1, 2006, CAST(350 AS Decimal(18, 0)), N'Kiralik')
INSERT INTO [dbo].[Cars] ([CarId], [BrandId], [ColorId], [ModelYear], [DailyPrice], [Descriptions]) VALUES (6, 4, 3, 2020, CAST(1500 AS Decimal(18, 0)), N'Kiralik')
SET IDENTITY_INSERT [dbo].[Cars] OFF
