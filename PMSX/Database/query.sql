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

create table pmsx_staff(
	staff_id uniqueidentifier not null primary key default newid(),
	staff_username nvarchar(100) not null unique,
	staff_password nvarchar(100) not null,

	staff_name nvarchar(100) not null,

	staff_comment nvarchar(500),
	staff_state int not null default 1,

	staff_createStaffId uniqueidentifier not null references pmsx_staff(staff_id),
	staff_createDatetime datetime not null default getdate(),

	staff_updateStaffId uniqueidentifier references pmsx_staff(staff_id),
	staff_updateDatetime datetime
)
go

create table pmsx_role(
	role_id uniqueidentifier not null primary key default newid(),
	role_name nvarchar(100) not null unique,

	role_comment nvarchar(500),	
	role_state int not null default 1,

	role_createStaffId uniqueidentifier not null references pmsx_staff(staff_id),
	role_createDatetime datetime not null default getdate(),

	role_updateStaffId uniqueidentifier references pmsx_staff(staff_id),
	role_updateDatetime datetime
)
go

create table pmsx_permission(
	permission_id uniqueidentifier not null primary key default newid(),
	permission_staffId uniqueidentifier not null references pmsx_staff(staff_id),
	permission_roleId uniqueidentifier not null references pmsx_role(role_id),

	permission_comment nvarchar(500),
	permission_state int not null default 1,
	
	permission_createStaffId uniqueidentifier not null references pmsx_staff(staff_id),
	permission_createDatetime datetime not null default getdate(),

	permission_updateStaffId uniqueidentifier references pmsx_staff(staff_id),
	permission_updateDatetime datetime,

	unique (permission_staffId, permission_roleId)
)
go

create table pmsx_session(
	session_id uniqueidentifier not null primary key default newid(),
	session_name date not null unique,
	session_technicianId uniqueidentifier not null references pmsx_staff(staff_id),
	session_doctorId uniqueidentifier not null references pmsx_staff(staff_id),

	session_comment nvarchar(500),
	session_state int not null default 1,

	session_createStaffId uniqueidentifier not null references pmsx_staff(staff_id),
	session_createDatetime datetime not null default getdate(),

	session_updateStaffId uniqueidentifier references pmsx_staff(staff_id),
	session_updateDatetime datetime
)
go

create table pmsx_patient(
	patient_id uniqueidentifier not null primary key default newid(),
	patient_name nvarchar(100) not null,
	patient_yearBirth int not null,
	patient_address nvarchar(500) not null,

	patient_comment nvarchar(500),
	patient_state int not null default 1,

	patient_createStaffId uniqueidentifier not null references pmsx_staff(staff_id),
	patient_createDatetime datetime not null default getdate(),

	patient_updateStaffId uniqueidentifier references pmsx_staff(staff_id),
	patient_updateDatetime datetime
)
go

create table pmsx_biopsyGroup(
	biopsyGroup_id uniqueidentifier not null primary key default newid(),
	biopsyGroup_code nvarchar(100) not null unique,
	biopsyGroup_numberBiopsy bigint not null default 0,

	biopsyGroup_comment nvarchar(500),
	biopsyGroup_state int not null default 1,

	biopsyGroup_createStaffId uniqueidentifier not null references pmsx_staff(staff_id),
	biopsyGroup_createDatetime datetime not null default getdate(),

	biopsyGroup_updateStaffId uniqueidentifier references pmsx_staff(staff_id),
	biopsyGroup_updateDatetime datetime
)
go

create table pmsx_biopsy(
	biopsy_id uniqueidentifier not null primary key default newid(),
	biopsy_code bigint not null,
	biopsy_groupId uniqueidentifier not null references pmsx_biopsyGroup(biopsyGroup_id),
	biopsy_patientId uniqueidentifier not null references pmsx_patient(patient_id),
	biopsy_sessionId uniqueidentifier references pmsx_session(session_id),
	biopsy_grossDoctorId uniqueidentifier not null references pmsx_staff(staff_id),
	biopsy_segment int not null default 1,	
	biopsy_grossDatetime date not null,
	biopsy_collectDatetime date not null,		

	biopsy_comment nvarchar(500),
	biopsy_state int not null default 1,

	biopsy_createStaffId uniqueidentifier not null references pmsx_staff(staff_id),
	biopsy_createDatetime datetime not null default getdate(),

	biopsy_updateStaffId uniqueidentifier references pmsx_staff(staff_id),
	biopsy_updateDatetime datetime,

	unique (biopsy_code, biopsy_groupId)
)
go

