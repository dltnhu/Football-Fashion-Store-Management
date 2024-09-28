use CuaHangDaBanhDB
-- Lấy danh sách nhóm quyền
create proc Select_NhomQuyen
as
select * from NhomQuyen where TrangThai=1

go 

-- Lấy danh sách chức năng
create proc Select_ChucNang
as
select * from ChucNang where TrangThai = 1
go

-- Lấy chi tiết quyền
create proc Select_ChiTietQuyen
as
select * from ChiTietQuyen

go

-- Lấy tài khoản
create proc Select_TaiKhoan
as
select * from TaiKhoan where TrangThai=1

go

-- Lấy Nhân Viên
create proc Select_NhanVien
as
select * from NhanVien where TrangThai=1

go

-- lấy thể loại
create proc Select_TheLoai
as
select * from TheLoai where TrangThai=1

go

-- lấy thương hiệu
create proc Select_ThuongHieu
as
select * from ThuongHieu where TrangThai=1

go

-- lấy chất liệu
create proc Select_ChatLieu
as
select * from ChatLieu where TrangThai=1

go

-- lấy màu sắc
create proc Select_MauSac
as
select * from MauSac where TrangThai=1

go

-- lấy kích cỡ
create proc Select_KichCo
as
select * from KichCo where TrangThai=1

go

-- Lấy sản phẩm
create proc Select_SanPham
as
select * from SanPham where TrangThai = 1

go


-- lấy chi tiết sản phẩm
create proc Select_ChiTietSanPham
as
select * from ChiTietSanPham where TrangThai=1

select * from chitietquyen