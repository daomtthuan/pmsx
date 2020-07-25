drop database if exists pmsx;
create database pmsx;
use pmsx;

create table table_staff(
	staff_id							bigint 					not null	auto_increment,  
	staff_username				nvarchar(100) 	not null,
	staff_password				nvarchar(100) 	not null,
	staff_name						nvarchar(100)		not null,

	staff_comment					nvarchar(1000),
	staff_state						int 						not null	default 1,

	staff_createStaffId		bigint					not null,
	staff_createDatetime	datetime				not null	default now(),

	staff_updateStaffId		bigint,
	staff_updateDatetime	datetime,

	primary key	(staff_id),
  unique			(staff_username),
  foreign key	(staff_createStaffId)	references	table_staff	(staff_id),
	foreign key	(staff_updateStaffId)	references	table_staff	(staff_id)
);

create table table_role(
	role_id							bigint 					not null	auto_increment,  
	role_name						nvarchar(100) 	not null,

	role_comment				nvarchar(1000),
	role_state					int 						not null	default 1,

	role_createStaffId	bigint					not null,
	role_createDatetime	datetime				not null	default now(),

	role_updateStaffId	bigint,
	role_updateDatetime	datetime,

	primary key	(role_id),
  unique			(role_name),
  foreign key	(role_createStaffId)	references	table_staff	(staff_id),
	foreign key	(role_updateStaffId)	references	table_staff	(staff_id)
);

create table table_permission(
	permission_id							bigint 					not null	auto_increment,  
	permission_staffId				bigint					not null,
	permission_roleId					bigint					not null,

	permission_comment				nvarchar(1000),
	permission_state					int 						not null	default 1,

	permission_createStaffId	bigint					not null,
	permission_createDatetime	datetime				not null	default now(),

	permission_updateStaffId	bigint,
	permission_updateDatetime	datetime,

	primary key	(permission_id),
  unique			(permission_staffId, permission_roleId),
  foreign key	(permission_staffId)				references	table_staff	(staff_id),
  foreign key	(permission_roleId)					references	table_role		(role_id),
  foreign key	(permission_createStaffId)	references	table_staff	(staff_id),
	foreign key	(permission_updateStaffId)	references	table_staff	(staff_id)
);

create table table_session(
	session_id							bigint 					not null	auto_increment,  
  session_date						date						not null,
	session_doctorId				bigint					not null,
	session_technicianId		bigint					not null,
	session_comment					nvarchar(1000),
	session_state						int 						not null	default 1,

	session_createStaffId		bigint					not null,
	session_createDatetime	datetime				not null	default now(),

	session_updateStaffId		bigint,
	session_updateDatetime	datetime,

	primary key	(session_id),
  unique			(session_date),
  foreign key	(session_doctorId)			references	table_staff	(staff_id),
  foreign key	(session_technicianId)	references	table_staff	(staff_id),
  foreign key	(session_createStaffId)	references	table_staff	(staff_id),
	foreign key	(session_updateStaffId)	references	table_staff	(staff_id)
);

create table table_group(
	group_id		bigint	not null	auto_increment,
  group_year	int			not null,
  group_total bigint	not null	default 0,

	primary key	(group_id),
  unique			(group_year)
);

create trigger trigger_before_insert_table_group
	before insert on table_group for each row
  set new.group_year = year(now());

create table table_patient(
	patient_id							bigint					not null	auto_increment,
  patient_groupId					bigint					not null,
  patient_code						bigint					not null,
  patient_name						nvarchar(100)		not null,
  patient_year						int							not null,
	patient_address					nvarchar(1000)	not null,

	patient_comment					nvarchar(1000),
	patient_state						int 						not null	default 1,

	patient_createStaffId		bigint					not null,
	patient_createDatetime	datetime				not null	default now(),

	patient_updateStaffId		bigint,
	patient_updateDatetime	datetime,

	primary key	(patient_id),
  foreign key	(patient_groupId)				references	table_group	(group_id),
  foreign key	(patient_createStaffId)	references	table_staff	(staff_id),
	foreign key	(patient_updateStaffId)	references	table_staff	(staff_id)
);

create table table_macroGroup(
	macroGroup_id							bigint					not null	auto_increment,
  macroGroup_code						nvarchar(100)		not null,
  macroGroup_name						nvarchar(100)		not null,

	macroGroup_comment				nvarchar(1000),
	macroGroup_state					int 						not null	default 1,

	macroGroup_createStaffId	bigint					not null,
	macroGroup_createDatetime	datetime				not null	default now(),

	macroGroup_updateStaffId	bigint,
	macroGroup_updateDatetime	datetime,

	primary key	(macroGroup_id),
	unique			(macroGroup_code),
  foreign key	(macroGroup_createStaffId)	references	table_staff	(staff_id),
	foreign key	(macroGroup_updateStaffId)	references	table_staff	(staff_id)
);

