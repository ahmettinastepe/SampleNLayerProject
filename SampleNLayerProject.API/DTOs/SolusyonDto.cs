namespace SampleNLayerProject.API.DTOs
{
    public class SolusyonDto
    {
        /// <summary>
        /// Order Miktarı
        /// </summary>
        public double volume { get; set; }

        /// <summary>
        /// Doktor Tarafından belirlenen miktar
        /// </summary>
        public int doktorMiktar { get; set; }

        /// <summary>
        /// İlaç etken madde grup ID Default 0
        /// </summary>
        public int solusyonTipId { get; set; }

        /// <summary>
        /// Her İlaç ve Etken Madde İçin belirlenmiş Integer Değerdir. Bu liste KurumIlaclari metodu ile elde edile bilir.
        /// </summary>
        public int solusyonId { get; set; }

        /// <summary>
        /// İlaç veya etken madde birimi. Default cc
        /// </summary>
        public string birim { get; set; }
    }
}