create table pmsx_macroGroup(
	macroGroup_id uniqueidentifier not null primary key default newid(),
	macroGroup_code nvarchar(100) not null unique,
	macroGroup_name nvarchar(100) not null,

	macroGroup_comment nvarchar(500),
	macroGroup_state int not null default 1,

	macroGroup_createStaffId uniqueidentifier not null references pmsx_staff(staff_id),
	macroGroup_createDatetime datetime not null default getdate(),

	macroGroup_updateStaffId uniqueidentifier references pmsx_staff(staff_id),
	macroGroup_updateDatetime datetime
)
go

create table pmsx_macro(
	macro_id uniqueidentifier not null primary key default newid(),
	macro_code nvarchar(100) not null,
	macro_description nvarchar(500) not null,
	macro_groupId uniqueidentifier not null references pmsx_macroGroup(macroGroup_id),

	macro_comment nvarchar(500),
	macro_state int not null default 1,

	macro_createStaffId uniqueidentifier not null references pmsx_staff(staff_id),
	macro_createDatetime datetime not null default getdate(),

	macro_updateStaffId uniqueidentifier references pmsx_staff(staff_id),
	macro_updateDatetime datetime,

	unique (macro_code, macro_groupId)
)
go

create table pmsx_microGroup(
	microGroup_id uniqueidentifier not null primary key default newid(),
	microGroup_code nvarchar(100) not null unique,
	microGroup_name nvarchar(100) not null,

	microGroup_comment nvarchar(500),
	microGroup_state int not null default 1,

	microGroup_createStaffId uniqueidentifier not null references pmsx_staff(staff_id),
	microGroup_createDatetime datetime not null default getdate(),

	microGroup_updateStaffId uniqueidentifier references pmsx_staff(staff_id),
	microGroup_updateDatetime datetime
)
go

create table pmsx_micro(
	micro_id uniqueidentifier not null primary key default newid(),
	micro_code nvarchar(100) not null,
	micro_description nvarchar(500) not null,
	micro_conclusion nvarchar(500) not null,
	micro_groupId uniqueidentifier not null references pmsx_microGroup(microGroup_id),

	micro_comment nvarchar(500),
	micro_state int not null default 1,

	micro_createStaffId uniqueidentifier not null references pmsx_staff(staff_id),
	micro_createDatetime datetime not null default getdate(),

	micro_updateStaffId uniqueidentifier references pmsx_staff(staff_id),
	micro_updateDatetime datetime,

	unique (micro_code, micro_groupId)
)
go

create table pmsx_diagnoseType1(
	diagnose_id uniqueidentifier not null primary key default newid(),
	diagnose_code nvarchar(100) not null unique,	
	diagnose_biopsyId uniqueidentifier not null references pmsx_biopsy(biopsy_id),
	diagnose_macroId uniqueidentifier references pmsx_macro(macro_id),
	diagnose_macroDescription nvarchar(500) not null,
	diagnose_microId uniqueidentifier references pmsx_micro(micro_id),
	diagnose_microDescription nvarchar(500) not null,
  diagnose_conclusion nvarchar(500) not null,
	diagnose_readDate date,

	diagnose_comment nvarchar(500),
	diagnose_state int not null default 1,

	diagnose_createStaffId uniqueidentifier not null references pmsx_staff(staff_id),
	diagnose_createDatetime datetime not null default getdate(),

	diagnose_updateStaffId uniqueidentifier references pmsx_staff(staff_id),
	diagnose_updateDatetime datetime
)
go

create table pmsx_image(
	image_id uniqueidentifier not null primary key default newid(),
	image_diagnoseType nvarchar(100) not null,	
	image_diagnoseId uniqueidentifier not null,
	image_path nvarchar(500) not null,	
	image_caption nvarchar(500),

	image_comment nvarchar(500),
	image_state int not null default 1,

	image_createStaffId uniqueidentifier not null references pmsx_staff(staff_id),
	image_createDatetime datetime not null default getdate(),

	image_updateStaffId uniqueidentifier references pmsx_staff(staff_id),
	image_updateDatetime datetime
)
go

