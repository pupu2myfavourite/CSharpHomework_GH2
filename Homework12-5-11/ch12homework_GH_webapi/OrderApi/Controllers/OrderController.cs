using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OrderApi.Models;

namespace OrderApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class OrderController: ControllerBase{
        private readonly OrderContext orderContext;
        public OrderController(OrderContext context){
            this.orderContext = context;
        }


        [HttpGet("id/{id}")]   
        //Get: api/order/id
        public ActionResult<Order> Get(int id)

        {
            var query = orderContext.orders.FirstOrDefault(o=> o.Id == id);
            return query;
        }

        [HttpGet("client/{client}")]
        public ActionResult<Order> GetOrder(String client){
            var query = orderContext.orders.FirstOrDefault(o => o.Client.Contains(client));
            return query;
        }

        [HttpPost]
        public ActionResult<Order> PostOrder(Order order){
            try{
                orderContext.orders.Add(order);
                orderContext.SaveChanges();
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
                return NotFound();
            }
            return order;
            
        }

        [HttpPut]
        public ActionResult<Order> PutOrder(Order order){
            orderContext.Entry(order).State = EntityState.Modified;
            orderContext.SaveChanges();
            return order;
        }

        [HttpDelete("{field}/{value}")]
        public ActionResult<Order> DeleteOrder(String field, int value){
            Order target = null;
            IQueryable<Order> orders = null;
            List<Order>orderList = null;
            switch(field.ToLower()){
                case("id"):
                    orders = orderContext.orders.Where(o => o.Id == value);
                    orderList = orders.ToList();
                    if(orderList.Count == 0){
                        return NotFound();
                    }
                    target = orderList[0];
                    break;
                case("client"):
                    orders = orderContext.orders.Where(o => o.Id == value);
                    orderList = orders.ToList();
                    if(orderList.Count == 0){
                        return NotFound();
                    }
                    target = orderList[0];
                    break;
            }
            orderContext.orders.Remove(target);
            return target;

        }
    }
    /*
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
    */
}
