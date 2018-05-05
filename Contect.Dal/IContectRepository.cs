using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContectModel;

namespace Contect.Dal
{
   public interface IContectRepository
    {
        List<ContectTable> GetAll();
        ContectTable GetById(int Id);
        ContectTable Insert(ContectTable obj);
        void Update(ContectTable obj);
        void Delete(ContectTable obj);
    }
}
