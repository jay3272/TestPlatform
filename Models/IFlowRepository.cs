using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPlatform.Models
{
   public interface IFlowRepository
    {
        void Add(FlowModel flowModel);
        void Edit(FlowModel flowModel);
        void Delete(int id);
        IEnumerable<FlowModel> GetAll();
        IEnumerable<FlowModel> GetByValue(string value);//Searchs
    }
}
