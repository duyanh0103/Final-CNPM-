﻿create database quanlykho
go

--CREATE TABLE
--ACCOUNT
create table ACCOUNT
(
	ID_USER INT IDENTITY PRIMARY KEY,
	USENAME VARCHAR (30),
	NAME_USER NVARCHAR(200),
	PASSWORD VARCHAR(30),
	EMAIL VARCHAR(50),	
)

--SAN PHAM
create table PRODUCT
(
	IDSANPHAM VARCHAR(10) PRIMARY KEY,
	TENSANPHAM NVARCHAR(200),
	UNIT nvarchar(20)not null,
	--ID_SUPPLIER VARCHAR(10) not null FOREIGN KEY REFERENCES SUPPLIER(ID_SUPPLIER),
	SOLUONG int,
	ID_LOAISP INT NOT NULL FOREIGN KEY REFERENCES PRODUCTTYPE(ID_LOAISP),
	GIANHAP float,
	GIABAN float
)
GO
DROP TABLE PRODUCT

create table PRODUCTTYPE
(
	ID_LOAISP INT IDENTITY PRIMARY KEY,
	NAME_LOAISP NVARCHAR (MAX)NOT NULL 
)
GO
--DON Vi
create table UNIT
(
	ID_UNIT INT IDENTITY PRIMARY KEY,
	TENDONVI NVARCHAR (100)
)
GO


--SUPPLIER
CREATE TABLE SUPPLIER
(
	ID_SUPPLIER VARCHAR (10) PRIMARY KEY,
	TEN_NCC NVARCHAR(100),
	DIACHI_NCC NVARCHAR(100),
	PHONE_NCC CHAR(10),
	EMAIL_NCC VARCHAR(50)
)
GO

--DAILY
CREATE TABLE DAILY
(	
	ID_DAILY INT IDENTITY PRIMARY KEY,
	TENDAILY NVARCHAR(200),
	DIACHI_DAILY NVARCHAR(100),
	EMAIL_DAILY VARCHAR(50),
	PHONE_DAILY CHAR(10)

)
GO

CREATE TABLE INPUTKHO
(	
	ID_INPUT int identity PRIMARY KEY,
	NAMEINPUT NVARCHAR(MAX),
	
)
GO

--INPUTINFO --TONG HOA DON
CREATE TABLE INPUTINFO
(
	ID_INPUTINFO INT IDENTITY PRIMARY KEY,
	IDSANPHAM VARCHAR(10) ,--not null FOREIGN KEY REFERENCES PRODUCT(IDSANPHAM),
	TENSANPHAM NVARCHAR(200),
	ID_INPUT int not null FOREIGN KEY REFERENCES INPUTKHO(ID_INPUT),
	SOLUONG INT,
	DATE_INPUT datetime,
	GIANHAP MONEY,
	GIABAN MONEY 
)
GO
DROP TABLE INPUTINFO
--OUTPUT
CREATE TABLE OUTPUTKHO
(
	ID_OUTPUT INT IDENTITY PRIMARY KEY,
	ID_DAILY INT not null FOREIGN KEY REFERENCES DAILY(ID_DAILY), --lay ten dai ly
	STATUSPAYMENT INT DEFAULT 0,--0 LÀ CHuA TRa 1 LÀ tra roi
	PAYMENT NVARCHAR(MAX) DEFAULT 'CASH',
	DELIVERYSTATUS NVARCHAR(MAX) DEFAULT 'Waiting',
	DATE_OUTPUT datetime
)
GO
DROP TABLE OUTPUTKHO
--OUTPUTINFOR
CREATE TABLE OUTPUTINFO
(
	ID_OUTPUTINFO INT IDENTITY PRIMARY KEY,
	IDSANPHAM VARCHAR(10) not null FOREIGN KEY REFERENCES PRODUCT(IDSANPHAM),
	ID_OUTPUT INT  not null FOREIGN KEY REFERENCES OUTPUTKHO(ID_OUTPUT),
	SOLUONG INT not null default 0
)
GO
DROP TABLE OUTPUTINFO

