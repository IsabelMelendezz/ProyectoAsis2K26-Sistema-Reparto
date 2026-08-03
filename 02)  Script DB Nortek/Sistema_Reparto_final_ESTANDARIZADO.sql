CREATE DATABASE IF NOT EXISTS sistema_reparto
    CHARACTER SET utf8mb4
    COLLATE utf8mb4_spanish_ci;
USE sistema_reparto;

-- ============================================================
-- NIVEL 1 - CATALOGOS INDEPENDIENTES (sin FK)
-- ============================================================
-- 1
CREATE TABLE rol (
    id_rol          INT             NOT NULL AUTO_INCREMENT,
    nombre_rol          VARCHAR(50)     NOT NULL,
    descripcion_rol     VARCHAR(255)    NULL,
    estado_rol VARCHAR(20) NOT NULL DEFAULT 'Activo',
    PRIMARY KEY (id_rol)
) ENGINE=InnoDB;

-- 2
CREATE TABLE modulo (
    id_modulo      INT             NOT NULL AUTO_INCREMENT,
    nombre_modulo          VARCHAR(50)     NOT NULL,
    estatus_modulo  VARCHAR(10)    NULL,
    PRIMARY KEY (id_modulo)
) ENGINE=InnoDB;

CREATE TABLE tipo_empleado (
    id_tipo_empleado INT            NOT NULL AUTO_INCREMENT,
    nombre_tipo_empleado          VARCHAR(50)     NOT NULL,
    descripcion_tipo_empleado     VARCHAR(255)    NULL,
    PRIMARY KEY (id_tipo_empleado)
) ENGINE=InnoDB;

CREATE TABLE estado_empleado (
    id_estado_empleado INT          NOT NULL AUTO_INCREMENT,
    nombre_estado_empleado          VARCHAR(50)     NOT NULL,
    descripcion_estado_empleado     VARCHAR(255)    NULL,
    PRIMARY KEY (id_estado_empleado)
) ENGINE=InnoDB;

-- 3
CREATE TABLE cliente (
    id_cliente      INT             NOT NULL AUTO_INCREMENT,
    nombres_cliente         VARCHAR(100)    NOT NULL,
    apellidos_cliente       VARCHAR(100)    NOT NULL,
    telefono_cliente       VARCHAR(20)     NULL,
    correo_cliente          VARCHAR(100)    NULL,
    direccion_cliente       VARCHAR(255)    NULL,
    PRIMARY KEY (id_cliente)
) ENGINE=InnoDB;

CREATE TABLE estado_pedido (
    id_estado_pedido INT            NOT NULL AUTO_INCREMENT,
    nombre_estado_pedido          VARCHAR(50)     NOT NULL,
    descripcion_estado_pedido     VARCHAR(255)    NULL,
    PRIMARY KEY (id_estado_pedido)
) ENGINE=InnoDB;

CREATE TABLE estado_entrega (
    id_estado_entrega INT           NOT NULL AUTO_INCREMENT,
    nombre_estado_entrega          VARCHAR(50)     NOT NULL,
    descripcion_estado_entrega     VARCHAR(255)    NULL,
    PRIMARY KEY (id_estado_entrega)
) ENGINE=InnoDB;

CREATE TABLE tipo_ruta (
    id_tipo_ruta    INT             NOT NULL AUTO_INCREMENT,
    nombre_tipo_ruta          VARCHAR(50)     NOT NULL,
    descripcion_tipo_ruta     VARCHAR(255)    NULL,
    PRIMARY KEY (id_tipo_ruta)
) ENGINE=InnoDB;

CREATE TABLE estado_ruta (
    id_estado_ruta  INT             NOT NULL AUTO_INCREMENT,
    nombre_estado_ruta          VARCHAR(50)     NOT NULL,
    descripcion_estado_ruta     VARCHAR(255)    NULL,
    PRIMARY KEY (id_estado_ruta)
) ENGINE=InnoDB;