--------------------------------------------------
insert into pmsx_staff(staff_id, staff_username, staff_password, staff_name, staff_createStaffId) values('73F2B296-EBDC-4434-892C-983E46F7CCF3', N'daomtthuan', N'$2y$10$1iWsYQzkNTnZY8AVtSEJl.2lbYpyCaqTWRYXD.nL3Rz1kaEy57.Uq', N'Đào Minh Trung Thuận', '73F2B296-EBDC-4434-892C-983E46F7CCF3')
insert into pmsx_staff(staff_id, staff_username, staff_password, staff_name, staff_createStaffId) values('6DDAA669-7F0E-46CC-8271-88633C859FFC', N'nguyenpduy', N'$2y$10$1iWsYQzkNTnZY8AVtSEJl.2lbYpyCaqTWRYXD.nL3Rz1kaEy57.Uq', N'Nguyễn Phúc Duy', '73F2B296-EBDC-4434-892C-983E46F7CCF3')
insert into pmsx_staff(staff_id, staff_username, staff_password, staff_name, staff_createStaffId) values('4EBCCA02-3D67-48DC-983E-AD3406A33A40', N'staff1', N'$2y$10$1iWsYQzkNTnZY8AVtSEJl.2lbYpyCaqTWRYXD.nL3Rz1kaEy57.Uq', N'Hà Vĩnh Chu', '73F2B296-EBDC-4434-892C-983E46F7CCF3')
insert into pmsx_staff(staff_id, staff_username, staff_password, staff_name, staff_createStaffId) values('696072FE-AAC8-432C-ACFB-EDB65B4C2C5A', N'staff2', N'$2y$10$1iWsYQzkNTnZY8AVtSEJl.2lbYpyCaqTWRYXD.nL3Rz1kaEy57.Uq', N'Dương Mịch', '73F2B296-EBDC-4434-892C-983E46F7CCF3')
insert into pmsx_staff(staff_id, staff_username, staff_password, staff_name, staff_createStaffId) values('E226DC82-6028-413E-B0B0-EEA3E62219D2', N'tech1', N'$2y$10$1iWsYQzkNTnZY8AVtSEJl.2lbYpyCaqTWRYXD.nL3Rz1kaEy57.Uq', N'Lưu Bá Ôn', '73F2B296-EBDC-4434-892C-983E46F7CCF3')
insert into pmsx_staff(staff_id, staff_username, staff_password, staff_name, staff_createStaffId) values('999A21D1-B792-4033-BCA9-6838F8A7311A', N'tech2', N'$2y$10$1iWsYQzkNTnZY8AVtSEJl.2lbYpyCaqTWRYXD.nL3Rz1kaEy57.Uq', N'Âu Dương Chấn Hoa', '73F2B296-EBDC-4434-892C-983E46F7CCF3')
insert into pmsx_staff(staff_id, staff_username, staff_password, staff_name, staff_createStaffId) values('9294B3B9-261E-49E3-92EF-BB5F05AA43D1', N'tech3', N'$2y$10$1iWsYQzkNTnZY8AVtSEJl.2lbYpyCaqTWRYXD.nL3Rz1kaEy57.Uq', N'Lâm Văn Long', '73F2B296-EBDC-4434-892C-983E46F7CCF3')
insert into pmsx_staff(staff_id, staff_username, staff_password, staff_name, staff_createStaffId) values('AEF97B23-9C18-4F6F-922E-9768BA930068', N'doctor1', N'$2y$10$1iWsYQzkNTnZY8AVtSEJl.2lbYpyCaqTWRYXD.nL3Rz1kaEy57.Uq', N'Lâm Văn Long', '73F2B296-EBDC-4434-892C-983E46F7CCF3')
insert into pmsx_staff(staff_id, staff_username, staff_password, staff_name, staff_createStaffId) values('D9B482FC-A146-476A-AA72-3A686F12E8D7', N'doctor2', N'$2y$10$1iWsYQzkNTnZY8AVtSEJl.2lbYpyCaqTWRYXD.nL3Rz1kaEy57.Uq', N'Lương Tiểu Nhu', '73F2B296-EBDC-4434-892C-983E46F7CCF3')
go

