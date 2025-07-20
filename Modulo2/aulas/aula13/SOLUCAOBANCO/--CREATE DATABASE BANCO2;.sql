--CREATE DATABASE BANCO2;

use BANCO2;

/*CREATE TABLE Conta (
    Agencia int NOT NULL,
    Numero int not null,
    ClienteCPF varchar(14) not null,
    Saldo decimal(10,2)
);

alter table Conta Add CONSTRAINT PK_Conta 
    PRIMARY KEY CLUSTERED (Agencia, Numero);*/

    /*CREATE TABLE Cliente (
        CPF CHAR(14) NOT NULL UNIQUE,
        RG VARCHAR(20) NOT NULL,
        Nome VARCHAR(100) NOT NULL,
        Endereco VARCHAR(255)
    );

    alter table Cliente Add CONSTRAINT PK_CPF 
    PRIMARY KEY CLUSTERED (CPF);*/
--DROP TABLE Conta;
--DROP TABLE Cliente;

--insert into Cliente values ('000.000.000-00', '0.000.00-0', 'Hinata', 'Konoha');
select * from cliente;