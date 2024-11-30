const { json } = require("express");
const path = require("path");

const Idusuario = process.env.IDUSUARIO; // El objeto que necesitas enviar

let carritoCompras = [];

const Carrito = (req, res) => {
  // Construir la URL con parámetros de consulta
  const url = new URL("http://localhost:3005/Api/Carrito?objs=" + Idusuario);

  fetch(url, { method: "GET" }) // ❌ Eliminamos el `body`
    .then((res) => res.json())
    .then((ProductosCarrito) => {
      carritoCompras.push(...ProductosCarrito); // Guardar productos en el array
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
  const values = req.body.values;
  console.log("Valores recibidos:", values);
};

module.exports = {
  Carrito,
  AgregarAlCarrito,
  carritoCompras,
};
