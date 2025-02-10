using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prueba.Codifico.DAL.DataAcCess;
using Prueba.Codifico.ENL.EntityDataModel;

namespace Prueba.Codifico.BLL.BusinessLogic
{
    public class EmployeesBL
    {
        EmployesDA employesDA;
        public List<vw_Employes> Get_Employees()
        {
            try
            {
                employesDA = new EmployesDA();
                return employesDA.Get_Employees();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;

            }
        }
    }
}
