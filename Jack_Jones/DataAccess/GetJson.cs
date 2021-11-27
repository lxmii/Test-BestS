using Jack_Jones.Models;
using Jack_Jones.DataAccess;
using Newtonsoft.Json;

namespace Jack_Jones.DataAccess
{
    public class GetJsonLocal: IGetData
    {
        public Root DataReturn()
        {
            StreamReader r = new StreamReader("..\\test-technical-prep.json");
            Root root= new Root();
            root = JsonConvert.DeserializeObject<Root>(r.ReadToEnd());
            return root;
        }

    }
    public class GetJsonDB : IGetData
    {
        public Root DataReturn()
        {
            StreamReader r = new StreamReader("..\\test-technical-prep.json");
            Root root = new Root();
            root = JsonConvert.DeserializeObject<Root>(r.ReadToEnd());
            return root;
        }

    }
}
