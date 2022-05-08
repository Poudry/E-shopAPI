create table Products
(
    Id          int identity
        constraint PK_Products
            primary key,
    Name        nvarchar(max)  not null,
    ImgUri      nvarchar(max)  not null,
    Description nvarchar(max),
    Price       decimal(18, 2) not null
)
go

INSERT INTO eshopAPI.dbo.Products (Id, Name, ImgUri, Description, Price) VALUES (1, N'GUNNAR Gaming Collection RPG designed by Razer, onyx/yellow', N'https://cdn.alza.cz/ImgW.ashx?fd=f16&cd=JD610m3a', null, 1499.00);
INSERT INTO eshopAPI.dbo.Products (Id, Name, ImgUri, Description, Price) VALUES (1002, N'Doom Eternal', N'https://cdn.alza.cz/ImgW.ashx?fd=f16&cd=WG1090', N'Hra na PC', 499.00);
INSERT INTO eshopAPI.dbo.Products (Id, Name, ImgUri, Description, Price) VALUES (1003, N'Realme GT', N'https://cdn.alza.cz/ImgW.ashx?fd=f16&cd=SADW45', N'telefon', 7499.00);
INSERT INTO eshopAPI.dbo.Products (Id, Name, ImgUri, Description, Price) VALUES (1004, N'Corsair K70', N'https://cdn.alza.cz/ImgW.ashx?fd=f16&cd=dasc21a', null, 999.00);
INSERT INTO eshopAPI.dbo.Products (Id, Name, ImgUri, Description, Price) VALUES (1005, N'Gigabyte GeForce RTX 3060 ELITE 12G', N'https://cdn.alza.cz/ImgW.ashx?fd=f16&cd=ASDW12s5c', N'Výkonná herní grafická karta', 12000.00);
INSERT INTO eshopAPI.dbo.Products (Id, Name, ImgUri, Description, Price) VALUES (1006, N'Gigabyte GeForce RTX 3080', N'https://cdn.alza.cz/ImgW.ashx?fd=f16&cd=ghjgL14', null, 26999.00);
INSERT INTO eshopAPI.dbo.Products (Id, Name, ImgUri, Description, Price) VALUES (1007, N'Intel Core i7-10700K', N'https://cdn.alza.cz/ImgW.ashx?fd=f16&cd=DSAW1', null, 8900.00);
INSERT INTO eshopAPI.dbo.Products (Id, Name, ImgUri, Description, Price) VALUES (1008, N'AMD Ryzen 5 5600X', N'https://cdn.alza.cz/ImgW.ashx?fd=f16&cd=DSAW1', null, 6600.00);
INSERT INTO eshopAPI.dbo.Products (Id, Name, ImgUri, Description, Price) VALUES (1009, N'Corsair Vengeance RGB PRO 32GB', N'https://cdn.alza.cz/ImgW.ashx?fd=f16&cd=DSAW1', N'Vysoce kvalitní paměti typu DDR4', 5300.00);
INSERT INTO eshopAPI.dbo.Products (Id, Name, ImgUri, Description, Price) VALUES (1010, N'Corsair Value Select 8GB DDR4', N'https://cdn.alza.cz/ImgW.ashx?fd=f16&cd=DSAW1', N'Vysoce kvalitní paměti typu DDR4', 1300.00);
INSERT INTO eshopAPI.dbo.Products (Id, Name, ImgUri, Description, Price) VALUES (1011, N'ASUS PRIME Z590-P', N'https://cdn.alza.cz/ImgW.ashx?fd=f16&cd=ghjgL14', N'Výkonná základní deska', 4999.00);
INSERT INTO eshopAPI.dbo.Products (Id, Name, ImgUri, Description, Price) VALUES (1012, N'Gigabyte B660M GAMING', N'https://cdn.alza.cz/ImgW.ashx?fd=f16&cd=ASDW12s5c', N'Výkonná základní deska', 2800.00);
INSERT INTO eshopAPI.dbo.Products (Id, Name, ImgUri, Description, Price) VALUES (1013, N'ASUS ROG THOR 850P - 850W', N'https://cdn.alza.cz/ImgW.ashx?fd=f16&cd=dasc21a', N'Vysoce kvalitní a účinný napájecí zdroj', 4700.00);
INSERT INTO eshopAPI.dbo.Products (Id, Name, ImgUri, Description, Price) VALUES (1014, N'Seasonic Focus Gold - 650W', N'https://cdn.alza.cz/ImgW.ashx?fd=f16&cd=DSAW1', N'Spolehlivý ATX zdroj s výkonem 650W', 2500.00);
INSERT INTO eshopAPI.dbo.Products (Id, Name, ImgUri, Description, Price) VALUES (1015, N'Samsung SSD 980', N'https://cdn.alza.cz/ImgW.ashx?fd=f16&cd=WG1090', N'SSD', 3200.00);
INSERT INTO eshopAPI.dbo.Products (Id, Name, ImgUri, Description, Price) VALUES (1016, N'Seagate BarraCuda', N'https://cdn.alza.cz/ImgW.ashx?fd=f16&cd=dasc21a', N'3.5" - 2TB', 1400.00);
INSERT INTO eshopAPI.dbo.Products (Id, Name, ImgUri, Description, Price) VALUES (1017, N'Corsair iCUE 220T', N'https://cdn.alza.cz/ImgW.ashx?fd=f16&cd=ASDW12s5c', null, 2800.00);
INSERT INTO eshopAPI.dbo.Products (Id, Name, ImgUri, Description, Price) VALUES (1018, N'Cooler Master MasterBox K501L', N'https://cdn.alza.cz/ImgW.ashx?fd=f16&cd=WG1090', null, 1500.00);
INSERT INTO eshopAPI.dbo.Products (Id, Name, ImgUri, Description, Price) VALUES (1019, N'Gigabyte ATC800', N'https://cdn.alza.cz/ImgW.ashx?fd=f16&cd=ASDW12s5c', N'Vysoce výkonný a tichý chladič CPU', 2500.00);
INSERT INTO eshopAPI.dbo.Products (Id, Name, ImgUri, Description, Price) VALUES (1020, N'Be quiet! Dark Rock PRO 4', N'https://cdn.alza.cz/ImgW.ashx?fd=f16&cd=JKG5', null, 2300.00);
INSERT INTO eshopAPI.dbo.Products (Id, Name, ImgUri, Description, Price) VALUES (1021, N'Logitech MX Keys', N'https://cdn.alza.cz/ImgW.ashx?fd=f16&cd=dasc21a', null, 2500.00);
INSERT INTO eshopAPI.dbo.Products (Id, Name, ImgUri, Description, Price) VALUES (1022, N'Razer Huntsman V2', N'https://cdn.alza.cz/ImgW.ashx?fd=f16&cd=ghjgL14', null, 7600.00);
INSERT INTO eshopAPI.dbo.Products (Id, Name, ImgUri, Description, Price) VALUES (1023, N'Razer Viper Ultimate', N'https://cdn.alza.cz/ImgW.ashx?fd=f16&cd=dasc21a', N'Optická myš se symetrickým tvare', 4500.00);
INSERT INTO eshopAPI.dbo.Products (Id, Name, ImgUri, Description, Price) VALUES (1024, N'Logitech G Pro X Superlight', N'https://cdn.alza.cz/ImgW.ashx?fd=f16&cd=WG1090', N'Herní myš. Vysoce kvalitní a lehká', 3800.00);
