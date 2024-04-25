CREATE TABLE SANPHAM 
(
	 DANHMUC NVARCHAR(50) NOT NULL,
	 TENSP NVARCHAR(50) NOT NULL,
	 MASP NVARCHAR(10) NOT NULL PRIMARY KEY,
	 MAU NVARCHAR(50) NOT NULL,
	 GIAGOC INT  NOT NULL,
	 GIA INT NOT NULL,
	 TINHTRANG NVARCHAR(50) NOT NULL,
	 KHUYENMAI NVARCHAR(50) NOT NULL,
	 DANHGIA FLOAT NOT NULL,
	 LINHKIEN NVARCHAR(50) NOT NULL,
	 BAOHANH NVARCHAR(50) NOT NULL,
	 SOLUONG INT NOT NULL,
	 THONGTIN NVARCHAR(500) NOT NULL,
	 PHUKIEN NVARCHAR(50) NOT NULL,
	 NGAYTHEM DATE	NOT NULL,
	 FILEANH NVARCHAR(50) NOT NULL
)



CREATE TABLE KHOHANG
(
	MASP NVARCHAR(10) PRIMARY KEY,
	TENSP NVARCHAR(50) NOT NULL,
	NGUOIBAN NVARCHAR(100) NOT NULL,
	MATK VARCHAR(10) NOT NULL ,
	NGAYDANG DATETIME NOT NULL,
	NGAYHETHAN DATETIME NOT NULL,
	FOREIGN KEY (MASP) REFERENCES SANPHAM(MASP),
)

INSERT INTO SANPHAM(DANHMUC, TENSP, MASP, MAU, GIAGOC,  GIA, TINHTRANG, KHUYENMAI, DANHGIA, LINHKIEN, BAOHANH, SOLUONG, THONGTIN, PHUKIEN, NGAYTHEM, FILEANH)
VALUES 
(N'Điện thoại', N'iPhone XS Max  ', N'IPX09', N'Xám', 10000, 8190, N'Cũ đẹp 90%', N'Trả góp 0% + Tặng ốp dán', 4.5, N'Chưa thay linh kiện.', N'6 tháng', 4, N'SP được thu lại từ khách bán lại - thu cũ, ngoại hình đẹp như máy mới.', N'Đầy đủ phụ kiện từ NSX', N'2024-03-26','D:\\bao\\OOP(C#)\\FileAnh\\1.jpg'),
(N'Điện thoại', N'iPhone 11 ', N'IP1101', N'Xanh', 9000, 7590, N'Cũ, đẹp 89%, trầy xước nhẹ', N'Trả góp 0% + Sạc dự phòng', 4.7, N'Thay màn', N'5 tháng', 2, N'SP được thu lại từ khách bán lại - thu cũ, ngoại hình đẹp như máy mới. Linh kiện đã được thay thế nhưng vẫn đảm bảo sự ổn định cho thiết bị.', N'Không bao gồm phụ kiện', N'2024-03-16','D:\\bao\\OOP(C#)\\FileAnh\\2.jpg'),
(N'Điện thoại', N'iPhone 13 ', N'IP13SA', N'Đen', 15000, 12590, N'Cũ, đẹp 99%', N'Trả góp 0% + Sạc nhanh', 4.9, N'Chưa thay linh kiện.', N'6 tháng', 1, N'SP được thu lại từ khách bán lại - thu cũ, Có nguồn gốc rõ ràng, xuất bán đầy đủ hoá đơn eVAT.', N'Sạc nhanh', N'2024-01-19','D:\\bao\\OOP(C#)\\FileAnh\\3.jpg'),
(N'Điện thoại', N'iPhone 15 Pro ', N'IP15AA', N'Titan trắng', 25000, 23190, N'Cũ đẹp 98%', N'Trả góp 0%', 4.6, N'Chưa thay linh kiện.', N'6 tháng', 2, N'SP được thu lại từ khách bán lại - thu cũ, ngoại hình đẹp như máy mới.', N'Đầy đủ phụ kiện từ NSX', N'2024-02-17', 'D:\\bao\\OOP(C#)\\FileAnh\\4.jpg'),
(N'Điện thoại', N'Samsung Galaxy Z Flip4 ', N'GLXZ01', N'Vàng', 10000, 8990, N'Cũ, đẹp 92%', N'Tặng ốp dán', 4.7, N'Chưa thay linh kiện.', N'4 tháng', 1, N'SP được thu lại từ khách bán lại - thu cũ, ngoại hình đẹp như máy mới.', N'Không bao gồm phụ kiện', N'2024-02-18', 'D:\\bao\\OOP(C#)\\FileAnh\\5.jpg'),
(N'Điện thoại', N'Samsung Galaxy A25 ', N'A255G', N'Đen', 7000, 5290, N'Cũ, đẹp 99%', N'Trả góp 0% + Cường lực', 4.9, N'Chưa thay linh kiện.', N'6 tháng', 1, N'SP được thu lại từ khách bán lại - thu cũ, Có nguồn gốc rõ ràng, xuất bán đầy đủ hoá đơn eVAT.', N'Sạc nhanh', N'2024-02-01', 'D:\\bao\\OOP(C#)\\FileAnh\\6.jpg'),
(N'Điện thoại', N'Samsung Galaxy Z Fold3 ', N'A5GZF', N'Bạc', 16000, 12790, N'Cũ, đẹp 99%', N'Trả góp 0% + Voucher 200k', 4.7, N'Chưa thay linh kiện.', N'5 tháng', 1, N'SP được thu lại từ khách bán lại - thu cũ, ngoại hình đẹp như máy mới. Linh kiện đã được thay thế nhưng vẫn đảm bảo sự ổn định cho thiết bị.', N'Không bao gồm phụ kiện', N'2024-01-15', 'D:\\bao\\OOP(C#)\\FileAnh\\7.jpg'),
(N'Điện thoại', N'Samsung Galaxy S24 Ultra ', N'GLXS24', N'Xám', 26000, 24390, N'Cũ, đẹp 99%', N'Trả góp 0% + Ốp chống sốc', 4.9, N'Chưa thay linh kiện.', N'12 tháng', 1, N'SP được thu lại từ khách bán lại - thu cũ, ngoại hình đẹp như máy mới. ', N'Đầy đủ phụ kiện từ NSX', N'2023-12-09', 'D:\\bao\\OOP(C#)\\FileAnh\\8.jpg'),
(N'Điện thoại', N'Samsung Galaxy A15 LTE ', N'GLXA15', N'Đen', 5000, 3890, N'Cũ, đẹp 92%', N'Không có', 4.2, N'Chưa thay linh kiện.', N'3 tháng', 1, N'SP được thu lại từ khách bán lại - thu cũ, ngoại hình đẹp như máy mới. ', N'Đầy đủ phụ kiện từ NSX', N'2024-01-18', 'D:\\bao\\OOP(C#)\\FileAnh\\9.jpg'),


