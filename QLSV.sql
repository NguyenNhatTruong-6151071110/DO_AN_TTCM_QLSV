CREATE DATABASE QLSinhVien;
USE QLSinhVien;

CREATE Table TaiKhoan(
	tentaikhoan nvarchar(50) primary key not null,
	matkhau varchar(150)
)
select * from TaiKhoan

CREATE table Monhoc(
	ngaytao datetime,
	nguoitao nvarchar(30),
	ngaycapnhat datetime,
	nguoicapnhat nvarchar(30),
	mamonhoc int primary key identity(100,1) not null,
	tenmonhoc nvarchar(150) not null,
	sotinchi int
)

select * from Monhoc
insert into Monhoc(tenmonhoc, sotinchi) values (N'An toàn bảo mật thông tin', 3);
insert into Monhoc(tenmonhoc, sotinchi) values (N'Anh văn chuyên ngành', 3);
insert into Monhoc(tenmonhoc, sotinchi) values (N'Lập trình thiết bị di động', 3);
insert into Monhoc(tenmonhoc, sotinchi) values (N'Lập trình web', 3);
insert into Monhoc(tenmonhoc, sotinchi) values (N'Thực tập chuyên môn', 3);
insert into Monhoc(tenmonhoc, sotinchi) values (N'Lý thuyết trò chơi và ứng dụng', 3);
insert into Monhoc(tenmonhoc, sotinchi) values (N'Lập trình API', 3);
insert into Monhoc(tenmonhoc, sotinchi) values (N'Lập trình mạng', 3);
CREATE table GiaoVien(
	ngaytao datetime,
	nguoitao nvarchar(30),
	ngaycapnhat datetime,
	nguoicapnhat nvarchar(30),
	magiaovien int identity(1000,1) primary key not null,
	ho nvarchar(10) not null,
	tendem nvarchar(20),
	ten nvarchar(10) not null,
	gioitinh tinyint,
	ngaysinh date,
	dienthoai varchar(30),
	email nvarchar(150),
	diachi nvarchar(150)
)
select * from GiaoVien
insert into GiaoVien (ho, tendem, ten, gioitinh, ngaysinh, dienthoai, email, diachi)
values (N'Trần', N'Phong', N'Nhã', 0, '1980-12-24', '0977548223','phongnha@gmail.com', N'Hồ Chí Minh' );
insert into GiaoVien (ho, tendem, ten, gioitinh, ngaysinh, dienthoai, email, diachi)
values (N'Nguyễn', N'Thiện', N'Dương', 0, '1998-08-12', '0986483663','thienduong@gmail.com', N'Hồ Chí Minh' );
insert into GiaoVien (ho, tendem, ten, gioitinh, ngaysinh, dienthoai, email, diachi)
values (N'Trần', N'Thị', N'Dung', 1, '1990-05-09', '0975283663','dungtran@gmail.com', N'Hồ Chí Minh' );
insert into GiaoVien (ho, tendem, ten, gioitinh, ngaysinh, dienthoai, email, diachi)
values (N'Trần', N'Quốc', N'Khánh', 0, '1998-10-09', '0975273993','quockhanh@gmail.com', N'Hồ Chí Minh' );
CREATE table SinhVien(
	ngaytao datetime,
	nguoitao nvarchar(30),
	ngaycapnhat datetime,
	nguoicapnhat nvarchar(30),
	masinhvien varchar(50) primary key not null,
	ho nvarchar(10) not null,
	tendem nvarchar(20),
	ten nvarchar(10) not null,
	gioitinh tinyint,
	ngaysinh date,
	quequan nvarchar(150),
	diachi nvarchar(150),
	dienthoai varchar(30),
	email nvarchar(150)
)
select * from SinhVien
 create sequence sinhvienSeq
	start with 1000
	increment by 1;

	select next value for sinhvienSeq

	insert into SinhVien(masinhvien, ho, tendem, ten, gioitinh, ngaysinh, quequan, diachi, dienthoai, email)
	values ('615107' +CAST(next value for sinhvienSeq as varchar(30)),
	N'Nguyen', N'Nhật',N'Trường', 0, '2002-10-29', N'Lâm Đồng', N'Thủ Đức', '0393451662', 'nhattruong@gmail.com' );
	insert into SinhVien(masinhvien, ho, tendem, ten, gioitinh, ngaysinh, quequan, diachi, dienthoai, email)
	values ('615107' +CAST(next value for sinhvienSeq as varchar(30)),
	N'Nguyễn', N'Việt',N'Hà', 0, '2002-10-27', N'Lâm Đồng', N'Thủ Đức', '0398274661', 'vietha@gmail.com' );
		insert into SinhVien(masinhvien, ho, tendem, ten, gioitinh, ngaysinh, quequan, diachi, dienthoai, email)
	values ('615107' +CAST(next value for sinhvienSeq as varchar(30)),
	N'Phạm', N'Nguyễn Thanh',N'Tú', 1, '2002-10-28', N'Lâm Đồng', N'Gò Vấp', '0397182661', 'thanhtu@gmail.com' );
		insert into SinhVien(masinhvien, ho, tendem, ten, gioitinh, ngaysinh, quequan, diachi, dienthoai, email)
	values ('615107' +CAST(next value for sinhvienSeq as varchar(30)),
	N'Đậu', N'Đoàn Như',N'Định', 1, '2002-11-24', N'Lâm Đồng', N'Quận 10', '03927461552', 'nhudinh@gmail.com' );
		insert into SinhVien(masinhvien, ho, tendem, ten, gioitinh, ngaysinh, quequan, diachi, dienthoai, email)
	values ('615107' +CAST(next value for sinhvienSeq as varchar(30)),
	N'Lê', N'Ngọc Minh',N'Thư', 1, '2002-06-21', N'Lâm Đồng', N'Quận 10', '0398796532', 'minhthu@gmail.com' );
		insert into SinhVien(masinhvien, ho, tendem, ten, gioitinh, ngaysinh, quequan, diachi, dienthoai, email)
	values ('615107' +CAST(next value for sinhvienSeq as varchar(30)),
	N'Trương', N'Quang',N'Denni', 0, '2002-12-29', N'Lâm Đồng', N'Quận 12', '0388374662', 'dennitq@gmail.com' );
		insert into SinhVien(masinhvien, ho, tendem, ten, gioitinh, ngaysinh, quequan, diachi, dienthoai, email)
	values ('615107' +CAST(next value for sinhvienSeq as varchar(30)),
	N'Hồng', N'Huy',N'Kim', 0, '2002-07-24', N'Lâm Đồng', N'Bình Thạnh', '0399863992', 'huykim@gmail.com' );
		insert into SinhVien(masinhvien, ho, tendem, ten, gioitinh, ngaysinh, quequan, diachi, dienthoai, email)
	values ('615107' +CAST(next value for sinhvienSeq as varchar(30)),
	N'Nguyễn', N'Duy',N'Thao', 0, '2002-10-08', N'Nghệ An', N'Thủ Đức', '03892373552', 'duythao@gmail.com' );
		insert into SinhVien(masinhvien, ho, tendem, ten, gioitinh, ngaysinh, quequan, diachi, dienthoai, email)
	values ('615107' +CAST(next value for sinhvienSeq as varchar(30)),
	N'Lê', N'Công',N'Tuấn', 0, '2002-03-28', N'Vũng Tàu', N'Thủ Đức', '0379263092', 'congtuan@gmail.com' );
		insert into SinhVien(masinhvien, ho, tendem, ten, gioitinh, ngaysinh, quequan, diachi, dienthoai, email)
	values ('615107' +CAST(next value for sinhvienSeq as varchar(30)),
	N'Nguyễn', N'Tuấn',N'Kiệt', 0, '2002-09-30', N'Bình Định', N'Thủ Đức', '0378927393', 'tuankiet@gmail.com' );
		insert into SinhVien(masinhvien, ho, tendem, ten, gioitinh, ngaysinh, quequan, diachi, dienthoai, email)
	values ('615107' +CAST(next value for sinhvienSeq as varchar(30)),
	N'Chế', N'Phan Hoàng',N'Việt', 0, '2002-01-27', N'Bình Định', N'Thủ Đức', '0837493737', 'hoangviet@gmail.com' );
