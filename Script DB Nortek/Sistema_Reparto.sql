CREATE DATABASE IF NOT EXISTS sistema_reparto
    CHARACTER SET utf8mb4
    COLLATE utf8mb4_spanish_ci;
USE sistema_reparto;

-- ============================================================
-- NIVEL 1 - CATÁLOGOS INDEPENDIENTES (sin FK)
-- ============================================================

CREATE TABLE roles (
    id_rol          INT             NOT NULL AUTO_INCREMENT,
    nombre          VARCHAR(50)     NOT NULL,
    descripcion     VARCHAR(255)    NULL,
    PRIMARY KEY (id_rol)
) ENGINE=InnoDB;

CREATE TABLE modulos (
    id_modulo      INT             NOT NULL AUTO_INCREMENT,
    nombre_modulos          VARCHAR(50)     NOT NULL,
    estatus_modulo  VARCHAR(10)    NULL,
    PRIMARY KEY (id_modulo)
) ENGINE=InnoDB;

CREATE TABLE tipo_empleado (
    id_tipo_empleado INT            NOT NULL AUTO_INCREMENT,
    nombre          VARCHAR(50)     NOT NULL,
    descripcion     VARCHAR(255)    NULL,
    PRIMARY KEY (id_tipo_empleado)
) ENGINE=InnoDB;

CREATE TABLE estado_empleado (
    id_estado_empleado INT          NOT NULL AUTO_INCREMENT,
    nombre          VARCHAR(50)     NOT NULL,
    descripcion     VARCHAR(255)    NULL,
    PRIMARY KEY (id_estado_empleado)
) ENGINE=InnoDB;

CREATE TABLE clientes (
    id_cliente      INT             NOT NULL AUTO_INCREMENT,
    nombres         VARCHAR(100)    NOT NULL,
    apellidos       VARCHAR(100)    NOT NULL,
    telefono        VARCHAR(20)     NULL,
    correo          VARCHAR(100)    NULL,
    direccion       VARCHAR(255)    NULL,
    PRIMARY KEY (id_cliente)
) ENGINE=InnoDB;

CREATE TABLE estado_pedido (
    id_estado_pedido INT            NOT NULL AUTO_INCREMENT,
    nombre          VARCHAR(50)     NOT NULL,
    descripcion     VARCHAR(255)    NULL,
    PRIMARY KEY (id_estado_pedido)
) ENGINE=InnoDB;

CREATE TABLE estado_entrega (
    id_estado_entrega INT           NOT NULL AUTO_INCREMENT,
    nombre          VARCHAR(50)     NOT NULL,
    descripcion     VARCHAR(255)    NULL,
    PRIMARY KEY (id_estado_entrega)
) ENGINE=InnoDB;

CREATE TABLE tipo_ruta (
    id_tipo_ruta    INT             NOT NULL AUTO_INCREMENT,
    nombre          VARCHAR(50)     NOT NULL,
    descripcion     VARCHAR(255)    NULL,
    PRIMARY KEY (id_tipo_ruta)
) ENGINE=InnoDB;

CREATE TABLE estado_ruta (
    id_estado_ruta  INT             NOT NULL AUTO_INCREMENT,
    nombre          VARCHAR(50)     NOT NULL,
    descripcion     VARCHAR(255)    NULL,
    PRIMARY KEY (id_estado_ruta)
) ENGINE=InnoDB;

CREATE TABLE tipo_vehiculo (
    id_tipo_vehiculo INT            NOT NULL AUTO_INCREMENT,
    nombre          VARCHAR(50)     NOT NULL,
    descripcion     VARCHAR(255)    NULL,
    PRIMARY KEY (id_tipo_vehiculo)
) ENGINE=InnoDB;

CREATE TABLE estado_vehiculo (
    id_estado_vehiculo INT          NOT NULL AUTO_INCREMENT,
    nombre          VARCHAR(50)     NOT NULL,
    descripcion     VARCHAR(255)    NULL,
    PRIMARY KEY (id_estado_vehiculo)
) ENGINE=InnoDB;

CREATE TABLE areas_cubiertas (
    id_area         INT             NOT NULL AUTO_INCREMENT,
    nombre          VARCHAR(100)    NOT NULL,
    municipio       VARCHAR(100)    NULL,
    departamento    VARCHAR(100)    NULL,
    descripcion     VARCHAR(255)    NULL,
    PRIMARY KEY (id_area)
) ENGINE=InnoDB;

