
/*
Created		6/26/2021
Modified		7/25/2021
Project		
Model			
Company		
Author		
Version		
Database		MS SQL 2005 
*/

drop database db_qlhs
create database db_qlhs
use db_qlhs

Create table [ThongTinCaNhan]
(
	[MaCN] Char(10) NOT NULL,
	[HoTen] Nvarchar(200) NOT NULL,
	[Anh] Varchar(100) NULL,
	[NgaySinh] Datetime NULL,
	[GioiTinh] Nchar(5) NOT NULL,
	[DiaChi] Nvarchar(500) NULL,
	[SDT] Char(10) NOT NULL,
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
	[TaiKhoan] Char(32) NULL,
	[MatKhau] Char(32) NULL,
	[MaCN] Char(10) NOT NULL,
Primary Key ([MaNV])
) 
go

Create table [GVCN]
(
	[MaGV] Char(10) NOT NULL,
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
	[HeSo] Integer NULL,
Primary Key ([MaMon])
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
	[DiemMieng] Float NULL,
	[Diem15Phut] Float NULL,
	[Diem1Tiet] Float NULL,
	[DiemGiuaKy] Float NULL,
	[DiemCuoiKy] Float NULL,
	[MaKQ] Char(10) NOT NULL,
Primary Key ([MaHS],[MaMon])
) 
go

Create table [KetQua]
(
	[MaKQ] Char(10) NOT NULL,
	[DiemTB] Float NULL,
	[MaHK] Char(10) NOT NULL,
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
Primary Key ([MaLoai])
) 
go

Create table [LichSuGiaoDich]
(
	[MaLS] Nchar(10) NOT NULL,
	[NgayGD] Datetime NULL,
	[MaGD] Char(10) NOT NULL,
Primary Key ([MaLS])
) 
go

Create table [TongKet]
(
	[MaDiemTK] Char(10) NOT NULL,
	[DiemTK] Float NULL,
	[LenLop] bit NULL,
	[MaHanhKiem] Char(10) NOT NULL,
Primary Key ([MaDiemTK])
) 
go


Alter table [NhanVien] add  foreign key([MaCN]) references [ThongTinCaNhan] ([MaCN])  on update cascade on delete cascade 
go
Alter table [GVCN] add  foreign key([MaCN]) references [ThongTinCaNhan] ([MaCN])  on update cascade on delete cascade 
go
Alter table [HocSinh] add  foreign key([MaCN]) references [ThongTinCaNhan] ([MaCN])  on update cascade on delete cascade  
go
Alter table [Diem] add  foreign key([MaHS]) references [HocSinh] ([MaHS])  on update cascade on delete cascade  
go
Alter table [ThanhToan] add  foreign key([MaHS]) references [HocSinh] ([MaHS])  on update cascade on delete cascade 
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
Alter table [Diem] add  foreign key([MaKQ]) references [KetQua] ([MaKQ])  on update cascade on delete cascade 
go
Alter table [KetQua] add  foreign key([MaHK]) references [HocKy] ([MaHK]) on update cascade on delete cascade 
go
Alter table [TongKet] add  foreign key([MaHanhKiem]) references [HanhKiem] ([MaHanhKiem]) on update cascade on delete cascade 
go
Alter table [LopHoc] add  foreign key([MaKhoiLop]) references [KhoiLop] ([MaKhoiLop]) on update cascade on delete cascade 
go


Set quoted_identifier on
go


Set quoted_identifier off
go


/* Roles permissions */


/* Users permissions */


insert into ThongTinCaNhan values ('TTCN01',N'Nguyễn Văn Tiến','avata_nv_02.png',N'11/13/2000',N'Nam',N'Thanh Hóa','0123456789')
insert into ThongTinCaNhan values ('TTCN02',N'Đoàn Văn Dũng','avata_nv_05.png',N'08/17/2000',N'Nam',N'Thanh Hóa','0354738859')
insert into ThongTinCaNhan values ('TTCN03',N'Têu Phong','avata_nv_04.png',N'05/19/1999',N'Nam',N'Hà Nội','0123987623')
insert into ThongTinCaNhan values ('TTCN04',N'Đoàn Dự','avata_nv_03.png',N'08/20/2001',N'Nam',N'Thanh Hóa','0275639862')
insert into ThongTinCaNhan values ('TTCN05',N'Hư Trúc','avata_nv_02.png',N'01/13/2000',N'Nam',N'Thanh Hóa','0123456789')
insert into ThongTinCaNhan values ('TTCN06',N'Nguyễn Thị A','avata_nv_05.png',N'05/17/2000',N'Nữ',N'Thanh Hóa','0354738859')
insert into ThongTinCaNhan values ('TTCN07',N'Lê Văn B','avata_nv_04.png',N'02/19/1999',N'Nam',N'Hà Nội','0123987623')
insert into ThongTinCaNhan values ('TTCN08',N'Ngô Đình C','avata_nv_03.png',N'08/20/2001',N'Nam',N'Thanh Hóa','0275639862')
insert into ThongTinCaNhan values ('TTCN09',N'Nguyễn Thu Thảo','avata_nv_02.png',N'11/13/1999',N'Nữ',N'Thanh Hóa','0123456789')
insert into ThongTinCaNhan values ('TTCN10',N'Lê Hồng Phong','avata_nv_05.png',N'08/17/2000',N'Nam',N'Thanh Hóa','0354738859')
insert into ThongTinCaNhan values ('TTCN11',N'Lê Thị Nụ','avata_nv_04.png',N'05/19/1999',N'Nữ',N'Hà Nội','0123987623')
insert into ThongTinCaNhan values ('TTCN12',N'Nguyễn Thị Ánh','avata_nv_03.png',N'08/20/2001',N'Nữ',N'Thanh Hóa','0275639862')
insert into ThongTinCaNhan values ('TTCN13',N'Đặng Văn Phong','avata_nv_05.png',N'08/17/2000',N'Nam',N'Thanh Hóa','0354738859')
insert into ThongTinCaNhan values ('TTCN14',N'Lại Thị D','avata_nv_04.png',N'05/19/1999',N'Nữ',N'Hà Nội','0123987623')
insert into ThongTinCaNhan values ('TTCN15',N'Quách Tĩnh','avata_nv_03.png',N'08/20/2001',N'Nam',N'Thanh Hóa','0275639862')

