drop database if exists database_pmsx;
create database database_pmsx;
use database_pmsx;

-- ----------------------------

create table table_staff
(
  staff_id             bigint        not null auto_increment,
  staff_username       nvarchar(100) not null,
  staff_password       nvarchar(100) not null,
  staff_name           nvarchar(100) not null,

  staff_comment        nvarchar(1000),
  staff_state          int           not null default 1,

  staff_createStaffId  bigint        not null,
  staff_createDateTime datetime      not null default now(),
  staff_updateStaffId  bigint,
  staff_updateDateTime datetime,

  primary key (staff_id),
  unique (staff_username),
  foreign key (staff_createStaffId) references table_staff (staff_id),
  foreign key (staff_updateStaffId) references table_staff (staff_id)
);

create table table_role
(
  role_id   bigint        not null auto_increment,
  role_name nvarchar(100) not null,

  primary key (role_id),
  unique (role_name)
);

create table table_permission
(
  permission_id             bigint   not null auto_increment,
  permission_staffId        bigint   not null,
  permission_roleId         bigint   not null,

  permission_comment        nvarchar(1000),
  permission_state          int      not null default 1,

  permission_createStaffId  bigint   not null,
  permission_createDateTime datetime not null default now(),
  permission_updateStaffId  bigint,
  permission_updateDateTime datetime,

  primary key (permission_id),
  unique (permission_staffId, permission_roleId),
  foreign key (permission_staffId) references table_staff (staff_id),
  foreign key (permission_roleId) references table_role (role_id),
  foreign key (permission_createStaffId) references table_staff (staff_id),
  foreign key (permission_updateStaffId) references table_staff (staff_id)
);

create table table_session
(
  session_id             bigint   not null auto_increment,
  session_date           date     not null,
  session_doctorId       bigint   not null,
  session_technicianId   bigint   not null,

  session_comment        nvarchar(1000),
  session_state          int      not null default 1,

  session_createStaffId  bigint   not null,
  session_createDateTime datetime not null default now(),
  session_updateStaffId  bigint,
  session_updateDateTime datetime,

  primary key (session_id),
  unique (session_date),
  foreign key (session_doctorId) references table_staff (staff_id),
  foreign key (session_technicianId) references table_staff (staff_id),
  foreign key (session_createStaffId) references table_staff (staff_id),
  foreign key (session_updateStaffId) references table_staff (staff_id)
);

create table table_group
(
  group_id    bigint not null auto_increment,
  group_year  int    not null,
  group_total bigint not null default 0,

  primary key (group_id),
  unique (group_year)
);

create table table_patient
(
  patient_id             bigint         not null auto_increment,
  patient_groupId        bigint         not null,
  patient_code           bigint         not null,
  patient_name           nvarchar(100)  not null,
  patient_year           int            not null,
  patient_address        nvarchar(1000) not null,

  patient_comment        nvarchar(1000),
  patient_state          int            not null default 1,

  patient_createStaffId  bigint         not null,
  patient_createDateTime datetime       not null default now(),
  patient_updateStaffId  bigint,
  patient_updateDateTime datetime,

  primary key (patient_id),
  foreign key (patient_groupId) references table_group (group_id),
  foreign key (patient_createStaffId) references table_staff (staff_id),
  foreign key (patient_updateStaffId) references table_staff (staff_id)
);

create table table_macroGroup
(
  macroGroup_id             bigint        not null auto_increment,
  macroGroup_code           nvarchar(100) not null,
  macroGroup_name           nvarchar(100) not null,

  macroGroup_comment        nvarchar(1000),
  macroGroup_state          int           not null default 1,

  macroGroup_createStaffId  bigint        not null,
  macroGroup_createDateTime datetime      not null default now(),
  macroGroup_updateStaffId  bigint,
  macroGroup_updateDateTime datetime,

  primary key (macroGroup_id),
  unique (macroGroup_code),
  foreign key (macroGroup_createStaffId) references table_staff (staff_id),
  foreign key (macroGroup_updateStaffId) references table_staff (staff_id)
);

