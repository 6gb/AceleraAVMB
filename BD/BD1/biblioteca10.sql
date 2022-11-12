-- 10. Crie uma consulta para relacionar todos os dados disponíveis dos livros de humor ou ficção científica com ano entre 2000 e 2010

SELECT isbn, titulo_livro, ano_publicacao, nome_editora, nome_autor, nome_pais, nome_categoria FROM livros, editoras, autores, paises, categorias
	WHERE fk_editora = id_editora
	AND fk_autor = id_autor
	AND fk_nacionalidade = id_pais
	AND fk_categoria = id_categoria
	AND ano_publicacao >= 2000
	AND ano_publicacao <= 2010
	AND (nome_categoria = 'Humor' OR nome_categoria = 'Ficção Científica')
