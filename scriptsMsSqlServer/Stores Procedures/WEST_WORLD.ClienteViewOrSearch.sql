CREATE PROCEDURE WEST_WORLD.ClienteViewOrSearch
	@nombre nvarchar(255),
	@apellido nvarchar(255),
	@dni numeric(15)
AS
	SELECT *
	FROM WEST_WORLD.Cliente
	WHERE nombre LIKE @nombre + '%' 
			AND apellido LIKE @apellido + '%' 
			 AND (@dni     IS NULL OR (DNI     = @dni    ))
        OPTION (RECOMPILE)
			
RETURN 0