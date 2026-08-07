CREATE DATABASE  IF NOT EXISTS `sistema_reparto` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_spanish_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `sistema_reparto`;
-- MySQL dump 10.13  Distrib 8.0.46, for Win64 (x86_64)
--
-- Host: localhost    Database: sistema_reparto
-- ------------------------------------------------------
-- Server version	8.0.43

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `area_cubierta`
--

DROP TABLE IF EXISTS `area_cubierta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `area_cubierta` (
  `id_area` int NOT NULL AUTO_INCREMENT,
  `zona_area_cubierta` varchar(100) COLLATE utf8mb4_spanish_ci NOT NULL,
  `municipio_area_cubierta` varchar(100) COLLATE utf8mb4_spanish_ci DEFAULT NULL,
  `departamento_area_cubierta` varchar(100) COLLATE utf8mb4_spanish_ci DEFAULT NULL,
  `descripcion_area_cubierta` varchar(255) COLLATE utf8mb4_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`id_area`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `area_cubierta`
--

LOCK TABLES `area_cubierta` WRITE;
/*!40000 ALTER TABLE `area_cubierta` DISABLE KEYS */;
INSERT INTO `area_cubierta` VALUES (1,'Zona 1','Guatemala','Guatemala','Centro histórico'),(2,'Zona 10','Guatemala','Guatemala','Zona financiera'),(3,'Zacapa Centro','Zacapa','Zacapa','Cabecera departamental'),(4,'Zona 1','Guatemala','Guatemala','Centro historico de la ciudad'),(5,'Zona 10','Guatemala','Guatemala','Zona comercial y financiera'),(6,'Mixco Centro','Mixco','Guatemala','Area urbana de Mixco'),(7,'Villa Nueva Centro','Villa Nueva','Guatemala','Area urbana de Villa Nueva'),(8,'Antigua Centro','Antigua Guatemala','Sacatepequez','Casco urbano de Antigua'),(9,'Quetzaltenango Centro','Quetzaltenango','Quetzaltenango','Area urbana de Xela'),(10,'Escuintla Centro','Escuintla','Escuintla','Area urbana de Escuintla'),(11,'Chimaltenango Centro','Chimaltenango','Chimaltenango','Area urbana de Chimaltenango');
/*!40000 ALTER TABLE `area_cubierta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `asignacion_area`
--

