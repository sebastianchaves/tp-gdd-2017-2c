/*** insertando clientes ***/
print 'Insertando clientes...'
insert into GD2C2017.rocket_database.clientes
select distinct [Cliente-Apellido], [Cliente-Nombre], [Cliente-Fecha_Nac], Cliente_Mail, Cliente_Direccion,
Cliente_Codigo_Postal, null, 1
from GD2C2017.gd_esquema.Maestra;

/*** insertando rubros ***/
print 'Insertando rubros...'
GO
set identity_insert GD2C2017.rocket_database.rubros ON;
GO
insert into GD2C2017.rocket_database.rubros (id_rubro, nombre, descripcion)
select distinct Empresa_Rubro, null, Rubro_Descripcion
from GD2C2017.gd_esquema.Maestra;
set identity_insert GD2C2017.rocket_database.rubros OFF;

/*** insertando empresas ***/
print 'Insertando empresas...'
insert into GD2C2017.rocket_database.empresas
select distinct Empresa_Cuit, Empresa_Nombre, Empresa_Direccion, Empresa_Rubro, 1
from GD2C2017.gd_esquema.Maestra;

