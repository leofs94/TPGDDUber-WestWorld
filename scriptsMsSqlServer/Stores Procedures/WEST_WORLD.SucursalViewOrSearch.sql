CREATE PROCEDURE WEST_WORLD.SucursalViewOrSearch
	@nombre nvarchar(50),
	@direccion nvarchar(50),
	@codigoPostal numeric(15,5)
AS
	SELECT *
	FROM WEST_WORLD.Sucursal
	WHERE nombre LIKE @nombre + '%' 
			 AND direccion LIKE @direccion + '%'
			 AND (codigoPostal = @codigoPostal)
        OPTION (RECOMPILE)
RETURN 0