DROP TABLE IF EXISTS `asignacion_area`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `asignacion_area` (
  `id_asignacion_area` int NOT NULL AUTO_INCREMENT,
  `id_empleado` int NOT NULL,
  `id_area` int NOT NULL,
  `fecha_inicio_asignacion_area` date DEFAULT NULL,
  `fecha_fin_asignacion_area` date DEFAULT NULL,
  PRIMARY KEY (`id_asignacion_area`),
  KEY `fk_asigarea_empleado` (`id_empleado`),
  KEY `fk_asigarea_area` (`id_area`),
  CONSTRAINT `fk_asigarea_area` FOREIGN KEY (`id_area`) REFERENCES `area_cubierta` (`id_area`),
  CONSTRAINT `fk_asigarea_empleado` FOREIGN KEY (`id_empleado`) REFERENCES `empleado` (`id_empleado`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `asignacion_area`
--

LOCK TABLES `asignacion_area` WRITE;
/*!40000 ALTER TABLE `asignacion_area` DISABLE KEYS */;
INSERT INTO `asignacion_area` VALUES (1,1,1,'2020-01-10',NULL),(2,2,2,'2019-05-03',NULL),(3,3,3,'2021-02-17',NULL),(4,4,4,'2018-08-20',NULL),(5,5,5,'2022-03-01',NULL),(6,6,6,'2021-11-15','2026-01-01'),(7,7,7,'2015-06-01',NULL),(8,8,8,'2023-01-09',NULL);
/*!40000 ALTER TABLE `asignacion_area` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `asignacion_transp`
--

DROP TABLE IF EXISTS `asignacion_transp`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `asignacion_transp` (
  `id_asignacion` int NOT NULL AUTO_INCREMENT,
  `id_ruta` int NOT NULL,
  `id_vehiculo` int NOT NULL,
  `id_empleado` int NOT NULL,
  `fecha_asignacion_asignacion_transp` date DEFAULT NULL,
  `observaciones` varchar(255) COLLATE utf8mb4_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`id_asignacion`),
  KEY `fk_asigtransp_ruta` (`id_ruta`),
  KEY `fk_asigtransp_vehiculo` (`id_vehiculo`),
  KEY `fk_asigtransp_empleado` (`id_empleado`),
  CONSTRAINT `fk_asigtransp_empleado` FOREIGN KEY (`id_empleado`) REFERENCES `empleado` (`id_empleado`),
  CONSTRAINT `fk_asigtransp_ruta` FOREIGN KEY (`id_ruta`) REFERENCES `ruta` (`id_ruta`),
  CONSTRAINT `fk_asigtransp_vehiculo` FOREIGN KEY (`id_vehiculo`) REFERENCES `vehiculo` (`id_vehiculo`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `asignacion_transp`
--

LOCK TABLES `asignacion_transp` WRITE;
/*!40000 ALTER TABLE `asignacion_transp` DISABLE KEYS */;
INSERT INTO `asignacion_transp` VALUES (1,1,1,1,'2026-08-01','Asignacion sin novedad'),(2,2,2,2,'2026-08-01','Vehiculo revisado antes de salir'),(3,3,3,3,'2026-08-06','En curso actualmente'),(4,4,4,4,'2026-08-07','Pendiente de inicio'),(5,5,5,5,'2026-07-30','Ruta larga finalizada sin problemas'),(6,6,6,6,'2026-08-05','Pausada por lluvia intensa'),(7,7,7,7,'2026-08-04','Retraso reportado por el conductor'),(8,8,8,8,'2026-08-08','Asignacion nocturna programada'),(9,1,8,11,'2026-08-03','');
/*!40000 ALTER TABLE `asignacion_transp` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bodega`
--

DROP TABLE IF EXISTS `bodega`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bodega` (
  `id_bodega` int NOT NULL AUTO_INCREMENT,
  `id_sucursal` int NOT NULL,
  `nombre_bodega` varchar(100) COLLATE utf8mb4_spanish_ci NOT NULL,
  `id_direccion` int DEFAULT NULL,
  `capacidad_bodega` int DEFAULT NULL,
  `telefono_bodega` varchar(20) COLLATE utf8mb4_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`id_bodega`),
  KEY `fk_bodega_sucursal` (`id_sucursal`),
  KEY `fk_bodega_direccion` (`id_direccion`),
  CONSTRAINT `fk_bodega_direccion` FOREIGN KEY (`id_direccion`) REFERENCES `direccion` (`id_direccion`),
  CONSTRAINT `fk_bodega_sucursal` FOREIGN KEY (`id_sucursal`) REFERENCES `sucursal` (`id_sucursal`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bodega`
--

LOCK TABLES `bodega` WRITE;
/*!40000 ALTER TABLE `bodega` DISABLE KEYS */;
INSERT INTO `bodega` VALUES (1,1,'Bodega Central Zona 1',1,500,'22001112'),(2,2,'Bodega Zona 10',2,300,'22002223'),(3,3,'Bodega Zacapa',3,200,'22003334'),(4,1,'Bodega Central Zona 1',1,5000,'22001101'),(5,2,'Bodega Zona 10',2,4000,'22002201'),(6,3,'Bodega Mixco',3,3500,'22003301'),(7,4,'Bodega Villa Nueva',4,3000,'22004401'),(8,5,'Bodega Antigua',5,2000,'22005501'),(9,6,'Bodega Quetzaltenango',6,2500,'22006601'),(10,7,'Bodega Escuintla',7,2200,'22007701'),(11,8,'Bodega Chimaltenango',8,1800,'22008801');
/*!40000 ALTER TABLE `bodega` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cliente` (
  `id_cliente` int NOT NULL AUTO_INCREMENT,
  `nombres_cliente` varchar(100) COLLATE utf8mb4_spanish_ci NOT NULL,
  `apellidos_cliente` varchar(100) COLLATE utf8mb4_spanish_ci NOT NULL,
  `telefono_cliente` varchar(20) COLLATE utf8mb4_spanish_ci DEFAULT NULL,
  `correo_cliente` varchar(100) COLLATE utf8mb4_spanish_ci DEFAULT NULL,
  `direccion_cliente` varchar(255) COLLATE utf8mb4_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`id_cliente`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` VALUES (1,'Carlos','Pérez López','55123456','carlos.perez@email.com','Zona 1, Ciudad de Guatemala'),(2,'María','González Ruiz','55234567','maria.gonzalez@email.com','Zona 10, Ciudad de Guatemala'),(3,'Luis','Ramírez Solís','55345678','luis.ramirez@email.com','Zacapa, Zacapa'),(4,'Maria Jose','Lopez Ramirez','55123456','maria.lopez@gmail.com','3a Avenida 5-20 Zona 1, Guatemala'),(5,'Carlos Enrique','Gonzalez Perez','55234567','carlos.gonzalez@gmail.com','7a Calle 12-30 Zona 10, Guatemala'),(6,'Ana Lucia','Martinez Diaz','55345678','ana.martinez@gmail.com','Colonia El Rosario, Mixco'),(7,'Jose Fernando','Ramirez Ortiz','55456789','jose.ramirez@gmail.com','Boulevard Los Naranjos, Villa Nueva'),(8,'Sofia Andrea','Castillo Mejia','55567890','sofia.castillo@gmail.com','4a Calle Poniente, Antigua Guatemala'),(9,'Luis Alberto','Hernandez Cruz','55678901','luis.hernandez@gmail.com','15 Avenida 3-45 Zona 3, Quetzaltenango'),(10,'Gabriela Patricia','Morales Soto','55789012','gabriela.morales@gmail.com','Colonia San Jose, Escuintla'),(11,'Diego Alejandro','Vasquez Reyes','55890123','diego.vasquez@gmail.com','2a Calle 6-10, Chimaltenango');
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_asignacion_transp`
--

DROP TABLE IF EXISTS `detalle_asignacion_transp`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `detalle_asignacion_transp` (
  `id_detalle` int NOT NULL AUTO_INCREMENT,
  `id_asignacion` int NOT NULL,
  `id_pedido` int NOT NULL,
  `estado_pedido` enum('Pendiente','En ruta','Entregado','No entregado') COLLATE utf8mb4_spanish_ci DEFAULT 'En ruta',
  PRIMARY KEY (`id_detalle`),
  KEY `id_asignacion` (`id_asignacion`),
  KEY `id_pedido` (`id_pedido`),
  CONSTRAINT `detalle_asignacion_transp_ibfk_1` FOREIGN KEY (`id_asignacion`) REFERENCES `asignacion_transp` (`id_asignacion`),
  CONSTRAINT `detalle_asignacion_transp_ibfk_2` FOREIGN KEY (`id_pedido`) REFERENCES `pedido` (`id_pedido`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_asignacion_transp`
--

LOCK TABLES `detalle_asignacion_transp` WRITE;
/*!40000 ALTER TABLE `detalle_asignacion_transp` DISABLE KEYS */;
INSERT INTO `detalle_asignacion_transp` VALUES (1,1,1,'Entregado'),(2,2,2,'Entregado'),(3,3,3,'En ruta'),(4,4,4,'Pendiente'),(5,5,5,'Entregado'),(6,6,6,'No entregado'),(7,7,7,'En ruta'),(8,8,8,'Pendiente'),(9,9,5,'En ruta');
/*!40000 ALTER TABLE `detalle_asignacion_transp` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `direccion`
--

DROP TABLE IF EXISTS `direccion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `direccion` (
  `id_direccion` int NOT NULL AUTO_INCREMENT,
  `id_area` int NOT NULL,
  `direccion_detalle` varchar(255) COLLATE utf8mb4_spanish_ci NOT NULL,
  `referencia_direccion` varchar(255) COLLATE utf8mb4_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`id_direccion`),
  KEY `fk_direccion_area` (`id_area`),
  CONSTRAINT `fk_direccion_area` FOREIGN KEY (`id_area`) REFERENCES `area_cubierta` (`id_area`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `direccion`
--

LOCK TABLES `direccion` WRITE;
/*!40000 ALTER TABLE `direccion` DISABLE KEYS */;
INSERT INTO `direccion` VALUES (1,1,'6a Avenida 3-45, Zona 1','Frente al parque central'),(2,2,'12 Calle 6-25, Zona 10','Edificio Torre Azul, nivel 3'),(3,3,'3a Calle 2-10, Zacapa Centro','Cerca del mercado municipal'),(4,1,'22 av 15-45 capitol',NULL),(5,3,'zona 3 centro',NULL),(6,1,'3a Avenida 5-20 Zona 1','Frente al Parque Central'),(7,2,'7a Calle 12-30 Zona 10','Junto a Centro Comercial Oakland'),(8,3,'Colonia El Rosario, Mixco','A dos cuadras del mercado municipal'),(9,4,'Boulevard Los Naranjos, Villa Nueva','Cerca del Trebol de Villa Nueva'),(10,5,'4a Calle Poniente, Antigua Guatemala','A media cuadra del Parque Central de Antigua'),(11,6,'15 Avenida 3-45 Zona 3, Quetzaltenango','Frente a la Terminal de Buses'),(12,7,'Colonia San Jose, Escuintla','Detras del Hospital Nacional'),(13,8,'2a Calle 6-10, Chimaltenango','Cerca de la Municipalidad');
/*!40000 ALTER TABLE `direccion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empleado`
--

DROP TABLE IF EXISTS `empleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `empleado` (
  `id_empleado` int NOT NULL AUTO_INCREMENT,
  `id_tipo_empleado` int NOT NULL,
  `id_estado_empleado` int NOT NULL,
  `nombre_empleado` varchar(100) COLLATE utf8mb4_spanish_ci NOT NULL,
  `apellido_empleado` varchar(100) COLLATE utf8mb4_spanish_ci NOT NULL,
  `dpi_empleado` varchar(20) COLLATE utf8mb4_spanish_ci DEFAULT NULL,
  `nit_empleado` varchar(20) COLLATE utf8mb4_spanish_ci DEFAULT NULL,
  `telefono_empleado` varchar(20) COLLATE utf8mb4_spanish_ci DEFAULT NULL,
  `direccion_empleado` varchar(255) COLLATE utf8mb4_spanish_ci DEFAULT NULL,
  `fecha_nacimiento_empleado` date DEFAULT NULL,
  `fecha_contratacion_empleado` date DEFAULT NULL,
  PRIMARY KEY (`id_empleado`),
  KEY `fk_empleados_tipo` (`id_tipo_empleado`),
  KEY `fk_empleados_estado` (`id_estado_empleado`),
  CONSTRAINT `fk_empleados_estado` FOREIGN KEY (`id_estado_empleado`) REFERENCES `estado_empleado` (`id_estado_empleado`),
  CONSTRAINT `fk_empleados_tipo` FOREIGN KEY (`id_tipo_empleado`) REFERENCES `tipo_empleado` (`id_tipo_empleado`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empleado`
--

LOCK TABLES `empleado` WRITE;
/*!40000 ALTER TABLE `empleado` DISABLE KEYS */;
INSERT INTO `empleado` VALUES (1,1,1,'Juan','Martínez López','1234567890101','12345-6','55112233','Zona 1, Guatemala','1990-05-14','2020-01-15'),(2,2,1,'Ana','Torres Díaz','2345678901112','23456-7','55223344','Zona 10, Guatemala','1988-09-22','2019-03-10'),(3,3,1,'Pedro','Sánchez Gómez','3456789012123','34567-8','55334455','Zacapa, Zacapa','1992-11-30','2021-06-01'),(4,1,1,'Juan','Isa','1234567890101','12345-6','55112233','Zona 1, Guatemala','1990-05-14','2020-01-15'),(5,2,1,'Administrador','General','7897857885475','4606649-7','57897458','Zona 5 jardines de la asuncion 22-15','1959-02-06','2026-08-06'),(6,1,1,'Cristian','Sipac','1234567891234','7894567-8','35922120','El Gallito','2004-07-08','2026-08-06'),(7,1,1,'Pedro','Sandoval Lima','1985123450101','1234561','55111222','Zona 6, Guatemala','1992-03-15','2020-01-10'),(8,2,1,'Marta','Chavez Osorio','1990234560202','1234562','55222333','Zona 7, Guatemala','1988-07-22','2019-05-03'),(9,3,1,'Rodrigo','Paz Fuentes','1987345670303','1234563','55333444','Mixco','1990-11-05','2021-02-17'),(10,4,1,'Claudia','Estrada Marroquin','1989456780404','1234564','55444555','Villa Nueva','1985-09-30','2018-08-20'),(11,5,1,'Fernando','Barrios Solis','1991567890505','1234565','55555666','Antigua Guatemala','1993-04-12','2022-03-01'),(12,6,3,'Yesenia','Ochoa Villagran','1993678900606','1234566','55666777','Quetzaltenango','1995-01-25','2021-11-15'),(13,7,1,'Miguel','Aguilar Contreras','1980789010707','1234567','55777888','Escuintla','1982-06-18','2015-06-01'),(14,8,2,'Daniela','Toc Xicay','1994890120808','1234568','55888999','Chimaltenango','1996-12-08','2023-01-09');
/*!40000 ALTER TABLE `empleado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `entrega`
--

DROP TABLE IF EXISTS `entrega`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `entrega` (
  `id_entrega` int NOT NULL AUTO_INCREMENT,
  `id_pedido` int NOT NULL,
  `id_estado_entrega` int NOT NULL,
  `fecha_entrega` date DEFAULT NULL,
  `hora_entrega` time DEFAULT NULL,
  `persona_recibe_entrega` varchar(100) COLLATE utf8mb4_spanish_ci DEFAULT NULL,
  `observaciones_entrega` varchar(255) COLLATE utf8mb4_spanish_ci DEFAULT NULL,
  `firma_recibido_entrega` varchar(5) COLLATE utf8mb4_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`id_entrega`),
  KEY `fk_entrega_pedido` (`id_pedido`),
  KEY `fk_entrega_estado` (`id_estado_entrega`),
  CONSTRAINT `fk_entrega_estado` FOREIGN KEY (`id_estado_entrega`) REFERENCES `estado_entrega` (`id_estado_entrega`),
  CONSTRAINT `fk_entrega_pedido` FOREIGN KEY (`id_pedido`) REFERENCES `pedido` (`id_pedido`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `entrega`
--

LOCK TABLES `entrega` WRITE;
/*!40000 ALTER TABLE `entrega` DISABLE KEYS */;
INSERT INTO `entrega` VALUES (1,1,3,'2026-08-01','11:45:00','Maria Jose Lopez','Entrega sin novedad','Si'),(2,2,3,'2026-08-01','12:30:00','Carlos Gonzalez','Cliente satisfecho','Si'),(3,3,2,NULL,NULL,NULL,'Repartidor en camino','No'),(4,4,1,NULL,NULL,NULL,'Pendiente de despacho','No'),(5,5,3,'2026-07-29','10:15:00','Sofia Castillo','Entrega exitosa','Si'),(6,6,6,'2026-08-04','15:00:00',NULL,'Cliente rechazo el paquete','No'),(7,7,4,'2026-08-03','17:20:00',NULL,'No se encontro al destinatario','No'),(8,8,1,NULL,NULL,NULL,'En espera de asignacion final','No');
/*!40000 ALTER TABLE `entrega` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `estado_empleado`
--

DROP TABLE IF EXISTS `estado_empleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `estado_empleado` (
  `id_estado_empleado` int NOT NULL AUTO_INCREMENT,
  `nombre_estado_empleado` varchar(50) COLLATE utf8mb4_spanish_ci NOT NULL,
  `descripcion_estado_empleado` varchar(255) COLLATE utf8mb4_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`id_estado_empleado`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `estado_empleado`
--

LOCK TABLES `estado_empleado` WRITE;
/*!40000 ALTER TABLE `estado_empleado` DISABLE KEYS */;
INSERT INTO `estado_empleado` VALUES (1,'Activo','Empleado actualmente laborando'),(2,'Inactivo','Empleado dado de baja'),(3,'Vacaciones','Empleado en periodo de vacaciones'),(4,'Activo','Empleado laborando actualmente'),(5,'Inactivo','Empleado dado de baja'),(6,'Vacaciones','Empleado de vacaciones'),(7,'Suspendido','Empleado suspendido temporalmente'),(8,'Permiso','Empleado con permiso autorizado'),(9,'Baja Temporal','Baja temporal por diversas causas'),(10,'Incapacidad','Empleado con incapacidad medica'),(11,'Jubilado','Empleado jubilado');
/*!40000 ALTER TABLE `estado_empleado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `estado_entrega`
--

DROP TABLE IF EXISTS `estado_entrega`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `estado_entrega` (
  `id_estado_entrega` int NOT NULL AUTO_INCREMENT,
  `nombre_estado_entrega` varchar(50) COLLATE utf8mb4_spanish_ci NOT NULL,
  `descripcion_estado_entrega` varchar(255) COLLATE utf8mb4_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`id_estado_entrega`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `estado_entrega`
--

LOCK TABLES `estado_entrega` WRITE;
/*!40000 ALTER TABLE `estado_entrega` DISABLE KEYS */;
INSERT INTO `estado_entrega` VALUES (1,'Pendiente','Entrega aún no realizada'),(2,'Entregado','Entrega completada con éxito'),(3,'Fallida','Entrega no pudo completarse'),(4,'Pendiente','Entrega aun no realizada'),(5,'En camino','Repartidor en camino a destino'),(6,'Entregado','Entrega completada con exito'),(7,'No entregado','No fue posible entregar el pedido'),(8,'Reprogramado','Entrega reprogramada para otra fecha'),(9,'Rechazado','Cliente rechazo el pedido'),(10,'Parcial','Entrega parcial del pedido'),(11,'Fallido','Intento de entrega fallido');
/*!40000 ALTER TABLE `estado_entrega` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `estado_pedido`
--

DROP TABLE IF EXISTS `estado_pedido`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `estado_pedido` (
  `id_estado_pedido` int NOT NULL AUTO_INCREMENT,
  `nombre_estado_pedido` varchar(50) COLLATE utf8mb4_spanish_ci NOT NULL,
  `descripcion_estado_pedido` varchar(255) COLLATE utf8mb4_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`id_estado_pedido`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `estado_pedido`
--

LOCK TABLES `estado_pedido` WRITE;
/*!40000 ALTER TABLE `estado_pedido` DISABLE KEYS */;
INSERT INTO `estado_pedido` VALUES (1,'Pendiente','Pedido registrado, aún no procesado'),(2,'En ruta','Pedido asignado a una ruta de reparto'),(3,'Entregado','Pedido entregado al cliente'),(4,'Pendiente','Pedido registrado sin procesar'),(5,'Confirmado','Pedido confirmado por el cliente'),(6,'En preparacion','Pedido siendo preparado en bodega'),(7,'En ruta','Pedido asignado a una ruta de reparto'),(8,'Entregado','Pedido entregado satisfactoriamente'),(9,'Cancelado','Pedido cancelado por el cliente o la empresa'),(10,'Devuelto','Pedido devuelto a bodega'),(11,'Retrasado','Pedido con retraso en la entrega');
/*!40000 ALTER TABLE `estado_pedido` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `estado_ruta`
--

DROP TABLE IF EXISTS `estado_ruta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `estado_ruta` (
  `id_estado_ruta` int NOT NULL AUTO_INCREMENT,
  `nombre_estado_ruta` varchar(50) COLLATE utf8mb4_spanish_ci NOT NULL,
  `descripcion_estado_ruta` varchar(255) COLLATE utf8mb4_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`id_estado_ruta`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `estado_ruta`
--

LOCK TABLES `estado_ruta` WRITE;
/*!40000 ALTER TABLE `estado_ruta` DISABLE KEYS */;
INSERT INTO `estado_ruta` VALUES (1,'Planificada','Ruta creada, aún no iniciada'),(2,'En curso','Ruta actualmente en ejecución'),(3,'Finalizada','Ruta completada'),(4,'Planificada','Ruta programada sin iniciar'),(5,'En curso','Ruta actualmente en ejecucion'),(6,'Finalizada','Ruta completada'),(7,'Cancelada','Ruta cancelada'),(8,'Pausada','Ruta pausada temporalmente'),(9,'Retrasada','Ruta con retraso en su ejecucion'),(10,'Reasignada','Ruta reasignada a otro conductor'),(11,'En revision','Ruta en proceso de revision');
/*!40000 ALTER TABLE `estado_ruta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `estado_vehiculo`
--

DROP TABLE IF EXISTS `estado_vehiculo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `estado_vehiculo` (
  `id_estado_vehiculo` int NOT NULL AUTO_INCREMENT,
  `nombre_estado_vehiculo` varchar(50) COLLATE utf8mb4_spanish_ci NOT NULL,
  `descripcion_estado_vehiculo` varchar(255) COLLATE utf8mb4_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`id_estado_vehiculo`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `estado_vehiculo`
--

LOCK TABLES `estado_vehiculo` WRITE;
/*!40000 ALTER TABLE `estado_vehiculo` DISABLE KEYS */;
INSERT INTO `estado_vehiculo` VALUES (1,'Disponible','Vehículo listo para asignación'),(2,'En mantenimiento','Vehículo en taller'),(3,'Fuera de servicio','Vehículo no operativo'),(4,'Disponible','Vehiculo listo para asignacion'),(5,'En ruta','Vehiculo actualmente en reparto'),(6,'Mantenimiento','Vehiculo en mantenimiento preventivo'),(7,'Fuera de servicio','Vehiculo no operativo'),(8,'Reservado','Vehiculo reservado para una ruta'),(9,'En reparacion','Vehiculo en taller por reparacion'),(10,'Dado de baja','Vehiculo retirado de la flota'),(11,'Revision tecnica','Vehiculo en revision tecnica');
/*!40000 ALTER TABLE `estado_vehiculo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `modulo`
--

DROP TABLE IF EXISTS `modulo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `modulo` (
  `id_modulo` int NOT NULL AUTO_INCREMENT,
  `nombre_modulo` varchar(50) COLLATE utf8mb4_spanish_ci NOT NULL,
  `estatus_modulo` varchar(10) COLLATE utf8mb4_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`id_modulo`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `modulo`
--

LOCK TABLES `modulo` WRITE;
/*!40000 ALTER TABLE `modulo` DISABLE KEYS */;
INSERT INTO `modulo` VALUES (1,'Pedidos','Activo'),(2,'Rutas','Activo'),(3,'Reportes','Activo'),(4,'Usuarios','Activo'),(5,'Areas Cubiertas','Activo'),(6,'Paquetes','Activo'),(7,'Bodegas','Activo'),(8,'Transportes','Activo'),(9,'Empleados','Activo'),(10,'Sucursales','Activo'),(11,'Asignacion','Activo');
/*!40000 ALTER TABLE `modulo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `paquete`
--

DROP TABLE IF EXISTS `paquete`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `paquete` (
  `id_paquete` int NOT NULL AUTO_INCREMENT,
  `id_pedido` int NOT NULL,
  `codigo_rastreo_paquete` varchar(30) COLLATE utf8mb4_spanish_ci DEFAULT NULL,
  `peso_paquete` decimal(10,2) DEFAULT NULL,
  `alto_paquete` decimal(10,2) DEFAULT NULL,
  `ancho_paquete` decimal(10,2) DEFAULT NULL,
  `largo_paquete` decimal(10,2) DEFAULT NULL,
  `descripcion_paquete` varchar(255) COLLATE utf8mb4_spanish_ci DEFAULT NULL,
  `fragil_paquete` varchar(5) COLLATE utf8mb4_spanish_ci DEFAULT NULL,
  `valor_declarado_paquete` decimal(10,2) DEFAULT NULL,
  `tipo_paquete` varchar(25) COLLATE utf8mb4_spanish_ci DEFAULT NULL,
  `estado_paquete` varchar(20) COLLATE utf8mb4_spanish_ci NOT NULL DEFAULT 'Activo',
  PRIMARY KEY (`id_paquete`),
  KEY `fk_paquete_pedido` (`id_pedido`),
  CONSTRAINT `fk_paquete_pedido` FOREIGN KEY (`id_pedido`) REFERENCES `pedido` (`id_pedido`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `paquete`
--

LOCK TABLES `paquete` WRITE;
/*!40000 ALTER TABLE `paquete` DISABLE KEYS */;
INSERT INTO `paquete` VALUES (1,1,'TRK-00001',2.50,30.00,20.00,15.00,'Ropa y accesorios','No',250.00,'Textil','Activo'),(2,2,'TRK-00002',3.20,25.00,25.00,25.00,'Equipo electronico','Si',1200.00,'Electronico','Activo'),(3,3,'TRK-00003',1.80,15.00,15.00,10.00,'Vajilla de ceramica','Si',450.00,'Fragil','Activo'),(4,4,'TRK-00004',5.00,40.00,30.00,30.00,'Repuestos automotrices','No',800.00,'Ferreteria','Activo'),(5,5,'TRK-00005',2.10,20.00,20.00,20.00,'Documentos importantes','No',0.00,'Documentos','Activo'),(6,6,'TRK-00006',6.30,35.00,35.00,25.00,'Juguetes surtidos','No',300.00,'Juguetes','Inactivo'),(7,7,'TRK-00007',4.40,28.00,22.00,18.00,'Articulos de cocina','Si',350.00,'Hogar','Activo'),(8,8,'TRK-00008',4.40,26.00,20.00,16.00,'Libros y utiles escolares','No',180.00,'Educativo','Activo');
/*!40000 ALTER TABLE `paquete` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pedido`
--

DROP TABLE IF EXISTS `pedido`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pedido` (
  `id_pedido` int NOT NULL AUTO_INCREMENT,
  `codigo_pedido` varchar(20) COLLATE utf8mb4_spanish_ci NOT NULL,
  `id_cliente` int NOT NULL,
  `id_estado_pedido` int NOT NULL,
  `id_ruta` int DEFAULT NULL,
  `id_direccion_origen_pedido` int DEFAULT NULL,
  `id_direccion_destino_pedido` int NOT NULL,
  `fecha_solicitud_pedido` date DEFAULT NULL,
  `peso_total_pedido` decimal(10,2) DEFAULT NULL,
  `cantidad_paquetes_pedido` int DEFAULT NULL,
  `observaciones_pedido` varchar(255) COLLATE utf8mb4_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`id_pedido`),
  UNIQUE KEY `uq_pedido_codigo` (`codigo_pedido`),
  KEY `fk_pedido_cliente` (`id_cliente`),
  KEY `fk_pedido_estado` (`id_estado_pedido`),
  KEY `fk_pedido_ruta` (`id_ruta`),
  KEY `fk_pedido_dir_origen` (`id_direccion_origen_pedido`),
  KEY `fk_pedido_dir_destino` (`id_direccion_destino_pedido`),
  CONSTRAINT `fk_pedido_cliente` FOREIGN KEY (`id_cliente`) REFERENCES `cliente` (`id_cliente`),
  CONSTRAINT `fk_pedido_dir_destino` FOREIGN KEY (`id_direccion_destino_pedido`) REFERENCES `direccion` (`id_direccion`),
  CONSTRAINT `fk_pedido_dir_origen` FOREIGN KEY (`id_direccion_origen_pedido`) REFERENCES `direccion` (`id_direccion`),
  CONSTRAINT `fk_pedido_estado` FOREIGN KEY (`id_estado_pedido`) REFERENCES `estado_pedido` (`id_estado_pedido`),
  CONSTRAINT `fk_pedido_ruta` FOREIGN KEY (`id_ruta`) REFERENCES `ruta` (`id_ruta`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pedido`
--

LOCK TABLES `pedido` WRITE;
/*!40000 ALTER TABLE `pedido` DISABLE KEYS */;
INSERT INTO `pedido` VALUES (1,'PED-001',3,2,NULL,4,5,'2026-08-06',7.00,5,'Entrega express'),(2,'PED-0001',1,5,1,1,1,'2026-07-30',5.50,2,'Entregar en horario de la manana'),(3,'PED-0002',2,5,2,2,2,'2026-07-30',3.20,1,'Cliente solicita llamada antes de llegar'),(4,'PED-0003',3,4,3,3,3,'2026-08-05',8.00,3,'Paquete fragil'),(5,'PED-0004',4,1,1,4,4,'2026-08-06',12.75,4,'Pendiente de confirmacion de pago'),(6,'PED-0005',5,5,5,5,5,'2026-07-29',2.10,1,'Entrega exitosa'),(7,'PED-0006',6,6,6,6,6,'2026-08-04',6.30,2,'Pedido cancelado por el cliente'),(8,'PED-0007',7,8,7,7,7,'2026-08-03',9.90,3,'Retraso por condiciones climaticas'),(9,'PED-0008',8,2,8,8,8,'2026-08-06',4.40,1,'Confirmado, en espera de despacho');
/*!40000 ALTER TABLE `pedido` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `queja`
--

DROP TABLE IF EXISTS `queja`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `queja` (
  `id_queja` int NOT NULL AUTO_INCREMENT,
  `id_entrega` int NOT NULL,
  `id_cliente` int NOT NULL,
  `tipo_queja` varchar(50) COLLATE utf8mb4_spanish_ci DEFAULT NULL,
  `comentario_queja` varchar(500) COLLATE utf8mb4_spanish_ci DEFAULT NULL,
  `calificacion_queja` int DEFAULT NULL,
  `fecha_queja` date DEFAULT NULL,
  PRIMARY KEY (`id_queja`),
  KEY `fk_queja_entrega` (`id_entrega`),
  KEY `fk_queja_cliente` (`id_cliente`),
  CONSTRAINT `fk_queja_cliente` FOREIGN KEY (`id_cliente`) REFERENCES `cliente` (`id_cliente`),
  CONSTRAINT `fk_queja_entrega` FOREIGN KEY (`id_entrega`) REFERENCES `entrega` (`id_entrega`),
  CONSTRAINT `ck_queja_calificacion` CHECK ((`calificacion_queja` between 1 and 5))
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `queja`
--

LOCK TABLES `queja` WRITE;
/*!40000 ALTER TABLE `queja` DISABLE KEYS */;
INSERT INTO `queja` VALUES (1,1,1,'Reclamo','Entrega llego mas tarde de lo esperado',3,'2026-08-01'),(2,2,2,'Elogio','Repartidor muy amable y profesional',5,'2026-08-01'),(3,3,3,'Reclamo','Cliente reporto caja danada',2,'2026-08-06'),(4,4,4,'Sugerencia','Falta de aviso previo a la entrega',3,'2026-08-06'),(5,5,5,'Elogio','Excelente atencion durante la entrega',5,'2026-07-29'),(6,6,6,'Sugerencia','Cliente no reconocio el pedido',1,'2026-08-04'),(7,7,7,'Sugerencia','Retraso significativo por mal tiempo',2,'2026-08-03'),(8,8,8,'Sugerencia','Consulta sobre reprogramacion de entrega',4,'2026-08-06');
/*!40000 ALTER TABLE `queja` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `relacion_rol_modulo`
--

DROP TABLE IF EXISTS `relacion_rol_modulo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `relacion_rol_modulo` (
  `id_modulo` int NOT NULL,
  `id_rol` int NOT NULL,
  `der_insertar_relrolmodulo` varchar(1) COLLATE utf8mb4_spanish_ci NOT NULL,
  `der_editar_relrolmodulo` varchar(1) COLLATE utf8mb4_spanish_ci NOT NULL,
  `der_eliminar_relrolmodulo` varchar(1) COLLATE utf8mb4_spanish_ci NOT NULL,
  `der_imprimir_relrolmodulo` varchar(1) COLLATE utf8mb4_spanish_ci NOT NULL,
  PRIMARY KEY (`id_modulo`,`id_rol`),
  KEY `fk_relacion_rol` (`id_rol`),
  CONSTRAINT `fk_relacion_modulo` FOREIGN KEY (`id_modulo`) REFERENCES `modulo` (`id_modulo`),
  CONSTRAINT `fk_relacion_rol` FOREIGN KEY (`id_rol`) REFERENCES `rol` (`id_rol`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `relacion_rol_modulo`
--

LOCK TABLES `relacion_rol_modulo` WRITE;
/*!40000 ALTER TABLE `relacion_rol_modulo` DISABLE KEYS */;
INSERT INTO `relacion_rol_modulo` VALUES (1,1,'S','S','S','S'),(1,2,'S','S','S','N'),(2,1,'S','S','S','S'),(3,1,'S','S','S','N'),(4,1,'S','S','S','S'),(5,1,'S','S','S','N'),(6,1,'S','S','S','N'),(6,2,'S','N','S','N'),(7,1,'S','S','S','N'),(7,2,'S','N','S','N'),(8,1,'S','S','S','N'),(9,1,'S','S','S','N'),(10,1,'S','S','S','N'),(11,1,'S','S','S','N');
/*!40000 ALTER TABLE `relacion_rol_modulo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `relacion_usuario_modulo`
--

DROP TABLE IF EXISTS `relacion_usuario_modulo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `relacion_usuario_modulo` (
  `id_modulo` int NOT NULL,
  `id_usuario` int NOT NULL,
  `der_insertar_relusumodulo` varchar(1) COLLATE utf8mb4_spanish_ci NOT NULL,
  `der_editar_relusumodulo` varchar(1) COLLATE utf8mb4_spanish_ci NOT NULL,
  `der_eliminar_relusumodulo` varchar(1) COLLATE utf8mb4_spanish_ci NOT NULL,
  `der_imprimir_relusumodulo` varchar(1) COLLATE utf8mb4_spanish_ci NOT NULL,
  PRIMARY KEY (`id_modulo`,`id_usuario`),
  KEY `fk_relacion_usuario` (`id_usuario`),
  CONSTRAINT `fk_relacion_usuario` FOREIGN KEY (`id_usuario`) REFERENCES `usuario` (`id_usuario`),
  CONSTRAINT `fk_usurio_modulo` FOREIGN KEY (`id_modulo`) REFERENCES `modulo` (`id_modulo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `relacion_usuario_modulo`
--

LOCK TABLES `relacion_usuario_modulo` WRITE;
/*!40000 ALTER TABLE `relacion_usuario_modulo` DISABLE KEYS */;
INSERT INTO `relacion_usuario_modulo` VALUES (1,1,'S','S','S','S'),(2,2,'S','S','N','S'),(3,3,'S','N','N','S');
/*!40000 ALTER TABLE `relacion_usuario_modulo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rol`
--

DROP TABLE IF EXISTS `rol`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `rol` (
  `id_rol` int NOT NULL AUTO_INCREMENT,
  `nombre_rol` varchar(50) COLLATE utf8mb4_spanish_ci NOT NULL,
  `descripcion_rol` varchar(255) COLLATE utf8mb4_spanish_ci DEFAULT NULL,
  `estado_rol` varchar(20) COLLATE utf8mb4_spanish_ci NOT NULL DEFAULT 'Activo',
  PRIMARY KEY (`id_rol`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rol`
--

LOCK TABLES `rol` WRITE;
/*!40000 ALTER TABLE `rol` DISABLE KEYS */;
INSERT INTO `rol` VALUES (1,'Administrador','Acceso total al sistema','Activo'),(2,'Despachador','Gestiona pedidos y rutas','Activo'),(3,'Repartidor','Realiza entregas a clientes','Activo');
/*!40000 ALTER TABLE `rol` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ruta`
--

DROP TABLE IF EXISTS `ruta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ruta` (
  `id_ruta` int NOT NULL AUTO_INCREMENT,
  `id_bodega` int NOT NULL,
  `id_area` int NOT NULL,
  `id_tipo_ruta` int NOT NULL,
  `id_estado_ruta` int NOT NULL,
  `fecha_ruta` date DEFAULT NULL,
  `hora_inicio_ruta` time DEFAULT NULL,
  `hora_fin_ruta` time DEFAULT NULL,
  `distancia_km_ruta` decimal(10,2) DEFAULT NULL,
  `observaciones_ruta` varchar(255) COLLATE utf8mb4_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`id_ruta`),
  KEY `fk_ruta_bodega` (`id_bodega`),
  KEY `fk_ruta_area` (`id_area`),
  KEY `fk_ruta_tipo` (`id_tipo_ruta`),
  KEY `fk_ruta_estado` (`id_estado_ruta`),
  CONSTRAINT `fk_ruta_area` FOREIGN KEY (`id_area`) REFERENCES `area_cubierta` (`id_area`),
  CONSTRAINT `fk_ruta_bodega` FOREIGN KEY (`id_bodega`) REFERENCES `bodega` (`id_bodega`),
  CONSTRAINT `fk_ruta_estado` FOREIGN KEY (`id_estado_ruta`) REFERENCES `estado_ruta` (`id_estado_ruta`),
  CONSTRAINT `fk_ruta_tipo` FOREIGN KEY (`id_tipo_ruta`) REFERENCES `tipo_ruta` (`id_tipo_ruta`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ruta`
--

LOCK TABLES `ruta` WRITE;
/*!40000 ALTER TABLE `ruta` DISABLE KEYS */;
INSERT INTO `ruta` VALUES (1,1,1,1,1,'2026-08-03','08:00:00','12:00:00',15.50,'Ruta matutina zona 1'),(2,2,2,1,2,'2026-08-03','09:00:00','13:00:00',20.75,'Ruta zona 10'),(3,3,3,2,1,'2026-08-04','07:30:00','11:30:00',45.20,'Ruta rural Zacapa'),(4,1,1,1,3,'2026-08-01','08:00:00','12:00:00',15.50,'Ruta completada sin novedad'),(5,2,2,1,3,'2026-08-01','08:30:00','13:00:00',18.20,'Entregas realizadas correctamente'),(6,3,3,1,2,'2026-08-06','09:00:00',NULL,12.00,'Ruta en curso'),(7,4,4,4,1,'2026-08-07',NULL,NULL,20.00,'Ruta programada para manana'),(8,5,5,2,3,'2026-07-30','07:00:00','11:30:00',45.00,'Ruta rural completada'),(9,6,6,3,5,'2026-08-05','06:00:00',NULL,210.00,'Ruta pausada por clima'),(10,7,7,1,6,'2026-08-04','08:00:00',NULL,25.30,'Ruta con retraso por trafico'),(11,8,8,5,1,'2026-08-08',NULL,NULL,30.00,'Ruta nocturna planificada');
/*!40000 ALTER TABLE `ruta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sucursal`
--

DROP TABLE IF EXISTS `sucursal`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sucursal` (
  `id_sucursal` int NOT NULL AUTO_INCREMENT,
  `nombre_sucursal` varchar(100) COLLATE utf8mb4_spanish_ci NOT NULL,
  `id_direccion` int DEFAULT NULL,
  `telefono_sucursal` varchar(20) COLLATE utf8mb4_spanish_ci DEFAULT NULL,
  `correo_sucursal` varchar(100) COLLATE utf8mb4_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`id_sucursal`),
  KEY `fk_sucursal_direccion` (`id_direccion`),
  CONSTRAINT `fk_sucursal_direccion` FOREIGN KEY (`id_direccion`) REFERENCES `direccion` (`id_direccion`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sucursal`
--

LOCK TABLES `sucursal` WRITE;
/*!40000 ALTER TABLE `sucursal` DISABLE KEYS */;
INSERT INTO `sucursal` VALUES (1,'Sucursal Zona 1',1,'22001111','sucursalzona1@reparto.com'),(2,'Sucursal Zona 10',2,'22002222','sucursalzona10@reparto.com'),(3,'Sucursal Zacapa',3,'22003333','sucursalzacapa@reparto.com'),(4,'Sucursal Zona 1',1,'22001100','zona1@repartofast.com'),(5,'Sucursal Zona 10',2,'22002200','zona10@repartofast.com'),(6,'Sucursal Mixco',3,'22003300','mixco@repartofast.com'),(7,'Sucursal Villa Nueva',4,'22004400','villanueva@repartofast.com'),(8,'Sucursal Antigua',5,'22005500','antigua@repartofast.com'),(9,'Sucursal Quetzaltenango',6,'22006600','quetzaltenango@repartofast.com'),(10,'Sucursal Escuintla',7,'22007700','escuintla@repartofast.com'),(11,'Sucursal Chimaltenango',8,'22008800','chimaltenango@repartofast.com');
/*!40000 ALTER TABLE `sucursal` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo_empleado`
--

DROP TABLE IF EXISTS `tipo_empleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tipo_empleado` (
  `id_tipo_empleado` int NOT NULL AUTO_INCREMENT,
  `nombre_tipo_empleado` varchar(50) COLLATE utf8mb4_spanish_ci NOT NULL,
  `descripcion_tipo_empleado` varchar(255) COLLATE utf8mb4_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`id_tipo_empleado`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo_empleado`
--

LOCK TABLES `tipo_empleado` WRITE;
/*!40000 ALTER TABLE `tipo_empleado` DISABLE KEYS */;
INSERT INTO `tipo_empleado` VALUES (1,'Repartidor','Encargado de entregar paquetes'),(2,'Administrativo','Personal de oficina'),(3,'Supervisor','Supervisa operaciones de reparto'),(4,'Repartidor','Realiza entregas a domicilio'),(5,'Bodeguero','Maneja inventario en bodega'),(6,'Administrativo','Labores de oficina'),(7,'Supervisor','Supervisa personal operativo'),(8,'Conductor','Conduce vehiculos de reparto'),(9,'Auxiliar','Apoyo general en operaciones'),(10,'Gerente','Gerencia de area o sucursal'),(11,'Soporte','Soporte tecnico interno');
/*!40000 ALTER TABLE `tipo_empleado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo_ruta`
--

DROP TABLE IF EXISTS `tipo_ruta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tipo_ruta` (
  `id_tipo_ruta` int NOT NULL AUTO_INCREMENT,
  `nombre_tipo_ruta` varchar(50) COLLATE utf8mb4_spanish_ci NOT NULL,
  `descripcion_tipo_ruta` varchar(255) COLLATE utf8mb4_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`id_tipo_ruta`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo_ruta`
--

LOCK TABLES `tipo_ruta` WRITE;
/*!40000 ALTER TABLE `tipo_ruta` DISABLE KEYS */;
INSERT INTO `tipo_ruta` VALUES (1,'Urbana','Ruta dentro del área metropolitana'),(2,'Rural','Ruta hacia áreas rurales'),(3,'Express','Ruta de entrega prioritaria'),(4,'Urbana','Ruta dentro del area urbana'),(5,'Rural','Ruta hacia zonas rurales'),(6,'Interdepartamental','Ruta entre departamentos'),(7,'Express','Ruta de entrega rapida'),(8,'Nocturna','Ruta programada en horario nocturno'),(9,'Larga distancia','Ruta de trayecto extenso'),(10,'Zona restringida','Ruta con acceso limitado'),(11,'Especial','Ruta para casos especiales');
/*!40000 ALTER TABLE `tipo_ruta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo_vehiculo`
--

DROP TABLE IF EXISTS `tipo_vehiculo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tipo_vehiculo` (
  `id_tipo_vehiculo` int NOT NULL AUTO_INCREMENT,
  `nombre_tipo_vehiculo` varchar(50) COLLATE utf8mb4_spanish_ci NOT NULL,
  `descripcion_tipo_vehiculo` varchar(255) COLLATE utf8mb4_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`id_tipo_vehiculo`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo_vehiculo`
--

LOCK TABLES `tipo_vehiculo` WRITE;
/*!40000 ALTER TABLE `tipo_vehiculo` DISABLE KEYS */;
INSERT INTO `tipo_vehiculo` VALUES (1,'Motocicleta','Vehículo de dos ruedas para entregas rápidas'),(2,'Camioneta','Vehículo de carga mediana'),(3,'Camión','Vehículo de carga pesada'),(4,'Motocicleta','Vehiculo de dos ruedas para entregas rapidas'),(5,'Furgoneta','Vehiculo de carga mediana'),(6,'Camion pequeno','Camion de baja capacidad'),(7,'Camion mediano','Camion de capacidad media'),(8,'Camion grande','Camion de alta capacidad'),(9,'Pickup','Vehiculo pickup para carga ligera'),(10,'Panel','Vehiculo tipo panel cerrado'),(11,'Cabezal','Vehiculo articulado de gran capacidad');
/*!40000 ALTER TABLE `tipo_vehiculo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuario` (
  `id_usuario` int NOT NULL AUTO_INCREMENT,
  `id_empleado` int NOT NULL,
  `usuario_usuario` varchar(50) COLLATE utf8mb4_spanish_ci NOT NULL,
  `correo_usuario` varchar(100) COLLATE utf8mb4_spanish_ci DEFAULT NULL,
  `contrasena_usuario` varchar(255) COLLATE utf8mb4_spanish_ci NOT NULL,
  `ultimo_acceso_usuario` datetime DEFAULT NULL,
  `fecha_creacion_usuario` date DEFAULT NULL,
  `estado_usuario` varchar(20) COLLATE utf8mb4_spanish_ci DEFAULT NULL,
  `token_recuperacion_usuario` varchar(10) COLLATE utf8mb4_spanish_ci DEFAULT NULL,
  `fecha_expiracion_token_usuario` datetime DEFAULT NULL,
  PRIMARY KEY (`id_usuario`),
  UNIQUE KEY `uq_usuarios_empleado` (`id_empleado`),
  CONSTRAINT `fk_usuarios_empleado` FOREIGN KEY (`id_empleado`) REFERENCES `empleado` (`id_empleado`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (1,1,'jmartinez','jmartinez@reparto.com','$2y$10$hashpass1',NULL,'2020-01-15','Activo',NULL,NULL),(2,2,'atorres','atorres@reparto.com','$2y$10$hashpass2',NULL,'2019-03-10','Activo',NULL,NULL),(3,3,'psanchez','psanchez@reparto.com','$2y$10$hashpass3',NULL,'2021-06-01','Activo',NULL,NULL),(4,4,'isa123','vgomezc7@umg.edu.gt','1234','2026-08-06 17:56:32','2021-06-01','Activo',NULL,NULL),(5,5,'admin','norteksolutions.gt@gmail.com','$2a$11$8JgnGm66pNSd5w5zQ9M3f.ZU.7uWNPKrZlLUts06mCnpzf4kx5kLC','2026-08-06 18:35:54','2026-08-06','Activo',NULL,NULL),(6,6,'Csipac','sipac@gmail.com','$2a$11$IM5K/xsd3IlVjlrZKRg/4OGRnP1Ao1TeF4oa3EuWD/GTJ4w4q7WIO','2026-08-06 18:38:14','2026-08-06','Activo',NULL,NULL);
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario_rol`
--

DROP TABLE IF EXISTS `usuario_rol`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuario_rol` (
  `id_usuario` int NOT NULL,
  `id_rol` int NOT NULL,
  `fecha_asignacion_usuario_rol` date DEFAULT NULL,
  PRIMARY KEY (`id_usuario`,`id_rol`),
  KEY `fk_usuariorol_rol` (`id_rol`),
  CONSTRAINT `fk_usuariorol_rol` FOREIGN KEY (`id_rol`) REFERENCES `rol` (`id_rol`),
  CONSTRAINT `fk_usuariorol_usuario` FOREIGN KEY (`id_usuario`) REFERENCES `usuario` (`id_usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario_rol`
--

LOCK TABLES `usuario_rol` WRITE;
/*!40000 ALTER TABLE `usuario_rol` DISABLE KEYS */;
INSERT INTO `usuario_rol` VALUES (1,1,'2020-01-15'),(1,3,'2019-03-10'),(2,2,'2019-03-10'),(3,3,'2021-06-01'),(4,1,'2021-06-01'),(5,1,'2026-08-06'),(6,2,'2026-08-06'),(6,3,'2026-08-06');
/*!40000 ALTER TABLE `usuario_rol` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vehiculo`
--

DROP TABLE IF EXISTS `vehiculo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `vehiculo` (
  `id_vehiculo` int NOT NULL AUTO_INCREMENT,
  `placa_vehiculo` varchar(15) COLLATE utf8mb4_spanish_ci NOT NULL,
  `marca_vehiculo` varchar(50) COLLATE utf8mb4_spanish_ci DEFAULT NULL,
  `modelo_vehiculo` varchar(50) COLLATE utf8mb4_spanish_ci DEFAULT NULL,
  `anio_vehiculo` int DEFAULT NULL,
  `capacidad_peso_vehiculo` decimal(10,2) DEFAULT NULL,
  `id_tipo_vehiculo` int NOT NULL,
  `id_estado_vehiculo` int NOT NULL,
  PRIMARY KEY (`id_vehiculo`),
  KEY `fk_vehiculo_tipo` (`id_tipo_vehiculo`),
  KEY `fk_vehiculo_estado` (`id_estado_vehiculo`),
  CONSTRAINT `fk_vehiculo_estado` FOREIGN KEY (`id_estado_vehiculo`) REFERENCES `estado_vehiculo` (`id_estado_vehiculo`),
  CONSTRAINT `fk_vehiculo_tipo` FOREIGN KEY (`id_tipo_vehiculo`) REFERENCES `tipo_vehiculo` (`id_tipo_vehiculo`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vehiculo`
--

LOCK TABLES `vehiculo` WRITE;
/*!40000 ALTER TABLE `vehiculo` DISABLE KEYS */;
INSERT INTO `vehiculo` VALUES (1,'P123ABC','Yamaha','FZ 150',2022,50.00,1,1),(2,'P456DEF','Toyota','Hilux',2021,1200.00,2,1),(3,'P789GHI','Isuzu','NPR',2020,3500.00,3,1),(4,'P123ABC','Yamaha','FZ150',2022,20.00,1,1),(5,'P456BCD','Toyota','Hiace',2020,1500.00,2,1),(6,'P789CDE','Isuzu','NPR',2019,3500.00,3,2),(7,'P321DEF','Hino','300',2021,5000.00,4,1),(8,'P654EFG','Mercedes-Benz','Actros',2018,12000.00,5,3),(9,'P987FGH','Toyota','Hilux',2023,1000.00,6,1),(10,'P159GHI','Ford','Transit',2020,1800.00,7,5),(11,'P753HIJ','Freightliner','Cascadia',2017,20000.00,8,7);
/*!40000 ALTER TABLE `vehiculo` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-08-06 18:42:35