CREATE TABLE tipo_vehiculo (
    id_tipo_vehiculo INT            NOT NULL AUTO_INCREMENT,
    nombre_tipo_vehiculo          VARCHAR(50)     NOT NULL,
    descripcion_tipo_vehiculo     VARCHAR(255)    NULL,
    PRIMARY KEY (id_tipo_vehiculo)
) ENGINE=InnoDB;

CREATE TABLE estado_vehiculo (
    id_estado_vehiculo INT          NOT NULL AUTO_INCREMENT,
    nombre_estado_vehiculo          VARCHAR(50)     NOT NULL,
    descripcion_estado_vehiculo     VARCHAR(255)    NULL,
    PRIMARY KEY (id_estado_vehiculo)
) ENGINE=InnoDB;

-- 4
-- !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
-- ESTA LE MODIFIQUE NOMBRE POR ZONA 
-- !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

CREATE TABLE area_cubierta (
    id_area         INT             NOT NULL AUTO_INCREMENT,
    zona_area_cubierta          VARCHAR(100)    NOT NULL,
    municipio_area_cubierta       VARCHAR(100)    NULL,
    departamento_area_cubierta    VARCHAR(100)    NULL,
    descripcion_area_cubierta     VARCHAR(255)    NULL,
    PRIMARY KEY (id_area)
) ENGINE=InnoDB;

-- ============================================================
-- NIVEL 2 - DEPENDEN DE UN SOLO CATALOGO
-- ============================================================

-- direccion depende de area_cubierta
-- !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
-- TABLA NUEVA
-- !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
CREATE TABLE direccion (
    id_direccion      INT           NOT NULL AUTO_INCREMENT,
    id_area           INT           NOT NULL,
    direccion_detalle VARCHAR(255)  NOT NULL,
    referencia_direccion        VARCHAR(255)  NULL,
    PRIMARY KEY (id_direccion),
    CONSTRAINT fk_direccion_area FOREIGN KEY (id_area)
        REFERENCES area_cubierta (id_area)
) ENGINE=InnoDB;


-- !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
-- sucursal depende de direccion
-- ACA MODIFIQUE ESTA TABLA Y LE AGREGUE EL CAMPOS ID_DIRECCION
-- !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
CREATE TABLE sucursal (
    id_sucursal       INT             NOT NULL AUTO_INCREMENT,
    nombre_sucursal   VARCHAR(100)    NOT NULL,
    id_direccion      INT             NULL, -- AQUI VE!!!!!!!!!!!!!
    telefono_sucursal VARCHAR(20)     NULL,
    correo_sucursal   VARCHAR(100)    NULL,
    PRIMARY KEY (id_sucursal),
    CONSTRAINT fk_sucursal_direccion FOREIGN KEY (id_direccion)
        REFERENCES direccion (id_direccion)
) ENGINE=InnoDB;

CREATE TABLE empleado (
    id_empleado         INT          NOT NULL AUTO_INCREMENT,
    id_tipo_empleado    INT          NOT NULL,
    id_estado_empleado  INT          NOT NULL,
    nombre_empleado             VARCHAR(100) NOT NULL,
    apellido_empleado           VARCHAR(100) NOT NULL,
    dpi_empleado                VARCHAR(20)  NULL,
    nit_empleado                 VARCHAR(20)  NULL,
    telefono_empleado            VARCHAR(20)  NULL,
    direccion_empleado           VARCHAR(255) NULL,
    fecha_nacimiento_empleado    DATE         NULL,
    fecha_contratacion_empleado  DATE         NULL,
    PRIMARY KEY (id_empleado),
    CONSTRAINT fk_empleados_tipo FOREIGN KEY (id_tipo_empleado)
        REFERENCES tipo_empleado (id_tipo_empleado),
    CONSTRAINT fk_empleados_estado FOREIGN KEY (id_estado_empleado)
        REFERENCES estado_empleado (id_estado_empleado)
) ENGINE=InnoDB;

