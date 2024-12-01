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
  if (!lista) {
    return;
  }
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

addEventListener("submit", (event) => {
  event.preventDefault();

  if (!event.target.classList.contains("Acciones")) {
    return;
  }

  let btnCarrito = event.submitter;

  if (btnCarrito && btnCarrito.classList.contains("Carrito")) {
    let values = btnCarrito.value.split(","); // Dividir el valor en una lista

    // Enviar los valores al controlador
    fetch("/Carrito", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify({ values: values }), // Enviar los valores como JSON
    })
      .then((response) => {
        if (!response.ok) {
          throw new Error("Error en la respuesta del servidor");
        }
        return response.json();
      })
      .then((data) => {
        console.log("Respuesta del servidor:", data);
      })
      .catch((error) => {
        console.error("Error al enviar los datos:", error);
      });
  }
});
