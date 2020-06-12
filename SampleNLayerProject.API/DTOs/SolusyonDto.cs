using System.ComponentModel.DataAnnotations;

namespace SampleNLayerProject.API.DTOs
{
    public class SolusyonDto
    {
        /// <summary>
        /// Order Miktarı
        /// </summary>
        [Required]
        public double volume { get; set; }

        /// <summary>
        /// Doktor Tarafından belirlenen miktar
        /// </summary>
        [Required]
        public int doktorMiktar { get; set; }

        /// <summary>
        /// İlaç etken madde grup ID Default 0
        /// </summary>
        [Required]
        public int solusyonTipId { get; set; }

        /// <summary>
        /// Her İlaç ve Etken Madde İçin belirlenmiş Integer Değerdir. Bu liste KurumIlaclari metodu ile elde edile bilir.
        /// </summary>
        [Required]
        public int solusyonId { get; set; }

        /// <summary>
        /// İlaç veya etken madde birimi. Default cc
        /// </summary>
        [Required]
        public string birim { get; set; }
    }
}