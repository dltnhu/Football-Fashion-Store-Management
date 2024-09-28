
CREATE DATABASE CuaHangDaBanhDB
GO
USE CuaHangDaBanhDB
GO
/*===================================================== Phân quyền linh động ============================================*/

-- Tạo bảng tài khoản
CREATE TABLE TaiKhoan
(
	MaTaiKhoan INT,
	MaNhomQuyen INT,
	TenTaiKhoan NVARCHAR(250),
	MatKhau NVARCHAR(250),
	TrangThai INT
)
GO
-- Tạo bảng nhóm quyền
CREATE TABLE NhomQuyen
(
	MaNhomQuyen INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	TenNhomQuyen NVARCHAR(250),
	TrangThai INT
)
GO
-- Tạo bảng chức năng
CREATE TABLE ChucNang
(
	MaChucNang INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	TenChucNang NVARCHAR(250),
	TrangThai INT
)
GO
-- Tạo bảng chi tiết quyền hình thành từ quan hệ nhiều - nhiều giữa Chức năng và Nhóm quyền
CREATE TABLE ChiTietQuyen
(
	MaChiTietQuyen INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	MaNhomQuyen INT,
	MaChucNang INT,
	HanhDong NVARCHAR(250)
)
GO
--Bảng tài khoản thêm khóa ngoại tham chiếu tới khóa chính bảng Nhóm Quyền
ALTER TABLE TaiKhoan
ADD CONSTRAINT FK_TaiKhoan_MaNhomQuyen 
FOREIGN KEY (MaNhomQuyen) REFERENCES NhomQuyen(MaNhomQuyen)

GO
-- Bảng chi tiết quyền thêm khóa ngoại tham chiếu tới khóa chính bảng chức năng
ALTER TABLE ChiTietQuyen
ADD CONSTRAINT FK_ChiTietQuyen_MaChucNang
FOREIGN KEY (MaChucNang) REFERENCES ChucNang(MaChucNang)

GO
-- bảng chi tiết quyền thêm khóa ngoại tham chiếu tới khóa chính bảng nhóm quyền
ALTER TABLE ChiTietQuyen
ADD CONSTRAINT FK_ChiTietQuyen_MaNhomQuyen
FOREIGN KEY (MaNhomQuyen) REFERENCES NhomQuyen(MaNhomQuyen)

/*

select * from chitietquyen
insert into NhomQuyen values (N'Admin', 1),(N'Nhân viên bán hàng', 1),(N'Nhân viên nhập hàng', 1)

insert into ChucNang values (N'Sản Phẩm', 1), (N'Danh Mục Sản Phẩm', 1), (N'Bán Hàng', 1),(N'Nhập Hàng', 1),(N'Nhân Viên', 1), (N'Khách Hàng', 1), (N'Hóa Đơn', 1), (N'Khuyến Mãi', 1), (N'Thuế', 1), (N'Phân Quyền', 1), (N'Thống Kê', 1), (N'Nhà Cung Cấp', 1)







// phân quyền cho admin
select * from chitietquyen
insert into ChiTietQuyen values (1,1,N'Xem'),(1,1,N'Sửa'),(1,1,N'Xóa'),(1,1,N'Thêm')
insert into ChiTietQuyen values (1,2,N'Xem'),(1,2,N'Sửa'),(1,2,N'Xóa'),(1,2,N'Thêm')
insert into ChiTietQuyen values (1,3,N'Xem'),(1,3,N'Sửa'),(1,3,N'Xóa'),(1,3,N'Thêm')
insert into ChiTietQuyen values (1,4,N'Xem'),(1,4,N'Sửa'),(1,4,N'Xóa'),(1,4,N'Thêm')
insert into ChiTietQuyen values (1,5,N'Xem'),(1,5,N'Sửa'),(1,5,N'Xóa'),(1,5,N'Thêm')
insert into ChiTietQuyen values (1,6,N'Xem'),(1,6,N'Sửa'),(1,6,N'Xóa'),(1,6,N'Thêm')
insert into ChiTietQuyen values (1,7,N'Xem'),(1,7,N'Sửa'),(1,7,N'Xóa'),(1,7,N'Thêm')
insert into ChiTietQuyen values (1,8,N'Xem'),(1,8,N'Sửa'),(1,8,N'Xóa'),(1,8,N'Thêm')
insert into ChiTietQuyen values (1,9,N'Xem'),(1,9,N'Sửa'),(1,9,N'Xóa'),(1,9,N'Thêm')
insert into ChiTietQuyen values (1,10,N'Xem'),(1,10,N'Sửa'),(1,10,N'Xóa'),(1,10,N'Thêm')
insert into ChiTietQuyen values (1,11,N'Xem'),(1,11,N'Sửa'),(1,11,N'Xóa'),(1,11,N'Thêm')
insert into ChiTietQuyen values (1,12,N'Xem'),(1,12,N'Sửa'),(1,12,N'Xóa'),(1,12,N'Thêm')



select * from Thue where concat(MaThue,TenThue, MucThue) COLLATE Latin1_General_CI_AI like '%2%'


*/