--insert account
INSERT INTO ACCOUNT VALUES ('duyanh01',N'Võ Nguyễn Duy Anh','abc123','duyanh41511@gmail.com');
INSERT INTO ACCOUNT VALUES ('kimlam',N'Thanh Nguyễn Kim Lâm','ab123','kl123@gmail.com')
INSERT INTO ACCOUNT VALUES ('shishiba',N'Lê Ngọc Thanh Thủy','abc1234','tt123@gmail.com') 
INSERT INTO ACCOUNT VALUES ('thalz',N'Lê Thanh','12345','thanhthanh123@gmail.com')

select * 
from account
delete ACCOUNT

--insert daily
INSERT INTO DAILY VALUES (N'Pharmacy',N'300 Nguyễn Chí Thanh','pharmacynct@gmail.com','0987654323')
INSERT INTO DAILY VALUES (N'Thanh Bình',N'32 Nguyễn Thị Thập','tb32ntt@gmail.com','0897654321')
INSERT INTO DAILY VALUES (N'Pharmacy',N'567 Huỳnh Tấn Phát','pharmacyhtp@gmail.com','0891234567')
INSERT INTO DAILY VALUES (N'Huệ Hùng',N'123 Nguyễn Hữu Thọ','huehung123@gmail.com','0987654345')

select * 
from DAILY

--Nhà cung c?p
INSERT INTO SUPPLIER VALUES ('BTD',N'CÔNG TY TRÁCH NHIỆM HỮU HẠN BÁCH THẢO DƯỢC',N'Lô Q-6, Khu Công Nghiệp Tràng Duệ, Thuộc Khu Kinh Tế Đình Vũ – Cát Hải, Xã An Hoà','0987644345','btd@gmail.com')
INSERT INTO SUPPLIER VALUES ('NB',N'CÔNG TY  TNHH NUBEST',N'13 S7, Tây Thạnh, Tân Phú, TP. HCM','0987653678','nb13@gmail.com')
INSERT INTO SUPPLIER VALUES ('TT',N'CÔNG TY CỔ PHẦN PHÂN PHỐI TRÍ TÍN',N'53 Đường Số 12, Phường Hiệp Bình Chánh, Quận Thủ Đức','0987654345','tritin@gmail.com')
INSERT INTO SUPPLIER VALUES ('HT',N'CÔNG TY CỔ PHẦN THƯƠNG MẠI DỊCH VỤ SẢN XUẤT HƯƠNG THỦY',N'C10, 39 Khu Nhà Ở Tại Phân Khu 18A, Đường Nguyễn Hữu Thọ, X. Phước Kiến, H. Nhà Bè','0981234123','huongthuy@gmail.com')

select * 
from SUPPLIER

--insert don vi
INSERT INTO UNIT VALUES (N'viên')
INSERT INTO UNIT VALUES (N'ml')
select * 
from UNIT

--LOAI SAN PHAM
INSERT INTO PRODUCTTYPE VALUES(N'CHIỀU CAO')
INSERT INTO PRODUCTTYPE VALUES(N'CÂN NẶNG')
INSERT INTO PRODUCTTYPE VALUES(N'XƯƠNG KHỚP')
INSERT INTO PRODUCTTYPE VALUES(N'SỨC KHỎE')
select * 
from PRODUCTTYPE

--PRODUCT

INSERT INTO PRODUCT VALUES ('TPBVSK LHD',N'TPBVSK LIỄU HOÀN ĐAN',N'viên',120,4,120000,150000)
INSERT INTO PRODUCT VALUES ('TPBVSK BAK',N'TPBVSK BẢO AN KHỚP',N'viên',120,3,123000,140000)
INSERT INTO PRODUCT VALUES ('TTC',N'Doctor Plus',N'viên',120,1,50000,60000)
INSERT INTO PRODUCT VALUES ('CACI',N'Calcium Corbiere',N'ống',120,1,80000,90000)
INSERT INTO PRODUCT VALUES ('ABC',N'ABOUT CANXI',N'viên',110,1,80000,90000)
INSERT INTO PRODUCT VALUES ('IMF',N'Imga Fitness',N'viên',10,4,80000,90000)
INSERT INTO PRODUCT VALUES ('LOG',N'Longlife guide',N'viên',20,1,80000,90000)
INSERT INTO PRODUCT VALUES ('OM',N'Orange Mix',N'ống',100,1,80000,90000)


