//por algunos problemas con la carga de los objetos esto estara comentado...

// const abrirModal = (estado) => {
//   const modal = document.getElementById("modal");
//   if (estado) {
//     modal.classList.remove("hidden");
//   } else {
//     modal.classList.add("hidden");
//   }
// };

// Esta funcion se encarga de eliminar los elementos de los carritos de compra
document.addEventListener("DOMContentLoaded", () => {
  //Esta parte se encarga de obtener el elelemento lista que es el que se enarga de guardar todo en el carrito
  const lista = document.getElementById("ListaCarrito");
  // esta aagrega un esuchador de eventos al evento click
  lista.addEventListener("click", (event) => {
    // aqui usamos el "evento" para  encontrar el que contiene
    if (event.target.classList.contains("Eliminar")) {
      // aqui estamos separando el voton de la lista para extraer el valor que este lleva..
      const boton = event.target;
      const value = boton.value;
      const item = event.target.closest("li");
      if (item) {
        console.log(value);
        item.remove();
      }
    }
  });
});
