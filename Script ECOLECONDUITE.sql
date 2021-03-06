USE [master]
GO
/****** Object:  Database [ECOLECONDUITE]    Script Date: 11/12/2020 11:22:29 ******/
CREATE DATABASE [ECOLECONDUITE]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ECOLECONDUITE', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\ECOLECONDUITE.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ECOLECONDUITE_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\ECOLECONDUITE_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [ECOLECONDUITE] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ECOLECONDUITE].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ECOLECONDUITE] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ECOLECONDUITE] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ECOLECONDUITE] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ECOLECONDUITE] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ECOLECONDUITE] SET ARITHABORT OFF 
GO
ALTER DATABASE [ECOLECONDUITE] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ECOLECONDUITE] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ECOLECONDUITE] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ECOLECONDUITE] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ECOLECONDUITE] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ECOLECONDUITE] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ECOLECONDUITE] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ECOLECONDUITE] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ECOLECONDUITE] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ECOLECONDUITE] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ECOLECONDUITE] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ECOLECONDUITE] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ECOLECONDUITE] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ECOLECONDUITE] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ECOLECONDUITE] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ECOLECONDUITE] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ECOLECONDUITE] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ECOLECONDUITE] SET RECOVERY FULL 
GO
ALTER DATABASE [ECOLECONDUITE] SET  MULTI_USER 
GO
ALTER DATABASE [ECOLECONDUITE] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ECOLECONDUITE] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ECOLECONDUITE] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ECOLECONDUITE] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ECOLECONDUITE] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ECOLECONDUITE] SET QUERY_STORE = OFF
GO
USE [ECOLECONDUITE]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [ECOLECONDUITE]
GO
/****** Object:  Table [dbo].[ELEVE]    Script Date: 11/12/2020 11:22:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ELEVE](
	[id] [int] NOT NULL,
	[nom] [varchar](50) NOT NULL,
	[prenom] [varchar](50) NULL,
	[rue] [varchar](100) NULL,
	[ville] [varchar](50) NULL,
	[cp] [char](5) NULL,
	[creditHoraire] [int] NOT NULL,
	[dateInscription] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_ELEVE] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LECON]    Script Date: 11/12/2020 11:22:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LECON](
	[id] [char](10) NOT NULL,
	[dateLecon] [smalldatetime] NOT NULL,
	[heure] [int] NOT NULL,
	[duree] [int] NOT NULL,
	[effectueeO/N] [bit] NULL,
	[idEleve] [int] NOT NULL,
	[idVehicule] [char](7) NOT NULL,
 CONSTRAINT [PK_LECON] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VEHICULE]    Script Date: 11/12/2020 11:22:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VEHICULE](
	[id] [char](7) NOT NULL,
	[modele] [char](30) NULL,
	[cylindree] [int] NULL,
	[voitureO/N] [bit] NULL,
 CONSTRAINT [PK_VEHICULE] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ELEVE] ([id], [nom], [prenom], [rue], [ville], [cp], [creditHoraire], [dateInscription]) VALUES (1, N'CHAPELIER', N'Nicolas', N'Rue Arthur Rimbaut', N'LA GUERCHE', N'18150', 25, CAST(N'2020-09-26T00:00:00' AS SmallDateTime))
INSERT [dbo].[ELEVE] ([id], [nom], [prenom], [rue], [ville], [cp], [creditHoraire], [dateInscription]) VALUES (2, N'GRANGE', N'Pauline', N'Avenue Bel Air', N'NEVERS', N'58000', 10, CAST(N'2020-09-10T00:00:00' AS SmallDateTime))
INSERT [dbo].[ELEVE] ([id], [nom], [prenom], [rue], [ville], [cp], [creditHoraire], [dateInscription]) VALUES (3, N'MACADRE', N'Adrien', N'10 rue des inséparables', N'NEVERS', N'58000', 32, CAST(N'2020-10-09T00:00:00' AS SmallDateTime))
INSERT [dbo].[ELEVE] ([id], [nom], [prenom], [rue], [ville], [cp], [creditHoraire], [dateInscription]) VALUES (4, N'MAQUET', N'Alexis', N'Route des Latins', N'NEVERS', N'58000', 26, CAST(N'2020-09-30T00:00:00' AS SmallDateTime))
INSERT [dbo].[ELEVE] ([id], [nom], [prenom], [rue], [ville], [cp], [creditHoraire], [dateInscription]) VALUES (5, N'MOISSONNIER', N'Thibaut', N'Allée des croissants', N'SAINT PIERRE LE MOUTIER', N'58240', 15, CAST(N'2020-09-28T00:00:00' AS SmallDateTime))
INSERT [dbo].[ELEVE] ([id], [nom], [prenom], [rue], [ville], [cp], [creditHoraire], [dateInscription]) VALUES (6, N'PLUCNER', N'Quentin', N'La Civelle', N'FOURCHAMBAULT', N'58180', 10, CAST(N'2020-09-10T00:00:00' AS SmallDateTime))
INSERT [dbo].[ELEVE] ([id], [nom], [prenom], [rue], [ville], [cp], [creditHoraire], [dateInscription]) VALUES (7, N'ROUSSEAU', N'Mylène', N'Avenue des Clercs ', N'NEVERS', N'58000', 26, CAST(N'2020-09-30T00:00:00' AS SmallDateTime))
INSERT [dbo].[ELEVE] ([id], [nom], [prenom], [rue], [ville], [cp], [creditHoraire], [dateInscription]) VALUES (8, N'VACHER', N'Damien', N'Le Plessis', N'CLAMECY', N'58500', 15, CAST(N'2020-09-10T00:00:00' AS SmallDateTime))
INSERT [dbo].[LECON] ([id], [dateLecon], [heure], [duree], [effectueeO/N], [idEleve], [idVehicule]) VALUES (N'1         ', CAST(N'2020-09-17T00:00:00' AS SmallDateTime), 10, 2, 1, 2, N'MN856PS')
INSERT [dbo].[LECON] ([id], [dateLecon], [heure], [duree], [effectueeO/N], [idEleve], [idVehicule]) VALUES (N'10        ', CAST(N'2020-10-06T00:00:00' AS SmallDateTime), 13, 2, 1, 4, N'EF789GH')
INSERT [dbo].[LECON] ([id], [dateLecon], [heure], [duree], [effectueeO/N], [idEleve], [idVehicule]) VALUES (N'11        ', CAST(N'2020-10-06T00:00:00' AS SmallDateTime), 15, 2, 1, 6, N'JK569LM')
INSERT [dbo].[LECON] ([id], [dateLecon], [heure], [duree], [effectueeO/N], [idEleve], [idVehicule]) VALUES (N'12        ', CAST(N'2020-10-06T00:00:00' AS SmallDateTime), 16, 1, 1, 7, N'AB154CD')
INSERT [dbo].[LECON] ([id], [dateLecon], [heure], [duree], [effectueeO/N], [idEleve], [idVehicule]) VALUES (N'2         ', CAST(N'2020-09-20T00:00:00' AS SmallDateTime), 13, 1, 1, 2, N'MN856PS')
INSERT [dbo].[LECON] ([id], [dateLecon], [heure], [duree], [effectueeO/N], [idEleve], [idVehicule]) VALUES (N'25        ', CAST(N'2020-11-26T11:48:00' AS SmallDateTime), 10, 2, 1, 1, N'QR963ST')
INSERT [dbo].[LECON] ([id], [dateLecon], [heure], [duree], [effectueeO/N], [idEleve], [idVehicule]) VALUES (N'3         ', CAST(N'2020-09-29T00:00:00' AS SmallDateTime), 10, 2, 1, 2, N'MN856PS')
INSERT [dbo].[LECON] ([id], [dateLecon], [heure], [duree], [effectueeO/N], [idEleve], [idVehicule]) VALUES (N'4         ', CAST(N'2020-09-29T00:00:00' AS SmallDateTime), 10, 1, 1, 1, N'QR963ST')
INSERT [dbo].[LECON] ([id], [dateLecon], [heure], [duree], [effectueeO/N], [idEleve], [idVehicule]) VALUES (N'5         ', CAST(N'2020-10-01T00:00:00' AS SmallDateTime), 9, 1, 1, 4, N'EF789GH')
INSERT [dbo].[LECON] ([id], [dateLecon], [heure], [duree], [effectueeO/N], [idEleve], [idVehicule]) VALUES (N'6         ', CAST(N'2020-10-01T00:00:00' AS SmallDateTime), 16, 1, 1, 2, N'MN856PS')
INSERT [dbo].[LECON] ([id], [dateLecon], [heure], [duree], [effectueeO/N], [idEleve], [idVehicule]) VALUES (N'7         ', CAST(N'2020-10-03T00:00:00' AS SmallDateTime), 15, 2, 1, 6, N'JK569LM')
INSERT [dbo].[LECON] ([id], [dateLecon], [heure], [duree], [effectueeO/N], [idEleve], [idVehicule]) VALUES (N'8         ', CAST(N'2020-10-03T00:00:00' AS SmallDateTime), 18, 1, 1, 7, N'AB154CD')
INSERT [dbo].[LECON] ([id], [dateLecon], [heure], [duree], [effectueeO/N], [idEleve], [idVehicule]) VALUES (N'9         ', CAST(N'2020-10-06T00:00:00' AS SmallDateTime), 11, 1, 1, 1, N'QR963ST')
INSERT [dbo].[VEHICULE] ([id], [modele], [cylindree], [voitureO/N]) VALUES (N'AB154CD', N'Renault Clio                  ', NULL, 1)
INSERT [dbo].[VEHICULE] ([id], [modele], [cylindree], [voitureO/N]) VALUES (N'DZ789PL', N'Peugeot 208                   ', NULL, 1)
INSERT [dbo].[VEHICULE] ([id], [modele], [cylindree], [voitureO/N]) VALUES (N'EF789GH', N'Peugeot 206                   ', NULL, 1)
INSERT [dbo].[VEHICULE] ([id], [modele], [cylindree], [voitureO/N]) VALUES (N'HJ456KL', NULL, 750, 0)
INSERT [dbo].[VEHICULE] ([id], [modele], [cylindree], [voitureO/N]) VALUES (N'JK569LM', N'Peugeot 207                   ', NULL, 1)
INSERT [dbo].[VEHICULE] ([id], [modele], [cylindree], [voitureO/N]) VALUES (N'MN856PS', NULL, 750, 0)
INSERT [dbo].[VEHICULE] ([id], [modele], [cylindree], [voitureO/N]) VALUES (N'QR963ST', NULL, 1000, 0)
INSERT [dbo].[VEHICULE] ([id], [modele], [cylindree], [voitureO/N]) VALUES (N'VA821FG', NULL, 125, 0)
INSERT [dbo].[VEHICULE] ([id], [modele], [cylindree], [voitureO/N]) VALUES (N'XA456DF', NULL, 750, 0)
ALTER TABLE [dbo].[LECON]  WITH CHECK ADD  CONSTRAINT [FK_LECON_ELEVE] FOREIGN KEY([idEleve])
REFERENCES [dbo].[ELEVE] ([id])
GO
ALTER TABLE [dbo].[LECON] CHECK CONSTRAINT [FK_LECON_ELEVE]
GO
ALTER TABLE [dbo].[LECON]  WITH CHECK ADD  CONSTRAINT [FK_LECON_VEHICULE] FOREIGN KEY([idVehicule])
REFERENCES [dbo].[VEHICULE] ([id])
GO
ALTER TABLE [dbo].[LECON] CHECK CONSTRAINT [FK_LECON_VEHICULE]
GO
/****** Object:  StoredProcedure [dbo].[pEleve_INSERT]    Script Date: 11/12/2020 11:22:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pEleve_INSERT]
     @nom varchar(50)
    ,@dateInscription smallDateTime
    ,@prenom varchar(50)
    ,@rue varchar(100)
    ,@ville varchar(50)
    ,@cp char(5)
    ,@creditHoraire int
AS
DECLARE @id int
SELECT @id = (select max(id) from eleve)
select @id = (@id+1)
INSERT eleve (
     id
    ,nom
    ,dateInscription
    ,prenom
    ,rue
    ,ville
    ,cp
    ,creditHoraire
) 
VALUES (
     @id
    ,@nom
    ,@dateInscription
    ,@prenom
    ,@rue 
    ,@ville
    ,@cp
    ,@creditHoraire
)
GO
USE [master]
GO
ALTER DATABASE [ECOLECONDUITE] SET  READ_WRITE 
GO