CREATE table Diem(
	ngaytao datetime,
	nguoitao nvarchar(30),
	ngaycapnhat datetime,
	nguoicapnhat nvarchar(30),
	mamonhoc int primary key not null,
	magiaovien int not null,
	masinhvien varchar(50) not null,
	lanhoc int  not null,
	diemthilan1 float,
	diemthilan2 float
)
CREATE table LopHoc(
	ngaytao datetime,
	nguoitao nvarchar(30),
	ngaycapnhat datetime,
	nguoicapnhat nvarchar(30),
	malophoc int primary key not null,
	mamonhoc int not null,
	magiaovien int not null,
	daketthuc tinyint,
)
----procedure-----
CREATE PROCEDURE SelectAllSinhVien
@tukhoa nvarchar(50)
AS
	select
		masinhvien,
		case
			when LEN(tendem) > 0 then
				CONCAT(ho,' ',tendem,' ',ten)
			else CONCAT (ho,' ',ten)
		end as hoten,
		CONVERT (varchar(10), ngaysinh, 103) as ngaysinh,
		case
			when gioitinh = 0 then N'Nam'
			else N'Nữ'
		end as gioitinh,
		quequan,
		diachi,
		dienthoai,
		email
	from SinhVien
	where 
		lower(ho) like '%' +lower(trim(@tukhoa)) + '%'
		or lower(tendem) like '%' + lower(trim(@tukhoa)) + '%'
		or lower(ten) like '%' +lower(trim(@tukhoa)) + '%'
		or dienthoai like '%' +lower(trim(@tukhoa)) + '%'
		or quequan like '%' +lower(trim(@tukhoa)) + '%'
		or diachi like '%' +lower(trim(@tukhoa)) + '%'
		or email like '%' +lower(trim(@tukhoa)) + '%'
	order by ten;
