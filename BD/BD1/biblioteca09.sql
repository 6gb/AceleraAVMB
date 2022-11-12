-- 9. Crie uma consulta para relacionar todos os dados disponíveis dos livros da categoria de literatura Juvenil em ordem de ano

SELECT isbn, titulo_livro, ano_publicacao, nome_editora, nome_autor, nome_pais, nome_categoria
    FROM livros, editoras, autores, paises, categorias
    WHERE fk_editora = id_editora
    AND fk_autor = id_autor
    AND fk_nacionalidade = id_pais
    AND fk_categoria = id_categoria
    AND nome_categoria = 'Literatura Juvenil'
    ORDER BY ano_publicacao
