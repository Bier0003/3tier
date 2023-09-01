using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;


namespace BLL
{
    public class studentRepository
    {
        public string GetStudent()
        {
            var DataAccess = new DataAccess();
            return  DataAccess.GetData();

        }


    }
}
