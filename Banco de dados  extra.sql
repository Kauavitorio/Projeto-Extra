--  Copyright (c) 2020 Kauã Vitório
--  GitHub repositorio: https://github.com/Kauavitorio/Projeto-Extra
--  Não esqueça de preencher as informaçoes do seu banco de dados nas conexões dentro do projetos csharp
--  Não é recomendado alterar o nome das tabelas pois ira dar erro no projeto csharp
--  (caso queria mudar o nome das tebelas  atulize o nome nos codigos do programa)
--  Caso as linhas esteja indicando que a algum erro desconsidere o erro pois é um bug decorrendo a escrita pode executar o comando tranquilamente


--  Criando o banco de dados	
create database db_redeextra;

---------------------------------------------------------------------------------------

--  Utilizando o banco de dados
use db_redeextra

---------------------------------------------------------------------------------------

--Criando a tabela de funcionario
create table tbl_funcionario(
		cd_func int primary key identity(1,1),
		nm_func varchar(50) not null,
		cpf_func varchar(11) not null,
		idade_fnc varchar(3) not null,
		nasc_func date,
		dtcontrat_func date,
		login_func varchar(20) not null,
		senha_func varchar(20) not null
)

---------------------------------------------------------------------------------------!

--     !!!!!!!!         !!!!!           !!!!!!!!
--  Esse comando só deve ser executado para alguns test na tabela de funcionario
--  Não é necessario executar ele na criação do banco
delete tbl_funcionario where cd_func = 1

---------------------------------------------------------------------------------------!

--  Criando a tabela de gerentes

create table tbl_gerentes(
		cd_gerente int primary key identity(1,1),
		nm_gerente varchar(50) not null,
		cpf_gerente varchar(11) not null,
		func_gerente varchar(20) not null,
		senha_gerente varchar(20) not null
)

---------------------------------------------------------------------------------------!

--  Criando a tabela de desenvolvedores

create table tbl_devs(
		cd_dev int primary key identity(1,1),
		nm_dev varchar(50) not null,
		serial_dev varchar(20) not null,
		cpf_dev varchar(11) not null,
		senha_dev varchar(20) not null
)

---------------------------------------------------------------------------------------!

--  Inserindo o primeiro dado na tabela de desenvolvedor
--  Os campos indicando "Insira um ... aqui" você devere preencher com oque achar melhor

insert into tbl_devs
(nm_dev,serial_dev,cpf_dev,senha_dev)
values(' Insira um Nome aqui','Insira um numero para ser o serial','Insira um cpf aqui','Insira uma senha aqui')

---------------------------------------------------------------------------------------!

--  Inserindo o primeiro dado na tabela de gerentes
--  Os campos indicando "Insira um ... aqui" você devere preencher com oque achar melhor

insert into tbl_gerentes
(nm_gerente,cpf_gerente,func_gerente,senha_gerente)
values('Insira um nome aqui','Insira um cpf aqui','Insira uma função aqui','Insira uma senha aqui')

---------------------------------------------------------------------------------------!

--  Inserindo o primeiro dado na tabela de funcionario
--  Os campos indicando "Insira um ... aqui" você devere preencher com oque achar melhor

insert into tbl_funcionario
(nm_func,cpf_func,idade_fnc,nasc_func,dtcontrat_func,login_func,senha_func)
values('Insira um nome aqui','Insira um cpf aqui','Insira uma idade aqui','Insira uma data de nascimento aqui','Insira uma data de contratação aqui','Insira um login aqui','Insira uma senha aqui')

---------------------------------------------------------------------------------------!

--  Criando a tabela de produtos

create table tbl_produtos(
		cd_prod int primary key identity(1,1),
		nm_prod varchar(50) not null,
		qtd_prod int not null,
		dt_vali date,
		vl_produto decimal (10,2) not null
)

---------------------------------------------------------------------------------------!

--  Criando a tabela de bater ponto

create table tbl_baterponto(
		cd_func varchar(4),
		nm_func varchar(50) not null,
		dt_ponto date,
		hr_entra time,
		hr_saida time,
		cd_ponto int primary key identity(1,1)
)

---------------------------------------------------------------------------------------!

--  Inserindo o primeiro dado na tabela de bater ponto
--  Os campos indicando "Insira um ... aqui" você devere preencher com oque achar melhor

insert into tbl_baterponto
(cd_func,nm_func,dt_ponto,hr_entra,hr_saida)
values('Insira um codigo aqui','Insira um nome aqui','Insira uma data aqui','Insira uma hora aqui','Insira uma hora aqui')

---------------------------------------------------------------------------------------

--  Inserindo o primeiro dado na tabela de produtos
--  Os campos indicando "Insira um ... aqui" você devere preencher com oque achar melhor

insert into tbl_produtos
(nm_prod,qtd_prod,dt_vali,vl_produto)
values('Insira um nome de produto aqui','Insira uma quantidade de estoque aqui','Insira um data aqui','Insira o valor aqui')

---------------------------------------------------------------------------------------!

--     !!!!!!!!         !!!!!           !!!!!!!!
--  Esse comando só deve ser executado para alguns test na tabela de gerentes
--  Não é necessario executar ele na criação do banco

delete from tbl_gerentes  where cd_gerente = 5

---------------------------------------------------------------------------------------!

--  Aqui são os comandos para visualizar os dados que a dentro das respectivas tabelas

select * from tbl_gerentes
select * from tbl_funcionario
select * from tbl_baterponto
select * from tbl_devs
select * from tbl_produtos

---------------------------------------------------------------------------------------!


--  Copyright (c) 2020 Kauã Vitório
--  GitHub repositorio: https://github.com/Kauavitorio/Projeto-Extra
--  Não esqueça de preencher as informaçoes do seu banco de dados nas conexões dentro do projetos csharp
--  Não é recomendado alterar o nome das tabelas pois ira dar erro no projeto csharp
--  (caso queria mudar o nome das tebelas  atulize o nome nos codigos do programa)
--  Caso as linhas esteja indicando que a algum erro desconsidere o erro pois é um bug decorrendo a escrita pode executar o comando tranquilamente