create table table_microGroup
(
  microGroup_id             bigint        not null auto_increment,
  microGroup_code           nvarchar(100) not null,
  microGroup_name           nvarchar(100) not null,

  microGroup_comment        nvarchar(1000),
  microGroup_state          int           not null default 1,

  microGroup_createStaffId  bigint        not null,
  microGroup_createDateTime datetime      not null default now(),
  microGroup_updateStaffId  bigint,
  microGroup_updateDateTime datetime,

  primary key (microGroup_id),
  unique (microGroup_code),
  foreign key (microGroup_createStaffId) references table_staff (staff_id),
  foreign key (microGroup_updateStaffId) references table_staff (staff_id)
);

create table table_macro
(
  macro_id             bigint         not null auto_increment,
  macro_code           nvarchar(100)  not null,
  macro_description    nvarchar(1000) not null,
  macro_macroGroupId   bigint         not null,

  macro_comment        nvarchar(1000),
  macro_state          int            not null default 1,

  macro_createStaffId  bigint         not null,
  macro_createDateTime datetime       not null default now(),
  macro_updateStaffId  bigint,
  macro_updateDateTime datetime,

  primary key (macro_id),
  unique (macro_code),
  foreign key (macro_macroGroupId) references table_macroGroup (macroGroup_id),
  foreign key (macro_createStaffId) references table_staff (staff_id),
  foreign key (macro_updateStaffId) references table_staff (staff_id)
);

create table table_micro
(
  micro_id             bigint         not null auto_increment,
  micro_code           nvarchar(100)  not null,
  micro_description    nvarchar(1000) not null,
  micro_conclusion     nvarchar(1000) not null,
  micro_microGroupId   bigint         not null,

  micro_comment        nvarchar(1000),
  micro_state          int            not null default 1,

  micro_createStaffId  bigint         not null,
  micro_createDateTime datetime       not null default now(),
  micro_updateStaffId  bigint,
  micro_updateDateTime datetime,

  primary key (micro_id),
  unique (micro_code),
  foreign key (micro_microGroupId) references table_microGroup (microGroup_id),
  foreign key (micro_createStaffId) references table_staff (staff_id),
  foreign key (micro_updateStaffId) references table_staff (staff_id)
);

create table table_biopsy
(
  biopsy_id                  bigint         not null auto_increment,
  biopsy_patientId           bigint         not null,
  biopsy_sessionId           bigint         not null,
  biopsy_segment             nvarchar(100)  not null default 1,
  biopsy_grossDate           date           not null,
  biopsy_collectDate         date           not null,
  biopsy_macroId             bigint         not null,
  biopsy_macroDescription    nvarchar(1000) not null,
  biopsy_provisionalDiagnose nvarchar(1000),

  biopsy_comment             nvarchar(1000),
  biopsy_state               int            not null default 1,

  biopsy_createStaffId       bigint         not null,
  biopsy_createDateTime      datetime       not null default now(),
  biopsy_updateStaffId       bigint,
  biopsy_updateDateTime      datetime,

  primary key (biopsy_id),
  foreign key (biopsy_patientId) references table_patient (patient_id),
  foreign key (biopsy_sessionId) references table_session (session_id),
  foreign key (biopsy_macroId) references table_macro (macro_id),
  foreign key (biopsy_createStaffId) references table_staff (staff_id),
  foreign key (biopsy_updateStaffId) references table_staff (staff_id)
);

create table table_diagnoseType1
(
  diagnose_id               bigint         not null auto_increment,
  diagnose_biopsyId         bigint         not null,
  diagnose_microId          bigint         not null,
  diagnose_microDescription nvarchar(1000) not null,
  diagnose_conclusion       nvarchar(1000) not null,
  diagnose_readDate         date           not null,
  diagnose_image1           nvarchar(1000) not null,
  diagnose_image2           nvarchar(1000) not null,

  diagnose_comment          nvarchar(1000),
  diagnose_state            int            not null default 1,

  diagnose_createStaffId    bigint         not null,
  diagnose_createDateTime   datetime       not null default now(),
  diagnose_updateStaffId    bigint,
  diagnose_updateDateTime   datetime,

  primary key (diagnose_id),
  foreign key (diagnose_biopsyId) references table_biopsy (biopsy_id),
  foreign key (diagnose_microId) references table_micro (micro_id),
  foreign key (diagnose_createStaffId) references table_staff (staff_id),
  foreign key (diagnose_updateStaffId) references table_staff (staff_id)
);

