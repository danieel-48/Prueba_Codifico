using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prueba.Codifico.ENL.EntityDataModel;

namespace Prueba.Codifico.DAL.DataAcCess
{
    public class ProductsDA
    {
        StoreSampleEntities context;
        int DbTimeOut = 3000;
        public List<vw_Products> Get_Products()
        {
            try
            {
                context = new StoreSampleEntities();
                context.Database.CommandTimeout = DbTimeOut;

                var consulta = (from query in context.vw_Products
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