/* ===============================================================================================================*/

GO

/* ===============================================================================================================*/

/*=======================================NHÂN VIÊN================================================================*/
-- Tạo bảng nhân viên

CREATE TABLE NhanVien
(
	MaNhanVien INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	TenNhanVien NVARCHAR(50),
	Tuoi INT,
	SoDienThoai VARCHAR(10),
	HinhAnh IMAGE,
	TrangThai INT,
)

GO

/*
select * from TAIKHOAN
select * from nhanvien
delete from taikhoan

// tài khoản gốc
insert into NhanVien values(N'Admin',20,'0907146115','',1)


insert into TaiKhoan values(1, 1, N'Admin', '1234',1)

select * from nhomQuyen
select * from taikhoan
select * from nhanvien
*/

ALTER TABLE TaiKhoan
ADD CONSTRAINT FK_TaiKhoan_MaNhanVien 
FOREIGN KEY (MaTaiKhoan) REFERENCES NhanVien(MaNhanVien)
/*===============================================================================================================*/
GO


/* ============================================ Thuộc tính sản phẩm ============================================*/
-- Tạo bảng thương hiệu
CREATE TABLE ThuongHieu
(
	MaThuongHieu INT IDENTITY PRIMARY KEY NOT NULL,
	TenThuongHieu NVARCHAR(250),
	TrangThai INT
)

GO
/*

-- Chèn bản ghi "Nike"
INSERT INTO ThuongHieu (TenThuongHieu, TrangThai)
VALUES ('Nike', 1);

-- Chèn bản ghi "Adidas"
INSERT INTO ThuongHieu (TenThuongHieu, TrangThai)
VALUES ('Adidas', 1);

-- Chèn bản ghi "Puma"
INSERT INTO ThuongHieu (TenThuongHieu, TrangThai)
VALUES ('Puma', 1);

-- Chèn bản ghi "Under Armour"
INSERT INTO ThuongHieu (TenThuongHieu, TrangThai)
VALUES ('Under Armour', 1);

GO
*/

-- Tạo bảng chất liệu
CREATE TABLE ChatLieu
(
	MaChatLieu INT IDENTITY PRIMARY KEY NOT NULL,
	TenChatLieu NVARCHAR(250),
	TrangThai INT
)

GO
/*
INSERT INTO ChatLieu (TenChatLieu, TrangThai)
VALUES
    (N'Vải thể thao', 1),
    (N'Da tổng hợp', 1),
    (N'Lưới', 1),
    (N'Thun', 1),
    (N'Nhựa cao cấp', 1),
    (N'Polyester', 1),
    (N'Lông cừu', 1),
    (N'Nỉ', 1),
    (N'Nhựa dẻo', 1),
    (N'Gel', 1);

GO
*/
-- tạo bảng thể loại sản phẩm
CREATE TABLE TheLoai
(
	MaTheLoai INT IDENTITY PRIMARY KEY NOT NULL,
	TenTheLoai NVARCHAR(250),
	TrangThai INT
)

GO

