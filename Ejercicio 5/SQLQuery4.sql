Create database ControlDeInventario;
go

USE ControlDeInventario;
GO

CREATE TABLE Inventario (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Producto NVARCHAR(100) NOT NULL,
    Categoria NVARCHAR(50) NOT NULL,
    Cantidad INT NOT NULL,
    PrecioCompra DECIMAL(10,2) NOT NULL
);
GO