CREATE PROCEDURE [ROCKET_DATABASE].rendirEmpresa   
    @id_empresa int,
	@mes int,
	@anio int,
	@porcentaje decimal
AS   
	declare @cantFacturas int;
	declare @importeTotal int;
	declare @comision int;
	declare @dia int;
	declare @idRendicion int;
	declare @idRendicionTable table
	(
	  id_rendicion int
	);
	declare @idFacturaTable table
	(
	  id_factura int,
	  total decimal(8,2)
	);

	select @dia=dia_de_rendicion from ROCKET_DATABASE.EMPRESAS e where e.id_empresa = @id_empresa;

	insert into @idFacturaTable
	select f.id_factura, f.total
	from ROCKET_DATABASE.FACTURAS f, ROCKET_DATABASE.PAGO_FACTURA pf, ROCKET_DATABASE.PAGOS p 
	where f.id_factura = pf.id_factura and pf.id_pago = p.id_pago and year(p.fecha_cobro) = @anio and month(p.fecha_cobro) = @mes
	and f.id_rendicion is null and f.id_empresa = @id_empresa;

	select @cantFacturas = count(1) from @idFacturaTable;
	select @importeTotal = sum(total) from @idFacturaTable;

	set @comision = @importeTotal / 100 * @porcentaje;

	insert into ROCKET_DATABASE.RENDICIONES 
	OUTPUT inserted.id_rendicion into @idRendicionTable
	values (@cantFacturas, 
	convert(datetime, cast(@anio as varchar(4)) + '-' + cast(@mes as varchar(2)) + cast(@dia as varchar(2)))
	, @comision, @importeTotal, @porcentaje, @id_empresa);

	select @idRendicion=id_rendicion from @idRendicionTable;

	update ROCKET_DATABASE.FACTURAS set id_rendicion = @idRendicion where id_factura in
	(select id_factura from @idFacturaTable);

GO  