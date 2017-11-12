CREATE PROCEDURE WEST_WORLD.GetClientes
AS
	BEGIN 
		SELECT idCliente, nombre, apellido
		FROM WEST_WORLD.Cliente
	END