using SampleNLayerProject.Core.Entities.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace SampleNLayerProject.Core.Entities
{
    public class Solusyon : IEntity
    {
        public int id { get; set; }
        public int orderId { get; set; }
        public double volume { get; set; }
        public int doktorMiktar { get; set; }
        public int solusyonTipId { get; set; }
        public int solusyonId { get; set; }
        public string birim { get; set; }

        public virtual Order order { get; set; }
    }
}