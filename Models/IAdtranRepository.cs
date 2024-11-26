using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPlatform.Models
{
   public interface IAdtranRepository
    {
        void Add(AdtranModel adtranModel);
        void Edit(AdtranModel adtranModel);
        void Delete(int id);
        IEnumerable<AdtranModel> GetAll();
        IEnumerable<AdtranModel> GetByValue(string value);//Searchs
    }
}
