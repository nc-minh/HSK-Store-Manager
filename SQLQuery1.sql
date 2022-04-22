create database BTL_HuongSukien
use BTL_HuongSukien

go

create table tbl_PhoneBrand
(
	sBrandID varchar(50) not null primary key,
	sBrandName varchar(50)
)

go

create table tbl_Phone
(
	sPhoneID varchar(50) not null primary key,
	sBrandID varchar(50),
	sPhoneModel varchar(50),
	iQuantity int,
	iPrice int,

	constraint FK_BrandID_Phone foreign key(sBrandID) references tbl_PhoneBrand(sBrandID)
)

go

Create table tbl_Staff
(
	iStaffID int not null IDENTITY(1,1) primary key,
	sFullName varchar(100) not null,
	sAddress varchar(100) not null,
	dDateOfBirth date,
	sPhoneNumber varchar(12),
	fBasicSalary float,
	fGrant float,
)

go

create table tbl_Customer
(
	iCustomerID int not null IDENTITY(1,1) primary key,
	sFullName varchar(100),
	sAddress varchar(100),
	dDateOfBirth date,
	sGender varchar(10),--male, female
	sPhoneNumber varchar(12)
)

go

create table tbl_Orders
(
	iOrdersID int not null IDENTITY(1,1) primary key,
	iCustomerID int not null,
	iStaffID int not null,
	dOrdersDate date not null,

	constraint FK_CustomerID_Orders foreign key(iCustomerID) references tbl_Customer(iCustomerID),
	constraint FK_StaffID_Orders foreign key (iStaffID) references tbl_Staff(iStaffID)
)

go

create table tbl_OrdersDetails
(
	iOrdersID int,
	sPhoneID varchar(50),
	iQuantity int,
	iPrice int,

	constraint FK_OrdersID_OrdersDetails foreign key(iOrdersID) references tbl_Orders(iOrdersID),
	constraint FK_PhoneID_OrdersDetails foreign key(sPhoneID) references tbl_Phone(sPhoneID)
)

go

----------------------- INSERT DATA INTO TABLEs -----------------------
-- Insert data into tbl_PhoneBrand
insert into tbl_PhoneBrand
values('IP', 'Iphone')

insert into tbl_PhoneBrand
values('SS', 'Samsung')

insert into tbl_PhoneBrand
values('VS', 'Vsmart')

insert into tbl_PhoneBrand
values('MI', 'Xiaomi')

insert into tbl_PhoneBrand
values('Op', 'Oppo')

insert into tbl_PhoneBrand
values('Hua', 'Huawei')

select * from tbl_PhoneBrand
go

-- Insert data into tbl_Phone
insert into tbl_Phone
values('IP5', 'IP', 'Iphone 5', 25, 850000)

insert into tbl_Phone
values('IP5s', 'IP', 'Iphone 5s', 5, 1200000)

insert into tbl_Phone
values('IP6', 'IP', 'Iphone 6', 55, 1500000)

insert into tbl_Phone
values('IP6s', 'IP', 'Iphone 6s', 35, 1850000)

insert into tbl_Phone
values('IP7', 'IP', 'Iphone 7', 85, 3500000)

insert into tbl_Phone
values('IP7s', 'IP', 'Iphone 7s', 15, 3500000)

select * from tbl_Phone
go

-- Insert data into tbl_Staff
insert into tbl_Staff
values('Nguyen Cong Minh', 'Ha Noi', '1998-12-25', '0989989639', 75000000, 5000000)

insert into tbl_Staff
values('Nguyen Xuan Ngoc', 'Ha Noi', '2001-02-21', '0989989639', 50000000, 1500000)

insert into tbl_Staff
values('Dinh Thi Thu Hien', 'Ha Noi', '2001-02-21', '0989989639', 8000000, 1500000)

insert into tbl_Staff
values('Nguyen Huu Vu', 'Ha Noi', '2001-02-21', '0989989639', 7000000, 1500000)

insert into tbl_Staff
values('Tran Van Nam', 'Ha Noi', '2001-05-30', '0989989639', 15000000, 1500000)

select * from tbl_Staff
go

-- Insert data into tbl_Customer
insert into tbl_Customer
values('Bao Nhat', 'Hung Yen', '2000-01-27', 'male', '0989989639')

insert into tbl_Customer
values('Hoang', 'Thai Binh', '2002-09-25', 'male', '0989989639')

select * from tbl_Customer
go

-- Insert data into tbl_Orders
insert into tbl_Orders
values(1, 1, '2022-04-15')

insert into tbl_Orders
values(2, 2, '2022-04-15')

insert into tbl_Orders
values(1, 3, '2022-04-15')

select * from tbl_Orders
go

-- Insert data into tbl_OrdersDetails
insert into tbl_OrdersDetails
values(1, 'IP5', 1, 850000)

insert into tbl_OrdersDetails
values(2, 'IP7', 2, 3500000)

