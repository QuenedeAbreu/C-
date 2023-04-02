CREATE DATABASE locadora;
USE locadora;

DROP TABLE IF EXISTS `usuario`;
CREATE TABLE usuario(
	id_usuario int primary key auto_increment not null,
    nome_usuario varchar(255) not null,
    data_nascimento_usuario date not null,
    email_usuario varchar(100) not null,
    cpf_usuario varchar(14) not null
);

DROP TABLE IF EXISTS `carro`;
CREATE TABLE carro(
	id_carro int primary key auto_increment not null,
    marca_carro varchar(100) not null,
    modelo_carro varchar(100) not null,
    placa_carro varchar(100) not null,
    cor_carro varchar(100) not null,
    status_carro int(1) not null
);
DROP TABLE IF EXISTS `aluguel`;
CREATE TABLE aluguel(
	id_aluguel int primary key auto_increment not null,
    id_usuario int not null,
    id_carro int not null,
    data_aluguel datetime not null,
    data_devolucao datetime,
    valor_aluguel double,
    FOREIGN KEY (id_usuario) REFERENCES usuario(id_usuario) 
		ON DELETE CASCADE
		ON UPDATE CASCADE,
    FOREIGN KEY (id_carro) REFERENCES carro(id_carro)
		ON DELETE CASCADE
		ON UPDATE CASCADE
);
-- Inserir usuario para testes
INSERT INTO usuario(nome_usuario,data_nascimento_usuario,email_usuario,cpf_usuario) values("Aluno 01 da silva","1993-05-16","aluno01@gmail.com","111.222.333-01");

-- Inserir carro para testes - Obs: Status 0-(Disponivel) 1-(Alugado)
INSERT INTO carro(marca_carro,modelo_carro,placa_carro,cor_carro,status_carro) values("Fiat","Toro","MZX-0223","Vermelho",0);

-- Inserir Aluguel para testes 
INSERT INTO aluguel(id_usuario,id_carro,data_aluguel,data_devolucao,valor_aluguel) values(1,1,"2023-03-30","2023-03-31",150.00);