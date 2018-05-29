use PROYECTO_CSHARP



CREATE PROC SP_BUSCAR_EMPLEADO_POR_ID
@ID INT
AS
BEGIN
SELECT        
	E.EMPLEADO_ID,
	E.APELLIDOS, 
	E.NOMBRE, 
	E.DNI, E.GENERO, 
	E.ESTADO_CIVIL,  
	E.DIRECCION,
	E.DISTRITO_ID, 
	P.PROVINCIA_ID, 
	DP.DEPARTAMENTO_ID              
FROM            EMPLEADOS AS E 
INNER JOIN
                         DISTRITOS D ON E.DISTRITO_ID = D.DISTRITO_ID INNER JOIN
                         PROVINCIAS P ON D.PROVINCIA_ID = P.PROVINCIA_ID INNER JOIN
                         DEPARTAMENTOS DP ON P.DEPARTAMENTO_ID = DP.DEPARTAMENTO_ID
WHERE E.EMPLEADO_ID = @ID
END


EXEC SP_BUSCAR_EMPLEADO_POR_ID 12


CREATE PROC SP_BUSCAR_TELEFONOS_POR_EMPLEADO_ID
@ID INT
AS
BEGIN
SELECT * FROM TELEFONOS WHERE EMPLEADO_ID = @ID
END


EXEC SP_BUSCAR_TELEFONOS_POR_EMPLEADO_ID 17

SELECT * FROM TELEFONOS
DELETE FROM TELEFONOS 


DELETE FROM EMPLEADOS

CREATE PROC SP_ACTUALIZAR_EMPLEADO
@APELLIDOS VARCHAR(100),
@NOMBRE VARCHAR(60),
@DNI VARCHAR(5) ,
@GENERO VARCHAR(30) ,
@ESTADO_CIVIL VARCHAR(30),
@DIRECCION VARCHAR(300),
@DISTRITO_ID VARCHAR(7),
@EMPLEADO_ID INT
AS 
BEGIN
UPDATE       EMPLEADOS
SET                APELLIDOS = @APELLIDOS, NOMBRE = @NOMBRE, DNI = @DNI, GENERO = @GENERO, ESTADO_CIVIL = @ESTADO_CIVIL, DIRECCION = @DIRECCION, DISTRITO_ID = @DISTRITO_ID
WHERE EMPLEADO_ID = @EMPLEADO_ID
END