(N'Laptop', N'Surface Pro 7 Core i5 / 8GB / 128GB', N'SFPI5', N'Trắng', 15000, 10590, N'Trầy xước, đẹp 90%', N'Không có', 4.3, N'Chưa thay linh kiện.', N'3 tháng', 1, N'SP thu lại từ khách có nhu cầu bán lại, thu cũ, ngoại hình cấn nhẹ thân máy/mặt kính màn hình.', N'Kèm Cáp, củ sạc', N'2023-12-17', 'D:\\bao\\OOP(C#)\\FileAnh\\10.jpg'),
(N'Laptop', N'Lenovo IdeaPad 3 ', N'IP314I', N'Xám', 18000, 11490, N'Cũ, đẹp 90%, trầy xước nhẹ', N'Giảm 200k', 4.7, N'Chưa thay linh kiện.', N'5 tháng', 1, N'SP chính hãng đã active, thu lại từ khách không sử dụng trong thời gian test(30 ngày).', N'Đầy đủ phụ kiện từ NSX', N'2023-12-14', 'D:\\bao\\OOP(C#)\\FileAnh\\11.jpg'),
(N'Laptop', N'Laptop Dell Inspiron ', N'DI350', N'Đen', 16000, 8390, N'Trầy nhẹ thân máy, mặt kính, đẹp 92%', N'Không có', 4.6, N'Chưa thay linh kiện.', N'6 tháng', 1, N'SP được thu lại từ khách có nhu cầu bán lại, thu cũ.', N'Kèm Cáp, củ sạc ', N'2023-12-11', 'D:\\bao\\OOP(C#)\\FileAnh\\12.jpg'),
(N'Laptop', N'Laptop Asus VivoBook ', N'X515A', N'Bạc', 14000, 7690, N'Cũ, ngoại hình đẹp 90%', N'Trả góp 0%', 4.5, N'Chưa thay linh kiện.', N'5 tháng', 1, N'SP thu lại từ khách có nhu cầu bán lại, thu cũ, ngoại hình đẹp như máy mới.', N'Kèm: Cáp, củ sạc', N'2024-01-20', 'D:\\bao\\OOP(C#)\\FileAnh\\13.jpg'),
(N'Laptop', N'Laptop HP 240 G8 ', N'518V6', N'Bạc', 18000, 7290, N'Cũ Xước Cấn, 89%', N'Không có', 4.6, N'Chưa thay linh kiện.', N'6 tháng', 1, N'SP được thu lại từ khách có nhu cầu bán lại, thu cũ.', N'Không bao gồm phụ kiện', N'2023-12-04', 'D:\\bao\\OOP(C#)\\FileAnh\\14.jpg'),
(N'Laptop', N'Laptop HP 15S', N'FQ271', N'Đen', 10000, 7790, N'Cũ, đẹp, 85%', N'Trả góp 0%', 4.9, N'Chưa thay linh kiện.', N'6 tháng', 1, N'SP được thu lại từ khách có nhu cầu bán lại, thu cũ.', N'Không bao gồm phụ kiện', N'2024-03-01', 'D:\\bao\\OOP(C#)\\FileAnh\\15.jpg'),


