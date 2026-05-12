CREATE DATABASE SistemaMedico;
GO

USE SistemaMedico;
GO

CREATE TABLE Pacientes (
    Id INT PRIMARY KEY IDENTITY(1,1), 
    Nombre NVARCHAR(100) NOT NULL,   
    Edad INT NOT NULL,               
    Diagnostico NVARCHAR(MAX) NOT NULL
);
GO