/*
Script de implementación para BD_PFINAL

Una herramienta generó este código.
Los cambios realizados en este archivo podrían generar un comportamiento incorrecto y se perderán si
se vuelve a generar el código.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "BD_PFINAL"
:setvar DefaultFilePrefix "BD_PFINAL"
:setvar DefaultDataPath "C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\"
:setvar DefaultLogPath "C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\"

GO
:on error exit
GO
/*
Detectar el modo SQLCMD y deshabilitar la ejecución del script si no se admite el modo SQLCMD.
Para volver a habilitar el script después de habilitar el modo SQLCMD, ejecute lo siguiente:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'El modo SQLCMD debe estar habilitado para ejecutar correctamente este script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
PRINT N'Creando Tabla [dbo].[DetalleVenta]...';


GO
CREATE TABLE [dbo].[DetalleVenta] (
    [IdDetalle]      INT             IDENTITY (1, 1) NOT NULL,
    [IdVenta]        INT             NOT NULL,
    [Codigo]         NVARCHAR (100)  NOT NULL,
    [Nombre]         NVARCHAR (100)  NOT NULL,
    [Categoria]      NVARCHAR (100)  NOT NULL,
    [PrecioUnitario] DECIMAL (18, 2) NOT NULL,
    [Cantidad]       INT             NOT NULL,
    [PrecioTotal]    DECIMAL (18, 2) NOT NULL,
    PRIMARY KEY CLUSTERED ([IdDetalle] ASC)
);


GO
PRINT N'Creando Tabla [dbo].[Ventas]...';


GO
CREATE TABLE [dbo].[Ventas] (
    [IdVenta]  INT             IDENTITY (1, 1) NOT NULL,
    [Fecha]    DATETIME        NOT NULL,
    [Subtotal] DECIMAL (18, 2) NOT NULL,
    [IVA]      DECIMAL (18, 2) NOT NULL,
    [Total]    DECIMAL (18, 2) NOT NULL,
    PRIMARY KEY CLUSTERED ([IdVenta] ASC)
);


GO
PRINT N'Creando Restricción DEFAULT restricción sin nombre en [dbo].[Ventas]...';


GO
ALTER TABLE [dbo].[Ventas]
    ADD DEFAULT GETDATE() FOR [Fecha];


GO
PRINT N'Creando Clave externa [dbo].[FK_DetalleVenta_Ventas]...';


GO
ALTER TABLE [dbo].[DetalleVenta] WITH NOCHECK
    ADD CONSTRAINT [FK_DetalleVenta_Ventas] FOREIGN KEY ([IdVenta]) REFERENCES [dbo].[Ventas] ([IdVenta]);


GO
PRINT N'Comprobando los datos existentes con las restricciones recién creadas';


GO
USE [$(DatabaseName)];


GO
ALTER TABLE [dbo].[DetalleVenta] WITH CHECK CHECK CONSTRAINT [FK_DetalleVenta_Ventas];


GO
PRINT N'Actualización completada.';


GO
