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

-- DRELIMITER - ALTERAR SENHA

DELIMITER $$ 
CREATE TRIGGER tblogSenhaAlterar
AFTER
UPDATE
ON tbusuarios
FOR EACH ROW 
BEGIN
	INSERT INTO tblog
    (usuario, dataehora,descricao)
    VALUES 
    (user(), current_timestamp(),
    CONCAT('A senha ', old.senha, ' foi alterado para ', new.senha)
    );
END

$$
DELIMITER ;
-- --------------------------------------------------------------------------------------

-- EXCLUIR USUARIO
DELIMITER $$
CREATE TRIGGER tblogUsuarioDelete
AFTER
DELETE
ON tbusuarios
FOR EACH ROW 
BEGIN
	INSERT INTO tblog
    (usuario, dataehora,descricao)
    VALUES 
    (user(), current_timestamp(),
    CONCAT('O usuário ', OLD.usuario, ' foi excluído')
    );
END

$$

DELIMITER ;

-- --------------------------------------------------------------------------------------

-- CRIAR TABELA CONTATOS

create table tbcontatos (
	contato VARCHAR (80) NOT NULL,
    telefone VARCHAR (20) PRIMARY KEY,
    categoria VARCHAR (20)
    );