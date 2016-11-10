CREATE DEFINER=`root`@`localhost` PROCEDURE `nuevoCliente`(nit integer, nombre varchar(45), direccion varchar (5))
BEGIN
INSERT INTO clientes VALUES (nit, nombre, direccion);
END