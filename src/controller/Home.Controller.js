const path = require("path");

const index = (req, res) => {
  res.render(path.join(__dirname, "../views/Home/index.ejs"));
};

module.exports = {
  index,
};
