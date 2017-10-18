create table Cliente(
	codigo int,
	nome varchar(50),
	telefones varchar(30),
	cidade varchar(50),
	estado varchar(50),
	endereco varchar(85),
	cpf_cnpj varchar(14),
	email varchar(320),
	primary key(codigo)
)

create table Fornecedor(
	codigo int,
	nome varchar(50),
	telefones varchar(30),
	cidade varchar(50),
	estado varchar(50),
	cpf_cnpj varchar(14),
	email varchar(320),
	primary key(codigo)
)

create table Produto(
	codigo int,
	decricao varchar(50),
	primary key(codigo)
)

create table Venda(
	codigo int,
	data date,
	desconto float,
	valorTotal float,
	cliente_codigo int,
	primary key(codigo),
	foreign key(cliente_codigo) references Cliente(codigo)
)

create table ItemVenda(
	codigo int,
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
	codigo int,
	data date,
	desconto float,
	valorTotal float,
	fornecedor_codigo int,
	primary key(codigo),
	foreign key(fornecedor_codigo) references Fornecedor(codigo)
)

create table ItemCompra(
	codigo int,
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

create table Funcionario(
	codigo int,
	nome varchar(50),
	telefones varchar(30),
	identidade varchar(9),
	clt varchar(16),
	salario float,
	motorista bit,
	tecnico bit,
	observacao varchar(150),
	primary key(codigo)
)

create table PagamentoSalario(
	codigo int,
	data date,
	mesReferente int,
	anoReferente int,
	valorPago float,
	funcionario_codigo int,
	primary key(codigo),
	foreign key(funcionario_codigo) references Funcionario(codigo)
)