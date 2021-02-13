Create table Brands(
BrandId int,
BrandName varchar(10))
Create table Colors(
ColorId int,
BrandName varchar(10))
Create table Cars(
CarId int,
BrandId int,
ColorId int,
ModelYear int,
Description varchar(100),
DailyPrice decimal,
)