CREATE OR ALTER PROCEDURE insertUpdateCliente
AS 
BEGIN

	/*MIGRACION CLIENTE*/

	DECLARE @clienteNombre varchar(255), @clienteApellido varchar(255), @clienteMail varchar(255),
	@clienteDireccion varchar(255), @codigoPostal varchar, @dni bigint, @fec_nac datetime, @tel numeric(15,0), @habilitado bit

	
	DECLARE CustomerCursor Cursor FOR 
	SELECT DISTINCT [Cliente-Nombre], [Cliente-Apellido], Cliente_Mail, Cliente_Direccion, Cliente_Codigo_Postal, [Cliente-Dni], NULL, [Cliente-Fecha_Nac], 1
	FROM gd_esquema.Maestra

	OPEN CustomerCursor;

	FETCH NEXT FROM CustomerCursor
	INTO @clienteNombre,@clienteApellido,@clienteMail,@clienteDireccion,
	@codigoPostal,@dni,@tel,@fec_nac,@habilitado

	BEGIN TRANSACTION 
	WHILE @@FETCH_STATUS = 0
	BEGIN
		IF EXISTS(SELECT 1 from WEST_WORLD.Cliente WHERE mail=@clienteMail)
		BEGIN
			 update WEST_WORLD.Cliente SET nombre=@clienteNombre, apellido=@clienteApellido, mail=@clienteMail, 
			 direccion=@clienteDireccion, codigoPostal=@codigoPostal, DNI=@dni,fecha_nac=@fec_nac, habilitado=@habilitado
			where mail = @clienteMail
		END
		ELSE		
			begin
				insert into WEST_WORLD.Cliente (nombre, apellido, mail,direccion,codigoPostal,DNI,fecha_nac,telefono,habilitado) values 
				(@clienteNombre,@clienteApellido, @clienteMail, @clienteDireccion, @codigoPostal, @dni,@fec_nac, null, 1)
			end


			FETCH NEXT FROM CustomerCursor
			INTO @clienteNombre,@clienteApellido,@clienteMail,@clienteDireccion,
			@codigoPostal,@dni,@tel,@fec_nac,@habilitado
	END
	COMMIT TRANSACTION
	CLOSE CustomerCursor
	DEALLOCATE CustomerCursor

	-- Migrar rubro
	INSERT INTO WEST_WORLD.Rubro
	SELECT DISTINCT Rubro_Descripcion
	FROM gd_esquema.Maestra

	-- Migrar Empresa
	INSERT INTO WEST_WORLD.Empresa
	SELECT DISTINCT Empresa_Cuit, Empresa_Nombre, Empresa_Direccion, Empresa_Rubro, 1
	FROM gd_esquema.Maestra


	--Migrar Sucursal
	INSERT INTO WEST_WORLD.Sucursal
	SELECT DISTINCT Sucursal_Nombre, Sucursal_Dirección, Sucursal_Codigo_Postal, 1, NULL
	FROM gd_esquema.Maestra
	WHERE Sucursal_Codigo_Postal IS NOT NULL

	INSERT INTO WEST_WORLD.FormaPago
	SELECT DISTINCT FormaPagoDescripcion
	FROM gd_esquema.Maestra
	WHERE FormaPagoDescripcion IS NOT NULL


	--Migrar Pagos
	INSERT INTO WEST_WORLD.Pago
	SELECT DISTINCT Pago_nro, Pago_Fecha, Factura_Fecha_Vencimiento, We.idEmpresa, wc.idCliente, ws.idSucursal, Total, fp.idFormaPago
	FROM gd_esquema.Maestra
	JOIN WEST_WORLD.Empresa We ON (We.cuit = Empresa_Cuit)
	JOIN WEST_WORLD.Cliente wc ON (wc.DNI = [Cliente-Dni])
	JOIN WEST_WORLD.Sucursal ws ON (ws.codigoPostal = Sucursal_Codigo_Postal)
	JOIN WEST_WORLD.FormaPago fp ON (fp.descripcion = FormaPagoDescripcion)
	WHERE Pago_nro IS NOT NULL
	ORDER BY Pago_nro


	/*MIGRACION FACTURAS*/
	DECLARE @facturaNumero bigint, @idCliente bigint, @idEmpresa bigint,
		 @facturaFecha date, @Factura_Fecha_Vencimiento date,
	  @Factura_Total numeric(15,2), @rendicion bigint, @pago int

	DECLARE FacturaCursor Cursor FOR 
	SELECT DISTINCT Nro_Factura, w.idCliente, e.idEmpresa, Factura_Fecha, Factura_Fecha_Vencimiento, Factura_Total, Rendicion_Nro, Pago_nro
	FROM (SELECT DISTINCT Nro_Factura, Factura_Fecha, Factura_Total, Factura_Fecha_Vencimiento, Cliente_Mail, Empresa_Cuit, Pago_nro, Rendicion_Nro
		FROM gd_esquema.Maestra
		) as TablaTemp
	JOIN WEST_WORLD.Cliente w ON (w.mail = TablaTemp.Cliente_Mail)
	JOIN WEST_WORLD.Empresa e ON (e.cuit = TablaTemp.Empresa_Cuit)
	ORDER BY Nro_Factura ASC

	OPEN FacturaCursor;

	FETCH NEXT FROM FacturaCursor
	INTO @facturaNumero, @idCliente, @idEmpresa, @facturaFecha,
	@Factura_Fecha_Vencimiento, @Factura_Total, @rendicion, @pago
	
	BEGIN TRANSACTION 
	WHILE @@FETCH_STATUS = 0
	BEGIN
		IF(@pago is null AND @rendicion IS NULL)
		begin
		INSERT INTO WEST_WORLD.Factura (numeroFactura, cliente, empresa, fechaAlta, fechaVencimiento, total, rendicion, pago)
		VALUES (@facturaNumero, @idCliente, @idEmpresa, @facturaFecha,
				@Factura_Fecha_Vencimiento, @Factura_Total, @rendicion, @pago)
		end
		ELSE
		begin
		UPDATE WEST_WORLD.Factura
		SET rendicion = @rendicion, pago =  @pago
		WHERE numeroFactura = @facturaNumero
		end

		FETCH NEXT FROM FacturaCursor
	INTO @facturaNumero, @idCliente, @idEmpresa, @facturaFecha,
	@Factura_Fecha_Vencimiento, @Factura_Total, @rendicion, @pago
	
	END

	COMMIT TRANSACTION
	CLOSE FacturaCursor
	DEALLOCATE FacturaCursor





	
