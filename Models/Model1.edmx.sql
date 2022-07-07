
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/07/2022 07:43:27
-- Generated from EDMX file: C:\Users\T.i\source\repos\Cantinho Caseiro\Models\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [CantinhoCaseiro];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[PedidosLocais]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PedidosLocais];
GO
IF OBJECT_ID(N'[dbo].[Usuarios]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Usuarios];
GO
IF OBJECT_ID(N'[dbo].[ReservaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ReservaSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'PedidosLocais'
CREATE TABLE [dbo].[PedidosLocais] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PdcPrato] varchar(50)  NULL,
    [PdcQuantidade] varchar(50)  NULL,
    [PdcCliente] varchar(50)  NULL,
    [PdcData] datetime  NULL,
    [PdcAdcional] varchar(50)  NULL
);
GO

-- Creating table 'Usuarios'
CREATE TABLE [dbo].[Usuarios] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UsrNome] varchar(50)  NULL,
    [UsrEmail] varchar(50)  NULL,
    [UsrSenha] varchar(50)  NULL,
    [UsrPerfil] varchar(50)  NULL,
    [UsrTel] nvarchar(50)  NULL,
    [UsrRua] varchar(50)  NULL,
    [UsrNum] varchar(50)  NULL,
    [UsrBairro] varchar(50)  NULL,
    [UsrCidade] varchar(50)  NULL,
    [UsrData] datetime  NULL
);
GO

-- Creating table 'ReservaSet'
CREATE TABLE [dbo].[ReservaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [mesa] nvarchar(max)  NOT NULL,
    [reservada] nvarchar(max)  NOT NULL,
    [data] datetime  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'PedidosLocais'
ALTER TABLE [dbo].[PedidosLocais]
ADD CONSTRAINT [PK_PedidosLocais]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Usuarios'
ALTER TABLE [dbo].[Usuarios]
ADD CONSTRAINT [PK_Usuarios]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ReservaSet'
ALTER TABLE [dbo].[ReservaSet]
ADD CONSTRAINT [PK_ReservaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------