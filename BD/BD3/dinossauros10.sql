-- 10. Crie uma consulta para relacionar todos os dados disponíveis dos dinossauros ceratopsídeos ou anquilossauros com ano de descoberta entre 1900 e 1999

SELECT nome_dinossauro, nome_grupo, toneladas, ano_descoberta, nome_descobridor, nome_era, inicio, fim, nome_pais
    FROM dinossauros, grupos, eras, descobridores, paises
    WHERE fk_grupo = id_grupo
    AND fk_era = id_era
    AND fk_descobridor = id_descobridor
    AND fk_pais = id_pais
    AND (nome_grupo = 'Ceratopsídeos' OR nome_grupo = 'Anquilossauros')
    AND ano_descoberta >= 1900
    AND ano_descoberta <= 1999
    ORDER BY nome_dinossauro;
