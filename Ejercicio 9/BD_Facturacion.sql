create database BD_facturacion
go

use BD_facturacion
go
CREATE TABLE Facturas
(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Cliente NVARCHAR(100) NOT NULL,
    Fecha DATETIME NOT NULL 
);

create table DetalleFactura(
Id INT PRIMARY KEY IDENTITY(1,1),
    FacturaId INT NOT NULL,
    Producto NVARCHAR(100) NOT NULL,
    Cantidad INT NOT NULL,
    Precio DECIMAL(10,2) NOT NULL,

    CONSTRAINT FK_DetalleFactura_Facturas
    FOREIGN KEY (FacturaId)
    REFERENCES Facturas(Id)
);