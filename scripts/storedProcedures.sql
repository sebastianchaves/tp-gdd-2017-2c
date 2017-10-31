USE [GD2C2017]
USE [GD2C2017]
GO
CREATE PROCEDURE [ROCKET_DATABASE].obtenerFuncionalidadesPorRol @rol int
AS
SELECT * 
FROM ROCKET_DATABASE.FUNCIONALIDADES f, ROCKET_DATABASE.ROL_FUNCIONALIDAD rf
WHERE f.id_funcionalidad = rf.id_funcionalidad and rf.id_rol = @rol;