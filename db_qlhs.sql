/*
Created		6/26/2021
Modified		7/10/2021
Project		
Model			
Company		
Author		
Version		
Database		MS SQL 2005 
*/
use master
create database db_qlhs
use db_qlhs

Create table [ThongTinCaNhan]
(
	[MaCN] Char(10) NOT NULL,
	[HoTen] Nvarchar(200) NULL,
	[Anh] Varchar(100) NULL,
	[Tuoi] Integer NOT NULL,
	[NgaySinh] Date NULL,
	[GioiTinh] Char(5) NULL,
	[DiaChi] Nvarchar(500) NULL,
	[SDT] Char(10) NULL,
Primary Key ([MaCN])
) 
go

Create table [HocSinh]
(
	[MaHS] Char(10) NOT NULL,
	[DiemDauVao] Float NULL,
	[MaCN] Char(10) NOT NULL,
	[MaLop] Char(10) NOT NULL,
Primary Key ([MaHS])
) 
go

Create table [NhanVien]
(
	[MaNV] Char(10) NOT NULL,
	[NgayBD] Date NOT NULL,
	[ChucVu] Nvarchar(50) NULL,
	[Level] Integer NULL,
	[MaCN] Char(10) NOT NULL,
Primary Key ([MaNV])
) 
go

Create table [GVCN]
(
	[MaGV] Char(10) NOT NULL,
	[NgayBD] Date NULL,
	[MaCN] Char(10) NOT NULL,
Primary Key ([MaGV])
) 
go

Create table [LopHoc]
(
	[MaLop] Char(10) NOT NULL,
	[TenLop] Nvarchar(50) NULL,
	[LoaiLop] Nvarchar(20) NULL,
	[MaGV] Char(10) NOT NULL,
	[NamHoc] Nvarchar(50) NULL,
	[MaKhoiLop] Char(10) NOT NULL,
Primary Key ([MaLop])
) 
go

Create table [MonHoc]
(
	[MaMon] Char(10) NOT NULL,
	[TenMon] Nvarchar(30) NULL,
	[MaGV] Char(10) NULL,
	[HeSo] Integer NULL,
Primary Key ([MaMon])
) 
go

Create table [TaiKhoan]
(
	[MaTK] Char(10) NOT NULL,
	[TaiKhoan] Char(32) NULL,
	[MatKhau] Char(32) NULL,
	[MaNV] Char(10) NOT NULL,
Primary Key ([MaTK])
) 
go

Create table [ThanhToan]
(
	[MaGD] Char(10) NOT NULL,
	[HocPhi] Money NULL,
	[PhiPhatSinh] Money NULL,
	[ThanhTien] Money NULL,
	[TinhTrang] Nvarchar(10) NULL,
	[MaHS] Char(10) NOT NULL,
Primary Key ([MaGD])
) 
go

Create table [Diem]
(
	[MaHS] Char(10) NOT NULL,
	[MaMon] Char(10) NOT NULL,
	[DiemTB] Decimal(18,0) NULL,
	[HanhKiem] Nvarchar(10) NULL,
	[MaKQ] Char(10) NOT NULL,
Primary Key ([MaHS],[MaMon])
) 
go

Create table [KetQua]
(
	[MaKQ] Char(10) NOT NULL,
	[DiemTK] Decimal(18,0) NULL,
	[LenLop] Nvarchar(20) NULL,
	[MaHK] Char(10) NOT NULL,
	[MaHanhKiem] Char(10) NOT NULL,
	[MaHocLuc] Char(10) NOT NULL,
Primary Key ([MaKQ])
) 
go

Create table [HocKy]
(
	[MaHK] Char(10) NOT NULL,
	[TenHocKy] Nvarchar(20) NULL,
	[HeSo] Integer NULL,
Primary Key ([MaHK])
) 
go

