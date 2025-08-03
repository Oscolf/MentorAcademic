-- Crear base de datos y usarla
drop database if exists mentoracademic;
create database mentoracademic;
use mentoracademic;

-- Crear tablas

CREATE TABLE clubes
(
    idClub      int          NOT NULL PRIMARY KEY AUTO_INCREMENT,
    nombre      varchar(100) NOT NULL,
    descripcion text DEFAULT NULL
);

CREATE TABLE materias
(
    idMateria   int          NOT NULL PRIMARY KEY AUTO_INCREMENT,
    nombre      varchar(100) NOT NULL,
    descripcion text DEFAULT NULL
);

CREATE TABLE profesores
(
    idProfesor  int          NOT NULL PRIMARY KEY AUTO_INCREMENT,
    nombre      varchar(50)  NOT NULL,
    apellido    varchar(50)  NOT NULL,
    email       varchar(100) NOT NULL UNIQUE,
    horario	    int 		 DEFAULT NULL,
    idMateria   int          NOT NULL
);

CREATE TABLE horarios
(
    idHorario   int          NOT NULL PRIMARY KEY AUTO_INCREMENT,
    idProfesor  int          NOT NULL,
    dia         enum         ('Lunes', 'Martes', 'Miércoles', 'Jueves', 'Viernes') NOT NULL,
    hora_inicio time         NOT NULL,
    hora_fin    time         NOT NULL
);

CREATE TABLE alumnos
(
    matricula       varchar(10)  UNIQUE,
    nombre          varchar(50)  NOT NULL,
    apellido        varchar(50)  NOT NULL,
    email           varchar(100) NOT NULL UNIQUE,
    contasena       varchar(100) NOT NULL,
    numero_telefono int DEFAULT NULL,
    nss             int DEFAULT NULL,
    club_pertenece  int DEFAULT NULL
);

CREATE TABLE asesorias
(
    idAsesoria int                                           NOT NULL PRIMARY KEY AUTO_INCREMENT,
    idAlumno   varchar(10)                                   NOT NULL,
    idProfesor int                                           NOT NULL,
    fecha      date                                          NOT NULL,
    hora       time                                          NOT NULL,
    estado     enum ('Pendiente', 'Confirmada', 'Cancelada') NOT NULL DEFAULT 'Pendiente'
);

CREATE TABLE encargadosclubes
(
    idEncargado int          NOT NULL PRIMARY KEY AUTO_INCREMENT,
    idClub      int          NOT NULL,
    nombre      varchar(50)  NOT NULL,
    apellido    varchar(50)  NOT NULL,
    email       varchar(100) NOT NULL UNIQUE
); 
-- Agregar llaves foráneas

ALTER TABLE alumnos
    ADD CONSTRAINT fk_alumnos_club
        FOREIGN KEY (club_pertenece) REFERENCES clubes(idClub);

ALTER TABLE profesores
    ADD CONSTRAINT fk_profesores_materia
        FOREIGN KEY (idMateria) REFERENCES materias(idMateria);
        
ALTER TABLE horarios
	ADD CONSTRAINT fk_horarios_profesor
		FOREIGN KEY (idProfesor) REFERENCES profesores(idProfesor);
        
ALTER TABLE asesorias
    ADD CONSTRAINT fk_asesorias_alumno
        FOREIGN KEY (idAlumno) REFERENCES alumnos(matricula),
    ADD CONSTRAINT fk_asesorias_profesor
        FOREIGN KEY (idProfesor) REFERENCES profesores(idProfesor);

ALTER TABLE encargadosclubes
    ADD CONSTRAINT fk_encargadosclubes_club
        FOREIGN KEY (idClub) REFERENCES clubes(idClub);
