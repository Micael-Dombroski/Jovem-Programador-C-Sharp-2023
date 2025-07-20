--CREATE DATABASE ESTOQUE4;
USE ESTOQUE4

GO
--SELECT * from Cliente
--select * from Produto
--select * from Venda
/*SELECT * FROM PRODUTO;*/


/*CREATE TABLE PRODUTO(
    Id INT identity(1,1) NOT NULL,
    Nome VARCHAR(50) NOT NULL,

    Marca VARCHAR(30) NOT NULL,

    DataVencimento DATE NOT NULL,

    PrecoUnitario DECIMAL(11,2) NOT NULL,

    Unidade VARCHAR(20) NOT NULL,

    QtEstoque DECIMAL(11,2) NOT NULL
)

alter table Produto Add CONSTRAINT PK_Produto 
    PRIMARY KEY CLUSTERED (Id);*/

/*CREATE TABLE Cliente (
    CPF char(14) Not null,
    Nome VARCHAR(200) not null,
    Data_Nascimento  DATE null,
    Rua VARCHAR(200) null,
    Numero int null,
    Bairro VARCHAR(100) null,
    Cidade VARCHAR(100) null,
    UF CHAR(2) null,
    constraint [PK_CPF] PRIMARY KEY (CPF) 
);*/

/*CREATE TABLE Venda (
    Id INT identity(1,1) NOT NULL,
    Cliente_Cpf char (14) NOT NULL,
    Produto_Id int NOT NULL,
    PrecoUnitario DECIMAL(11,2) NOT NULL,
    QtLevada DECIMAL (11,2) NOT NULL
);

ALTER TABLE Venda ADD CONSTRAINT fk_ClienteVenda
    FOREIGN KEY (Cliente_Cpf) REFERENCES Cliente (CPF);

ALTER TABLE Venda ADD CONSTRAINT fk_ProdutoVenda
    FOREIGN KEY (Produto_Id) REFERENCES PRODUTO (Id);

alter table Venda Add CONSTRAINT PK_Venda
    PRIMARY KEY CLUSTERED (Id);*/

/*SELECT A.CPF, A.Nome as Cliente, A.Data_Nascimento as Nacimento, A.Rua, A.Bairro, A.Cidade, A.UF, 
    B.Id as Produto_Id, B.Nome as Produto, B.Marca, B.DataVencimento as Vencimento, B.PrecoUnitario, B.Unidade, B.QtEstoque,
    C.Id as Venda_Id, C.QtLevada
    FROM Cliente A, Produto B, Venda C*/

/*SELECT A.CPF, A.Nome as Cliente, A.Data_Nascimento as Nacimento, A.Rua, A.Bairro, A.Cidade, A.UF, 
    B.Id as Produto_Id, B.Nome as Produto, B.Marca, B.DataVencimento as Vencimento, B.PrecoUnitario, B.Unidade, B.QtEstoque,
    C.Id as Venda_Id, C.QtLevada
    FROM Cliente A, Produto B, Venda C 
    where B.Id = C.Produto_Id and A.CPF = C.Cliente_Cpf*/

