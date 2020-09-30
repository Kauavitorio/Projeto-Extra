	create database db_redeextra;


	use db_redeextra

create table tbl_funcionario(
		cd_func int primary key identity(1,1),
		nm_func varchar(50) not null,
		cpf_func varchar(11) not null,
		idade_fnc varchar(50) not null,
		nasc_func date,
		dtcontrat_func date,
		login_func varchar(20) not null,
		senha_func varchar(20) not null
)


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
values('Kauã Vitorio','43333349850','43333349850','kaua2004')

insert into tbl_gerentes
(nm_gerente,cpf_gerente,func_gerente,senha_gerente)
values('Kauã Vitorio','43333349850','Developer','kaua2004')

insert into tbl_gerentes
(nm_gerente,cpf_gerente,func_gerente,senha_gerente)
values('Valentim Diniz','00000000000','CEO','valentim123')



insert into tbl_funcionario
(nm_func,cpf_func,idade_fnc,nasc_func,dtcontrat_func,login_func,senha_func)
values('Kauã Vitorio','43333349850','16','31/05/2004','27/09/2020','kaua123','kaua123')


create table tbl_produtos(
		cd_prod int primary key identity(1,1),
		nm_prod varchar(50) not null,
		qtd_prod int not null,
		dt_vali date,
		vl_produto decimal (10,2) not null
)

insert into tbl_produtos
(nm_prod,qtd_prod,dt_vali,vl_produto)
values('Néctar Del Valle Uva 1L','55','15/01/2021','4.12')

select * from tbl_gerentes
select * from tbl_funcionario