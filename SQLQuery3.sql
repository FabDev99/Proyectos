-- Insertar datos en la tabla Empresa
INSERT INTO Empresa (Nombre, Direccion, Telefono)
VALUES 
    ('Tech Solutions', '1234 Tech Park', '555-1234'),
    ('Innovative Labs', '5678 Innovation Drive', '555-5678');

	SELECT * FROM Empresa;

	-- Insertar datos en la tabla Empleado
INSERT INTO Empleado (Nombre, Apellido, FechaNacimiento, Email, Telefono, EmpresaID)
VALUES 
    ('John', 'Doe', '1980-01-01', 'john.doe@example.com', '555-8765', 1),
    ('Jane', 'Smith', '1990-02-02', 'jane.smith@example.com', '555-4321', 2);

	SELECT * FROM Empleado;
