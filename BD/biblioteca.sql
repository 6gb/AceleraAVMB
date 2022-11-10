CREATE TABLE autor (
    id SERIAL PRIMARY KEY,
    nome VARCHAR(50),
    nacionalidade VARCHAR(20)
)

CREATE TABLE editora (
    id SERIAL PRIMARY KEY,
    nome VARCHAR(50)
)

CREATE TABLE categoria (
    id SERIAL PRIMARY KEY,
    tipo_categoria VARCHAR(50)
)

CREATE TABLE livro (
    isbn INTEGER PRIMARY KEY,
    titulo VARCHAR(50),
    ano_publicacao VARCHAR(4),
    fk_editora INTEGER NOT NULL,
    fk_categoria INTEGER NOT NULL,
    FOREIGN KEY (fk_editora) REFERENCES editora (id),
    FOREIGN KEY (fk_categoria) REFERENCES categoria (id)
)

CREATE TABLE livroautor (
    id SERIAL PRIMARY KEY,
    fk_livro INTEGER NOT NULL,
    fk_autor INTEGER NOT NULL,
    FOREIGN KEY (fk_livro) REFERENCES livro (id),
    FOREIGN KEY (fk_autor) REFERENCES autor (id)
)
