using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Prueba.Codifico.BLL.BusinessLogic;
using Prueba.Codifico.ENL.Entities;
using Prueba.Codifico.ENL.EntityDataModel;


namespace Prueba.Codifico.API.Controllers
{
    public class CustomersController : ApiController
    {
        CustomersBL customersBL;
        OrdersBL ordersBL;
        ProductsBL productsBL;
        ShippersBL shippersBL;
        EmployeesBL employeesBL;

        [HttpGet]
        [Route("api/getsalesprediction")]
        public IHttpActionResult Get_SalesPrediction()
        {
            try
            {
                ordersBL = new OrdersBL();

                var consulta = ordersBL.Get_SalesPrediction();

                if (consulta.Count != 0)
                {
                    return Ok(consulta);
                }
                else
                {
                    return Ok(new
                    {
                        message = "No se encontraron datos"
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return InternalServerError(new Exception("Hubo un problema al procesar su solicitud. Por favor, intente más tarde."));
            }
        }

        [HttpGet]
        [Route("api/getorderscustomers")]
        public IHttpActionResult Get_Orders_Customers(int custid)
       {
            try
            {
                customersBL = new CustomersBL();

                if (custid == null)
                {
                    return BadRequest("Debe ingresar el campo CustId");
                }
                else
                {
                    var consulta = customersBL.Get_Orders_Customers((int)custid);

                    if (consulta.Count != 0)
                    {
                        return Ok(consulta);
                    }
                    else
                    {
                        return Ok(new
                        {
                            message = "No se encontraron datos"
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return InternalServerError(new Exception("Hubo un problema al procesar su solicitud. Por favor, intente más tarde."));
            }
        }

        [HttpGet]
        [Route("api/employees")]
        public IHttpActionResult Get_Employees()
        {
            try
            {
                employeesBL = new EmployeesBL();

                var consulta = employeesBL.Get_Employees();

                if (consulta.Count != 0)
                {
                    return Ok(consulta);
                }
                else
                {
                    return Ok(new
                    {
                        message = "No se encontraron datos"
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return InternalServerError(new Exception("Hubo un problema al procesar su solicitud. Por favor, intente más tarde."));
            }
        }

        [HttpGet]
        [Route("api/shippers")]
        public IHttpActionResult Get_Shippers()
        {
            try
            {
                shippersBL = new ShippersBL();

                var consulta = shippersBL.Get_Shippers();

                if (consulta.Count != 0)
                {
                    return Ok(consulta);
                }
                else
                {
                    return Ok(new
                    {
                        message = "No se encontraron datos"
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return InternalServerError(new Exception("Hubo un problema al procesar su solicitud. Por favor, intente más tarde."));
            }
        }

        [HttpGet]
        [Route("api/products")]
        public IHttpActionResult Get_Products()
        {
            try
            {
                productsBL = new ProductsBL();

                var consulta = productsBL.Get_Products();

                if (consulta.Count != 0)
                {
                    return Ok(consulta);
                }
                else
                {
                    return Ok(new
                    {
                        message = "No se encontraron datos"
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return InternalServerError(new Exception("Hubo un problema al procesar su solicitud. Por favor, intente más tarde."));
            }
        }

        [HttpPost]
        [Route("api/addneworder")]

        public IHttpActionResult AddNewOrder(AddOrderEN item)
        {
            try
            {
                ordersBL = new OrdersBL();

                if (item != null)
                {
                    ordersBL.AddNewOrder(item);

                    return Ok("Orden ingresada correctamente");
                }
                else
                {
                  return BadRequest("Debe ingresar datos");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return InternalServerError(new Exception("Hubo un problema al procesar su solicitud. Por favor, intente más tarde."));
            }
        }
    }
}