-- 5. Crie o comando SQL para a criação das tabelas solicitadas

BEGIN;

CREATE TABLE IF NOT EXISTS paises (
    id_pais SERIAL CONSTRAINT pk_pais PRIMARY KEY,
    nome_pais VARCHAR(50)
);

CREATE TABLE IF NOT EXISTS autores (
    id_autor SERIAL CONSTRAINT pk_autor PRIMARY KEY,
    nome_autor VARCHAR(50),
    fk_nacionalidade INTEGER NOT NULL,
    FOREIGN KEY (fk_nacionalidade) REFERENCES paises (id_pais)
);

CREATE TABLE IF NOT EXISTS editoras (
    id_editora SERIAL CONSTRAINT pk_editora PRIMARY KEY,
    nome_editora VARCHAR(50)
);

CREATE TABLE IF NOT EXISTS categorias (
    id_categoria SERIAL CONSTRAINT pk_categoria PRIMARY KEY,
    nome_categoria VARCHAR(50)
);

CREATE TABLE IF NOT EXISTS livros (
    isbn BIGINT CONSTRAINT pk_livro PRIMARY KEY,
    titulo_livro VARCHAR(50),
    ano_publicacao SMALLINT,
    fk_editora INTEGER NOT NULL,
    fk_categoria INTEGER NOT NULL,
    fk_autor INTEGER NOT NULL,
    FOREIGN KEY (fk_editora) REFERENCES editoras (id_editora),
    FOREIGN KEY (fk_categoria) REFERENCES categorias (id_categoria),
    FOREIGN KEY (fk_autor) REFERENCES autores (id_autor)
);

--CREATE TABLE IF NOT EXISTS livroautor (
--    fk_livro BIGINT REFERENCES livros,
--    fk_autor INTEGER REFERENCES autores,
--    PRIMARY KEY (fk_livro, fk_autor)
--);

COMMIT;