-- -----------------------------

delimiter $$

create procedure procedure_select_group_now()
begin
  declare $id bigint default null;
  declare $year_now int default year(now());

  set $id = (
    select group_id
    from view_group
    where group_year = $year_now
  );

  if ($id is null) then
    insert into table_group(group_year) values ($year_now);
    set $id = last_insert_id();
  end if;

  select *
  from view_group
  where group_id = $id;
end $$

delimiter ;

-- -----------------------------

create view view_staff as
select staff.*,
       createStaff.staff_name as staff_createStaffName,
       updateStaff.staff_name as staff_updateStaffName
from table_staff as staff
       join table_staff as createStaff on staff.staff_createStaffId = createStaff.staff_id
       left outer join table_staff as updateStaff on staff.staff_updateStaffId = updateStaff.staff_id
order by staff.staff_name desc;

create view view_role as
select table_role.*
from table_role
order by table_role.role_id desc;

create view view_permission as
select table_permission.*,
       staff.staff_name       as permission_staffName,
       table_role.role_name   as permission_roleName,
       createStaff.staff_name as permission_createStaffName,
       updateStaff.staff_name as permission_updateStaffName
from table_permission
       join table_staff as staff on table_permission.permission_staffId = staff.staff_id
       join table_role on table_permission.permission_roleId = table_role.role_id
       join table_staff as createStaff on table_permission.permission_createStaffId = createStaff.staff_id
       left outer join table_staff as updateStaff on table_permission.permission_updateStaffId = updateStaff.staff_id
order by staff.staff_name desc;

create view view_session as
select table_session.*,
       doctor.staff_name      as session_doctorName,
       technician.staff_name  as session_technicianName,
       createStaff.staff_name as session_createStaffName,
       updateStaff.staff_name as session_updateStaffName
from table_session
       join table_staff as doctor on table_session.session_doctorId = doctor.staff_id
       join table_staff as technician on table_session.session_technicianId = technician.staff_id
       join table_staff as createStaff on table_session.session_createStaffId = createStaff.staff_id
       left outer join table_staff as updateStaff on table_session.session_updateStaffId = updateStaff.staff_id
order by table_session.session_date desc;

create view view_group as
select table_group.*
from table_group
order by table_group.group_year desc;

create view view_patient as
select table_patient.*,
       table_group.group_year as patient_groupYear,
       createStaff.staff_name as patient_createStaffName,
       updateStaff.staff_name as patient_updateStaffName
from table_patient
       join table_group on table_patient.patient_groupId = table_group.group_id
       join table_staff as createStaff on table_patient.patient_createStaffId = createStaff.staff_id
       left outer join table_staff as updateStaff on table_patient.patient_updateStaffId = updateStaff.staff_id
order by table_patient.patient_code;

create view view_macroGroup as
select table_macroGroup.*,
       createStaff.staff_name as macroGroup_createStaffName,
       updateStaff.staff_name as macroGroup_updateStaffName
from table_macroGroup
       join table_staff as createStaff on table_macroGroup.macroGroup_createStaffId = createStaff.staff_id
       left outer join table_staff as updateStaff on table_macroGroup.macroGroup_updateStaffId = updateStaff.staff_id
order by table_macroGroup.macroGroup_code;

create view view_microGroup as
select table_microGroup.*,
       createStaff.staff_name as microGroup_createStaffName,
       updateStaff.staff_name as microGroup_updateStaffName
from table_microGroup
       join table_staff as createStaff on table_microGroup.microGroup_createStaffId = createStaff.staff_id
       left outer join table_staff as updateStaff on table_microGroup.microGroup_updateStaffId = updateStaff.staff_id
order by table_microGroup.microGroup_code;