END






/* Pruebas falopa*/


SELECT *
FROM WEST_WORLD.Factura

execute insertUpdateCliente


SELECT *
FROM WEST_WORLD.Sucursal



ORDER BY Nro_Factura

--Select Rubro
SELECT DISTINCT Empresa_Rubro, Rubro_Descripcion
FROM gd_esquema.Maestra


-- Select Factura
SELECT DISTINCT Nro_Factura, idCliente, idEmpresa, Factura_Fecha, Factura_Fecha_Vencimiento, Factura_Total, Pago_nro, Rendicion_Nro
FROM (SELECT DISTINCT Nro_Factura, Factura_Fecha, Factura_Total, Factura_Fecha_Vencimiento, Cliente_Mail, Empresa_Cuit, Pago_nro, Rendicion_Nro
		FROM gd_esquema.Maestra
		) as TablaTemp
JOIN WEST_WORLD.Cliente w ON (w.mail = TablaTemp.Cliente_Mail)
JOIN WEST_WORLD.Empresa e ON (e.cuit = TablaTemp.Empresa_Cuit)
WHERE Pago_nro IS NULL AND Rendicion_Nro IS NULL
order by Nro_Factura

Select Nro_Factura, Pago_Nro, Rendicion_Nro
from gd_esquema.Maestra
WHERE Pago_Nro is null

Select distinct Nro_Factura, Pago_Nro, Rendicion_Nro
from gd_esquema.Maestra
WHERE Pago_Nro is null AND Rendicion_Nro IS NULL
order by Nro_Factura

order by Nro_Factura




SELECT *
FROM gd_esquema.Maestra


SELECT *
FROM WEST_WORLD.Pago

SELECT DISTINCT Pago_nro, Pago_Fecha, Factura_Fecha_Vencimiento, We.idEmpresa, wc.idCliente, ws.idSucursal, Total, fp.idFormaPago
FROM gd_esquema.Maestra
JOIN WEST_WORLD.Empresa We ON (We.cuit = Empresa_Cuit)
JOIN WEST_WORLD.Cliente wc ON (wc.DNI = [Cliente-Dni])
JOIN WEST_WORLD.Sucursal ws ON (ws.codigoPostal = Sucursal_Codigo_Postal)
JOIN WEST_WORLD.FormaPago fp ON (fp.descripcion = FormaPagoDescripcion)
WHERE Pago_nro IS NOT NULL
ORDER BY Pago_nro

SELECT Rendicion_Nro, Rendicion_Fecha, Count(DISTINCT Nro_Factura)
FROM gd_esquema.Maestra
GROUP BY Rendicion_Nro, Rendicion_Fecha
ORDER BY Count(DISTINCT Nro_Factura) desc

SELECT DISTINCT Rendicion_Nro, Rendicion_Fecha, ItemRendicion_Importe, ItemRendicion_nro, Nro_Factura, COUNT(MONTH(Rendicion_Fecha))
FROM gd_esquema.Maestra 
WHERE ItemRendicion_nro IS NOT NULL
group by Rendicion_Nro, Rendicion_Fecha, ItemRendicion_Importe, ItemRendicion_nro, Nro_Factura
ORDER BY Nro_Factura asc