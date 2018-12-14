Create Database Autores
GO
USE Autores
GO
CREATE TABLE Autor(
id int IDENTITY (1,1) NOT NULL,
nombre varchar(100) NOT NULL,
Constraint PK_Autor PRIMARY KEY (id)
)
GO
CREATE TABLE Libro(
id int IDENTITY (1,1) NOT NULL,
titulo varchar(100) NOT NULL,
fecha_edicion date NOT NULL,
Constraint PK_Libro PRIMARY KEY (id)
)
GO
CREATE TABLE Autor_Libro(
id_autor int NOT NULL,
id_libro int NOT NULL,
Constraint FK_Autor FOREIGN KEY (id_autor) REFERENCES Autor (id),
Constraint FK_Libro FOREIGN KEY (id_libro) REFERENCES Libro (id),
)