GO;
exec [SelectAllSinhVien] N'Thủ Đức'

select * from SinhVien

-- tạo stored procedure để thêm mới sinh viên vào bảng sinh viên
CREATE PROCEDURE ThemMoiSV
	--khai báo danh sách tham chiếu truyền vào
	@Ho nvarchar(10),
	@TenDem nvarchar(20),
	@Ten nvarchar(10),
	@Ngaysinh date,
	@Gioitinh tinyint,
	@Quequan nvarchar(150),
	@Diachi nvarchar(150),
	@Dienthoai varchar(30),
	@Email varchar(150)
	--kết thúc khai báo
AS
	BEGIN 
		--thêm dữ liệu mới
		INSERT INTO SinhVien(
			masinhvien,
			ho, tendem, ten,
			ngaysinh, gioitinh,
			quequan, diachi,
			dienthoai, email
			)VALUES(
			'615107'+CAST(NEXT VALUE FOR sinhvienSeq as varchar(30)),
			@Ho, @TenDem, @Ten,
			@Ngaysinh,
			@Gioitinh,
			@Quequan, @Diachi,
			@Dienthoai, @Email
			);--kết thúc thêm mới

			--kiểm tra xem dữ liệu insert thành công hay chưa
			IF @@ROWCOUNT > 0 BEGIN RETURN 1 END
			ELSE BEGIN RETURN 0 END;
	END
exec ThemMoiSV N'Tôn',N'Nữ Thị Bảo','Trâm','2002-12-28','1',N'Lâm Đồng',N'Gò Vấp','0987689552','baotram@gmail.com'
select * from SinhVien

--tạo procedure update thông tin sinh viên

create procedure updateSV
			--khai báo danh sách tham số truyền vào
			@masinhvien varchar(50),
			@ho nvarchar(10), 
			@tendem nvarchar(20), 
			@ten nvarchar(10),
			@ngaysinh date,
			@gioitinh tinyint,
			@quequan nvarchar(150), 
			@diachi nvarchar(150),
			@dienthoai varchar(30), 
			@email varchar(150)
			--kết thúc khai báo
AS
BEGIN
	UPDATE SinhVien
	SET
		ho = @ho,
		tendem = @tendem,
		ten = @ten,
		ngaysinh = @ngaysinh,
		gioitinh = @gioitinh,
		quequan = @quequan,
		diachi = @diachi,
		dienthoai = @dienthoai,
		email = @email
		WHERE masinhvien = @masinhvien;
		IF @@ROWCOUNT > 0 BEGIN RETURN 1 END
		ELSE BEGIN RETURN 0 END;
END
select * from GiaoVien

