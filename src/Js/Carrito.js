class CarritoDb {
  constructor(idCarrito, IdUsuario, idProducto, CantidadCompra, Estatus) {
    this.idCarrito = idCarrito;
    this.IdUsuario = IdUsuario;
    this.idProducto = idProducto;
    this.CantidadCompra = CantidadCompra;
    this.Estatus = Estatus;
  }
}

export default CarritoDb;
