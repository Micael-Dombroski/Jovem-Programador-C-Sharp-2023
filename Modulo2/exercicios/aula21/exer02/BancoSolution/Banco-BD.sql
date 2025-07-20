--CREATE DATABASE Banco;
use Banco;

/*create TABLE Cliente
(
    CPF CHAR(14) NOT NULL UNIQUE,
    RG VARCHAR(20) NOT NULL,
    Nome VARCHAR(100) NOT NULL,
    Endereco VARCHAR(255),
    Numero INT NOT NULL,
    Bairro VARCHAR(100) NOT NULL,
    Cidade VARCHAR(100) NOT NULL,
    UF CHAR(2) NOT NULL
);

alter table Cliente Add CONSTRAINT PK_CPF 
    PRIMARY KEY CLUSTERED (CPF);*/

/*CREATE TABLE Conta
(
    Agencia INT NOT NULL,
    Numero INT NOT NULL,
    CPF_fk CHAR(14) NOT NULL,
    TipoConta INT NOT NULL,
    Saldo DECIMAL (11,2) NOT NULL,
);

alter table Conta Add CONSTRAINT PK_Conta 
    PRIMARY KEY CLUSTERED (Agencia, Numero);
ALTER TABLE Conta ADD CONSTRAINT fk_ClienteConta 
    FOREIGN KEY (CPF_fk) REFERENCES Cliente (CPF);*/

/*CREATE TABLE Movimento_Bancario (
    Id INT IDENTITY(1,1) NOT NULL,
    Tipo_Movimento VARCHAR(30) NOT NULL,
    Valor_Movimentado DECIMAL (11,2) NOT NULL,
    Conta_Agencia INT NOT NULL,
    Conta_Numero INT NOT NULL
);
ALTER TABLE Movimento_Bancario ADD CONSTRAINT fk_ContaMovimento
    FOREIGN KEY (Conta_Agencia,Conta_Numero) REFERENCES Conta (Agencia,Numero);
    
alter table Movimento_Bancario Add CONSTRAINT PK_Movimento_Bancario 
    PRIMARY KEY CLUSTERED (Id);*/


/*CREATE DATABASE banking_system;
 
USE banking_system;
 
CREATE TABLE tb_customer (
    cpf VARCHAR(11) NOT NULL,
    name VARCHAR(50) NOT NULL,
    rg VARCHAR(15) not null,
    address VARCHAR(30) not null,
    number int,
    neighborhood VARCHAR(20) not null,
    city varchar(10) not null,
    uf varchar(2) not null,
 
    CONSTRAINT pk_tb_customer PRIMARY KEY(cpf)
);
 
 
CREATE TABLE tb_account (
    agency int not null,
    account_number int not null,
    account_type int not null,
    balance float not null,
    customer_cpf varchar(11) not null,
    CONSTRAINT PK_Conta 
    PRIMARY KEY CLUSTERED (agency, account_number),
    CONSTRAINT fk_customer_cpf FOREIGN KEY (customer_cpf)
    REFERENCES tb_customer(cpf)
);

CREATE TABLE tb_account_cash_flow (
    id int not null,
    agency int not null,
    number_account int not null,
    value_cash float not null,
    CONSTRAINT pk_tb_account_cash_flow PRIMARY KEY(id)
)*/