create table Retenciones(RetencionId int identity(1,1) primary key, 
Descripcion varchar (255),
Valor int );


create table TiposEmails (TipoId int identity(1,1) primary key ,
Descripcion varchar (255));


create table Empleados (EmpleadoId int identity(1,1) primary key ,
Nombre varchar (255),  FechaNacimiento datetime, Sueldo float,     RetencionId   INT    );



create table EmpleadosDescuentos (Id int identity(1,1) primary key ,
EmpleadoId int,   RetencionId int);


create table EmpleadosEmails (Id int identity(1,1) primary key ,
EmpleadoId int,   TipoId int, Email varchar(255));


