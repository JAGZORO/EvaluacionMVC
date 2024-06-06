create database EvaluacionMVC

use EvaluacionMVC

create table Productos (
ProductoID int primary key identity (1,1),
Nombre nvarchar (100) not null,
Descripción nvarchar(255),
Precio decimal(10,2),
CantidadEnStock int,
FechaCreacion datetime
);