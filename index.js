//Zona de requires...
const express = require("express"); //el modulo express es para crear el servidor de forma mas sencilla

require("dotenv").config(); // esta parte es necesaria para usar el .env

const path = require("path"); // usamos el modulo path para navegar entre archivos y carpetas

const expressLayout = require("express-ejs-layouts"); // Esto nos permite tener un layout en nuestra app

const homeRouters = require("./src/routes/Home.routes.js");

const CarritoRouters = require("./src/routes/Carrito.routes.js");

// final de zona de requires...



const app = express(); // creamos el servidor

app.use(express.json()); // le decimos a express que use el formato json

app.use(express.urlencoded({ extended: false })); // esto es un manejador de archivos json.

app.use(express.static(path.join(__dirname, "./src/public"))); // le decimos a express que use esta carpeta como carpeta publica

app.set("view engine", "ejs"); // con esto hacemos que el motor de plantillas sea EJS

app.set("views", "./src/views"); // aqui le indicamos la ruta de las vistas

app.use(expressLayout); //le decimos a la plicaicon que use el layout
app.set("layout", "layout/layout.ejs"); //le indicamos a la aplicacion en donde esta el layout

// app.get("/", (req, res) => {
//   res.send("Hola mundooo");
// }); // esta es la primera ruta de acceso que creamos en nuestra app

app.use(homeRouters);
app.use(CarritoRouters);

const PORT = process.env.PORT || 3001; // aqui le decimo cual es puerto que va a usar la aplicacion.

app.listen(PORT, () => {
  console.log(`El servidor está escuchando en http://localhost:${PORT}/`);
});

//npx tailwindcss -i ./src/public/css/input.css -o ./src/public/css/output.css --watch
