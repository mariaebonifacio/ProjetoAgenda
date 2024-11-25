create database bdagenda;
use bdagenda;
create table tbusuarios(
nome varchar(60) not null,
usuario varchar(20) PRIMARY KEY,
telefone varchar(15) not null,
senha varchar(20)
);
-- ------------------------------------
SELECT * FROM tbusuarios;
-- ------------------------------------

create table tbcategoria(
id_categoria INT auto_increment PRIMARY KEY,
nome_categoria VARCHAR(50) 
);
-- ------------------------------------
SELECT * FROM tbcategoria;
-- ------------------------------------

-- INSERIR USUARIO	
DELIMITER $$
CREATE TRIGGER trInsertCategoria
BEFORE 
INSERT
ON tbcategoria
FOR EACH ROW
BEGIN
	SET NEW.usuario = USER();
END;

$$

DELIMITER ;
-- -----------------------------------

-- tabela log
create table tblog (idLog int auto_increment primary key,
					usuario varchar (40) not null,
					dataehora datetime not null,
                    descricao varchar (70));
-- -----------------------------------------------------------------------------------

-- EXCLUIR
DELIMITER $$
CREATE TRIGGER tblogcategoriadelete
AFTER
DELETE
ON tbcategoria
FOR EACH ROW 
BEGIN
	INSERT INTO tblog
    (usuario, dataehora,descricao)
    VALUES 
    (user(), current_timestamp(),
    CONCAT('A categoria ', OLD.nome_categoria, ' foi excluida')
    );
END

$$
DELIMITER ;
-- ------------------------------------------------------------------------------------

-- INSERIR
DELIMITER $$
CREATE TRIGGER tblogcategoriainserir
BEFORE
INSERT
ON tbcategoria
FOR EACH ROW 
BEGIN
	INSERT INTO tblog
    (usuario, dataehora,descricao)
    VALUES 
    (user(), current_timestamp(),
    CONCAT('A categoria ', NEW.nome_categoria, ' foi inserido')
    );
END

$$
DELIMITER ;
-- ----------------------------------------------------------------------------------------

-- ALTERAR
DELIMITER $$ 
CREATE TRIGGER tblogcategoriaalterar
AFTER
UPDATE
ON tbcategoria
FOR EACH ROW 
BEGIN
	INSERT INTO tblog
    (usuario, dataehora,descricao)
    VALUES 
    (user(), current_timestamp(),
    CONCAT('A categoria ', old.nome_categoria, ' foi alterado para ', new.nome_categoria)
    );
END

$$
DELIMITER ;
-- ---------------------------------------------------------------------------------------