insert into pmsx_role(role_id, role_name, role_createStaffId) values('E226DC82-6028-413E-B0B0-EEA3E62219D2', N'Kỹ thuật viên', '73F2B296-EBDC-4434-892C-983E46F7CCF3')
insert into pmsx_role(role_id, role_name, role_createStaffId) values('16A63F6F-54D9-4EBD-A946-04CB061FD503', N'Bác sĩ', '73F2B296-EBDC-4434-892C-983E46F7CCF3')
insert into pmsx_role(role_id, role_name, role_createStaffId) values('7871A37A-F721-44E2-8F03-611FF5888808', N'Quản trị viên','73F2B296-EBDC-4434-892C-983E46F7CCF3')
go

insert into pmsx_permission(permission_staffId, permission_roleId, permission_createStaffId) values('73F2B296-EBDC-4434-892C-983E46F7CCF3', 'E226DC82-6028-413E-B0B0-EEA3E62219D2', '73F2B296-EBDC-4434-892C-983E46F7CCF3')
insert into pmsx_permission(permission_staffId, permission_roleId, permission_createStaffId) values('6DDAA669-7F0E-46CC-8271-88633C859FFC', 'E226DC82-6028-413E-B0B0-EEA3E62219D2', '73F2B296-EBDC-4434-892C-983E46F7CCF3')
insert into pmsx_permission(permission_staffId, permission_roleId, permission_createStaffId) values('E226DC82-6028-413E-B0B0-EEA3E62219D2', 'E226DC82-6028-413E-B0B0-EEA3E62219D2', '73F2B296-EBDC-4434-892C-983E46F7CCF3')
insert into pmsx_permission(permission_staffId, permission_roleId, permission_createStaffId) values('999A21D1-B792-4033-BCA9-6838F8A7311A', 'E226DC82-6028-413E-B0B0-EEA3E62219D2', '73F2B296-EBDC-4434-892C-983E46F7CCF3')
insert into pmsx_permission(permission_staffId, permission_roleId, permission_createStaffId) values('9294B3B9-261E-49E3-92EF-BB5F05AA43D1', 'E226DC82-6028-413E-B0B0-EEA3E62219D2', '73F2B296-EBDC-4434-892C-983E46F7CCF3')

insert into pmsx_permission(permission_staffId, permission_roleId, permission_createStaffId) values('73F2B296-EBDC-4434-892C-983E46F7CCF3', '16A63F6F-54D9-4EBD-A946-04CB061FD503', '73F2B296-EBDC-4434-892C-983E46F7CCF3')
insert into pmsx_permission(permission_staffId, permission_roleId, permission_createStaffId) values('6DDAA669-7F0E-46CC-8271-88633C859FFC', '16A63F6F-54D9-4EBD-A946-04CB061FD503', '73F2B296-EBDC-4434-892C-983E46F7CCF3')
insert into pmsx_permission(permission_staffId, permission_roleId, permission_createStaffId) values('AEF97B23-9C18-4F6F-922E-9768BA930068', '16A63F6F-54D9-4EBD-A946-04CB061FD503', '73F2B296-EBDC-4434-892C-983E46F7CCF3')
insert into pmsx_permission(permission_staffId, permission_roleId, permission_createStaffId) values('D9B482FC-A146-476A-AA72-3A686F12E8D7', '16A63F6F-54D9-4EBD-A946-04CB061FD503', '73F2B296-EBDC-4434-892C-983E46F7CCF3')

insert into pmsx_permission(permission_staffId, permission_roleId, permission_createStaffId) values('73F2B296-EBDC-4434-892C-983E46F7CCF3', '7871A37A-F721-44E2-8F03-611FF5888808', '73F2B296-EBDC-4434-892C-983E46F7CCF3')
insert into pmsx_permission(permission_staffId, permission_roleId, permission_createStaffId) values('6DDAA669-7F0E-46CC-8271-88633C859FFC', '7871A37A-F721-44E2-8F03-611FF5888808', '73F2B296-EBDC-4434-892C-983E46F7CCF3')
go