CREATE TABLE vehiculo (
    id_vehiculo         INT           NOT NULL AUTO_INCREMENT,
    placa_vehiculo               VARCHAR(15)   NOT NULL,
    marca_vehiculo               VARCHAR(50)   NULL,
    modelo_vehiculo               VARCHAR(50)   NULL,
    anio_vehiculo                 INT           NULL,
    capacidad_peso_vehiculo       DECIMAL(10,2) NULL,
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

-- ACA MODIFIQUE ESTA TABLA LE AGREGUE EL CAMPO ID_DIRECCION

CREATE TABLE bodega (
    id_bodega         INT             NOT NULL AUTO_INCREMENT,
    id_sucursal       INT             NOT NULL,
    nombre_bodega     VARCHAR(100)    NOT NULL,
    id_direccion      INT             NULL, -- AQUI VE!!!!!!!!!!
    capacidad_bodega  INT             NULL,
    telefono_bodega   VARCHAR(20)     NULL,
    PRIMARY KEY (id_bodega),
    CONSTRAINT fk_bodega_sucursal FOREIGN KEY (id_sucursal)
        REFERENCES sucursal (id_sucursal),
    CONSTRAINT fk_bodega_direccion FOREIGN KEY (id_direccion)
        REFERENCES direccion (id_direccion)
) ENGINE=InnoDB;

-- 6
CREATE TABLE usuario (
    id_usuario      INT             NOT NULL AUTO_INCREMENT,
    id_empleado     INT             NOT NULL,
    usuario_usuario         VARCHAR(50)     NOT NULL,
    correo_usuario          VARCHAR(100)    NULL,
    contrasena_usuario      VARCHAR(255)    NOT NULL,
    ultimo_acceso_usuario   DATETIME        NULL,
    fecha_creacion_usuario  DATE            NULL,
    estado_usuario          VARCHAR(20)     NULL,
    token_recuperacion_usuario VARCHAR(10) NULL,
    fecha_expiracion_token_usuario DATETIME NULL,
    PRIMARY KEY (id_usuario),
    UNIQUE KEY uq_usuarios_empleado (id_empleado),
    CONSTRAINT fk_usuarios_empleado FOREIGN KEY (id_empleado)
        REFERENCES empleado (id_empleado)
) ENGINE=InnoDB;

-- ============================================================
-- NIVEL 4 - DEPENDEN DE TABLAS DE NIVEL 3
-- ============================================================

CREATE TABLE ruta (
    id_ruta         INT             NOT NULL AUTO_INCREMENT,
    id_bodega       INT             NOT NULL,
    id_area         INT             NOT NULL,
    id_tipo_ruta    INT             NOT NULL,
    id_estado_ruta  INT             NOT NULL,
    fecha_ruta      DATE            NULL,
    hora_inicio_ruta     TIME            NULL,
    hora_fin_ruta        TIME            NULL,
    distancia_km_ruta    DECIMAL(10,2)   NULL,
    observaciones_ruta   VARCHAR(255)    NULL,
    PRIMARY KEY (id_ruta),
    CONSTRAINT fk_ruta_bodega FOREIGN KEY (id_bodega)
        REFERENCES bodega (id_bodega),
    CONSTRAINT fk_ruta_area FOREIGN KEY (id_area)
        REFERENCES area_cubierta (id_area),
    CONSTRAINT fk_ruta_tipo FOREIGN KEY (id_tipo_ruta)
        REFERENCES tipo_ruta (id_tipo_ruta),
    CONSTRAINT fk_ruta_estado FOREIGN KEY (id_estado_ruta)
        REFERENCES estado_ruta (id_estado_ruta)
) ENGINE=InnoDB;

CREATE TABLE relacion_rol_modulo(
    id_modulo INT NOT NULL,
    id_rol INT NOT NULL,
    der_insertar_relrolmodulo VARCHAR(1) NOT NULL,
    der_editar_relrolmodulo VARCHAR(1) NOT NULL,
    der_eliminar_relrolmodulo VARCHAR(1) NOT NULL,
    der_imprimir_relrolmodulo VARCHAR(1) NOT NULL,
    PRIMARY KEY (id_modulo, id_rol),
    CONSTRAINT fk_relacion_modulo FOREIGN KEY (id_modulo)
        REFERENCES modulo (id_modulo),
    CONSTRAINT fk_relacion_rol FOREIGN KEY (id_rol)
        REFERENCES rol (id_rol)
) ENGINE=InnoDB;

CREATE TABLE relacion_usuario_modulo(
    id_modulo INT NOT NULL,
    id_usuario INT NOT NULL,
    der_insertar_relusumodulo VARCHAR(1) NOT NULL,
    der_editar_relusumodulo VARCHAR(1) NOT NULL,
    der_eliminar_relusumodulo VARCHAR(1) NOT NULL,
    der_imprimir_relusumodulo VARCHAR(1) NOT NULL,
    PRIMARY KEY (id_modulo, id_usuario),
    CONSTRAINT fk_usurio_modulo FOREIGN KEY (id_modulo)
        REFERENCES modulo (id_modulo),
    CONSTRAINT fk_relacion_usuario FOREIGN KEY (id_usuario)
        REFERENCES usuario (id_usuario)
) ENGINE=InnoDB;

CREATE TABLE usuario_rol (
    id_usuario       INT            NOT NULL,
    id_rol           INT            NOT NULL,
    fecha_asignacion_usuario_rol DATE           NULL,
    PRIMARY KEY (id_usuario, id_rol),
    CONSTRAINT fk_usuariorol_usuario FOREIGN KEY (id_usuario)
        REFERENCES usuario (id_usuario),
    CONSTRAINT fk_usuariorol_rol FOREIGN KEY (id_rol)
        REFERENCES rol (id_rol)
) ENGINE=InnoDB;

CREATE TABLE asignacion_area (
    id_asignacion_area INT          NOT NULL AUTO_INCREMENT,
    id_empleado         INT         NOT NULL,
    id_area              INT        NOT NULL,
    fecha_inicio_asignacion_area         DATE       NULL,
    fecha_fin_asignacion_area             DATE      NULL,
    PRIMARY KEY (id_asignacion_area),
    CONSTRAINT fk_asigarea_empleado FOREIGN KEY (id_empleado)
        REFERENCES empleado (id_empleado),
    CONSTRAINT fk_asigarea_area FOREIGN KEY (id_area)
        REFERENCES area_cubierta (id_area)
) ENGINE=InnoDB;

-- ============================================================
-- NIVEL 5 - DEPENDEN DE RUTA / DIRECCION
-- ============================================================

-- ACA MODIFIQUE ESTA TABLA Y SE LE AGREGARON LOS CAMPOS ID_DIRECCION_ORIGEN Y DESTINO


CREATE TABLE pedido (
    id_pedido                INT          NOT NULL AUTO_INCREMENT,
    codigo_pedido            VARCHAR(20)  NOT NULL,
    id_cliente               INT          NOT NULL,
    id_estado_pedido         INT          NOT NULL,
    id_ruta                  INT          NULL,
    id_direccion_origen_pedido    INT          NULL, -- AQUI VE
    id_direccion_destino_pedido   INT          NOT NULL,-- AQUI VE
    fecha_solicitud_pedido   DATE         NULL,
    peso_total_pedido        DECIMAL(10,2) NULL,
    cantidad_paquetes_pedido INT          NULL,
    observaciones_pedido     VARCHAR(255) NULL,
    PRIMARY KEY (id_pedido),
    UNIQUE KEY uq_pedido_codigo (codigo_pedido),
    CONSTRAINT fk_pedido_cliente FOREIGN KEY (id_cliente)
        REFERENCES cliente (id_cliente),
    CONSTRAINT fk_pedido_estado FOREIGN KEY (id_estado_pedido)
        REFERENCES estado_pedido (id_estado_pedido),
    CONSTRAINT fk_pedido_ruta FOREIGN KEY (id_ruta)
        REFERENCES ruta (id_ruta),
    CONSTRAINT fk_pedido_dir_origen FOREIGN KEY (id_direccion_origen_pedido)
        REFERENCES direccion (id_direccion),
    CONSTRAINT fk_pedido_dir_destino FOREIGN KEY (id_direccion_destino_pedido)
        REFERENCES direccion (id_direccion)
) ENGINE=InnoDB;

CREATE TABLE asignacion_transp (
    id_asignacion    INT            NOT NULL AUTO_INCREMENT,
    id_ruta          INT            NOT NULL,
    id_vehiculo      INT            NOT NULL,
    id_empleado      INT            NOT NULL,
    fecha_asignacion_asignacion_transp DATE           NULL,
    PRIMARY KEY (id_asignacion),
    CONSTRAINT fk_asigtransp_ruta FOREIGN KEY (id_ruta)
        REFERENCES ruta (id_ruta),
    CONSTRAINT fk_asigtransp_vehiculo FOREIGN KEY (id_vehiculo)
        REFERENCES vehiculo (id_vehiculo),
    CONSTRAINT fk_asigtransp_empleado FOREIGN KEY (id_empleado)
        REFERENCES empleado (id_empleado)
) ENGINE=InnoDB;

-- ============================================================
-- NIVEL 6 - DEPENDEN DE PEDIDO
-- ============================================================

CREATE TABLE paquete (
    id_paquete      INT             NOT NULL AUTO_INCREMENT,
    id_pedido       INT             NOT NULL,
    codigo_rastreo_paquete  VARCHAR(30)     NULL,
    peso_paquete            DECIMAL(10,2)   NULL,
    alto_paquete            DECIMAL(10,2)   NULL,
    ancho_paquete           DECIMAL(10,2)   NULL,
    largo_paquete           DECIMAL(10,2)   NULL,
    descripcion_paquete     VARCHAR(255)    NULL,
    fragil_paquete          VARCHAR(5)      NULL,
    valor_declarado_paquete DECIMAL(10,2)   NULL,
    tipo_paquete			VARCHAR(25)     NULL,
    estado_paquete VARCHAR(20) NOT NULL DEFAULT 'Activo',
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
    persona_recibe_entrega      VARCHAR(100) NULL,
    observaciones_entrega       VARCHAR(255) NULL,
    firma_recibido_entrega      VARCHAR(5)   NULL,
    PRIMARY KEY (id_entrega),
    CONSTRAINT fk_entrega_pedido FOREIGN KEY (id_pedido)
        REFERENCES pedido (id_pedido),
    CONSTRAINT fk_entrega_estado FOREIGN KEY (id_estado_entrega)
        REFERENCES estado_entrega (id_estado_entrega)
) ENGINE=InnoDB;

-- ============================================================
-- NIVEL 7 - DEPENDE DE ENTREGA Y EMPLEADOS
-- ============================================================

CREATE TABLE queja (
    id_queja        INT             NOT NULL AUTO_INCREMENT,
    id_entrega      INT             NOT NULL,
    id_empleado     INT             NOT NULL,
    tipo_queja            VARCHAR(50)     NULL,
    comentario_queja      VARCHAR(500)    NULL,
    calificacion_queja    INT             NULL,
    fecha_queja           DATE            NULL,
    PRIMARY KEY (id_queja),
    CONSTRAINT fk_queja_entrega FOREIGN KEY (id_entrega)
        REFERENCES entrega (id_entrega),
    CONSTRAINT fk_queja_empleado FOREIGN KEY (id_empleado)
        REFERENCES empleado (id_empleado),
    CONSTRAINT ck_queja_calificacion CHECK (calificacion_queja BETWEEN 1 AND 5)
) ENGINE=InnoDB;

-- ============================================================
-- FIN DEL SCRIPT - 28 TABLAS CREADAS EN ORDEN DE DEPENDENCIA
-- ============================================================