Create table [HocLuc]
(
	[MaHocLuc] Char(10) NOT NULL,
	[TenHocLuc] Nvarchar(50) NULL,
	[TuDiem] Float NULL,
	[DenDiem] Float NULL,
Primary Key ([MaHocLuc])
) 
go

Create table [HanhKiem]
(
	[MaHanhKiem] Char(10) NOT NULL,
	[LoaiHanhKiem] Nvarchar(30) NULL,
Primary Key ([MaHanhKiem])
) 
go

Create table [KhoiLop]
(
	[MaKhoiLop] Char(10) NOT NULL,
	[TenKhoi] Nvarchar(50) NULL,
Primary Key ([MaKhoiLop])
) 
go

Create table [LoaiDiem]
(
	[MaLoai] Char(10) NOT NULL,
	[LoaiDiem] Nvarchar(50) NULL,
	[HeSo] Integer NULL,
	[DiemSo] Float NULL,
	[MaHS] Char(10) NOT NULL,
	[MaMon] Char(10) NOT NULL,
Primary Key ([MaLoai])
) 
go

Create table [LichSuGiaoDich]
(
	[maLichSu] Nchar(10) NOT NULL,
	[ghiChu] Nvarchar(100) NULL,
	[MaGD] Char(10) NOT NULL,
Primary Key ([maLichSu])
) 
go


Alter table [NhanVien] add  foreign key([MaCN]) references [ThongTinCaNhan] ([MaCN])  on update cascade on delete cascade 
go
Alter table [GVCN] add  foreign key([MaCN]) references [ThongTinCaNhan] ([MaCN])  on update cascade on delete cascade 
go
Alter table [HocSinh] add  foreign key([MaCN]) references [ThongTinCaNhan] ([MaCN])  on update cascade on delete cascade 
go
Alter table [Diem] add  foreign key([MaHS]) references [HocSinh] ([MaHS]) on update cascade on delete cascade 
go
Alter table [ThanhToan] add  foreign key([MaHS]) references [HocSinh] ([MaHS])  on update cascade on delete cascade 
go
Alter table [TaiKhoan] add  foreign key([MaNV]) references [NhanVien] ([MaNV])  on update cascade on delete cascade 
go
Alter table [MonHoc] add  foreign key([MaGV]) references [GVCN] ([MaGV])  on update cascade on delete cascade 
go
Alter table [LopHoc] add  foreign key([MaGV]) references [GVCN] ([MaGV])  on update cascade on delete cascade 
go
Alter table [HocSinh] add  foreign key([MaLop]) references [LopHoc] ([MaLop])  on update cascade on delete cascade 
go
Alter table [Diem] add  foreign key([MaMon]) references [MonHoc] ([MaMon])  on update cascade on delete cascade 
go
Alter table [LichSuGiaoDich] add  foreign key([MaGD]) references [ThanhToan] ([MaGD])  on update cascade on delete cascade 
go
Alter table [LoaiDiem] add  foreign key([MaHS],[MaMon]) references [Diem] ([MaHS],[MaMon])  on update cascade on delete cascade
go
Alter table [Diem] add  foreign key([MaKQ]) references [KetQua] ([MaKQ])  on update cascade on delete cascade 
go
Alter table [KetQua] add  foreign key([MaHK]) references [HocKy] ([MaHK])  on update cascade on delete cascade 
go
Alter table [KetQua] add  foreign key([MaHocLuc]) references [HocLuc] ([MaHocLuc])  on update cascade on delete cascade 
go
Alter table [KetQua] add  foreign key([MaHanhKiem]) references [HanhKiem] ([MaHanhKiem])  on update no action on delete no action 
go
Alter table [LopHoc] add  foreign key([MaKhoiLop]) references [KhoiLop] ([MaKhoiLop])  on update no action on delete no action 
go


Set quoted_identifier on
go


Set quoted_identifier off
go


/* Roles permissions */


/* Users permissions */

