/*
SQLyog Community v13.1.5  (64 bit)
MySQL - 10.4.11-MariaDB : Database - finanmotors
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`finanmotors` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;

USE `finanmotors`;

/*Table structure for table `anio` */

DROP TABLE IF EXISTS `anio`;

CREATE TABLE `anio` (
  `ID_ANIO` int(5) NOT NULL AUTO_INCREMENT,
  `ANIO` varchar(4) NOT NULL,
  PRIMARY KEY (`ID_ANIO`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4;

/*Data for the table `anio` */

insert  into `anio`(`ID_ANIO`,`ANIO`) values 
(1,'2019'),
(2,'2020');

/*Table structure for table `clientes` */

DROP TABLE IF EXISTS `clientes`;

CREATE TABLE `clientes` (
  `ID` int(5) NOT NULL AUTO_INCREMENT,
  `DNI` varchar(8) NOT NULL,
  `RUC` varchar(11) DEFAULT NULL,
  `NOMBRE_RAZON_SOCIAL` varchar(100) NOT NULL,
  `DIRECCION` varchar(80) NOT NULL,
  `TELEFONO` varchar(9) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8mb4;

/*Data for the table `clientes` */

insert  into `clientes`(`ID`,`DNI`,`RUC`,`NOMBRE_RAZON_SOCIAL`,`DIRECCION`,`TELEFONO`) values 
(19,'46813718','10468137181','VASQUEZ RIVERO JOSE MANUEL',' - - ','949165677');

/*Table structure for table `color` */

DROP TABLE IF EXISTS `color`;

CREATE TABLE `color` (
  `ID` int(5) NOT NULL AUTO_INCREMENT,
  `COLOR` varchar(10) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4;

/*Data for the table `color` */

insert  into `color`(`ID`,`COLOR`) values 
(0,'Selecciona'),
(1,'ROJO PLATA'),
(2,'AZUL PLATA'),
(3,'AZUL'),
(4,'ROJO'),
(5,'NEGRO'),
(6,'PLATA'),
(7,'BLANCO');

/*Table structure for table `marca` */

DROP TABLE IF EXISTS `marca`;

CREATE TABLE `marca` (
  `ID` int(2) NOT NULL AUTO_INCREMENT,
  `MARCA` varchar(10) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4;

/*Data for the table `marca` */

insert  into `marca`(`ID`,`MARCA`) values 
(1,'Honda'),
(2,'Motokar');

/*Table structure for table `modelos` */

DROP TABLE IF EXISTS `modelos`;

CREATE TABLE `modelos` (
  `ID` int(5) NOT NULL AUTO_INCREMENT,
  `MODELO` varchar(20) NOT NULL,
  `MARCA` int(1) NOT NULL,
  `TIPO` int(1) NOT NULL,
  `PRECIO_COSTO` varchar(10) NOT NULL,
  `PRECIO_VENTA` varchar(10) NOT NULL,
  `PROMOCION_1` int(5) NOT NULL,
  `PROMOCION_2` int(5) NOT NULL,
  `PROMOCION_3` int(5) NOT NULL,
  `PROMOCION_4` int(5) NOT NULL,
  `PROMOCION_5` int(5) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK_TIPO` (`TIPO`),
  KEY `FK_MARCA` (`MARCA`),
  CONSTRAINT `FK_MARCA` FOREIGN KEY (`MARCA`) REFERENCES `marca` (`ID`),
  CONSTRAINT `FK_TIPO` FOREIGN KEY (`TIPO`) REFERENCES `tipos` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4;

/*Data for the table `modelos` */

insert  into `modelos`(`ID`,`MODELO`,`MARCA`,`TIPO`,`PRECIO_COSTO`,`PRECIO_VENTA`,`PROMOCION_1`,`PROMOCION_2`,`PROMOCION_3`,`PROMOCION_4`,`PROMOCION_5`) values 
(0,'',1,1,'','',0,0,0,0,0),
(1,'CCG125',2,1,'','1.799,00',1,3,5,6,7),
(2,'GL150',2,1,'','2.109,00',0,0,0,0,0),
(3,'CB125F TWISTER',1,1,'','1.519,00\r\n',0,0,0,0,0),
(4,'ELITE',1,1,'','2.109,00\r\n',0,0,0,0,0),
(5,'XR150L',1,1,'','2.529,00\r\n',0,0,0,0,0),
(6,'WAVE110S Cast Disk',1,1,'','1.499,00',0,0,0,0,0),
(7,'CB190R',1,1,'','2.669,00',0,0,0,0,0),
(8,'GL 125',1,1,'','1.499,00\r\n',0,0,0,0,0),
(9,'XR190L',1,1,'','',0,0,0,0,0),
(10,'CB300R',1,1,'','',0,0,0,0,0),
(11,'CB500X',1,1,'','',0,0,0,0,0),
(12,'CB1000RL',1,1,'','',0,0,0,0,0),
(13,'CBR300R',1,1,'','',0,0,0,0,0),
(14,'NC750X',1,1,'','',0,0,0,0,0);

/*Table structure for table `orden_pedido` */

DROP TABLE IF EXISTS `orden_pedido`;

CREATE TABLE `orden_pedido` (
  `ID` int(5) NOT NULL AUTO_INCREMENT,
  `N_OP` varchar(10) NOT NULL,
  `CLIENTE` int(1) NOT NULL,
  `TIENDA` int(1) NOT NULL,
  `VENDEDOR` int(1) NOT NULL,
  `CONDICION_PAGO` varchar(10) NOT NULL,
  `TIPO_CAMBIO` varchar(4) NOT NULL,
  `FECHA` date NOT NULL,
  `MODELO_MOTO` int(1) NOT NULL,
  `PRECIO_LISTA` int(1) NOT NULL,
  `DSC_TIENDA` varchar(5) NOT NULL,
  `SOBREPRECIO` varchar(5) NOT NULL,
  `PRECIO_FINAL` varchar(10) NOT NULL,
  `TIPO_MOTO` int(1) NOT NULL,
  `COLOR` int(1) NOT NULL,
  `PROMOCIONAL_1` int(1) DEFAULT NULL,
  `PROMOCIONAL_2` int(1) DEFAULT NULL,
  `PROMOCIONAL_3` int(1) DEFAULT NULL,
  `PROMOCIONAL_4` int(1) DEFAULT NULL,
  `PROMOCIONAL_5` int(1) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK_PROMOCIONAL_1` (`PROMOCIONAL_1`),
  KEY `FK_PROMOCIONAL_2` (`PROMOCIONAL_2`),
  KEY `FK_PROMOCIONAL_3` (`PROMOCIONAL_3`),
  KEY `FK_PROMOCIONAL_4` (`PROMOCIONAL_4`),
  KEY `FK_PROMOCIONAL_5` (`PROMOCIONAL_5`),
  KEY `FK_CLIENTE` (`CLIENTE`),
  KEY `FK_TIENDA_OP` (`TIENDA`),
  KEY `FK_VENDEDOR_OP` (`VENDEDOR`),
  KEY `FK_MODELO` (`MODELO_MOTO`),
  CONSTRAINT `FK_CLIENTE` FOREIGN KEY (`CLIENTE`) REFERENCES `clientes` (`ID`),
  CONSTRAINT `FK_MODELO` FOREIGN KEY (`MODELO_MOTO`) REFERENCES `modelos` (`ID`),
  CONSTRAINT `FK_PROMOCIONAL_1` FOREIGN KEY (`PROMOCIONAL_1`) REFERENCES `promocionales` (`ID`),
  CONSTRAINT `FK_PROMOCIONAL_2` FOREIGN KEY (`PROMOCIONAL_2`) REFERENCES `promocionales` (`ID`),
  CONSTRAINT `FK_PROMOCIONAL_3` FOREIGN KEY (`PROMOCIONAL_3`) REFERENCES `promocionales` (`ID`),
  CONSTRAINT `FK_PROMOCIONAL_4` FOREIGN KEY (`PROMOCIONAL_4`) REFERENCES `promocionales` (`ID`),
  CONSTRAINT `FK_PROMOCIONAL_5` FOREIGN KEY (`PROMOCIONAL_5`) REFERENCES `promocionales` (`ID`),
  CONSTRAINT `FK_TIENDA_OP` FOREIGN KEY (`TIENDA`) REFERENCES `tienda` (`ID`),
  CONSTRAINT `FK_VENDEDOR_OP` FOREIGN KEY (`VENDEDOR`) REFERENCES `vendedor` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4;

/*Data for the table `orden_pedido` */

/*Table structure for table `proformas` */

DROP TABLE IF EXISTS `proformas`;

CREATE TABLE `proformas` (
  `ID` int(5) NOT NULL AUTO_INCREMENT,
  `N_PROFORMA` varchar(10) NOT NULL,
  `TIENDA` int(5) NOT NULL,
  `CLIENTE` int(5) NOT NULL,
  `MODELO_MOTO` int(5) NOT NULL,
  `COLOR` int(5) NOT NULL,
  `TARJETA` int(5) NOT NULL DEFAULT 0,
  `PLACA` int(5) NOT NULL DEFAULT 0,
  `VENDEDOR` int(5) NOT NULL,
  `FECHA` datetime NOT NULL,
  `CONDICION_PAGO` varchar(7) NOT NULL,
  `TC` varchar(5) NOT NULL,
  `INICIAL` varchar(10) NOT NULL,
  `P_MENSUAL` varchar(10) NOT NULL,
  `N_CUOTAS` varchar(10) NOT NULL,
  `COSTO_TOTAL` varchar(10) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK_MODELO_P` (`MODELO_MOTO`),
  KEY `FK_COLOR_P` (`COLOR`),
  KEY `FK_VEDEDOR_P` (`VENDEDOR`),
  KEY `FK_CLIENTE_P` (`CLIENTE`),
  KEY `FK_TARJETA_P` (`TARJETA`),
  KEY `FK_PLACA_P` (`PLACA`),
  CONSTRAINT `FK_CLIENTE_P` FOREIGN KEY (`CLIENTE`) REFERENCES `clientes` (`ID`),
  CONSTRAINT `FK_COLOR_P` FOREIGN KEY (`COLOR`) REFERENCES `color` (`ID`),
  CONSTRAINT `FK_MODELO_P` FOREIGN KEY (`MODELO_MOTO`) REFERENCES `modelos` (`ID`),
  CONSTRAINT `FK_PLACA_P` FOREIGN KEY (`PLACA`) REFERENCES `servicios` (`ID`),
  CONSTRAINT `FK_TARJETA_P` FOREIGN KEY (`TARJETA`) REFERENCES `servicios` (`ID`),
  CONSTRAINT `FK_VEDEDOR_P` FOREIGN KEY (`VENDEDOR`) REFERENCES `vendedor` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=41 DEFAULT CHARSET=utf8mb4;

/*Data for the table `proformas` */

insert  into `proformas`(`ID`,`N_PROFORMA`,`TIENDA`,`CLIENTE`,`MODELO_MOTO`,`COLOR`,`TARJETA`,`PLACA`,`VENDEDOR`,`FECHA`,`CONDICION_PAGO`,`TC`,`INICIAL`,`P_MENSUAL`,`N_CUOTAS`,`COSTO_TOTAL`) values 
(36,'002-0',1,19,2,3,3,0,1,'2020-03-29 06:43:31','CONTADO','3.43','0','0','0','2.149,00'),
(37,'002-1',1,19,1,3,3,1,1,'2020-03-29 22:48:21','CREDITO','3.43','400','450','12','1.864,00'),
(38,'002-2',1,19,1,3,3,1,1,'2020-03-29 22:48:21','CREDITO','3.43','400','450','12','1.864,00'),
(39,'002-3',1,19,4,3,3,1,1,'2020-03-29 22:48:21','CREDITO','3.43','400','450','12','2.109,00\r\n'),
(40,'002-4',1,19,3,3,3,1,1,'2020-03-30 00:46:37','CREDITO','3.43','0','0','0','1.584,00');

/*Table structure for table `promocionales` */

DROP TABLE IF EXISTS `promocionales`;

CREATE TABLE `promocionales` (
  `ID` int(5) NOT NULL AUTO_INCREMENT,
  `NOMBRE_PRODUCTO` varchar(40) NOT NULL,
  `COSTO_V_PRODUCTO` varchar(10) NOT NULL,
  `ACTIVO` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4;

/*Data for the table `promocionales` */

insert  into `promocionales`(`ID`,`NOMBRE_PRODUCTO`,`COSTO_V_PRODUCTO`,`ACTIVO`) values 
(1,'Tapalluvias (1 und)','5,14',1),
(2,'Tarjeta','36,82',1),
(3,'Placa','36,82',1),
(4,'Casco Promocional (1 und)','7,64',1),
(5,'Aceite Motokar (2 und)','6,8',1),
(6,'Polo Merch (1 und)','4,41',1),
(7,'Gorra Merch (1 und)','4,41',1),
(8,'Aceite Motocicleta (2 und)','6,8',1),
(9,'Mochila Roja FM','6,70',0),
(10,'Mochila Negra FM','6,70',0),
(11,'Mochila Honda Racing','9,17',0);

/*Table structure for table `servicios` */

DROP TABLE IF EXISTS `servicios`;

CREATE TABLE `servicios` (
  `ID` int(5) NOT NULL AUTO_INCREMENT,
  `NOMBRE_SERVICIO` varchar(100) NOT NULL,
  `COSTO` varchar(10) NOT NULL,
  `TIENDA` int(1) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK_TIENDA_S` (`TIENDA`),
  CONSTRAINT `FK_TIENDA_S` FOREIGN KEY (`TIENDA`) REFERENCES `tienda` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4;

/*Data for the table `servicios` */

insert  into `servicios`(`ID`,`NOMBRE_SERVICIO`,`COSTO`,`TIENDA`) values 
(0,'','',0),
(1,'PLACA_JAEN','25,00',1),
(2,'PLACA_TARAPOTO','30,00',2),
(3,'TARJETA_JAEN','40,00',1),
(4,'TARJETA_TARAPOTO','40,00',2);

/*Table structure for table `tienda` */

DROP TABLE IF EXISTS `tienda`;

CREATE TABLE `tienda` (
  `ID` int(5) NOT NULL AUTO_INCREMENT,
  `TIENDA` varchar(15) NOT NULL,
  `DIRECCION_TIENDA` varchar(50) NOT NULL,
  `SERIE` varchar(3) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4;

/*Data for the table `tienda` */

insert  into `tienda`(`ID`,`TIENDA`,`DIRECCION_TIENDA`,`SERIE`) values 
(0,'Seleccionar','','000'),
(1,'JAEN','123','002'),
(2,'BAGUA GRANDE','1234','003'),
(3,'PUCALLPA','','004'),
(4,'TARAPOTO','','005');

/*Table structure for table `tipos` */

DROP TABLE IF EXISTS `tipos`;

CREATE TABLE `tipos` (
  `ID` int(5) NOT NULL AUTO_INCREMENT,
  `NOMBRE_TIPO` varchar(20) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4;

/*Data for the table `tipos` */

insert  into `tipos`(`ID`,`NOMBRE_TIPO`) values 
(1,'TODO TERRENO'),
(2,'CIUDAD');

/*Table structure for table `user_login` */

DROP TABLE IF EXISTS `user_login`;

CREATE TABLE `user_login` (
  `user_id` int(11) NOT NULL AUTO_INCREMENT,
  `user_name` varchar(20) NOT NULL,
  `user_password` varchar(100) NOT NULL,
  `user_email` varchar(50) NOT NULL,
  `tienda` int(1) NOT NULL,
  PRIMARY KEY (`user_id`),
  UNIQUE KEY `user_name` (`user_name`),
  UNIQUE KEY `user_email` (`user_email`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4;

/*Data for the table `user_login` */

insert  into `user_login`(`user_id`,`user_name`,`user_password`,`user_email`,`tienda`) values 
(1,'finanmotors','ICJg7rWANsXaXGwbQogZkQ==','asdas@asd.com',1),
(2,'jose','ICJg7rWANsXaXGwbQogZkQ==','asdas@assd.com',2);

/*Table structure for table `vendedor` */

DROP TABLE IF EXISTS `vendedor`;

CREATE TABLE `vendedor` (
  `ID` int(5) NOT NULL AUTO_INCREMENT,
  `NOMBRE_VENDEDOR` varchar(50) NOT NULL,
  `DNI_VENDEDOR` varchar(50) NOT NULL,
  `TIENDA` int(1) NOT NULL,
  `FIRMA` longblob NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK_TIENDA` (`TIENDA`),
  CONSTRAINT `FK_TIENDA` FOREIGN KEY (`TIENDA`) REFERENCES `tienda` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4;

/*Data for the table `vendedor` */

insert  into `vendedor`(`ID`,`NOMBRE_VENDEDOR`,`DNI_VENDEDOR`,`TIENDA`,`FIRMA`) values 
(1,'VENDEDOR 1','970756102',1,''),
(2,'VENDEDOR 2','88888888',2,'');

/*Table structure for table `ventas` */

DROP TABLE IF EXISTS `ventas`;

CREATE TABLE `ventas` (
  `ID` int(5) NOT NULL,
  `NUMERO` varchar(4) DEFAULT NULL,
  `SEDE` varchar(15) DEFAULT NULL,
  `DOCUMENTO_DE_VENTA` varchar(15) DEFAULT NULL,
  `FECHA_DE_VENTA` date DEFAULT NULL,
  `SOCIO` varchar(70) DEFAULT NULL,
  `PVP` varchar(10) DEFAULT NULL,
  `TIPO` varchar(6) DEFAULT NULL,
  `INICIAL` varchar(10) DEFAULT NULL,
  `CODIGO_OPERACION_1` varchar(7) DEFAULT NULL,
  `MAF` varchar(10) DEFAULT NULL,
  `CODIGO_OPERACION_2` varchar(7) DEFAULT NULL,
  `TOTAL_OPERACION` varchar(10) DEFAULT NULL,
  `VENDEDOR` varchar(70) DEFAULT NULL,
  `COMISION` varchar(6) DEFAULT NULL,
  `PORCENTAJE` varchar(4) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `ventas` */

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
