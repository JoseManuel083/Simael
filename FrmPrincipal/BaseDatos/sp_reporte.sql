delimiter  //
drop procedure if exists sp_reporte;
create procedure sp_reporte(IN sicipo varchar(12),IN idbitacora varchar(12))
	begin
	declare tipoEquipo varchar(50);
	declare id_bitacora varchar(12);
	
	
	if idbitacora = '0' then
		 select tbl_bitacora.idbitacora into id_bitacora from tbl_bitacora where tbl_bitacora.sicipo = sicipo;
	else
		 set id_bitacora = idbitacora;
	end if;
			
	select categoria into tipoEquipo from tbl_perifericos where sicipo = sicipo;
	if tipoEquipo = 'PC' then 
		select tbl_bitacora.folioumar,tbl_computadora.sicipo,tbl_computadora.Categoria,tbl_computadora.tipo,tbl_computadora.marca,
		tbl_computadora.Modelo,tbl_computadora.NoSerie,tbl_computadora.RAM,tbl_computadora.TipoProcesador,
		tbl_computadora.VelocidadProc,tbl_computadora.NoDiscoDuros,tbl_computadora.CapDiscoDuro,tbl_computadora.SistemaOperativo,
		tbl_computadora.VersionSO,tbl_computadora.EstadoFisico,tbl_computadora.Precio,tbl_computadora.Resguardante,tbl_bitacora.area,
		tbl_bitacora.problema,tbl_bitacora.solucion from perifericos,tbl_bitacora,tbl_computadora where perifericos.ID= tbl_bitacora.sicipo
      and perifericos.ID =  tbl_computadora.sicipo and tbl_bitacora.sicipo = sicipo and tbl_bitacora.idbitacora = id_bitacora;
	else
		select tbl_bitacora.folioumar,tbl_bitacora.sicipo,tbl_perifericos.Categoria,tbl_perifericos.Tipo,tbl_perifericos.Marca,
		tbl_perifericos.Modelo,tbl_perifericos.NoSerie,tbl_perifericos.Color,tbl_perifericos.Composicion,tbl_perifericos.EstadoFisico,
		tbl_perifericos.Precio,tbl_perifericos.Resguardante,tbl_bitacora.area,tbl_bitacora.problema,tbl_bitacora.solucion from tbl_bitacora,tbl_perifericos where 
		tbl_bitacora.sicipo =  tbl_perifericos.sicipo and tbl_perifericos.Categoria != "PC" and tbl_bitacora.sicipo = sicipo and tbl_bitacora.idbitacora = id_bitacora;
	end if;	
	end
//
delimiter //