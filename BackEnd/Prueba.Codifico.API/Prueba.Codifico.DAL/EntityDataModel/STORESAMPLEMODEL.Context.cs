﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Prueba.Codifico.ENL.EntityDataModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class StoreSampleEntities : DbContext
    {
        public StoreSampleEntities()
            : base("name=StoreSampleEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<vw_Employes> vw_Employes { get; set; }
        public virtual DbSet<vw_Products> vw_Products { get; set; }
        public virtual DbSet<vw_SalesDatePrediction> vw_SalesDatePrediction { get; set; }
        public virtual DbSet<vw_Shippers> vw_Shippers { get; set; }
        public virtual DbSet<vw_OrderClients> vw_OrderClients { get; set; }
    
        public virtual int sp_AddNewOrder(Nullable<int> empid, Nullable<int> shipperid, string shipname, string shipaddress, string shipcity, Nullable<System.DateTime> orderdate, Nullable<System.DateTime> requireddate, Nullable<System.DateTime> shippeddate, Nullable<decimal> freight, string shipcountry, Nullable<int> productid, Nullable<decimal> unitprice, Nullable<short> qty, Nullable<decimal> discount)
        {
            var empidParameter = empid.HasValue ?
                new ObjectParameter("Empid", empid) :
                new ObjectParameter("Empid", typeof(int));
    
            var shipperidParameter = shipperid.HasValue ?
                new ObjectParameter("Shipperid", shipperid) :
                new ObjectParameter("Shipperid", typeof(int));
    
            var shipnameParameter = shipname != null ?
                new ObjectParameter("Shipname", shipname) :
                new ObjectParameter("Shipname", typeof(string));
    
            var shipaddressParameter = shipaddress != null ?
                new ObjectParameter("Shipaddress", shipaddress) :
                new ObjectParameter("Shipaddress", typeof(string));
    
            var shipcityParameter = shipcity != null ?
                new ObjectParameter("Shipcity", shipcity) :
                new ObjectParameter("Shipcity", typeof(string));
    
            var orderdateParameter = orderdate.HasValue ?
                new ObjectParameter("Orderdate", orderdate) :
                new ObjectParameter("Orderdate", typeof(System.DateTime));
    
            var requireddateParameter = requireddate.HasValue ?
                new ObjectParameter("Requireddate", requireddate) :
                new ObjectParameter("Requireddate", typeof(System.DateTime));
    
            var shippeddateParameter = shippeddate.HasValue ?
                new ObjectParameter("Shippeddate", shippeddate) :
                new ObjectParameter("Shippeddate", typeof(System.DateTime));
    
            var freightParameter = freight.HasValue ?
                new ObjectParameter("Freight", freight) :
                new ObjectParameter("Freight", typeof(decimal));
    
            var shipcountryParameter = shipcountry != null ?
                new ObjectParameter("Shipcountry", shipcountry) :
                new ObjectParameter("Shipcountry", typeof(string));
    
            var productidParameter = productid.HasValue ?
                new ObjectParameter("Productid", productid) :
                new ObjectParameter("Productid", typeof(int));
    
            var unitpriceParameter = unitprice.HasValue ?
                new ObjectParameter("Unitprice", unitprice) :
                new ObjectParameter("Unitprice", typeof(decimal));
    
            var qtyParameter = qty.HasValue ?
                new ObjectParameter("Qty", qty) :
                new ObjectParameter("Qty", typeof(short));
    
            var discountParameter = discount.HasValue ?
                new ObjectParameter("discount", discount) :
                new ObjectParameter("discount", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_AddNewOrder", empidParameter, shipperidParameter, shipnameParameter, shipaddressParameter, shipcityParameter, orderdateParameter, requireddateParameter, shippeddateParameter, freightParameter, shipcountryParameter, productidParameter, unitpriceParameter, qtyParameter, discountParameter);
        }
    }
}