create view view_macro as
select table_macro.*,
       createStaff.staff_name as macro_createStaffName,
       updateStaff.staff_name as macro_updateStaffName
from table_macro
       join table_staff as createStaff on table_macro.macro_createStaffId = createStaff.staff_id
       left outer join table_staff as updateStaff on table_macro.macro_updateStaffId = updateStaff.staff_id
order by table_macro.macro_code;

create view view_micro as
select table_micro.*,
       createStaff.staff_name as micro_createStaffName,
       updateStaff.staff_name as micro_updateStaffName
from table_micro
       join table_staff as createStaff on table_micro.micro_createStaffId = createStaff.staff_id
       left outer join table_staff as updateStaff on table_micro.micro_updateStaffId = updateStaff.staff_id
order by table_micro.micro_code;

-- -----------------------------

insert into table_staff(staff_username, staff_password, staff_name, staff_createStaffId)
values ('daomtthuan', '$2y$10$1iWsYQzkNTnZY8AVtSEJl.2lbYpyCaqTWRYXD.nL3Rz1kaEy57.Uq', 'Đào Minh Trung Thuận', 1);
insert into table_staff(staff_username, staff_password, staff_name, staff_createStaffId)
values ('tech1', '$2y$10$1iWsYQzkNTnZY8AVtSEJl.2lbYpyCaqTWRYXD.nL3Rz1kaEy57.Uq', 'Lưu Bá Ôn', 1);
insert into table_staff(staff_username, staff_password, staff_name, staff_createStaffId)
values ('tech2', '$2y$10$1iWsYQzkNTnZY8AVtSEJl.2lbYpyCaqTWRYXD.nL3Rz1kaEy57.Uq', 'Âu Dương Chấn Hoa', 1);
insert into table_staff(staff_username, staff_password, staff_name, staff_createStaffId)
values ('tech3', '$2y$10$1iWsYQzkNTnZY8AVtSEJl.2lbYpyCaqTWRYXD.nL3Rz1kaEy57.Uq', 'Lâm Văn Long', 1);
insert into table_staff(staff_username, staff_password, staff_name, staff_createStaffId)
values ('tech4', '$2y$10$1iWsYQzkNTnZY8AVtSEJl.2lbYpyCaqTWRYXD.nL3Rz1kaEy57.Uq', 'Hà Vĩnh Chu', 1);
insert into table_staff(staff_username, staff_password, staff_name, staff_createStaffId)
values ('doctor1', '$2y$10$1iWsYQzkNTnZY8AVtSEJl.2lbYpyCaqTWRYXD.nL3Rz1kaEy57.Uq', 'Lâm Văn Long', 1);
insert into table_staff(staff_username, staff_password, staff_name, staff_createStaffId)
values ('doctor2', '$2y$10$1iWsYQzkNTnZY8AVtSEJl.2lbYpyCaqTWRYXD.nL3Rz1kaEy57.Uq', 'Lương Tiểu Nhu', 1);
insert into table_staff(staff_username, staff_password, staff_name, staff_createStaffId)
values ('doctor3', '$2y$10$1iWsYQzkNTnZY8AVtSEJl.2lbYpyCaqTWRYXD.nL3Rz1kaEy57.Uq', 'Dương Mịch', 1);

insert into table_role (role_name)
values ('Quản trị');
insert into table_role (role_name)
values ('Bác sĩ');
insert into table_role (role_name)
values ('Kỹ thuật viên');

insert into table_permission(permission_staffId, permission_roleId, permission_createStaffId)
values (1, 1, 1);
insert into table_permission(permission_staffId, permission_roleId, permission_createStaffId)
values (1, 2, 1);
insert into table_permission(permission_staffId, permission_roleId, permission_createStaffId)
values (6, 2, 1);
insert into table_permission(permission_staffId, permission_roleId, permission_createStaffId)
values (7, 2, 1);
insert into table_permission(permission_staffId, permission_roleId, permission_createStaffId)
values (8, 2, 1);
insert into table_permission(permission_staffId, permission_roleId, permission_createStaffId)
values (1, 3, 1);
insert into table_permission(permission_staffId, permission_roleId, permission_createStaffId)
values (2, 3, 1);
insert into table_permission(permission_staffId, permission_roleId, permission_createStaffId)
values (3, 3, 1);
insert into table_permission(permission_staffId, permission_roleId, permission_createStaffId)
values (4, 3, 1);
insert into table_permission(permission_staffId, permission_roleId, permission_createStaffId)
values (5, 3, 1);

