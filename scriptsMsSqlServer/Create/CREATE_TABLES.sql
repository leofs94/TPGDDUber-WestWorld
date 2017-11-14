/*
Scripts Generados por el hombre del Oeste 0.1V
*/
CREATE TABLE "WEST_WORLD"."Cliente"( 
	"idCliente"   	BIGINT IDENTITY(1,1) NOT NULL,
	"nombre"      	nvarchar(255) NOT NULL,
	"apellido"    	nvarchar(255) NOT NULL,
	"mail"        	nvarchar(255) NOT NULL UNIQUE,
	"direccion"   	nvarchar(255) NOT NULL,
	"codigoPostal"	nvarchar(255) NOT NULL,
	"DNI"         	numeric(15) NOT NULL,
	"telefono"    	numeric(15) NOT NULL,
	"fecha_nac"   	datetime NOT NULL,
	"habilitado"	bit NOT NULL,
	CONSTRAINT "id" PRIMARY KEY CLUSTERED("idCliente")
 ON [PRIMARY])
GO
CREATE TABLE "WEST_WORLD"."Empresa" (
	"idEmpresa"		bigint IDENTITY(1,1) NOT NULL, 
	"cuit"      	nvarchar(50) NOT NULL,
	"nombre"    	nvarchar(255) NOT NULL,
	"direccion" 	nvarchar(255) NOT NULL,
	"idRubro"   	BIGINT NOT NULL,
	"habilitado"	bit NOT NULL,
	CONSTRAINT "empresaPK" PRIMARY KEY NONCLUSTERED("idEmpresa")
ON [PRIMARY])
GO
CREATE TABLE "WEST_WORLD"."Factura"  ( 
	"numeroFactura"   	bigint NOT NULL,
	"cliente"         	bigint NULL,
	"empresa"         	bigint NULL,
	"fechaAlta"       	datetime NOT NULL,
	"FechaVencimiento"	datetime NOT NULL CHECK(FechaVencimiento <= SYSDATETIME()),
	"total"           	numeric(15,2) NOT NULL CHECK (total > 0),
	"rendicion"       	bigint NULL,
	"pago"				bigint NULL,
	CONSTRAINT "facturaPK" PRIMARY KEY CLUSTERED("numeroFactura")
 ON [PRIMARY])
GO
CREATE TABLE "WEST_WORLD"."Factura_Item"( 
	"idItem"       	bigint IDENTITY(1,1) NOT NULL,
	"numeroFactura"	bigint NOT NULL,
	"monto"         numeric(15,2) NOT NULL,
	"cantidad"     	smallint NOT NULL,
	"importe"		numeric(15,2) NOT NULL,
	CONSTRAINT "FacturaItemPK" PRIMARY KEY CLUSTERED("idItem","numeroFactura")
 ON [PRIMARY])
GO
CREATE TABLE "WEST_WORLD"."Item"  ( 
	"idItem"		bigint IDENTITY(1,1) NOT NULL,
	"descripcion"	nvarchar(255) NOT NULL,
	CONSTRAINT "itemPK" PRIMARY KEY CLUSTERED("idItem")
 ON [PRIMARY])
GO
CREATE TABLE "WEST_WORLD"."FormaPago"  ( 
	"idFormaPago"	bigint IDENTITY(1,1) NOT NULL,
	"descripcion"	nvarchar(50) NOT NULL,
	CONSTRAINT "idFormaPagoPK" PRIMARY KEY CLUSTERED("idFormaPago")
 ON [PRIMARY])
GO
CREATE TABLE "WEST_WORLD"."Funcionalidad"  ( 
	"idFuncionalidad"	bigint IDENTITY(1,1) NOT NULL,
	"nombre"         	nvarchar(50) NOT NULL,
	CONSTRAINT "idFuncPK" PRIMARY KEY CLUSTERED("idFuncionalidad")
 ON [PRIMARY])
GO
CREATE TABLE "WEST_WORLD"."Pago"  ( 
	"idPago"          	bigint IDENTITY(1,1) NOT NULL,
	"FechaCobro"      	datetime NOT NULL DEFAULT SYSDATETIME(),
	"cliente"         	bigint NOT NULL,
	"sucursal"        	bigint NOT NULL,
	"importe"         	numeric(15,2) NOT NULL CHECK(importe > 0),
	"formaPago"       	bigint NOT NULL,
	CONSTRAINT "idPagoPK" PRIMARY KEY CLUSTERED("idPago")
 ON [PRIMARY])
