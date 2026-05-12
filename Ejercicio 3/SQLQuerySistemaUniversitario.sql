CREATE DATABASE SistemaUniversitario;
GO
USE SistemaUniversitario;
GO

CREATE TABLE Estudiantes (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    Carrera NVARCHAR(100) NOT NULL,
    Promedio DECIMAL(4,2) NOT NULL
);