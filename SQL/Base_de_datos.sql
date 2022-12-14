/****** Object:  Database [Registro_Vehiculo]    Script Date: 12/23/2022 6:31:56 PM ******/
CREATE DATABASE [Registro_Vehiculo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Registro_Vehiculo', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Registro_Vehiculo.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Registro_Vehiculo_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Registro_Vehiculo_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Registro_Vehiculo] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Registro_Vehiculo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Registro_Vehiculo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Registro_Vehiculo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Registro_Vehiculo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Registro_Vehiculo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Registro_Vehiculo] SET ARITHABORT OFF 
GO
ALTER DATABASE [Registro_Vehiculo] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Registro_Vehiculo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Registro_Vehiculo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Registro_Vehiculo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Registro_Vehiculo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Registro_Vehiculo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Registro_Vehiculo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Registro_Vehiculo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Registro_Vehiculo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Registro_Vehiculo] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Registro_Vehiculo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Registro_Vehiculo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Registro_Vehiculo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Registro_Vehiculo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Registro_Vehiculo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Registro_Vehiculo] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Registro_Vehiculo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Registro_Vehiculo] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Registro_Vehiculo] SET  MULTI_USER 
GO
ALTER DATABASE [Registro_Vehiculo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Registro_Vehiculo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Registro_Vehiculo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Registro_Vehiculo] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Registro_Vehiculo] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Registro_Vehiculo] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Registro_Vehiculo] SET QUERY_STORE = OFF
GO
USE [Registro_Vehiculo]
GO
/****** Object:  Table [dbo].[Canton]    Script Date: 12/23/2022 6:31:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Canton](
	[CODIGO_PROV] [smallint] NOT NULL,
	[CODIGO_CANTON] [smallint] NOT NULL,
	[DESCRIPCION_CANTON] [varchar](50) NOT NULL,
 CONSTRAINT [PK_CANTON] PRIMARY KEY CLUSTERED 
(
	[CODIGO_PROV] ASC,
	[CODIGO_CANTON] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clase]    Script Date: 12/23/2022 6:31:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clase](
	[Codigo_Clase] [smallint] NOT NULL,
	[Clase] [varchar](30) NOT NULL,
	[Consecutivo] [numeric](15, 0) NOT NULL,
 CONSTRAINT [PK_Clase] PRIMARY KEY CLUSTERED 
(
	[Codigo_Clase] ASC,
	[Clase] ASC,
	[Consecutivo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Distrito]    Script Date: 12/23/2022 6:31:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Distrito](
	[CODIGO_PROV] [smallint] NOT NULL,
	[CODIGO_CANTON] [smallint] NOT NULL,
	[CODIGO_DISTRITO] [smallint] NOT NULL,
	[DESCRIPCION_DISTRITO] [varchar](50) NOT NULL,
 CONSTRAINT [PK_DISTRITO] PRIMARY KEY CLUSTERED 
(
	[CODIGO_PROV] ASC,
	[CODIGO_CANTON] ASC,
	[CODIGO_DISTRITO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estado_Civil]    Script Date: 12/23/2022 6:31:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estado_Civil](
	[Codigo_Estado] [int] NOT NULL,
	[Descripcion_Estado] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Padron_Fisico]    Script Date: 12/23/2022 6:31:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Padron_Fisico](
	[CEDULA] [varchar](10) NOT NULL,
	[CODIGO_ELECTORAL] [varchar](6) NOT NULL,
	[RELLENO] [varchar](1) NOT NULL,
	[FECHACADUC] [datetime] NOT NULL,
	[JUNTA] [varchar](5) NOT NULL,
	[NOMBRE] [varchar](30) NOT NULL,
	[APELLIDO1] [varchar](26) NOT NULL,
	[APELLIDO2] [varchar](26) NOT NULL,
 CONSTRAINT [PK_padron_provisional] PRIMARY KEY CLUSTERED 
(
	[CEDULA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Padron_Juridico]    Script Date: 12/23/2022 6:31:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Padron_Juridico](
	[Numero_Identificacion] [varchar](10) NOT NULL,
	[Nombre_Juridico] [varchar](300) NOT NULL,
 CONSTRAINT [PK_Padron_Juridico] PRIMARY KEY CLUSTERED 
(
	[Numero_Identificacion] ASC,
	[Nombre_Juridico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Propietario]    Script Date: 12/23/2022 6:31:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Propietario](
	[Tipo_Identificacion] [smallint] NOT NULL,
	[Numero_Identificacion] [varchar](30) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Primer_Apellido] [varchar](50) NULL,
	[Segundo_Apellido] [varchar](50) NULL,
	[Nombre_Juridico] [varchar](50) NULL,
	[Provincia] [smallint] NOT NULL,
	[Canton] [smallint] NOT NULL,
	[Distrito] [smallint] NOT NULL,
	[Direccion] [varchar](300) NULL,
	[Estado_Civil] [smallint] NOT NULL,
	[Correo_Electronico] [varchar](320) NULL,
 CONSTRAINT [PK_Propietario] PRIMARY KEY CLUSTERED 
(
	[Tipo_Identificacion] ASC,
	[Numero_Identificacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provincia]    Script Date: 12/23/2022 6:31:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provincia](
	[CODIGO_PROV] [smallint] NOT NULL,
	[DESCRIPCION_PROVINCIA] [varchar](50) NOT NULL,
 CONSTRAINT [PK_PROVINCIA] PRIMARY KEY CLUSTERED 
(
	[CODIGO_PROV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 12/23/2022 6:31:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Correo] [varchar](30) NOT NULL,
	[Clave] [varchar](30) NOT NULL,
	[Nombre] [varchar](30) NOT NULL,
	[Tipo_Usuario] [varchar](5) NOT NULL,
 CONSTRAINT [PK_Usuario_1] PRIMARY KEY CLUSTERED 
(
	[Correo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehiculo]    Script Date: 12/23/2022 6:31:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehiculo](
	[Tipo_Identificacion] [smallint] NOT NULL,
	[Numero_Identificacion] [varchar](30) NOT NULL,
	[Clase] [varchar](30) NOT NULL,
	[Numero_Placa] [numeric](15, 0) NOT NULL,
	[Numero_Chasis] [varchar](50) NOT NULL,
	[Numero_Motor] [varchar](50) NULL,
	[Color] [varchar](50) NOT NULL,
	[Estilo] [varchar](50) NOT NULL,
	[Anho] [smallint] NOT NULL,
	[Cilindraje] [smallint] NOT NULL,
	[Capacidad] [smallint] NOT NULL,
	[Combustible] [varchar](20) NOT NULL,
	[Marca] [varchar](30) NOT NULL,
	[Categoria] [varchar](30) NOT NULL,
	[Valor_Fiscal] [float] NOT NULL,
	[Serie] [varchar](50) NOT NULL,
	[Codigo_Clase] [smallint] NOT NULL,
 CONSTRAINT [PK_Vechiculo] PRIMARY KEY CLUSTERED 
(
	[Tipo_Identificacion] ASC,
	[Numero_Identificacion] ASC,
	[Clase] ASC,
	[Numero_Placa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Padron_Fisico] ADD  CONSTRAINT [DF_Padron_Fisico_RELLENO]  DEFAULT ((0)) FOR [RELLENO]
GO
ALTER TABLE [dbo].[Propietario] ADD  CONSTRAINT [DF_Propietario_Nombre]  DEFAULT ('') FOR [Nombre]
GO
ALTER TABLE [dbo].[Propietario] ADD  CONSTRAINT [DF_Propietario_Primer_Apellido]  DEFAULT ('') FOR [Primer_Apellido]
GO
ALTER TABLE [dbo].[Propietario] ADD  CONSTRAINT [DF_Propietario_Segundo_Apellido]  DEFAULT ('') FOR [Segundo_Apellido]
GO
ALTER TABLE [dbo].[Propietario] ADD  CONSTRAINT [DF_Propietario_Nombre_Juridico]  DEFAULT ('') FOR [Nombre_Juridico]
GO
ALTER TABLE [dbo].[Propietario] ADD  CONSTRAINT [DF_Propietario_Direccion]  DEFAULT ('') FOR [Direccion]
GO
ALTER TABLE [dbo].[Propietario] ADD  CONSTRAINT [DF_Propietario_Correo_Electronico]  DEFAULT ('') FOR [Correo_Electronico]
GO
ALTER TABLE [dbo].[Canton]  WITH CHECK ADD  CONSTRAINT [FK_CANTON_PROVINCIA] FOREIGN KEY([CODIGO_PROV])
REFERENCES [dbo].[Provincia] ([CODIGO_PROV])
GO
ALTER TABLE [dbo].[Canton] CHECK CONSTRAINT [FK_CANTON_PROVINCIA]
GO
ALTER TABLE [dbo].[Distrito]  WITH CHECK ADD  CONSTRAINT [FK_DISTRITO_CANTON] FOREIGN KEY([CODIGO_PROV], [CODIGO_CANTON])
REFERENCES [dbo].[Canton] ([CODIGO_PROV], [CODIGO_CANTON])
GO
ALTER TABLE [dbo].[Distrito] CHECK CONSTRAINT [FK_DISTRITO_CANTON]
GO
ALTER TABLE [dbo].[Propietario]  WITH CHECK ADD  CONSTRAINT [FK_Propietario_Distrito] FOREIGN KEY([Provincia], [Canton], [Distrito])
REFERENCES [dbo].[Distrito] ([CODIGO_PROV], [CODIGO_CANTON], [CODIGO_DISTRITO])
GO
ALTER TABLE [dbo].[Propietario] CHECK CONSTRAINT [FK_Propietario_Distrito]
GO
ALTER TABLE [dbo].[Vehiculo]  WITH CHECK ADD  CONSTRAINT [FK_Vehiculo_Clase] FOREIGN KEY([Codigo_Clase], [Clase], [Numero_Placa])
REFERENCES [dbo].[Clase] ([Codigo_Clase], [Clase], [Consecutivo])
GO
ALTER TABLE [dbo].[Vehiculo] CHECK CONSTRAINT [FK_Vehiculo_Clase]
GO
ALTER TABLE [dbo].[Vehiculo]  WITH CHECK ADD  CONSTRAINT [FK_Vehiculo_Propietario] FOREIGN KEY([Tipo_Identificacion], [Numero_Identificacion])
REFERENCES [dbo].[Propietario] ([Tipo_Identificacion], [Numero_Identificacion])
GO
ALTER TABLE [dbo].[Vehiculo] CHECK CONSTRAINT [FK_Vehiculo_Propietario]
GO
USE [master]
GO
ALTER DATABASE [Registro_Vehiculo] SET  READ_WRITE 
GO