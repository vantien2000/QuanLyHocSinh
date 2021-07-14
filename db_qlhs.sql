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
	[Anh] Image NULL,
	[Tuoi] Integer NOT NULL,
	[NgaySinh] Datetime NULL,
	[GioiTinh] Char(5) NULL,
	[DiaChi] Nvarchar(500) NULL,
	[SDT] Char(10) NULL,
Primary Key ([MaCN])
) 
go

Create table [HocSinh]
(
	[MaHS] Char(10) NOT NULL,
	[DiemDauVao] Integer NULL,
	[MaCN] Char(10) NOT NULL,
	[MaLop] Char(10) NOT NULL,
Primary Key ([MaHS])
) 
go

Create table [NhanVien]
(
	[MaNV] Char(10) NOT NULL,
	[NgayBD] Datetime NOT NULL,
	[ChucVu] Nvarchar(50) NULL,
	[Level] Integer NULL,
	[MaCN] Char(10) NOT NULL,
Primary Key ([MaNV])
) 
go

Create table [GVCN]
(
	[MaGV] Char(10) NOT NULL,
	[NgayBD] Datetime NULL,
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

insert into ThongTinCaNhan values ('TTCN01',N'NguyêÞn Vãn Tiêìn','./Image/avata_nv_02.png',21,N'11/13/2000',N'Nam',N'Thanh Hoìa','0123456789')
insert into NhanVien values ('NV01','07/14/2021',N'Nhân viên',1,'TTCN01')
insert into TaiKhoan values ('TK01','admin','123456','NV01')

select * from ThongTinCaNhan
select * from NhanVien
select * from TaiKhoan

delete from ThongTinCaNhan where MaCN = 'TTCN01'

alter table ThongTinCaNhan
alter column Anh nvarchar(max) not null;