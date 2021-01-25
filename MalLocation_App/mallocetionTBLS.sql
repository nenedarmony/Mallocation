
create table malls_tbl
(
MallID int identity(1,1) primary key,
MallName nvarchar(20) not null ,
CurentLat float,
CurentLang float,
)

create table categorys_tbl
(
CategoryID  int identity(1,1) primary key,
Category nvarchar (20) not null,
)
/*לבדוק אם אפשר למחוק את הטבלה הזאת לדעתי היא לא נחוצה */
create table audiences_tbl
(
AudienceID  int identity(1,1) primary key,
AudienceName nvarchar (20) not null,
)

create table shops_tbl
(
ShopID int identity(1,1) primary key,
ShopName nvarchar(20) not null,
IdFromAudience int ,
foreign key (IdFromAudience) references audiences_tbl(AudienceID)
)

create table shopsInMall_tbl
(
shopInMallID int identity(1,1) primary key,
IdFromMall int ,
foreign key  (IdFromMall) references malls_tbl(MallID),
IdFromShop int ,
 foreign key (IDFromShop) references shops_tbl(ShopID),
)

create table categorys_in_shop
(
categoryInShopID int identity(1,1) primary key,
IdFromCategory int ,
foreign key (IdFromCategory) references categorys_tbl(CategoryID),
IdFromShop int ,
foreign key (IDFromShop)  references shops_tbl(ShopID),
)


create table custumers_tbl
(
CustumerID int identity(1,1) primary key,
CustumerName nvarchar (20) not null,
)

create table custumer_historys_tbl
(
CustumerHistorysID int identity(1,1) primary key,
IDFromShop int ,
foreign key (IDFromShop)  references shops_tbl(ShopID),
IDfromUser int ,
foreign key (IDfromUser)  references custumers_tbl(CustumerID),
NumOfTimeGoToShope int , 
 NumOfTimeWasSatified int ,
 )

 /*insert*/
 insert into categorys_tbl values('אופנת נשים')
 insert into categorys_tbl values('ציוד ספורט ')
 insert into categorys_tbl values(' נעלי נשים')
 insert into categorys_tbl values('מסעדות')
 insert into categorys_tbl values('פארם')
 insert into categorys_tbl values('ספרים')
 insert into categorys_tbl values('אופטיקה')
 insert into categorys_tbl values('אופנת גברים')
 insert into categorys_tbl values('הלבשה תחתונה ')
 insert into categorys_tbl values('הנעלת ילדים ותינוקות')
 insert into categorys_tbl values('אופנת ילדים ותינוקות ')
 insert into categorys_tbl values('חדר כושר')
 insert into categorys_tbl values('מוצרי חשמל מחשב וסוללרי ')
 insert into categorys_tbl values('מוצרי בית')
 insert into categorys_tbl values('הנעלת גברים')
 insert into categorys_tbl values('סופרמרקט')
 insert into categorys_tbl values('ציוד משרדי')
 insert into categorys_tbl values('קוסמטיקה ויופי ')
 insert into categorys_tbl values(' תיקים ואקססוריז')
 insert into categorys_tbl values('תכשיטים')

  insert into shops_tbl values('תכשיטים')