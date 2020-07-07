use master
go

drop database pmsx
go

--------------------------------------------------

create database pmsx
go

use pmsx
go
--------------------------------------------------

create table pmsx_role(
	role_id uniqueidentifier not null primary key default newid(),
	role_name nvarchar(100) not null,
	role_comment nvarchar(500),

	role_state int not null default 1, -- 1: available, 0: disabled
	role_createDatetime datetime not null default getdate(),
	role_updateDatetime datetime,
)
go

create table pmsx_staff(
	staff_id uniqueidentifier not null primary key default newid(),
	staff_username nvarchar(100),
	staff_password nvarchar(100),

	staff_name nvarchar(100),

	staff_state int not null default 1, -- 1: available, 0: disabled
	staff_createDatetime datetime not null default getdate(),
	staff_updateDatetime datetime,
)
go

create table pmsx_staffRole(
	staffRole_id uniqueidentifier not null primary key default newid(),
	staffRole_staffId uniqueidentifier not null references pmsx_staff(staff_id),
	staffRole_roleId uniqueidentifier not null references pmsx_role(role_id),

	staffRole_createDatetime datetime not null default getdate(),
)
go

create table pmsx_session(
	session_id uniqueidentifier not null primary key default newid(),
	session_name nvarchar(100) not null,
	session_technicianId uniqueidentifier not null references pmsx_staff(staff_id),
	session_doctorId uniqueidentifier not null references pmsx_staff(staff_id),
	session_comment nvarchar(500),

	session_state int not null default 1, -- 1: available, 0: disabled
	session_createDatetime datetime not null default getdate(),
	session_updateDatetime datetime,
)
go

create table pmsx_patient(
	patient_id uniqueidentifier not null primary key default newid(),
	patient_name nvarchar(100) not null,
	patient_year int not null,
	patient_address nvarchar(500) not null,
	patient_comment nvarchar(500),

	patient_state int not null default 1, -- 1: available, 0: disabled
	patient_createDatetime datetime not null default getdate(),
	patient_updateDatetime datetime,
)
go

create table pmsx_biopsyGroup(
	biopsyGroup_id uniqueidentifier not null primary key default newid(),
	biopsyGroup_name nvarchar(100) not null,
	biopsyGroup_comment nvarchar(500),

	biopsyGroup_state int not null default 1, -- 1: available, 0: disabled
	biopsyGroup_createDatetime datetime not null default getdate(),
	biopsyGroup_updateDatetime datetime,
)
go

create table pmsx_biopsy(
	biopsy_id uniqueidentifier not null primary key default newid(),
	biopsy_code int not null,
	biopsy_groupId uniqueidentifier not null references pmsx_biopsyGroup(biopsyGroup_id),
	biopsy_patientId uniqueidentifier not null references pmsx_patient(patient_id),
	biopsy_sessionId uniqueidentifier not null references pmsx_session(session_id),

	biopsy_grossStaffId uniqueidentifier not null references pmsx_staff(staff_id),
	biopsy_numberSegment int not null default 1,	
	biopsy_grossDatetime datetime not null default getdate(),
	biopsy_collectDatetime datetime not null default getdate(),	

	biopsy_state int not null default 1, -- 1: available, 0: disabled
	biopsy_createDatetime datetime not null default getdate(),
	biopsy_updateDatetime datetime,
)
go

--------------------------------------------------
insert into pmsx_role(role_id, role_name, role_comment) values('E226DC82-6028-413E-B0B0-EEA3E62219D2', N'Technician', N'Kỹ thuật viên');
insert into pmsx_role(role_id, role_name, role_comment) values('16A63F6F-54D9-4EBD-A946-04CB061FD503', N'Doctor', N'Bác sĩ');
insert into pmsx_role(role_id, role_name, role_comment) values('A4619A90-D95F-4919-8DC2-A5AD3ABB5E12', N'Manager', N'Quản lý');
insert into pmsx_role(role_id, role_name, role_comment) values('7871A37A-F721-44E2-8F03-611FF5888808', N'Admin', N'Quản trị viên');
go

