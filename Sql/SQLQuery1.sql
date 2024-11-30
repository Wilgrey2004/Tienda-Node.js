-- Create Database TiendaVirtual

use TiendaVirtual

-- create table Estatus(
-- 	idEstatus int identity(1,1) primary key not null,
-- 	Estatus varchar(10) not null
-- )

insert into Estatus(Estatus) values ('Activo'),('Inactivo')

-- Create table categorias(
-- 	idCategoria int identity(1,1) primary key not null,
-- 	Categoria varchar(50),
-- 	urlImagen varchar(max),
-- 	Descripcion varchar(max),
-- 	Estatus int references Estatus(idEstatus) default 1
-- )
insert into categorias(Categoria,Descripcion,urlImagen) values 
('Tecnologia','Productos tecnologicos que te ayudaran a tener una vida mas facil','https://i.postimg.cc/RFYQsndw/Tecnologia.png')
,('Trabajos Duros','Utencilios para todo tipo de trabajo rudo en exteriores','https://i.postimg.cc/CxwPfkQK/cutting-metal-with-plasma-equipment-plant.jpg')
,('Cocina','Todos los utenciolios para los amantes de la gastronomia','https://i.postimg.cc/XNTtXZWZ/woman-cooking-kitchen.jpg')


-- create table Productos(
-- 	IdProducto int identity(1,1) primary key not null,
-- 	Nombre varchar(50),
-- 	Descripcion varchar(100),
-- 	Precio int default 1,
-- 	urlImagen varchar(max),
-- 	cantidad int default 1,
-- 	Categoria int references Categorias(idCategoria),
-- 	Estatus int references estatus(idEstatus) default 1
-- )


INSERT INTO Productos (Nombre, Descripcion, Precio, urlImagen, cantidad, Categoria, Estatus) 
VALUES  ('laptop', 'Una laptop ligera y sencilla para uso cotidiano', 600, 'https://i.postimg.cc/28K35fc0/image.png', 10, 1, DEFAULT),
		('laptop gamer', 'Una laptop Un poco pesada pero potente', 1200, 'https://i.postimg.cc/rsYyzSJD/image.png', 13, 1, DEFAULT),
		('router', 'Un dispositivo para acceder a internet sin la necesidad de usar cables', 200, 'https://i.postimg.cc/W1zr9nKH/Router.png', 10, 1, DEFAULT),
		('Pc gamer', 'Dispositivo de sobremesa con gran potencia y multiples usos', 900, 'https://i.postimg.cc/90SVccmT/image.png', 6, 1, DEFAULT),
		('Pc Sencilla', 'Un dispositivo de sobremesa de buenas especificaciones pero no de gran potencia', 400, 'https://i.postimg.cc/jSyKrVGw/image.png', 10, 1, DEFAULT),
		('router', 'Un dispositivo para acceder a internet sin la necesidad de usar cables', 300, 'https://i.postimg.cc/W1zr9nKH/Router.png', 10, 1, DEFAULT),
		('Sartenes', 'sarten antiaderente', 900, 'https://i.postimg.cc/L8hSnYYP/image.png', 10, 3, DEFAULT),
		('Kit de herramientas', 'Kit sencillo de herramientas', 200, 'https://i.postimg.cc/J7gWD48H/image.png', 10, 2, DEFAULT),
		('Pinsas', 'Pinsas para cortar alambres', 200, 'https://i.postimg.cc/L8kdbt1j/image.png', 10, 2, DEFAULT),
		('Motocierra', 'Apta para cortar toda clase de arboles', 500, 'https://i.postimg.cc/Fs3shJSH/image.png', 10, 2, DEFAULT),
		('Guantes', 'Guantes Para trabajos rudos', 200, 'https://i.postimg.cc/vHtFP79f/image.png', 10, 2, DEFAULT),
		('Pinzas', 'Pinsas de cosina', 100, 'https://i.postimg.cc/pTP5NJr8/image.png', 32, 3, DEFAULT);

--select * from Productos where categoria = 3

-- create table usuario(
-- 	idusuario int identity(1,1) primary key not null,
-- 	Correo varchar(300) not null, 
-- 	Password varchar(max),
-- 	estatus int references estatus(idEstatus)
-- )

insert into usuario(Correo,Password,estatus) values ('Antonio@x.com','12345',1);



-- Create table Carrito(
-- 	idCarrito int identity(1,1) primary key not null,
-- 	idusuario int references usuario(idusuario),
-- 	idProducto int references Productos(IdProducto),
-- 	CantidadCompra int,
-- 	Estatus int references estatus(idEstatus) default 1
-- )


Create table ListaEspera (
	IdLista int identity(1,1) primary key not null,
	IdUsuario int references usuario(idusuario),
	IdProducto int references Productos(IdProducto),
	cantidad int default 1
)

INSERT INTO Carrito(idusuario,idProducto,CantidadCompra) VALUES (1,8,3);

-- CREATE TABLE Ventas (
--     idVenta INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
--     idUsuario INT NOT NULL REFERENCES Usuario(idUsuario),
--     FechaVenta DATETIME DEFAULT GETDATE(),
--     TotalVenta DECIMAL(10, 2) NOT NULL CHECK (TotalVenta >= 0)
-- );

-- CREATE TABLE DetalleVenta (
--     idDetalleVenta INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
--     idVenta INT NOT NULL REFERENCES Ventas(idVenta),
--     idProducto INT NOT NULL REFERENCES Productos(IdProducto),
--     Cantidad INT NOT NULL CHECK (Cantidad > 0),
--     PrecioUnitario DECIMAL(10, 2) NOT NULL CHECK (PrecioUnitario >= 0)
-- );


