create database LogoMarket
use LogoMarket

create table YapilanLogolar(
uyeid int,
Constraint fk_UyelerVeBilgileri_YapilanLogolar foreign key(uyeid) References UyelerVeBilgileri(uyeid) on delete cascade on update cascade,
logoid int primary key identity(1,1) not null,
logoaciklama nvarchar(200),
olusturankisi nvarchar(15) not null,
teklifedenkisi nvarchar(15) not null,
logofiyati float not null,logourl nvarchar(100)not null,logosayisi int);

create table Teklifler(
uyeid int,
Constraint fk_UyelerVeBilgileri_Teklifler foreign key (uyeid) References UyelerVeBilgileri(uyeid) on delete cascade on update cascade,
teklifno int primary key identity(1,1) not null,
teklifedenkisi nvarchar(15)not null,teklifaciklamasi nvarchar(200)not null,
tekliffiyati float not null,teklifsayisi int);

create table Sehirler(sehirplaka tinyint primary key not null,sehiradi nvarchar(15) not null);

create table UyelerVeBilgileri(
uyeid int primary key identity(1,1) not null,
uyekuladi nvarchar(15) not null,
uyesifre nvarchar(20) not null,
uyeadsoyad nvarchar(20) not null,
uyedt smalldatetime not null,
uyeemail nvarchar(25) not null,
uyetelno int,
uyecinsiyet bit not null,
uyesehir tinyint not null,
constraint fk_Sehirler_UyelerVeBilgileri foreign key(uyesehir) References Sehirler(sehirplaka) on delete cascade on update cascade,
uyelogosayisi int,
uyeteklifsayisi int);


drop table YapilanLogolar
drop table Teklifler
drop table ÜyelerVeBilgileri