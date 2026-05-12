CREATE DATABASE SistemaVentas;
GO

USE SistemaVentas;
GO


CREATE TABLE Ventas (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Cliente NVARCHAR(100) NOT NULL,
    Producto NVARCHAR(100) NOT NULL,
    Cantidad INT NOT NULL,
    Precio DECIMAL(18, 2) NOT NULL,
    
    TotalVenta AS (Cantidad * Precio) 
);
GO