CREATE TABLE sucursal (
    id_sucursal     INT             NOT NULL AUTO_INCREMENT,
    nombre          VARCHAR(100)    NOT NULL,
    direccion       VARCHAR(255)    NULL,
    telefono        VARCHAR(20)     NULL,
    correo          VARCHAR(100)    NULL,
    PRIMARY KEY (id_sucursal)
) ENGINE=InnoDB;

-- ============================================================
-- NIVEL 2 - DEPENDEN DE UN SOLO CATÁLOGO
-- ============================================================

CREATE TABLE bodega (
    id_bodega       INT             NOT NULL AUTO_INCREMENT,
    id_sucursal     INT             NOT NULL,
    nombre          VARCHAR(100)    NOT NULL,
    direccion       VARCHAR(255)    NULL,
    capacidad       INT             NULL,
    telefono        VARCHAR(20)     NULL,
    PRIMARY KEY (id_bodega),
    CONSTRAINT fk_bodega_sucursal FOREIGN KEY (id_sucursal)
        REFERENCES sucursal (id_sucursal)
) ENGINE=InnoDB;

CREATE TABLE empleados (
    id_empleado         INT          NOT NULL AUTO_INCREMENT,
    id_tipo_empleado    INT          NOT NULL,
    id_estado_empleado  INT          NOT NULL,
    nombres             VARCHAR(100) NOT NULL,
    apellidos           VARCHAR(100) NOT NULL,
    dpi                 VARCHAR(20)  NULL,
    nit                 VARCHAR(20)  NULL,
    telefono            VARCHAR(20)  NULL,
    correo              VARCHAR(100) NULL,
    direccion           VARCHAR(255) NULL,
    fecha_nacimiento    DATE         NULL,
    fecha_contratacion  DATE         NULL,
    PRIMARY KEY (id_empleado),
    CONSTRAINT fk_empleados_tipo FOREIGN KEY (id_tipo_empleado)
        REFERENCES tipo_empleado (id_tipo_empleado),
    CONSTRAINT fk_empleados_estado FOREIGN KEY (id_estado_empleado)
        REFERENCES estado_empleado (id_estado_empleado)
) ENGINE=InnoDB;

CREATE TABLE vehiculo (
    id_vehiculo         INT           NOT NULL AUTO_INCREMENT,
    placa               VARCHAR(15)   NOT NULL,
    marca               VARCHAR(50)   NULL,
    modelo               VARCHAR(50)   NULL,
    anio                 INT           NULL,
    capacidad_peso       DECIMAL(10,2) NULL,
    id_tipo_vehiculo     INT           NOT NULL,
    id_estado_vehiculo   INT           NOT NULL,
    PRIMARY KEY (id_vehiculo),
    CONSTRAINT fk_vehiculo_tipo FOREIGN KEY (id_tipo_vehiculo)
        REFERENCES tipo_vehiculo (id_tipo_vehiculo),
    CONSTRAINT fk_vehiculo_estado FOREIGN KEY (id_estado_vehiculo)
        REFERENCES estado_vehiculo (id_estado_vehiculo)
) ENGINE=InnoDB;

-- ============================================================
-- NIVEL 3 - DEPENDEN DE TABLAS DE NIVEL 2
-- ============================================================

CREATE TABLE usuarios (
    id_usuario      INT             NOT NULL AUTO_INCREMENT,
    id_empleado     INT             NOT NULL,
    usuario         VARCHAR(50)     NOT NULL,
    correo          VARCHAR(100)    NULL,
    contrasena      VARCHAR(255)    NOT NULL,
    ultimo_acceso   DATETIME        NULL,
    fecha_creacion  DATE            NULL,
    estado          VARCHAR(20)     NULL,
    PRIMARY KEY (id_usuario),
    UNIQUE KEY uq_usuarios_empleado (id_empleado),
    CONSTRAINT fk_usuarios_empleado FOREIGN KEY (id_empleado)
        REFERENCES empleados (id_empleado)
) ENGINE=InnoDB;

