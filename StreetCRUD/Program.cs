using System;
using System.Text;
using StreetCRUD.controller;
using StreetCRUD.entity;
using StreetCRUD.model;
using StreetCRUD.view;

namespace StreetCRUD
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            DuongPho duongPho = new DuongPho();
            duongPho.Ma = "A003";
            duongPho.Ten = "Cau Giay";
            duongPho.MoTa = "Cau Giay";
            duongPho.NgaySuDung = DateTime.Now;
            duongPho.LichSu = "Cau Giay";
            duongPho.TenQuan = "Cau Giay";
            duongPho.TrangThai = 1;
            DuongPhoDbModel duongPhoDbModel = new DuongPhoDbModel();
            duongPhoDbModel.Save(duongPho);
        }
    }
}