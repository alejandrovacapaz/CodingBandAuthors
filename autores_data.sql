USE [Autores]
GO
SET IDENTITY_INSERT [dbo].[Autor] ON 

INSERT [dbo].[Autor] ([id], [nombre]) VALUES (1, N'Andres Oppenheimer')
INSERT [dbo].[Autor] ([id], [nombre]) VALUES (2, N'Gabriel Garcia Marquez')
SET IDENTITY_INSERT [dbo].[Autor] OFF
SET IDENTITY_INSERT [dbo].[Libro] ON 

INSERT [dbo].[Libro] ([id], [titulo], [fecha_edicion]) VALUES (1, N'Cuentos Gaviota', CAST(N'2018-05-01' AS Date))
INSERT [dbo].[Libro] ([id], [titulo], [fecha_edicion]) VALUES (2, N'Cuentos Chinos', CAST(N'2018-06-01' AS Date))
SET IDENTITY_INSERT [dbo].[Libro] OFF
INSERT [dbo].[Autor_Libro] ([id_autor], [id_libro]) VALUES (1, 1)
INSERT [dbo].[Autor_Libro] ([id_autor], [id_libro]) VALUES (2, 1)
INSERT [dbo].[Autor_Libro] ([id_autor], [id_libro]) VALUES (2, 2)
