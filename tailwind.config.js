/** @type {import('tailwindcss').Config} */
module.exports = {
  content: [
    "./src/views/**/*.ejs", // Todas las vistas EJS
    "./src/**/*.js", // Archivos JS (controladores y rutas)
  ],
  theme: {
    extend: {},
  },
  plugins: [],
};
