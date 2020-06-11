using System;
using System.Collections.Generic;

namespace SampleNLayerProject.API.DTOs
{
    public class OrderDto
    {
        /// <summary>
        /// Nutrisoft tarafından üretilen Integer değerdir. 0 (Sıfır) gönderilince yeni order kayıt anlamına gelir. 0‘dan farklı bir değer gönderilirse mevcut order düzeltme anlamına gelir.
        /// </summary>
        public int orderId { get; set; }

        /// <summary>
        /// Kurum tarında HBYS otomasyonu tarafından verilen tekil INTERGER degerdir.
        /// </summary>
        public int dosyaNo { get; set; }

        /// <summary>
        /// Kişi TC kimlik numarası
        /// </summary>
        public int hastaTCKimlikNo { get; set; }

        /// <summary>
        /// Hasta Adı
        /// </summary>
        public string hastaAdi { get; set; }

        /// <summary>
        /// Hasta Soyadı
        /// </summary>
        public string hastaSoyadi { get; set; }

        /// <summary>
        /// Order Tarihi ve Saati
        /// </summary>
        public DateTime orderTarihSaat { get; set; }

        /// <summary>
        /// Hasta Tipi [1:Yeni Doğan,2:bebek,3:Yetişkin]
        /// </summary>
        public int hastaTipi { get; set; }

        /// <summary>
        /// Bu değer order için hatpayı miktarını belirtir.
        /// </summary>
        public int artirimOrani { get; set; }

        /// <summary>
        /// Order Talep edilen Hastane Bölüm Adı
        /// </summary>
        public string klinikAdi { get; set; }

        /// <summary>
        /// Order Veren Doktor Adı Soyadı
        /// </summary>
        public string orderVerenDoktorAdSoyad { get; set; }

        /// <summary>
        /// Hasta Doğum Tarihi
        /// </summary>
        public DateTime dogumTarihi { get; set; }

        /// <summary>
        /// Hasta kilo(Gram)
        /// </summary>
        public double kilo { get; set; }

        /// <summary>
        /// Hasta Cinsiyeti [1:Erkek,2:Kadın]
        /// </summary>
        public int cinsiyet { get; set; }

        /// <summary>
        /// Array olarak verilecektir.
        /// </summary>
        public ICollection<SolusyonDto> solusyonBilgisi { get; set; }
    }

    public class OrderS
    {
        public int dosyaNo { get; set; }
        public int hastaTCKimlikNo { get; set; }
        public string hastaAdi { get; set; }
        public string hastaSoyadi { get; set; }
        public DateTime orderTarihSaat { get; set; }
        public int hastaTipi { get; set; }
        public int artirimOrani { get; set; }
        public string klinikAdi { get; set; }
        public string orderVerenDoktorAdSoyad { get; set; }
        public DateTime dogumTarihi { get; set; }
        public double kilo { get; set; }
        public int cinsiyet { get; set; }
    }
}