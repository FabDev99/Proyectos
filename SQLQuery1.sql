USE [EmpresaDB]
GO

SELECT [EmpleadoID]
      ,[Nombre]
      ,[Apellido]
      ,[FechaNacimiento]
      ,[Email]
      ,[Telefono]
      ,[EmpresaID]
  FROM [dbo].[Empleado]

GO

DELETE FROM Empresa WHERE NOMBRE = 'TECHSOLUTION';
DELETE FROM Empresa WHERE NOMBRE = 'INNOVATIVE LABS';

INSERT INTO Empresa (EmpresaID, Nombre, Direccion, Telefono)
VALUES (1, 'Tech Solutions', '1234 Tech Park', '555-1234'),
(2, 'Innovative Labs', '5678 Innovation Drive', '555-5678');

INSERT INTO Empleado (EmpleadoID, Nombre, Apellido, FechaNacimiento, Email, Telefono, EmpresaID)
VALUES (1, 'John', 'Doe', '1980-01-01', 'john.doe@example.com', '555-8765', 1),
(2, 'Jane', 'Smith', '1990-02-02', 'jane.smith@example.com', '555-4321', 2);


SELECT * FROM Empresa;


SELECT * FROM EmpLEADO;