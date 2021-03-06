﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuanLyThuVien.Models;
using QuanLyThuVien.ViewModels;
using static System.Collections.Specialized.BitVector32;

namespace QuanLyThuVien.Controllers
{
    public class DocGiaController : Controller
    {
        private MyDBContext context;
        public DocGiaController()
        {
            context = new MyDBContext();
        }
        /// 
        public IActionResult CheckTaiKhoan(string TaiKhoan)
        {
            var timTaiKhoan = context.DocGias.SingleOrDefault(c => c.TaiKhoan == TaiKhoan);
            if (timTaiKhoan != null)
                return Json(data: "*Tai khoan này đã tồn tại");
            return Json(data: true);

        }
        /////
        public IActionResult Index()
        {
            //phân quyền
            if (HttpContext.Session.GetString("TaiKhoanNv") == null) return RedirectToAction("Login", "NhanVien");
            //
            var docGia = context.DocGias.ToList();
            return View(docGia);
        }
        public IActionResult Edit(int id)
        {
            //phân quyền
            if (HttpContext.Session.GetInt32("IDDocGia") == null) return RedirectToAction("Login", "DocGia");
            //
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var docGia = context.DocGias.SingleOrDefault(m=>m.IDDocGia==id);
            if (docGia == null) return NotFound();
            return View(docGia);
        }
        [HttpPost]
        public IActionResult Edit(DocGia Model)
        {
            if (HttpContext.Session.GetInt32("IDDocGia") == null) return RedirectToAction("Login", "DocGia");
            Model.TaiKhoan =HttpContext.Session.GetString("TaiKhoan");
            context.DocGias.Update(Model);  
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            //phân quyền
            if (HttpContext.Session.GetString("TaiKhoanNv") == null) return RedirectToAction("Login", "NhanVien");
            //
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var docGia = context.DocGias.SingleOrDefault(m => m.IDDocGia == id);
            if (docGia == null) return NotFound();
            context.DocGias.Remove(docGia);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var docGia = context.DocGias.SingleOrDefault(m => m.IDDocGia == id);
            if (docGia == null) return NotFound();
            return View(docGia);
        }
        public IActionResult Create() 
        {
            //phân quyền
            if (HttpContext.Session.GetString("TaiKhoanNv") == null) return RedirectToAction("Login", "NhanVien");
            //
            return View();
        }
        [HttpPost]
        public IActionResult Create(DocGia Model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            context.DocGias.Add(Model);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(DocGiaLogin Model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            DocGiaLogin docGia = (from dg in context.DocGias
                         where dg.TaiKhoan == Model.TaiKhoan && dg.MatKhau == Model.MatKhau
                         select new DocGiaLogin
                         {
                             IDDocGia=dg.IDDocGia,
                             TaiKhoan=dg.TaiKhoan,
                             MatKhau=dg.MatKhau,
                             LoaiDocGia=dg.LoaiDocGia
                         }).SingleOrDefault();
            if(docGia==null)
            {
                ModelState.AddModelError("", "Sai tài khoản hoặc mật khẩu");
                return View();
            }
            else
            {
                HttpContext.Session.SetInt32("IDDocGia", docGia.IDDocGia);
                HttpContext.Session.SetString("TaiKhoan", docGia.TaiKhoan);
                HttpContext.Session.SetString("MatKhau", docGia.MatKhau);
                HttpContext.Session.SetInt32("LoaiTaiKhoan", docGia.LoaiDocGia);
            }
            return RedirectToAction("Details", "DocGia", new { id= docGia.IDDocGia });
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("IDDocGia");
            HttpContext.Session.Remove("TaiKhoan");
            HttpContext.Session.Remove("MatKhau");
            HttpContext.Session.Remove("LoaiTaiKhoan");
            return RedirectToAction("Index","Home");
        }
        public IActionResult DanhSach(int id)
        {
            var danhSachMuon = from ms in context.MuonSaches
                               join s in context.Saches
                               on ms.IDSach equals s.IDSach
                               join nv in context.NhanViens
                               on ms.IDNhanVien equals nv.IDNhanVien
                               join dg in context.DocGias
                               on ms.IDDocGia equals dg.IDDocGia
                               where ms.IDDocGia == id
                               select new viewMuonSach
                               {
                                   IDPhieu = ms.IDPhieu,
                                   TenSach = s.TenSach,
                                   TinhTrangSach = ms.TinhTrangSach,
                                   PhiMuon = ms.PhiMuon,
                                   TienCoc = ms.TienCoc,
                                   NgayMuon = ms.NgayMuon,
                                   TenDocGia = dg.HoTen,
                                   TenNhanVien = nv.HoTen,
                                   TenChiNhanh = ms.TenChiNhanh,
                                   TrangThai = ms.TrangThai
                               };
            return View(danhSachMuon);
        }
    }
}