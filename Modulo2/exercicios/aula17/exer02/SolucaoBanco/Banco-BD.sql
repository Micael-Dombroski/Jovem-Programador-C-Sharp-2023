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