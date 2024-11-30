namespace Api_Tienda_Virtual.Models.ViewsModels
{
        public class ProductosViewsModel
        {

                public int? IdProducto { get; set; }
                public string Nombre { get; set; }
                public string Descripcion { get; set; }
                public string UrlImagen { get; set; }
                public int Categoria { get; set; }
                public double? Precio { get; set; }
                public int? CantuidadCompra { get; set; }
        }
}