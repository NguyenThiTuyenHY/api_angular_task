using System;
namespace Models{
    public class nhanvien{
        public int id { get; set; }
        public int idbophan { get; set; }
        public string hoten { get; set; }
        public string sdt { get; set; }
        public DateTime ngaysinh { get; set; }
        public int gioitinh { get; set; }
        public string diachi { get; set; }
        public DateTime gianhap { get; set; }
    }
}