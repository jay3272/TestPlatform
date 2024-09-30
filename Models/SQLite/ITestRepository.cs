using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestPlatform.Models;

namespace TestPlatform.Models.SQLite
{
    public interface ITestRepository
    {
        void Add(TestModel testModel);
        void Edit(TestModel testModel);
        void Delete(int id);
        IEnumerable<TestModel> GetAll();
        IEnumerable<TestModel> GetByValue(string value);//Searchs
    }
}