GO
CREATE TABLE "WEST_WORLD"."Rendicion"  ( 
	"idRendicion"       	bigint IDENTITY(1,1) NOT NULL,
	"FechaRendicion"    	datetime NOT NULL,
	"cantidadFacturas"  	smallint NOT NULL,
	"importe"           	numeric(15,2) NOT NULL,
	"empresa"           	bigint NOT NULL,
	"porcentajeComision"	bigint NOT NULL,
	"importeTotal"      	numeric(15,2) NOT NULL,
	CONSTRAINT "RendicionPK" PRIMARY KEY CLUSTERED("idRendicion")
 ON [PRIMARY])
GO
CREATE TABLE "WEST_WORLD"."Rol"  ( 
	"idRol"     	bigint IDENTITY(1,1) NOT NULL,
	"nombre"    	nvarchar(50) NOT NULL,
	"habilitado"	bit NOT NULL,
	CONSTRAINT "idRolPK" PRIMARY KEY CLUSTERED("idRol")
 ON [PRIMARY])
GO
CREATE TABLE "WEST_WORLD"."Rol_Funcionalidad"  ( 
	"idFuncionalidad"	bigint NOT NULL,
	"idRol"          	bigint NOT NULL,
	CONSTRAINT "RolFuncionalidadPK" PRIMARY KEY CLUSTERED("idFuncionalidad","idRol")
 ON [PRIMARY])
GO
CREATE TABLE "WEST_WORLD"."Rol_Usuario"  ( 
	"idUsuario"	bigint NOT NULL,
	"idRol"    	bigint NOT NULL,
	CONSTRAINT "RolUsuarioPK" PRIMARY KEY CLUSTERED("idUsuario","idRol")
 ON [PRIMARY])
GO
CREATE TABLE "WEST_WORLD"."Rubro"  ( 
	"idRubro"	bigint IDENTITY(1,1) NOT NULL,
	"nombre" 	nvarchar(50) NOT NULL,
	CONSTRAINT "idRubro" PRIMARY KEY CLUSTERED("idRubro")
 ON [PRIMARY])
GO
CREATE TABLE "WEST_WORLD"."Sucursal"  ( 
	"idSucursal"  	bigint IDENTITY(1,1) NOT NULL,
	"nombre"      	nvarchar(50) NOT NULL,
	"direccion"   	nvarchar(50) NOT NULL,
	"codigoPostal"	nvarchar(10) NOT NULL,
	"habilitado"  	bit NOT NULL,
	"operador"    	bigint NOT NULL,
	CONSTRAINT "PKSucursal" PRIMARY KEY NONCLUSTERED("idSucursal")
ON [PRIMARY])
GO
CREATE TABLE "WEST_WORLD"."Usuario"  ( 
	"idUser"      	bigint IDENTITY (1, 1) NOT NULL,
	"user"        	nvarchar(50) NOT NULL,
	"pass"        	BINARY (50) NOT NULL,
	"failedLogins"	int NOT NULL,
	CONSTRAINT "idUserPK" PRIMARY KEY CLUSTERED("idUser")
 ON [PRIMARY])
GO

ALTER TABLE "WEST_WORLD"."Usuario"
	ADD CONSTRAINT "UQ__Usuario__7FC76D7279515943"
	UNIQUE ("user")
	WITH (
		DATA_COMPRESSION = NONE
	) ON [PRIMARY]
GO
ALTER TABLE "WEST_WORLD"."Pago"
	ADD CONSTRAINT "CheckFecVenc" CHECK ([FechaVencimiento]<=getdate())
GO
ALTER TABLE "WEST_WORLD"."Factura"
	ADD CONSTRAINT "empresaFK"
	FOREIGN KEY("empresa")
	REFERENCES "WEST_WORLD"."Empresa"("idEmpresa")
	ON DELETE SET NULL 
	ON UPDATE NO ACTION 
GO
ALTER TABLE "WEST_WORLD"."Factura"
	ADD CONSTRAINT "clienteFK"
	FOREIGN KEY("cliente")
	REFERENCES "WEST_WORLD"."Cliente"("idCliente")
	ON DELETE SET NULL 
	ON UPDATE NO ACTION 
