use sistema_reparto

ALTER TABLE roles
ADD COLUMN estado VARCHAR(20) NOT NULL DEFAULT 'Activo';

ALTER TABLE paquete
ADD COLUMN estado VARCHAR(20) NOT NULL DEFAULT 'Activo';

