using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string CompanyAdded = "Firma Eklendi";
        public static string ReceiptNameInvalid = "Fiş ismi geçersiz";
        public  static string  MaintenanceTime = "Şuan sistem bakımdadır.";
        public static string ReceiptListed = "Fişler Listelendi";
        public static string ReceiptAdded = "Fis Eklendi";
        public static string ReceiptNoAlreadyExists="Bu koda ait bir fiş zaten var";
        public static string AuthorizationDenied = "Buna yetkiniz yok.";

        public static string ReceiptDeleted ="Fiş Silindi";
        public static string ReceiptUpdated = "Güncellendi"; 
    }
}
