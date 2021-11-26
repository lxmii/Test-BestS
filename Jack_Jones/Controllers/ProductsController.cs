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
        [HttpGet]
        public Root Get()
        {
           return newLayer.ReturnProducts();
        }
        //IBusinessLayer newLayer = new ReturnID(new GetJson());
        [HttpGet("id")]
        public Product GetID(int ide)
        {
            return newLayer.ReturnID(ide);
        }
        [HttpGet("categories")]
        public List<Product> GetPCat(string ide)
        {
            return newLayer.ReturnCat(ide);
        }

    }
}