using Jack_Jones.Models;
namespace Jack_Jones.Business
{
    public interface IBusinessLayer
    {
        public Root ReturnProducts();
        public Product ReturnID(int iden);
        public List<Product> ReturnCat(string cat);
        public List<Product> ReturnSize(string Size);
    }
}
