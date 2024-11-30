namespace Api_Tienda_Virtual.Models.ViewsModels
{
        public class CarritoViewsModels
        {
                public int IdCarrito { get; set; }
                public int IdProducto { get; set; }
                public string Nombre { get; set; }
                public int precio { get; set; }
                public int Cantidad { get; set; }
                public int CantuidadMaxima { get; set; }
        }

        public class InfoCarrito
        {
                public int Idusuario { get; set; }
                
        }
}