create procedure selectAllGV
	@tukhoa nvarchar(50)
	AS
	BEGIN 
		select 
		magiaovien,
		case
			when len(tendem) > 0 then concat (ho, ' ',tendem,' ', ten)
			else CONCAT (ho,' ', ten)
			end as hoten,
			case when gioitinh = 0 then 'Nam'
			else N'Nữ' end as gioitinh,
			ngaysinh,
			dienthoai,
			email,
			diachi
		from GiaoVien
		where 
		lower (concat(ho,'',tendem,'',ten)) like '%'+lower(trim(@tukhoa))+'%'
		or dienthoai like'%'+lower(trim(@tukhoa))+'%'
		or cast(magiaovien as varchar(30)) like'%'+lower(trim(@tukhoa))+'%'
		or lower (email) like'%'+lower(trim(@tukhoa))+'%'
		or lower (ho) like'%'+lower(trim(@tukhoa))+'%'
		or lower(tendem) like '%' + lower(trim(@tukhoa)) + '%'
		or diachi like '%' +lower(trim(@tukhoa)) + '%'
		or lower(ten) like '%' +lower(trim(@tukhoa)) + '%'
		order by ten;
	END

	

create procedure InsertGV
	@nguoitao varchar(30),
	@ho nvarchar(10),
	@tendem nvarchar(20),
	@ten nvarchar(10),
	@gioitinh tinyint,
	@ngaysinh date,
	@dienthoai varchar(30),
	@email varchar(150),
	@diachi nvarchar(150)
	AS
	BEGIN
		Insert into GiaoVien
		(
			nguoitao,
			ho, tendem, ten,
			gioitinh, ngaysinh,
			dienthoai, email, diachi
		)values(
			@nguoitao,
			@ho, @tendem, @ten,
			@gioitinh, @ngaysinh,
			@dienthoai, @email, @diachi
		);
		if @@ROWCOUNT > 0 begin return 1 end
		else begin return 0 end;
	END

create procedure updateGV
	@nguoicapnhat varchar(30),
	@magiaovien int,
	@ho nvarchar(10),
	@tendem nvarchar(20),
	@ten nvarchar(10),
	@gioitinh tinyint,
	@ngaysinh date,
	@dienthoai varchar(30),
	@email varchar(150),
	@diachi nvarchar(150)
	AS
	BEGIN
		UPDATE GiaoVien
		SET
			nguoicapnhat = @nguoicapnhat,
			ngaycapnhat = getdate(),
			ho = @ho, tendem = @tendem, ten = @ten,
			gioitinh = @gioitinh, ngaysinh = @ngaysinh,
			dienthoai = @dienthoai, email = @email, diachi = @diachi
		WHERE magiaovien = @magiaovien
	END

create procedure selectGV
	@magiaovien int
	AS
	BEGIN
		SELECT
		ho,
		tendem,
		ten,
		gioitinh,
		convert(varchar(10), ngaysinh, 103) as ngaysinh,
		dienthoai,
		email, diachi
		from GiaoVien
		where magiaovien = @magiaovien;
	END

create procedure deleteGV
	@magiaovien int
	AS
	BEGIN
		delete from GiaoVien
		where magiaovien = @magiaovien;
	END
 create procedure deleteSV
	@masinhvien varchar(50)
	AS
	BEGIN
		delete from SinhVien
		where masinhvien = @masinhvien;
	END

create procedure selectAllMonhoc
	@tukhoa nvarchar(30)
	AS
	BEGIN
		select
			mamonhoc,
			tenmonhoc,
			sotinchi
		from Monhoc
		where mamonhoc like '%' +lower(trim(@tukhoa))+'%'
		or lower(tenmonhoc) like '%' +lower(trim(@tukhoa))+'%'
		order by tenmonhoc;
	END
	selectAllMonhoc 111
create procedure SelectMonhoc
	@mamonhoc int
	AS
	BEGIN
	SELECT
		tenmonhoc,
		sotinchi
	from Monhoc
	where mamonhoc = @mamonhoc;
	END

create procedure insertMonhoc
	@nguoitao varchar(30),
	@tenmonhoc nvarchar(150),
	@sotinchi int
	AS
	BEGIN
		insert into Monhoc
		(
		nguoitao,
		tenmonhoc,
		sotinchi
		) values(
		@nguoitao,
		@tenmonhoc,
		@sotinchi
		);
		if @@ROWCOUNT > 0 begin return 1 end
		else begin return 0 end;
	END
