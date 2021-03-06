CREATE DATABASE [DBMoneda]
GO
USE [DBMoneda]
GO
/****** Object:  Table [dbo].[TblTarjetas]    Script Date: 03/29/2020 14:48:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TblTarjetas](
	[PKCodigo] [varchar](20) NOT NULL,
	[FKId_TblEstado] [int] NULL,
 CONSTRAINT [PK_TblTarjetas] PRIMARY KEY CLUSTERED 
(
	[PKCodigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TblProductos]    Script Date: 03/29/2020 14:48:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TblProductos](
	[PKCodigo] [varchar](20) NOT NULL,
	[Nombre] [varchar](100) NULL,
	[Precio] [float] NULL,
	[Stock] [int] NULL,
 CONSTRAINT [PK_TblProductos] PRIMARY KEY CLUSTERED 
(
	[PKCodigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TblEstado]    Script Date: 03/29/2020 14:48:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TblEstado](
	[PKId] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](30) NULL,
 CONSTRAINT [PK_TblEstado] PRIMARY KEY CLUSTERED 
(
	[PKId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TblVendedor]    Script Date: 03/29/2020 14:48:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TblVendedor](
	[PKDocumento] [varchar](20) NOT NULL,
	[Nombre_Completo] [varchar](100) NULL,
	[Telefono] [varchar](10) NULL,
	[Correo] [varchar](50) NULL,
 CONSTRAINT [PK_TblVendedor] PRIMARY KEY CLUSTERED 
(
	[PKDocumento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TblUsuario]    Script Date: 03/29/2020 14:48:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TblUsuario](
	[PKRFID] [varchar](20) NOT NULL,
	[Contraseña] [varchar](50) NULL,
	[fecha] [time](7) NULL,
	[FKId_TblEstado] [int] NULL,
	[FKDocumento_TblVendedor] [varchar](20) NULL,
 CONSTRAINT [PK_TblUsuario] PRIMARY KEY CLUSTERED 
(
	[PKRFID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TblCliente]    Script Date: 03/29/2020 14:48:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TblCliente](
	[PKDocumento] [varchar](12) NOT NULL,
	[Nombre_completo] [varchar](100) NULL,
	[Institucion] [varchar](100) NULL,
	[FKCodigo_TblTarjetas] [varchar](20) NULL,
	[FKId_TblEstado] [int] NULL,
	[Saldo] [float] NULL,
 CONSTRAINT [PK_TblCliente] PRIMARY KEY CLUSTERED 
(
	[PKDocumento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TblCompra]    Script Date: 03/29/2020 14:48:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TblCompra](
	[PKCodigo] [varchar](12) NOT NULL,
	[Fecha] [time](7) NULL,
	[FKDocumento_TblCliente] [varchar](12) NULL,
	[Valor] [float] NULL,
	[FKRFID_TblUsuario] [varchar](20) NULL,
 CONSTRAINT [PK_TblCompra] PRIMARY KEY CLUSTERED 
(
	[PKCodigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TblDetProductos_TblProductos]    Script Date: 03/29/2020 14:48:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TblDetProductos_TblProductos](
	[PKId] [int] IDENTITY(1,1) NOT NULL,
	[FKCodigo_TblCompra] [varchar](12) NULL,
	[FKCodigo_TblProductos] [varchar](20) NULL,
	[Precio] [float] NULL,
	[Cantidad] [int] NULL,
 CONSTRAINT [PK_TblDetProductos_TblProductos] PRIMARY KEY CLUSTERED 
(
	[PKId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [FK_TblCliente_TblEstado]    Script Date: 03/29/2020 14:48:06 ******/