/*
-- Chèn bản ghi "Bóng đá"
INSERT INTO TheLoai (TenTheLoai, TrangThai)
VALUES	(N'Bóng đá', 1),
		(N'Áo bóng đá', 1),
		(N'Quần bóng đá', 1),
		(N'Giày bóng đá', 1),
		(N'Phụ kiện bóng đá', 1),
		(N'Đồ tập gym', 1),
		(N'Đồng phục đội bóng đá', 1),
		(N'Đồ lưu niệm bóng đá', 1);

		select * from theloai
GO
*/


-- tạo bảng kích cở
CREATE TABLE KichCo
(
	MaKichCo INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	TenKichCo NVARCHAR(250),
	TrangThai INT
)


GO
/*

INSERT INTO KichCo (TenKichCo, TrangThai)
VALUES ('XS', 1);

INSERT INTO KichCo (TenKichCo, TrangThai)
VALUES ('S', 1);

INSERT INTO KichCo (TenKichCo, TrangThai)
VALUES ('M', 1);

INSERT INTO KichCo (TenKichCo, TrangThai)
VALUES ('L', 1);

INSERT INTO KichCo (TenKichCo, TrangThai)
VALUES ('XL', 1);

*/
GO
-- tạo bảng màu sắc
CREATE TABLE MauSac
(
	MaMauSac INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	TenMauSac NVARCHAR(250),
	TrangThai INT
)

/*
INSERT INTO MauSac (TenMauSac, TrangThai) VALUES (N'Đỏ', 1);
INSERT INTO MauSac (TenMauSac, TrangThai) VALUES (N'Xanh', 1);
INSERT INTO MauSac (TenMauSac, TrangThai) VALUES (N'Vàng', 1);
INSERT INTO MauSac (TenMauSac, TrangThai) VALUES (N'Trắng', 1);
select * from mausac
*/
/* ==========================================================================================================================*/

GO

/*===================================================== Sản phẩm ============================================================*/
-- tạo bảng sản phẩm
CREATE TABLE SanPham
(
	MaSanPham INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	MaThuongHieu INT NOT NULL,
	MaTheLoai INT NOT NULL,
	MaChatLieu INT NOT NULL,
	TenSanPham NVARCHAR(250),
	GiaSanPham FLOAT,
	GiaNhap FLOAT,
	SoLuongNhap INT,
	SoLuongTon INT,
	TrangThai INT,
)

GO 
/**
-- Bản ghi 1

INSERT INTO SanPham (MaThuongHieu, MaTheLoai, MaChatLieu, TenSanPham, GiaSanPham, GiaNhap, SoLuongNhap, SoLuongTon, TrangThai)
VALUES (1, 2, 4, N'Áo đấu Manchester United', 500000, 400000, 100, 50, 1);

-- Bản ghi 2
INSERT INTO SanPham (MaThuongHieu, MaTheLoai, MaChatLieu, TenSanPham, GiaSanPham, GiaNhap, SoLuongNhap, SoLuongTon, TrangThai)
VALUES (1, 2, 4, N'Áo đấu Barcelona', 550000, 450000, 80, 30, 1);

-- Bản ghi 3
INSERT INTO SanPham (MaThuongHieu, MaTheLoai, MaChatLieu, TenSanPham, GiaSanPham, GiaNhap, SoLuongNhap, SoLuongTon, SoLuongBan, TrangThai)
VALUES (3, 3, 4, N'Quần đùi Real Madrid', 300000, 250000, 120, 80, 40, 1);

-- Bản ghi 4
INSERT INTO SanPham (MaThuongHieu, MaTheLoai, MaChatLieu, TenSanPham, GiaSanPham, GiaNhap, SoLuongNhap, SoLuongTon, SoLuongBan, TrangThai)
VALUES (4, 3, 4, N'Quần đùi Liverpool', 320000, 270000, 100, 50, 50, 1);

-- Bản ghi 5
INSERT INTO SanPham (MaThuongHieu, MaTheLoai, MaChatLieu, TenSanPham, GiaSanPham, GiaNhap, SoLuongNhap, SoLuongTon, SoLuongBan, TrangThai)
VALUES (4, 4, 6, N'Giày bóng đá Nike Mercurial', 1200000, 1000000, 60, 20, 40, 1);

-- Bản ghi 6
INSERT INTO SanPham (MaThuongHieu, MaTheLoai, MaChatLieu, TenSanPham, GiaSanPham, GiaNhap, SoLuongNhap, SoLuongTon, SoLuongBan, TrangThai)
VALUES (4, 4, 6, N'Giày bóng đá Adidas Predator', 1100000, 900000, 80, 30, 50, 1);

-- Bản ghi 7
INSERT INTO SanPham (MaThuongHieu, MaTheLoai, MaChatLieu, TenSanPham, GiaSanPham, GiaNhap, SoLuongNhap, SoLuongTon, SoLuongBan, TrangThai)
VALUES (4, 5, 9, N'Bóng đá Adidas Tango', 200000, 150000, 150, 100, 50, 1);

GO
*/

