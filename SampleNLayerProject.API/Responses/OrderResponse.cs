using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleNLayerProject.API.Responses
{
    public class OrderResponse
    {
        public int Durum { get; set; }
        public int HataKodu { get; set; }
        public string HataMesaji { get; set; }
        public int orderId { get; set; }
    }

    public class OrderResponseList
    {
        public List<OrderResponse> result { get; set; }
    }
}
