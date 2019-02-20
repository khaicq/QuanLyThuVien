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
    public class QuanLyController : Controller
    {
        private MyDBContext context;
        public QuanLyController()
        {
            context = new MyDBContext();
        }

        public IActionResult Index()
        {
            //phân quyền
            if (HttpContext.Session.GetInt32("IDNhanVien") == null) return RedirectToAction("Login", "NhanVien");
            //
            return View();
        }
        public IActionResult XuLy(int? id)
        {
            //phân quyền
            if (HttpContext.Session.GetInt32("IDNhanVien") == null) return RedirectToAction("Login", "NhanVien");
            //
            int id0;
            if (id == null)
            {
                if (Request.Form["key"] == "")
                {
                    ModelState.AddModelError("", "Chưa nhập mã nhân viên");
                    return RedirectToAction("Index", "DocGia");
                }
                id = Int32.Parse(Request.Form["key"]);
            }
            else id0 = (int)id;

            var docGia = context.DocGias.SingleOrDefault(m => m.IDDocGia == id);
            if (docGia == null) return NotFound();
            ViewBag.IDDocGia = id;
            var danhSachMuon = (from ms in context.MuonSaches
                               join s in context.Saches
                               on ms.IDSach equals s.IDSach
                               join nv in context.NhanViens
                               on ms.IDNhanVien equals nv.IDNhanVien
                               join dg in context.DocGias
                               on ms.IDDocGia equals dg.IDDocGia
                               where ms.IDDocGia == id&&ms.TrangThai!=2
                               select new viewMuonSach
                               {
                                   IDPhieu = ms.IDPhieu,
                                   TenSach = s.TenSach,
                                   LoaiDocGia=dg.LoaiDocGia,
                                   TinhTrangSach = ms.TinhTrangSach,
                                   PhiMuon = ms.PhiMuon,
                                   TienCoc = ms.TienCoc,
                                   NgayMuon = ms.NgayMuon,
                                   TenDocGia = dg.HoTen,
                                   TenNhanVien = nv.HoTen,
                                   TenChiNhanh = ms.TenChiNhanh,
                                   TrangThai = ms.TrangThai,
                               }).ToList();
            return View(danhSachMuon);
        }
        public IActionResult GiaoSach(int id)
        {
            //phân quyền
            if (HttpContext.Session.GetInt32("IDNhanVien") == null) return RedirectToAction("Login", "NhanVien");
            //
            var muonSach = context.MuonSaches.SingleOrDefault(m => m.IDPhieu == id);
            if (muonSach == null) return NotFound();
            int type = context.DocGias.SingleOrDefault(m => m.IDDocGia == muonSach.IDDocGia).LoaiDocGia;
            if (type == 0)
            {
                if (soSachMuonTrongNam(muonSach.IDDocGia) < 5)
                {
                    muonSach.NgayMuon = DateTime.Now;
                    muonSach.TrangThai = 1;
                    context.MuonSaches.Update(muonSach);
                    context.SaveChanges();
                }
                else ModelState.AddModelError("", "Không đủ điều kiện mượn sách");
            }
            if (type == 1)
            {
                muonSach.NgayMuon = DateTime.Now;
                muonSach.TrangThai = 1;
                muonSach.NgayTra = muonSach.NgayMuon.AddDays(7);
                context.MuonSaches.Update(muonSach);
                context.SaveChanges();
            }
            if (type == 2)
            {
                if (soSachDangMuon(muonSach.IDDocGia) < 3)
                {
                    muonSach.NgayMuon = DateTime.Now;
                    muonSach.TrangThai = 1;
                    context.MuonSaches.Update(muonSach);
                    context.SaveChanges();
                }
                else ModelState.AddModelError("", "Không đủ điều kiện mượn sách");
            }
            return RedirectToAction("XuLy", "QuanLy", new { id=muonSach.IDDocGia});
        }
        public IActionResult NhanSach(int id)
        {
            //phân quyền
            if (HttpContext.Session.GetInt32("IDNhanVien") == null) return RedirectToAction("Login", "NhanVien");
            //
            var muonSach = context.MuonSaches.SingleOrDefault(m => m.IDPhieu == id);
            if (muonSach == null) return NotFound();
            int type = context.DocGias.SingleOrDefault(m => m.IDDocGia == muonSach.IDDocGia).LoaiDocGia;
            if (type == 0)
            {
                if (soSachDangMuon(muonSach.IDDocGia) < 7)
                {
                    muonSach.NgayTraThuc = DateTime.Now;
                    muonSach.TrangThai = 2;
                    context.MuonSaches.Update(muonSach);
                    context.SaveChanges();
                }
                else ModelState.AddModelError("", "Không đủ điều kiện mượn sách");
            }
            if (type == 1)
            {
                muonSach.NgayTraThuc = DateTime.Now;
                muonSach.TrangThai = 2;
                context.MuonSaches.Update(muonSach);
                context.SaveChanges();
            }
            if (type == 2)
            {
                if (soSachDangMuon(muonSach.IDDocGia) < 4)
                {
                    muonSach.NgayTraThuc= DateTime.Now;
                    muonSach.TrangThai = 2;
                    context.MuonSaches.Update(muonSach);
                    context.SaveChanges();
                }
                else ModelState.AddModelError("", "Không đủ điều kiện mượn sách");
            }
            return RedirectToAction("XuLy", "QuanLy", new { id = muonSach.IDDocGia });
        }
        public IActionResult GiaoHet(int id)
        {
            //phân quyền
            if (HttpContext.Session.GetInt32("IDNhanVien") == null) return RedirectToAction("Login", "NhanVien");
            //
            var muonSach = context.MuonSaches.Where(m=>m.IDDocGia==id&&m.TrangThai!=2).ToList();
            foreach(var item in muonSach)
            {
                int type = context.DocGias.SingleOrDefault(m => m.IDDocGia == item.IDDocGia).LoaiDocGia;
                if (type == 0)
                {

                    item.NgayMuon = DateTime.Now;
                    item.TrangThai = 1;
                    context.MuonSaches.Update(item);
                    context.SaveChanges();
                }
                if (type == 1)
                {
                    item.NgayMuon = DateTime.Now;
                    item.TrangThai = 1;
                    item.NgayTra = item.NgayMuon.AddDays(7);
                    context.MuonSaches.Update(item);
                    context.SaveChanges();
                }
                if (type == 2)
                {
                    item.NgayMuon = DateTime.Now;
                    item.TrangThai = 1;
                    context.MuonSaches.Update(item);
                    context.SaveChanges();

                }
            }
            return RedirectToAction("XuLy", "QuanLy", new { id=id});
        }
        public IActionResult NhanHet(int id)
        {
            //phân quyền
            if (HttpContext.Session.GetInt32("IDNhanVien") == null) return RedirectToAction("Login", "NhanVien");
            //
            var muonSach = context.MuonSaches.Where(m => m.IDDocGia == id).ToList();
            foreach(var item in muonSach){
                int type = context.DocGias.SingleOrDefault(m => m.IDDocGia == item.IDDocGia).LoaiDocGia;
                if (type == 0)
                {

                    item.NgayTraThuc = DateTime.Now;
                    item.TrangThai = 2;
                    context.MuonSaches.Update(item);
                    context.SaveChanges();
     
                }
                if (type == 1)
                {
                    item.NgayTraThuc = DateTime.Now;
                    item.TrangThai = 2;
                    context.MuonSaches.Update(item);
                    context.SaveChanges();
                }
                if (type == 2)
                {
                    item.NgayTraThuc = DateTime.Now;
                    item.TrangThai = 2;
                    context.MuonSaches.Update(item);
                    context.SaveChanges();
                }
            }
            return RedirectToAction("XuLy", "QuanLy", new { id = id });
        }

       
        public IActionResult ThongKe(int? id)
        {
            //phân quyền
            if (HttpContext.Session.GetInt32("IDNhanVien") == null) return RedirectToAction("Login", "NhanVien");
            //
            int? idcn = HttpContext.Session.GetInt32("IDChiNhanh");
            List<viewMuonSach> ThongKe;
            if (id == null)
            {
                ThongKe = (from ms in context.MuonSaches
                           join s in context.Saches
                           on ms.IDSach equals s.IDSach
                           join dg in context.DocGias
                           on ms.IDDocGia equals dg.IDDocGia
                           join nv in context.NhanViens
                           on ms.IDNhanVien equals nv.IDNhanVien
                           join cn in context.ChiNhanhs
                           on nv.IDChiNhanh equals cn.IDChiNhanh
                           join l in context.LoaiSaches
                           on s.IDLoai equals l.IDLoai
                           where cn.IDChiNhanh == idcn
                            select new viewMuonSach
                            {
                                TenChiNhanh = cn.TenChiNhanh,
                                IDPhieu = ms.IDPhieu,
                                TenDocGia = dg.HoTen,
                                TenSach = s.TenSach,
                                TenLoai = l.TenLoai,
                                TenNhanVien = nv.HoTen,
                                PhiMuon = ms.PhiMuon,
                                TienCoc = ms.TienCoc,
                                NgayMuon = ms.NgayMuon

                            }).ToList();
            }
            else
            {
                ThongKe = (from ms in context.MuonSaches
                           join s in context.Saches
                           on ms.IDSach equals s.IDSach
                           join dg in context.DocGias
                           on ms.IDDocGia equals dg.IDDocGia
                           join nv in context.NhanViens
                           on ms.IDNhanVien equals nv.IDNhanVien
                           join cn in context.ChiNhanhs
                           on nv.IDChiNhanh equals cn.IDChiNhanh
                           join l in context.LoaiSaches
                           on s.IDLoai equals l.IDLoai
                           where cn.IDChiNhanh == idcn &&ms.TrangThai==id
                           select new viewMuonSach
                           {
                               TenChiNhanh = cn.TenChiNhanh,
                               IDPhieu = ms.IDPhieu,
                               TenDocGia = dg.HoTen,
                               TenSach = s.TenSach,
                               TenLoai = l.TenLoai,
                               TenNhanVien = nv.HoTen,
                               PhiMuon = ms.PhiMuon,
                               TienCoc = ms.TienCoc,
                               NgayMuon = ms.NgayMuon,
                               TrangThai=ms.TrangThai

                           }).ToList();
            }
            ViewBag.TenChiNhanh = context.ChiNhanhs.SingleOrDefault(m => m.IDChiNhanh == HttpContext.Session.GetInt32("IDChiNhanh")).TenChiNhanh;
            return View(ThongKe);

        }
        /// //////////////////////////////////////////////////////////

        public int soSachDangMuon(int id)
        {
            int count = (from ms in context.MuonSaches
                         where ms.IDDocGia == id && ms.TrangThai == 1
                         select new viewMuonSach
                         {
                             IDPhieu = ms.IDPhieu
                         }).Count();
            return count;
        }
        public int soSachMuonTrongNam(int id)
        {
            int count = (from ms in context.MuonSaches
                         where ms.IDDocGia == id && ms.NgayMuon.Year == DateTime.Now.Year
                         select new viewMuonSach
                         {
                             IDPhieu = ms.IDPhieu
                         }).Count();
            return count;
        }
    }
}