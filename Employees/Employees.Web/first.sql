info: Microsoft.EntityFrameworkCore.Infrastructure[10403]
      Entity Framework Core 2.2.2-servicing-10034 initialized 'EmployeesDbContext' using provider 'Microsoft.EntityFrameworkCore.SqlServer' with options: MaxPoolSize=128 
IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Employees] (
    [EmployeeID] int NOT NULL IDENTITY,
    [FirstName] varchar(255) NULL,
    [LastName] nvarchar(255) NOT NULL,
    [HireDate] datetime2 NOT NULL,
    CONSTRAINT [PK_Employees] PRIMARY KEY ([EmployeeID])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20190425135142_InitialMigration', N'2.2.2-servicing-10034');

GO