GO
ALTER TABLE "WEST_WORLD"."Factura_Item"
	ADD CONSTRAINT "nroFacturaFK"
	FOREIGN KEY("numeroFactura")
	REFERENCES "WEST_WORLD"."Factura"("numeroFactura")
	ON DELETE CASCADE
	ON UPDATE NO ACTION 
GO
ALTER TABLE "WEST_WORLD"."Factura_Item"
	ADD CONSTRAINT "itemFK"
	FOREIGN KEY("idItem")
	REFERENCES "WEST_WORLD"."Item"("idItem")
	ON DELETE NO ACTION 
	ON UPDATE NO ACTION 
GO
ALTER TABLE "WEST_WORLD"."Pago"
	ADD CONSTRAINT "sucursalFK"
	FOREIGN KEY("sucursal")
	REFERENCES "WEST_WORLD"."Sucursal"("idSucursal")
	ON DELETE NO ACTION 
	ON UPDATE NO ACTION 
GO
ALTER TABLE "WEST_WORLD"."Pago"
	ADD CONSTRAINT "FKFormaPago"
	FOREIGN KEY("formaPago")
	REFERENCES "WEST_WORLD"."FormaPago"("idFormaPago")
	ON DELETE NO ACTION 
	ON UPDATE NO ACTION 
GO
ALTER TABLE "WEST_WORLD"."Pago"
	ADD CONSTRAINT "FKCliente"
	FOREIGN KEY("cliente")
	REFERENCES "WEST_WORLD"."Cliente"("idCliente")
	ON DELETE NO ACTION 
	ON UPDATE NO ACTION 
GO
ALTER TABLE "WEST_WORLD"."Rendicion"
	ADD CONSTRAINT "empresaFK2"
	FOREIGN KEY("empresa")
	REFERENCES "WEST_WORLD"."Empresa"("idEmpresa")
	ON DELETE NO ACTION 
	ON UPDATE NO ACTION 
GO
ALTER TABLE "WEST_WORLD"."Rol_Funcionalidad"
	ADD CONSTRAINT "FKRol"
	FOREIGN KEY("idRol")
	REFERENCES "WEST_WORLD"."Rol"("idRol")
	ON DELETE NO ACTION 
	ON UPDATE NO ACTION 
GO
ALTER TABLE "WEST_WORLD"."Rol_Funcionalidad"
	ADD CONSTRAINT "FKFunc"
	FOREIGN KEY("idFuncionalidad")
	REFERENCES "WEST_WORLD"."Funcionalidad"("idFuncionalidad")
	ON DELETE NO ACTION 
	ON UPDATE NO ACTION 
GO
ALTER TABLE "WEST_WORLD"."Rol_Usuario"
	ADD CONSTRAINT "UsuarioFK"
	FOREIGN KEY("idUsuario")
	REFERENCES "WEST_WORLD"."Usuario"("idUser")
	ON DELETE NO ACTION 
	ON UPDATE NO ACTION 
GO
ALTER TABLE "WEST_WORLD"."Rol_Usuario"
	ADD CONSTRAINT "RolFK"
	FOREIGN KEY("idRol")
	REFERENCES "WEST_WORLD"."Rol"("idRol")
	ON DELETE NO ACTION 
	ON UPDATE NO ACTION 
GO
ALTER TABLE [WEST_WORLD].[Sucursal]
	ADD CONSTRAINT [FKoperador]
	FOREIGN KEY([operador])
	REFERENCES [WEST_WORLD].[Usuario]([idUser])
	ON DELETE NO ACTION 
	ON UPDATE NO ACTION 
GO
ALTER TABLE [WEST_WORLD].[Empresa]
	ADD CONSTRAINT [rubroFK]
	FOREIGN KEY([idRubro])
	REFERENCES [WEST_WORLD].[Rubro]([idRubro])
	ON DELETE NO ACTION 
	ON UPDATE NO ACTION 
GO
ALTER TABLE [WEST_WORLD].[Factura]
	ADD CONSTRAINT [rendicionFK]
	FOREIGN KEY([rendicion])
	REFERENCES [WEST_WORLD].[Rendicion]([idRendicion])
	ON DELETE NO ACTION 
	ON UPDATE NO ACTION 
GO
ALTER TABLE [WEST_WORLD].[Factura]
	ADD CONSTRAINT [pagoFK]
	FOREIGN KEY([pago])
	REFERENCES [WEST_WORLD].[Pago]([idPago])
	ON DELETE NO ACTION 
	ON UPDATE NO ACTION 
GO