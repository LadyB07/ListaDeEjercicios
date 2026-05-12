Create database SistemaProductos;
go

Use SistemaProductos;
go

CREATE TABLE Productos (
    Id INT PRIMARY KEY IDENTITY(1,1), 
    Nombre NVARCHAR(100) NOT NULL,
    Precio DECIMAL(10,2) NOT NULL,
    Stock INT NOT NULL
);
go
