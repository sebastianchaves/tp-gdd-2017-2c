/*** insertando clientes ***/
print 'Insertando clientes...'
insert into GD2C2017.rocket_database.clientes
select distinct [Cliente-Dni], [Cliente-Apellido], [Cliente-Nombre],
[Cliente-Fecha_Nac], Cliente_Mail, Cliente_Direccion, Cliente_Codigo_Postal, null, 1
from GD2C2017.gd_esquema.Maestra;
GO
print 'Buscado clientes con el mail repetido...'
update GD2C2017.rocket_database.clientes set mail = 'MAIL_INCORRECTO_' + CAST(dni AS varchar(20))
where dni in (
select min([Cliente-Dni]) as dniABorrar from
(
select distinct [Cliente-Dni], [Cliente-Apellido], [Cliente-Nombre],
[Cliente-Fecha_Nac], Cliente_Mail, Cliente_Direccion, Cliente_Codigo_Postal, null as telefono, 1 as habilitado
from GD2C2017.gd_esquema.Maestra) a
group by a.Cliente_Mail
having count(1)>1
);
print 'Aplicando constraint UNIQUE sobre el mail'
ALTER TABLE GD2C2017.rocket_database.clientes
ADD UNIQUE (mail);
GO

/*** insertando rubros ***/
print 'Insertando rubros...'
set identity_insert GD2C2017.rocket_database.rubros ON;
insert into GD2C2017.rocket_database.rubros (id_rubro, nombre, descripcion)
select distinct Empresa_Rubro, Rubro_Descripcion, Rubro_Descripcion
from GD2C2017.gd_esquema.Maestra;
set identity_insert GD2C2017.rocket_database.rubros OFF;
GO

/*** insertando formas de pago ***/
print 'Insertando metodos de pago'
insert into GD2C2017.ROCKET_DATABASE.FORMAS_PAGO 
select distinct FormaPagoDescripcion , FormaPagoDescripcion from GD2C2017.gd_esquema.Maestra
where FormaPagoDescripcion is not null;

/*** insertando empresas ***/
print 'Insertando empresas...'
insert into GD2C2017.rocket_database.empresas
select distinct Empresa_Cuit, Empresa_Nombre, Empresa_Direccion, Empresa_Rubro, 1
from GD2C2017.gd_esquema.Maestra;
GO

/*** insertando tipo_devolucion ***/
print 'Insertando tipo_devolucion...'
insert into GD2C2017.ROCKET_DATABASE.TIPO_DEVOLUCION
values ('Rendicion', 'Se devuelve una rendicion');
insert into GD2C2017.ROCKET_DATABASE.TIPO_DEVOLUCION
values ('Factura', 'Se devuelve la factura de un cliente');
GO

/*** insertando rendiciones ***/
print 'Insertando rendiciones...'
set identity_insert GD2C2017.rocket_database.rendiciones  ON;
insert into GD2C2017.rocket_database.rendiciones 
(id_rendicion, cantidad_facturas_rendidas, fecha, comision, valor_total, porcentaje, id_empresa)
select a.Rendicion_Nro, count(distinct a.ItemRendicion_nro) as total_facturas, 
max(a.Rendicion_Fecha) as fecha_rendicion, 0 as comision, 
sum(distinct a.ItemRendicion_Importe) as valor_total, 0 as porcentaje, a.id_empresa
from
( select Rendicion_nro, ItemRendicion_nro, Rendicion_fecha, ItemRendicion_importe, 
(select id_empresa from GD2C2017.ROCKET_DATABASE.EMPRESAS where nombre = empresa_nombre) as id_empresa
from GD2C2017.gd_esquema.Maestra where Rendicion_Nro is not null) a
group by a.Rendicion_Nro, a.id_empresa;
set identity_insert GD2C2017.rocket_database.rendiciones OFF;
GO

