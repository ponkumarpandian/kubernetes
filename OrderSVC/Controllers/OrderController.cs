//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using BuildingBlocks.EventBus;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using OrderSVC.Events;
//using OrderSVC.Models;

//namespace OrderSVC.Controllers
//{
//    [Route("api/[controller]")]
//    public class OrderController : Controller
//    {
//        private readonly IEventBus _eventBus;

//        public OrderController(IEventBus eventBus)
//        {
//            _eventBus = eventBus;
//        }
        
//        //[HttpPost]
//        //public ActionResult Create([FromBody] order orderinfo)
//        //{


//        //    //// publish to event that order has been created.
//        //    //_eventBus.Publish(new OrderConfirmationIntegrationEvent(orderinfo));

//        //    //    return new JsonResult(new { orderid = orderinfo.orderId, result = "OK" });
           
//        }

       
//    }
//}