create procedure updateMonhoc
	@nguoicapnhat varchar(30),
	@mamonhoc int,
	@tenmonhoc nvarchar(150),
	@sotinchi int
	AS
	BEGIN
		UPDATE Monhoc
		SET
			nguoicapnhat = @nguoicapnhat,
			ngaycapnhat = getdate(),
			tenmonhoc = @tenmonhoc,
			sotinchi = @sotinchi
		where mamonhoc = @mamonhoc;
		if @@ROWCOUNT > 0 begin return 1 end
		else begin return 0 end;
	END

 create procedure deleteMonhoc
	@mamonhoc int
	AS
	BEGIN
		delete from Monhoc
		where mamonhoc = @mamonhoc;
	END

	allLopHoc ''
create procedure allLopHoc
	@tukhoa nvarchar(50)
	as
	begin
		select 
			l.malophoc,
			case when len(trim(g.tendem)) > 0 then concat(g.ho, ' ', g.tendem,' ',g.ten)
			else concat (g.ho,' ',g.ten) end as giaovien,
			m.tenmonhoc
		from LopHoc l 
		inner join GiaoVien g on l.magiaovien = g.magiaovien
		inner join Monhoc m on l.mamonhoc = m.mamonhoc
		where lower(m.tenmonhoc) like '%' + lower(@tukhoa) +'%'
		or lower(g.ten) like '%' + lower(@tukhoa) +'%'
		or lower(g.tendem) like '%' + lower(@tukhoa) +'%'
		or lower(g.ten) like '%' + lower(@tukhoa) +'%'
		or lower(concat(g.ho, ' ',g.tendem,' ', g.ten)) like '%' + lower(@tukhoa) +'%';
	end

create procedure insertLopHoc
	@nguoitao varchar(30),
	@mamonhoc int,
	@magiaovien int
	as
	begin
		insert into LopHoc(nguoitao, mamonhoc, magiaovien)
		values (@nguoitao, @mamonhoc, @magiaovien);
		if @@ROWCOUNT > 0 begin return 1 end
		else begin return 0 end;
	end

create procedure updateLopHoc
	@nguoicapnhat varchar(30),
	@malophoc bigint,
	@mamonhoc int,
	@magiaovien int
	as 
	begin
		update LopHoc
		set nguoicapnhat = @nguoicapnhat,
		ngaycapnhat = getdate(),
		magiaovien = @magiaovien,
		mamonhoc = @mamonhoc
		where malophoc = @malophoc;
		if @@ROWCOUNT > 0 begin return 1 end
		else begin return 0 end;
	end

create procedure selectLopHoc
	@malophoc bigint
	as
	begin
		select magiaovien, mamonhoc from LopHoc where malophoc = @malophoc;
	end

 create procedure deleteLopHoc
	@malophoc int
	AS
	BEGIN
		delete from LopHoc
		where malophoc = @malophoc;
	END

alter table SinhVien add matkhau varchar(150) default '123'

alter table GiaoVien add matkhau varchar(150) default '123'
exec dangnhap 'admin', 'admin', 'admin'

create procedure dangnhap
	@loaitaikhoan varchar(10),
	@taikhoan varchar(50),
	@matkhau varchar(50)
	as
	begin

	if @loaitaikhoan = 'admin' 
	select * from TaiKhoan where tentaikhoan = @taikhoan 
									and matkhau = @matkhau;
		else if @loaitaikhoan = 'giaovien'
		select * from GiaoVien where CONVERT(varchar(50), magiaovien) = @taikhoan
										and matkhau = @matkhau;
		else
			select * from SinhVien where masinhvien = @taikhoan
										and matkhau = @matkhau;
end

select * from Diem
update LopHoc set daketthuc = 0