insert into pmsx_staff(staff_id, staff_username, staff_password, staff_name) values('73F2B296-EBDC-4434-892C-983E46F7CCF3', N'daomtthuan', N'$2y$10$1iWsYQzkNTnZY8AVtSEJl.2lbYpyCaqTWRYXD.nL3Rz1kaEy57.Uq', N'Đào Minh Trung Thuận');
insert into pmsx_staff(staff_id, staff_username, staff_password, staff_name) values('6DDAA669-7F0E-46CC-8271-88633C859FFC', N'duy', N'$2y$10$1iWsYQzkNTnZY8AVtSEJl.2lbYpyCaqTWRYXD.nL3Rz1kaEy57.Uq', N'Nguyễn Phúc Duy');
insert into pmsx_staff(staff_id, staff_username, staff_password, staff_name) values('4EBCCA02-3D67-48DC-983E-AD3406A33A40', N'staff', N'$2y$10$1iWsYQzkNTnZY8AVtSEJl.2lbYpyCaqTWRYXD.nL3Rz1kaEy57.Uq', N'Nhân viên');
insert into pmsx_staff(staff_id, staff_username, staff_password, staff_name) values('E226DC82-6028-413E-B0B0-EEA3E62219D2', N'tech', N'$2y$10$1iWsYQzkNTnZY8AVtSEJl.2lbYpyCaqTWRYXD.nL3Rz1kaEy57.Uq', N'Kỹ thuật viên');
insert into pmsx_staff(staff_id, staff_username, staff_password, staff_name) values('999A21D1-B792-4033-BCA9-6838F8A7311A', N'doctor', N'$2y$10$1iWsYQzkNTnZY8AVtSEJl.2lbYpyCaqTWRYXD.nL3Rz1kaEy57.Uq', N'Bác sĩ');
insert into pmsx_staff(staff_id, staff_username, staff_password, staff_name) values('696072FE-AAC8-432C-ACFB-EDB65B4C2C5A', N'manager', N'$2y$10$1iWsYQzkNTnZY8AVtSEJl.2lbYpyCaqTWRYXD.nL3Rz1kaEy57.Uq', N'Quản lý');
insert into pmsx_staff(staff_id, staff_username, staff_password, staff_name) values('AEF97B23-9C18-4F6F-922E-9768BA930068', N'admin', N'$2y$10$1iWsYQzkNTnZY8AVtSEJl.2lbYpyCaqTWRYXD.nL3Rz1kaEy57.Uq', N'Quản trị viên');
go

insert into pmsx_staffRole(staffRole_staffId, staffRole_roleId) values('73F2B296-EBDC-4434-892C-983E46F7CCF3', 'E226DC82-6028-413E-B0B0-EEA3E62219D2');
insert into pmsx_staffRole(staffRole_staffId, staffRole_roleId) values('73F2B296-EBDC-4434-892C-983E46F7CCF3', '16A63F6F-54D9-4EBD-A946-04CB061FD503');
insert into pmsx_staffRole(staffRole_staffId, staffRole_roleId) values('73F2B296-EBDC-4434-892C-983E46F7CCF3', 'A4619A90-D95F-4919-8DC2-A5AD3ABB5E12');
insert into pmsx_staffRole(staffRole_staffId, staffRole_roleId) values('73F2B296-EBDC-4434-892C-983E46F7CCF3', '7871A37A-F721-44E2-8F03-611FF5888808');

