using System;


namespace Street
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var duongPho = new DuongPho();
            var duongPhoModel = new DuongPhoModel();
            duongPho.Ma = "2";
            duongPho.Ten = "Tôn Thất Thuyết";
            duongPho.MoTa = "Tôn Thất Thuyết";
            duongPho.NgaySuDung = DateTime.Parse("1999-10-21");
            duongPho.LichSu = "Tôn Thất Thuyết";
            duongPho.TenQuan = "Tôn Thất Thuyết";
            duongPho.TrangThai = 2;
            duongPhoModel.Save(null);
        }
    }
}