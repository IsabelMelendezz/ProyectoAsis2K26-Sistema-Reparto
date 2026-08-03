USE sistema_reparto;

-- ============================================================
-- INSERTS - 3 REGISTROS POR CADA TABLA
-- Se respeta el orden de dependencia de llaves foráneas
-- ============================================================

-- NIVEL 1 - CATALOGOS INDEPENDIENTES
INSERT INTO rol (nombre_rol, descripcion_rol) VALUES
('Administrador', 'Acceso total al sistema'),
('Despachador', 'Gestiona pedidos y rutas'),
('Repartidor', 'Realiza entregas a clientes');

INSERT INTO modulo (nombre_modulo, estatus_modulo) VALUES
('Pedidos', 'Activo'),
('Rutas', 'Activo'),
('Reportes', 'Activo');

INSERT INTO tipo_empleado (nombre_tipo_empleado, descripcion_tipo_empleado) VALUES
('Repartidor', 'Encargado de entregar paquetes'),
('Administrativo', 'Personal de oficina'),
('Supervisor', 'Supervisa operaciones de reparto');

INSERT INTO estado_empleado (nombre_estado_empleado, descripcion_estado_empleado) VALUES
('Activo', 'Empleado actualmente laborando'),
('Inactivo', 'Empleado dado de baja'),
('Vacaciones', 'Empleado en periodo de vacaciones');

INSERT INTO cliente (nombres_cliente, apellidos_cliente, telefono_cliente, correo_cliente, direccion_cliente) VALUES
('Carlos', 'Pérez López', '55123456', 'carlos.perez@email.com', 'Zona 1, Ciudad de Guatemala'),
('María', 'González Ruiz', '55234567', 'maria.gonzalez@email.com', 'Zona 10, Ciudad de Guatemala'),
('Luis', 'Ramírez Solís', '55345678', 'luis.ramirez@email.com', 'Zacapa, Zacapa');

INSERT INTO estado_pedido (nombre_estado_pedido, descripcion_estado_pedido) VALUES
('Pendiente', 'Pedido registrado, aún no procesado'),
('En ruta', 'Pedido asignado a una ruta de reparto'),
('Entregado', 'Pedido entregado al cliente');

INSERT INTO estado_entrega (nombre_estado_entrega, descripcion_estado_entrega) VALUES
('Pendiente', 'Entrega aún no realizada'),
('Entregado', 'Entrega completada con éxito'),
('Fallida', 'Entrega no pudo completarse');

INSERT INTO tipo_ruta (nombre_tipo_ruta, descripcion_tipo_ruta) VALUES
('Urbana', 'Ruta dentro del área metropolitana'),
('Rural', 'Ruta hacia áreas rurales'),
('Express', 'Ruta de entrega prioritaria');

INSERT INTO estado_ruta (nombre_estado_ruta, descripcion_estado_ruta) VALUES
('Planificada', 'Ruta creada, aún no iniciada'),
('En curso', 'Ruta actualmente en ejecución'),
('Finalizada', 'Ruta completada');

INSERT INTO tipo_vehiculo (nombre_tipo_vehiculo, descripcion_tipo_vehiculo) VALUES
('Motocicleta', 'Vehículo de dos ruedas para entregas rápidas'),
('Camioneta', 'Vehículo de carga mediana'),
('Camión', 'Vehículo de carga pesada');

INSERT INTO estado_vehiculo (nombre_estado_vehiculo, descripcion_estado_vehiculo) VALUES
('Disponible', 'Vehículo listo para asignación'),
('En mantenimiento', 'Vehículo en taller'),
('Fuera de servicio', 'Vehículo no operativo');

INSERT INTO area_cubierta (zona_area_cubierta, municipio_area_cubierta, departamento_area_cubierta, descripcion_area_cubierta) VALUES
('Zona 1', 'Guatemala', 'Guatemala', 'Centro histórico'),
('Zona 10', 'Guatemala', 'Guatemala', 'Zona financiera'),
('Zacapa Centro', 'Zacapa', 'Zacapa', 'Cabecera departamental');

