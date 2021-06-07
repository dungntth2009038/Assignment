using System;
using System.Collections.Generic;
using System.Text;
using StreetCRUD.entity;
using StreetCRUD.model;

namespace StreetCRUD.controller
{
    public class DuongPhoController
    {
        private DuongPhoDbModel _duongPhoDbModel = new DuongPhoDbModel();

        public void TaoDuongPho()
        {
            Console.OutputEncoding = Encoding.UTF8;
            DuongPho duongPho = new DuongPho();
            Console.WriteLine("Vui lòng nhập mã: ");
            duongPho.Ma = Console.ReadLine();
            Console.WriteLine("Nhập tên đường: ");
            duongPho.Ten = Console.ReadLine();
            Console.WriteLine("Mô tả: ");
            duongPho.MoTa = Console.ReadLine();
            Console.WriteLine("Ngày sử dụng: ");
            duongPho.NgaySuDung = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Lịch sử: ");
            duongPho.LichSu = Console.ReadLine();
            Console.WriteLine("Tên quận: ");
            duongPho.TenQuan =Console.ReadLine();
            Console.WriteLine("Trạng thái: ");
            duongPho.TrangThai = Convert.ToInt32(Console.ReadLine());
            bool result = _duongPhoDbModel.Save(duongPho);
            if (result)
            {
                Console.WriteLine("Tạo đường phố thành công!");
            }
            else
            {
                Console.WriteLine("Không thể tạo đường phố!");
            }
        }

        public void HienThiDanhSachDuongPho()
        {
            List<DuongPho> listDuongPho = _duongPhoDbModel.FindAll();
            Console.WriteLine("Danh sách đường phố: ");
            for (var i = 0; i < listDuongPho.Count; i++)
            {
                var dp = listDuongPho[i];
                Console.WriteLine(
                    $"Mã đường,phố: {dp.Ma}, Tên đường,phố: {dp.Ten}, Mô tả: {dp.NgaySuDung}, Lịch sử: {dp.LichSu}, Tên quận: {dp.TenQuan}, Trạng thái: {dp.TrangThai}");
            }
        }

        public void SuaThongTinDuongPho()
        {
            Console.WriteLine("Nhập mã đường phố cần sửa:");
            var maDuongPho = Console.ReadLine();
            DuongPho dp = _duongPhoDbModel.FindById(maDuongPho);
            if (dp == null)
            {
                Console.WriteLine("Không tìm thấy đường,phố cần sửa!");
                return;
            }

            Console.WriteLine("Nhập tên đường,phố: ");
            var tenDuongPho = Console.ReadLine();
            dp.Ten = tenDuongPho;
            Console.WriteLine("Nhập mô tả đường,phố: ");
            var moTa = Console.ReadLine();
            dp.MoTa = moTa;
            Console.WriteLine("Nhập ngày sử dụng đường,phố: ");
            var ngaySuDung = Console.ReadLine();
            dp.NgaySuDung = Convert.ToDateTime(ngaySuDung);
            Console.WriteLine("Nhập lịch sử đường,phố: ");
            var lichSu = Console.ReadLine();
            dp.LichSu = lichSu;
            Console.WriteLine("Nhập tên quận: ");
            var tenQuan = Console.ReadLine();
            dp.TenQuan = tenQuan;
            Console.WriteLine("Nhập trạng thái đường,phố: ");
            var trangThai = Console.ReadLine();
            dp.TrangThai = Convert.ToInt32(trangThai);
            bool result = _duongPhoDbModel.Update(maDuongPho, dp);
            if (result)
            {
                Console.WriteLine("Sửa thông tin thành công!");
            }
            else
            {
                Console.WriteLine("Có lỗi xảy ra, vui lòng thử lại sau!");
            }
        }

        public void XoaThongTinDuongPho()
        {
            Console.WriteLine("Nhập mã đường,phố cần xóa: ");
            var maDuongPho = Console.ReadLine();
            DuongPho dp = _duongPhoDbModel.FindById(maDuongPho);
            if (dp == null)
            {
                Console.WriteLine("Không tim thấy đường,phố!");
                return;
            }

            Console.WriteLine($"Tìm thấy đường,phố có mã: {dp.Ma}, tên là: {dp.Ten}");
            Console.WriteLine("Bạn có chắc muốn xóa sv này không (C/K) ?");
            string choice = Console.ReadLine();
            if (choice.ToLower().Equals("C"))
            {
                bool result = _duongPhoDbModel.Delete(maDuongPho);
                if (result)
                {
                    Console.WriteLine("Xóa thành công!");
                }
                else
                {
                    Console.WriteLine("Có lỗi, vui lòg thử lại!");
                }
            }
        }
    }
}


