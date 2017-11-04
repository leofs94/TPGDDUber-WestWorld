CREATE PROCEDURE WEST_WORLD.EmpresaCreateOrUpdate
@mode nvarchar(10),
@nombre nvarchar(255),
@cuit nvarchar(50),
@direccion nvarchar(255),
@idRubro bigint,
@habilitado bit

AS
	IF @mode='Add'
	BEGIN
		INSERT INTO WEST_WORLD.Empresa(
			nombre, 
			cuit, 
			direccion,
			idRubro, 
			habilitado
		)
		VALUES(
			@nombre,
			@cuit,
			@direccion,
			@idRubro,
			@habilitado
		)
	END
	ELSE IF @mode ='Edit'
	BEGIN
		UPDATE WEST_WORLD.Empresa
		SET nombre=@nombre, 
			cuit=@cuit,
			direccion=@direccion,
			idRubro=@idRubro,
			habilitado=@habilitado
		WHERE cuit=@cuit
	END

RETURN 0