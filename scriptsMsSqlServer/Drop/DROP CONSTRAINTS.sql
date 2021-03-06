ALTER TABLE "WEST_WORLD"."Usuario"
	DROP CONSTRAINT "UQ_Usuario"
GO
ALTER TABLE "WEST_WORLD"."Factura"
	DROP CONSTRAINT "empresaFK"
GO
ALTER TABLE "WEST_WORLD"."Factura"
	DROP CONSTRAINT "clienteFK"
GO
ALTER TABLE "WEST_WORLD"."Factura"
	DROP CONSTRAINT "rendicionFK"
GO
ALTER TABLE "WEST_WORLD"."Factura"
	DROP CONSTRAINT "pagoFK"
GO
ALTER TABLE "WEST_WORLD"."Item"
	DROP CONSTRAINT "nroFacturaFK"
GO
ALTER TABLE "WEST_WORLD"."Pago"
	DROP CONSTRAINT "sucursalFK"
GO
ALTER TABLE "WEST_WORLD"."Pago"
	DROP CONSTRAINT "FKFormaPago"
GO
ALTER TABLE "WEST_WORLD"."Pago"
	DROP CONSTRAINT "FKCliente"
GO
ALTER TABLE "WEST_WORLD"."Rendicion"
	DROP CONSTRAINT "empresaFK2"
GO
ALTER TABLE "WEST_WORLD"."Rol_Funcionalidad"
	DROP CONSTRAINT "FKRol"
GO
ALTER TABLE "WEST_WORLD"."Rol_Funcionalidad"
	DROP CONSTRAINT "FKFunc"
GO
ALTER TABLE "WEST_WORLD"."Rol_Usuario"
	DROP CONSTRAINT "UsuarioFK"
GO
ALTER TABLE "WEST_WORLD"."Rol_Usuario"
	DROP CONSTRAINT "RolFK"
GO
ALTER TABLE [WEST_WORLD].[Sucursal]
	DROP CONSTRAINT [FKoperador]
GO
ALTER TABLE [WEST_WORLD].[Empresa]
	DROP CONSTRAINT [rubroFK]
GO