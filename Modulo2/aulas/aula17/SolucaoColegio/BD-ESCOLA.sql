use escola;

/*create table ALUNO (
    Matricula int not null,
    Nome varchar(100) not null,
    Idade int not null
);

alter table ALUNO add constraint PK_Aluno
    primary key clustered (Matricula);*/

select * from Aluno

/*create table Professor (
    Matricula int not null,
    Nome varchar (100) not null,
    Data_Nascimento date not null,
    Rua varchar(200) not null,
    Numero int null,
    Bairro varchar (100) not null,
    Cidade varchar(100) not null,
    UF char(2) not null,
    constraint [PK_Matricula] PRIMARY KEY (Matricula)
);*/

--select * from Professor

/*CREATE TABLE Materia (
    id int IDENTITY(1,1) not null,
    nome VARCHAR(25) not null,
    quantidade_aulas int not null
);

alter table Materia ADD CONSTRAINT PK_MATERIA
    PRIMARY KEY CLUSTERED (id);*/

--SELECT * from Materia

/*create table Materia_Cursada (
    id int IDENTITY (1,1) not null,
    matricula_aluno int not null,
    materia_id int not null,
    nota decimal (5,2)
);

alter table Materia_Cursada add CONSTRAINT
    PK_Materia_Cursada PRIMARY KEY CLUSTERED (id);

alter table Materia_Cursada add CONSTRAINT
    FK_Materia_Cursada_Aluno FOREIGN KEY (matricula_aluno) REFERENCES
        Aluno (Matricula);

alter table Materia_Cursada ADD CONSTRAINT
    FK_Materia_Cursada_Materia FOREIGN KEY (materia_id) REFERENCES
    Materia (id);*/

/*INSERT into Materia_Cursada (matricula_aluno, materia_id)
    VALUES(11, 2);*/

/*select A.Matricula, A.Nome, A.Idade, C.id, C.nome, C.quantidade_aulas, B.nota from ALUNO A 
    INNER JOIN Materia_Cursada B ON (A.Matricula = B.matricula_aluno)
    INNER JOIN Materia C ON (B.materia_id = C.id)*/

    select B.Id, C.id as Materia_ID, C.nome, C.quantidade_aulas, B.nota from  Materia_Cursada B
    INNER JOIN Materia C ON (B.materia_id = C.id) WHERE B.matricula_aluno = 11;

    /*select A.Matricula, A.Nome, A.Idade,  B.nota from ALUNO A 
    INNER JOIN Materia_Cursada B ON (A.Matricula = B.matricula_aluno)
    WHERE B.Id = 2;