insert into NhanVien values ('NV01','tien','admin','TTCN01')
insert into NhanVien values ('NV02','dung','admin','TTCN02')


insert into GVCN values ('GV01', 'TTCN03')
insert into GVCN values ('GV02', 'TTCN04')
insert into GVCN values ('GV03', 'TTCN05')
insert into GVCN values ('GV04', 'TTCN06')
insert into GVCN values ('GV05', 'TTCN07')
insert into GVCN values ('GV06', 'TTCN08')
insert into GVCN values ('GV07', 'TTCN09')
insert into GVCN values ('GV08', 'TTCN10')

insert into KhoiLop values ('K01', N'Khối 10')
insert into KhoiLop values ('K02', N'Khối 11')
insert into KhoiLop values ('K03', N'Khối 12')

insert into LopHoc values ('L01', N'10 B1', N'Chuyên Toán', 'GV01', N'2018 - 2019', 'K01')
insert into LopHoc values ('L02', N'10 B2', N'Chuyên Lý', 'GV02', N'2018 - 2019', 'K01')
insert into LopHoc values ('L03', N'10 B3', N'Chuyên Hóa', 'GV03', N'2018 - 2019', 'K01')
insert into LopHoc values ('L04', N'10 B4', N'Chuyên Văn', 'GV04', N'2019 - 2020', 'K01')
insert into LopHoc values ('L05', N'10 B5', N'Chuyên Anh', 'GV05', N'2019 - 2020', 'K01')

insert into HocSinh values ('HS01', '45', 'TTCN11', 'L01')
insert into HocSinh values ('HS02', '47', 'TTCN12', 'L02')
insert into HocSinh values ('HS03', '43', 'TTCN13', 'L03')
insert into HocSinh values ('HS04', '42', 'TTCN14', 'L04')
insert into HocSinh values ('HS05', '45', 'TTCN15', 'L05')

insert into LoaiDiem values ('LD01', N'Điểm miệng', 1)
insert into LoaiDiem values ('LD02', N'Điểm kiểm tra 15 phút', 1)
insert into LoaiDiem values ('LD03', N'Điểm kiểm tra 1 tiết', 1)
insert into LoaiDiem values ('LD04', N'Điểm giữa kỳ', 2)
insert into LoaiDiem values ('LD05', N'Điểm cuối kỳ', 2)

insert into MonHoc values ('M01', N'Toán Học', 2)
insert into MonHoc values ('M02', N'Vật Lý', 1)
insert into MonHoc values ('M03', N'Hóa Học', 1)
insert into MonHoc values ('M04', N'Sinh Học', 1)
insert into MonHoc values ('M05', N'Ngữ Văn', 1)
insert into MonHoc values ('M06', N'Tiếng Anh', 2)
insert into MonHoc values ('M07', N'Địa Lý', 1)
insert into MonHoc values ('M08', N'Lịch Sử', 1)
insert into MonHoc values ('M09', N'GDCD', 1)

insert into HocKy values ('HK01', N'Học kỳ 1', 1)
insert into HocKy values ('HK02', N'Học kỳ 2', 2)

insert into HocLuc values ('HL01', N'Học lực giỏi', 8, 10)
insert into HocLuc values ('HL02', N'Học lực khá', 6.5, 7.9)
insert into HocLuc values ('HL03', N'Học lực trung bình', 5, 6.4)
insert into HocLuc values ('HL04', N'Học lực yếu', 0, 4.9)

insert into HanhKiem values ('HKiem01', N'Xuất sắc')
insert into HanhKiem values ('HKiem02', N'Tốt')
insert into HanhKiem values ('HKiem03', N'Khá')
insert into HanhKiem values ('HKiem04', N'Trung bình')
insert into HanhKiem values ('HKiem05', N'Yếu')

insert into ThanhToan values ('TT01', '6000000', '300000', '6300000', N'Đã nộp', 'HS01')

insert into LichSuGiaoDich values ('LS01', '09/09/2020', 'TT01')

select * from ThongTinCaNhan
select * from NhanVien
select * from GVCN
select * from KhoiLop
select * from LopHoc
select * from HocSinh
select * from LoaiDiem
select * from MonHoc
select * from HocKy
select * from HocLuc
select * from HanhKiem
select * from ThanhToan
select * from LichSuGiaoDich
select * from Diem
select * from KetQua




