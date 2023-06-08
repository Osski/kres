
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/08/2023 23:50:41
-- Generated from EDMX file: C:\Users\osman\source\repos\kres\Models\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [kres__Os];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_DersProgrami_ders]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DersProgrami] DROP CONSTRAINT [FK_DersProgrami_ders];
GO
IF OBJECT_ID(N'[dbo].[FK_DersProgrami_ogretmen]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DersProgrami] DROP CONSTRAINT [FK_DersProgrami_ogretmen];
GO
IF OBJECT_ID(N'[dbo].[FK_DersProgrami_siniflar]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DersProgrami] DROP CONSTRAINT [FK_DersProgrami_siniflar];
GO
IF OBJECT_ID(N'[dbo].[FK_ogrencisinif_ogrenci]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ogrencisinif] DROP CONSTRAINT [FK_ogrencisinif_ogrenci];
GO
IF OBJECT_ID(N'[dbo].[FK_ogrencisinif_siniflar]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ogrencisinif] DROP CONSTRAINT [FK_ogrencisinif_siniflar];
GO
IF OBJECT_ID(N'[dbo].[FK_ogrenciveli_ogrenci]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ogrenciveli] DROP CONSTRAINT [FK_ogrenciveli_ogrenci];
GO
IF OBJECT_ID(N'[dbo].[FK_ogrenciveli_veli]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ogrenciveli] DROP CONSTRAINT [FK_ogrenciveli_veli];
GO
IF OBJECT_ID(N'[dbo].[FK_sinifogretmen_ogretmen]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[sinifogretmen] DROP CONSTRAINT [FK_sinifogretmen_ogretmen];
GO
IF OBJECT_ID(N'[dbo].[FK_sinifogretmen_siniflar]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[sinifogretmen] DROP CONSTRAINT [FK_sinifogretmen_siniflar];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ders]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ders];
GO
IF OBJECT_ID(N'[dbo].[DersProgrami]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DersProgrami];
GO
IF OBJECT_ID(N'[dbo].[ogrenci]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ogrenci];
GO
IF OBJECT_ID(N'[dbo].[ogrencisinif]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ogrencisinif];
GO
IF OBJECT_ID(N'[dbo].[ogrenciveli]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ogrenciveli];
GO
IF OBJECT_ID(N'[dbo].[ogretmen]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ogretmen];
GO
IF OBJECT_ID(N'[dbo].[siniflar]', 'U') IS NOT NULL
    DROP TABLE [dbo].[siniflar];
GO
IF OBJECT_ID(N'[dbo].[sinifogretmen]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sinifogretmen];
GO
IF OBJECT_ID(N'[dbo].[veli]', 'U') IS NOT NULL
    DROP TABLE [dbo].[veli];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ogrenci'
CREATE TABLE [dbo].[ogrenci] (
    [ogrenciID] int IDENTITY(1,1) NOT NULL,
    [adi] nchar(10)  NULL,
    [soyadi] nchar(10)  NULL,
    [cinsiyet] bit  NULL,
    [dogumtarihi] datetime  NULL,
    [tcno] int  NULL,
    [ogrencino] int  NULL,
    [durumu] bit  NULL
);
GO

-- Creating table 'ogrencisinif'
CREATE TABLE [dbo].[ogrencisinif] (
    [ogrencisinifID] int IDENTITY(1,1) NOT NULL,
    [ogrenciID] int  NULL,
    [sinifID] int  NULL
);
GO

-- Creating table 'ogrenciveli'
CREATE TABLE [dbo].[ogrenciveli] (
    [ogrenciveliID] int IDENTITY(1,1) NOT NULL,
    [ogrenciID] int  NULL,
    [veliID] int  NULL
);
GO

-- Creating table 'ogretmen'
CREATE TABLE [dbo].[ogretmen] (
    [ogretmenID] int IDENTITY(1,1) NOT NULL,
    [adi] nvarchar(max)  NULL,
    [soyadi] nvarchar(max)  NULL,
    [tcno] nvarchar(max)  NULL,
    [tel] nvarchar(max)  NULL,
    [adres] nvarchar(max)  NULL,
    [maas] nvarchar(max)  NULL,
    [mail] nvarchar(max)  NULL,
    [cinsiyet] bit  NULL,
    [dogumtarihi] datetime  NULL
);
GO

-- Creating table 'siniflar'
CREATE TABLE [dbo].[siniflar] (
    [sinifID] int IDENTITY(1,1) NOT NULL,
    [sinifadi] nchar(10)  NULL
);
GO

-- Creating table 'sinifogretmen'
CREATE TABLE [dbo].[sinifogretmen] (
    [sinifogretmenID] int IDENTITY(1,1) NOT NULL,
    [sinifID] int  NULL,
    [ogretmenID] int  NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'veli'
CREATE TABLE [dbo].[veli] (
    [veliID] int IDENTITY(1,1) NOT NULL,
    [adi] nvarchar(max)  NULL,
    [soyadi] nvarchar(max)  NULL,
    [tcno] nvarchar(max)  NULL,
    [cinsiyet] bit  NULL,
    [adres] nvarchar(max)  NULL,
    [tel] nvarchar(max)  NULL
);
GO

-- Creating table 'ders'
CREATE TABLE [dbo].[ders] (
    [DersID] int IDENTITY(1,1) NOT NULL,
    [DersAdi] nvarchar(50)  NULL
);
GO

-- Creating table 'DersProgrami'
CREATE TABLE [dbo].[DersProgrami] (
    [DersProgramiID] int IDENTITY(1,1) NOT NULL,
    [DersID] int  NULL,
    [OgretmenID] int  NULL,
    [SinifID] int  NULL,
    [Gun] datetime  NULL,
    [BaslangicSaat] time  NULL,
    [BitisSaat] time  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ogrenciID] in table 'ogrenci'
ALTER TABLE [dbo].[ogrenci]
ADD CONSTRAINT [PK_ogrenci]
    PRIMARY KEY CLUSTERED ([ogrenciID] ASC);
GO

-- Creating primary key on [ogrencisinifID] in table 'ogrencisinif'
ALTER TABLE [dbo].[ogrencisinif]
ADD CONSTRAINT [PK_ogrencisinif]
    PRIMARY KEY CLUSTERED ([ogrencisinifID] ASC);
GO

-- Creating primary key on [ogrenciveliID] in table 'ogrenciveli'
ALTER TABLE [dbo].[ogrenciveli]
ADD CONSTRAINT [PK_ogrenciveli]
    PRIMARY KEY CLUSTERED ([ogrenciveliID] ASC);
GO

-- Creating primary key on [ogretmenID] in table 'ogretmen'
ALTER TABLE [dbo].[ogretmen]
ADD CONSTRAINT [PK_ogretmen]
    PRIMARY KEY CLUSTERED ([ogretmenID] ASC);
GO

-- Creating primary key on [sinifID] in table 'siniflar'
ALTER TABLE [dbo].[siniflar]
ADD CONSTRAINT [PK_siniflar]
    PRIMARY KEY CLUSTERED ([sinifID] ASC);
GO

-- Creating primary key on [sinifogretmenID] in table 'sinifogretmen'
ALTER TABLE [dbo].[sinifogretmen]
ADD CONSTRAINT [PK_sinifogretmen]
    PRIMARY KEY CLUSTERED ([sinifogretmenID] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [veliID] in table 'veli'
ALTER TABLE [dbo].[veli]
ADD CONSTRAINT [PK_veli]
    PRIMARY KEY CLUSTERED ([veliID] ASC);
GO

-- Creating primary key on [DersID] in table 'ders'
ALTER TABLE [dbo].[ders]
ADD CONSTRAINT [PK_ders]
    PRIMARY KEY CLUSTERED ([DersID] ASC);
GO

-- Creating primary key on [DersProgramiID] in table 'DersProgrami'
ALTER TABLE [dbo].[DersProgrami]
ADD CONSTRAINT [PK_DersProgrami]
    PRIMARY KEY CLUSTERED ([DersProgramiID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ogrenciID] in table 'ogrencisinif'
ALTER TABLE [dbo].[ogrencisinif]
ADD CONSTRAINT [FK_ogrencisinif_ogrenci]
    FOREIGN KEY ([ogrenciID])
    REFERENCES [dbo].[ogrenci]
        ([ogrenciID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ogrencisinif_ogrenci'
CREATE INDEX [IX_FK_ogrencisinif_ogrenci]
ON [dbo].[ogrencisinif]
    ([ogrenciID]);
GO

-- Creating foreign key on [ogrenciID] in table 'ogrenciveli'
ALTER TABLE [dbo].[ogrenciveli]
ADD CONSTRAINT [FK_ogrenciveli_ogrenci]
    FOREIGN KEY ([ogrenciID])
    REFERENCES [dbo].[ogrenci]
        ([ogrenciID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ogrenciveli_ogrenci'
CREATE INDEX [IX_FK_ogrenciveli_ogrenci]
ON [dbo].[ogrenciveli]
    ([ogrenciID]);
GO

-- Creating foreign key on [sinifID] in table 'ogrencisinif'
ALTER TABLE [dbo].[ogrencisinif]
ADD CONSTRAINT [FK_ogrencisinif_siniflar]
    FOREIGN KEY ([sinifID])
    REFERENCES [dbo].[siniflar]
        ([sinifID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ogrencisinif_siniflar'
CREATE INDEX [IX_FK_ogrencisinif_siniflar]
ON [dbo].[ogrencisinif]
    ([sinifID]);
GO

-- Creating foreign key on [veliID] in table 'ogrenciveli'
ALTER TABLE [dbo].[ogrenciveli]
ADD CONSTRAINT [FK_ogrenciveli_veli]
    FOREIGN KEY ([veliID])
    REFERENCES [dbo].[veli]
        ([veliID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ogrenciveli_veli'
CREATE INDEX [IX_FK_ogrenciveli_veli]
ON [dbo].[ogrenciveli]
    ([veliID]);
GO

-- Creating foreign key on [ogretmenID] in table 'sinifogretmen'
ALTER TABLE [dbo].[sinifogretmen]
ADD CONSTRAINT [FK_sinifogretmen_ogretmen]
    FOREIGN KEY ([ogretmenID])
    REFERENCES [dbo].[ogretmen]
        ([ogretmenID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_sinifogretmen_ogretmen'
CREATE INDEX [IX_FK_sinifogretmen_ogretmen]
ON [dbo].[sinifogretmen]
    ([ogretmenID]);
GO

-- Creating foreign key on [sinifID] in table 'sinifogretmen'
ALTER TABLE [dbo].[sinifogretmen]
ADD CONSTRAINT [FK_sinifogretmen_siniflar]
    FOREIGN KEY ([sinifID])
    REFERENCES [dbo].[siniflar]
        ([sinifID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_sinifogretmen_siniflar'
CREATE INDEX [IX_FK_sinifogretmen_siniflar]
ON [dbo].[sinifogretmen]
    ([sinifID]);
GO

-- Creating foreign key on [DersID] in table 'DersProgrami'
ALTER TABLE [dbo].[DersProgrami]
ADD CONSTRAINT [FK_DersProgrami_ders]
    FOREIGN KEY ([DersID])
    REFERENCES [dbo].[ders]
        ([DersID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DersProgrami_ders'
CREATE INDEX [IX_FK_DersProgrami_ders]
ON [dbo].[DersProgrami]
    ([DersID]);
GO

-- Creating foreign key on [OgretmenID] in table 'DersProgrami'
ALTER TABLE [dbo].[DersProgrami]
ADD CONSTRAINT [FK_DersProgrami_ogretmen]
    FOREIGN KEY ([OgretmenID])
    REFERENCES [dbo].[ogretmen]
        ([ogretmenID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DersProgrami_ogretmen'
CREATE INDEX [IX_FK_DersProgrami_ogretmen]
ON [dbo].[DersProgrami]
    ([OgretmenID]);
GO

-- Creating foreign key on [SinifID] in table 'DersProgrami'
ALTER TABLE [dbo].[DersProgrami]
ADD CONSTRAINT [FK_DersProgrami_siniflar]
    FOREIGN KEY ([SinifID])
    REFERENCES [dbo].[siniflar]
        ([sinifID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DersProgrami_siniflar'
CREATE INDEX [IX_FK_DersProgrami_siniflar]
ON [dbo].[DersProgrami]
    ([SinifID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------