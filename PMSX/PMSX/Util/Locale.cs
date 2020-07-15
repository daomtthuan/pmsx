using System.Collections.Generic;

namespace PMSX.Util {
  public class Locale {

    private static Locale instance;

    private Locale() {
      Caption = new Dictionary<string, string>() {
        { "Id", "Mã định danh" },
        { "Username", "Tên đăng nhập" },
        { "Password", "Mật khẩu" },
        { "Name", "Tên" },
        { "Comment", "Ghi chú" },
        { "State", "Trạng thái" },
        { "CreateStaffId", "Mã định danh nhân viên tạo" },
        { "CreateDatetime", "Ngày tạo" },
        { "UpdateStaffId", "Mã định danh nhân viên sửa" },
        { "UpdateDatetime", "Ngày sửa" },
        { "TechnicianId", "Mã định danh kỹ thuật viên" },
        { "TechnicianName", "Tên kỹ thuật viên" },
        { "DoctorId", "Mã định danh bác sĩ" },
        { "DoctorName", "Tên bác sĩ" },
        { "StaffId", "Mã định danh nhân viên" },
        { "StaffUsername", "Tên đăng nhập nhân viên" },
        { "StaffName", "Tên nhân viên" },
        { "RoleId", "Mã định danh quyền truy cập" },
        { "YearsOld", "Tuổi" },
        { "Address", "Địa chỉ" },
        { "Code", "Mã số" },
        { "NumberBiopsy", "Số mẫu sinh thiết" },
        { "MacroGroupId", "Mã định danh nhóm đại thể" },
        { "MicroGroupId", "Mã định danh nhóm vi thể" },
        { "DiagnoseType", "Loại chẩn đoán" },
        { "PatientId", "Mã định danh bệnh nhân" },
        { "SessionId", "Mã định danh phiên làm việc" },
        { "GrossDoctorId", "Mã định danh bác sĩ gọt" },
        { "Segment", "Số mảnh" },
        { "GrossDatetime", "Ngày gọt" },
        { "CollectDatetime", "Ngày thu thập" },
        { "BiopsyGroupId", "Mã định danh nhóm sinh thiết" },
        { "Description", "Mô tả" },
        { "Conclusion", "Kết luận" },
      };      
    }

    public static Locale Instance {
      get {
        if (instance == null)
          instance = new Locale();
        return instance;
      }
      private set => instance = value;
    }

    public Dictionary<string, string> Caption { get; private set; }
  }
}
