delimiter //
drop procedure if exists agregar_computadora;
create procedure agregar_computadora(IN sicipo varchar(30),IN folio varchar(20), IN Categoria varchar(50),IN Tipo varchar(30),
IN Marca varchar(30),IN NoSerie varchar(50),IN Modelo varchar(50),IN RAM varchar(20),IN TipoProcesador varchar(30),
IN VelocidadProc varchar(20),IN NoDiscoDuros varchar(20),IN CapDiscoDuro varchar(20),IN SistemaOperativo varchar(50),
IN VersionSO varchar(30),IN EstadoFisico varchar(20),IN Precio varchar(10),IN Resguardante varchar(50),IN Inventario varchar(255),IN composicion varchar(50) )
begin
  
  insert into tbl_perifericos values(sicipo,folio,Categoria,Tipo,Marca,Modelo,NoSerie,"NEGRO",Composicion,EstadoFisico,Precio,
  				 Resguardante,Inventario);
  				 
  insert into tbl_computadora values(sicipo,folio,Categoria,Tipo,Marca,NoSerie,Modelo,RAM,TipoProcesador,VelocidadProc,
                                NoDiscoDuros,CapDiscoDuro,SistemaOperativo,VersionSO,EstadoFisico,Precio,Resguardante,Inventario);
end 
//
delimiter //