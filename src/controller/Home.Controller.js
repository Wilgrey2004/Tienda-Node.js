const path = require("path");

const Idusuario = process.env.IDUSUARIO;
let ProductosList = [];

fetch("http://localhost:3005/Api/Productos/Listar/")
  .then((res) => res.json())
  .then((Productos) => ProductosList.push(...Productos));

const index = (req, res) => {
  res.render(path.join(__dirname, "../views/Home/index.ejs"), {
    ProductosList,
    Idusuario,
  });
};

module.exports = {
  index,
};
