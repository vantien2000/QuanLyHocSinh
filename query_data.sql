--select HocSinh.MaHS,HoTen,Anh,Tuoi,NgaySinh,GioiTinh,DiaChi,DiemDauVao,TenLop from HocSinh inner join LopHoc on HocSinh.MaLop=LopHoc.MaLop inner join ThongTinCaNhan on ThongTinCaNhan.MaCN = HocSinh.MaCN

create proc ShowStudent
as
	select HocSinh.MaHS,Anh,HoTen,NgaySinh,GioiTinh,DiaChi,SDT,DiemDauVao,TenLop from HocSinh inner join LopHoc on HocSinh.MaLop=LopHoc.MaLop inner join ThongTinCaNhan on ThongTinCaNhan.MaCN = HocSinh.MaCN

exec ShowStudent
--thêm học sinh
create proc InsertStudent
(
	@mahs char(10),
	@diem int,
	@malop char(10),
	@macn char(10),
	@hoten nvarchar(200),
	@anh varchar(100),
	@ngaySinh date,
	@gioiTinh char(5),
	@diaChi nvarchar(500),
	@sdt char(10)
)
as
begin
	insert into ThongTinCaNhan values(@macn,@hoten,@anh,@ngaySinh,@gioiTinh,@diaChi,@sdt)
	insert into HocSinh values(@mahs,@diem,@macn,@malop)
end

create proc ShowStudentByMa
(
	@mahs nchar(10)
)
as
	select HocSinh.MaHS,Anh,HoTen,NgaySinh,GioiTinh,DiaChi,SDT,DiemDauVao,TenLop from HocSinh inner join LopHoc on HocSinh.MaLop=LopHoc.MaLop inner join ThongTinCaNhan on ThongTinCaNhan.MaCN = HocSinh.MaCN
	where HocSinh.MaHS = @mahs
exec ShowStudentByMa 'HS01'

create proc UpdateStudent
(
	@mahs char(10),
	@diem int,
	@malop char(10),
	@hoten nvarchar(200),
	@anh varchar(100),
	@ngaySinh date,
	@gioiTinh char(5),
	@diaChi nvarchar(500),
	@sdt char(10)
)
as
begin
	declare @macn char(10)
	select @macn = MaCN from HocSinh where HocSinh.MaHS = @mahs
	update HocSinh set DiemDauVao = @diem,MaLop = @malop 
		where MaHS = @mahs
	update ThongTinCaNhan set HoTen = @hoten,Anh = @anh,NgaySinh = @ngaySinh,GioiTinh = @gioiTinh,DiaChi = @diaChi,SDT=@sdt
		where ThongTinCaNhan.MaCN = @macn
end

create proc DeleteStudent
(
	@mahs char(10)
)
as
begin
	declare @macn char(10)
	select @macn = MaCN from HocSinh where HocSinh.MaHS = @mahs
	delete from ThongTinCaNhan where MaCN = @macn
end

select * from HocSinh

select * from ThongTinCaNhan

create proc ShowScores
(
	@maLop char(10),
	@maMon char(10),
	@maHocKy char(10)
)
as
begin
	select Diem.MaHS,HoTen,MonHoc.TenMon,DiemMieng,Diem15Phut,Diem1Tiet,DiemGiuaKy,DiemCuoiKy,DiemTB,HocKy.TenHocKy
	from Diem inner join KetQua on Diem.MaKQ = KetQua.MaKQ
	inner join HocSinh on Diem.MaHS = HocSinh.MaHS
	inner join ThongTinCaNhan on ThongTinCaNhan.MaCN = HocSinh.MaCN
	inner join MonHoc on MonHoc.MaMon = Diem.MaMon
	inner join HocKy on HocKy.MaHK = KetQua.MaHK
	inner join LopHoc on HocSinh.MaLop = LopHoc.MaLop
	where LopHoc.MaLop = @maLop and MonHoc.MaMon = @maMon and HocKy.MaHK = @maHocKy
end

create proc InsertScores
(
	@makq char(10),
	@diemtb decimal,
	@mahk char(10),
	@mahs char(10),
	@mamon char(10),
	@diemM float,
	@diem15 float,
	@diem1 float,
	@diemgk float,
	@diemck float
)
as
begin
	insert into KetQua values(@makq,@diemtb,@mahk)
	insert into Diem values (@mahs,@mamon,@diemM,@diem15,@diem1,@diemgk,@diemck,@makq)
end

create proc DeleteScores
(
	@mahs char(10),
	@mamon char(10)
)
as
begin
	declare @makq char(10)
	select @makq=Diem.MaKQ from Diem where MaHS=@mahs and MaMon=@mamon;
	delete from Diem where MaHS=@mahs and MaMon=@mamon
	delete from KetQua where MaKQ=@makq
end

create proc UpdateScores
(
	@mahs char(10),
	@mamon char(10),
	@diemM float,
	@diem15 float,
	@diem1 float,
	@diemgk float,
	@diemck float,
	@diemtb float,
	@mahk char(10)
)
as
begin
	declare @makq char(10)
	select @makq=Diem.MaKQ from Diem where MaHS=@mahs and MaMon=@mamon
	Update Diemset set DiemM=@diemM,Diem15phut=@diem15,Diem1Tiet=@diem1,DiemGiuaKy=@diemgk,DiemCuoiKy=@diemck
	where MaHS=@mahs and MaMon=@mamon;
	Update KetQua set DiemTB=@diemtb where MaKQ=@makq
end

create proc FindScoresByMaHS
(
	@mahs char(10),
	@maLop char(10),
	@maMon char(10),
	@maHocKy char(10)
)
as
begin
	select Diem.MaHS,HoTen,MonHoc.TenMon,DiemMieng,Diem15Phut,Diem1Tiet,DiemGiuaKy,DiemCuoiKy,DiemTB,HocKy.TenHocKy
	from Diem inner join KetQua on Diem.MaKQ = KetQua.MaKQ
	inner join HocSinh on Diem.MaHS = HocSinh.MaHS
	inner join ThongTinCaNhan on ThongTinCaNhan.MaCN = HocSinh.MaCN
	inner join MonHoc on MonHoc.MaMon = Diem.MaMon
	inner join HocKy on HocKy.MaHK = KetQua.MaHK
	inner join LopHoc on HocSinh.MaLop = LopHoc.MaLop
	where LopHoc.MaLop = @maLop and MonHoc.MaMon = @maMon and HocKy.MaHK = @maHocKy and HocSinh.MaHS = @mahs
end

create proc FindScoresByHoTen
(
	@hoten nvarchar(200),
	@maLop char(10),
	@maMon char(10),
	@maHocKy char(10)
)
as
begin
	select Diem.MaHS,HoTen,MonHoc.TenMon,DiemMieng,Diem15Phut,Diem1Tiet,DiemGiuaKy,DiemCuoiKy,DiemTB,HocKy.TenHocKy
	from Diem inner join KetQua on Diem.MaKQ = KetQua.MaKQ
	inner join HocSinh on Diem.MaHS = HocSinh.MaHS
	inner join ThongTinCaNhan on ThongTinCaNhan.MaCN = HocSinh.MaCN
	inner join MonHoc on MonHoc.MaMon = Diem.MaMon
	inner join HocKy on HocKy.MaHK = KetQua.MaHK
	inner join LopHoc on HocSinh.MaLop = LopHoc.MaLop
	where LopHoc.MaLop = @maLop and MonHoc.MaMon = @maMon and HocKy.MaHK = @maHocKy and ThongTinCaNhan.HoTen = @hoten
end
select * from KetQua
select * from Diem