const path = require("path");

const Idusuario = process.env.IDUSUARIO; // El objeto que necesitas enviar

let CantidadDeProductos = 0;

const Carrito = (req, res) => {
  let carritoCompras = [];

  // Construir la URL con parámetros de consulta
  const url = new URL("http://localhost:3005/Api/Carrito?objs=" + Idusuario);

  fetch(url, { method: "GET" })
    .then((res) => res.json())
    .then((ProductosCarrito) => {
      carritoCompras.push(...ProductosCarrito); // Guardar productos en el array
      CantidadDeProductos = carritoCompras.length;
      res.render(
        path.join(__dirname, "../views/layout/Componentes/Carrito.ejs"),
        {
          carritoCompras,
          Idusuario,
        }
      );
    })
    .catch((error) => {
      console.error("Error al obtener el carrito:", error);
      res.status(500).send("Error al obtener el carrito");
    });
};

const AgregarAlCarrito = (req, res) => {
  const ProductoAcarrito =
    //req.body.values;
    {
      IdUsuario: req.body.values[0],
      IdProducto: req.body.values[1],
      CantidadComprar: 1,
    };
  fetch("http://localhost:3005/Api/Carrito/AgregarCarrito/", {
    method: "POST",
    headers: {
      "Content-Type": "application/json",
    },
    body: JSON.stringify(ProductoAcarrito),
  })
    //la respuesta esta con este nombre debido a que estamos dentro de una funcion.
    .then((respuesta) => {
      respuesta.status(200).json({ message: "Producto agregado al carrito" });
    })
    .catch((error) => {
      console.error("Error al agregar al carrito => ", error);
      res.status(500).send("Error al agregar al carrito");
    });
};

module.exports = {
  Carrito,
  AgregarAlCarrito,
  CantidadDeProductos,
};
