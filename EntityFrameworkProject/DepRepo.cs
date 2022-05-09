using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkProject
{
    internal class DepRepo
    {
        public void AddDepartament (Departament departament)
        {
            using (var context = new SchoolContext())
            {
                context.Departaments.Add(departament);
                context.SaveChanges();
            }
        }
        public void AddToExistingDepartament (Departament departament)
        {
            using (SchoolContext context = new SchoolContext())
            {
                var departamentFind = context.Departaments.Where(d => d.Name == departament.Name).FirstOrDefault();
                if (departamentFind != null && departamentFind.Name == departament.Name)
                {
                    departament.Id = departamentFind.Id;
                    context.Departaments.Update(departament);
                    context.SaveChanges ();
                }
            }
        }
    }
}