insert into pmsx_staffRole(staffRole_staffId, staffRole_roleId) values('6DDAA669-7F0E-46CC-8271-88633C859FFC', 'E226DC82-6028-413E-B0B0-EEA3E62219D2');
insert into pmsx_staffRole(staffRole_staffId, staffRole_roleId) values('6DDAA669-7F0E-46CC-8271-88633C859FFC', '16A63F6F-54D9-4EBD-A946-04CB061FD503');
insert into pmsx_staffRole(staffRole_staffId, staffRole_roleId) values('6DDAA669-7F0E-46CC-8271-88633C859FFC', 'A4619A90-D95F-4919-8DC2-A5AD3ABB5E12');
insert into pmsx_staffRole(staffRole_staffId, staffRole_roleId) values('6DDAA669-7F0E-46CC-8271-88633C859FFC', '7871A37A-F721-44E2-8F03-611FF5888808');

insert into pmsx_staffRole(staffRole_staffId, staffRole_roleId) values('E226DC82-6028-413E-B0B0-EEA3E62219D2', 'E226DC82-6028-413E-B0B0-EEA3E62219D2');
insert into pmsx_staffRole(staffRole_staffId, staffRole_roleId) values('999A21D1-B792-4033-BCA9-6838F8A7311A', '16A63F6F-54D9-4EBD-A946-04CB061FD503');
insert into pmsx_staffRole(staffRole_staffId, staffRole_roleId) values('696072FE-AAC8-432C-ACFB-EDB65B4C2C5A', 'A4619A90-D95F-4919-8DC2-A5AD3ABB5E12');
insert into pmsx_staffRole(staffRole_staffId, staffRole_roleId) values('AEF97B23-9C18-4F6F-922E-9768BA930068', '7871A37A-F721-44E2-8F03-611FF5888808');
go

insert into pmsx_session(session_id, session_name, session_technicianId, session_doctorId) values('629D7368-8431-421B-8720-9BC0B89A4E60', N'Phiên làm việc 1', '73F2B296-EBDC-4434-892C-983E46F7CCF3', '6DDAA669-7F0E-46CC-8271-88633C859FFC');
insert into pmsx_session(session_id, session_name, session_technicianId, session_doctorId) values('2E851378-1E4D-41E0-B736-A5DD6EF72147', N'Phiên làm việc 2', 'E226DC82-6028-413E-B0B0-EEA3E62219D2', '999A21D1-B792-4033-BCA9-6838F8A7311A');
insert into pmsx_session(session_id, session_name, session_technicianId, session_doctorId) values('8CF9811C-8D66-4DC1-A42F-85B2A44089E5', N'Phiên làm việc 3', 'E226DC82-6028-413E-B0B0-EEA3E62219D2', '6DDAA669-7F0E-46CC-8271-88633C859FFC');
go

insert into pmsx_patient(patient_id, patient_name, patient_year, patient_address) values('07F5E2E4-CA32-46A9-BED7-C25B7E9E74CB', N'Nguyễn Văn An', 1970, N'Ninh Kiều, Cần Thơ');
insert into pmsx_patient(patient_id, patient_name, patient_year, patient_address) values('E4F4845B-B47D-478C-B0CC-D10856057E2B', N'Trần Thanh Bình', 1966, N'Quận 1, TP. HCM');
insert into pmsx_patient(patient_id, patient_name, patient_year, patient_address) values('A04E2A34-4D6C-4246-BCF4-47B8482BAAF7', N'Đỗ Lâm Cường', 1983, N'Cái Răng, Cần Thơ');
insert into pmsx_patient(patient_id, patient_name, patient_year, patient_address) values('87F61977-AC33-4074-80FD-8ACEED052D64', N'Hà Thị Kim Dung', 1990, N'Bình Minh, Vĩnh Long');
insert into pmsx_patient(patient_id, patient_name, patient_year, patient_address) values('1A1D1307-A471-4752-B492-3E2DF431B0BA', N'Hồng Thị Bé Em', 1992, N'Ninh Kiều, Cần Thơ');
insert into pmsx_patient(patient_id, patient_name, patient_year, patient_address) values('54C1D24B-4D38-4B99-B973-5B0D2204800A', N'Nguyễn Trường Giang', 1988, N'Vị Thanh, Hậu Giang');
go

