-- 7. Crie uma consulta para relacionar todos os dados disponíveis de todos os livros existentes na biblioteca em ordem alfabética de título

SELECT isbn, titulo_livro, ano_publicacao, nome_editora, nome_autor, nome_pais, nome_categoria
    FROM livros, editoras, autores, paises, categorias
    WHERE fk_editora = id_editora
    AND fk_autor = id_autor
    AND fk_nacionalidade = id_pais
    AND fk_categoria = id_categoria
    ORDER BY titulo_livro