ALTER TABLE SanPham
ADD CONSTRAINT FK_SanPham_MaThuongHieu
FOREIGN KEY (MaThuongHieu) REFERENCES ThuongHieu(MaThuongHieu)

GO

ALTER TABLE SanPham
ADD CONSTRAINT FK_SanPham_MaTheLoai
FOREIGN KEY (MaTheLoai) REFERENCES TheLoai(MaTheLoai)

GO
ALTER TABLE SanPham
ADD CONSTRAINT FK_SanPham_MaChatLieu
FOREIGN KEY (MaChatLieu) REFERENCES ChatLieu(MaChatLieu)


/*============================================================================================================================*/

GO

/*========================================= CHI TIẾT SẢN PHẨM =============================================================== */

CREATE TABLE ChiTietSanPham
(
	MaChiTietSanPham INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	MaSanPham INT NOT NULL,
	MaMauSac INT NOT NULL,
	MaKichCo INT NOT NULL,
	HinhAnh IMAGE,
	SoLuongNhap INT,
	SoLuongTon INT,
	TrangThai INT
)

GO

ALTER TABLE ChiTietSanPham
ADD CONSTRAINT FK_ChiTietSanPham_MaSanPham
FOREIGN KEY (MaSanPham) REFERENCES SanPham(MaSanPham)

GO

ALTER TABLE ChiTietSanPham
ADD CONSTRAINT FK_ChiTietSanPham_MaMauSac
FOREIGN KEY (MaMauSac) REFERENCES MauSac(MaMauSac)

GO 

ALTER TABLE ChiTietSanPham
ADD CONSTRAINT FK_ChiTietSanPham_MaKichCo
FOREIGN KEY (MaKichCo) REFERENCES KichCo(MaKichCo)


/* ============================================================================================================== */





/*=============================================== PHIẾU NHẬP =====================================================*/

CREATE TABLE NhaCungCap
(
	MaNhaCungCap INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	TenNhaCungCap NVARCHAR(250),
	DiaChi NVARCHAR(250),
	SoDienThoai NVARCHAR(50),
	TrangThai INT
)
GO

/*
INSERT INTO NhaCungCap (TenNhaCungCap, DiaChi, SoDienThoai, TrangThai)
VALUES
    (N'Nhà cung cấp A', N'Địa chỉ A', N'0123456789', 1),
    (N'Nhà cung cấp B', N'Địa chỉ B', N'0987654321', 1),
    (N'Nhà cung cấp C', N'Địa chỉ C', N'0123123456', 1),
    (N'Nhà cung cấp D', N'Địa chỉ D', N'0987098765', 1),
    (N'Nhà cung cấp E', N'Địa chỉ E', N'0123498765', 1),
    (N'Nhà cung cấp F', N'Địa chỉ F', N'0987654321', 1),
    (N'Nhà cung cấp G', N'Địa chỉ G', N'0123456789', 1),
    (N'Nhà cung cấp H', N'Địa chỉ H', N'0987098765', 1),
    (N'Nhà cung cấp I', N'Địa chỉ I', N'0123123456', 1),
    (N'Nhà cung cấp J', N'Địa chỉ J', N'0983498765', 1);
*/
GO

