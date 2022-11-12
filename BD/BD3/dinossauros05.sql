-- 5. Crie o comando SQL para a criação das tabelas solicitadas

BEGIN;

CREATE TABLE IF NOT EXISTS eras (
    id_era SERIAL CONSTRAINT pk_era PRIMARY KEY,
    nome_era VARCHAR(50)
);

CREATE TABLE IF NOT EXISTS grupos (
    id_grupo SERIAL CONSTRAINT pk_grupo PRIMARY KEY,
    nome_grupo VARCHAR(50),
    fk_era INTEGER NOT NULL,
    FOREIGN KEY (fk_era) REFERENCES eras (id_era)
);

CREATE TABLE IF NOT EXISTS descobridores (
    id_descobridor SERIAL CONSTRAINT pk_descobridor PRIMARY KEY,
    nome_descobridor VARCHAR(50)
);

CREATE TABLE IF NOT EXISTS paises (
    id_pais SERIAL CONSTRAINT pk_pais PRIMARY KEY,
    nome_pais VARCHAR(50)
);

CREATE TABLE IF NOT EXISTS dinossauros (
    id_dinossauro SERIAL CONSTRAINT pk_dinossauro PRIMARY KEY,
    nome_dinossauro VARCHAR(50),
    toneladas SMALLINT,
    ano_descoberta SMALLINT,
    inicio SMALLINT,
    fim SMALLINT,
    fk_grupo INTEGER NOT NULL,
    fk_descobridor INTEGER NOT NULL,
    fk_pais INTEGER NOT NULL,
    FOREIGN KEY (fk_grupo) REFERENCES grupos (id_grupo),
    FOREIGN KEY (fk_descobridor) REFERENCES descobridores (id_descobridor),
    FOREIGN KEY (fk_pais) REFERENCES paises (id_pais)
);

COMMIT;
