USE Master;
DROP DATABASE Ventas;

CREATE DATABASE Ventas;
USE Ventas;

CREATE TABLE Vendedor(
	IdVendedor INT IDENTITY(1,1) PRIMARY KEY,
	Nombre VARCHAR(MAX) NOT NULL,
	Dui VARCHAR(10) NOT NULL,
	Sueldo DECIMAL NOT NULL
);

CREATE TABLE Ventas(
	IdVenta INT IDENTITY(1,1) PRIMARY KEY,
	IdVendedor INT FOREIGN KEY REFERENCES Vendedor(IdVendedor),
	Cantidad DECIMAL NOT NULL
);

INSERT INTO Vendedor(Nombre, Dui, Sueldo) VALUES
('Jonathan Escalante','12345678-9',365.00);

INSERT INTO Vendedor(Nombre, Dui, Sueldo) VALUES
('Juan Perez','98765432-0',420);

SELECT * FROM Vendedor;

INSERT INTO Ventas(IdVendedor,Cantidad) VALUES
(1,500);

INSERT INTO Ventas(IdVendedor,Cantidad) VALUES
(2,300);

SELECT * FROM Ventas;