(N'Loa', N'Loa JBL Partybox On The Go', N'IPXO4', N'Đen', 8000, 4990, N'Cũ, không móp méo, 93%', N'Trả góp 0%', 4.3, N'Chưa thay linh kiện.', N'3 tháng', 1, N'Phụ kiện cũ, không bao gồm hộp', N'Không bao gồm phụ kiện', N'2024-01-22', 'D:\\bao\\OOP(C#)\\FileAnh\\16.jpg'),
(N'Loa', N'Loa Bluetooth JBL Xtreme 3', N'JBLX4', N'Đen', 6000, 3400, N'Cũ, xước nhẹ thân, 89%', N'Trả góp 0%', 4.7, N'Chưa thay linh kiện.', N'1 tháng', 1, N'Phụ kiện cũ, không bao gồm hộp', N'Túi bọc', N'2023-12-02', 'D:\\bao\\OOP(C#)\\FileAnh\\17.jpg'),
(N'Loa', N'Loa thanh Soundbar Samsung HW T420', N'HWT24', N'Đen (led xanh)', 3000, 1900, N'Cũ, đẹp, 91%', N'Trả góp 0%', 4.6, N'Chưa thay linh kiện.', N'2 tháng', 1, N'Phụ kiện cũ, không bao gồm hộp', N'Không bao gồm phụ kiện', N'2024-01-30', 'D:\\bao\\OOP(C#)\\FileAnh\\18.jpg'),
(N'Loa', N'Loa Bluetooth Havit SK838BT', N'SK838', N'Rằn ri', 2500, 999, N'Cũ, xước nhẹ thân, 85%', N'Trả góp 0%', 4.5, N'Chưa thay linh kiện.', N'6 tháng', 1, N'Phụ kiện cũ, không bao gồm hộp', N'Túi bọc', N'2024-03-09', 'D:\\bao\\OOP(C#)\\FileAnh\\19.jpg'),
(N'Loa', N'Loa Sony SRS-XB23 Extra Bass', N'SRS23', N'Đen', 3400, 1400, N'Cũ, đẹp, 98%', N'Trả góp 0%', 4.6, N'Chưa thay linh kiện.', N'5 tháng', 1, N'Phụ kiện cũ, không bao gồm hộp', N'Túi bọc', N'2024-01-18', 'D:\\bao\\OOP(C#)\\FileAnh\\20.jpg'),
(N'Loa', N'Loa Bluetooth JBL Pulse 5', N'JBLP5', N'Xanh', 11000, 5390, N'Cũ, xước nhẹ thân, 94%', N'Trả góp 0%', 4.9, N'Chưa thay linh kiện.', N'4 tháng', 1, N'Phụ kiện cũ, không bao gồm hộp', N'Không bao gồm phụ kiện', N'2024-03-03', 'D:\\bao\\OOP(C#)\\FileAnh\\21.jpg');





