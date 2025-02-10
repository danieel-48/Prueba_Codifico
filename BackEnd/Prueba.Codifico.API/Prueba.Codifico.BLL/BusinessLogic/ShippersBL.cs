using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prueba.Codifico.DAL.DataAcCess;
using Prueba.Codifico.ENL.EntityDataModel;

namespace Prueba.Codifico.BLL.BusinessLogic
{
    public class ShippersBL
    {
        ShippersDA shippersDA;

        public List<vw_Shippers> Get_Shippers()
        {
            try
            {
                shippersDA = new ShippersDA();
                return shippersDA.Get_Shippers();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;

            }
        }
    }
}
