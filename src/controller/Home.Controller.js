const path = require("path");

let Productos = [
  {
    idProducto: 1,
    idusuario: 1,
    Nombre: "Labtop",
    Descripcion: "Computadora de ultima generacion",
    urlImagen: "https://i.postimg.cc/rsYyzSJD/image.png",
    precio: 30,
    CantuidadCompra: 1,
  },
  {
    idProducto: 2,
    idusuario: 1,
    Nombre: "Pinsas",
    Descripcion: "Abtas para cortar alambres",
    urlImagen: "https://i.postimg.cc/L8kdbt1j/image.png",
    precio: 10,
    CantuidadCompra: 4,
  },
];
const index = (req, res) => {
  res.render(path.join(__dirname, "../views/Home/index.ejs"), {
    Productos,
  });
};

module.exports = {
  index,
};