CREATE TABLE ruta (
    id_ruta         INT             NOT NULL AUTO_INCREMENT,
    id_bodega       INT             NOT NULL,
    id_area         INT             NOT NULL,
    id_tipo_ruta    INT             NOT NULL,
    id_estado_ruta  INT             NOT NULL,
    fecha_ruta      DATE            NULL,
    hora_inicio     TIME            NULL,
    hora_fin        TIME            NULL,
    distancia_km    DECIMAL(10,2)   NULL,
    observaciones   VARCHAR(255)    NULL,
    PRIMARY KEY (id_ruta),
    CONSTRAINT fk_ruta_bodega FOREIGN KEY (id_bodega)
        REFERENCES bodega (id_bodega),
    CONSTRAINT fk_ruta_area FOREIGN KEY (id_area)
        REFERENCES areas_cubiertas (id_area),
    CONSTRAINT fk_ruta_tipo FOREIGN KEY (id_tipo_ruta)
        REFERENCES tipo_ruta (id_tipo_ruta),
    CONSTRAINT fk_ruta_estado FOREIGN KEY (id_estado_ruta)
        REFERENCES estado_ruta (id_estado_ruta)
) ENGINE=InnoDB;

-- ============================================================
-- NIVEL 4 - DEPENDEN DE NIVEL 3
-- ============================================================
CREATE TABLE IF NOT EXISTS relrolmodulo(
    id_modulo INT NOT NULL,
    id_rol INT NOT NULL,
    der_insertar VARCHAR(1) NOT NULL,
    der_editar VARCHAR(1) NOT NULL,
    der_eliminar VARCHAR(1) NOT NULL,
    der_imprimir VARCHAR(1) NOT NULL,
    PRIMARY KEY (id_modulo, id_rol),
    FOREIGN KEY (id_modulo) REFERENCES modulos (id_modulo),
    FOREIGN KEY (id_rol) REFERENCES roles (id_rol)
) ENGINE=InnoDB;

CREATE TABLE IF NOT EXISTS relusumodulo(
    id_modulo INT NOT NULL,
    id_usuario INT NOT NULL,
    der_insertar VARCHAR(1) NOT NULL,
    der_editar VARCHAR(1) NOT NULL,
    der_eliminar VARCHAR(1) NOT NULL,
    der_imprimir VARCHAR(1) NOT NULL,
    PRIMARY KEY (id_modulo, id_usuario),
    FOREIGN KEY (id_modulo) REFERENCES modulos (id_modulo),
    FOREIGN KEY (id_usuario) REFERENCES usuarios (id_usuario)
) ENGINE=InnoDB;
    
CREATE TABLE usuario_rol (
    id_usuario       INT            NOT NULL,
    id_rol           INT            NOT NULL,
    fecha_asignacion DATE           NULL,
    PRIMARY KEY (id_usuario, id_rol),
    CONSTRAINT fk_usuariorol_usuario FOREIGN KEY (id_usuario)
        REFERENCES usuarios (id_usuario),
    CONSTRAINT fk_usuariorol_rol FOREIGN KEY (id_rol)
        REFERENCES roles (id_rol)
) ENGINE=InnoDB;

CREATE TABLE pedido (
    id_pedido           INT          NOT NULL AUTO_INCREMENT,
    codigo_pedido       VARCHAR(20)  NOT NULL,
    id_cliente          INT          NOT NULL,
    id_estado_pedido    INT          NOT NULL,
    id_ruta             INT          NULL,
    fecha_solicitud     DATE         NULL,
    direccion_origen    VARCHAR(255) NULL,
    direccion_destino   VARCHAR(255) NULL,
    peso_total          DECIMAL(10,2) NULL,
    cantidad_paquetes   INT          NULL,
    observaciones       VARCHAR(255) NULL,
    PRIMARY KEY (id_pedido),
    UNIQUE KEY uq_pedido_codigo (codigo_pedido),
    CONSTRAINT fk_pedido_cliente FOREIGN KEY (id_cliente)
        REFERENCES clientes (id_cliente),
    CONSTRAINT fk_pedido_estado FOREIGN KEY (id_estado_pedido)
        REFERENCES estado_pedido (id_estado_pedido),
    CONSTRAINT fk_pedido_ruta FOREIGN KEY (id_ruta)
        REFERENCES ruta (id_ruta)
) ENGINE=InnoDB;