-- NIVEL 2 - DEPENDEN DE UN SOLO CATALOGO
INSERT INTO direccion (id_area, direccion_detalle, referencia_direccion) VALUES
(1, '6a Avenida 3-45, Zona 1', 'Frente al parque central'),
(2, '12 Calle 6-25, Zona 10', 'Edificio Torre Azul, nivel 3'),
(3, '3a Calle 2-10, Zacapa Centro', 'Cerca del mercado municipal');

INSERT INTO sucursal (nombre_sucursal, id_direccion, telefono_sucursal, correo_sucursal) VALUES
('Sucursal Zona 1', 1, '22001111', 'sucursalzona1@reparto.com'),
('Sucursal Zona 10', 2, '22002222', 'sucursalzona10@reparto.com'),
('Sucursal Zacapa', 3, '22003333', 'sucursalzacapa@reparto.com');

INSERT INTO empleado (id_tipo_empleado, id_estado_empleado, nombre_empleado, apellido_empleado, dpi_empleado, nit_empleado, telefono_empleado, direccion_empleado, fecha_nacimiento_empleado, fecha_contratacion_empleado) VALUES
(1, 1, 'Juan', 'Martínez López', '1234567890101', '12345-6', '55112233', 'Zona 1, Guatemala', '1990-05-14', '2020-01-15'),
(2, 1, 'Ana', 'Torres Díaz', '2345678901112', '23456-7', '55223344', 'Zona 10, Guatemala', '1988-09-22', '2019-03-10'),
(3, 1, 'Pedro', 'Sánchez Gómez', '3456789012123', '34567-8', '55334455', 'Zacapa, Zacapa', '1992-11-30', '2021-06-01');

INSERT INTO vehiculo (placa_vehiculo, marca_vehiculo, modelo_vehiculo, anio_vehiculo, capacidad_peso_vehiculo, id_tipo_vehiculo, id_estado_vehiculo) VALUES
('P123ABC', 'Yamaha', 'FZ 150', 2022, 50.00, 1, 1),
('P456DEF', 'Toyota', 'Hilux', 2021, 1200.00, 2, 1),
('P789GHI', 'Isuzu', 'NPR', 2020, 3500.00, 3, 1);

-- NIVEL 3 - DEPENDEN DE TABLAS DE NIVEL 2
INSERT INTO bodega (id_sucursal, nombre_bodega, id_direccion, capacidad_bodega, telefono_bodega) VALUES
(1, 'Bodega Central Zona 1', 1, 500, '22001112'),
(2, 'Bodega Zona 10', 2, 300, '22002223'),
(3, 'Bodega Zacapa', 3, 200, '22003334');

INSERT INTO usuario (id_empleado, usuario_usuario, correo_usuario, contrasena_usuario, ultimo_acceso_usuario, fecha_creacion_usuario, estado_usuario) VALUES
(1, 'jmartinez', 'jmartinez@reparto.com', '$2y$10$hashpass1', NULL, '2020-01-15', 'Activo'),
(2, 'atorres', 'atorres@reparto.com', '$2y$10$hashpass2', NULL, '2019-03-10', 'Activo'),
(3, 'psanchez', 'psanchez@reparto.com', '$2y$10$hashpass3', NULL, '2021-06-01', 'Activo');

-- NIVEL 4 - DEPENDEN DE TABLAS DE NIVEL 3
INSERT INTO ruta (id_bodega, id_area, id_tipo_ruta, id_estado_ruta, fecha_ruta, hora_inicio_ruta, hora_fin_ruta, distancia_km_ruta, observaciones_ruta) VALUES
(1, 1, 1, 1, '2026-08-03', '08:00:00', '12:00:00', 15.50, 'Ruta matutina zona 1'),
(2, 2, 1, 2, '2026-08-03', '09:00:00', '13:00:00', 20.75, 'Ruta zona 10'),
(3, 3, 2, 1, '2026-08-04', '07:30:00', '11:30:00', 45.20, 'Ruta rural Zacapa');

