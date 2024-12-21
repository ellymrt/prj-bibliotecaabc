create database biblioteca_va2

create table tb_cadastro(
cpf varchar(14) not null primary key,
nome varchar(50) not null,
senha varchar(50) not null,
email varchar(50) not null,
cargo varchar (50) not null);

select * from tb_cadastro

create table tb_livros(
cod int identity(1,1) not null primary key,
titulo varchar(60) not null,
subtitulo varchar(60),
autor varchar (60) not null,
edicao varchar(60),
editora varchar(60) not null,
data_publi varchar(60),
situacao varchar(20)
);

select * from tb_livros
drop table tb_livros 

use biblioteca_va2;