INSERT INTO KHOHANG (MASP, TENSP, NGUOIBAN, MATK, NGAYDANG, NGAYHETHAN)
VALUES 
	('518V6', 'Laptop HP 240 G8', N'Người dùng 4', 'TK004', '2024-04-09 08:00:00', '2024-05-09 08:00:00'),
	('A255G', 'Samsung Galaxy A25', N'Người dùng 4', 'TK004', '2024-04-09 09:00:00', '2024-05-09 09:00:00'),
	('A5GZF', 'Samsung Galaxy Z Fold3',	N'Người dùng 4', 'TK004', '2024-04-09 10:00:00', '2024-05-09 10:00:00'),
	('DI350', 'Laptop Dell Inspiron', N'Người bán 4', 'TK004', '2024-04-09 11:00:00', '2024-05-09 11:00:00'),

	('FQ271', 'Laptop HP 15', N'Người dùng 5', 'TK005', '2024-04-09 12:00:00', '2024-05-09 12:00:00'),
	('GLXA15', 'Samsung Galaxy A15 LTE', N'Người dùng 5', 'TK005', '2024-04-09 12:00:00', '2024-05-09 12:00:00'),
	('GLXS24', 'Samsung Galaxy S24 Ultra', N'Người dùng 5', 'TK005', '2024-04-09 12:00:00', '2024-05-09 12:00:00'),
	('GLXZ01', 'Samsung Galaxy Z Flip4', N'Người dùng 5', 'TK005', '2024-04-09 12:00:00', '2024-05-09 12:00:00'),


	('HWT24', 'Loa thanh Soundbar Samsung HW T420', N'Người dùng 6', 'TK006', '2024-04-09 13:00:00', '2024-05-09 13:00:00'),
	('IP1101', 'iPhone 11', N'Người dùng 6', 'TK006', '2024-04-09 13:00:00', '2024-05-09 13:00:00'),
	('IP13SA', 'iPhone 13', N'Người dùng 6', 'TK006', '2024-04-09 13:00:00', '2024-05-09 13:00:00'),
	('IP15AA', 'iPhone 15 Pro', N'Người dùng 6', 'TK006', '2024-04-09 13:00:00', '2024-05-09 13:00:00'),


	('IP314I', 'Lenovo IdeaPad 3', N'Người dùng 7', 'TK007', '2024-04-09 14:00:00', '2024-05-09 14:00:00'),
	('IPX09', 'iPhone XS Max', N'Người dùng 7', 'TK007', '2024-04-09 14:00:00', '2024-05-09 14:00:00'),
	('IPXO4', 'Loa JBL Partybox On The Go', N'Người dùng 7', 'TK007', '2024-04-09 14:00:00', '2024-05-09 14:00:00'),

	('JBLP5', 'Loa Bluetooth JBL Pulse 5', N'Người dùng 8', 'TK008', '2024-04-09 15:00:00', '2024-05-09 15:00:00'),
	('JBLX4', 'Loa Bluetooth JBL Xtreme 3', N'Người dùng 8', 'TK008', '2024-04-09 15:00:00', '2024-05-09 15:00:00'),
	('SFPI5', 'Surface Pro 7 Core i5 / 8GB / 128GB', N'Người dùng 8', 'TK008', '2024-04-09 15:00:00', '2024-05-09 15:00:00'),

	('SK838', 'Loa Bluetooth Havit SK838BT', N'Người dùng 9', 'TK009', '2024-04-09 16:00:00', '2024-05-09 16:00:00'),
	('SRS23', 'Loa Sony SRS-XB23 Extra Bass', N'Người dùng 9', 'TK009', '2024-04-09 16:00:00', '2024-05-09 16:00:00'),

	('X515A', 'Laptop Asus VivoBook', N'Người bán 10', 'TK010', '2024-04-09 17:00:00', '2024-05-09 17:00:00');




DELETE FROM SANPHAM
DELETE FROM NHANVIEN


DROP TABLE NHANVIEN
SELECT * From DANHGIA
SELECT * FROM USERS WHERE MaTK = 'TK003' 
