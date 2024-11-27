const path = require("path");

let carritoCompras = [
  {
    idProducto: 1,
    idusuario: 1,
    Nombre: "router",
    precio: 30,
    CantuidadCompra: 1,
  },
  {
    idProducto: 2,
    idusuario: 1,
    Nombre: "Pinsas",
    precio: 10,
    CantuidadCompra: 4,
  },
];

const Carrito = (req, res) => {
  res.render(path.join(__dirname, "../views/layout/Componentes/Carrito.ejs"), {
    carritoCompras,
  });
};

module.exports = {
  Carrito,
};
