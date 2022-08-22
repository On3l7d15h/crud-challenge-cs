Create Database miPrimeraVez
Use miPrimeraVez

--creación de la tabla Mercancías
Create Table Mercancías
(
	IdMercancía int Identity(1, 1),
	Descripción varchar(120) Not Null,
	Existencia bigint Default 0,
	Comentario text,
	Status varchar(10) Default 'Activa',
	NoEliminable bit Default 0,
	Primary Key Clustered (IdMercancía ASC),
	Index descripción(Descripción ASC) 
);

Drop Table Mercancías

--Introduciendo datos de prueba
Insert Into Mercancías
Values('Abrazaderas Flotantes', 100, 'Abrazaderas Flotantes de 6 pulgadas', 'Activa', 1),
	  ('Abrazaderas P/ Manguera', 400, 'Abrazaderas pequeñas para mangueras', 'Activa', 1)

Select * From Mercancías