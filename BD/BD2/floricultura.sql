BEGIN;

CREATE TABLE clientes (
    rg VARCHAR(10) CONSTRAINT pk_cliente PRIMARY KEY,
    nome_cliente VARCHAR(50),
    telefone VARCHAR(20),
    endereco VARCHAR(50)
);

CREATE TABLE tipos_produto (
    id_tipo SERIAL CONSTRAINT pk_tipo PRIMARY KEY,
    nome_tipo VARCHAR(50)
);

CREATE TABLE produtos (
    id_produto SERIAL CONSTRAINT pk_produto PRIMARY KEY,
    nome_produto VARCHAR(50),
    fk_tipo INTEGER NOT NULL,
    preco DECIMAL(6, 2),
    quantidade_estoque INTEGER,
    FOREIGN KEY (fk_tipo) REFERENCES tipos_produto(id_tipo)
);

CREATE TABLE compras (
    id_compra SERIAL CONSTRAINT pk_compra PRIMARY KEY,
    fk_cliente VARCHAR(10) NOT NULL,
    data_compra DATE,
    valor_total DECIMAL(8, 2),
    FOREIGN KEY (fk_cliente) REFERENCES clientes(rg)
);

CREATE TABLE produtos_comprados (
    fk_compra INTEGER REFERENCES compras,
    fk_produto INTEGER REFERENCES produtos,
    quantidade INTEGER,
    PRIMARY KEY (fk_compra, fk_produto)
);

COMMIT;
