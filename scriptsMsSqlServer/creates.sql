
CREATE TABLE [WEST_WORLD].[Cliente]  ( 
	[idCliente]   	bigint  IDENTITY(1,1) NOT NULL,
	[nombre]      	nvarchar(255) NOT NULL,
	[apellido]    	nvarchar(255) NOT NULL,
	[mail]        	nvarchar(255) NOT NULL,
	[direccion]   	nvarchar(255) NOT NULL,
	[codigoPostal]	nvarchar(255) NOT NULL,
	[DNI]         	numeric(15,5) NOT NULL,
	[telefono]    	numeric(15,5) NOT NULL,
	[fecha_nac]   	datetime NOT NULL,
	[habilitado]	bit NOT NULL,
	CONSTRAINT [id] PRIMARY KEY CLUSTERED([idCliente])
 ON [PRIMARY])
GO
ALTER TABLE [WEST_WORLD].[Cliente]
	ADD CONSTRAINT [mailunique]
	UNIQUE ([mail])
	WITH (
		DATA_COMPRESSION = NONE
	) ON [PRIMARY]
GO
CREATE TABLE [WEST_WORLD].[Rubro]  ( 
	[idRubro]   	bigint IDENTITY(1,1) NOT NULL,
	[nombre]      	nvarchar(50) NOT NULL,
	CONSTRAINT [idRubro] PRIMARY KEY ([idRubro])
 ON [PRIMARY])
 GO
 CREATE TABLE [WEST_WORLD].[Empresa]  ( 
	[cuit]      	nvarchar(50) NOT NULL,
	[nombre]    	nvarchar(255) NOT NULL,
	[direccion] 	nvarchar(255) NOT NULL,
	[idRubro]   	numeric(15,5) NOT NULL,
	[habilitado]	bit NOT NULL,
	CONSTRAINT [idEmpresa] PRIMARY KEY NONCLUSTERED([cuit])
)
GO
ALTER TABLE [WEST_WORLD].[Empresa]
	ADD CONSTRAINT [rubroFK]
	FOREIGN KEY([idRubro])
	REFERENCES [WEST_WORLD].[Rubro]([idRubro])
	
GO
CREATE TABLE [WEST_WORLD].[Sucursal]  ( 
	[idSucursal]  	numeric(15,5) IDENTITY(1,1) NOT NULL,
	[nombre]      	nvarchar(50) NOT NULL,
	[direccion]   	nvarchar(50) NOT NULL,
	[codigoPostal]	numeric(15,5) NOT NULL,
	[habilitado]  	bit NOT NULL,
	CONSTRAINT [PKSucursal] PRIMARY KEY NONCLUSTERED([codigoPostal])
)
GO
CREATE TABLE [WEST_WORLD].[Factura]  ( 
	[numeroFactura]   	numeric(15,5) NOT NULL,
	[cliente]         	bigint NOT NULL,
	[empresa]         	nvarchar(50) NOT NULL,
	[fechaAlta]       	datetime NOT NULL,
	[fechaVencimiento]	datetime NOT NULL,
	[total]           	numeric(15,5) NOT NULL,
	CONSTRAINT [facturaPK] PRIMARY KEY CLUSTERED([numeroFactura])
)
GO
ALTER TABLE [WEST_WORLD].[Factura]
	ADD CONSTRAINT [empresaFK]
	FOREIGN KEY([empresa])
	REFERENCES [WEST_WORLD].[Empresa]([cuit])
GO
ALTER TABLE [WEST_WORLD].[Factura]
	ADD CONSTRAINT [clienteFK]
	FOREIGN KEY([cliente])
	REFERENCES [WEST_WORLD].[Cliente]([idCliente])
GO
CREATE TABLE [WEST_WORLD].[Item]  ( 
	[idItem]	bigint IDENTITY(1,1) NOT NULL,
	CONSTRAINT [itemPK] PRIMARY KEY CLUSTERED([idItem])
)
GO
CREATE TABLE [WEST_WORLD].[Factura_Item]  ( 
	[idItem]       	bigint NOT NULL,
	[numeroFactura]	numeric(15,5) NOT NULL,
	[monto]        	numeric(15,5) NOT NULL,
	[cantidad]     	numeric(15,5) NOT NULL,
	CONSTRAINT [FacturaItemPK] PRIMARY KEY CLUSTERED([idItem],[numeroFactura])
)
GO
ALTER TABLE [WEST_WORLD].[Factura_Item]
	ADD CONSTRAINT [nroFacturaFK]
	FOREIGN KEY([numeroFactura])
	REFERENCES [WEST_WORLD].[Factura]([numeroFactura])
GO
ALTER TABLE [WEST_WORLD].[Factura_Item]
	ADD CONSTRAINT [itemFK]
	FOREIGN KEY([idItem])
	REFERENCES [WEST_WORLD].[Item]([idItem])

GO
CREATE TABLE [WEST_WORLD].[Usuario]  ( 
	[idUser]       	bigint NOT NULL,
	[user]	        nvarchar(50) NOT NULL UNIQUE,
	[pass]        	nvarchar(50) NOT NULL,
	[failedLogins]  int NOT NULL,
	CONSTRAINT [idUserPK] PRIMARY KEY CLUSTERED([idUser])
)



-- TABLAS QUE FALTAN:
-- PAGO, RENDICION,, FORMA PAGO
-- LAS 5 TABLAS QUE CUBREN USUARIOS, ROLES Y FUNCIONALIDADES.
-- UN SALUDO AL HOMBRE PLAINING