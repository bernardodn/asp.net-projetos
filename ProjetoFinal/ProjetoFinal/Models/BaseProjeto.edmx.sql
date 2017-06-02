
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/01/2017 23:45:13
-- Generated from EDMX file: C:\Users\Bernardo Dolata Neto\Documents\asp.net\asp.net-projetos\ProjetoFinal\ProjetoFinal\Models\BaseProjeto.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ProjetoDB];
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

-- Creating table 'Empresas'
CREATE TABLE [dbo].[Empresas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Funcionarios'
CREATE TABLE [dbo].[Funcionarios] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CPF] nvarchar(11)  NOT NULL,
    [Nome] nvarchar(50)  NOT NULL,
    [DataDeNascimento] nvarchar(10)  NOT NULL,
    [EmpresaId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Empresas'
ALTER TABLE [dbo].[Empresas]
ADD CONSTRAINT [PK_Empresas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Funcionarios'
ALTER TABLE [dbo].[Funcionarios]
ADD CONSTRAINT [PK_Funcionarios]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [EmpresaId] in table 'Funcionarios'
ALTER TABLE [dbo].[Funcionarios]
ADD CONSTRAINT [FK_EmpresaFuncionario]
    FOREIGN KEY ([EmpresaId])
    REFERENCES [dbo].[Empresas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmpresaFuncionario'
CREATE INDEX [IX_FK_EmpresaFuncionario]
ON [dbo].[Funcionarios]
    ([EmpresaId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------