CREATE TABLE PhieuNhap
(
	MaPhieuNhap INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	MaNhaCungCap INT NOT NULL,
	MaNhanVien INT NOT NULL,
	NgayNhap DATETIME,
	TenPhieuNhap NVARCHAR(250),
	TongTienNhap FLOAT,
	TrangThai INT
)
GO
CREATE TABLE ChiTietPhieuNhap
(
	MaChiTietPhieuNhap INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	MaPhieuNhap INT NOT NULL,
	MaChiTietSanPham INT NOT NULL,
	SoLuongNhap INT,
	DonVi NVARCHAR(250),
	TienNhap FLOAT,
	ThanhTien FLOAT
)
GO
ALTER TABLE PhieuNhap
ADD CONSTRAINT FK_PhieuNhap_MaNhaCungCap
FOREIGN KEY (MaNhaCungCap) REFERENCES NhaCungCap(MaNhaCungCap)
GO
ALTER TABLE PhieuNhap
ADD CONSTRAINT FK_PhieuNhap_MaNhanVien
FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
GO
ALTER TABLE ChiTietPhieuNhap
ADD CONSTRAINT FK_ChiTietPhieuNhap_MaPhieuNhap
FOREIGN KEY (MaPhieuNhap) REFERENCES PhieuNhap(MaPhieuNhap)
GO
ALTER TABLE ChiTietPhieuNhap
ADD CONSTRAINT FK_ChiTietPhieuNhap_MaChiTietSanPham
FOREIGN KEY (MaChiTietSanPham) REFERENCES ChiTietSanPham(MaChiTietSanPham)

/*=================================================================================================================*/
GO

/*=========================================== KHÁCH HÀNG ==========================================================*/

CREATE TABLE KhachHang
(
	MaKhachHang INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	TenKhachHang NVARCHAR(250),
	SoDienThoai NVARCHAR(250),
	TrangThai INT
)


/*
-- Chèn nhiều bản ghi cùng một lúc

-- Chèn nhiều bản ghi với cột TrangThai
INSERT INTO KhachHang (TenKhachHang, SoDienThoai, TrangThai)
VALUES
  (N'Nguyễn Văn A', '0123456789', 0),
  (N'Trần Thị B', '0987654321', 1),
  (N'Lê Minh C', '0369874123', 0);


*/

/*================================================================================================================*/


GO 


/*========================================== HÓA ĐƠN ==============================================================*/
CREATE TABLE KhuyenMai
(
	MaKhuyenMai INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	MucKhuyenMai FLOAT,
	DieuKien NVARCHAR(250),
	ThoiGianBatDau DATETIME,
	ThoiGianKetThuc DATETIME,
	TrangThai INT,
)

/*
INSERT INTO KhuyenMai (MucKhuyenMai, DieuKien, ThoiGianBatDau, ThoiGianKetThuc, TinhTrang)
VALUES 
    (0.1, 'Đơn hàng trên 500.000đ', '2023-10-27 09:00:00', '2023-10-31 23:59:59', 1),
    (0.2, 'Đơn hàng trên 1.000.000đ', '2023-11-01 00:00:00', '2023-11-07 23:59:59', 1),
    (0.15, 'Đơn hàng trên 300.000đ', '2023-11-10 10:00:00', '2023-11-15 18:00:00', 0)
*/
GO

CREATE TABLE Thue
(
	MaThue INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	TenThue NVARCHAR(250),
	MucThue FLOAT,
	TrangThai INT
)


GO


CREATE TABLE HoaDon
(
	MaHoaDon INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	MaKhachHang INT,
	MaNhanVien INT,
	MaKhuyenMai INT,
	MaThue INT,
	TenHoaDon NVARCHAR(250),
	NgayLapHoaDon DATETIME,
	TongTien FLOAT,
	TongTienKhuyenMai FLOAT,
	TongTienThue FLOAT,
	HinhThucThanhToan NVARCHAR(250),
	ThanhTien FLOAT,
	TrangThai INT

)

GO

ALTER TABLE HoaDon
ADD CONSTRAINT FK_HoaDon_MaKhachHang
FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang)

GO

ALTER TABLE HoaDon
ADD CONSTRAINT FK_HoaDon_MaNhanVien
FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)

GO