insert into pmsx_session(session_id, session_name, session_technicianId, session_doctorId, session_createStaffId) values('629D7368-8431-421B-8720-9BC0B89A4E60', '2020-7-11', '73F2B296-EBDC-4434-892C-983E46F7CCF3', '6DDAA669-7F0E-46CC-8271-88633C859FFC', '73F2B296-EBDC-4434-892C-983E46F7CCF3')
insert into pmsx_session(session_id, session_name, session_technicianId, session_doctorId, session_createStaffId) values('2E851378-1E4D-41E0-B736-A5DD6EF72147', '2020-7-10','E226DC82-6028-413E-B0B0-EEA3E62219D2', 'AEF97B23-9C18-4F6F-922E-9768BA930068', '73F2B296-EBDC-4434-892C-983E46F7CCF3')
insert into pmsx_session(session_id, session_name, session_technicianId, session_doctorId, session_createStaffId) values('8CF9811C-8D66-4DC1-A42F-85B2A44089E5', '2020-7-9','E226DC82-6028-413E-B0B0-EEA3E62219D2', '6DDAA669-7F0E-46CC-8271-88633C859FFC', '73F2B296-EBDC-4434-892C-983E46F7CCF3')
go

insert into pmsx_patient(patient_id, patient_name, patient_yearBirth, patient_address, patient_createStaffId) values('07F5E2E4-CA32-46A9-BED7-C25B7E9E74CB', N'Nguyễn Văn An', 1970, N'Ninh Kiều, Cần Thơ', '73F2B296-EBDC-4434-892C-983E46F7CCF3')
insert into pmsx_patient(patient_id, patient_name, patient_yearBirth, patient_address, patient_createStaffId) values('E4F4845B-B47D-478C-B0CC-D10856057E2B', N'Trần Thanh Bình', 1966, N'Quận 1, TP. HCM', '73F2B296-EBDC-4434-892C-983E46F7CCF3')
insert into pmsx_patient(patient_id, patient_name, patient_yearBirth, patient_address, patient_createStaffId) values('A04E2A34-4D6C-4246-BCF4-47B8482BAAF7', N'Đỗ Lâm Cường', 1983, N'Cái Răng, Cần Thơ', '73F2B296-EBDC-4434-892C-983E46F7CCF3')
insert into pmsx_patient(patient_id, patient_name, patient_yearBirth, patient_address, patient_createStaffId) values('87F61977-AC33-4074-80FD-8ACEED052D64', N'Hà Thị Kim Dung', 1990, N'Bình Minh, Vĩnh Long', '73F2B296-EBDC-4434-892C-983E46F7CCF3')
insert into pmsx_patient(patient_id, patient_name, patient_yearBirth, patient_address, patient_createStaffId) values('1A1D1307-A471-4752-B492-3E2DF431B0BA', N'Hồng Thị Bé Em', 1992, N'Ninh Kiều, Cần Thơ', '73F2B296-EBDC-4434-892C-983E46F7CCF3')
insert into pmsx_patient(patient_id, patient_name, patient_yearBirth, patient_address, patient_createStaffId) values('54C1D24B-4D38-4B99-B973-5B0D2204800A', N'Nguyễn Trường Giang', 1988, N'Vị Thanh, Hậu Giang', '73F2B296-EBDC-4434-892C-983E46F7CCF3')
go

insert into pmsx_biopsyGroup(biopsyGroup_id, biopsyGroup_code, biopsyGroup_createStaffId, biopsyGroup_numberBiopsy) values ('574A295E-CFA9-4CDE-B75F-B4AA650206E4', N'YCT20', '73F2B296-EBDC-4434-892C-983E46F7CCF3', 6)
insert into pmsx_biopsyGroup(biopsyGroup_id, biopsyGroup_code, biopsyGroup_createStaffId, biopsyGroup_numberBiopsy) values ('8C1782CA-A3BA-45C8-B2E0-40585C064B83', N'YCT19', '73F2B296-EBDC-4434-892C-983E46F7CCF3', 5)
insert into pmsx_biopsyGroup(biopsyGroup_id, biopsyGroup_code, biopsyGroup_createStaffId, biopsyGroup_numberBiopsy) values ('2183CCCB-0A65-407C-AE93-CE9CF37B5499', N'YCT18', '73F2B296-EBDC-4434-892C-983E46F7CCF3', 3)
go

