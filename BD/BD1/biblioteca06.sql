-- 6. Crie o comando SQL para a inserção dos referidos dados em todas as tabelas

BEGIN;

INSERT INTO paises (nome_pais) VALUES ('Brasil'), ('Inglaterra');

INSERT INTO autores (nome_autor, fk_nacionalidade) VALUES
    ('J. K. Rowling', (SELECT id_pais FROM paises WHERE nome_pais = 'Inglaterra')),
    ('Clive Staples Lewis', (SELECT id_pais FROM paises WHERE nome_pais = 'Brasil')),
    ('Affonso Solano', (SELECT id_pais FROM paises WHERE nome_pais = 'Brasil')),
    ('Marcos Piangers', (SELECT id_pais FROM paises WHERE nome_pais = 'Brasil')),
    ('Ciro Botelho - Tiririca', (SELECT id_pais FROM paises WHERE nome_pais = 'Brasil')),
    ('Bianca Mól', (SELECT id_pais FROM paises WHERE nome_pais = 'Inglaterra'));

INSERT INTO editoras (nome_editora) VALUES
    ('Rocco'), ('Wmf Martins Fontes'), ('Casa da Palavra'), ('Belas Letras'), ('Matrix');

INSERT INTO categorias (nome_categoria) VALUES
    ('Literatura Juvenil'), ('Ficção Científica'), ('Humor');

INSERT INTO livros (isbn, titulo_livro, ano_publicacao, fk_editora, fk_categoria, fk_autor) VALUES
    (8532511015, 'Harry Potter e A Pedra Filosofal', 2000,
        (SELECT id_editora FROM editoras WHERE nome_editora = 'Rocco'),
        (SELECT id_categoria FROM categorias WHERE nome_categoria = 'Literatura Juvenil'),
        (SELECT id_autor FROM autores WHERE nome_autor = 'J. K. Rowling')),
    (9788578270698, 'As Crônicas de Nárnia', 2009,
        (SELECT id_editora FROM editoras WHERE nome_editora = 'Wmf Martins Fontes'),
        (SELECT id_categoria FROM categorias WHERE nome_categoria = 'Literatura Juvenil'),
        (SELECT id_autor FROM autores WHERE nome_autor = 'Clive Staples Lewis')),
    (9788577343348, 'O Espadachim de Carvão', 2013,
        (SELECT id_editora FROM editoras WHERE nome_editora = 'Casa da Palavra'),
        (SELECT id_categoria FROM categorias WHERE nome_categoria = 'Ficção Científica'),
        (SELECT id_autor FROM autores WHERE nome_autor = 'Affonso Solano')),
    (9788581742458, 'O Papai É Pop', 2015,
        (SELECT id_editora FROM editoras WHERE nome_editora = 'Belas Letras'),
        (SELECT id_categoria FROM categorias WHERE nome_categoria = 'Humor'),
        (SELECT id_autor FROM autores WHERE nome_autor = 'Marcos Piangers')),
    (9788582302026, 'Pior Que Tá Não Fica', 2015,
        (SELECT id_editora FROM editoras WHERE nome_editora = 'Matrix'),
        (SELECT id_categoria FROM categorias WHERE nome_categoria = 'Humor'),
        (SELECT id_autor FROM autores WHERE nome_autor = 'Ciro Botelho - Tiririca')),
    (9788577345670, 'Garota Desdobrável', 2015,
        (SELECT id_editora FROM editoras WHERE nome_editora = 'Casa da Palavra'),
        (SELECT id_categoria FROM categorias WHERE nome_categoria = 'Literatura Juvenil'),
        (SELECT id_autor FROM autores WHERE nome_autor = 'Bianca Mól')),
    (8532512062, 'Harry Potter e O Prisioneiro de Azkaban', 2000,
        (SELECT id_editora FROM editoras WHERE nome_editora = 'Rocco'),
        (SELECT id_categoria FROM categorias WHERE nome_categoria = 'Literatura Juvenil'),
        (SELECT id_autor FROM autores WHERE nome_autor = 'J. K. Rowling'));

COMMIT;
