CREATE PROCEDURE WEST_WORLD.SucursalCreateOrUpdate
@mode nvarchar(10),
@idSucursal bigint,
@nombre nvarchar(50),
@direccion nvarchar(50),
@codigoPostal nvarchar(50),
@habilitado bit,
@operador bigint

AS
	IF @mode='Add'
	BEGIN
		INSERT INTO WEST_WORLD.Sucursal(
			nombre, 
			direccion, 
			codigoPostal, 
			habilitado,
			operador
		)
		VALUES(
			@nombre,
			@direccion,
			@codigoPostal,
			@habilitado,
			@operador
		)
	END
	ELSE IF @mode ='Edit'
	BEGIN
		UPDATE WEST_WORLD.Sucursal
		SET nombre=@nombre,
			direccion=@direccion, 
			codigoPostal=@codigoPostal, 
			habilitado=@habilitado,
			operador=@operador
		WHERE idSucursal=@idSucursal
	END	

RETURN 0