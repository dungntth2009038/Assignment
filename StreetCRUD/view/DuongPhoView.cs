using System;
using StreetCRUD.controller;

namespace StreetCRUD.view
{
    public class DuongPhoView
    {
        private DuongPhoController _duongPhoController = new DuongPhoController();
        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("Quản lý đường phố. ");
                Console.WriteLine("------------------------------ ");
                Console.WriteLine("1.Tạo mới đường phố. ");
                Console.WriteLine("2.Hiển thị danh sách đường phố. ");
                Console.WriteLine("3.Sửa thông tin. ");
                Console.WriteLine("4.Xóa thông tin.");
                Console.WriteLine("5.Thoát chương trình. ");
                Console.WriteLine("------------------------------ ");
                Console.WriteLine("Nhập lựa chọn của bạn (1-5): ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1: _duongPhoController.TaoDuongPho();
                        break;
                    case 2: _duongPhoController.HienThiDanhSachDuongPho();
                        break;
                    case 3: _duongPhoController.SuaThongTinDuongPho();
                        break;
                    case 4: _duongPhoController.XoaThongTinDuongPho();
                        break;
                    case 5:
                        Console.WriteLine("Thoát chương trình, hẹn gặp lại sau!");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn sai, vui lòng nhập lựa chọn từ 1-5.");
                        break;
                }
                Console.WriteLine();
                if (choice==5)
                {
                    break;
                }
            }
        }
    }
}