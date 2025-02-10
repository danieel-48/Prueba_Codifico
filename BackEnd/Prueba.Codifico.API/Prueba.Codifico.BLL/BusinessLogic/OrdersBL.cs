using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prueba.Codifico.DAL.DataAcCess;
using Prueba.Codifico.ENL.Entities;
using Prueba.Codifico.ENL.EntityDataModel;


namespace Prueba.Codifico.BLL.BusinessLogic
{
    public class OrdersBL
    {
        OrdersDA ordersDA;
        public List<vw_SalesDatePrediction> Get_SalesPrediction()
        {
            try
            {
                ordersDA = new OrdersDA();
                return ordersDA.Get_SalesPrediction();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;

            }
        }
        public void AddNewOrder (AddOrderEN items)
        {
            try
            {
                ordersDA = new OrdersDA();
                ordersDA.AddNewOrder(items);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
