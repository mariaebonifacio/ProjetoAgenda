create database bdagenda;
use bdagenda;
create table tbusuarios(
nome varchar(60) not null,
usuario varchar(20) PRIMARY KEY,
telefone varchar(15) not null,
senha varchar(20)
);
SELECT * FROM tbusuarios;

create table tbcategoria(
id_categoria INT auto_increment PRIMARY KEY,
nome_categoria VARCHAR(50) 
);

SELECT * FROM tbcategoria;