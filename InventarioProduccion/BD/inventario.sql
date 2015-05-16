-- phpMyAdmin SQL Dump
-- version 4.0.4.1
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 02-12-2013 a las 19:53:23
-- Versión del servidor: 5.5.32
-- Versión de PHP: 5.4.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de datos: `inventario`
--
CREATE DATABASE IF NOT EXISTS `inventario` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `inventario`;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empleados`
--

CREATE TABLE IF NOT EXISTS `empleados` (
  `nombre` varchar(30) NOT NULL,
  `app` varchar(30) NOT NULL,
  `apm` varchar(30) NOT NULL,
  `domicilio` varchar(20) NOT NULL,
  `colonia` varchar(20) NOT NULL,
  `cp` int(10) NOT NULL,
  `fecha_nac` varchar(20) NOT NULL,
  `estado` varchar(20) NOT NULL,
  `nacionalidad` varchar(20) NOT NULL,
  `municipio` varchar(20) NOT NULL,
  `sexo` varchar(20) NOT NULL,
  `estado_civil` varchar(20) NOT NULL,
  `fecha_ingre` varchar(20) NOT NULL,
  `telefono` int(15) NOT NULL,
  `cel` int(15) NOT NULL,
  `puesto` varchar(30) NOT NULL,
  `nss` int(15) NOT NULL,
  `id` int(20) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Volcado de datos para la tabla `empleados`
--

INSERT INTO `empleados` (`nombre`, `app`, `apm`, `domicilio`, `colonia`, `cp`, `fecha_nac`, `estado`, `nacionalidad`, `municipio`, `sexo`, `estado_civil`, `fecha_ingre`, `telefono`, `cel`, `puesto`, `nss`, `id`) VALUES
('jonathan', 'Ramirez', 'Partida', 'jdof', 'kkdjsfk', 21323, '', '', '', '', '', '', '', 213, 4345345, '', 213, 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `login`
--

CREATE TABLE IF NOT EXISTS `login` (
  `username` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL,
  `id` int(20) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Volcado de datos para la tabla `login`
--

INSERT INTO `login` (`username`, `password`, `id`) VALUES
('jonathan', '123', 1),
('udg', '100', 2),
('Pedro', '23', 3),
('mini', 'teamo', 4);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `registro`
--

CREATE TABLE IF NOT EXISTS `registro` (
  `id_usuario` int(20) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(40) DEFAULT NULL,
  `apellidos` varchar(40) NOT NULL,
  `empresa` varchar(40) NOT NULL,
  `domicilio` varchar(30) NOT NULL,
  `correo` varchar(30) NOT NULL,
  `localidad` varchar(30) NOT NULL,
  `telefono` int(20) NOT NULL,
  `celular` int(20) NOT NULL,
  `cp` int(10) NOT NULL,
  PRIMARY KEY (`id_usuario`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Volcado de datos para la tabla `registro`
--

INSERT INTO `registro` (`id_usuario`, `nombre`, `apellidos`, `empresa`, `domicilio`, `correo`, `localidad`, `telefono`, `celular`, `cp`) VALUES
(1, 'JONATHAN', 'ETWET', 'ETWET', 'TRYTY', 'jrp_salch', 'oifjdif', 34345345, 443223435, 3333);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `reporte`
--

CREATE TABLE IF NOT EXISTS `reporte` (
  `medida` varchar(20) NOT NULL,
  `color` varchar(20) NOT NULL,
  `calibre` int(10) NOT NULL,
  `cantidad` float NOT NULL,
  `n_operador` varchar(20) NOT NULL,
  `turno` varchar(20) NOT NULL,
  `tipo` varchar(20) NOT NULL,
  `id` int(15) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Volcado de datos para la tabla `reporte`
--

INSERT INTO `reporte` (`medida`, `color`, `calibre`, `cantidad`, `n_operador`, `turno`, `tipo`, `id`) VALUES
('60x90', 'negra', 200, 150, 'jona', 'Matutino', 'Bolsa Plana', 3),
('60x90', 'negra', 150, 562, 'joan', 'Matutino', 'Bolsa Plana', 5);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
