const path = require("path");

let carritoCompras = [
  {
    idProducto: 1,
    idusuario: 1,
    Nombre: "Labtop",
    precio: 30,
    CantuidadMaxima: 10,
  },
  {
    idProducto: 2,
    idusuario: 1,
    Nombre: "Pinsas",
    precio: 10,
    CantuidadMaxima: 10,
  },
];

const Carrito = (req, res) => {
  res.render(path.join(__dirname, "../views/layout/Componentes/Carrito.ejs"), {
    carritoCompras,
  });
};

module.exports = {
  Carrito,
  carritoCompras,
};
