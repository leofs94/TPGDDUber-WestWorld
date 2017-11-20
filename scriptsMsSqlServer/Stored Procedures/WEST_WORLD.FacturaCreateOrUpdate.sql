CREATE PROCEDURE WEST_WORLD.FacturaCreateOrUpdate
	@MODE nvarchar(10),
	@NUMEROFACTURA bigint,
	@CLIENTE bigint,
	@EMPRESA bigint,
	@FECHA_ALTA datetime,
	@FECHA_VENC datetime,
	@TOTAL numeric(15,2)

AS
	IF @mode='Add'
		BEGIN
			INSERT INTO WEST_WORLD.Factura(numeroFactura, cliente, empresa, fechaAlta, fechaVencimiento, total)
			VALUES(@NUMEROFACTURA, @CLIENTE, @EMPRESA, @FECHA_ALTA, @FECHA_VENC, @TOTAL)
			RETURN 0
		END
	ELSE IF @mode ='Edit'
		BEGIN
			IF EXISTS (SELECT * FROM WEST_WORLD.Factura
					WHERE numeroFactura=@NUMEROFACTURA AND pago IS NULL AND rendicion IS NULL)
				BEGIN
					UPDATE WEST_WORLD.Factura
					SET cliente=@CLIENTE, 
						empresa=@EMPRESA,
						fechaAlta=@FECHA_ALTA,
						fechaVencimiento=@FECHA_VENC,
						total=@TOTAL
					WHERE numeroFactura=@NUMEROFACTURA
					RETURN 0
				END
			ELSE
				RETURN -1
		END
RETURN 0