insert into pmsx_biopsy(biopsy_id, biopsy_code, biopsy_groupId, biopsy_patientId, biopsy_segment, biopsy_grossDoctorId, biopsy_sessionId, biopsy_grossDatetime, biopsy_collectDatetime, biopsy_createStaffId) values ('15166E2D-951E-4B56-8581-05559E5D9108', 1, '574A295E-CFA9-4CDE-B75F-B4AA650206E4', '07F5E2E4-CA32-46A9-BED7-C25B7E9E74CB', 2, '6DDAA669-7F0E-46CC-8271-88633C859FFC', '629D7368-8431-421B-8720-9BC0B89A4E60', getdate(), getdate(), '73F2B296-EBDC-4434-892C-983E46F7CCF3')
insert into pmsx_biopsy(biopsy_id, biopsy_code, biopsy_groupId, biopsy_patientId, biopsy_segment, biopsy_grossDoctorId, biopsy_sessionId, biopsy_grossDatetime, biopsy_collectDatetime, biopsy_createStaffId) values ('043A8BAA-60BB-4BDA-B868-291F3EB9BF41', 2, '574A295E-CFA9-4CDE-B75F-B4AA650206E4', 'E4F4845B-B47D-478C-B0CC-D10856057E2B', 1, '6DDAA669-7F0E-46CC-8271-88633C859FFC', '629D7368-8431-421B-8720-9BC0B89A4E60', getdate(), getdate(), '73F2B296-EBDC-4434-892C-983E46F7CCF3')
insert into pmsx_biopsy(biopsy_id, biopsy_code, biopsy_groupId, biopsy_patientId, biopsy_segment, biopsy_grossDoctorId, biopsy_sessionId, biopsy_grossDatetime, biopsy_collectDatetime, biopsy_createStaffId) values ('87DBB483-F2CA-4623-98D8-059536BED0E4', 3, '574A295E-CFA9-4CDE-B75F-B4AA650206E4', 'A04E2A34-4D6C-4246-BCF4-47B8482BAAF7', 1, '6DDAA669-7F0E-46CC-8271-88633C859FFC', '629D7368-8431-421B-8720-9BC0B89A4E60', getdate(), getdate(), '73F2B296-EBDC-4434-892C-983E46F7CCF3')
insert into pmsx_biopsy(biopsy_id, biopsy_code, biopsy_groupId, biopsy_patientId, biopsy_segment, biopsy_grossDoctorId, biopsy_sessionId, biopsy_grossDatetime, biopsy_collectDatetime, biopsy_createStaffId) values ('3299556F-0C25-45A8-8F81-AF031562F573', 4, '574A295E-CFA9-4CDE-B75F-B4AA650206E4', '87F61977-AC33-4074-80FD-8ACEED052D64', 3, '6DDAA669-7F0E-46CC-8271-88633C859FFC', '629D7368-8431-421B-8720-9BC0B89A4E60', getdate(), getdate(), '73F2B296-EBDC-4434-892C-983E46F7CCF3')
insert into pmsx_biopsy(biopsy_id, biopsy_code, biopsy_groupId, biopsy_patientId, biopsy_segment, biopsy_grossDoctorId, biopsy_sessionId, biopsy_grossDatetime, biopsy_collectDatetime, biopsy_createStaffId) values ('7B5E1389-A135-4DA8-83AF-3EBA7FAC1550', 5, '574A295E-CFA9-4CDE-B75F-B4AA650206E4', '1A1D1307-A471-4752-B492-3E2DF431B0BA', 1, '6DDAA669-7F0E-46CC-8271-88633C859FFC', '8CF9811C-8D66-4DC1-A42F-85B2A44089E5', getdate(), getdate(), '73F2B296-EBDC-4434-892C-983E46F7CCF3')
insert into pmsx_biopsy(biopsy_id, biopsy_code, biopsy_groupId, biopsy_patientId, biopsy_segment, biopsy_grossDoctorId, biopsy_sessionId, biopsy_grossDatetime, biopsy_collectDatetime, biopsy_createStaffId) values ('A8FD39C7-37E8-46C8-A873-6C4427C130B3', 6, '574A295E-CFA9-4CDE-B75F-B4AA650206E4', '54C1D24B-4D38-4B99-B973-5B0D2204800A', 2, '6DDAA669-7F0E-46CC-8271-88633C859FFC', '8CF9811C-8D66-4DC1-A42F-85B2A44089E5', getdate(), getdate(), '73F2B296-EBDC-4434-892C-983E46F7CCF3')

