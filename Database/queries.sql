-- MySQL Administrator dump 1.4
--
-- ------------------------------------------------------
-- Server version	5.0.11-beta-nt


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


--
-- Create schema consultas
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ consultas;
USE consultas;

--
-- Table structure for table `consultas`.`cuartospaciente`
--

DROP TABLE IF EXISTS `cuartospaciente`;
CREATE TABLE `cuartospaciente` (
  `idcuarto` varchar(45) NOT NULL,
  `descripcion` varchar(45) NOT NULL,
  `costo` int(10) unsigned NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `consultas`.`cuartospaciente`
--

/*!40000 ALTER TABLE `cuartospaciente` DISABLE KEYS */;
/*!40000 ALTER TABLE `cuartospaciente` ENABLE KEYS */;


--
-- Table structure for table `consultas`.`descripcionequipo`
--

DROP TABLE IF EXISTS `descripcionequipo`;
CREATE TABLE `descripcionequipo` (
  `idtipo` varchar(45) NOT NULL,
  `descripcion` varchar(45) NOT NULL,
  `cantidad` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `consultas`.`descripcionequipo`
--

/*!40000 ALTER TABLE `descripcionequipo` DISABLE KEYS */;
/*!40000 ALTER TABLE `descripcionequipo` ENABLE KEYS */;


--
-- Table structure for table `consultas`.`empleados`
--

DROP TABLE IF EXISTS `empleados`;
CREATE TABLE `empleados` (
  `cedula` varchar(45) NOT NULL,
  `primerapellido` varchar(45) NOT NULL,
  `segundoapellido` varchar(45) NOT NULL,
  `direccion` varchar(45) NOT NULL,
  `nombre` varchar(45) NOT NULL,
  `iddepartamento` varchar(45) NOT NULL,
  PRIMARY KEY  (`cedula`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `consultas`.`empleados`
--

/*!40000 ALTER TABLE `empleados` DISABLE KEYS */;
/*!40000 ALTER TABLE `empleados` ENABLE KEYS */;


--
-- Table structure for table `consultas`.`equipos`
--

DROP TABLE IF EXISTS `equipos`;
CREATE TABLE `equipos` (
  `idequipo` varchar(45) NOT NULL,
  `idtipo` varchar(45) NOT NULL,
  `estado` varchar(45) NOT NULL,
  `disponibilidad` varchar(45) NOT NULL,
  PRIMARY KEY  (`idequipo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `consultas`.`equipos`
--

/*!40000 ALTER TABLE `equipos` DISABLE KEYS */;
/*!40000 ALTER TABLE `equipos` ENABLE KEYS */;


--
-- Table structure for table `consultas`.`equiposxcuarto`
--

DROP TABLE IF EXISTS `equiposxcuarto`;
CREATE TABLE `equiposxcuarto` (
  `idcuarto` varchar(45) NOT NULL,
  `idequipo` varchar(45) NOT NULL,
  `fechadeentrega` varchar(45) NOT NULL,
  PRIMARY KEY  (`idcuarto`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `consultas`.`equiposxcuarto`
--

/*!40000 ALTER TABLE `equiposxcuarto` DISABLE KEYS */;
/*!40000 ALTER TABLE `equiposxcuarto` ENABLE KEYS */;


--
-- Table structure for table `consultas`.`especialidad`
--

DROP TABLE IF EXISTS `especialidad`;
CREATE TABLE `especialidad` (
  `idespecialidad` varchar(45) NOT NULL,
  `nombre` varchar(45) NOT NULL,
  `descripcion` varchar(45) NOT NULL,
  `saldo` varchar(45) NOT NULL,
  PRIMARY KEY  (`idespecialidad`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `consultas`.`especialidad`
--

/*!40000 ALTER TABLE `especialidad` DISABLE KEYS */;
/*!40000 ALTER TABLE `especialidad` ENABLE KEYS */;


--
-- Table structure for table `consultas`.`especialidadxempleado`
--

DROP TABLE IF EXISTS `especialidadxempleado`;
CREATE TABLE `especialidadxempleado` (
  `cedula` varchar(45) NOT NULL,
  `idespecialidad` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `consultas`.`especialidadxempleado`
--

/*!40000 ALTER TABLE `especialidadxempleado` DISABLE KEYS */;
/*!40000 ALTER TABLE `especialidadxempleado` ENABLE KEYS */;


--
-- Table structure for table `consultas`.`examendetalle`
--

DROP TABLE IF EXISTS `examendetalle`;
CREATE TABLE `examendetalle` (
  `idexamen` varchar(50) NOT NULL,
  `idtipo` varchar(45) NOT NULL,
  PRIMARY KEY  (`idexamen`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `consultas`.`examendetalle`
--

/*!40000 ALTER TABLE `examendetalle` DISABLE KEYS */;
/*!40000 ALTER TABLE `examendetalle` ENABLE KEYS */;


--
-- Table structure for table `consultas`.`examenp`
--

DROP TABLE IF EXISTS `examenp`;
CREATE TABLE `examenp` (
  `idexamen` varchar(45) NOT NULL,
  `idpaciente` varchar(45) NOT NULL,
  `estado` varchar(45) NOT NULL,
  `idtipopaciente` varchar(45) NOT NULL,
  `fechaexamen` varchar(45) NOT NULL,
  `fecharesultado` varchar(45) NOT NULL,
  PRIMARY KEY  (`idexamen`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `consultas`.`examenp`
--

/*!40000 ALTER TABLE `examenp` DISABLE KEYS */;
INSERT INTO `examenp` (`idexamen`,`idpaciente`,`estado`,`idtipopaciente`,`fechaexamen`,`fecharesultado`) VALUES 
 ('21','11','estable','31','10/11/2005','15/11/2005'),
 ('22','12','estable','32','10/11/2005','15/11/2005');
/*!40000 ALTER TABLE `examenp` ENABLE KEYS */;


--
-- Table structure for table `consultas`.`pacientes`
--

DROP TABLE IF EXISTS `pacientes`;
CREATE TABLE `pacientes` (
  `idpaciente` varchar(45) NOT NULL,
  `nombre` varchar(45) NOT NULL,
  `primerapellido` varchar(45) NOT NULL,
  `domicilio` varchar(45) NOT NULL,
  `sexo` varchar(45) NOT NULL,
  `telefono` varchar(45) NOT NULL,
  `fechanacimiento` varchar(45) NOT NULL,
  `segundoApellido` varchar(45) NOT NULL,
  PRIMARY KEY  (`idpaciente`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `consultas`.`pacientes`
--

/*!40000 ALTER TABLE `pacientes` DISABLE KEYS */;
INSERT INTO `pacientes` (`idpaciente`,`nombre`,`primerapellido`,`domicilio`,`sexo`,`telefono`,`fechanacimiento`,`segundoApellido`) VALUES 
 ('11','Maria','brenes','coto','cartago','f','5589542',''),
 ('12','carlos','aguilar','villalobos','heredia','m','8865421','');
/*!40000 ALTER TABLE `pacientes` ENABLE KEYS */;


--
-- Table structure for table `consultas`.`recetas`
--

DROP TABLE IF EXISTS `recetas`;
CREATE TABLE `recetas` (
  `idpaciente` varchar(45) NOT NULL,
  `idtiporeceta` varchar(45) NOT NULL,
  `tipo` varchar(45) NOT NULL,
  `estado` varchar(45) NOT NULL,
  PRIMARY KEY  (`idtiporeceta`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `consultas`.`recetas`
--

/*!40000 ALTER TABLE `recetas` DISABLE KEYS */;
/*!40000 ALTER TABLE `recetas` ENABLE KEYS */;


--
-- Table structure for table `consultas`.`recetasdetalle`
--

DROP TABLE IF EXISTS `recetasdetalle`;
CREATE TABLE `recetasdetalle` (
  `idreceta` varchar(45) NOT NULL,
  `idmedicamento` varchar(45) NOT NULL,
  `cantidad` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `consultas`.`recetasdetalle`
--

/*!40000 ALTER TABLE `recetasdetalle` DISABLE KEYS */;
/*!40000 ALTER TABLE `recetasdetalle` ENABLE KEYS */;


--
-- Table structure for table `consultas`.`tiposexamen`
--

DROP TABLE IF EXISTS `tiposexamen`;
CREATE TABLE `tiposexamen` (
  `idtipoexamen` varchar(45) NOT NULL default '',
  `valor` varchar(45) NOT NULL,
  `descripcion` varchar(45) NOT NULL,
  PRIMARY KEY  (`idtipoexamen`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `consultas`.`tiposexamen`
--

/*!40000 ALTER TABLE `tiposexamen` DISABLE KEYS */;
INSERT INTO `tiposexamen` (`idtipoexamen`,`valor`,`descripcion`) VALUES 
 ('21','10000','cardiologia'),
 ('22','15000','rayosx');
/*!40000 ALTER TABLE `tiposexamen` ENABLE KEYS */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
