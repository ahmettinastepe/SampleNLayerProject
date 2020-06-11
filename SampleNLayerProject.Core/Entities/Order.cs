using SampleNLayerProject.Core.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace SampleNLayerProject.Core.Entities
{
    public class Order : IEntity
    {
        public int orderId { get; set; }
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
        // solusyonVerilisSekli
        // solusyonBilgisi
        public ICollection<Solusyon> solusyonBilgisi { get; set; }
    }
}