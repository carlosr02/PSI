create table Cliente(
	codigo int identity(1,1),
	nome varchar(50) not null,
	telefones varchar(30),
	cidade varchar(50),
	estado varchar(50),
	endereco varchar(85),
	cpf_cnpj varchar(14),
	email varchar(320),
	primary key(codigo)
)

create table Produto(
	codigo int identity(1,1),
	descricao varchar(50) not null,
	primary key(codigo)
)

create table Funcionario(
	codigo int identity(1,1),
	nome varchar(50) not null,
	telefones varchar(30),
	identidade varchar(9),
	clt varchar(16),
	salario varchar(5) not null,
	motorista bit,
	tecnico bit,
	observacao varchar(150),
	primary key(codigo)
)

create table Fornecedor(
	codigo int identity(1,1),
	nome varchar(50) not null,
	telefones varchar(30),
	cidade varchar(50),
	estado varchar(50),
	endereco varchar(85),
	cpf_cnpj varchar(14),
	email varchar(320),
	primary key(codigo)
)

create table PagamentoSalario(
	codigo int identity(1,1),
	data date not null,
	mesReferente int not null,
	anoReferente int not null,
	valorPago float not null,
	funcionario_codigo int not null,
	primary key(codigo),
	foreign key(funcionario_codigo) references Funcionario(codigo)
)

create table Venda(
	codigo int identity(1,1),
	data date,
	desconto float,
	valorTotal float,
	cliente_codigo int,
	primary key(codigo),
	foreign key(cliente_codigo) references Cliente(codigo)
)

create table ItemVenda(
	codigo int identity(1,1),
	peso float,
	preco_kg float,
	valoTotal float,
	venda_codigo int,
	produto_codigo int,
	primary key(codigo),
	foreign key(venda_codigo) references Venda(codigo),
	foreign key(produto_codigo) references Produto(codigo)
)

create table Compra(
	codigo int identity(1,1),
	data date,
	desconto float,
	valorTotal float,
	fornecedor_codigo int,
	primary key(codigo),
	foreign key(fornecedor_codigo) references Fornecedor(codigo)
)

create table ItemCompra(
	codigo int identity(1,1),
	unidade varchar(2),
	quantidade float,
	precoUnitario float,
	valorTotal float,
	compra_codigo int,
	produto_codigo int,
	primary key(codigo),
	foreign key(compra_codigo) references Compra(codigo),
	foreign key(produto_codigo) references Produto(codigo)
)
