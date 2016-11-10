CREATE DEFINER=`root`@`localhost` PROCEDURE `selectMesa`()
BEGIN
SELECT mesas.id, numeroMesa,statusMesa.descripcion from mesas inner join statusmesa
on mesas.StatusMesa_id=statusMesa.id order by id;
END