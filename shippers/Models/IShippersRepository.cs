using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shippers.Models
{
    interface IShippersRepository
    {
        void Insert(Shippers shippers);
        void Delete(Shippers shippers);
        void Update(Shippers shippers);
        IEnumerable<Shippers> GetAll();
        Shippers GetOne(int id);
    }
}
