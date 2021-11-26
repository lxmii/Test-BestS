using Jack_Jones.DataAccess;
using Jack_Jones.Models;
namespace Jack_Jones.Business
{
    public class Allproduct : IBusinessLayer
    {
        private readonly IGetJson _igetjson;
      
        public Allproduct(IGetJson igetjson)
        { 
            _igetjson = igetjson;   
        }
        
        public Root ReturnProducts()
        
        {
            return _igetjson.JsonReturn();
        }
        public Product ReturnID(int iden)

        {
            Product ret = new();


            foreach (Product temp in _igetjson.JsonReturn().products)
            {
                if ((temp.id == iden))
                {
                    ret = temp;
                }
            }
            return ret;
        }
        public List<Product> ReturnCat(string cat)

        {
           
            List<Product> ret = new List<Product>();
            foreach (Product temp in _igetjson.JsonReturn().products)
            {
                foreach (string s in temp.categories)
                {
                    if (s == cat)
                    {
                        ret.Add(temp);
                    }
                }
            }

            return ret;
        }
    }


}
   