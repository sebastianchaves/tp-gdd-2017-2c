USE [GD2C2017]
USE [GD2C2017]
GO
/****** Creando el esquema [ROCKET_DATABASE] ******/
CREATE SCHEMA [ROCKET_DATABASE] AUTHORIZATION [gd]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
print 'Creando tablas...';
CREATE TABLE [ROCKET_DATABASE].[CLIENTES](
	id_cliente int IDENTITY(1,1) PRIMARY KEY,
	dni int,
	apellido varchar(255) NOT NULL,
	nombre varchar(255) NOT NULL,
	fecha_nac datetime,
	mail varchar(255),
	direccion varchar(255),
	codigo_postal varchar(10),
	telefono varchar(20),
	habilitado bit
) ON [PRIMARY]
GO

CREATE TABLE [ROCKET_DATABASE].[TIPO_DEVOLUCION](
	id_tipo_devolucion int IDENTITY(1,1) primary key,
	nombre varchar(255) not null,
	descripcion varchar(255)
) ON [PRIMARY]
GO
CREATE TABLE [ROCKET_DATABASE].[RUBROS](
	id_rubro int IDENTITY(1,1) primary key,
	nombre varchar(255) not null,
	descripcion varchar(255)
) ON [PRIMARY]
GO
CREATE TABLE [ROCKET_DATABASE].[SUCURSALES](
	id_sucursal int IDENTITY(1,1) primary key,
	nombre varchar(255) not null,
	direccion varchar(255),
	codigo_postal varchar(10) not null unique,
	activo bit not null
) ON [PRIMARY]
GO
CREATE TABLE [ROCKET_DATABASE].[FORMAS_PAGO](
	id_forma_pago int IDENTITY(1,1) primary key,
	nombre varchar(255) not null,
	descripcion varchar(255)
) ON [PRIMARY]
GO
CREATE TABLE [ROCKET_DATABASE].[PAGOS](
	id_pago int IDENTITY(1,1) primary key,
	fecha_cobro datetime,
	importe decimal(8,2) not null,
	id_forma_pago int not null,
	id_sucursal int not null,
	FOREIGN KEY (id_forma_pago) REFERENCES ROCKET_DATABASE.FORMAS_PAGO (id_forma_pago)
	ON DELETE CASCADE  
    ON UPDATE CASCADE
) ON [PRIMARY]
GO
CREATE TABLE [ROCKET_DATABASE].[EMPRESAS](
	id_empresa int IDENTITY(1,1) primary key,
	cuit varchar(13) not null unique,
	nombre varchar(255) not null,
	direccion varchar(255),
	id_rubro int,
	activo bit not null,
	fecha_rendicion datetime,
	foreign key (id_rubro) references ROCKET_DATABASE.RUBROS(id_rubro)
) ON [PRIMARY]
GO
CREATE TABLE ROCKET_DATABASE.RENDICIONES(
	id_rendicion int IDENTITY(1,1) primary key,
	cantidad_facturas_rendidas int,
	fecha datetime,
	comision decimal(8,2),
	valor_total decimal (8,2),
	porcentaje int,
	id_empresa int not null,
	foreign key (id_empresa) references ROCKET_DATABASE.EMPRESAS(id_empresa)
) ON [PRIMARY]
GO
CREATE TABLE [ROCKET_DATABASE].[FACTURAS](
	id_factura int IDENTITY(1,1) primary key,
	nro_factura int,
	fecha_alta datetime,
	total decimal (8,2) not null,
	fecha_vencimiento datetime,
	id_rendicion int,
	id_cliente int,
	id_empresa int,
	foreign key (id_rendicion) references ROCKET_DATABASE.RENDICIONES(id_rendicion),
	foreign key (id_cliente) references ROCKET_DATABASE.CLIENTES(id_cliente),
	foreign key (id_empresa) references ROCKET_DATABASE.EMPRESAS(id_empresa)
) ON [PRIMARY]
GO
CREATE TABLE [ROCKET_DATABASE].[CONCEPTOS](
	id_concepto int IDENTITY(1,1) PRIMARY KEY,
	monto decimal (8,2),
	cantidad int,
	id_factura int not null,
	foreign key (id_factura) references ROCKET_DATABASE.FACTURAS(id_factura)
) ON [PRIMARY]
GO
CREATE TABLE [ROCKET_DATABASE].[DEVOLUCIONES](
	id_devolucion int IDENTITY(1,1) primary key,
	fecha datetime,
	id_tipo_devolucion int not null,
	motivo_devolucion varchar(255) not null,
	foreign key (id_tipo_devolucion) references ROCKET_DATABASE.tipo_devolucion(id_tipo_devolucion)
) ON [PRIMARY]
GO
CREATE TABLE [ROCKET_DATABASE].[PAGO_FACTURA](
	id_factura int,
	id_pago int,
	primary key (id_factura, id_pago),
	foreign key (id_factura) references ROCKET_DATABASE.FACTURAS(id_factura),
	foreign key (id_pago) references ROCKET_DATABASE.PAGOS(id_pago)
) ON [PRIMARY]
GO
CREATE TABLE [ROCKET_DATABASE].[DEVOLUCION_FACTURA](
	id_devolucion int,
	id_factura int,
	primary key (id_devolucion, id_factura),
	foreign key (id_devolucion) references ROCKET_DATABASE.DEVOLUCIONES(id_devolucion),
	foreign key (id_factura) references ROCKET_DATABASE.FACTURAS(id_factura)
) ON [PRIMARY]
GO
CREATE TABLE [ROCKET_DATABASE].[DEVOLUCION_RENDICION](
	id_devolucion int,
	id_rendicion int,
	primary key (id_devolucion, id_rendicion),
	foreign key (id_devolucion) references ROCKET_DATABASE.DEVOLUCIONES(id_devolucion),
	foreign key (id_rendicion) references ROCKET_DATABASE.RENDICIONES(id_rendicion)
) ON [PRIMARY]
GO
CREATE TABLE [ROCKET_DATABASE].[USUARIOS](
	id_usuario int IDENTITY(1,1) primary key,
	nombre varchar(255) unique not null,
	apellido varchar(255),
	contrasenia varchar(255),
	id_sucursal int,
	intentos int not null,
	habilitado bit not null,
	foreign key (id_sucursal) references ROCKET_DATABASE.SUCURSALES(id_sucursal)
) ON [PRIMARY]
GO
CREATE TABLE [ROCKET_DATABASE].[ROLES](
	id_rol int IDENTITY(1,1) primary key,
	nombre varchar(255) unique not null,
	descripcion varchar(255),
	habilitado bit not null
) ON [PRIMARY]
GO
CREATE TABLE [ROCKET_DATABASE].[USUARIO_ROLES](
	id_usuario int,
	id_rol int,
	primary key (id_usuario, id_rol),
	foreign key (id_usuario) references ROCKET_DATABASE.USUARIOS(id_usuario),
	foreign key (id_rol) references ROCKET_DATABASE.ROLES(id_rol)
) ON [PRIMARY]
GO
CREATE TABLE [ROCKET_DATABASE].[FUNCIONALIDADES](
	id_funcionalidad int IDENTITY(1,1) primary key,
	nombre varchar(255) not null,
	descripcion varchar(255)
) ON [PRIMARY]
GO
CREATE TABLE [ROCKET_DATABASE].[ROL_FUNCIONALIDAD](
	id_funcionalidad int,
	id_rol int,
	primary key (id_funcionalidad, id_rol),
	foreign key (id_funcionalidad) references ROCKET_DATABASE.FUNCIONALIDADES(id_funcionalidad),
	foreign key (id_rol) references ROCKET_DATABASE.ROLES(id_rol)
) ON [PRIMARY]
print 'Poblando tablas desde la tabla maestra...';