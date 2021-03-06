CREATE DATABASE APPTASK
USE APPTASK

CREATE TABLE USUARIOS
(
	ID_USUARIO INT PRIMARY KEY NOT NULL,
	NOMBRE VARCHAR (20) NOT NULL,
	CORREO VARCHAR (30) NOT NULL,
	CONTRASEÑA VARCHAR (20) NOT NULL,
	NIVEL INT NOT NULL DEFAULT '0',
	PUNTOSXP INT NOT NULL DEFAULT '0'
)

CREATE TABLE TAREAS
(
	ID_TAREA INT PRIMARY KEY NOT NULL,
	TITULO VARCHAR (45) NOT NULL,
	ETIQUETA TEXT,
	DESCRIPCION TEXT,
	ESTADO VARCHAR (15),
	FECHAIN DATE NOT NULL,
	FECHAFIN DATE,
	ULTIMAMOD DATE,
	IMPORTANCIA VARCHAR (15),
	ID_USUARIO INT FOREIGN KEY 
	REFERENCES USUARIOS(ID_USUARIO)

)
