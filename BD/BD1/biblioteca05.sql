-- 5. Crie o comando SQL para a criação das tabelas solicitadas

BEGIN;

CREATE TABLE IF NOT EXISTS nacionalidades (
    id_nacionalidade SERIAL CONSTRAINT pk_nacionalidade PRIMARY KEY,
    nome_país VARCHAR(50)
);

CREATE TABLE IF NOT EXISTS autores (
    id_autor SERIAL CONSTRAINT pk_autor PRIMARY KEY,
    nome_autor VARCHAR(50),
    fk_nacionalidade INTEGER NOT NULL,
    FOREIGN KEY (fk_nacionalidade) REFERENCES nacionalidades (id_nacionalidade)
);

CREATE TABLE IF NOT EXISTS editoras (
    id_editora SERIAL CONSTRAINT pk_editora PRIMARY KEY,
    nome_editora VARCHAR(50)
);

CREATE TABLE IF NOT EXISTS categorias (
    id_categoria SERIAL CONSTRAINT pk_categoria PRIMARY KEY,
    tipo_categoria VARCHAR(50)
);

CREATE TABLE IF NOT EXISTS livros (
    isbn INTEGER CONSTRAINT pk_livro PRIMARY KEY,
    titulo_livro VARCHAR(50),
    data_publicacao DATE,
    fk_editora INTEGER NOT NULL,
    fk_categoria INTEGER NOT NULL,
    FOREIGN KEY (fk_editora) REFERENCES editoras (id_editora),
    FOREIGN KEY (fk_categoria) REFERENCES categorias (id_categoria)
);

CREATE TABLE IF NOT EXISTS livroautor (
    fk_livro INTEGER REFERENCES livros,
    fk_autor INTEGER REFERENCES autores,
    PRIMARY KEY (fk_livro, fk_autor)
);

END;
