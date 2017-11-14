CREATE PROCEDURE WEST_WORLD.PagoCreate
@FECHACOBRO datetime,
@IDCLIENTE bigint,
@IDSUCURSAL bigint,
@IMPORTE numeric(15,2),
@FORMADEPAGO nvarchar(50)

AS
	DECLARE @@idFormaPago int
	SET @@idFormaPago = (SELECT idFormaPago FROM WEST_WORLD.FormaPago WHERE descripcion like @FORMADEPAGO)
	
	IF (@@idFormaPago IS NULL)
		BEGIN
			INSERT INTO WEST_WORLD.FormaPago(descripcion) VALUES (@FORMADEPAGO)

			INSERT INTO WEST_WORLD.Pago(FechaCobro, cliente, sucursal, importe, formaPago)
					VALUES(@FECHACOBRO, @IDCLIENTE, @IDSUCURSAL, @IMPORTE, (select IDENT_CURRENT('WEST_WORLD.FormaPago')))
		END
	ELSE	
		BEGIN
			INSERT INTO WEST_WORLD.Pago(FechaCobro, cliente, sucursal, importe, formaPago)
				VALUES(@FECHACOBRO, @IDCLIENTE, @IDSUCURSAL, @IMPORTE, @@idFormaPago)
		END

RETURN  (select IDENT_CURRENT('WEST_WORLD.Pago'))