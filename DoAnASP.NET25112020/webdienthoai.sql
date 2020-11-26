create database DB_DoAn
CREATE TABLE DongDienThoai (
  IMEI varchar(15) NOT NULL,
  MaDongDT varchar(10) NOT NULL,
  MauSac varchar(15) NOT NULL
)

--
-- Dumping data for table dienthoai
--

INSERT INTO  DongDienThoai(IMEI, MaDongDT, MauSac) VALUES
('355792420054554', 'VI02', 'Trắng'),
('356257742042470', 'OP01', 'Vàng'),
('356257742798678', 'OP01', 'Đen'),
('356752500544887', 'OP02', 'Đen'),
('356752543235458', 'OP03', 'Vàng'),
('356757211117575', 'HT01', 'Xanh'),
('356757275735770', 'HT02', 'Đỏ'),
('356757275737575', 'HT03', 'Xám'),
('356757892275004', 'NO02', 'Xám'),
('356757892275799', 'NO03', 'Xanh'),
('356757892873539', 'NO01', 'Trắng'),
('356770470724047', 'SO01', 'Xám'),
('356774275750001', 'SO02', 'Xám'),
('356774275752002', 'SO03', 'Xám'),
('356774275787752', 'SO03', 'Hồng'),
('357257056757727', 'SA01', 'Trắng'),
('357257056975004', 'SA02', 'Đen'),
('357257056975167', 'SA02', 'Đen'),
('357257056975168', 'SA02', 'Trắng'),
('357257056975724', 'SA01', 'Đen'),
('357257076343273', 'IP01', 'Trắng'),
('357262443212544', 'SA03', 'Đen'),
('357278637425355', 'SA04', 'Đen'),
('357278637425357', 'SA04', 'Khói'),
('357700733424624', 'IP02', 'Trắng'),
('357701007624767', 'IP03', 'Đen'),
('357701008833352', 'IP03', 'Đen'),
('357701557757727', 'IP03', 'Xám'),
('357763571111425', 'IP01', 'Xám'),
('357763577532420', 'IP01', 'Xám'),
('357763577757001', 'IP04', 'Trắng'),
('357763577757725', 'IP01', 'Đen'),
('357763577788888', 'NO04', 'Đen'),
('685421035653', 'HT01', 'dfgh');

-- --------------------------------------------------------

--
-- Table structure for table dongdienthoai
--

CREATE TABLE DienThoai (
  MaDongDT varchar(10) NOT NULL,
  MaLoai varchar(10) NOT NULL,
  MaHangSX varchar(10) NOT NULL,
  MaNCC varchar(10) NOT NULL,
  TenDongDT varchar(50) NOT NULL,
  Hinh varchar(255) NOT NULL,
  DonGia float NOT NULL,
  GiaKM float NOT NULL DEFAULT '0'
)

