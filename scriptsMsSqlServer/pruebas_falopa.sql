/* Pruebas falopa*/


SELECT *
FROM WEST_WORLD.Factura

execute insertUpdateCliente


SELECT *
FROM WEST_WORLD.Sucursal



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