ALTER TABLE [dbo].[TblCliente]  WITH CHECK ADD  CONSTRAINT [FK_TblCliente_TblEstado] FOREIGN KEY([FKId_TblEstado])
REFERENCES [dbo].[TblEstado] ([PKId])
GO
ALTER TABLE [dbo].[TblCliente] CHECK CONSTRAINT [FK_TblCliente_TblEstado]
GO
/****** Object:  ForeignKey [FK_TblCliente_TblTarjetas]    Script Date: 03/29/2020 14:48:06 ******/
ALTER TABLE [dbo].[TblCliente]  WITH CHECK ADD  CONSTRAINT [FK_TblCliente_TblTarjetas] FOREIGN KEY([FKCodigo_TblTarjetas])
REFERENCES [dbo].[TblTarjetas] ([PKCodigo])
GO
ALTER TABLE [dbo].[TblCliente] CHECK CONSTRAINT [FK_TblCliente_TblTarjetas]
GO
/****** Object:  ForeignKey [FK_TblCompra_TblCliente]    Script Date: 03/29/2020 14:48:06 ******/
ALTER TABLE [dbo].[TblCompra]  WITH CHECK ADD  CONSTRAINT [FK_TblCompra_TblCliente] FOREIGN KEY([FKDocumento_TblCliente])
REFERENCES [dbo].[TblCliente] ([PKDocumento])
GO
ALTER TABLE [dbo].[TblCompra] CHECK CONSTRAINT [FK_TblCompra_TblCliente]
GO
/****** Object:  ForeignKey [FK_TblCompra_TblUsuario]    Script Date: 03/29/2020 14:48:06 ******/
ALTER TABLE [dbo].[TblCompra]  WITH CHECK ADD  CONSTRAINT [FK_TblCompra_TblUsuario] FOREIGN KEY([FKRFID_TblUsuario])
REFERENCES [dbo].[TblUsuario] ([PKRFID])
GO
ALTER TABLE [dbo].[TblCompra] CHECK CONSTRAINT [FK_TblCompra_TblUsuario]
GO
/****** Object:  ForeignKey [FK_TblDetProductos_TblProductos_TblCompra]    Script Date: 03/29/2020 14:48:06 ******/
ALTER TABLE [dbo].[TblDetProductos_TblProductos]  WITH CHECK ADD  CONSTRAINT [FK_TblDetProductos_TblProductos_TblCompra] FOREIGN KEY([FKCodigo_TblCompra])
REFERENCES [dbo].[TblCompra] ([PKCodigo])
GO
ALTER TABLE [dbo].[TblDetProductos_TblProductos] CHECK CONSTRAINT [FK_TblDetProductos_TblProductos_TblCompra]
GO
/****** Object:  ForeignKey [FK_TblDetProductos_TblProductos_TblProductos]    Script Date: 03/29/2020 14:48:06 ******/
ALTER TABLE [dbo].[TblDetProductos_TblProductos]  WITH CHECK ADD  CONSTRAINT [FK_TblDetProductos_TblProductos_TblProductos] FOREIGN KEY([FKCodigo_TblProductos])
REFERENCES [dbo].[TblProductos] ([PKCodigo])
GO
ALTER TABLE [dbo].[TblDetProductos_TblProductos] CHECK CONSTRAINT [FK_TblDetProductos_TblProductos_TblProductos]
GO
/****** Object:  ForeignKey [FK_TblUsuario_TblEstado]    Script Date: 03/29/2020 14:48:06 ******/
ALTER TABLE [dbo].[TblUsuario]  WITH CHECK ADD  CONSTRAINT [FK_TblUsuario_TblEstado] FOREIGN KEY([FKId_TblEstado])
REFERENCES [dbo].[TblEstado] ([PKId])
GO
ALTER TABLE [dbo].[TblUsuario] CHECK CONSTRAINT [FK_TblUsuario_TblEstado]
GO
/****** Object:  ForeignKey [FK_TblUsuario_TblVendedor]    Script Date: 03/29/2020 14:48:06 ******/
ALTER TABLE [dbo].[TblUsuario]  WITH CHECK ADD  CONSTRAINT [FK_TblUsuario_TblVendedor] FOREIGN KEY([FKDocumento_TblVendedor])
REFERENCES [dbo].[TblVendedor] ([PKDocumento])
GO
ALTER TABLE [dbo].[TblUsuario] CHECK CONSTRAINT [FK_TblUsuario_TblVendedor]
GO