insert into tbl_OrdersDetails
values(3, 'IP5s', 1, 1200000)
	
select * from tbl_OrdersDetails
go

------------------- Create proc ------------------------

------------------- Brand -------------------
-- show all th brand
----------------------------------------
create proc showAllBrand
as
begin
select * from tbl_PhoneBrand
end

exec showAllBrand
go
----------------------------------------

-- proc add a new brand
----------------------------------------
create proc addNewBrand (@sBrandID varchar(50), @sBrandName varchar(50))
as
insert into tbl_PhoneBrand(sBrandID, sBrandName)
values( @sBrandID, @sBrandName)

exec addNewBrand @sBrandID='test', @sBrandName='testt'
go
----------------------------------------

-- proc delete a brand
----------------------------------------
create proc deleteBrand (@sBrandID varchar(50))
as
delete from tbl_PhoneBrand where sBrandID = @sBrandID

exec deleteBrand @sBrandID='test'
go
----------------------------------------

-- proc update a brand
----------------------------------------
create proc updateBrand (@sBrandID varchar(50), @sBrandName varchar(50))
as
begin
update tbl_PhoneBrand
set sBrandName = @sBrandName
where sBrandID = @sBrandID
end
go
----------------------------------------

------------------- Phone -------------------
-- proc show phone list with brand name
----------------------------------------
create proc searchPhone (@sPhoneModel varchar(50))
as
select sBrandName as N'Hãng Điện Thoại', sPhoneID as N'Mã Điện Thoại', sPhoneModel as N'Tên Điện Thoại',
iQuantity as N'Số Lượng', iPrice as N'Giá Bán' from tbl_Phone
inner join tbl_PhoneBrand
on tbl_Phone.sBrandID = tbl_PhoneBrand.sBrandID
where sPhoneModel LIKE '%' + @sPhoneModel + '%'

exec searchPhone @sPhoneModel='xiaomi'
go
----------------------------------------

-- proc show all phone
----------------------------------------
create proc showAllPhone
as
begin
select sPhoneID as [Mã điện thoại] , tbl_PhoneBrand.sBrandID as [Mã Hãng Điện Thoại], sPhoneModel as [Tên Điện Thoại],
iQuantity as [Số Lượng], iPrice as [Giá Bán]
from tbl_Phone inner join tbl_PhoneBrand on tbl_Phone.sBrandID = tbl_PhoneBrand.sBrandID
end

exec showAllPhone
go
----------------------------------------

-- proc add a new phone
----------------------------------------
create proc addNewPhone (@sPhoneID varchar(50), @sBrandID varchar(50), @sPhoneModel varchar(50), @iQuantity int, @iPrice int)
as
insert into tbl_Phone(sPhoneID, sBrandID, sPhoneModel, iQuantity, iPrice)
values(@sPhoneID, @sBrandID, @sPhoneModel, @iQuantity, @iPrice)

exec addNewPhone @sPhoneID='IP8', @sBrandID='IP', @sPhoneModel='Iphone 8', @iQuantity=14, @iPrice=9000000
go
----------------------------------------

-- proc update a phone
----------------------------------------
create proc updatePhone (@sPhoneID varchar(50), @sBrandID varchar(50), @sPhoneModel varchar(50), @iQuantity int, @iPrice int)
as
begin
update tbl_Phone
set sBrandID = @sBrandID, sPhoneModel = @sPhoneModel, iQuantity = @iQuantity, iPrice = @iPrice
where sPhoneID = @sPhoneID
end

go
----------------------------------------

-- proc delete a new phone
----------------------------------------
create proc deletePhone (@sPhoneID varchar(50))
as
delete from tbl_Phone where sPhoneID = @sPhoneID

exec deletePhone @sPhoneID='IP5'
go
----------------------------------------

------------------- Staff -------------------
-- proc show staff list with fullName
----------------------------------------
create proc searchStaff (@sFullName varchar(100))
as
select iStaffID as N'Mã Nhân Viên', sFullName as N'Tên Nhân Viên', sAddress as N'Địa Chỉ',
dDateOfBirth as N'Ngày Sinh', sPhoneNumber as N'Số ĐT', fBasicSalary as N'Lương CB', fGrant as N'Phụ Cấp' from tbl_Staff
where sFullName LIKE '%' + @sFullName + '%'

exec searchStaff @sFullName = 'Minh'
go
----------------------------------------

-- proc show all phone
----------------------------------------
create proc showAllStaff
as
begin
select iStaffID as [Mã Nhân Viên], sFullName as [Tên Nhân Viên], sAddress as [Địa Chỉ],
dDateOfBirth as [Ngày Sinh], sPhoneNumber as [Số Điện Thoại], fBasicSalary as [Lương Cơ Bản], fGrant as [Phụ Cấp] from tbl_Staff
end

exec showAllStaff
go
----------------------------------------

