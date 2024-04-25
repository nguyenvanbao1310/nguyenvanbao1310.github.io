CREATE TABLE USERS
(
	TaiKhoan  varchar(50) NOT NULL UNIQUE,
	MatKhau varchar(255) NOT NULL,
    MaTK varchar(10)    PRIMARY KEY,
	Email varchar(100) UNIQUE NOT NULL,
	TenND nvarchar(100) NOT NULL ,
	Phone char(10),
	DiaChi nvarchar(255),
    NgaySinh DATETIME NOT NULL,
	NgayTao DATETIME DEFAULT CURRENT_TIMESTAMP,
	VaiTro varchar(10) NOT NULL,
);

CREATE TABLE DONHANG
(
    MaDH varchar(50) PRIMARY KEY ,
    MaND varchar(10),
    TenNguoiBan nvarchar(50),
    MaSP nvarchar(10),
    NgayMua DATETIME DEFAULT CURRENT_TIMESTAMP,
    TongTien INT NOT NULL,
    TrangThaiThanhToan VARCHAR(50),
    TrangThaiGiaoHang VARCHAR(50),
    FOREIGN KEY(MaSP) REFERENCES SANPHAM(MaSP)
)


CREATE TABLE HOADON 
(
    MaHoaDon nvarchar(50) ,
    MaSP nvarchar(10),
    MaKH varchar(10),
    NgayMua DATETIME DEFAULT CURRENT_TIMESTAMP,
    TenKH VARCHAR(100),
    DiaChi VARCHAR(255),
    Email VARCHAR(100),
    SDT VARCHAR(20),
    TongTien DECIMAL(10,2),
    PhuongThucThanhToan VARCHAR(50),
    TrangThaiThanhToan VARCHAR(20),
    GhiChu TEXT,
    FOREIGN KEY (MaKH) REFERENCES USERS(MaTK),
    PRIMARY KEY(MaHoaDon, MaKH)
);


CREATE TABLE DANHGIA
(
    id INT IDENTITY(1,1) PRIMARY KEY,
    Ma varchar(10),
    TenNguoiBan nvarchar(50),
    TenSP nvarchar(50),
    MaDH varchar(50),
    TenNguoiMua nvarchar(100),
    KhachHangDG nvarchar(1000),
    PhanHoiDG nvarchar(1000),
    FileAnh nvarchar(50),
    FOREIGN KEY (Ma) REFERENCES USERS(MaTK)
)


CREATE TABLE GIOHANG
(
    MaTK varchar(10) NOT NULL,
    MaSP nvarchar(10) PRIMARY KEY,
    TenSP nvarchar(50) NOT NULL,
    Tien INT NOT NULL,
    FileAnh nvarchar(50) NOT NULL,
    FOREIGN KEY (MaSP) REFERENCES SANPHAM(MASP)

)


CREATE TABLE KHUYENMAI 
(
    id INT PRIMARY KEY IDENTITY(1,1),
    MaKhuyenMai VARCHAR(50) NOT NULL UNIQUE,
    LoaiKhuyenMai NVARCHAR(255) NOT NULL,
    TenKhuyenMai VARCHAR(255) NOT NULL,
    GiaTri INT,
    NgayBD DATE,
    NgayKT DATE
);



INSERT INTO USERS(TaiKhoan, MatKhau, MaTK, Email, TenND, Phone, DiaChi, NgaySinh, NgayTao, VaiTro)
VALUES
	('nvb1310','13102004','TK001','nguyenhoanggiaphong12@gmail.com',N'Nguyễn Văn Bảo', '0902847624',N'Quận 8', '2004-10-13', '2023-10-13','Admin'),
	('dhh0101','01012004','TK002', 'duhoanghuy0101@gmail.com',N'Dư Hoàng Huy', '0707751852',N'Thủ Đức', '2004-01-01', '2024-01-01','Customer'),
    ('1','2','TK003', 'duhoanghuy0102@gmail.com',N'dev-test', '0707751852',N'Thủ Đức','2004-11-23', '2024-01-01','Customer'),

    ('user4', 'password4', 'TK004', 'user4@example.com', N'Người dùng 4', '1234567893', N'Địa chỉ 4', '1993-04-04', CURRENT_TIMESTAMP, 'Customer'),
    ('user5', 'password5', 'TK005', 'user5@example.com', N'Người dùng 5', '1234567894', N'Địa chỉ 5', '1994-05-05', CURRENT_TIMESTAMP, 'Customer'),
    ('user6', 'password6', 'TK006', 'user6@example.com', N'Người dùng 6', '1234567895', N'Địa chỉ 6', '1995-06-06', CURRENT_TIMESTAMP, 'Customer'),
    ('user7', 'password7', 'TK007', 'user7@example.com', N'Người dùng 7', '1234567896', N'Địa chỉ 7', '1996-07-07', CURRENT_TIMESTAMP, 'Customer'),
    ('user8', 'password8', 'TK008', 'user8@example.com', N'Người dùng 8', '1234567897', N'Địa chỉ 8', '1997-08-08', CURRENT_TIMESTAMP, 'Customer'),
    ('user9', 'password9', 'TK009', 'user9@example.com', N'Người dùng 9', '1234567898', N'Địa chỉ 9', '1998-09-09', CURRENT_TIMESTAMP, 'Customer'),
    ('user10', 'password10', 'TK010', 'user10@example.com', N'Người dùng 10', '1234567899', N'Địa chỉ 10', '1999-10-10', CURRENT_TIMESTAMP, 'Customer');



INSERT INTO DANHGIA(Ma, TenNguoiBan, TenSP, MaDH, TenNguoiMua, KhachHangDG, PhanHoiDG, FileAnh)
VALUES
     ('TK006',N'Người dùng 6', N'Loa thanh Soundbar Samsung HW T420','HWT2427/03/24',N'Dư Hoàng Huy',N'Loa dùng rất mượt, giá thành hợp lý',N'Chưa có phản hồi', 'D:\\bao\\OOP(C#)\\FileAnh\\18.jpg'),
    ('TK006', N'Người dùng 6', N'iPhone 11','A255G27/03/24',N'Dư Hoàng Huy', N'Dùng rất tốt', N'Chưa có phản hồi', 'D:\\bao\\OOP(C#)\\FileAnh\\2.jpg')


INSERT INTO DONHANG(MaDH, MaND, TenNguoiBan, MaSP, NgayMua, TongTien, TrangThaiThanhToan, TrangThaiGiaoHang)
VALUES
    ('1232213', 'TK003', N'Người dùng 7',  N'IPX09', '2024-04-10', 700000, 'chua thanh toan', 'chua giao hang'),
    ('A255G25/04/24','TK002','Người dùng 4','A255G','2024-04-25',5290000, 'Chua thanh toan',	'Chua giao hang')

INSERT INTO KHUYENMAI(MaKhuyenMai,LoaiKhuyenMai, TenKhuyenMai, GiaTri, NgayBD, NgayKT)
VALUES
    ('AXC123ABX','Voucher', ' Giam Gia' ,10, '2024-03-26','2024-04-26')



SELECT *FROM DONHANG
DELETE FROM KHUYENMAI
DROP TABLE KHUYENMAI
DROP TABLE DONHANG

DELETE FROM USERS
DROP TABLE USERS

SELECT TOP 1 MaND, COUNT(MaND) AS DemMaND 
FROM DONHANG
GROUP BY MaND
ORDER BY DemMaND DESC