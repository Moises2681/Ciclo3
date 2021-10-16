CREATE TABLE `usuario` (
    `usu_id` INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
    `usu_cedula` VARCHAR(10),
    `usu_nombre` VARCHAR(20),
    `usu_apellidos` VARCHAR(20),
    `usu_direccion` VARCHAR(50),
    `usu_telefono` VARCHAR(20),
    `usu_correo` VARCHAR(50)
)  ENGINE=INNODB;

CREATE TABLE `alquiler` (
  `alq_id` int PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `alq_usuario` int,
  `alq_disponible` int,
  `alq_vehiculo` int,
  `alq_codigo` varchar(10),
  `alq_fecha_inicio` varchar(10),
  `alq_fecha_fin` varchar(10),
  `alq_lugar_entrega` varchar(20),
  `alq_lugar_recogida` varchar(20),
  `alq_estadoRecepcionVehiculo` int,
  `alq_forPago` int
)ENGINE=InnoDB;

CREATE TABLE `estadoAlquiler` (
  `estAlq_id` int PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `estAlq_estado` varchar(20)
)ENGINE=InnoDB;

CREATE TABLE `vehiculo` (
  `veh_id` int PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `veh_placa` varchar(20),
  `veh_marca` int,
  `veh_modelo` varchar(20),
  `veh_capacidad` varchar(20),
  `veh_color` varchar(20),
  `veh_tipoCaja` int,
  `veh_tipoCombustible` int,
  `veh_hojaVida` int
)ENGINE=InnoDB;

CREATE TABLE `marca` (
  `mar_id` int PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `mar_marca` varchar(20)
)ENGINE=InnoDB;

CREATE TABLE `tipoCaja` (
  `tipCaj_id` int PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `tipCaj_marca` varchar(20)
)ENGINE=InnoDB;

CREATE TABLE `tipoCombustible` (
  `tipCom_id` int PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `tipCom_combustible` varchar(20)
)ENGINE=InnoDB;

CREATE TABLE `hojaVida` (
  `hojVid_id` int PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `hojVid_nombre` varchar(20),
  `hojVid_fechaTecno` date,
  `hojVid_fechaSoat` date
)ENGINE=InnoDB;

CREATE TABLE `estadoEntrega` (
  `estEnt_id` int PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `estEnt_estadoEntrega` varchar(20)
)ENGINE=InnoDB;

CREATE TABLE `formaPago` (
  `forPag_id` int PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `forPag_nombre` varchar(20)
)ENGINE=InnoDB;

ALTER TABLE `alquiler` ADD FOREIGN KEY (`alq_usuario`) REFERENCES `usuario` (`usu_id`);

ALTER TABLE `alquiler` ADD FOREIGN KEY (`alq_disponible`) REFERENCES `estadoAlquiler` (`estAlq_id`);

ALTER TABLE `alquiler` ADD FOREIGN KEY (`alq_vehiculo`) REFERENCES `vehiculo` (`veh_id`);

ALTER TABLE `vehiculo` ADD FOREIGN KEY (`veh_marca`) REFERENCES `marca` (`mar_id`);

ALTER TABLE `vehiculo` ADD FOREIGN KEY (`veh_tipoCaja`) REFERENCES `tipoCaja` (`tipCaj_id`);

ALTER TABLE `vehiculo` ADD FOREIGN KEY (`veh_tipoCombustible`) REFERENCES `tipoCombustible` (`tipCom_id`);

ALTER TABLE `alquiler` ADD FOREIGN KEY (`alq_estadoRecepcionVehiculo`) REFERENCES `estadoEntrega` (`estEnt_id`);

ALTER TABLE `alquiler` ADD FOREIGN KEY (`alq_forPago`) REFERENCES `formaPago` (`forPag_id`);

ALTER TABLE `vehiculo` ADD FOREIGN KEY (`veh_hojaVida`) REFERENCES `hojaVida` (`hojVid_id`);