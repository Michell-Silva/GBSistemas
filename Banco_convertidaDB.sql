create database gbsistema;
use gbsistema;


CREATE TABLE Usuario (
  idUsuario INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  nome VARCHAR(255) NULL,
  email VARCHAR(45) NULL,
  login VARCHAR(45) NULL,
  senha VARCHAR(45) NULL,
  confsenha Varchar (45) null,
  PRIMARY KEY(idUsuario)
);

CREATE TABLE Cliente (
  idCliente INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  Cidade_Estado_idEstado INTEGER UNSIGNED NOT NULL,
  Cidade_idCidade INTEGER UNSIGNED NOT NULL,
  Cliente VARCHAR(255) NULL,
  CPF VARCHAR(45) NULL,
  Rua VARCHAR(45) NULL,
  Nº VARCHAR(20) NULL,
  Bairro  VARCHAR(45) NULL,
  Cidade  VARCHAR(45) NULL,
  UF VARCHAR(45) NULL,
  CEP VARCHAR(45) NULL,
  Telefone  INT NULL,
  Celular INT NULL,
  Email VARCHAR(255) NULL,
  PRIMARY KEY(idCliente, Cidade_Estado_idEstado, Cidade_idCidade),
  INDEX Cliente_FKIndex1(Cidade_idCidade, Cidade_Estado_idEstado)
);

CREATE TABLE Fornecedor (
  idForn INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,  
  NomeForn VARCHAR(255) NULL,
  CNPJ varchar(45) NULL,
  Rua  VARCHAR(45) NULL,
  Nº VARCHAR(20) NULL,
  Bairro  VARCHAR(45) NULL,
  Cidade VARCHAR(45) NULL,
  UF VARCHAR(45) NULL,
  CEP VARCHAR(45) NULL,
  Telefone VARCHAR(45)  NULL,
  Email VARCHAR(255) NULL,
  Contato VARCHAR(255) NULL,
  Cidade_Estado_idEstado INTEGER UNSIGNED NOT NULL,
  Cidade_idCidade INTEGER UNSIGNED NOT NULL,
  PRIMARY KEY(idFornecedor, Cidade_Estado_idEstado, Cidade_idCidade),
  INDEX Fornecedor_FKIndex1(Cidade_idCidade, Cidade_Estado_idEstado)
);

CREATE TABLE Produto (
  idProduto INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  Codigo INT UNSIGNED ZEROFILL NULL,
  Descrição VARCHAR(45) NULL,
  preco INT NULL,
  PRIMARY KEY(idProduto)
);


CREATE TABLE Compra (
  idCompra INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,  
  idFornecedor INTEGER UNSIGNED NOT NULL,
  Forma_Pagamento_idForma_Pagamento INTEGER UNSIGNED NOT NULL,
  Data_compra VARCHAR(20) NULL,
  Valor_total DOUBLE NULL,
  Desconto DOUBLE NULL,
  PRIMARY KEY(idCompra) 
);



CREATE TABLE Forma_Pagamento (
  idForma_Pagamento INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  Descricao VARCHAR(45) NULL,
  Desconto NUMERIC NULL,
  Acrescimo NUMERIC NULL,  
  PRIMARY KEY(idForma_Pagamento)
);


CREATE TABLE Itens_compras (
  idItens_compras INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  Compra_Fornecedor_idFornecedor INTEGER UNSIGNED NOT NULL,
  Compra_Fornecedor_Cidade_Estado_idEstado INTEGER UNSIGNED NOT NULL,
  Compra_Fornecedor_Cidade_idCidade INTEGER UNSIGNED NOT NULL,
  Compra_idCompra INTEGER UNSIGNED NOT NULL,
  Produto_idProduto INTEGER UNSIGNED NOT NULL,
  produto VARCHAR(255) NULL,
  quantidade INT NULL,
  valor_unit DOUBLE NULL,
  valor_total DOUBLE NULL,
  PRIMARY KEY(idItens_compras, Compra_Fornecedor_idFornecedor, Compra_Fornecedor_Cidade_Estado_idEstado, Compra_Fornecedor_Cidade_idCidade, Compra_idCompra, Produto_idProduto),
  INDEX Itens_compras_FKIndex1(Compra_idCompra, Compra_Fornecedor_Cidade_idCidade, Compra_Fornecedor_Cidade_Estado_idEstado, Compra_Fornecedor_idFornecedor),
  INDEX Itens_compras_FKIndex2(Produto_idProduto)
);

CREATE TABLE Itens_vendas (
  idItens_vendas INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  Produto_idProduto INTEGER UNSIGNED NOT NULL,
  Vendas_idVendas INTEGER UNSIGNED NOT NULL,
  Vendas_Usuario_idUsuario INTEGER UNSIGNED NOT NULL,
  Vendas_Forma_Pagamento_idForma_Pagamento INTEGER UNSIGNED NOT NULL,
  Vendas_Cliente_idCliente INTEGER UNSIGNED NOT NULL,
  Vendas_Cliente_Cidade_Estado_idEstado INTEGER UNSIGNED NOT NULL,
  Vendas_Cliente_Cidade_idCidade INTEGER UNSIGNED NOT NULL,
  produto VARCHAR(255) NULL,
  quantidade INT NULL,
  valor_unit DOUBLE NULL,
  valor_total DOUBLE NULL,
  PRIMARY KEY(idItens_vendas, Produto_idProduto, Vendas_idVendas, Vendas_Usuario_idUsuario, Vendas_Forma_Pagamento_idForma_Pagamento, Vendas_Cliente_idCliente, Vendas_Cliente_Cidade_Estado_idEstado, Vendas_Cliente_Cidade_idCidade),
  INDEX Itens_vendas_FKIndex1(Produto_idProduto),
  INDEX Itens_vendas_FKIndex2(Vendas_idVendas, Vendas_Usuario_idUsuario, Vendas_Forma_Pagamento_idForma_Pagamento, Vendas_Cliente_idCliente, Vendas_Cliente_Cidade_idCidade, Vendas_Cliente_Cidade_Estado_idEstado)
);





CREATE TABLE Vendas (
  idVendas INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  Usuario_idUsuario INTEGER UNSIGNED NOT NULL,
  Forma_Pagamento INTEGER UNSIGNED NOT NULL,
  Cliente_idCliente INTEGER UNSIGNED NOT NULL,
  Cliente_Cidade_idCidade INTEGER UNSIGNED NOT NULL,
  Cliente_Cidade_Estado_idEstado INTEGER UNSIGNED NOT NULL,
  Data_venda VARCHAR(20) NULL,
  Valor_Total DOUBLE NULL,
  Desconto DOUBLE NULL,
  PRIMARY KEY(idVendas, Usuario_idUsuario, Forma_Pagamento_idForma_Pagamento, Cliente_idCliente, Cliente_Cidade_idCidade, Cliente_Cidade_Estado_idEstado),
  INDEX Vendas_FKIndex1(Usuario_idUsuario),
  INDEX Vendas_FKIndex2(Forma_Pagamento_idForma_Pagamento),
  INDEX Vendas_FKIndex3(Cliente_idCliente, Cliente_Cidade_Estado_idEstado, Cliente_Cidade_idCidade)
);


