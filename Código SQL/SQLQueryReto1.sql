Create Database miPrimeraVez
Use miPrimeraVez

--creaci�n de la tabla Mercanc�as
Create Table Mercanc�as
(
	IdMercanc�a int Identity(1, 1),
	Descripci�n varchar(120) Not Null,
	Existencia bigint Default 0,
	Comentario text,
	Status varchar(10) Default 'Activa',
	NoEliminable bit Default 0,
	Primary Key Clustered (IdMercanc�a ASC),
	Index descripci�n(Descripci�n ASC) 
);

Drop Table Mercanc�as

--Introduciendo datos de prueba
Insert Into Mercanc�as
Values('Abrazaderas Flotantes', 100, 'Abrazaderas Flotantes de 6 pulgadas', 'Activa', 1),
	  ('Abrazaderas P/ Manguera', 400, 'Abrazaderas peque�as para mangueras', 'Activa', 1)

Select * From Mercanc�as