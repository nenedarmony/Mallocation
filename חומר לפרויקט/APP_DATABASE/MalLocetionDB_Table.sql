
create table mall_tbl
(
MallID int identity(1,1) primary key,
MallName varchar(20) not null ,
CurentLat float,
CurentLang float,
)

create table category_tbl
(
CategoryID  int identity(1,1) primary key,
Category varchar (20) not null,
)

create table audience_tbl
(
AudienceID  int identity(1,1) primary key,
AudienceName varchar (20) not null,
)

create table shop_tbl
(
ShopID int identity(1,1) primary key,
ShopName varchar(20) not null,
IdFromAudience int ,
foreign key (IdFromAudience) references audience_tbl(AudienceID)
)

create table shopInMall_tbl
(
IdFromMall int ,
foreign key  (IdFromMall) references mall_tbl(MallID),
IdFromShop int ,
 foreign key (IDFromShop) references shop_tbl(ShopID),
)

create table category_in_shop
(
IdFromCategory int ,
foreign key (IdFromCategory) references category_tbl(CategoryID),
IdFromShop int ,
foreign key (IDFromShop)  references shop_tbl(ShopID),
)


create table custumer_tbl
(
CustumerID int primary key,
CustumerName varchar (20) not null,
)

create table custumer_history_tbl
(
IDFromShop int ,
foreign key (IDFromShop)  references shop_tbl(ShopID),
IDfromUser int ,
foreign key (IDfromUser)  references custumer_tbl(CustumerID),
NumOfTimeGoToShope int , 
 NumOfTimeWasSatified int ,
 )