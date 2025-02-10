using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Prueba.Codifico.DAL.DataAcCess;
using Prueba.Codifico.ENL.EntityDataModel;

namespace Prueba.Codifico.BLL.BusinessLogic
{
    public class CustomersBL
    {
        CustomersDA customersDA;
        public List<vw_OrderClients> Get_Orders_Customers(int custid)
        {
            try
            {
                customersDA = new CustomersDA();
                return customersDA.Get_Orders_Customers(custid);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;

            }
        }
    }
}
