const path = require("path");

const Idusuario = process.env.IDUSUARIO;
let ProductosList = [];

fetch("http://localhost:3005/Api/Productos/Listar/")
  .then((res) => res.json())
  .then((Productos) => ProductosList.push(...Productos))
  .catch((error) => {
    console.error("Error al obtener los productos:" + error);
    res.status(500).send("Error al obtener los productos");
  });

const index = (req, res) => {
  res.render(path.join(__dirname, "../views/Home/index.ejs"), {
    ProductosList,
    Idusuario,
  });
};

module.exports = {
  index,
};
