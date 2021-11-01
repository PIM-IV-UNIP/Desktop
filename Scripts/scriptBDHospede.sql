USE [master]
GO

/****** Object:  Database [BDHOTEL]    Script Date: 23/10/2021 12:29:04 ******/
CREATE DATABASE [BDHOTEL]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BDCadastro', FILENAME = N'E:\SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\BDCadastro.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BDCadastro_log', FILENAME = N'E:\SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\BDCadastro_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BDHOTEL].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [BDHOTEL] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [BDHOTEL] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [BDHOTEL] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [BDHOTEL] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [BDHOTEL] SET ARITHABORT OFF 
GO

ALTER DATABASE [BDHOTEL] SET AUTO_CLOSE ON 
GO

ALTER DATABASE [BDHOTEL] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [BDHOTEL] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [BDHOTEL] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [BDHOTEL] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [BDHOTEL] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [BDHOTEL] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [BDHOTEL] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [BDHOTEL] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [BDHOTEL] SET  ENABLE_BROKER 
GO

ALTER DATABASE [BDHOTEL] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [BDHOTEL] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [BDHOTEL] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [BDHOTEL] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [BDHOTEL] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [BDHOTEL] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [BDHOTEL] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [BDHOTEL] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [BDHOTEL] SET  MULTI_USER 
GO

ALTER DATABASE [BDHOTEL] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [BDHOTEL] SET DB_CHAINING OFF 
GO

ALTER DATABASE [BDHOTEL] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [BDHOTEL] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [BDHOTEL] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [BDHOTEL] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [BDHOTEL] SET QUERY_STORE = OFF
GO

ALTER DATABASE [BDHOTEL] SET  READ_WRITE 
GO