-- proc add a new Staff
----------------------------------------
create proc addNewStaff (@sFullName varchar(100), @sAddress varchar(100), @dDateOfBirth date, 
@sPhoneNumber varchar(12), @fBasicSalary float, @fGrant float)
as
insert into tbl_Staff(sFullName, sAddress, dDateOfBirth, sPhoneNumber, fBasicSalary, fGrant)
values( @sFullName, @sAddress, @dDateOfBirth, @sPhoneNumber, @fBasicSalary, @fGrant)

exec addNewStaff @sFullName='test', @sAddress='test', @dDateOfBirth='2000-02-02', @sPhoneNumber='132465', @fBasicSalary=12, @fGrant=1
go
----------------------------------------

-- proc delete a Staff
----------------------------------------
create proc deleteStaff (@iStaffID int)
as
delete from tbl_Staff where iStaffID = @iStaffID

exec deleteStaff @iStaffID=6
go
----------------------------------------

-- proc update a Staff
----------------------------------------
create proc updateStaff (@iStaffID int, @sFullName varchar(100), @sAddress varchar(100), @dDateOfBirth date, 
@sPhoneNumber varchar(12), @fBasicSalary float, @fGrant float)
as
begin
update tbl_Staff
set sFullName = @sFullName, sAddress = @sAddress, dDateOfBirth = @dDateOfBirth,
sPhoneNumber = @sPhoneNumber, fBasicSalary = @fBasicSalary, fGrant = @fGrant
where iStaffID = @iStaffID
end

go
----------------------------------------

------------------- Customer -------------------
-- proc show all Customer
----------------------------------------
create proc showAllCustomer
as
begin
select iCustomerID as [Mã Khách Hàng], sFullName as [Tên Khách Hàng], sAddress as [Địa Chỉ],
dDateOfBirth as [Ngày Sinh], sGender as [Giới Tính], sPhoneNumber as [Số Điện Thoại] from tbl_Customer
end

exec showAllCustomer
go
----------------------------------------

-- proc add a new Customer
----------------------------------------
create proc addNewCustomer (@sFullName varchar(100), @sAddress varchar(100), @dDateOfBirth date, 
@sGender varchar(10), @sPhoneNumber varchar(12))
as
insert into tbl_Customer(sFullName, sAddress, dDateOfBirth, sGender, sPhoneNumber)
values(@sFullName, @sAddress, @dDateOfBirth, @sGender, @sPhoneNumber)

exec addNewCustomer @sFullName='test', @sAddress='test', @dDateOfBirth='2000-02-02', @sGender='female', @sPhoneNumber='132'
go
----------------------------------------

-- proc delete a Customer
----------------------------------------
create proc deleteCustomer (@iCustomerID int)
as
delete from tbl_Customer where iCustomerID = @iCustomerID

exec deleteCustomer @iCustomerID=5
go
----------------------------------------

-- proc update a Customer
----------------------------------------
create proc updateCustomer (@iCustomerID int, @sFullName varchar(100), @sAddress varchar(100), 
@dDateOfBirth date, @sGender varchar(10), @sPhoneNumber varchar(12))
as
begin
update tbl_Customer
set sFullName = @sFullName, sAddress = @sAddress, dDateOfBirth = @dDateOfBirth, sGender = @sGender, sPhoneNumber = @sPhoneNumber
where iCustomerID = @iCustomerID
end

go
----------------------------------------

------------------- Orders -------------------
-- proc show all Orders
----------------------------------------
create proc showAllOrders
as
begin
select iOrdersID as [Mã Orders], tbl_Customer.sFullName as [Tên Khách Hàng], tbl_Staff.sFullName as [Tên Nhân Viên], 
dOrdersDate as [Ngày Orders] from tbl_Orders
inner join tbl_Staff on tbl_Orders.iStaffID = tbl_Staff.iStaffID
inner join tbl_Customer on tbl_Orders.iCustomerID = tbl_Customer.iCustomerID
end

exec showAllOrders
go
----------------------------------------

-- proc add a new Orders
----------------------------------------
create proc addNewOrders (@iCustomerID int, @iStaffID int, @dOrdersDate date)
as
insert into tbl_Orders(iCustomerID, iStaffID, dOrdersDate)
values(@iCustomerID, @iStaffID, @dOrdersDate)

exec addNewOrders @iCustomerID = 1, @iStaffID = 1, @dOrdersDate = '2022-01-01'
go
----------------------------------------

-- proc delete a Orders
----------------------------------------
create proc deleteOrders (@iOrdersID int)
as
delete from tbl_Orders where iOrdersID = @iOrdersID

exec deleteOrders @iOrdersID=3
go
----------------------------------------

-- proc update a Orders
----------------------------------------
create proc updateOrders (@iOrdersID int, @iCustomerID int, @iStaffID int, @dOrdersDate date)
as
begin
update tbl_Orders
set iCustomerID = @iCustomerID, iStaffID = @iStaffID, dOrdersDate = @dOrdersDate
where iOrdersID = @iOrdersID
end

go
----------------------------------------