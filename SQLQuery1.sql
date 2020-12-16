create table servicio (IdIPS varchar(5), Identificacion varchar(10), NombrePaciente varchar(30),
IdLaboratorio varchar(5), ValorLaboratorio numeric)

create table ips (IdIPS varchar(5), NombreIPS varchar(40))

insert into ips values('0001','Laboratorio Yesenia Ovalle')
insert into ips values('0002','Laboratorio Nacy Florez')
insert into ips values('0003','Laboratorio Cristiam Gram')
select * from ips