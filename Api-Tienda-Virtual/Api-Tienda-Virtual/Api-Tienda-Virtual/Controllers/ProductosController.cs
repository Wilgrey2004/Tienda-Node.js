using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Api_Tienda_Virtual.Models;
using Api_Tienda_Virtual.Models.ViewsModels;

namespace Api_Tienda_Virtual.Controllers
{
        public class ProductosController : ApiController
        {
                // GET: Productos
                [HttpGet]
                public List<ProductosViewsModel> Listar() {
                        List<ProductosViewsModel> lts = new List<ProductosViewsModel>();
                        using (TiendaVirtualEntitie db = new TiendaVirtualEntitie())
                        {
                               
                                lts = (from d in db.Productos where d.Estatus == 1 select new ProductosViewsModel {
                                        IdProducto = d.IdProducto,
                                        Nombre = d.Nombre,      
                                        Precio = d.Precio,
                                        Descripcion = d.Descripcion,
                                        CantuidadCompra = d.cantidad,
                                        UrlImagen = d.urlImagen,
                                        Categoria = (int) d.Categoria,

                                }).ToList();
                                

                                return lts;
                        }

                }


        }
}