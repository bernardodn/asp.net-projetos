
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/29/2017 11:09:11
-- Generated from EDMX file: C:\Bernardo\asp.net-projetos\Projeto\Projeto\Models\BaseProjeto.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [nflDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Times'
CREATE TABLE [dbo].[Times] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Descricao_Id] int  NOT NULL
);
GO

-- Creating table 'Descricoes'
CREATE TABLE [dbo].[Descricoes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Conferencia] nvarchar(max)  NOT NULL,
    [Campeonatos] nvarchar(max)  NOT NULL,
    [MVP] nvarchar(max)  NOT NULL,
    [Estadio] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Times'
ALTER TABLE [dbo].[Times]
ADD CONSTRAINT [PK_Times]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Descricoes'
ALTER TABLE [dbo].[Descricoes]
ADD CONSTRAINT [PK_Descricoes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Descricao_Id] in table 'Times'
ALTER TABLE [dbo].[Times]
ADD CONSTRAINT [FK_TimeDescricao]
    FOREIGN KEY ([Descricao_Id])
    REFERENCES [dbo].[Descricoes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TimeDescricao'
CREATE INDEX [IX_FK_TimeDescricao]
ON [dbo].[Times]
    ([Descricao_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------