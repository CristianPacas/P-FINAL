CREATE TABLE [dbo].[DetalleVenta]
(
	IdDetalle INT PRIMARY KEY IDENTITY(1,1),
    IdVenta INT NOT NULL,
    Codigo NVARCHAR(100) NOT NULL,
    Nombre NVARCHAR(100) NOT NULL,
    Categoria NVARCHAR(100) NOT NULL,
    PrecioUnitario DECIMAL(18,2) NOT NULL,
    Cantidad INT NOT NULL,
    PrecioTotal DECIMAL(18,2) NOT NULL,

    CONSTRAINT FK_DetalleVenta_Ventas 
        FOREIGN KEY (IdVenta) REFERENCES Ventas(IdVenta)
)
