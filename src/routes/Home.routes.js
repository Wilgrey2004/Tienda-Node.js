const express = require("express");

const controller = require("../controller/Home.Controller.js");
const router = express.Router();

router.get("/", controller.index);

module.exports = router;
