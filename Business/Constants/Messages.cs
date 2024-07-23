using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants;

public static class Messages
{
    public static string ProductAdded = "Ürün başarıyla eklendi";
    public static string ProductDeleted = "Ürün başarıyla silindi";
    public static string ProductUpdated = "Ürün başarıyla güncellendi";
    public static string ProductNameInvalid = "Ürün ismi geçersiz";
    public static string MaintenanceTime = "Sistem bakımda";
    public static string ProductsListed = "Ürünler Listelendi";
    public static string ProductCountOfCategoryError = "Kategori sayısı aşıldı(15'dan fazla olamaz)";
    public static string ProductNameAlreadyExists = "Aynı isimde ürün mevcut!";
    public static string CategoryLimitExceeded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor.";
    public static string AuthorizationDenied = "Yetkiniz yok.";
    public static string AccessTokenCreated = "Token oluşturuldu";
}