insert into ThongTinCaNhan values ('TTCN01',N'Nguyễn Văn Tiến','avata_nv_02.png',21,N'11/13/2000',N'Nam',N'Thanh Hóa','0123456789')
insert into ThongTinCaNhan values ('TTCN02',N'Đoàn Văn Dũng','avata_nv_05.png',21,N'08/17/2000',N'Nam',N'Thanh Hóa','0354738859')
insert into ThongTinCaNhan values ('TTCN03',N'Têu Phong','avata_nv_04.png',21,N'05/19/1999',N'Nam',N'Hà Nội','0123987623')
insert into ThongTinCaNhan values ('TTCN04',N'Đoàn Dự','avata_nv_03.png',21,N'08/20/2001',N'Nam',N'Thanh Hóa','0275639862')
insert into ThongTinCaNhan values ('TTCN05',N'Hư Trúc','avata_nv_02.png',21,N'01/13/2000',N'Nam',N'Thanh Hóa','0123456789')
insert into ThongTinCaNhan values ('TTCN06',N'Nguyễn Thị A','avata_nv_05.png',21,N'05/17/2000',N'Nữ',N'Thanh Hóa','0354738859')
insert into ThongTinCaNhan values ('TTCN07',N'Lê Văn B','avata_nv_04.png',21,N'02/19/1999',N'Nam',N'Hà Nội','0123987623')
insert into ThongTinCaNhan values ('TTCN08',N'Ngô Đình C','avata_nv_03.png',21,N'08/20/2001',N'Nam',N'Thanh Hóa','0275639862')
insert into ThongTinCaNhan values ('TTCN09',N'Nguyễn Thu Thảo','avata_nv_02.png',21,N'11/13/1999',N'Nữ',N'Thanh Hóa','0123456789')
insert into ThongTinCaNhan values ('TTCN10',N'Lê Hồng Phong','avata_nv_05.png',21,N'08/17/2000',N'Nam',N'Thanh Hóa','0354738859')
insert into ThongTinCaNhan values ('TTCN11',N'Lê Thị Nụ','avata_nv_04.png',21,N'05/19/1999',N'Nữ',N'Hà Nội','0123987623')
insert into ThongTinCaNhan values ('TTCN12',N'Nguyễn Thị Ánh','avata_nv_03.png',21,N'08/20/2001',N'Nữ',N'Thanh Hóa','0275639862')
insert into ThongTinCaNhan values ('TTCN13',N'Đặng Văn Phong','avata_nv_05.png',21,N'08/17/2000',N'Nam',N'Thanh Hóa','0354738859')
insert into ThongTinCaNhan values ('TTCN14',N'Lại Thị D','avata_nv_04.png',21,N'05/19/1999',N'Nữ',N'Hà Nội','0123987623')
insert into ThongTinCaNhan values ('TTCN15',N'Quách Tĩnh','avata_nv_03.png',21,N'08/20/2001',N'Nam',N'Thanh Hóa','0275639862')

insert into NhanVien values ('NV01','07/14/2021',N'Nhân viên',1,'TTCN01')
insert into NhanVien values ('NV02','06/25/2021',N'Nhân viên',2,'TTCN02')
insert into NhanVien values ('NV03','07/05/2021',N'Nhân viên',2,'TTCN03')
insert into NhanVien values ('NV04','07/14/2021',N'Nhân viên',1,'TTCN04')

insert into TaiKhoan values ('TK01','admin','123456','NV01')
insert into TaiKhoan values ('TK02','dung','123456','NV02')
insert into TaiKhoan values ('TK03','phong','123456','NV03')
insert into TaiKhoan values ('TK04','du','123456','NV04')

insert into GVCN values ('GV01', '09/05/2020', 'TTCN01')
insert into GVCN values ('GV02', '09/05/2020', 'TTCN02')
insert into GVCN values ('GV03', '09/05/2020', 'TTCN03')
insert into GVCN values ('GV04', '09/05/2019', 'TTCN04')
insert into GVCN values ('GV05', '09/05/2019', 'TTCN01')
insert into GVCN values ('GV06', '09/05/2019', 'TTCN02')

