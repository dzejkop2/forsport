-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Hostiteľ: 127.0.0.1
-- Čas generovania: Št 25.Máj 2023, 15:19
-- Verzia serveru: 10.4.25-MariaDB
-- Verzia PHP: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Databáza: `forsport_test`
--

-- --------------------------------------------------------

--
-- Štruktúra tabuľky pre tabuľku `forum`
--

CREATE TABLE `forum` (
  `username` varchar(50) NOT NULL,
  `comment` varchar(200) NOT NULL,
  `date` varchar(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Sťahujem dáta pre tabuľku `forum`
--

INSERT INTO `forum` (`username`, `comment`, `date`) VALUES
('admin', 'Pekne forum či jako?', '23. 5. 2023 ');

-- --------------------------------------------------------

--
-- Štruktúra tabuľky pre tabuľku `kurzy`
--

CREATE TABLE `kurzy` (
  `first_team` text NOT NULL,
  `second_team` text NOT NULL,
  `date` text NOT NULL,
  `kurz1` text NOT NULL,
  `kurz10` text NOT NULL,
  `kurz0` text NOT NULL,
  `kurz02` text NOT NULL,
  `kurz2` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Sťahujem dáta pre tabuľku `kurzy`
--

INSERT INTO `kurzy` (`first_team`, `second_team`, `date`, `kurz1`, `kurz10`, `kurz0`, `kurz02`, `kurz2`) VALUES
('amerika', 'nemecko', '15:00 15.5. 1944', '3.2', '1.5', '2.3', '4.5', '8.7'),
('taliansko', 'holandsko', 'vcera vecer', '5.1', '9.8', '11.5', '4.56', '11.2');

-- --------------------------------------------------------

--
-- Štruktúra tabuľky pre tabuľku `user_balance`
--

CREATE TABLE `user_balance` (
  `id` varchar(10) NOT NULL,
  `balance` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Sťahujem dáta pre tabuľku `user_balance`
--

INSERT INTO `user_balance` (`id`, `balance`) VALUES
('1111111111', 0);

-- --------------------------------------------------------

--
-- Štruktúra tabuľky pre tabuľku `user_info`
--

CREATE TABLE `user_info` (
  `id` varchar(10) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `mail` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Sťahujem dáta pre tabuľku `user_info`
--

INSERT INTO `user_info` (`id`, `username`, `password`, `mail`) VALUES
('1111111111', 'admin', 'admin123', '*');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
