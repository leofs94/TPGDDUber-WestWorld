/*
Scripts Generados por el hombre del Oeste 0.1V
*/
CREATE TABLE "WEST_WORLD"."Cliente"  ( 
	"idCliente"   	bigint NOT NULL,
	"nombre"      	nvarchar(255) NOT NULL,
	"apellido"    	nvarchar(255) NOT NULL,
	"mail"        	nvarchar(255) NOT NULL,
	"direccion"   	nvarchar(255) NOT NULL,
	"codigoPostal"	nvarchar(255) NOT NULL,
	"DNI"         	numeric(15,5) NOT NULL,
	"telefono"    	numeric(15,5) NOT NULL,
	"fecha_nac"   	datetime NOT NULL,
	CONSTRAINT "id" PRIMARY KEY CLUSTERED("idCliente")
 ON [PRIMARY])
GO
CREATE TABLE "WEST_WORLD"."Empresa"  ( 
	"cuit"      	nvarchar(50) NOT NULL,
	"nombre"    	nvarchar(255) NOT NULL,
	"direccion" 	nvarchar(255) NOT NULL,
	"idRubro"   	numeric(15,5) NOT NULL,
	"habilitado"	bit NOT NULL,
	CONSTRAINT "idEmpresa" PRIMARY KEY NONCLUSTERED("cuit")
	WITH (
		DATA_COMPRESSION = NONE
	) ON [PRIMARY])
GO
CREATE TABLE "WEST_WORLD"."Factura"  ( 
	"numeroFactura"   	numeric(15,5) NOT NULL,
	"cliente"         	bigint NOT NULL,
	"empresa"         	nvarchar(50) NOT NULL,
	"fechaAlta"       	datetime NOT NULL,
	"fechaVencimiento"	datetime NOT NULL,
	"total"           	numeric(15,5) NOT NULL,
	"rendicion"       	bigint NULL,
	CONSTRAINT "facturaPK" PRIMARY KEY CLUSTERED("numeroFactura")
 ON [PRIMARY])
GO
CREATE TABLE "WEST_WORLD"."Factura_Item"  ( 
	"idItem"       	bigint NOT NULL,
	"numeroFactura"	numeric(15,5) NOT NULL,
	"monto"        	numeric(15,5) NOT NULL,
	"cantidad"     	numeric(15,5) NOT NULL,
	CONSTRAINT "FacturaItemPK" PRIMARY KEY CLUSTERED("idItem","numeroFactura")
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
CREATE TABLE "WEST_WORLD"."Item"  ( 
	"idItem"	bigint IDENTITY(1,1) NOT NULL,
	CONSTRAINT "itemPK" PRIMARY KEY CLUSTERED("idItem")
 ON [PRIMARY])
GO
CREATE TABLE "WEST_WORLD"."Pago"  ( 
	"idPago"          	bigint NOT NULL,
	"FechaCobro"      	datetime NOT NULL,
	"FechaVencimiento"	datetime NOT NULL,
	"empresa"         	nvarchar(50) NOT NULL,
	"cliente"         	bigint NOT NULL,
	"sucursal"        	numeric(15,5) NOT NULL,
	"importe"         	numeric(15,5) NOT NULL,
	"formaPago"       	bigint NOT NULL,
	CONSTRAINT "idPago" PRIMARY KEY CLUSTERED("idPago")
 ON [PRIMARY])
GO
CREATE TABLE "WEST_WORLD"."Rendicion"  ( 
	"idRendicion"       	bigint NOT NULL,
	"FechaRendicion"    	datetime NOT NULL,
	"cantidadFacturas"  	numeric(15,5) NOT NULL,
	"importe"           	numeric(15,5) NOT NULL,
	"empresa"           	nvarchar(50) NOT NULL,
	"porcentajeComision"	bigint NOT NULL,
	"importeTotal"      	numeric(15,5) NOT NULL,
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
	"idRubro"	bigint NOT NULL,
	"nombre" 	nvarchar(50) NOT NULL,
	CONSTRAINT "idRubro" PRIMARY KEY CLUSTERED("idRubro")
 ON [PRIMARY])
GO
CREATE TABLE "WEST_WORLD"."Sucursal"  ( 
	"idSucursal"  	bigint IDENTITY(1,1) NOT NULL,
	"nombre"      	nvarchar(50) NOT NULL,
	"direccion"   	nvarchar(50) NOT NULL,
	"codigoPostal"	numeric(15,5) NOT NULL,
	"habilitado"  	bit NOT NULL,
	"operador"    	bigint NOT NULL,
	CONSTRAINT "PKSucursal" PRIMARY KEY NONCLUSTERED("codigoPostal")
	WITH (
		DATA_COMPRESSION = NONE
	) ON [PRIMARY])
GO
CREATE TABLE "WEST_WORLD"."Usuario"  ( 
	"idUser"      	bigint NOT NULL,
	"user"        	nvarchar(50) NOT NULL,
	"pass"        	nvarchar(50) NOT NULL,
	"failedLogins"	int NOT NULL,
	CONSTRAINT "idUserPK" PRIMARY KEY CLUSTERED("idUser")
 ON [PRIMARY])
GO

ALTER TABLE "WEST_WORLD"."Cliente"
	ADD CONSTRAINT "mailunique"
	UNIQUE ("mail")
	WITH (
		DATA_COMPRESSION = NONE
	) ON [PRIMARY]
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
	REFERENCES "WEST_WORLD"."Empresa"("cuit")
	ON DELETE NO ACTION 
	ON UPDATE NO ACTION 
GO
ALTER TABLE "WEST_WORLD"."Factura"
	ADD CONSTRAINT "clienteFK"
	FOREIGN KEY("cliente")
	REFERENCES "WEST_WORLD"."Cliente"("idCliente")
	ON DELETE NO ACTION 
	ON UPDATE NO ACTION 
GO
ALTER TABLE "WEST_WORLD"."Factura_Item"
	ADD CONSTRAINT "nroFacturaFK"
	FOREIGN KEY("numeroFactura")
	REFERENCES "WEST_WORLD"."Factura"("numeroFactura")
	ON DELETE NO ACTION 
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
	ADD CONSTRAINT "FKSucursal"
	FOREIGN KEY("sucursal")
	REFERENCES "WEST_WORLD"."Sucursal"("codigoPostal")
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
	ADD CONSTRAINT "FkEmpresa"
	FOREIGN KEY("empresa")
	REFERENCES "WEST_WORLD"."Empresa"("cuit")
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
	REFERENCES "WEST_WORLD"."Empresa"("cuit")
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
