CREATE PROCEDURE [ROCKET_DATABASE].rendirEmpresa   
    @id_empresa int,
	@dia int,
	@mes int,
	@anio int,
	@porcentaje decimal
AS   
	declare @cantFacturas int;
	declare @importeTotal decimal(12,2);
	declare @comision decimal(12,2);
	declare @diaString varchar(2);
	declare @mesString varchar(2);
	declare @idRendicion int;
	declare @tieneRendiciones int;
	declare @result int;
	declare @idRendicionTable table
	(
	  id_rendicion int
	);
	declare @idFacturaTable table
	(
	  id_factura int,
	  total decimal(12,2)
	);

	if @dia < 10
		set @diaString = '0' + cast(@dia as varchar(1));
	else
		set @diaString = cast(@dia as varchar(2));

	if @mes < 10
		set @mesString = '0' + cast(@mes as varchar(1));
	else
		set @mesString = cast(@mes as varchar(2));

	set @result = 0;

	select @tieneRendiciones = count(1) from ROCKET_DATABASE.RENDICIONES r
	where r.id_empresa = @id_empresa and year(r.fecha) = @anio
	and month(r.fecha) = @mes;

	insert into @idFacturaTable
	select f.id_factura, f.total
	from ROCKET_DATABASE.FACTURAS f, ROCKET_DATABASE.PAGO_FACTURA pf, ROCKET_DATABASE.PAGOS p 
	where f.id_factura = pf.id_factura and pf.id_pago = p.id_pago and year(p.fecha_cobro) = @anio and month(p.fecha_cobro) = @mes
	and f.id_rendicion is null and f.id_empresa = @id_empresa;

	select @cantFacturas = count(1) from @idFacturaTable;
	select @importeTotal = sum(total) from @idFacturaTable;

	if @cantFacturas = 0
		set @result = 2;
	if @tieneRendiciones > 0
		set @result = 1;

	if @porcentaje = 0
		set @comision = 0;
	else
		set @comision = @importeTotal / 100 * @porcentaje;

	if @cantFacturas > 0 and @tieneRendiciones = 0
		begin

			insert into ROCKET_DATABASE.RENDICIONES 
			OUTPUT inserted.id_rendicion into @idRendicionTable
			values (@cantFacturas, 
			convert(datetime, cast(@anio as varchar(4)) + '-' + @mesString + '-' + @diaString)
			, @comision, @importeTotal, @porcentaje, @id_empresa);

			select @idRendicion=id_rendicion from @idRendicionTable;

			update ROCKET_DATABASE.FACTURAS set id_rendicion = @idRendicion where id_factura in
			(select id_factura from @idFacturaTable);
		end;
		return @result;
GO  