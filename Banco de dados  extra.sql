	create database db_redeextra;

	use db_redeextra

create table tbl_funcionario(
		cg_func int primary key identity(1,1),
		nm_func varchar(50) not null,
		cpf_func varchar(11) not null,
		idade_fnc varchar(50) not null,
		nasc_func date,
		dtcontrat_func date,
		login_func varchar(20) not null,
		senha_func varchar(20) not null
)


insert into tbl_funcionario
(nm_func,cpf_func,idade_fnc,nasc_func,dtcontrat_func,login_func,senha_func)
values('Kauã Vitorio','43333349850','16','31/05/2004','27/09/2020','kaua123','kaua123')

select * from tbl_funcionario