﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Api_Tienda_Virtual.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class TiendaVirtualEntitie : DbContext
    {
        public TiendaVirtualEntitie()
            : base("name=TiendaVirtualEntitie")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Carrito> Carrito { get; set; }
        public virtual DbSet<categorias> categorias { get; set; }
        public virtual DbSet<DetalleVenta> DetalleVenta { get; set; }
        public virtual DbSet<Estatus> Estatus { get; set; }
        public virtual DbSet<Productos> Productos { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<usuario> usuario { get; set; }
        public virtual DbSet<Ventas> Ventas { get; set; }
    
        public virtual ObjectResult<PS_GET_PRODUCTOS_CARRITO_Result> PS_GET_PRODUCTOS_CARRITO(Nullable<int> iDUSUARIO)
        {
            var iDUSUARIOParameter = iDUSUARIO.HasValue ?
                new ObjectParameter("IDUSUARIO", iDUSUARIO) :
                new ObjectParameter("IDUSUARIO", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PS_GET_PRODUCTOS_CARRITO_Result>("PS_GET_PRODUCTOS_CARRITO", iDUSUARIOParameter);
        }
    
        public virtual int SP_AGREGAR_CARRITO(Nullable<int> iDUSUARIO, Nullable<int> iDPRODUCTO, Nullable<int> cANTIDADCOMPRAR)
        {
            var iDUSUARIOParameter = iDUSUARIO.HasValue ?
                new ObjectParameter("IDUSUARIO", iDUSUARIO) :
                new ObjectParameter("IDUSUARIO", typeof(int));
    
            var iDPRODUCTOParameter = iDPRODUCTO.HasValue ?
                new ObjectParameter("IDPRODUCTO", iDPRODUCTO) :
                new ObjectParameter("IDPRODUCTO", typeof(int));
    
            var cANTIDADCOMPRARParameter = cANTIDADCOMPRAR.HasValue ?
                new ObjectParameter("CANTIDADCOMPRAR", cANTIDADCOMPRAR) :
                new ObjectParameter("CANTIDADCOMPRAR", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_AGREGAR_CARRITO", iDUSUARIOParameter, iDPRODUCTOParameter, cANTIDADCOMPRARParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int SP_SUMAR_CARRITO(Nullable<int> iDUSUARIO_, Nullable<int> iDPRODUCTO_, Nullable<int> cANTIDADCOMPRA_R)
        {
            var iDUSUARIO_Parameter = iDUSUARIO_.HasValue ?
                new ObjectParameter("IDUSUARIO_", iDUSUARIO_) :
                new ObjectParameter("IDUSUARIO_", typeof(int));
    
            var iDPRODUCTO_Parameter = iDPRODUCTO_.HasValue ?
                new ObjectParameter("IDPRODUCTO_", iDPRODUCTO_) :
                new ObjectParameter("IDPRODUCTO_", typeof(int));
    
            var cANTIDADCOMPRA_RParameter = cANTIDADCOMPRA_R.HasValue ?
                new ObjectParameter("CANTIDADCOMPRA_R", cANTIDADCOMPRA_R) :
                new ObjectParameter("CANTIDADCOMPRA_R", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_SUMAR_CARRITO", iDUSUARIO_Parameter, iDPRODUCTO_Parameter, cANTIDADCOMPRA_RParameter);
        }
    }
}
