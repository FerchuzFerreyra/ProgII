USE [master]
GO
/****** Object:  Database [Veterinaria_2023]    Script Date: 28/8/2023 11:39:50 ******/
CREATE DATABASE [Veterinaria_2023]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Veterinaria_2023', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Veterinaria_2023.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Veterinaria_2023_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Veterinaria_2023_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Veterinaria_2023] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Veterinaria_2023].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Veterinaria_2023] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Veterinaria_2023] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Veterinaria_2023] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Veterinaria_2023] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Veterinaria_2023] SET ARITHABORT OFF 
GO
ALTER DATABASE [Veterinaria_2023] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Veterinaria_2023] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Veterinaria_2023] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Veterinaria_2023] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Veterinaria_2023] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Veterinaria_2023] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Veterinaria_2023] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Veterinaria_2023] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Veterinaria_2023] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Veterinaria_2023] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Veterinaria_2023] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Veterinaria_2023] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Veterinaria_2023] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Veterinaria_2023] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Veterinaria_2023] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Veterinaria_2023] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Veterinaria_2023] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Veterinaria_2023] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Veterinaria_2023] SET  MULTI_USER 
GO
ALTER DATABASE [Veterinaria_2023] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Veterinaria_2023] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Veterinaria_2023] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Veterinaria_2023] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Veterinaria_2023] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Veterinaria_2023] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Veterinaria_2023] SET QUERY_STORE = ON
GO
ALTER DATABASE [Veterinaria_2023] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Veterinaria_2023]
GO
/****** Object:  Table [dbo].[Atencion]    Script Date: 28/8/2023 11:39:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Atencion](
	[idAtencion] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [datetime] NOT NULL,
	[descripcion] [varchar](200) NULL,
	[importe] [money] NULL,
 CONSTRAINT [PK_Atencion] PRIMARY KEY CLUSTERED 
(
	[idAtencion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 28/8/2023 11:39:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[idCliente] [int] IDENTITY(1,1) NOT NULL,
	[sexo] [bit] NOT NULL,
	[codigo] [int] NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[idCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalle_Atencion]    Script Date: 28/8/2023 11:39:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle_Atencion](
	[id_detalle_atencion] [int] IDENTITY(1,1) NOT NULL,
	[cantidad] [int] NULL,
	[idAtencion] [int] NULL,
	[idMascota] [int] NULL,
	[importe_atencion] [money] NULL,
 CONSTRAINT [PK_detalle_atencion] PRIMARY KEY CLUSTERED 
(
	[id_detalle_atencion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mascota]    Script Date: 28/8/2023 11:39:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mascota](
	[idMascota] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[edad] [int] NOT NULL,
	[idtipo] [int] NULL,
 CONSTRAINT [PK_Mascota] PRIMARY KEY CLUSTERED 
(
	[idMascota] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo]    Script Date: 28/8/2023 11:39:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo](
	[idTipo] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Tipo] PRIMARY KEY CLUSTERED 
(
	[idTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Detalle_Atencion]  WITH CHECK ADD  CONSTRAINT [fk_detalle_atencion_atencion] FOREIGN KEY([idAtencion])
REFERENCES [dbo].[Atencion] ([idAtencion])
GO
ALTER TABLE [dbo].[Detalle_Atencion] CHECK CONSTRAINT [fk_detalle_atencion_atencion]
GO
ALTER TABLE [dbo].[Detalle_Atencion]  WITH CHECK ADD  CONSTRAINT [fk_detalle_atencion_mascota] FOREIGN KEY([id_detalle_atencion])
REFERENCES [dbo].[Mascota] ([idMascota])
GO
ALTER TABLE [dbo].[Detalle_Atencion] CHECK CONSTRAINT [fk_detalle_atencion_mascota]
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_TIPO]    Script Date: 28/8/2023 11:39:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CONSULTAR_TIPO]
@nombre varchar (50)--parametro
AS
BEGIN
SELECT * FROM Tipo T
WHERE T.nombre = @nombre;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERTAR_DETALLE]    Script Date: 28/8/2023 11:39:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_INSERTAR_DETALLE] 
	@cantidad int, 
	@idAtencion int, 
	@idMascota int,
	@importe_atencion money
AS
BEGIN
	INSERT INTO Detalle_Atencion(cantidad,idAtencion, idMascota, importe_atencion)
    VALUES (@cantidad, @idAtencion, @idMascota, @importe_atencion);
  
END
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERTAR_MAESTRO_MASCOTA]    Script Date: 28/8/2023 11:39:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_INSERTAR_MAESTRO_MASCOTA] 
	@nombre varchar (50),
	@edad [int],
	@idtipo [int],
	@idMascota int OUTPUT
AS
BEGIN
	INSERT INTO Mascota(nombre, edad, idtipo)
    VALUES (@nombre, @edad, @idtipo);
    --Asignamos el valor del último ID autogenerado (obtenido --  
    --mediante la función SCOPE_IDENTITY() de SQLServer)	
    SET @idMascota = SCOPE_IDENTITY();

END
GO
/****** Object:  StoredProcedure [dbo].[SP_PROXIMO_ID]    Script Date: 28/8/2023 11:39:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_PROXIMO_ID]
@next int OUTPUT
AS
BEGIN
	SET @next = (SELECT MAX(idAtencion)+1  FROM Atencion );
END
GO
USE [master]
GO
ALTER DATABASE [Veterinaria_2023] SET  READ_WRITE 
GO
