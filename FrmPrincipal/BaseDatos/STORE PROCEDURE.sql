DELIMITER //
DROP PROCEDURE IF EXISTS Equipo;
CREATE PROCEDURE Equipo (IN parametro VARCHAR(30))
	BEGIN
	DECLARE IDEQUIPO VARCHAR(12);
	DECLARE TIPOEQUIPO VARCHAR(12);
		SELECT ID,CATEGORIA INTO IDEQUIPO,TIPOEQUIPO FROM PERIFERICOS WHERE ID = parametro;
	   
		IF TIPOEQUIPO = 'PC' THEN 
			SELECT * from COMPUTADORA WHERE ID = CONCAT('',IDEQUIPO,'');
		ELSE
			SELECT * FROM PERIFERICOS WHERE ID = CONCAT('',IDEQUIPO,'');
		END IF;		 
		
	END
//

delimiter //