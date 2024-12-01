USE TiendaVirtual;

--DROP PROCEDURE PS_GET_PRODUCTOS_CARRITO

 --CREATE PROCEDURE PS_GET_PRODUCTOS_CARRITO 
	--@IDUSUARIO INT
 --AS
 --BEGIN
 --    SELECT  cr.IdCarrito,pr.IdProducto,pr.NOMBRE, pr.PRECIO, pr.CANTIDAD, CR.CANTIDADCOMPRA
 --    FROM productos pr 
 --    INNER JOIN  
 --    CARRITO CR ON pr.IDPRODUCTO = CR.IDPRODUCTO 
 --    WHERE CR.ESTATUS = 1 AND CR.idusuario = @IDUSUARIO;
 --END

 --EXEC PS_GET_PRODUCTOS_CARRITO 1

 --SELECT * FROM CARRITO 

 
 
 --CREATE PROCEDURE SP_AGREGAR_CARRITO 
  
 --@IDUSUARIO INT,
 --@IDPRODUCTO INT,
 --@CANTIDADCOMPRAR INT

 --AS 

 --BEGIN 
	--INSERT INTO Carrito(idUsuario,idproducto,cantidadCompra) VALUES (@IDUSUARIO,@IDPRODUCTO,@CANTIDADCOMPRAR);
 --END;


 --EXEC SP_AGREGAR_CARRITO 1,2

 --SELECT * FROM CARRITO WHERE idusuario = 1

--EXEC PS_GET_PRODUCTOS_CARRITO 1


--CREATE PROCEDURE SP_SUMAR_CARRITO
--    @IDUSUARIO_ INT,
--    @IDPRODUCTO_ INT,
--    @CANTIDADCOMPRA_R INT
--AS
--BEGIN
--    -- Verificar si el producto ya está en el carrito del usuario
--    IF EXISTS (
--        SELECT 1 
--        FROM Carrito
--        WHERE idUsuario = @IDUSUARIO_ 
--          AND idProducto = @IDPRODUCTO_ 
--          AND ESTATUS = 1
--    )
--    BEGIN 
--        -- Si existe, actualizar la cantidad de compra
--        UPDATE Carrito
--        SET CantidadCompra = CantidadCompra + @CANTIDADCOMPRA_R
--        WHERE idUsuario = @IDUSUARIO_
--          AND idProducto = @IDPRODUCTO_
--          AND ESTATUS = 1;
--    END
--    ELSE 
--    BEGIN
--        -- Si no existe, llamar al procedimiento para agregar al carrito
--        EXEC SP_AGREGAR_CARRITO 
--            @IDUSUARIO = @IDUSUARIO_, 
--            @IDPRODUCTO = @IDPRODUCTO_, 
--            @CANTIDADCOMPRAR = @CANTIDADCOMPRA_R;
--    END
--END;
