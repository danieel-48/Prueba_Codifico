using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prueba.Codifico.DAL.DataAcCess;
using Prueba.Codifico.ENL.EntityDataModel;

namespace Prueba.Codifico.BLL.BusinessLogic
{
    public class ProductsBL
    {
        ProductsDA productsDA;
        public List<vw_Products> Get_Products()
        {
            try
            {
                productsDA = new ProductsDA();
                return productsDA.Get_Products();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;

            }
        }
    }
}