insert into pmsx_biopsy(biopsy_id, biopsy_code, biopsy_groupId, biopsy_patientId, biopsy_segment, biopsy_grossDoctorId, biopsy_sessionId, biopsy_grossDatetime, biopsy_collectDatetime, biopsy_createStaffId) values ('C34387DC-CDFB-4F23-A4E0-FD60F67EF927', 1, '8C1782CA-A3BA-45C8-B2E0-40585C064B83', '07F5E2E4-CA32-46A9-BED7-C25B7E9E74CB', 1, '73F2B296-EBDC-4434-892C-983E46F7CCF3', '629D7368-8431-421B-8720-9BC0B89A4E60', getdate(), getdate(), '73F2B296-EBDC-4434-892C-983E46F7CCF3')
insert into pmsx_biopsy(biopsy_id, biopsy_code, biopsy_groupId, biopsy_patientId, biopsy_segment, biopsy_grossDoctorId, biopsy_sessionId, biopsy_grossDatetime, biopsy_collectDatetime, biopsy_createStaffId) values ('7C2FF847-A0F3-47EF-AC6F-8AB231A3247C', 2, '8C1782CA-A3BA-45C8-B2E0-40585C064B83', 'E4F4845B-B47D-478C-B0CC-D10856057E2B', 1, '73F2B296-EBDC-4434-892C-983E46F7CCF3', '629D7368-8431-421B-8720-9BC0B89A4E60', getdate(), getdate(), '73F2B296-EBDC-4434-892C-983E46F7CCF3')
insert into pmsx_biopsy(biopsy_id, biopsy_code, biopsy_groupId, biopsy_patientId, biopsy_segment, biopsy_grossDoctorId, biopsy_sessionId, biopsy_grossDatetime, biopsy_collectDatetime, biopsy_createStaffId) values ('1B6FAC14-6D63-4086-A0EE-B80EEBAB4A9B', 3, '8C1782CA-A3BA-45C8-B2E0-40585C064B83', 'A04E2A34-4D6C-4246-BCF4-47B8482BAAF7', 1, '6DDAA669-7F0E-46CC-8271-88633C859FFC', '629D7368-8431-421B-8720-9BC0B89A4E60', getdate(), getdate(), '73F2B296-EBDC-4434-892C-983E46F7CCF3')
insert into pmsx_biopsy(biopsy_id, biopsy_code, biopsy_groupId, biopsy_patientId, biopsy_segment, biopsy_grossDoctorId, biopsy_sessionId, biopsy_grossDatetime, biopsy_collectDatetime, biopsy_createStaffId) values ('84551AC4-9B20-408F-96DE-DBF91F2931FB', 4, '8C1782CA-A3BA-45C8-B2E0-40585C064B83', '87F61977-AC33-4074-80FD-8ACEED052D64', 2, '73F2B296-EBDC-4434-892C-983E46F7CCF3', '629D7368-8431-421B-8720-9BC0B89A4E60', getdate(), getdate(), '73F2B296-EBDC-4434-892C-983E46F7CCF3')
insert into pmsx_biopsy(biopsy_id, biopsy_code, biopsy_groupId, biopsy_patientId, biopsy_segment, biopsy_grossDoctorId, biopsy_sessionId, biopsy_grossDatetime, biopsy_collectDatetime, biopsy_createStaffId) values ('ACCB40D3-ABB5-4664-9776-2D923BC08BDE', 1, '2183CCCB-0A65-407C-AE93-CE9CF37B5499', '1A1D1307-A471-4752-B492-3E2DF431B0BA', 1, '73F2B296-EBDC-4434-892C-983E46F7CCF3', '8CF9811C-8D66-4DC1-A42F-85B2A44089E5', getdate(), getdate(), '73F2B296-EBDC-4434-892C-983E46F7CCF3')
insert into pmsx_biopsy(biopsy_id, biopsy_code, biopsy_groupId, biopsy_patientId, biopsy_segment, biopsy_grossDoctorId, biopsy_sessionId, biopsy_grossDatetime, biopsy_collectDatetime, biopsy_createStaffId) values ('F15B3C75-2479-466F-9DD8-AA8668A3BD4F', 2, '2183CCCB-0A65-407C-AE93-CE9CF37B5499', '54C1D24B-4D38-4B99-B973-5B0D2204800A', 1, '6DDAA669-7F0E-46CC-8271-88633C859FFC', '8CF9811C-8D66-4DC1-A42F-85B2A44089E5', getdate(), getdate(), '73F2B296-EBDC-4434-892C-983E46F7CCF3')

