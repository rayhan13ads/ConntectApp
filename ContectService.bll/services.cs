using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contect.Dal;
using ContectModel;

namespace ContectService.bll
{
    public static class services
    {
         static IContectRepository repository;

         static services()
        {
            repository = new ContectRepository();
        }

       public static List<ContectTable> GetAll()
        {
           return repository.GetAll();
        }

       public static ContectTable GetById(int Id)
        {
            return repository.GetById(Id);
        }
        public static ContectTable Insert(ContectTable obj)
        {
            return repository.Insert(obj);
        }
        public static void Update(ContectTable obj)
        {
            repository.Update(obj);
        }
        public static void Delete(ContectTable obj)
        {
            repository.Delete(obj);
        }
    }
}
