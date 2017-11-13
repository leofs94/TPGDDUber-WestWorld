CREATE PROCEDURE WEST_WORLD.ClienteCreateOrUpdate
@mode nvarchar(10),
@idCliente bigint,
@nombre nvarchar(255),
@apellido nvarchar(255),
@mail nvarchar(255),
@direccion nvarchar(255),
@codigoPostal nvarchar(255),
@dni numeric(15,0),
@telefono numeric(15,0),
@fec_nac dateTime,
@habilitado bit


AS
	IF @mode='Add'
	BEGIN
		INSERT INTO WEST_WORLD.Cliente(
			nombre, 
			apellido, 
			mail ,
			direccion, 
			codigoPostal, 
			dni, 
			telefono, 
			fecha_nac,
			habilitado
		)
		VALUES(
			@nombre,
			@apellido,
			@mail,
			@direccion,
			@codigoPostal,
			@dni,
			@telefono,
			@fec_nac,
			@habilitado
		)
	END
	ELSE IF @mode ='Edit'
	BEGIN
		UPDATE WEST_WORLD.Cliente
		SET nombre=@nombre, 
			apellido=@apellido, 
			mail=@mail ,
			direccion=@direccion, 
			codigoPostal=@codigoPostal, 
			dni=@dni, 
			telefono=@telefono, 
			fecha_nac=@fec_nac,
			habilitado=@habilitado
		WHERE idCliente=@idCliente
	END
		
		

RETURN 0