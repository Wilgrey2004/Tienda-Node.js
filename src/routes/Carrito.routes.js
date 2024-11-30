const express = require("express");
const controller =  require("../controller/Carrito.controller.js");
const router = express.Router();

router.get("/Carrito", controller.Carrito);
router.post("/Carrito", controller.AgregarAlCarrito);

module.exports = router;
