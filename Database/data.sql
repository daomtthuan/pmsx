use pmsx;

delete from table_staff;
insert into table_staff(staff_username, staff_password, staff_name, staff_createStaffId) values ('daomtthuan', '$2y$10$1iWsYQzkNTnZY8AVtSEJl.2lbYpyCaqTWRYXD.nL3Rz1kaEy57.Uq', 'Đào Minh Trung Thuận', 1);
insert into table_staff(staff_username, staff_password, staff_name, staff_createStaffId) values ('tech1', '$2y$10$1iWsYQzkNTnZY8AVtSEJl.2lbYpyCaqTWRYXD.nL3Rz1kaEy57.Uq', 'Lưu Bá Ôn', 1);
insert into table_staff(staff_username, staff_password, staff_name, staff_createStaffId) values ('tech2', '$2y$10$1iWsYQzkNTnZY8AVtSEJl.2lbYpyCaqTWRYXD.nL3Rz1kaEy57.Uq', 'Âu Dương Chấn Hoa', 1);
insert into table_staff(staff_username, staff_password, staff_name, staff_createStaffId) values ('tech3', '$2y$10$1iWsYQzkNTnZY8AVtSEJl.2lbYpyCaqTWRYXD.nL3Rz1kaEy57.Uq', 'Lâm Văn Long', 1);
insert into table_staff(staff_username, staff_password, staff_name, staff_createStaffId) values ('tech4', '$2y$10$1iWsYQzkNTnZY8AVtSEJl.2lbYpyCaqTWRYXD.nL3Rz1kaEy57.Uq', 'Hà Vĩnh Chu', 1);
insert into table_staff(staff_username, staff_password, staff_name, staff_createStaffId) values ('doctor1', '$2y$10$1iWsYQzkNTnZY8AVtSEJl.2lbYpyCaqTWRYXD.nL3Rz1kaEy57.Uq', 'Lâm Văn Long', 1);
insert into table_staff(staff_username, staff_password, staff_name, staff_createStaffId) values ('doctor2', '$2y$10$1iWsYQzkNTnZY8AVtSEJl.2lbYpyCaqTWRYXD.nL3Rz1kaEy57.Uq', 'Lương Tiểu Nhu', 1);
insert into table_staff(staff_username, staff_password, staff_name, staff_createStaffId) values ('doctor3', '$2y$10$1iWsYQzkNTnZY8AVtSEJl.2lbYpyCaqTWRYXD.nL3Rz1kaEy57.Uq', 'Dương Mịch', 1);

delete from table_role;
insert into table_role (role_name, role_createStaffId) values ('Quản trị', 1);
insert into table_role (role_name, role_createStaffId) values ('Bác sĩ', 1);
insert into table_role (role_name, role_createStaffId) values ('Kỹ thuật', 1);

delete from table_permission;
insert into table_permission(permission_staffId, permission_roleId, permission_createStaffId) values (1, 1, 1);
insert into table_permission(permission_staffId, permission_roleId, permission_createStaffId) values (1, 2, 1);
insert into table_permission(permission_staffId, permission_roleId, permission_createStaffId) values (6, 2, 1);
insert into table_permission(permission_staffId, permission_roleId, permission_createStaffId) values (7, 2, 1);
insert into table_permission(permission_staffId, permission_roleId, permission_createStaffId) values (8, 2, 1);
insert into table_permission(permission_staffId, permission_roleId, permission_createStaffId) values (1, 3, 1);
insert into table_permission(permission_staffId, permission_roleId, permission_createStaffId) values (2, 3, 1);
insert into table_permission(permission_staffId, permission_roleId, permission_createStaffId) values (3, 3, 1);
insert into table_permission(permission_staffId, permission_roleId, permission_createStaffId) values (4, 3, 1);
insert into table_permission(permission_staffId, permission_roleId, permission_createStaffId) values (5, 3, 1);