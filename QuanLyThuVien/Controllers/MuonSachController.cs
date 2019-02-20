using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuanLyThuVien.Models;
using QuanLyThuVien.ViewModels;

namespace QuanLyThuVien.Controllers
{
    public class MuonSachController : Controller
    {
        MyDBContext context = new MyDBContext();
        public MuonSachController()
        {
            context = new MyDBContext();
        }
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult DatSach(int id, int? idchinhanh)
        {
            //phân quyền 
            if (HttpContext.Session.GetString("TaiKhoan") == null) return RedirectToAction("Login", "DocGia");
            //
            if (idchinhanh == 0) return RedirectToAction("Details", "Sach", new { id = id });
            if (HttpContext.Session.GetInt32("LoaiTaiKhoan") == 0)
            {
                if (soSachDangMuon((int)HttpContext.Session.GetInt32("IDDocGia")) >= 5)
                {
                    return RedirectToAction("Details", "Sach", new { id = id });
                }
            }
            else if (HttpContext.Session.GetInt32("LoaiTaiKhoan") == 2)
            {
                if (soSachDangMuon((int)HttpContext.Session.GetInt32("IDDocGia")) >= 3)
                {
                    return RedirectToAction("Details", "Sach", new { id=id});
                }
            }
            var sach = context.Saches.SingleOrDefault(m => m.IDSach == id);
            if (sach == null) return NotFound();
            var nhanVien = (from cn in context.ChiNhanhs
                            join nv in context.NhanViens
                            on cn.IDChiNhanh equals nv.IDChiNhanh
                            where nv.LoaiNhanVien == 0&&cn.IDChiNhanh==idchinhanh
                            select new MuonSach
                            {
                                IDNhanVien=nv.IDNhanVien,
                                TenChiNhanh=cn.TenChiNhanh
                            }).SingleOrDefault();
            var muonSach = new MuonSach()
            {
                IDSach = id,
                IDDocGia = (int)HttpContext.Session.GetInt32("IDDocGia"),
                IDNhanVien = nhanVien.IDNhanVien,
                TenChiNhanh=nhanVien.TenChiNhanh,
                PhiMuon=sach.TienMuon,
                TienCoc=sach.TienMua,
                NgayMuon=DateTime.Now,
                TrangThai=0,
                TinhTrangSach=""
            };
            context.MuonSaches.Add(muonSach);
            context.SaveChanges();
            SachChiNhanh sachChiNhanh = (from scn in context.SachChiNhanhs
                                         where scn.IDChiNhanh == idchinhanh && scn.IDSach == id
                                         select new SachChiNhanh
                                         {
                                             IDSachChiNhanh = scn.IDSachChiNhanh,
                                             IDSach = scn.IDSach,
                                             IDChiNhanh = scn.IDChiNhanh,
                                             TongSoLuong = scn.TongSoLuong,
                                             SoSachCon = scn.SoSachCon
                                         }).SingleOrDefault();
            if (sachChiNhanh.SoSachCon != 0&&sachChiNhanh!=null)
            {
                sachChiNhanh.SoSachCon--;
                context.SachChiNhanhs.Update(sachChiNhanh);
                context.SaveChanges();
            }
            return RedirectToAction("Index","Home");
        }
        public int soSachDangMuon(int id)
        {
            int count = (from ms in context.MuonSaches
                         where ms.IDDocGia == id && ms.TrangThai == 1|| ms.IDDocGia == id && ms.TrangThai == 0
                         select new viewMuonSach
                         {
                             IDPhieu = ms.IDPhieu
                         }).Count();
            return count;
        }
    }
}