--
-- Dumping data for table dongdienthoai
--
INSERT INTO DienThoai (MaDongDT, MaLoai, MaHangSX, MaNCC, TenDongDT, Hinh, DonGia, GiaKM) VALUES
('HT01', 'TM', 'HTC', 'NCC03', 'HTC U Play', 'htcuplay.jpg', 8990000, 0),
('HT02', 'TM', 'HTC', 'NCC03', 'HTC U11 Red', 'htcu11red.jpg', 16990000, 0),
('HT03', 'TM', 'HTC', 'NCC03', 'HTC U11', 'htcu11.jpg', 16990000, 0),
('IP01', 'TM', 'APP', 'NCC01', 'iPhone 8 Plus 256GB', 'iphone8plus.png', 28790000, 0),
('IP02', 'TM', 'APP', 'NCC01', 'iPhone 5s 16GB', 'iphone5s.png', 5999000, 0),
('IP03', 'TM', 'APP', 'NCC02', 'iPhone 8 256GB', 'iphone8plus.png', 25790000, 0),
('IP04', 'TM', 'APP', 'NCC02', 'iPhone 6s Plus 32GB', 'ip_6s_32.png', 14490000, 0),
('IP05', 'TM', 'APP', 'NCC03', 'iPhone 8 Plus 64GB', 'iphone8plus.png', 23990000, 0),
('NO01', 'TM', 'NOK', 'NCC02', 'Nokia 5', 'nokia5.png', 5259000, 4259000),
('NO02', 'TM', 'NOK', 'NCC02', 'Nokia 6', 'nokia6.png', 5590000, 0),
('NO03', 'TM', 'NOK', 'NCC02', 'Nokia 8', 'nokia8.png', 12990000, 0),
('NO04', 'BP', 'NOK', 'NCC02', 'Nokia N150', 'n150.png', 649000, 0),
('OP01', 'TM', 'OPP', 'NCC01', 'Oppo F3 Plus', 'oppof3+.jpg', 10690000, 0),
('OP02', 'TM', 'OPP', 'NCC01', 'Oppo F1s 2017 (64GB)', 'oppof1s2017.jpg', 5990000, 0),
('OP03', 'TM', 'OPP', 'NCC01', 'Oppo F1 Plus', 'oppof1+.jpg', 6490000, 0),
('OP04', 'TM', 'OPP', 'NCC01', 'Oppo F3 Lite (A57)', 'oppof3lite.jpg', 5490000, 0),
('SA01', 'TM', 'SAM', 'NCC02', 'Samsung Galaxy S8', 'samsunggalaxys8.png', 18490000, 0),
('SA02', 'TM', 'SAM', 'NCC02', 'Samsung Galaxy J7 Pro', 'samgalaJ7-pro.png', 6990000, 0),
('SA03', 'TM', 'SAM', 'NCC01', 'Samsung Galaxy Note 8', 'samnote8.png', 22490000, 0),
('SA04', 'TM', 'SAM', 'NCC01', 'Samsung Galaxy S8 Plus', 'samsunggalaxys8.png', 20490000, 0),
('SA05', 'TM', 'SAM', 'NCC03', 'Samsung Galaxy A5 (2017)', 'dt_1.png', 7990000, 0),
('SO01', 'TM', 'SON', 'NCC01', 'Sony Xperia XZ1', 'sonyxperiaxz1.png', 15990000, 0),
('SO02', 'TM', 'SON', 'NCC03', 'Sony Xperia XA1 Ultra', 'sonyxperiaxa1ultra.png', 8490000, 0),
('SO03', 'TM', 'SON', 'NCC01', 'Sony Xperia XZ Premium', 'sonyxperiaxzpremium.png', 17990000, 0),
('VI02', 'TM', 'VIV', 'NCC03', 'Vivo V5s', 'vivov5s.png', 6690000, 0);

-- --------------------------------------------------------

--
-- Table structure for table donhang
--



--



-- --------------------------------------------------------

--
-- Table structure for table loaidienthoai
--





--
-- Table structure for table nhanvien
--


--
-- Indexes for dumped tables
--

--


-- Indexes for table dienthoai
--
ALTER TABLE DongDienThoai
  ADD PRIMARY KEY (IMEI),
  ADD UNIQUE KEY IMEI (IMEI),
  ADD KEY MaDongDT (MaDongDT);

--
-- Indexes for table dongdienthoai
--
ALTER TABLE DienThoai
  ADD PRIMARY KEY (MaDongDT),
  ADD UNIQUE KEY MaDongDT (MaDongDT),
  ADD KEY MaLoai (MaLoai),
  ADD KEY MaHangSX (MaHangSX),
  ADD KEY MaNCC (MaNCC);
--
-- Constraints for table dienthoai
--
ALTER TABLE dienthoai
  ADD CONSTRAINT dienthoai_ibfk_1 FOREIGN KEY (MaDongDT) REFERENCES dongdienthoai (MaDongDT) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table dongdienthoai
--
ALTER TABLE dongdienthoai
  ADD CONSTRAINT dongdienthoai_ibfk_1 FOREIGN KEY (MaNCC) REFERENCES nhacungcap (MaNCC) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT dongdienthoai_ibfk_2 FOREIGN KEY (MaLoai) REFERENCES loaidienthoai (MaLoai) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT dongdienthoai_ibfk_3 FOREIGN KEY (MaHangSX) REFERENCES hangsanxuat (MaHangSX) ON DELETE CASCADE ON UPDATE CASCADE;

