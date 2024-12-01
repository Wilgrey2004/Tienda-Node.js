using Api_Tienda_Virtual.Models;
using Api_Tienda_Virtual.Models.ViewsModels;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using HttpDeleteAttribute = System.Web.Http.HttpDeleteAttribute;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;

namespace Api_Tienda_Virtual.Controllers
{
        public class CarritoController : ApiController
        {
                // GET: Carrito
                [HttpGet]
                public List<CarritoViewsModels> Listar( int objs ) {
                        List<CarritoViewsModels> lst = new List<CarritoViewsModels>();
                        using (TiendaVirtualEntitie db = new TiendaVirtualEntitie())
                        {
                                var lista = db.PS_GET_PRODUCTOS_CARRITO(objs).ToList();

                                lst = (from c in lista select new CarritoViewsModels {
                                        IdCarrito = c.IdCarrito,
                                        IdProducto = c.IdProducto,
                                        Nombre = c.NOMBRE,
                                        precio = (int)c.PRECIO,
                                        Cantidad = (int)c.CANTIDADCOMPRA,
                                        CantuidadMaxima = (int)c.CANTIDAD
                                }).ToList();

                        }

                        return lst;
                }

                [HttpPost]
                public void AgregarCarrito( CarritoInsert carritoInsert ) {
                        using(TiendaVirtualEntitie db = new TiendaVirtualEntitie()){
                                db.SP_SUMAR_CARRITO(carritoInsert.IdUsuario, carritoInsert.IdProducto, carritoInsert.CantidadComprar);
                                db.SaveChanges();
                        }
                }

                [HttpDelete]
                public void DestroyCarrito(int id) {
                        using(TiendaVirtualEntitie db = new TiendaVirtualEntitie())
                        {
                                var CarritooDestroy = db.Carrito.FirstOrDefault(carr => carr.idCarrito == id);
                                db.Carrito.Remove(CarritooDestroy);
                                db.SaveChanges();
                        }
                }


        }
}