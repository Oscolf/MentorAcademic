-- Crear base de datos y usarla
drop database if exists mentoracademic;
create database mentoracademic;
use mentoracademic;

-- Crear tablas

CREATE TABLE clubes (
idClub int NOT NULL PRIMARY KEY AUTO_INCREMENT,
nombre varchar(100) NOT NULL,
descripcion text DEFAULT NULL
);

CREATE TABLE materias (
idMateria int NOT NULL PRIMARY KEY AUTO_INCREMENT,
nombre varchar(100) NOT NULL,
descripcion text DEFAULT NULL
);

CREATE TABLE profesores (
idProfesor int NOT NULL PRIMARY KEY AUTO_INCREMENT,
nombre varchar(50) NOT NULL,
apellido varchar(50) NOT NULL,
email varchar(100) NOT NULL UNIQUE,
idMateria int DEFAULT NULL
);

CREATE TABLE alumnos (
idAlumno int NOT NULL PRIMARY KEY AUTO_INCREMENT,
nombre varchar(50) NOT NULL,
apellido varchar(50) NOT NULL,
email varchar(100) NOT NULL UNIQUE,
contasena varchar(100) NOT NULL,
fecha_nacimiento date NOT NULL,
club_pertenece int DEFAULT NULL
);

CREATE TABLE asesorias (
idAsesoria int NOT NULL PRIMARY KEY AUTO_INCREMENT,
idAlumno int NOT NULL,
idProfesor int NOT NULL,
fecha date NOT NULL,
hora time NOT NULL
);

CREATE TABLE encargadosclubes (
idEncargado int NOT NULL PRIMARY KEY AUTO_INCREMENT,
idClub int NOT NULL,
nombre varchar(50) NOT NULL,
apellido varchar(50) NOT NULL,
email varchar(100) NOT NULL UNIQUE
);

-- Agregar llaves foráneas

ALTER TABLE alumnos
    ADD CONSTRAINT fk_alumnos_club
        FOREIGN KEY (club_pertenece) REFERENCES clubes(idClub);

ALTER TABLE profesores
    ADD CONSTRAINT fk_profesores_materia
        FOREIGN KEY (idMateria) REFERENCES materias(idMateria);

ALTER TABLE asesorias
    ADD CONSTRAINT fk_asesorias_alumno
        FOREIGN KEY (idAlumno) REFERENCES alumnos(idAlumno),
    ADD CONSTRAINT fk_asesorias_profesor
        FOREIGN KEY (idProfesor) REFERENCES profesores(idProfesor);

ALTER TABLE encargadosclubes
    ADD CONSTRAINT fk_encargadosclubes_club
        FOREIGN KEY (idClub) REFERENCES clubes(idClub);