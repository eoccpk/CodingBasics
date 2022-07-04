
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/04/2022 14:00:04
-- Generated from EDMX file: D:\GitHub\CodingBasics\20220703_EcommerceStore\20220703_EcommerceStore\StoreModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [EcommerceStore];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CustomerOrder]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Orders] DROP CONSTRAINT [FK_CustomerOrder];
GO
IF OBJECT_ID(N'[dbo].[FK_OrderBill]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Orders] DROP CONSTRAINT [FK_OrderBill];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Customers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Customers];
GO
IF OBJECT_ID(N'[dbo].[Orders]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Orders];
GO
IF OBJECT_ID(N'[dbo].[Bills]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Bills];
GO
IF OBJECT_ID(N'[dbo].[Products]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Products];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Customers'
CREATE TABLE [dbo].[Customers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Phone] nvarchar(max)  NOT NULL,
    [Address] nvarchar(max)  NOT NULL,
    [Balance] int  NOT NULL
);
GO

-- Creating table 'Orders'
CREATE TABLE [dbo].[Orders] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [OrderTime] datetime  NOT NULL,
    [IsConfirmed] bit  NOT NULL,
    [IsDispatched] bit  NOT NULL,
    [DispatchTime] datetime  NOT NULL,
    [IsDelivered] bit  NOT NULL,
    [DeliveryTime] datetime  NOT NULL,
    [CustomerId] int  NOT NULL,
    [Bill_Id] int  NOT NULL
);
GO

-- Creating table 'Bills'
CREATE TABLE [dbo].[Bills] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [GenerationTime] datetime  NOT NULL,
    [IsPaid] bit  NOT NULL,
    [Amount] int  NOT NULL,
    [PaymentMethod] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Products'
CREATE TABLE [dbo].[Products] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Code] nvarchar(max)  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Category] nvarchar(max)  NOT NULL,
    [UnitPrice] int  NOT NULL,
    [StockQuantity] nvarchar(max)  NOT NULL,
    [Rating] int  NOT NULL,
    [Seller] nvarchar(max)  NOT NULL,
    [Image] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'OrderProducts'
CREATE TABLE [dbo].[OrderProducts] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [OrderId] int  NOT NULL,
    [ProductId] int  NOT NULL,
    [Quantity] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Customers'
ALTER TABLE [dbo].[Customers]
ADD CONSTRAINT [PK_Customers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [PK_Orders]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Bills'
ALTER TABLE [dbo].[Bills]
ADD CONSTRAINT [PK_Bills]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [PK_Products]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'OrderProducts'
ALTER TABLE [dbo].[OrderProducts]
ADD CONSTRAINT [PK_OrderProducts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CustomerId] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [FK_CustomerOrder]
    FOREIGN KEY ([CustomerId])
    REFERENCES [dbo].[Customers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CustomerOrder'
CREATE INDEX [IX_FK_CustomerOrder]
ON [dbo].[Orders]
    ([CustomerId]);
GO

-- Creating foreign key on [Bill_Id] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [FK_OrderBill]
    FOREIGN KEY ([Bill_Id])
    REFERENCES [dbo].[Bills]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OrderBill'
CREATE INDEX [IX_FK_OrderBill]
ON [dbo].[Orders]
    ([Bill_Id]);
GO

-- Creating foreign key on [OrderId] in table 'OrderProducts'
ALTER TABLE [dbo].[OrderProducts]
ADD CONSTRAINT [FK_OrderOrderProduct]
    FOREIGN KEY ([OrderId])
    REFERENCES [dbo].[Orders]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OrderOrderProduct'
CREATE INDEX [IX_FK_OrderOrderProduct]
ON [dbo].[OrderProducts]
    ([OrderId]);
GO

-- Creating foreign key on [ProductId] in table 'OrderProducts'
ALTER TABLE [dbo].[OrderProducts]
ADD CONSTRAINT [FK_ProductOrderProduct]
    FOREIGN KEY ([ProductId])
    REFERENCES [dbo].[Products]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductOrderProduct'
CREATE INDEX [IX_FK_ProductOrderProduct]
ON [dbo].[OrderProducts]
    ([ProductId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------