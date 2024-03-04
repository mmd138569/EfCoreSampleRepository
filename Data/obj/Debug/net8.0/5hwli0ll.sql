IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [customers] (
    [Id] int NOT NULL IDENTITY,
    [FirstName] nvarchar(max) NOT NULL,
    [LastName] nvarchar(max) NOT NULL,
    [phone] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_customers] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [employees] (
    [Id] int NOT NULL IDENTITY,
    [FirstName] nvarchar(max) NOT NULL,
    [LastName] nvarchar(max) NOT NULL,
    [phone] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_employees] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [products] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [price] decimal(20,0) NOT NULL,
    CONSTRAINT [PK_products] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240221120658_init', N'9.0.0-preview.1.24081.2');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240221121459_just_testing', N'9.0.0-preview.1.24081.2');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[employees]') AND [c].[name] = N'phone');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [employees] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [employees] ALTER COLUMN [phone] decimal(20,0) NOT NULL;
GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[customers]') AND [c].[name] = N'phone');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [customers] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [customers] ALTER COLUMN [phone] decimal(20,0) NOT NULL;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240221135849_mymig', N'9.0.0-preview.1.24081.2');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240222065304_a', N'9.0.0-preview.1.24081.2');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240222081756_ao', N'9.0.0-preview.1.24081.2');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240222084146_ao12', N'9.0.0-preview.1.24081.2');
GO

COMMIT;
GO

