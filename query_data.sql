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

create proc FindStudentByMa
(
	@mahs char(10)
)
as
	select HocSinh.MaHS,Anh,HoTen,NgaySinh,GioiTinh,DiaChi,SDT,DiemDauVao,TenLop from HocSinh inner join LopHoc on HocSinh.MaLop=LopHoc.MaLop inner join ThongTinCaNhan on ThongTinCaNhan.MaCN = HocSinh.MaCN
	where HocSinh.MaHS = @mahs
exec FindStudentByMa'HS01'

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

-- form QLLopHoc

create proc ShowClass
as
	select MaLop, TenLop, LoaiLop, NamHoc, LopHoc.MaKhoiLop, TenKhoi, HoTen 
	from LopHoc inner join KhoiLop on LopHoc.MaKhoiLop=KhoiLop.MaKhoiLop inner join GVCN on LopHoc.MaGV=GVCN.MaGV inner join ThongTinCaNhan on GVCN.MaCN=ThongTinCaNhan.MaCN

exec ShowClass

create proc FindClassByMa(@malop char(10))
as
	select MaLop, TenLop, LoaiLop, NamHoc, LopHoc.MaKhoiLop, TenKhoi, HoTen 
	from LopHoc inner join KhoiLop on LopHoc.MaKhoiLop=KhoiLop.MaKhoiLop inner join GVCN on LopHoc.MaGV=GVCN.MaGV inner join ThongTinCaNhan on GVCN.MaCN=ThongTinCaNhan.MaCN
	where MaLop = @malop
exec FindClassByMa 'L01'

-- form QlGiaoVien

create proc ShowTeacher
as
	select MaGV, Anh, HoTen, NgaySinh, GioiTinh, DiaChi, SDT
	from GVCN inner join ThongTinCaNhan on GVCN.MaCN=ThongTinCaNhan.MaCN
exec ShowTeacher

create proc FindTeacherByMa( @magv char(10))
as
	select MaGV, Anh, HoTen, NgaySinh, GioiTinh, DiaChi, SDT
	from GVCN inner join ThongTinCaNhan on GVCN.MaCN=ThongTinCaNhan.MaCN
	where MaGV=@magv
exec FindTeacherByMa 'GV01'

create proc InsertTeacher
(
	@magv char(10),
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
	insert into GVCN values(@magv,@macn)
end