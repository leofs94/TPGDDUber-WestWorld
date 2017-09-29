
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


-- TABLAS QUE FALTAN:
-- FACTURA(TIENE BOCHA DE FK'S), PAGO, RENDICION, ITEM, FACTURA_ITEM(ES UNA TABLA INTERMEDIA QUE SE GENERA), FORMA PAGO
-- LAS 5 TABLAS QUE CUBREN USUARIOS, ROLES Y FUNCIONALIDADES.
-- UN SALUDO AL HOMBRE PLAINING