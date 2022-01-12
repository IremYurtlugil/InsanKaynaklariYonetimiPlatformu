﻿using InsanKaynaklariYonetimiPlatformu.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsanKaynaklariYonetimiPlatformu.UI.Controllers
{
    public class ManagerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

       
        [HttpGet]
        public IActionResult Login()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Login(ManagerLoginVM manager)
        {
            //loginvm gelecek ve isvalid kontrolü yapılacak
             //böyle bir kullanıcı var mı konrolü yapılacak
             //kullanıcının company isapprovali true mu kontrolü yapılacak
             //false ise kullanıcıya önce şirket mailinden doğrulama yapılmalıdır uyarısı verilecek
             //true ise kullanıcı is active mi kontrolü yapılacak
             //true ise kullanıcı managerindex'e yönlendirilecek
             //false ise kullanıcıya uyarı gönderilecek
            return View();
        }


        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(ManagerRegisterVM register)
        {
            //Vm buraya gelecek isvalid kontrolü yapılacak
            //Böyle bir kullanıcı zaten var mı kontrolü yapılacak
            //Company ve manager oluşturulacak anca manager is active=false, company isapproval=false olarak
            //Şirket mailine doğrulama maili atılacak (Şifre veya link olarak? link olursa yanına mutlaka şirket ıdsi eklenecek)
            //Şirket mailine giden kodu onaylayınız sayfası gelecek.
            
            return View();
        }

    }
}