insert into pmsx_biopsy(biopsy_id, biopsy_code, biopsy_groupId, biopsy_patientId, biopsy_segment, biopsy_grossDoctorId, biopsy_grossDatetime, biopsy_collectDatetime, biopsy_createStaffId) values ('09665674-93E7-49D6-A6CA-CD617F6FDF19', 5, '8C1782CA-A3BA-45C8-B2E0-40585C064B83', '87F61977-AC33-4074-80FD-8ACEED052D64', 2, '73F2B296-EBDC-4434-892C-983E46F7CCF3', getdate(), getdate(), '73F2B296-EBDC-4434-892C-983E46F7CCF3')
insert into pmsx_biopsy(biopsy_id, biopsy_code, biopsy_groupId, biopsy_patientId, biopsy_segment, biopsy_grossDoctorId, biopsy_grossDatetime, biopsy_collectDatetime, biopsy_createStaffId) values ('09FAF08C-0419-4AAD-9EF2-2A5D31B95944', 6, '2183CCCB-0A65-407C-AE93-CE9CF37B5499', '1A1D1307-A471-4752-B492-3E2DF431B0BA', 1, '73F2B296-EBDC-4434-892C-983E46F7CCF3', getdate(), getdate(), '73F2B296-EBDC-4434-892C-983E46F7CCF3')
insert into pmsx_biopsy(biopsy_id, biopsy_code, biopsy_groupId, biopsy_patientId, biopsy_segment, biopsy_grossDoctorId, biopsy_grossDatetime, biopsy_collectDatetime, biopsy_createStaffId) values ('8B77B18F-1ABE-4D5C-AF0E-6AA9628C01A9', 3, '2183CCCB-0A65-407C-AE93-CE9CF37B5499', '54C1D24B-4D38-4B99-B973-5B0D2204800A', 1, '6DDAA669-7F0E-46CC-8271-88633C859FFC', getdate(), getdate(), '73F2B296-EBDC-4434-892C-983E46F7CCF3')
go

insert into pmsx_macroGroup(macroGroup_id, macroGroup_code, macroGroup_name, macroGroup_comment, macroGroup_state, macroGroup_createStaffId, macroGroup_createDatetime, macroGroup_updateStaffId, macroGroup_updateDatetime) values ('8B77B18F-1ABE-4D5C-AF0E-6AA9628C02A3','D','DA','abc',1,'73F2B296-EBDC-4434-892C-983E46F7CCF3','2020-7-11','73F2B296-EBDC-4434-892C-983E46F7CCF3','2020-7-12')
go

insert into pmsx_microGroup(microGroup_id, microGroup_code, microGroup_name, microGroup_comment, microGroup_state, microGroup_createStaffId, microGroup_createDatetime, microGroup_updateStaffId, microGroup_updateDatetime) values ('1EB38555-03CA-4A31-BBC3-F7070730A672','RHM','RANG HAM MAT','ABC',1,'73F2B296-EBDC-4434-892C-983E46F7CCF3','2020-7-11','73F2B296-EBDC-4434-892C-983E46F7CCF3','2020-7-12')
go

insert into pmsx_macro(macro_id, macro_code, macro_description, macro_groupId, macro_comment, macro_state, macro_createStaffId, macro_createDatetime, macro_updateStaffId, macro_updateDatetime) values ('CE4B5656-DCBA-46A3-9F71-6A8A52D0CB2A','D42','Trong lớp bì hiện diện các đám tuyến chuyển sản đỉnh tiết trưởng thành.','8B77B18F-1ABE-4D5C-AF0E-6AA9628C02A3','',1,'73F2B296-EBDC-4434-892C-983E46F7CCF3','2020-7-11','73F2B296-EBDC-4434-892C-983E46F7CCF3','2020-7-12')
go

insert into pmsx_micro(micro_id, micro_code, micro_description, micro_groupId, micro_createStaffId, micro_conclusion) values ('EFA6726E-1AD4-42DF-B401-F1EFFCFA4114','D42','Trong lớp bì hiện diện các đám tuyến chuyển sản đỉnh tiết trưởng thành.','1EB38555-03CA-4A31-BBC3-F7070730A672', '73F2B296-EBDC-4434-892C-983E46F7CCF3', 'asdasdasd')
go
