USE mentoracademic; 

INSERT INTO clubes (nombre, descripcion)
VALUES 
    ('Futbol', 'Club de futbol de la universidad'),
    ('Ajedrez', 'Club de ajedrez de la universidad'),
    ('Literatura', 'Club de literatura y escritura creativa'),
    ('Música', 'Club de música y bandas estudiantiles'),
    ('Basquetbol', 'Club de baloncesto de la universidad'),
    ('Tenis', 'Club de tenis del campus');

INSERT INTO materias (nombre, descripcion)
VALUES 
    ('Base de Datos', 'Curso de introducción a bases de datos'),
    ('Cálculo Integral', 'Curso de cálculo integral'),
    ('Desarrollo del Pensamiento y Toma de decisiones ', 'Curso de desarrollo del pensamiento crítico y toma de decisiones'),
    ('Inglés III', 'Curso de inglés nivel principiante'),
    ('Programación Orientada a Objetos', 'Curso de programación orientada a objetos en C#'),
    ('Proyecto Integrador I', 'Elaboración de un protoipo de un software apuntando a una necesidad real'),
    ('Tópicos de Calidad para el Desarrollo de Software', 'Curso acerca de la calidad en el desarrollo de software');

INSERT INTO profesores (nombre, apellido, email, idMateria)
VALUES
    ('Berenice Anabella', 'Leal Fuentes', 'berenice.leal@utpuebla.edu.mx', 1),
    ('Antonio', 'Cid García', 'antonio.cid@utpuebla.edu.mx', 2),
    ('Ana María', 'Ramírez Casco', 'ana.ramirez@utpuebla.edu.mx', 3),
    ('María del Rocío', 'Camarillo Huerta', 'maria.camarillo@utpuebla.edu.mx', 4),
    ('Guillermo', 'Sánchez Flores', 'guillermo.sanchez@utpuebla.edu.mx', 5),
    ('José de Jesús', 'García Sánchez', 'jose.garcia@utpuebla.edu.mx', 6),
    ('Julia Elena', 'Pérez Martínez', 'julia.perez@utpuebla.edu.mx', 7);

INSERT INTO alumnos (nombre, apellido, email, contasena)
VALUES 
    ('Joshue', 'Herrada Solís', 'utp0000000@alumno.utpuebla.edu.mx', '1234567890'),
    ('Alexia', 'Méndez Palacios', 'utp0000001@alumno.utpuebla.edu.mx', '1234567890'),
    ('Martín', 'Romero Vélez', 'utp0000002@alumno.utpuebla.edu.mx', '1234567890'),
    ('Oscar Olaf', 'Vázquez Rojas', 'utp0210139@alumno.utpuebla.edu.mx', '1234567890');