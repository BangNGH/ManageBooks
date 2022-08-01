create table DOCGIA
(
	MaDG char(10) primary key,
	TenDG nvarchar(50), 
	NgaySinhDG date,
	GioiTinh nvarchar(5),
	SDTDG char(10) unique,
)

create table KESACH
(
	MaKeSach char(10) primary key,
	ViTri nvarchar(20),
)

create table THELOAI
(
	MaTL char(10) primary key,
	TenTL nvarchar(50),
)

create table NHAXUATBAN
(
	MaNXB char(10) primary key,
	TenNXB nvarchar(50),
	SDTNXB char(10) unique,
)

create table NHACUNGCAP
(
	MaNCC char(10) primary key,
	TenNCC nvarchar(50),
)

create table NHANVIEN
(
	MaNV char(10) primary key,
	TenNV nvarchar(50),
	GioiTinh nvarchar(5),
	SDT char(10) unique,
	ChucVu nvarchar(50),
)

create table PHIEUNHAP
(
	MaPN char(10) primary key,
	MaNV char(10),
	MaNCC char(10),
	foreign key (MaNV) references NHANVIEN(MaNV),
	foreign key (MaNCC) references NHACUNGCAP(MaNCC)

)

create table SACH
(
	MaSach char(10) primary key, 
	TenSach nvarchar(100) not null,
	TenTacGia nvarchar(50),
	MaTL char(10),
	MaNXB char(10),
	NamXB int,
	MaKeSach char(10),
	foreign key (MaKeSach) references KESACH(MaKeSach),
	foreign key (MaNXB) references NHAXUATBAN(MaNXB),
	foreign key (MaTL) references THELOAI(MaTL)
)

create table CT_PHIEUNHAP
(
	MaPN char(10),
	MaSach char(10),
	primary key(MaPN,MaSach),
	SoLuongNhap int check(SoLuongNhap>=0),
	DonGiaNhap int check (DonGiaNhap >=0),
	foreign key (MaPN) references PHIEUNHAP(MaPN),
	foreign key (MaSach) references SACH(MaSach)
	
)

create table PHIEUMUON
(
	MaPM char(10) primary key,
	MaNV char(10),
	MaDG char(10),
	foreign key (MaNV) references NHANVIEN(MaNV),
	foreign key (MaDG) references DOCGIA(MaDG)
)

create table CT_PHIEUMUON
(
	MaPM char(10),
	MaSach char(10),
	NgayMuon datetime,
	NgayTra datetime,
	TinhTrangSach nvarchar(50),
	primary key(MaPM, MaSach),
	foreign key (MaPM) references PHIEUMUON(MaPM),
	foreign key(MaSach) references SACH(MaSach)

)

create table PHIEUPHAT
(
	MaPP char(10) primary key,
	MaNV char(10),
	MaPM char(10),
	MaSach char(10),
	MucPhiPhat int check(MucPhiPhat>0),
	foreign key (MANV) references NHANVIEN(MaNV),
	foreign key (MaPM, MaSach) references CT_PHIEUMUON(MaPM, MaSach)
)

create table THETV
(
	MaTTV char(10) primary key,
	MaDG char(10),
	foreign key (MaDG) references DOCGIA(MaDG)
)

create table Account
(
	id int identity(1,1) primary key,
	taiKhoan varchar(50) unique,
	matKhau nvarchar(50) not null,
	MaDG char(10),
	MaNV char(10),
	foreign key (MaDG) references DOCGIA(MaDG),
	foreign key (MaNV) references NHANVIEN(MaNV)
)
GO
create trigger check_Account on Account 
for insert as
BEGIN
	IF exists (
				select taiKhoan, matKhau 
				from Account
				group by taiKhoan, matKhau
				having LEN(taiKhoan) < 6 or LEN(matKhau) < 6
			  )
	BEGIN
		PRINT N'Tài khoản và mật khẩu phải có tối thiểu 6 ký tự'
		ROLLBACK TRAN
	END
END
	
go

drop trigger check_Account



