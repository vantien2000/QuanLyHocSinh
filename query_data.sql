select * from ThongTinCaNhan
select * from NhanVien
select* from TaiKhoan

delete from ThongTinCaNhan where MaCN = 'TTCN01'

insert into ThongTinCaNhan values ('TTCN01',N'Nguyễn Văn Tiến','avata_nv_02.png',21,N'11/13/2000',N'Nam',N'Thanh Hóa','0123456789')
insert into NhanVien values ('NV01','07/14/2021',N'Nhân viên',1,'TTCN01')
insert into TaiKhoan values ('TK01','admin','123456','NV01')

insert into ThongTinCaNhan values ('TTCN02',N'Nguyễn Văn Tiến','avata_nv_02.png',21,N'11/13/2000',N'Nam',N'Thanh Hóa','0123456789')
insert into NhanVien values ('NV02','07/14/2021',N'Nhân viên',1,'TTCN02')
insert into TaiKhoan values ('TK02','admin123','123456','NV02')

