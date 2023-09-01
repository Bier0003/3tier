using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class DataAccess
    {
        public string GetData() 
        {
            string data = File.ReadAllText("C:\\Users\\b\\projektASP\\3tier\\DAL\\MOCK_DATA.json");
            return data;
        }
    }
}