CREATE TABLE asignacion_transp (
    id_asignacion    INT            NOT NULL AUTO_INCREMENT,
    id_ruta          INT            NOT NULL,
    id_vehiculo      INT            NOT NULL,
    id_empleado      INT            NOT NULL,
    fecha_asignacion DATE           NULL,
    PRIMARY KEY (id_asignacion),
    CONSTRAINT fk_asigtransp_ruta FOREIGN KEY (id_ruta)
        REFERENCES ruta (id_ruta),
    CONSTRAINT fk_asigtransp_vehiculo FOREIGN KEY (id_vehiculo)
        REFERENCES vehiculo (id_vehiculo),
    CONSTRAINT fk_asigtransp_empleado FOREIGN KEY (id_empleado)
        REFERENCES empleados (id_empleado)
) ENGINE=InnoDB;

CREATE TABLE asignacion_area (
    id_asignacion_area INT          NOT NULL AUTO_INCREMENT,
    id_empleado         INT         NOT NULL,
    id_area              INT        NOT NULL,
    fecha_inicio         DATE       NULL,
    fecha_fin             DATE      NULL,
    PRIMARY KEY (id_asignacion_area),
    CONSTRAINT fk_asigarea_empleado FOREIGN KEY (id_empleado)
        REFERENCES empleados (id_empleado),
    CONSTRAINT fk_asigarea_area FOREIGN KEY (id_area)
        REFERENCES areas_cubiertas (id_area)
) ENGINE=InnoDB;

-- ============================================================
-- NIVEL 5 - DEPENDEN DE PEDIDO
-- ============================================================

CREATE TABLE paquete (
    id_paquete      INT             NOT NULL AUTO_INCREMENT,
    id_pedido       INT             NOT NULL,
    codigo_rastreo  VARCHAR(30)     NULL,
    peso            DECIMAL(10,2)   NULL,
    alto            DECIMAL(10,2)   NULL,
    ancho           DECIMAL(10,2)   NULL,
    largo           DECIMAL(10,2)   NULL,
    descripcion     VARCHAR(255)    NULL,
    fragil          VARCHAR(5)      NULL,
    valor_declarado DECIMAL(10,2)   NULL,
    PRIMARY KEY (id_paquete),
    CONSTRAINT fk_paquete_pedido FOREIGN KEY (id_pedido)
        REFERENCES pedido (id_pedido)
) ENGINE=InnoDB;

CREATE TABLE entrega (
    id_entrega          INT          NOT NULL AUTO_INCREMENT,
    id_pedido           INT          NOT NULL,
    id_estado_entrega   INT          NOT NULL,
    fecha_entrega       DATE         NULL,
    hora_entrega        TIME         NULL,
    persona_recibe      VARCHAR(100) NULL,
    observaciones       VARCHAR(255) NULL,
    firma_recibido      VARCHAR(5)   NULL,
    PRIMARY KEY (id_entrega),
    CONSTRAINT fk_entrega_pedido FOREIGN KEY (id_pedido)
        REFERENCES pedido (id_pedido),
    CONSTRAINT fk_entrega_estado FOREIGN KEY (id_estado_entrega)
        REFERENCES estado_entrega (id_estado_entrega)
) ENGINE=InnoDB;

-- ============================================================
-- NIVEL 6 - DEPENDE DE ENTREGA, CLIENTES Y EMPLEADOS
-- ============================================================

CREATE TABLE queja (
    id_queja        INT             NOT NULL AUTO_INCREMENT,
    id_entrega      INT             NOT NULL,
    id_cliente      INT             NOT NULL,
    id_empleado     INT             NOT NULL,
    tipo            VARCHAR(50)     NULL,
    comentario      VARCHAR(500)    NULL,
    calificacion    INT             NULL,
    fecha           DATE            NULL,
    PRIMARY KEY (id_queja),
    CONSTRAINT fk_queja_entrega FOREIGN KEY (id_entrega)
        REFERENCES entrega (id_entrega),
    CONSTRAINT fk_queja_cliente FOREIGN KEY (id_cliente)
        REFERENCES clientes (id_cliente),
    CONSTRAINT fk_queja_empleado FOREIGN KEY (id_empleado)
        REFERENCES empleados (id_empleado),
    CONSTRAINT ck_queja_calificacion CHECK (calificacion BETWEEN 1 AND 5)
) ENGINE=InnoDB;

-- ============================================================
-- FIN DEL SCRIPT - 25 TABLAS CREADAS EN ORDEN DE DEPENDENCIA
-- ============================================================