/*** insertando sucursales ***/
print 'Insertando sucursales...'
insert into GD2C2017.rocket_database.SUCURSALES 
(nombre, direccion, codigo_postal, activo)
select distinct Sucursal_Nombre, Sucursal_Dirección, Sucursal_Codigo_Postal, 1
from GD2C2017.gd_esquema.Maestra m
where Sucursal_Nombre is not null
GO
/*** insertando facturas ***/
print 'Insertando facturas...'
insert into GD2C2017.ROCKET_DATABASE.FACTURAS
select 
mm.Nro_Factura, mm.Factura_Fecha, mm.Factura_Total, mm.Factura_Fecha_Vencimiento, 
mm.Rendicion_Nro, 
(select id_cliente from GD2C2017.ROCKET_DATABASE.CLIENTES
where dni = [Cliente-Dni]) as cliente_id,
(select id_empresa from GD2C2017.ROCKET_DATABASE.EMPRESAS
where Empresa_Cuit = cuit) as empresa_id
from
(
select
distinct
Nro_Factura, Factura_Fecha, Factura_Total, Factura_Fecha_Vencimiento, Rendicion_Nro
, [Cliente-Dni], Empresa_Cuit
from GD2C2017.gd_esquema.Maestra m
where nro_factura is not null
group by 
Nro_Factura, Factura_Fecha, Factura_Total, Factura_Fecha_Vencimiento, Rendicion_Nro
, [Cliente-Dni], Empresa_Cuit
) mm
GO
print 'Eliminando facturas que figuran sin rendicion pero tienen en una carga posterior...'
delete from GD2C2017.ROCKET_DATABASE.FACTURAS
where id_rendicion is null and nro_factura in
(select nro_factura from GD2C2017.ROCKET_DATABASE.FACTURAS where id_rendicion is not null);
GO
/*** insertando pagos ***/
print 'Insertando pagos...'
set identity_insert GD2C2017.ROCKET_DATABASE.PAGOS ON;
insert into GD2C2017.ROCKET_DATABASE.PAGOS
(id_pago, fecha_cobro, importe, id_forma_pago, id_sucursal)
select distinct Pago_nro, Pago_Fecha, total, 
(select id_forma_pago from GD2C2017.ROCKET_DATABASE.FORMAS_PAGO 
where descripcion = FormaPagoDescripcion) as forma_pago,
(select id_sucursal from GD2C2017.ROCKET_DATABASE.SUCURSALES
where Sucursal_Nombre = nombre) as sucursal
from GD2C2017.gd_esquema.Maestra
where Pago_nro is not null
set identity_insert GD2C2017.ROCKET_DATABASE.PAGOS OFF;
GO
/*** insertando roles y funcionalidades ***/
print 'insertando funcionalidades...'

insert into ROCKET_DATABASE.ROLES values ('admin', 'Rol con permisos administrativos', 1);
insert into ROCKET_DATABASE.ROLES values ('cobrador', 'Rol de cobrador', 1);

insert into ROCKET_DATABASE.USUARIOS values ('admin', '', 'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7', null);
insert into ROCKET_DATABASE.USUARIOS values ('cobrador', '', 'fda9be620062a617156c1c6dbc788a6a204f85fe06e8ead0e3a43817b0e382db', 1);

insert into ROCKET_DATABASE.FUNCIONALIDADES values ('abm_rol', 'abm_rol')
insert into ROCKET_DATABASE.FUNCIONALIDADES values ('abm_cliente', 'abm_cliente');
insert into ROCKET_DATABASE.FUNCIONALIDADES values ('abm_empresa', 'abm_empresa');
insert into ROCKET_DATABASE.FUNCIONALIDADES values ('abm_sucursal', 'abm_sucursal');
insert into ROCKET_DATABASE.FUNCIONALIDADES values ('abm_factura', 'abm_factura');
insert into ROCKET_DATABASE.FUNCIONALIDADES values ('abm_pago', 'abm_pago');
insert into ROCKET_DATABASE.FUNCIONALIDADES values ('abm_rendicion', 'abm_rendicion');
insert into ROCKET_DATABASE.FUNCIONALIDADES values ('abm_estadisticas', 'abm_estadisticas');

insert into ROCKET_DATABASE.ROL_FUNCIONALIDAD values (1, 1);
insert into ROCKET_DATABASE.ROL_FUNCIONALIDAD values (2, 1);
insert into ROCKET_DATABASE.ROL_FUNCIONALIDAD values (3, 1);
insert into ROCKET_DATABASE.ROL_FUNCIONALIDAD values (4, 1);
insert into ROCKET_DATABASE.ROL_FUNCIONALIDAD values (5, 1);
insert into ROCKET_DATABASE.ROL_FUNCIONALIDAD values (6, 1);
insert into ROCKET_DATABASE.ROL_FUNCIONALIDAD values (7, 1);
insert into ROCKET_DATABASE.ROL_FUNCIONALIDAD values (8, 1);

insert into ROCKET_DATABASE.ROL_FUNCIONALIDAD values (5, 2);
insert into ROCKET_DATABASE.ROL_FUNCIONALIDAD values (6, 2);
insert into ROCKET_DATABASE.ROL_FUNCIONALIDAD values (7, 2);

insert into ROCKET_DATABASE.USUARIO_ROLES values (1, 1);
insert into ROCKET_DATABASE.USUARIO_ROLES values (2, 2);