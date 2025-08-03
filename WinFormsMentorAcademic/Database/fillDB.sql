USE mentoracademic;

INSERT INTO clubes (nombre, descripcion) 
VALUES
    ('Atletísmo', 'Club de atletismo de la universidad'),
    ('Basquetbol', 'Club de basquetbol de la universidad'),
    ('Beisbol', 'Club de beisbol de la universidad'),
    ('Crossfit', 'Club de crossfit de la universidad'),
    ('Defensa Personal', 'Club de defensa personal de la universidad'),
    ('Futbol', 'Club de futbol de la universidad'),
    ('Karate', 'Club de karate de la universidad'),
    ('Kendo', 'Club de kendo de la universidad'),
    ('Tae-kwon-do', 'Club de tae-kwon-do de la universidad'),
    ('Voleybol', 'Club de voleybol de la universidad'),
    ('Ajedrez', 'Club de ajedrez de la universidad'),
    ('Banda de Guerra', 'Club de banda de guerra de la universidad'),
    ('Danza Folklórica', 'Club de danza folklórica de la universidad'),
    ('Porristas', 'Club de porristas de la universidad'),
    ('Rondalla y Canto', 'Club de rondalla y canto de la universidad'),
    ('Ritmos Latinos', 'Club de ritmos latinos de la universidad');

INSERT INTO materias (nombre, descripcion)
VALUES 
    ('Base de Datos', 'Curso de introducción a bases de datos'),
    ('Cálculo Integral', 'Curso de cálculo integral'),
    ('Desarrollo del Pensamiento y Toma de decisiones ', 'Curso de desarrollo del pensamiento crítico y toma de decisiones'),
    ('Inglés III', 'Curso de inglés nivel principiante'),
    ('Programación Orientada a Objetos', 'Curso de programación orientada a objetos en C#'),
    ('Proyecto Integrador I', 'Elaboración de un protoipo de un software apuntando a una necesidad real'),
    ('Tópicos de Calidad para el Diseño de Software', 'Curso acerca de la calidad en el desarrollo de software');

INSERT INTO profesores (nombre, apellido, email, idMateria)
VALUES
    ('Berenice Anabella', 'Leal Fuentes', 'berenice.leal@utpuebla.edu.mx', 1),
    ('Antonio', 'Cid García', 'antonio.cid@utpuebla.edu.mx', 2),
    ('Ana María', 'Ramírez Casco', 'ana.ramirez@utpuebla.edu.mx', 3),
    ('María del Rocío', 'Camarillo Huerta', 'maria.camarillo@utpuebla.edu.mx', 4),
    ('Guillermo', 'Sánchez Flores', 'guillermo.sanchez@utpuebla.edu.mx', 5),
    ('José de Jesús', 'García Sánchez', 'jose.garcia@utpuebla.edu.mx', 6),
    ('Julia Elena', 'Pérez Martínez', 'julia.perez@utpuebla.edu.mx', 7);

INSERT INTO horarios (idProfesor, dia, hora_inicio, hora_fin)
VALUES
    (1, 'Lunes', '08:00:00', '10:00:00'),
    (2, 'Martes', '10:00:00', '12:00:00'),
    (3, 'Miércoles', '12:00:00', '14:00:00'),
    (4, 'Jueves', '14:00:00', '16:00:00'),
    (5, 'Viernes', '16:00:00', '18:00:00'),
    (6, 'Lunes', '10:00:00', '12:00:00'),
    (7, 'Martes', '08:00:00', '10:00:00'),
    (2, 'Lunes', '12:00:00', '14:00:00'),
    (3, 'Martes', '14:00:00', '16:00:00'),
    (4, 'Miércoles', '08:00:00', '10:00:00'),
    (5, 'Jueves', '10:00:00', '12:00:00'),
    (6, 'Viernes', '12:00:00', '14:00:00'),
    (7, 'Lunes', '16:00:00', '18:00:00'),
    (6, 'Martes', '16:00:00', '18:00:00'),
    (7, 'Miércoles', '10:00:00', '12:00:00'),
    (1, 'Jueves', '08:00:00', '10:00:00'),
    (2, 'Viernes', '14:00:00', '16:00:00');

INSERT INTO alumnos (nombre, apellido, email, contasena, matricula)
VALUES 
    ('Oscar Olaf', 'Vázquez Rojas', 'utp0210139@alumno.utpuebla.edu.mx', '1234567890', '0210139');
