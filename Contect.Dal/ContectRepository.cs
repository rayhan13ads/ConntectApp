using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContectModel;

namespace Contect.Dal
{
    public class ContectRepository : IContectRepository
    {
        public void Delete(ContectTable obj)
        {
            using (ContectEntities db = new ContectEntities())
            {
                db.ContectTables.Attach(obj);
                db.ContectTables.Remove(obj);
                db.SaveChanges();
            }
        } 

        public ContectTable Insert(ContectTable obj)
        {
            using (ContectEntities db = new ContectEntities())
            {
                db.ContectTables.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

       

        public void Update(ContectTable obj)
        {
            using (ContectEntities db = new ContectEntities())
            {
                db.ContectTables.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges(); 
            }
        }

      
        List<ContectTable> IContectRepository.GetAll()
        {
            using (ContectEntities db = new ContectEntities())
            {
                return db.ContectTables.ToList();
            }
        }

        ContectTable IContectRepository.GetById(int Id)
        {
            using (ContectEntities db = new ContectEntities())
            {
                return db.ContectTables.Find(Id);
            }
        }
    }
}
