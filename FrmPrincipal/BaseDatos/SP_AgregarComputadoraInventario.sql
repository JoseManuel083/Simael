delimiter //
drop procedure if exists agregarPerifericoInv(IN ID varchar(30), IN Categoria varchar(50),IN Tipo varchar(30),
IN Marca varchar(30),IN NoSerie varchar(50),IN Modelo varchar(50),
IN RAM varchar(20),IN NoProcesadores varchar(20),IN TipoProcesador varchar(30),
IN VelocidadProc varchar(20),IN NoDiscoDuros varchar(20),IN CapDiscoDuro varchar(20),
IN SistemaOperativo varchar(50),IN VersionSO varchar(30),IN EstadoFisico varchar(20),
IN Precio varchar(10),IN Resguardante varchar(50),IN Inventario varchar(255) )
begin
  insert into computadora values(ID,Categoria,Tipo,Marca,NoSerie,Modelo,RAM,NoProcesadores,TipoProcesador,VelocidadProc,
                                NoDiscoDuros,CapDiscoDuro,SistemaOperativo,VersionSO,EstadoFisico,Precio,Resguardante,
										  Inventario);
  insert into perifericos values(ID,Categoria,Tipo,Marca,Modelo,NoSerie,Color,Composicion,EstadoFisico,Precio,
  											Resguardante,Inventario);
end 
//