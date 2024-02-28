﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaptchaMvc.HtmlHelpers;

namespace EntityLayer.Entities
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Bu Alan Boş Geçilemez")]
        [Display(Name = "Ad")]
        [StringLength(50, ErrorMessage = "Max 50 karakter olmak zorundadır")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Bu Alan Boş Geçilemez")]
        [Display(Name = "Soyad")]
        [StringLength(50, ErrorMessage = "Max 50 karakter olmak zorundadır")]
        public string SurName { get; set; }
        //[Required(ErrorMessage = "Bu Alan Boş Geçilemez")]
        //[Display(Name = "Email")]
        //[StringLength(50, ErrorMessage = "Max 50 karakter olmak zorundadır")]
        //[EmailAddress(ErrorMessage = "E-mail Formatını Doğru Giriniz.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Bu Alan Boş Geçilemez")]
        [Display(Name = "Kullanıcı Adı")]
        [StringLength(50, ErrorMessage = "Max 50 karakter olmak zorundadır")]
        public string UserName { get; set; }
        //[Required(ErrorMessage = "Bu Alan Boş Geçilemez")]
        //[Display(Name = "Kullanıcı Şifresi")]
        //[StringLength(10, ErrorMessage = "Max 10 karakter olmak zorundadır")]
        //[DataType(DataType.Password)]
        public string Password { get; set; }
        //[Required(ErrorMessage = "Bu Alan Boş Geçilemez")]
        //[Display(Name = "Kullanıcı Şifresi Tekrarı")]
        //[StringLength(10, ErrorMessage = "Max 10 karakter olmak zorundadır")]
        //[DataType(DataType.Password)]
        //[Compare("Password", ErrorMessage = "Şifreler Uyuşmuyor")]
        public string RePassword { get; set; }
        [StringLength(10, ErrorMessage = "Max 10 karakter olmak zorundadır")]
        public string Role { get; set; }
    }
}