create procedure dkyhoc
	@masinhvien nvarchar(50),
	@malophoc int
	as
		declare @v_lanhoc int, -- khai bao bien de tinh lan hoc
				@v_mamonhoc int; --bien de luu ma mon hoc
	begin
		--nay ma mon hoc thong qua ma lop(khoa ngoai) cua bang Diem
		select @v_mamonhoc = mamonhoc
		from LopHoc
		where malophoc = @malophoc;--truyen tham so vao malophoc de lay dc mamonhoc

		select @v_lanhoc = COUNT(*)
		from Diem d
		inner join LopHoc l on d.malophoc = l.malophoc
		where d.masinhvien = @masinhvien
		and l.mamonhoc = @v_mamonhoc

		set @v_lanhoc = @v_lanhoc +1;
		--viec dk do sv => nguoitao la msv
		insert into Diem(nguoitao, masinhvien, malophoc, lanhoc)
		values(@masinhvien, @masinhvien, @malophoc, @v_lanhoc);

		if @@ROWCOUNT > 0 begin return 1 end
		else begin return 0 end;
	end
	select * from LopHoc
	exec dkyhoc '6151071001',2;
	exec dkyhoc '6151071011',2;
create procedure monDaDky
	@masinhvien varchar(50)
	as 
	begin
		select
			l.malophoc,
			m.tenmonhoc,
			case when(len(g.tendem)>0) then concat(g.ho,' ',g.tendem,' ',g.ten)
			else concat(g.ho,' ',g.ten) end as giaovien,
			m.sotinchi,
			d.diemlan1,
			d.diemlan2
		from Diem d
		inner join LopHoc l on d.malophoc = l.malophoc
		inner join Monhoc m on l.mamonhoc = m.mamonhoc
		inner join GiaoVien g on l.magiaovien = g.magiaovien
		where l.daketthuc = 0 -- mon da dang ky <-> lop dang/chua mo => trang trai ket thuc =0, neu = 1 => da hoc xong
		and d.masinhvien = @masinhvien;
end
 create procedure deletemonDaDky
	@malophoc int,
	@masinhvien nvarchar(50)
	AS
	BEGIN
		delete from Diem
		where malophoc = @malophoc;
	END
	select * from Diem

create procedure dsLopChuaDKy
	@masinhvien varchar(50)
	as
	begin
		select
			l.malophoc,
			l.mamonhoc,
			m.tenmonhoc,
			m.sotinchi,
			case when len(g.tendem)>0 then concat(g.ho,' ',g.tendem, ' ',g.ten)
			else concat(g.ho,' ',g.ten) end as giaovien
		from LopHoc l
		inner join GiaoVien g on l.magiaovien = g.magiaovien
		inner join Monhoc m on l.mamonhoc = m.mamonhoc
		where l.daketthuc = 0 --lay cac lop dang mo
		and l.malophoc not in(select malophoc from Diem where masinhvien = @masinhvien);

	end

	dsLopChuaDKy '6151071010'
	select * from LopHoc where daketthuc = 1;
update LopHoc set daketthuc = 1 where malophoc = 1;
	select * from Diem where malophoc = 1;
update Diem set diemlan1 = 10 where masinhvien = '6151071010';
update Diem set diemlan1 = 8 where masinhvien = '6151071001';

create procedure tracuudiem
	@masinhvien varchar(50),
	@tukhoa nvarchar(50)
	as
	begin
	set @tukhoa = LOWER(@tukhoa);
		select 
			m.mamonhoc,
			m.tenmonhoc,
			d.lanhoc,
			case when len(g.magiaovien) > 0 then concat (g.ho,' ',g.tendem,' ',g.ten)
			else concat(g.ho,' ',g.ten) end as giaovien,
			d.diemlan1,
			d.diemlan2
		from Diem d
		inner join LopHoc l on d.malophoc = l.malophoc
		inner join Monhoc m on l.mamonhoc = m.mamonhoc
		inner join GiaoVien g on l.magiaovien = g.magiaovien
		where l.daketthuc = 1
		and d.masinhvien = @masinhvien
		and lower(m.tenmonhoc) like '%'+@tukhoa+'%';
	end

		select
			l.malophoc,
			l.mamonhoc,
			m.tenmonhoc,
			m.sotinchi
		from LopHoc l
			inner join Monhoc m on l.mamonhoc = m.mamonhoc
			where daketthuc = 0
			and magiaovien = 1001
		-- lay si so lop hoc
		select * from (
			select
				l.malophoc,
				l.mamonhoc,
				m.tenmonhoc,
				m.sotinchi
			from LopHoc l
				inner join Monhoc m on l.mamonhoc = m.mamonhoc
				where daketthuc = 0
				and magiaovien = 1001
		) as tb inner join Diem d on d.malophoc = tb.malophoc