create table table_microGroup(
	microGroup_id							bigint					not null	auto_increment,
  microGroup_code						nvarchar(100)		not null,
  microGroup_name						nvarchar(100)		not null,

	microGroup_comment				nvarchar(1000),
	microGroup_state					int 						not null	default 1,

	microGroup_createStaffId	bigint					not null,
	microGroup_createDatetime	datetime				not null	default now(),

	microGroup_updateStaffId	bigint,
	microGroup_updateDatetime	datetime,

	primary key	(microGroup_id),
	unique			(microGroup_code),
  foreign key	(microGroup_createStaffId)	references	table_staff	(staff_id),
	foreign key	(microGroup_updateStaffId)	references	table_staff	(staff_id)
);

create table table_macro(
	macro_id							bigint					not null	auto_increment,
  macro_code						nvarchar(100)		not null,
  macro_description			nvarchar(1000)	not null,
  macro_macroGroupId		bigint					not null,

	macro_comment					nvarchar(1000),
	macro_state						int 						not null	default 1,

	macro_createStaffId		bigint					not null,
	macro_createDatetime	datetime				not null	default now(),

	macro_updateStaffId		bigint,
	macro_updateDatetime	datetime,

	primary key	(macro_id),
	unique			(macro_code),
  foreign key	(macro_macroGroupId)	references	table_macroGroup	(macroGroup_id),
  foreign key	(macro_createStaffId)	references	table_staff				(staff_id),
	foreign key	(macro_updateStaffId)	references	table_staff				(staff_id)
);

create table table_micro(
	micro_id							bigint					not null	auto_increment,
  micro_code						nvarchar(100)		not null,
  micro_description			nvarchar(1000)	not null,
  micro_conclusion			nvarchar(1000)	not null,
  micro_microGroupId		bigint					not null,

	micro_comment					nvarchar(1000),
	micro_state						int 						not null	default 1,

	micro_createStaffId		bigint					not null,
	micro_createDatetime	datetime				not null	default now(),

	micro_updateStaffId		bigint,
	micro_updateDatetime	datetime,

	primary key	(micro_id),
	unique			(micro_code),
  foreign key	(micro_microGroupId)	references	table_microGroup	(microGroup_id),
  foreign key	(micro_createStaffId)	references	table_staff				(staff_id),
	foreign key	(micro_updateStaffId)	references	table_staff				(staff_id)
);

create table table_biopsy(
	biopsy_id										bigint					not null	auto_increment,
  biopsy_patientId						bigint					not null,
  biopsy_sessionId						bigint					not null,
	biopsy_segment							nvarchar(100)		not null 	default 1,	
	biopsy_grossDate						date						not null,
  biopsy_collectDate					date						not null,
  biopsy_macroId							bigint					not null,
  biopsy_macroDescription			nvarchar(1000)	not null,
  biopsy_provisionalDiagnosy	nvarchar(1000),

	biopsy_comment							nvarchar(1000),
	biopsy_state								int 						not null	default 1,

	biopsy_createStaffId				bigint					not null,
	biopsy_createDatetime				datetime				not null	default now(),

	biopsy_updateStaffId				bigint,
	biopsy_updateDatetime				datetime,

	primary key	(biopsy_id),
  foreign key	(biopsy_patientId)			references	table_patient	(patient_id),
  foreign key	(biopsy_sessionId)			references	table_session	(session_id),
  foreign key	(biopsy_macroId)				references	table_macro		(macro_id),
  foreign key	(biopsy_createStaffId)	references	table_staff		(staff_id),
	foreign key	(biopsy_updateStaffId)	references	table_staff		(staff_id)
);

create table table_diagnosyType1(
	diagnosy_id								bigint						not null	auto_increment,
  diagnosy_biopsyId					bigint						not null,
	diagnosy_microId					bigint						not null,
  diagnosy_microDescription	nvarchar(1000)		not null,
  diagnosy_conclusion				nvarchar(1000)		not null,
  diagnosy_readDate 				date							not null,
  diagnosy_image1						nvarchar(1000)		not null,
	diagnosy_image2						nvarchar(1000)		not null,

	diagnosy_comment					nvarchar(1000),
	diagnosy_state						int 							not null	default 1,

	diagnosy_createStaffId		bigint						not null,
	diagnosy_createDatetime		datetime					not null	default now(),

	diagnosy_updateStaffId		bigint,
	diagnosy_updateDatetime		datetime,

	primary key	(diagnosy_id),
  foreign key	(diagnosy_biopsyId)				references	table_biopsy	(biopsy_id),
	foreign key	(diagnosy_microId)				references	table_micro		(micro_id),
  foreign key	(diagnosy_createStaffId)	references	table_staff		(staff_id),
	foreign key	(diagnosy_updateStaffId)	references	table_staff		(staff_id)
);
