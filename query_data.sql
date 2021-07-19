--select HocSinh.MaHS,HoTen,Anh,Tuoi,NgaySinh,GioiTinh,DiaChi,DiemDauVao,TenLop from HocSinh inner join LopHoc on HocSinh.MaLop=LopHoc.MaLop inner join ThongTinCaNhan on ThongTinCaNhan.MaCN = HocSinh.MaCN

create proc ShowStudent
as
	select HocSinh.MaHS,HoTen,Anh,Tuoi,NgaySinh,GioiTinh,DiaChi,DiemDauVao,TenLop from HocSinh inner join LopHoc on HocSinh.MaLop=LopHoc.MaLop inner join ThongTinCaNhan on ThongTinCaNhan.MaCN = HocSinh.MaCN

exec ShowStudent

create proc ShowStudentByMa
(
	@mahs nchar(10)
)
as
	select HocSinh.MaHS,HoTen,Anh,Tuoi,NgaySinh,GioiTinh,DiaChi,DiemDauVao,TenLop from HocSinh inner join LopHoc on HocSinh.MaLop=LopHoc.MaLop inner join ThongTinCaNhan on ThongTinCaNhan.MaCN = HocSinh.MaCN
	where HocSinh.MaHS = @mahs
exec ShowStudentByMa 'HS01'

select * from HocSinh

select * from ThongTinCaNhan

