INSERT INTO WEST_WORLD.Rubro(idRubro,nombre) 
			VALUES(1, 'Manijas')
INSERT INTO WEST_WORLD.Rubro(idRubro,nombre) 
			VALUES(2, 'Piedras')
INSERT INTO WEST_WORLD.Rubro(idRubro,nombre) 
			VALUES(3, 'Alquiler de pollos')

INSERT INTO WEST_WORLD.Empresa(cuit, nombre, direccion, idRubro, habilitado)
			VALUES(20305004000, 'Edesur', 'callao 3000', 2, 0)

INSERT INTO WEST_WORLD.Empresa
			VALUES(20000000001, 'TELECENTRO', 'santa fe 2500', 1, 0)

INSERT INTO WEST_WORLD.Empresa
			VALUES(20000000003, 'Cablevision', 'corrientes 1671', 3, 1)

INSERT INTO WEST_WORLD.Cliente(nombre, apellido, mail, direccion, codigoPostal, dni, telefono, fecha_nac, habilitado)
			VALUES('Juan', 'Perez', 'juan@perez.com', 'juancilandia', 1010, 40500600, 65546465, '20120618 10:34:09 AM', 1)
