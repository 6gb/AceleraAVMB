CREATE TABLE autor (id INTEGER PRIMARY KEY AUTOINCREMENT, nome VARCHAR(50), nacionalidade VARCHAR(20))
CREATE TABLE livro (isbn INTEGER PRIMARY KEY, titulo varchar(50), ano_publicacao varchar(4), fk_editora integer foreign key, 
