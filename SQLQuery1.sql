create table servicio (IdIPS varchar(5), Identificacion varchar(10), NombrePaciente varchar(30),
IdLaboratorio varchar(5), ValorLaboratorio numeric)

create table ips (IdIPS varchar(5), NombreIPS varchar(40))

insert into ips values('0001','Laboratorio Yesenia Ovalle')
insert into ips values('0002','Laboratorio Nacy Florez')
insert into ips values('0003','Laboratorio Cristiam Gram')
select * from ips

create table laboratorios (IdLaboratorio varchar(5), NombreLaboratorio varchar(40), ValorLaboratorio numeric)

insert into laboratorios values('1001','Cuadro Hematico',12000)
insert into laboratorios values('1002','Coprologico',5000)
insert into laboratorios values('1003','Glicemia',25000)
insert into laboratorios values('1004','Trigliceridos',8000)
select * from laboratorios
