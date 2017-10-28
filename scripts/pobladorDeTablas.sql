/*** insertando clientes ***/
print 'Insertando clientes...'
insert into GD2C2017.rocket_database.clientes
select distinct [Cliente-Dni], [Cliente-Apellido], [Cliente-Nombre],
[Cliente-Fecha_Nac], Cliente_Mail, Cliente_Direccion, Cliente_Codigo_Postal, null, 1
from GD2C2017.gd_esquema.Maestra;
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

print 'Eliminando facturas que figuran sin rendicion pero tienen en una carga posterior...'
delete from GD2C2017.ROCKET_DATABASE.FACTURAS
where id_rendicion is null and nro_factura in
(select nro_factura from GD2C2017.ROCKET_DATABASE.FACTURAS where id_rendicion is not null)

select Pago_nro, Pago_Fecha, total, 
(select id_forma_pago from GD2C2017.ROCKET_DATABASE.FORMAS_PAGO 
where descripcion = FormaPagoDescripcion) as forma_pago,
(select id_sucursal from GD2C2017.ROCKET_DATABASE.SUCURSALES
where Sucursal_Nombre = nombre) as sucursal
from GD2C2017.gd_esquema.Maestra
where Pago_nro is not null
order by Pago_nro

select * from GD2C2017.gd_esquema.Maestra where FormaPagoDescripcion is not null
select * from GD2C2017.ROCKET_DATABASE.FORMAS_PAGO 