ALTER TABLE HoaDon
ADD CONSTRAINT FK_HoaDon_MaKhuyenMai
FOREIGN KEY (MaKhuyenMai) REFERENCES KhuyenMai(MaKhuyenMai)


ALTER TABLE Thue
ADD CONSTRAINT FK_HoaDon_Thue
FOREIGN KEY (MaThue) REFERENCES Thue(MaThue)

GO

CREATE TABLE ChiTietHoaDon
(
	MaChiTietHoaDon INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	MaChiTietSanPham INT,
	MaHoaDon INT,
	GiaSanPham FLOAT,
	SoLuong INT,
	ThanhTien FLOAT
)

GO

ALTER TABLE ChiTietHoaDon
ADD CONSTRAINT FK_ChiTietHoaDon_MaChiTietSanPham
FOREIGN KEY (MaChiTietSanPham) REFERENCES ChiTietSanPham(MaChiTietSanPham)

GO

ALTER TABLE ChiTietHoaDon
ADD CONSTRAINT FK_ChiTietHoaDon_MaHoaDon
FOREIGN KEY (MaHoaDon) REFERENCES HoaDon(MaHoaDon)







/*
USE MASTER
DROP DATABASE CuaHangDaBanhDB



select * from Thue where concat(MaThue,TenThue, MucThue) COLLATE Latin1_General_CI_AI like '%1%'


select * from TheLoai where concat(MaTheLoai,TenTheLoai) COLLATE Latin1_General_CI_AI like N'%Áo%';

select ChiTietQuyen.MaChiTietQuyen,ChiTietQuyen.MaNhomQuyen,ChiTietQuyen.MaChucNang,ChiTietQuyen.HanhDong from ChiTietQuyen join ChucNang on
                ChiTietQuyen.MaChucNang=ChucNang.MaChucNang join NhomQuyen on ChiTietQuyen.MaNhomQuyen=NhomQuyen.MaNhomQuyen 
                where concat(ChiTietQuyen.MaNhomQuyen,ChiTietQuyen.MaChucNang,ChiTietQuyen.HanhDong,ChucNang.TenChucNang,NhomQuyen.TenNhomQuyen)
                like N'Sản Phẩm' and ChucNang.TrangThai=1 and NhomQuyen.TrangThai=1


-- Chèn các bản ghi vào bảng Thue
INSERT INTO Thue (TenThue, MucThue, TrangThai)
VALUES ('Thue1', 0.1, 1);

INSERT INTO Thue (TenThue, MucThue, TrangThai)
VALUES ('Thue2', 0.15, 1);

INSERT INTO Thue (TenThue, MucThue, TrangThai)
VALUES ('Thue3', 0.2, 0);

INSERT INTO Thue (TenThue, MucThue, TrangThai)
VALUES ('Thue4', 0.12, 1);
delete from chitietsanpham
use CuaHangDaBanhDB
select * from sanpham
select * from chitietsanpham

insert into chitietsanpham (MaSanPham, MaMauSac, MaKichCo, HinhAnh, SoLuongNhap, SoLuongTon, TrangThai) VALUES (2, 2, 2, '', 0, 0, 1), (3, 3, 3, '', 0, 0, 1)
select * from theloai
select * from taikhoan
select * from chitietsanpham
SELECT * FROM NHANVIEN
select * from mausac
select * from khuyenmai
select * from hoadon
select *  from ChiTietHoaDon
select * from khachhang
select * from phieuNhap
select * from chitietphieunhap
select * from khachhang
select * from chiTietquyen
select * from nhacungCap
select * from sanpham
select * from chitietsanpham
select * from nhomquyen
select * from chitietquyen
select * from phieunhap
select * from chitietphieunhap
delete from chitietphieunhap
delete from phieunhap
SELECT DISTINCT MaChucNang  FROM ChiTietQuyen WHERE MaNhomQuyen = 1
select * from CHITIETSANPHAM

UPDATE CHITIETSANPHAM SET SOLUONGNHAP = 0 WHERE MACHITIETSANPHAM = 5;
ALTER TABLE KhuyenMai
RENAME COLUMN TinhTrang TO TrangThai;
*/

SELECT * FROM KhuyenMai

select * from HoaDon