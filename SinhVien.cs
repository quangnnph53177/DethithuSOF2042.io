using System;
using System.Collections.Generic;
using System.Linq;

namespace Dethithu
{
    public class SinhVien
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public int Tuoi { get; set; }
        public float DiemTrungBinh { get; set; }
        public int KyHoc { get; set; }
        public string ChuyenNganh { get; set; }

        public SinhVien(string maSV, string hoTen, int tuoi, float diemTrungBinh, int kyHoc, string chuyenNganh)
        {
            MaSV = maSV;
            HoTen = hoTen;
            Tuoi = tuoi;
            DiemTrungBinh = diemTrungBinh;
            KyHoc = kyHoc;
            ChuyenNganh = chuyenNganh;
        }
    }

    public class SinhVienService
    {
        private List<SinhVien> _sinhViens;

        public SinhVienService()
        {
            _sinhViens = new List<SinhVien>();
        }

        public List<SinhVien> DanhSachSinhVien()
        {
            return _sinhViens;
        }

        public bool ThemSinhVien(SinhVien sinhVien)
        {
            if (sinhVien == null)
                throw new ArgumentException("Sinh viên không được để trống");
            if (_sinhViens.Any(x => x.MaSV == sinhVien.MaSV))
                throw new ArgumentException("Mã sinh viên đã tồn tại");
            _sinhViens.Add(sinhVien);
            return true;
        }

        public bool SuaSinhVien(SinhVien sinhVien)
        {
            var sinhVienSua = _sinhViens.FirstOrDefault(x => x.MaSV == sinhVien.MaSV);
            if (sinhVienSua == null)
                throw new ArgumentException("Không tìm thấy sinh viên");

            // Cập nhật thông tin sinh viên  
            sinhVienSua.HoTen = sinhVien.HoTen;
            sinhVienSua.Tuoi = sinhVien.Tuoi;
            sinhVienSua.DiemTrungBinh = sinhVien.DiemTrungBinh;
            sinhVienSua.KyHoc = sinhVien.KyHoc;
            sinhVienSua.ChuyenNganh = sinhVien.ChuyenNganh;

            return true;
        }

        public bool XoaSinhVien(string maSV)
        {
            var sinhVienXoa = _sinhViens.FirstOrDefault(x => x.MaSV == maSV);
            if (sinhVienXoa == null)
                throw new ArgumentException("Không tìm thấy sinh viên");

            _sinhViens.Remove(sinhVienXoa);
            return true;
        }
    }
}