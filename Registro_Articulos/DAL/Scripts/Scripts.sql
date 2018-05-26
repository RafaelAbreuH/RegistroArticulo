CREATE DATABASE ArticulosDb
GO
USE ArticulosDb
GO
CREATE TABLE Articulos
(
	ArticuloId int primary key identity,
	FechaVencimiento varchar(8),
	Descripcion varchar(25),
	Precio varchar(10),
	Existencia varchar(10),
	CantidadCotizada varchar(10)
	)