using Jack_Jones.DataAccess;
using Jack_Jones.Models;

namespace Jack_Jones.Business
{
    public class JackAndJones : IBusinessLayer
    {
        private readonly IGetData _igetdata;

        public JackAndJones(IGetData igetdata)
        {
            _igetdata = igetdata;

        }

        public Root ReturnProducts()

        {
            return _igetdata.DataReturn();
        }
        public Product ReturnID(int iden)

        {
            Product ret = new();


            foreach (Product temp in _igetdata.DataReturn().products)
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
            foreach (Product temp in _igetdata.DataReturn().products)
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
        public List<Product> ReturnSize(string Size)
        {
            List<Product> ret = new List<Product>();
            foreach(Product temp in _igetdata.DataReturn().products)
            {
                foreach(string s in temp.size)
                {
                    if (s == Size)
                    {
                        ret.Add(temp);
                        
                    }
                }
                if(temp.variant!=null)
                {
                    foreach (Variant v in temp.variant)
                    {
                        foreach (string s in v.size)
                        {
                            if (s == Size)
                            {
                                ret.Add(temp);
                            }
                        }
                    }
                }
            }
            return ret;
        }
    }

    public class JinnyAndJohnny : IBusinessLayer
    {
        private readonly IGetData _igetdata;

        public JinnyAndJohnny(IGetData igetdata)
        {
            _igetdata = igetdata;

        }

        public Root ReturnProducts()

        {
            return _igetdata.DataReturn();
        }
        public Product ReturnID(int iden)

        {
            Product ret = new();


            foreach (Product temp in _igetdata.DataReturn().products)
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
            foreach (Product temp in _igetdata.DataReturn().products)
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
        public List<Product> ReturnSize(string Size)
        {
            List<Product> ret = new List<Product>();
            foreach (Product temp in _igetdata.DataReturn().products)
            {
                foreach (string s in temp.size)
                {
                    
                        if (s == Size)
                        { ret.Add(temp); }
                   
                    
                }
            }
            return ret;
        }
    }

}
   