create procedure tracuulop
	@magiaovien int,
	@tukhoa nvarchar(50)
	as
	begin
		set @tukhoa = lower(@tukhoa);
		select 
			tb.malophoc,
			tb.mamonhoc,
			tb.tenmonhoc,
			tb.sotinchi,
			count(d.masinhvien) as siso
		from(
			select
				l.malophoc,
				l.mamonhoc,
				m.tenmonhoc,
				m.sotinchi
			from LopHoc l
			inner join Monhoc m on l.mamonhoc = m.mamonhoc
			where daketthuc = 0
			and magiaovien = @magiaovien
			and lower(m.tenmonhoc) like '%'+@tukhoa+'%'
		) as tb inner join Diem d on d.malophoc = tb.malophoc
		group by tb.malophoc,tb.mamonhoc,tb.tenmonhoc,tb.sotinchi;
end

exec tracuulop '1001', ''

select * from Diem
update Diem set diemlan1 = 0, diemlan2 = 0;

create proc dssv
	@malophoc int,
	@tukhoa nvarchar(50)
as
begin
	set @tukhoa = lower(@tukhoa);
	select 
		d.masinhvien,
		case when len(s.tendem)>0 
			then concat(s.ho,' ',s.tendem,' ',s.ten)
			else concat(s.ho,' ',s.ten)
		end as hoten,
		d.lanhoc,
		d.diemlan1,
		d.diemlan2
	from Diem d
	inner join SinhVien s on d.masinhvien = s.masinhvien
	where d.malophoc = @malophoc
	and (
			lower(concat(s.ho,' ',s.tendem,' ',s.ten)) like '%'+@tukhoa+'%'
			or lower(concat(s.ho,' ',s.ten)) like '%'+@tukhoa+'%'
		);
end


create procedure doimatkhau
	@tentaikhoan nvarchar(50),
	@matkhaucu nvarchar(150),
	@matkhaumoi nvarchar(150)
	as
	begin
		set nocount on;

		if EXISTS (select * from TaiKhoan where tentaikhoan = @tentaikhoan and matkhau = @matkhaucu)
		begin
			update TaiKhoan
			set matkhau = @matkhaumoi
			where tentaikhoan = @tentaikhoan;

			select N'Đổi mật khẩu thành công' as ThongBao;
		end
		else 
		begin
			select N'Tài khoản hoặc mật khẩu cũ không đúng' as ThongBao;
		end
		--sinhvien
		if EXISTS (select * from SinhVien where masinhvien = @tentaikhoan and matkhau = @matkhaucu)
		begin
			update SinhVien
			set matkhau = @matkhaumoi
			where masinhvien = @tentaikhoan;

			select N'Đổi mật khẩu thành công' as ThongBao;
		end
		else 
		begin
			select N'Tài khoản hoặc mật khẩu cũ không đúng' as ThongBao;
		end
		--giaovien
		if EXISTS (select * from GiaoVien where magiaovien = @tentaikhoan and matkhau = @matkhaucu)
		begin
			update GiaoVien
			set matkhau = @matkhaumoi
			where magiaovien = @tentaikhoan;

			select N'Đổi mật khẩu thành công' as ThongBao;
		end
		else 
		begin
			select N'Tài khoản hoặc mật khẩu cũ không đúng' as ThongBao;
		end
	end

	exec doimatkhau '6151071001', 'truong', '123';

CREATE PROCEDURE ChamDiem
    @magiaovien int,
    @malophoc int,
    @masinhvien varchar(50),
    @diemlan1 float
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra điều kiện để cho phép nhập điểm lần 2
    IF @diemlan1 < 4
    BEGIN
        -- Cập nhật điểm lần 1 và điểm lần 2
        UPDATE Diem
        SET 
			diemlan1 = @diemlan1,
            diemlan2 = NULL
        WHERE malophoc = @malophoc
            AND masinhvien = @masinhvien;
    END
    ELSE
    BEGIN
        -- Cập nhật chỉ điểm lần 1
        UPDATE Diem
        SET 
			diemlan1 = @diemlan1
        WHERE malophoc = @malophoc
            AND masinhvien = @masinhvien;
    END;

    -- In ra thông báo về điểm đã được cập nhật
    SELECT malophoc, masinhvien, diemlan1, diemlan2
    FROM Diem
    WHERE malophoc = @malophoc
        AND masinhvien = @masinhvien;

END;