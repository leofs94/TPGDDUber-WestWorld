CREATE PROCEDURE WEST_WORLD.EmpresaCreateOrUpdate
@mode nvarchar(10),
@idEmpresa bigint,
@nombre nvarchar(255),
@cuit nvarchar(50),
@direccion nvarchar(255),
@rubro bigint,
@habilitado bit

AS
	IF @mode='Add'
	BEGIN
		INSERT INTO WEST_WORLD.Empresa(
			nombre, 
			cuit, 
			direccion ,
			idRubro, 
			habilitado
		)
		VALUES(
			@nombre,
			@cuit,
			@direccion,
			@rubro,
			@habilitado
		)
	END
	--ELSE IF @mode ='Edit'
	--BEGIN
	--	UPDATE WEST_WORLD.Empresa
	--	SET nombre=@nombre, 
	--		apellido=@apellido, 
	--		mail=@mail ,
	--		direccion=@direccion, 
	--		codigoPostal=@codigoPostal, 
	--		dni=@dni, 
	--		telefono=@telefono, 
	--		fecha_nac=@fec_nac,
	--		habilitado=@habilitado
	--	WHERE idCliente=@idCliente
	--END

RETURN 0