-- 8. Crie uma consulta para relacionar todos os dados disponíveis de todos os dinossauros existentes em ordem alfabética de Descobridor

SELECT nome_dinossauro, nome_grupo, toneladas, ano_descoberta, nome_descobridor, nome_era, inicio, fim, nome_pais
    FROM dinossauros, grupos, eras, descobridores, paises
    WHERE fk_grupo = id_grupo
    AND fk_era = id_era
    AND fk_descobridor = id_descobridor
    AND fk_pais = id_pais
    ORDER BY nome_descobridor;
