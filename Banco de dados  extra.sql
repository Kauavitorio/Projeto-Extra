	create database db_redeextra;


	use db_redeextra

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

delete tbl_funcionario where cd_func = 1


create table tbl_gerentes(
		cd_gerente int primary key identity(1,1),
		nm_gerente varchar(50) not null,
		cpf_gerente varchar(11) not null,
		func_gerente varchar(20) not null,
		senha_gerente varchar(20) not null
)

create table tbl_devs(
		cd_dev int primary key identity(1,1),
		nm_dev varchar(50) not null,
		serial_dev varchar(20) not null,
		cpf_dev varchar(11) not null,
		senha_dev varchar(20) not null
)

insert into tbl_devs
(nm_dev,serial_dev,cpf_dev,senha_dev)
values(' Insira um Nome aqui','Insira um numero para ser o serial','Insira um cpf aqui','Insira uma senha aqui')

insert into tbl_gerentes
(nm_gerente,cpf_gerente,func_gerente,senha_gerente)
values('Insira um nome aqui','Insira um cpf aqui','Insira uma função aqui','Insira uma senha aqui')

insert into tbl_funcionario
(nm_func,cpf_func,idade_fnc,nasc_func,dtcontrat_func,login_func,senha_func)
values('Insira um nome aqui','Insira um cpf aqui','Insira uma idade aqui','Insira uma data de nascimento aqui','Insira uma data de contratação aqui','Insira um login aqui','Insira uma senha aqui')


create table tbl_produtos(
		cd_prod int primary key identity(1,1),
		nm_prod varchar(50) not null,
		qtd_prod int not null,
		dt_vali date,
		vl_produto decimal (10,2) not null
)


create table tbl_baterponto(
		cd_func varchar(4),
		nm_func varchar(50) not null,
		dt_ponto date,
		hr_entra time,
		hr_saida time,
		cd_ponto int primary key identity(1,1)
)

insert into tbl_baterponto
(cd_func,nm_func,dt_ponto,hr_entra,hr_saida)
values('Insira um codigo aqui','Insira um nome aqui','Insira uma data aqui','Insira uma hora aqui','Insira uma hora aqui')


insert into tbl_produtos
(nm_prod,qtd_prod,dt_vali,vl_produto)
values('Insira um nome de produto aqui','Insira uma quantidade de estoque aqui','Insira um data aqui','Insira o valor aqui')

delete from tbl_gerentes  where cd_gerente = 5

select * from tbl_gerentes
select * from tbl_funcionario