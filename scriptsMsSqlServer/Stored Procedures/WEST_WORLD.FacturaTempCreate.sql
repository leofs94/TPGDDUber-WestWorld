CREATE PROCEDURE WEST_WORLD.FacturaTempCreate

AS
	IF OBJECT_ID('FacturaTemp') IS NULL

		CREATE TABLE #FacturaTemp  ( 
			"numeroFactura"   	bigint NOT NULL PRIMARY KEY,
			"cliente"         	bigint NULL,
			"empresa"         	bigint NULL,
			"fechaAlta"       	datetime NOT NULL,
			"FechaVencimiento"	datetime NOT NULL,
			"total"           	numeric(15,2) NOT NULL CHECK (total > 0),
			"rendicion"       	bigint,
			"pago"				bigint
		)
	ELSE 
		DELETE FROM #FacturaTemp