select * 
from PRODUCT



-- inputkho
INSERT INTO INPUTKHO VALUES (N'HÓA ĐƠN 30/12/2021')
INSERT INTO INPUTKHO VALUES (N'HÓA ĐƠN 21/12/2021')
select * 
from INPUTKHO
delete inputkho


-- inputinfo
INSERT INTO INPUTINFO VALUES ('TPBVSK LHD',N'TPBVSK LIỄU HOÀN ĐAN',1,10,GETDATE(),1200000,1500000)
INSERT INTO INPUTINFO VALUES ('TPBVSK LHD',N'TPBVSK BẢO AN KHỚP',1,10,GETDATE(),140000,160000)
INSERT INTO INPUTINFO VALUES ('TTC LHD',N'Doctor Plus',1,10,GETDATE(),1234000,150000)
INSERT INTO INPUTINFO VALUES ('TPBVSK LHD',N'TPBVSK LIỄU HOÀN ĐAN',1,10,GETDATE(),160000,200000)
INSERT INTO INPUTINFO VALUES ('TPBVSK LHD',N'TPBVSK LIỄU HOÀN ĐAN',2,10,'2021-12-21',1200000,1500000)
INSERT INTO INPUTINFO VALUES ('CACI',N'Calcium Corbiere',2,10,'2021-12-21',2000000,2500000)
select * 
from INPUTINFO
delete INPUTINFO

--outputkho			ID_DAILY,STATUSPAYMENT,PAYMENT,DELIVERY,DATE_OUTPUT
insert into OUTPUTKHO values(1,0,N'Banking: ACB',N'waiting',GETDATE())--1
insert into OUTPUTKHO values(1,1,N'cash',N'In transit',GETDATE())	  --2
insert into OUTPUTKHO values(2,1,N'Banking: Citibank',N'In transit',GETDATE()) --3
insert into OUTPUTKHO values(4,1,N'Banking: VietcomBank',N'Delivered','2021-10-1')--4
insert into OUTPUTKHO values(3,0,N'Banking: ACB',N'waiting','2022-01-02') --5
select * from OUTPUTKHO
select * from outputkho where  statuspayment = 0

--outputinfo					idsanpham,id_output,soluong	
insert into OUTPUTINFO values('CACI',1,14)
insert into OUTPUTINFO values('CACI',2,12)
insert into OUTPUTINFO values('CACI',3,10)
insert into OUTPUTINFO values('CACI',4,20)
insert into OUTPUTINFO values('CACI',1,14)
insert into OUTPUTINFO values('TPBVSK LHD',5,14)
select * from OUTPUTINFO
select * from outputinfo where ID_OUTPUT = 2


select p.TENSANPHAM, OI.SOLUONG, P.GIABAN, ok.STATUSPAYMENT,ok.PAYMENT, ok.DELIVERYSTATUS, ok.DATE_OUTPUT ,P.GIABAN * OI.SOLUONG AS N'ĐƠN GIÁ' from outputinfo oi, outputkho ok, product p
where oi.ID_OUTPUT = ok.ID_OUTPUT AND oi.IDSANPHAM = p.IDSANPHAM AND OK.ID_DAILY = 1





--tạo proc
--sản phẩm
create proc productProc_getProductByDisplayName
@tensanpham nvarchar(200)
as
begin
	select * from dbo.product where tensanpham = @tensanpham
end
go

exec dbo.productProc_getProductByDisplayName @tensanpham = N'Doctor Plus'

create proc productProc_getProductByDisplayName
@tensanpham nvarchar(200)
as
begin
	select * from dbo.product where tensanpham = @tensanpham
end
go


--đại lý
create proc dailyProc_getAgentsList
as select * from DAILY
go

exec dbo.dailyProc_getAgentsList