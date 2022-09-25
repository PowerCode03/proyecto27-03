-- -----------------------------------------------------
-- Table ESPECIALIDAD
-- -----------------------------------------------------
CREATE TABLE  especialidad (
  esp_id  [int] IDENTITY(1,1) NOT NULL,
  esp_nombre VARCHAR(20) NOT NULL,
  PRIMARY KEY (esp_id))
;


-- -----------------------------------------------------
-- Table consultorio
-- -----------------------------------------------------
CREATE TABLE  consultorio (
  cons_codigo [int] IDENTITY(1,1) NOT NULL,
  cons_nombre VARCHAR(50) NOT NULL,
  PRIMARY KEY (cons_codigo))
;


-- -----------------------------------------------------
-- Table medico
-- -----------------------------------------------------
CREATE TABLE  medico (
  med_nroMatriculaProsional [int] IDENTITY(1,1) NOT NULL,
  med_nombreCompleto VARCHAR(120) NOT NULL,
  med_consultorio INT NOT NULL,
  med_especialidad INT NOT NULL,
  PRIMARY KEY (med_nroMatriculaProsional),
  CONSTRAINT especialidad_FK_medico
    FOREIGN KEY (med_especialidad)
    REFERENCES especialidad (esp_id)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT consultorio_FK_medico
    FOREIGN KEY (med_consultorio)
    REFERENCES consultorio (cons_codigo)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
;

CREATE INDEX medico_FK_especialidad_idx ON medico (med_especialidad ASC) ;

CREATE INDEX consultorio_FK_medico_idx ON medico (med_consultorio ASC) ;


-- -----------------------------------------------------
-- Table estado_cita
-- -----------------------------------------------------
CREATE TABLE  estado_cita (
  estcita_id [int] IDENTITY(1,1) NOT NULL,
  estcita_nombre VARCHAR(20) NOT NULL,
  PRIMARY KEY (estcita_id))
;


-- -----------------------------------------------------
-- Table tipo_documento
-- -----------------------------------------------------
CREATE TABLE  tipo_documento (
  tipdoc_id  [int] IDENTITY(1,1) NOT NULL,
  tipdoc_nombre VARCHAR(20) NOT NULL,
  tipdoc_abreviatura VARCHAR(20) NOT NULL,
  PRIMARY KEY (tipdoc_id))
;


-- -----------------------------------------------------
-- Table genero
-- -----------------------------------------------------
CREATE TABLE  genero (
  gen_id  [int] IDENTITY(1,1) NOT NULL,
  gen_nombre VARCHAR(20) NOT NULL,
  gen_abreviatura VARCHAR(20) NOT NULL,
  PRIMARY KEY (gen_id))
;


-- -----------------------------------------------------
-- Table acudiente
-- -----------------------------------------------------
CREATE TABLE  acudiente (
  acu_codigo  [int] IDENTITY(1,1) NOT NULL,
  acu_nombreCompleto VARCHAR(100) NOT NULL,
  acu_telefono VARCHAR(100) NOT NULL,
  acu_direccion VARCHAR(200) NULL,
  PRIMARY KEY (acu_codigo))
;


-- -----------------------------------------------------
-- Table usuario
-- -----------------------------------------------------
CREATE TABLE  usuario (
  usu_id  [int] IDENTITY(1,1) NOT NULL,
  usu_nombre VARCHAR(50) NOT NULL,
  usu_segdo_nombre VARCHAR(45) NULL,
  usu_primer_apellido_usuar VARCHAR(50) NOT NULL,
  usu_segdo_apellido_usuar VARCHAR(50) NOT NULL,
  usu_telefono VARCHAR(50) NOT NULL,
  usu_direccion VARCHAR(100) NOT NULL,
  usu_email VARCHAR(100) NULL,
  usu_tipodoc INT NOT NULL,
  usu_genero INT NOT NULL,
  usu_acudiente INT NOT NULL,
  PRIMARY KEY (usu_id),
  CONSTRAINT tipo_documento_FK_usuario
    FOREIGN KEY (usu_tipodoc)
    REFERENCES tipo_documento (tipdoc_id)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT genero_FK_usuario
    FOREIGN KEY (usu_genero)
    REFERENCES genero (gen_id)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT acudiente_FK_usuario
    FOREIGN KEY (usu_acudiente)
    REFERENCES acudiente (acu_codigo)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
;

CREATE INDEX tipo_documento_FK_usuario_idx ON usuario (usu_tipodoc ASC) ;

CREATE INDEX genero_FK_usuario_idx ON usuario (usu_genero ASC) ;

CREATE INDEX acudiente_FK_usuario_idx ON usuario (usu_acudiente ASC) ;


-- -----------------------------------------------------
-- Table cita
-- -----------------------------------------------------
CREATE TABLE  cita (
  cit_codigo [int] IDENTITY(1,1) NOT NULL,
  cit_fecha DATE NOT NULL,
  cit_estadoCita INT NOT NULL,
  cit_medico INT NOT NULL,
  cit_datosUsuario INT NOT NULL,
  PRIMARY KEY (cit_codigo),
  CONSTRAINT medico_FK_cita
    FOREIGN KEY (cit_medico)
    REFERENCES medico (med_nroMatriculaProsional)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT estcita_FK_cita
    FOREIGN KEY (cit_estadoCita)
    REFERENCES estado_cita (estcita_id)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT usuario_FK_cita
    FOREIGN KEY (cit_datosUsuario)
    REFERENCES usuario (usu_id)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
;

CREATE INDEX medico_FK_cita_idx ON cita (cit_medico ASC) ;

CREATE INDEX estcita_FK_cita_idx ON cita (cit_estadoCita ASC) ;

CREATE INDEX usuario_FK_cita_idx ON cita (cit_datosUsuario ASC) ;

