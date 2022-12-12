using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp3.Context;
using WpfApp3.Models;

namespace WpfApp3.BusinessLogic
{
    public class HumanService
    {
        ApplicationContext applicationContext;
        public HumanService()
        {
            applicationContext = new ApplicationContext();
        }
        public IEnumerable<Human> Get()
        {
            return applicationContext.Humans.ToList();
        }
        public void Add(Human human)
        {
            applicationContext.Humans.Add(human);
            applicationContext.SaveChanges();
        }
        public void Delete(Human human)
        {
            applicationContext.Humans.Remove(human);
            applicationContext.SaveChanges();
        }
        public void Update(Human human)
        {
            applicationContext.Humans.Update(human);
            applicationContext.SaveChanges();
        }
    }
}
