create database bdagenda;
use bdagenda;
create table tbusuarios(
nome varchar(60) not null,
usuario varchar(20) PRIMARY KEY,
telefone varchar(15) not null,
senha varchar(20)
);
SELECT * FROM tbusuarios;