INSERT INTO relacion_rol_modulo (id_modulo, id_rol, der_insertar_relrolmodulo, der_editar_relrolmodulo, der_eliminar_relrolmodulo, der_imprimir_relrolmodulo) VALUES
(1, 1, 'S', 'S', 'S', 'S'),
(2, 1, 'S', 'S', 'S', 'S'),
(1, 2, 'S', 'S', 'N', 'S');

INSERT INTO relacion_usuario_modulo (id_modulo, id_usuario, der_insertar_relusumodulo, der_editar_relusumodulo, der_eliminar_relusumodulo, der_imprimir_relusumodulo) VALUES
(1, 1, 'S', 'S', 'S', 'S'),
(2, 2, 'S', 'S', 'N', 'S'),
(3, 3, 'S', 'N', 'N', 'S');

INSERT INTO usuario_rol (id_usuario, id_rol, fecha_asignacion_usuario_rol) VALUES
(1, 1, '2020-01-15'),
(2, 2, '2019-03-10'),
(3, 3, '2021-06-01');

INSERT INTO asignacion_area (id_empleado, id_area, fecha_inicio_asignacion_area, fecha_fin_asignacion_area) VALUES
(1, 1, '2020-01-15', NULL),
(2, 2, '2019-03-10', NULL),
(3, 3, '2021-06-01', NULL);

-- NIVEL 5 - DEPENDEN DE RUTA / DIRECCION
INSERT INTO pedido (codigo_pedido, id_cliente, id_estado_pedido, id_ruta, id_direccion_origen_pedido, id_direccion_destino_pedido, fecha_solicitud_pedido, peso_total_pedido, cantidad_paquetes_pedido, observaciones_pedido) VALUES
('PED-0001', 1, 1, 1, 1, 2, '2026-08-01', 12.50, 2, 'Entrega urgente'),
('PED-0002', 2, 2, 2, 2, 3, '2026-08-02', 5.00, 1, 'Cliente solicita llamar antes de entregar'),
('PED-0003', 3, 3, 3, 3, 1, '2026-07-30', 30.00, 3, 'Entrega completada sin novedad');

INSERT INTO asignacion_transp (id_ruta, id_vehiculo, id_empleado, fecha_asignacion_asignacion_transp) VALUES
(1, 1, 1, '2026-08-03'),
(2, 2, 2, '2026-08-03'),
(3, 3, 3, '2026-08-04');

-- NIVEL 6 - DEPENDEN DE PEDIDO
-- NOTA: incluye el campo tipo_paquete agregado mediante el ALTER TABLE previo
INSERT INTO paquete (id_pedido, codigo_rastreo_paquete, peso_paquete, alto_paquete, ancho_paquete, largo_paquete, descripcion_paquete, tipo_paquete, fragil_paquete, valor_declarado_paquete) VALUES
(1, 'TRK-0001', 5.50, 30.00, 20.00, 15.00, 'Caja de electrónica', 'Electrónica', 'Si', 1500.00),
(2, 'TRK-0002', 2.00, 15.00, 10.00, 10.00, 'Documentos', 'Documentos', 'No', 100.00),
(3, 'TRK-0003', 12.00, 40.00, 30.00, 25.00, 'Ropa y textiles', 'Ropa', 'No', 800.00);

INSERT INTO entrega (id_pedido, id_estado_entrega, fecha_entrega, hora_entrega, persona_recibe_entrega, observaciones_entrega, firma_recibido_entrega) VALUES
(1, 1, NULL, NULL, NULL, 'Pendiente de entrega', 'No'),
(2, 2, '2026-08-02', '14:30:00', 'María González', 'Entregado en portería', 'Si'),
(3, 3, '2026-07-30', '16:00:00', 'Luis Ramírez', 'Sin novedad', 'Si');

-- NIVEL 7 - DEPENDE DE ENTREGA Y EMPLEADOS
INSERT INTO queja (id_entrega, id_empleado, tipo_queja, comentario_queja, calificacion_queja, fecha_queja) VALUES
(2, 2, 'Retraso', 'El pedido llegó una hora tarde', 3, '2026-08-02'),
(3, 3, 'Servicio', 'Buen trato del repartidor', 5, '2026-07-30'),
(2, 1, 'Empaque', 'El paquete llegó con la caja dañada', 2, '2026-08-02');
