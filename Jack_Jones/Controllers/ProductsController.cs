using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Jack_Jones.Models;
using Jack_Jones.Business;
using Jack_Jones.DataAccess;


namespace Jack_Jones.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IBusinessLayer newLayer = new Allproduct(new GetJson());
        [Route("api/all")]
        [HttpGet]
        public Root Get()
        {
           return newLayer.ReturnProducts();
        }
        //IBusinessLayer newLayer = new ReturnID(new GetJson());


        [Route("api/{ide}")]
        [HttpGet]
        public Product GetID(int ide)
        {
            return newLayer.ReturnID(ide);
        }

        [Route("api/all/{cat}")]
        [HttpGet]
        public List<Product> GetPCat(string cat)
        {
            return newLayer.ReturnCat(cat);
        }

    }
}