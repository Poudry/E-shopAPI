create table __EFMigrationsHistory
(
    MigrationId    nvarchar(150) not null
        constraint PK___EFMigrationsHistory
            primary key,
    ProductVersion nvarchar(32)  not null
)
go

INSERT INTO eshopAPI.dbo.__EFMigrationsHistory (MigrationId, ProductVersion) VALUES (N'20220427165857_CreateInitial', N'6.0.4');
