delimiter $$
drop procedure if exists agregarPeriferico$$
create procedure agregarPeriferico(IN ID varchar(20),
				   IN folio varchar(15),
                                   IN Categoria varchar(50),
                                   IN Tipo varchar(30),
                                   IN Marca varchar(40), 
                                   IN Modelo varchar(40), 
                                   IN NoSerie varchar(50), 
                                   IN Color varchar(30), 
                                   IN Composicion varchar(40),
                                   IN EstadoFisico varchar(40), 
                                   IN precio varchar(20), 
                                   IN resguardante varchar(50), 
                                   IN inventario varchar(300)
) 
BEGIN
    INSERT into perifericos values(ID,folio,Categoria,Tipo,Marca,Modelo,NoSerie,Color,Composicion,
    EstadoFisico,precio,resguardante,inventario);
END$$
DELIMITER ;