insert into table_session(session_date, session_doctorId, session_technicianId, session_createStaffId)
values (convert(now(), date), 2, 6, 1);

insert into table_group(group_year, group_total)
values (2018, 0);
insert into table_group(group_year, group_total)
values (2019, 0);
insert into table_group(group_year, group_total)
values (2020, 4);

insert into table_patient(patient_groupId, patient_code, patient_name, patient_year, patient_address, patient_createStaffId)
values (3, 1, 'Nguyễn Thị An', 1989, 'Cần Thơ', 1);
insert into table_patient(patient_groupId, patient_code, patient_name, patient_year, patient_address, patient_createStaffId)
values (3, 2, 'Trần Văn Bình', 1990, 'Cần Thơ', 1);
insert into table_patient(patient_groupId, patient_code, patient_name, patient_year, patient_address, patient_createStaffId)
values (3, 3, 'Ngô Diễm Châu', 1979, 'Cần Thơ', 1);
insert into table_patient(patient_groupId, patient_code, patient_name, patient_year, patient_address, patient_createStaffId)
values (3, 4, 'Hà Vĩnh Phúc', 1980, 'Cần Thơ', 1);
insert into table_patient(patient_groupId, patient_code, patient_name, patient_year, patient_address, patient_createStaffId)
values (3, 5, 'Trần Văn Lâm', 1970, 'Cần Thơ', 1);
insert into table_patient(patient_groupId, patient_code, patient_name, patient_year, patient_address, patient_createStaffId)
values (3, 6, 'Trương Thị Huệ', 1988, 'Cần Thơ', 1);
insert into table_patient(patient_groupId, patient_code, patient_name, patient_year, patient_address, patient_createStaffId)
values (3, 7, 'Lý Kim Thoa', 1995, 'Cần Thơ', 1);
insert into table_patient(patient_groupId, patient_code, patient_name, patient_year, patient_address, patient_createStaffId)
values (2, 1, 'Nguyễn Thị An', 1989, 'Cần Thơ', 1);
insert into table_patient(patient_groupId, patient_code, patient_name, patient_year, patient_address, patient_createStaffId)
values (2, 2, 'Trần Văn Bình', 1990, 'Cần Thơ', 1);
insert into table_patient(patient_groupId, patient_code, patient_name, patient_year, patient_address, patient_createStaffId)
values (1, 1, 'Ngô Diễm Châu', 1979, 'Cần Thơ', 1);
insert into table_patient(patient_groupId, patient_code, patient_name, patient_year, patient_address, patient_createStaffId)
values (1, 2, 'Lý Tuyết Dung', 1995, 'Cần Thơ', 1);
insert into table_patient(patient_groupId, patient_code, patient_name, patient_year, patient_address, patient_createStaffId)
values (1, 3, 'Nguyễn Thị An', 1989, 'Cần Thơ', 1);

insert into table_macroGroup(macroGroup_code, macroGroup_name, macroGroup_createStaffId)
values ('D', 'Da', 1);
insert into table_macroGroup(macroGroup_code, macroGroup_name, macroGroup_createStaffId)
values ('RHM', 'Răng hàm mặt', 1);
insert into table_macroGroup(macroGroup_code, macroGroup_name, macroGroup_createStaffId)
values ('A', 'Amindan', 1);

insert into table_microGroup(microGroup_code, microGroup_name, microGroup_createStaffId)
values ('D', 'Da', 1);
insert into table_microGroup(microGroup_code, microGroup_name, microGroup_createStaffId)
values ('RHM', 'Răng hàm mặt', 1);
insert into table_microGroup(microGroup_code, microGroup_name, microGroup_createStaffId)
values ('A', 'Amindan', 1);