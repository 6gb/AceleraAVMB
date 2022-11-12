BEGIN;

CREATE TABLE maes (
    id_mae SERIAL CONSTRAINT pk_mae PRIMARY KEY,
    nome_mae VARCHAR(50),
    endereco_mae VARCHAR(50),
    telefone_mae VARCHAR(20),
    data_nascimento_mae DATE
);

CREATE TABLE especialidades (
    id_especialidade SERIAL CONSTRAINT pk_especialidade PRIMARY KEY,
    nome_especialidade VARCHAR(50)
);

CREATE TABLE medicos (
    crm INTEGER CONSTRAINT pk_medico PRIMARY KEY,
    nome_medico VARCHAR(50),
    telefone_medico VARCHAR(20),
    fk_especialidade INTEGER NOT NULL,
    FOREIGN KEY (fk_especialidade) REFERENCES especialidades(id_especialidade)
);

CREATE TABLE recem_nascidos (
    id_recem_nascido SERIAL CONSTRAINT pk_recem_nascido PRIMARY KEY,
    nome_recem_nascido VARCHAR(50),
    data_nascimento_recem_nascido DATE,
    peso DECIMAL(5, 3),
    altura DECIMAL(3, 2),
    fk_mae INTEGER NOT NULL,
    fk_medico INTEGER NOT NULL,
    FOREIGN KEY (fk_mae) REFERENCES maes(id_mae),
    FOREIGN KEY (fk_medico) REFERENCES medicos(crm)
);

COMMIT;
