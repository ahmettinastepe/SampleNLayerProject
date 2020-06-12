using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SampleNLayerProject.API.DTOs;
using SampleNLayerProject.API.Responses;
using SampleNLayerProject.Core.Entities;
using SampleNLayerProject.Core.Services;

namespace SampleNLayerProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly ISolusyonService _solusyonService;
        private readonly IMapper _mapper;

        public OrderController(IOrderService orderService, ISolusyonService solusyonService, IMapper mapper)
        {
            _orderService = orderService;
            _solusyonService = solusyonService;
            _mapper = mapper;
        }

        /// <summary>
        /// Return All Orders
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var orders = await _orderService.GetAllAsync();
            return Ok(orders);
        }

        /// <summary>
        /// Yeni Order Ekle/Güncelle
        /// </summary>
        /// <param name="upsertParams">Client Objesi</param>
        [HttpPost("OrderGuncelle")]
        public async Task<IActionResult> Save(UpsertParamsDto upsertParams)
        {
            var orderS = _mapper.Map<OrderS>(upsertParams.upsertParams);
            var order = await _orderService.AddAsync(_mapper.Map<Order>(orderS));
            var solutions = _mapper.Map<List<Solusyon>>(upsertParams.upsertParams.solusyonBilgisi.ToList());

            foreach (var item in solutions)
                item.orderId = order.orderId;

            await _solusyonService.AddRangeAsync(solutions);

            var response = new OrderResponseList()
            {
                result = new List<OrderResponse>()
                {
                    new OrderResponse()
                    {
                        Durum = 1,
                        HataKodu = 0000,
                        HataMesaji = "İşlem Başarılı",
                        orderId = order.orderId
                    }
                }
            };

            return Created(string.Empty, response);
        }

        /// <summary>
        /// Girilen Order ID sine göre Veritabanından İlgili Kaydı Siler.
        /// </summary>
        /// <param name="orderId">Silinecek Id</param>
        /// <returns></returns>
        [HttpDelete("{orderId}")]
        public async Task<IActionResult> Delete(int orderId)
        {
            var entity = await _orderService.GetByIdAsync(orderId);
            _orderService.Remove(entity);

            var response = new OrderResponseList()
            {
                result = new List<OrderResponse>()
                {
                    new OrderResponse()
                    {
                        Durum = 1,
                        HataKodu = 0000,
                        HataMesaji = "İşlem Başarılı"
                    }
                }
            };

            return Ok(response);
        }
    }
}