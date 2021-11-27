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
        IBusinessLayer newLayer = new JackAndJones(new GetJsonLocal());
        [Route("api/all")]
        [HttpGet]
        public Root Get()
        {
            return newLayer.ReturnProducts();
        }



        [Route("api/ID/{ide}")]
        [HttpGet]
        public Product GetID(int ide)
        {
            return newLayer.ReturnID(ide);
        }

        [Route("api/category/{cat}")]
        [HttpGet]
        public List<Product> GetPCat(string cat)
        {
            return newLayer.ReturnCat(cat);

        }
        [Route("api/size/{str}")]
        [HttpGet]
        public List<Product> GetS(string str)
        {
            return newLayer.ReturnSize(str);

        }
    }
}