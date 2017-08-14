USE DB_A2745B_Fdrcdiogo
GO
Begin tran 

CREATE TABLE Networkcliente(
IdCliente int primary key identity not null,
NomeRazaoSocial varchar(500) null,
ApelidoNomeFantasia varchar(500) null,
Contato varchar(200) null,
DataCadastro datetime null,
Telefone1 varchar(100) null,
Telefone2 varchar(100) null,
Fax varchar(100) null,
Cnpj varchar(100) null,
Cpf varchar(100) null,
IncricaoEstadualRg varchar(100) null,
Endereco1 varchar(100) null,
Numero1  varchar(100) null,
Cidade1  varchar(100) null,
Uf1  varchar(100) null,
Cep1  varchar(100) null,
Endereco2 varchar(100) null,
Numero2  varchar(100) null,
Cidade2  varchar(100) null,
Uf2  varchar(100) null,
Cep2  varchar(100) null,
Referencia1 varchar(100) null,
TelefoneReferencia1 varchar(100) null,
EmailReferencia1 varchar(100) null,
DataNascimento datetime null, 
Referencia2 varchar(100) null,
TelefoneReferncia2 varchar(100) null,
Renda decimal(18,2) null,
Credito decimal(18,2) null,
CodMunicipio varchar(100) null,
Spc bit null,
Serasa bit null,
TeleCheque bit null,
Bloqueado bit null,
Classificacao bit null,
TipoRegiao varchar(400) null,
ProfissaoRamo varchar(400) null,
VendedorAtendente varchar(300) null,
Trasportadora varchar(200) null,
Observacao varchar(max) null
) 

select * from networkcliente


CREATE TABLE networkfornecedores (
IdFornecedor int not null identity primary key,
RazaoSocial varchar(500) null,
NomeFantasia varchar(500) null,
DataCadastro datetime null,
Telefone1 varchar(100) null,
Telefone2 varchar(100) null,
CnpjCpf varchar(100) null,
Cpf varchar(100) null,
Cnpj varchar(100) null,
IncricaoEstadual varchar(100) null,
Endereco varchar(300) null,
Bairro varchar(300) null,
LinhaProdutos varchar(100) null,
Cidade varchar(300) null,
Uf varchar(100) null,
Cep varchar(100) null,
SiteUrl varchar(300) null,
Banco varchar(100) null,
Agencia varchar(100) null,
Conta varchar(100) null,
TrasportadoraUltilizada varchar(100) null,
Codigo varchar(100) null,
Observacao varchar(6000) null,
Contato varchar(300) null,
Email varchar(200) null
)

select * from networkfornecedores

CREATE TABLE  networkusuario (
IdUsuario int not null identity primary key,
NomeFuncionario varchar(300) null,
CodigoFuncionario varchar(100) null,
Setor varchar(100) null,
DataEmaissao datetime null,
Salario decimal(18,2) null,
Carteiratrabalho varchar(200) null,
CarteiraMotorista varchar(100) null,
Rg varchar(100) null,
Cpf varchar(100) null,
Endereco varchar(200) null,
Bairro varchar(300) null,
Cidade varchar(200) null,
Ud varchar(100) null,
Fone1 varchar(100) null,
Fone2 varchar(100) null,
Senha varchar(100) null,
Status bit null
)


select * from networkusuario


CREATE TABLE networkcontasapagar(
	IdContasAPagar int IDENTITY(1,1) primary key NOT NULL,
	Data datetime NULL,
	Fornecedor varchar(100) NULL,
	Pagador varchar(100) null,
	Recebedor varchar(100) null,
	Identificacao varchar(5000) NULL,
	Vencimento datetime NULL,
	valor decimal(18, 2) NULL,
	Status bit NOT NULL

)
select * from networkcontasapagar


CREATE TABLE networkcontasareceber(
	IdContasAReceber int IDENTITY(1,1) primary key NOT NULL,
	Data datetime NULL,
	Fornecedor varchar(100) NULL,
	Pagador varchar(100) null,
	Recebedor varchar(100) null,
	Identificacao varchar(5000) NULL,
	Vencimento datetime NULL,
	valor decimal(18, 2) NULL,
	Status bit NOT NULL
)


select * from networkcontasareceber


CREATE TABLE networkprodutos (
IdProduto int not null primary key identity,
Descricao varchar(200) null,
NomeProduto varchar(100) null,
Classificacao varchar(200) null,
Status bit null,
Quantidade int null,
TipoProduto int null,
DescTipoProduto varchar(100) null,
Tamanho varchar(100) null,
Peso varchar(100) null,
ValorASerPagoProdutor decimal(18,2) null,
ValorASerCobradoProdutor decimal(18,2) null
)

select * from networkprodutos



CREATE TABLE networkcomposicao (
IdComposicao int not null primary key identity,
Descricao varchar(200) null,
NomeComposicao varchar(100) null,
Classificacao varchar(200) null,
Status bit null,
Quantiomposicao int null,
DescTipoComposicao varchar(100) null,
Tamanho varchar(100) null,
Peso varchar(100) null,
ValorASerPagoProdutor decimal(18,2) null,
ValorASerCobradoProdutor decimal(18,2) null
)

select * from networkcomposicao



commit
--rollback