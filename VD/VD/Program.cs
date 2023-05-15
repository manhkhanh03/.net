using System.IO;
using System.Security.AccessControl;

namespace VD
{
    public class Program
    {
        public static void AddDirectorySecurity(string FileName, string Account, FileSystemRights Rights, AccessControlType ControlType)
        {
            // Tạo một đối tượng DirectoryInfo mới và lấy thông tin bảo mật của thư mục
            DirectoryInfo dInfo = new DirectoryInfo(FileName);
            DirectorySecurity dSecurity = dInfo.GetAccessControl();

            // Thêm quyền truy cập cho thư mục
            dSecurity.AddAccessRule(new FileSystemAccessRule(Account, Rights, ControlType));

            // Đặt lại thông tin bảo mật cho thư mục
            dInfo.SetAccessControl(dSecurity);
        }

        public static void Main(string[] args)
        {
            string folderPath = @"C:\Users\MANH\Documents\test.rar";
            string userName = @"laptop-vl2dngoc\manh khanh";
            FileSystemRights rights = FileSystemRights.Write | FileSystemRights.Read;
            AccessControlType controlType = AccessControlType.Deny;
            AddDirectorySecurity(folderPath, userName, rights, controlType);
        }
    }
}