insert into KhoiLop values ('K01', N'Khối 10')
insert into KhoiLop values ('K02', N'Khối 11')
insert into KhoiLop values ('K03', N'Khối 12')

insert into LopHoc values ('L01', N'10 B1', N'Chuyên toán', 'GV01', N'2018 - 2019', 'K01')
insert into LopHoc values ('L02', N'10 B2', N'Chuyên lý', 'GV01', N'2018 - 2019', 'K01')
insert into LopHoc values ('L03', N'10 B3', N'Chuyên hóa', 'GV02', N'2018 - 2019', 'K01')
insert into LopHoc values ('L04', N'11 C1', N'Chuyên toán', 'GV02', N'2019 - 2020', 'K02')
insert into LopHoc values ('L05', N'11 C2', N'Chuyên lý', 'GV03', N'2019 - 2020', 'K02')
insert into LopHoc values ('L06', N'11 C3', N'Chuyên hóa', 'GV03', N'2019 - 2020', 'K02')
insert into LopHoc values ('L07', N'12 A1', N'Chuyên toán', 'GV04', N'2020 - 2021', 'K03')
insert into LopHoc values ('L08', N'12 A2', N'Chuyên lý', 'GV05', N'2020 - 2021', 'K03')
insert into LopHoc values ('L09', N'12 A3', N'Chuyên hóa', 'GV06', N'2020 - 2021', 'K03')

insert into HocSinh values ('HS01', '40', 'TTCN05', 'L01')
insert into HocSinh values ('HS02', '49', 'TTCN06', 'L01')
insert into HocSinh values ('HS03', '45', 'TTCN07', 'L01')
insert into HocSinh values ('HS04', '43', 'TTCN08', 'L03')
insert into HocSinh values ('HS05', '38', 'TTCN09', 'L02')
insert into HocSinh values ('HS06', '36', 'TTCN10', 'L03')
insert into HocSinh values ('HS07', '34', 'TTCN11', 'L02')
insert into HocSinh values ('HS08', '47', 'TTCN12', 'L03')
insert into HocSinh values ('HS09', '39', 'TTCN13', 'L02')
insert into HocSinh values ('HS10', '42', 'TTCN14', 'L02')
insert into HocSinh values ('HS11', '40', 'TTCN15', 'L03')

insert into MonHoc values ('M01', N'Toán', 'GV01', 2)
insert into MonHoc values ('M02', N'Văn', 'GV02', 2)
insert into MonHoc values ('M03', N'Anh', 'GV03', 1)
insert into MonHoc values ('M04', N'Vật lý', 'GV01', 1)
insert into MonHoc values ('M05', N'Hóa học', 'GV04', 1)
insert into MonHoc values ('M06', N'Sinh học', 'GV05', 1)
insert into MonHoc values ('M07', N'Lịch sử', 'GV02', 1)
insert into MonHoc values ('M08', N'Địa lý', 'GV03', 1)
insert into MonHoc values ('M09', N'GDCD', 'GV05', 1)
insert into MonHoc values ('M10', N'Thể dục', 'GV06', 1)

insert into LoaiDiem values ('LD01', N'Điểm miệng', 1, 'HS01', 'M01')
insert into LoaiDiem values ('LD01', N'Điểm kiểm tra 15 phút', 1, 'HS01', 'M01')
insert into LoaiDiem values ('LD01', N'Điểm kiểm tra 1 tiết', 1, 'HS01', 'M01')
insert into LoaiDiem values ('LD01', N'Điểm giữa kỳ', 1, 'HS01', 'M01')
insert into LoaiDiem values ('LD01', N'Điểm cuối kỳ', 1, 'HS01', 'M01')

select * from ThongTinCaNhan
select * from NhanVien
select * from TaiKhoan

delete from ThongTinCaNhan where MaCN = 'TTCN01'

alter table ThongTinCaNhan
alter column Anh nvarchar(max) not null;