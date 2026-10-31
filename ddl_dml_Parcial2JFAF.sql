-- DDL
CREATE DATABASE Parcial2JFAF;
GO
USE master
GO

CREATE LOGIN usrparcial2 WITH PASSWORD = '12345678',
  DEFAULT_DATABASE = Parcial2JFAF,
  CHECK_EXPIRATION = OFF,
  CHECK_POLICY = ON
GO
USE Parcial2JFAF
GO
CREATE USER usrparcial2 FOR LOGIN usrparcial2 
GO
ALTER ROLE db_owner ADD MEMBER usrparcial2 
GO

DROP TABLE IF EXISTS HorarioPrograma;
DROP TABLE IF EXISTS Canal;
GO

-- CANAL
CREATE TABLE Canal (
    id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    nombre VARCHAR(50) NOT NULL,
    frecuencia VARCHAR(20) NOT NULL,
    estado SMALLINT NOT NULL DEFAULT 1,
);
GO

-- HORARIO PROGRAMA
CREATE TABLE HorarioPrograma (
    id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    idCanal INT NOT NULL,
    titulo VARCHAR(100) NOT NULL,
    horaInicio TIME NULL,
    horaFin TIME NULL,
    diaSemana VARCHAR(20) NOT NULL,
    conductorPrincipal VARCHAR(100) NOT NULL,
    estado SMALLINT NOT NULL DEFAULT 1,
    CONSTRAINT FK__HorarioProgama_Canal FOREIGN KEY (idCanal) REFERENCES Canal(id)
);
GO

CREATE PROC paHorarioProgramaListar @parametro VARCHAR(80)
AS
    SELECT hp.id, hp.idCanal, c.nombre AS nombreCanal, hp.titulo, hp.horaInicio, 
           hp.horaFin, hp.diaSemana, hp.conductorPrincipal, hp.estado
    FROM HorarioPrograma hp
    INNER JOIN Canal c ON hp.idCanal = c.id
    WHERE hp.estado = 1 AND hp.titulo+hp.conductorPrincipal LIKE '%' + REPLACE (@parametro, ' ', '%') + '%'
    ORDER BY hp.diaSemana, hp.horaInicio;
GO
EXEC paHorarioProgramaListar '';

-- DML
-- Canales de Bolivia
INSERT INTO Canal (nombre, frecuencia) VALUES 
('Unitel', '36'),
('Cadena A', '15'),
('RTP', '11'),
('Bolivision', '9'),
('Bolivia TV', '7.1'),
('ATB', '5'),
('Red Uno', '2');
GO

-- Horario Programas
INSERT INTO HorarioPrograma (idCanal, titulo, horaInicio, horaFin, diaSemana, conductorPrincipal) VALUES
(1, 'Telenoche', '20:00', '21:00', 'Viernes', 'Jhon Arandia'),
(1, 'Cámara en Mano', '16:30', '18:00', 'Lunes', 'Ilsen Fernandez'),
(2, 'Primero Noticias', '07:00', '09:00', 'Lunes', 'Narda Castro'),
(3, 'Concierto Privado', '19:00', '21:00', 'Sabado', 'Pepe Macias');
GO

SELECT * FROM Canal;
SELECT * FROM HorarioPrograma;
