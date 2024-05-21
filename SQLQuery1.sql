create database TopInvest

use TopInvest

create table Endereco (
	id int identity primary key,
	estado varchar(255),
	cidade varchar(255),
	bairro varchar(max),
	rua varchar(255),
	cep varchar(12) not null,
	numero varchar(5) not null
)

drop table Endereco
select * from Endereco

create table Cliente (
	id int identity primary key,
	nome varchar(max) not null,
	usuario varchar(max) not null,
	senha varchar(max) not null,
	saldo float not null,
	numConta int not null,
	flgAdm bit not null,
	idEndereco int not null
)

create table RendaVariavel (
	id int identity primary key,
	sigla varchar(10) not null,
	imgIcone varbinary(max) not null,
	preco float,
	ultimoPreco float
)

create table ClienteRendaVariavel (
	id int identity primary key,
	valor float,
	quantidade int,
	dataCompra DateTime,
	clientId int,
	rendaVariavelId int
)

drop table ClienteRendaFixa
drop table ClienteRendaVariavel
drop table Cliente
drop table RendaFixa

create table RendaFixa (
	id int identity primary key,
	descricao varchar(255),
	duracao int,
	rentabilidade float
)

create table ClienteRendaFixa (
	id int identity primary key,
	valor float,
	duracao varchar(20),
	rendimentoFinal float,
	clientId int,
	rendaFixaId int
)

use TopInvest

create procedure spDelete
(
 @id int ,
 @tabela varchar(max)
)
as
begin
 declare @sql varchar(max);
 set @sql = ' delete ' + @tabela +
 ' where id = ' + cast(@id as varchar(max))
 exec(@sql)
end

GO

create procedure spConsulta
(
 @id int ,
 @tabela varchar(max)
)
as
begin
 declare @sql varchar(max);
 set @sql = 'select * from ' + @tabela +
 ' where id = ' + cast(@id as varchar(max))
 exec(@sql)
end

GO

create procedure spListagem
(
 @tabela varchar(max),
 @ordem varchar(max))
as
begin
 exec('select * from ' + @tabela +
 ' order by ' + @ordem)
end

GO

create procedure spProximoId
(@tabela varchar(max))
as
begin
 exec('select isnull(max(id) +1, 1) as MAIOR from '
 +@tabela)
end
GO

select * from Cliente

insert into Endereco (estado, cidade, rua, numero, cep) values ('SP', 'teste', 'testeRua', '12', '00000200')

//--------------------------- CLIENTE-------------------------
alter procedure spInsert_Cliente
(
 @id int,
 @nome varchar(max),
 @usuario varchar(max),
 @senha varchar(max),
 @saldo money,
 @numConta int,
 @flgAdm bit,
 @idEndereco int
)
as
begin
 insert into Cliente
 (nome,usuario, senha, saldo, numConta, flgAdm, idEndereco)
 values
 (@nome,@usuario, @senha, @saldo, @numConta, @flgAdm, @idEndereco)
end
GO
alter procedure spUpdate_Cliente
(
 @id int,
 @nome varchar(max),
 @usuario varchar(max),
 @senha varchar(max),
 @saldo money,
 @numConta int,
 @flgAdm bit,
 @idEndereco int
)
as
begin
 update Cliente set
 nome = @nome,
 usuario = @usuario,
 senha = @senha,
 saldo = @saldo,
 numConta = @numConta,
 flgAdm = @flgAdm
 where id = @id
end
GO


insert into Cliente
 (nome, usuario, senha, saldo, numConta, flgAdm, idEndereco)
 values
 ('admin','admin', 'admin', 100.00, 1, 1, 7)

 select * from Cliente

 create procedure spConsultaLogin
(
 @usuario varchar(max),
 @senha varchar(max)
)
as
begin
 select * from Cliente where usuario = @usuario and senha = @senha 
end

create procedure spProximaConta
as
begin
 select isnull(max(numConta) +1, 1) as MAIOR from Cliente
end

//--------------------------- ENDERECO-------------------------
use TopInvest
select * from Endereco
alter procedure spInsert_Endereco
(
 @id int,
 @estado varchar(max),
 @cidade varchar(max),
 @rua varchar(max),
 @bairro varchar(max),
 @numero varchar(max),
 @cep varchar(max)
)
as
begin
 insert into Endereco
 (estado, cidade,bairro, rua, numero, cep)
 values
 (@estado,@cidade,@bairro, @rua, @numero, @cep)
end
GO
alter procedure spUpdate_Endereco
(
 @id int,
 @estado varchar(max),
 @cidade varchar(max),
 @bairro varchar(max),
 @rua varchar(max),
 @numero varchar(max),
 @cep varchar(max)
)
as
begin
 update Endereco set
 estado = @estado,
 cidade = @cidade,
 bairro = @bairro,
 rua = @rua,
 numero = @numero,
 cep = @cep
 where id = @id
end
GO

select * from Endereco
select * from Cliente

delete from Cliente where id > 1
delete from Endereco where id > 1

//--------------------------- RENDA VARIAVEL-------------------------
use TopInvest
select * from RendaVariavel

create procedure spInsert_RendaVariavel
(
 @id int,
 @sigla varchar(10),
 @imgIcone varbinary(max),
 @preco float,
 @ultimoPreco float
)
as
begin
 insert into RendaVariavel
 (sigla, imgIcone, preco, ultimoPreco)
 values
 (@sigla,@imgIcone, @preco, @ultimoPreco)
end
GO
create procedure spUpdate_RendaVariavel
(
 @id int,
 @sigla varchar(10),
 @imgIcone varbinary(max),
 @preco float,
 @ultimoPreco float
)
as
begin
 update RendaVariavel set
 sigla = @sigla,
 imgIcone = @imgIcone,
 preco = @preco,
 ultimoPreco = @ultimoPreco
 where id = @id
end
GO

select * from RendaVariavel

create procedure spConsultaSigla
(
 @sigla varchar(max)
)
as
begin
select * from RendaVariavel
where sigla like '%' + @sigla + '%'
end

//--------------------------- RENDA FIXA-------------------------
use TopInvest
select * from RendaFixa

alter procedure spInsert_RendaFixa
(
 @id int,
 @descricao varchar(max),
 @duracao int,
 @rentabilidade float
)
as
begin
 insert into RendaFixa
 (descricao, duracao, rentabilidade)
 values
 (@descricao, @duracao, @rentabilidade)
end
GO
alter procedure spUpdate_RendaFixa
(
 @id int,
 @descricao varchar(max),
 @duracao int,
 @rentabilidade float
)
as
begin
 update RendaFixa set
 duracao = @duracao,
 rentabilidade = @rentabilidade
 where id = @id
end
GO

create procedure spConsultaDescricao
(
 @descricao varchar(max)
)
as
begin
select * from RendaFixa
where descricao like '%' + @descricao + '%'
end

select * from Cliente
select * from Endereco
select * from RendaVariavel