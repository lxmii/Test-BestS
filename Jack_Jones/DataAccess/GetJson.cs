using Jack_Jones.Models;
using Jack_Jones.DataAccess;
using Newtonsoft.Json;

namespace Jack_Jones.DataAccess
{
    public class GetJson: IGetJson
    {
        public Root JsonReturn()
        {
            StreamReader r = new StreamReader("..\\test-technical-prep.json");
            Root root= new Root();
            root = JsonConvert.DeserializeObject<Root>(r.ReadToEnd());
            return root;
        }

    }
}
