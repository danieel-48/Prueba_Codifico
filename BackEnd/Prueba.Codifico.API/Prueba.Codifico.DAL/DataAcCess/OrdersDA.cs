using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prueba.Codifico.ENL.Entities;
using Prueba.Codifico.ENL.EntityDataModel;


namespace Prueba.Codifico.DAL.DataAcCess
{
    public class OrdersDA
    {
        StoreSampleEntities context;
        int DbTimeOut = 3000;

        public List<vw_SalesDatePrediction> Get_SalesPrediction()
        {
            try
            {
                context = new StoreSampleEntities();
                context.Database.CommandTimeout = DbTimeOut;

                var consulta = (from query in context.vw_SalesDatePrediction
                                select query).ToList();

                return consulta;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;

            }
        }
        public void AddNewOrder(AddOrderEN items)
        {
            try
            {
                context = new StoreSampleEntities();
                context.Database.CommandTimeout = DbTimeOut;

                string orderDate = items.Orderdate.ToString("yyyy-MM-dd");
                string requiredDate = items.Requireddate.ToString("yyyy-MM-dd");
                string shippedDate = items.Shippeddate.ToString("yyyy-MM-dd");

                context.sp_AddNewOrder(items.Empid, items.Shipperid, items.Shipname, items.Shipaddress, items.Shipcity, Convert.ToDateTime(orderDate),
                                       Convert.ToDateTime(requiredDate), Convert.ToDateTime(shippedDate), items.Freight, items.Shipcountry, items.Productid, items.Unitprice,
                                       items.Qty, items.Discount);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
