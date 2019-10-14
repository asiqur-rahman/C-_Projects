using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Finally.Repository;

namespace Finally.Services
{
    public class TheServices
    {
        TheRepository repository = new TheRepository();
        public Boolean ConnectionBuild(String Import_FileName)
        {
            return repository.ConnectionBuild(Import_FileName);
        }
        public DataTable ShowDetails()
        {
            return repository.ShowDetails();
        }
        public Boolean UpdateDetails(String day,String text, String Import_FileName)
        {
            return repository.UpdateDetails(day,text, Import_FileName);
        }
        public String ShowName(String text)
        {
            return repository.ShowName(text);
        }
        public Boolean Check(String day)
        {
            return repository.Check(day);
        }
    }
}
