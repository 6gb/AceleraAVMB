-- 6. Crie o comando SQL para inserção de pelo menos 3 registros acima, em todas as tabelas necessárias

BEGIN;

INSERT INTO eras (nome_era) VALUES ('Cretáceo'), ('Jurássico');

INSERT INTO grupos (nome_grupo, fk_era) VALUES
    ('Anquilossauros', (SELECT id_era FROM eras WHERE nome_era = 'Cretáceo')),
    ('Ceratopsídeos', (SELECT id_era FROM eras WHERE nome_era = 'Cretáceo')),
    ('Estegossauros', (SELECT id_era FROM eras WHERE nome_era = 'Jurássico')),
    ('Terápodes', (SELECT id_era FROM eras WHERE nome_era = 'Jurássico'));

INSERT INTO descobridores (nome_descobridor) VALUES
    ('Maryanska'), ('John Bell Hatcher'), ('Cientistas Alemães'), ('Museu Americano de História Natural'),
    ('Othniel Charles Marsh'), ('Barnum Brown');

INSERT INTO paises (nome_pais) VALUES
    ('Mongólia'), ('Canadá'), ('Tanzânia'), ('China'), ('América do Norte'), ('USA');

INSERT INTO dinossauros (nome_dinossauro, toneladas, ano_descoberta, inicio, fim, fk_grupo, fk_descobridor, fk_pais) VALUES
    ('Saichania', 4, 1997, 145, 66,
        (SELECT id_grupo FROM grupos WHERE nome_grupo = 'Anquilossauros'),
        (SELECT id_descobridor FROM descobridores WHERE nome_descobridor = 'Maryanska'),
        (SELECT id_pais FROM paises WHERE nome_pais = 'Mongólia')),
    ('Tricerátops', 6, 1887, 70, 66,
        (SELECT id_grupo FROM grupos WHERE nome_grupo = 'Ceratopsídeos'),
        (SELECT id_descobridor FROM descobridores WHERE nome_descobridor = 'John Bell Hatcher'),
        (SELECT id_pais FROM paises WHERE nome_pais = 'Canadá')),
    ('Kentrossauro', 2, 1909, 201, 145,
        (SELECT id_grupo FROM grupos WHERE nome_grupo = 'Estegossauros'),
        (SELECT id_descobridor FROM descobridores WHERE nome_descobridor = 'Cientistas Alemães'),
        (SELECT id_pais FROM paises WHERE nome_pais = 'Tanzânia')),
    ('Pinacossauro', 6, 1999, 85, 75,
        (SELECT id_grupo FROM grupos WHERE nome_grupo = 'Anquilossauros'),
        (SELECT id_descobridor FROM descobridores WHERE nome_descobridor = 'Museu Americano de História Natural'),
        (SELECT id_pais FROM paises WHERE nome_pais = 'China')),
    ('Alossauro', 3, 1877, 155, 150,
        (SELECT id_grupo FROM grupos WHERE nome_grupo = 'Terápodes'),
        (SELECT id_descobridor FROM descobridores WHERE nome_descobridor = 'Othniel Charles Marsh'),
        (SELECT id_pais FROM paises WHERE nome_pais = 'América do Norte')),
    ('Torossauro', 8, 1891, 67, 65,
        (SELECT id_grupo FROM grupos WHERE nome_grupo = 'Ceratopsídeos'),
        (SELECT id_descobridor FROM descobridores WHERE nome_descobridor = 'John Bell Hatcher'),
        (SELECT id_pais FROM paises WHERE nome_pais = 'USA')),
    ('Anquilossauro', 8, 1906, 66, 63,
        (SELECT id_grupo FROM grupos WHERE nome_grupo = 'Anquilossauros'),
        (SELECT id_descobridor FROM descobridores WHERE nome_descobridor = 'Barnum Brown'),
        (SELECT id_pais FROM paises WHERE nome_pais = 'América do Norte'));

COMMIT;