insert into pmsx_biopsyGroup(biopsyGroup_id, biopsyGroup_name) values ('574A295E-CFA9-4CDE-B75F-B4AA650206E4', N'YCT-20');
insert into pmsx_biopsyGroup(biopsyGroup_id, biopsyGroup_name) values ('8C1782CA-A3BA-45C8-B2E0-40585C064B83', N'YCT-19');
insert into pmsx_biopsyGroup(biopsyGroup_id, biopsyGroup_name) values ('2183CCCB-0A65-407C-AE93-CE9CF37B5499', N'YCT-18');
go

insert into pmsx_biopsy(biopsy_id, biopsy_code, biopsy_groupId, biopsy_patientId, biopsy_numberSegment, biopsy_grossStaffId, biopsy_sessionId) values ('15166E2D-951E-4B56-8581-05559E5D9108', 1, '574A295E-CFA9-4CDE-B75F-B4AA650206E4', '07F5E2E4-CA32-46A9-BED7-C25B7E9E74CB', 2, '6DDAA669-7F0E-46CC-8271-88633C859FFC', '629D7368-8431-421B-8720-9BC0B89A4E60')
insert into pmsx_biopsy(biopsy_id, biopsy_code, biopsy_groupId, biopsy_patientId, biopsy_numberSegment, biopsy_grossStaffId, biopsy_sessionId) values ('043A8BAA-60BB-4BDA-B868-291F3EB9BF41', 2, '574A295E-CFA9-4CDE-B75F-B4AA650206E4', 'E4F4845B-B47D-478C-B0CC-D10856057E2B', 1, '6DDAA669-7F0E-46CC-8271-88633C859FFC', '629D7368-8431-421B-8720-9BC0B89A4E60')
insert into pmsx_biopsy(biopsy_id, biopsy_code, biopsy_groupId, biopsy_patientId, biopsy_numberSegment, biopsy_grossStaffId, biopsy_sessionId) values ('87DBB483-F2CA-4623-98D8-059536BED0E4', 3, '574A295E-CFA9-4CDE-B75F-B4AA650206E4', 'A04E2A34-4D6C-4246-BCF4-47B8482BAAF7', 1, '6DDAA669-7F0E-46CC-8271-88633C859FFC', '629D7368-8431-421B-8720-9BC0B89A4E60')
insert into pmsx_biopsy(biopsy_id, biopsy_code, biopsy_groupId, biopsy_patientId, biopsy_numberSegment, biopsy_grossStaffId, biopsy_sessionId) values ('3299556F-0C25-45A8-8F81-AF031562F573', 4, '574A295E-CFA9-4CDE-B75F-B4AA650206E4', '87F61977-AC33-4074-80FD-8ACEED052D64', 3, '6DDAA669-7F0E-46CC-8271-88633C859FFC', '629D7368-8431-421B-8720-9BC0B89A4E60')
insert into pmsx_biopsy(biopsy_id, biopsy_code, biopsy_groupId, biopsy_patientId, biopsy_numberSegment, biopsy_grossStaffId, biopsy_sessionId) values ('7B5E1389-A135-4DA8-83AF-3EBA7FAC1550', 5, '574A295E-CFA9-4CDE-B75F-B4AA650206E4', '1A1D1307-A471-4752-B492-3E2DF431B0BA', 1, '6DDAA669-7F0E-46CC-8271-88633C859FFC', '8CF9811C-8D66-4DC1-A42F-85B2A44089E5')
insert into pmsx_biopsy(biopsy_id, biopsy_code, biopsy_groupId, biopsy_patientId, biopsy_numberSegment, biopsy_grossStaffId, biopsy_sessionId) values ('A8FD39C7-37E8-46C8-A873-6C4427C130B3', 6, '574A295E-CFA9-4CDE-B75F-B4AA650206E4', '54C1D24B-4D38-4B99-B973-5B0D2204800A', 2, '6DDAA669-7F0E-46CC-8271-88633C859FFC', '8CF9811C-8D66-4DC1-A42F-85B2A44089E5')
go
