using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Prueba.Codifico.ENL.EntityDataModel;

namespace Prueba.Codifico.DAL.DataAcCess
{
    public class EmployesDA
    {
        StoreSampleEntities context;
        int DbTimeOut = 3000;
        public List<vw_Employes> Get_Employees()
        {
            try
            {
                context = new StoreSampleEntities();
                context.Database.CommandTimeout = DbTimeOut;

                var consulta = (from query in context.vw_Employes
                                select query).ToList();

                return consulta;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;

            }
        }
    }
}
