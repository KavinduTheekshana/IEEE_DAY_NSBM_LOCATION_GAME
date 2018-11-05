-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 22, 2018 at 07:58 AM
-- Server version: 10.1.26-MariaDB
-- PHP Version: 7.1.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ieeedaynsbm`
--

-- --------------------------------------------------------

--
-- Table structure for table `check64bit`
--

CREATE TABLE `check64bit` (
  `id` int(11) NOT NULL,
  `bitvalue` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `check64bit`
--

INSERT INTO `check64bit` (`id`, `bitvalue`) VALUES
(1, 'TW9uZXkgbWF5IG5vdCBidXkgaGFwcGluZXNzLCBidXQgaXQgY2FuIGRhbW4gd2VsbCBnaXZlIGl0'),
(2, 'S25vd2luZyBpcyBub3QgZW5vdWdoLCB3ZSBtdXN0IGFwcGx5LiBXaWxsaW5nIGlzIG5vdCBlbm91Z2gsIHdlIG11c3QgZG8u'),
(3, 'QSBkcmVhbSB5b3UgZHJlYW0gYWxvbmUgaXMgb25seSBhIGRyZWFtLiBBIGRyZWFtIHlvdSBkcmVhbSB0b2dldGhlciBpcyByZWFsaXR5Lg==');

-- --------------------------------------------------------

--
-- Table structure for table `details`
--

CREATE TABLE `details` (
  `ID` int(11) NOT NULL,
  `num1` int(3) NOT NULL,
  `num2` int(3) NOT NULL,
  `num3` int(3) NOT NULL,
  `num4` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `details`
--

INSERT INTO `details` (`ID`, `num1`, `num2`, `num3`, `num4`) VALUES
(1, 46, 431, 6, 909),
(2, 22, 296, 114, 175),
(3, 53, 406, -2, 988),
(4, 1, 1, 1, 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `check64bit`
--
ALTER TABLE `check64bit`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `details`
--
ALTER TABLE `details`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `check64bit`
--
ALTER TABLE `check64bit`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `details`
--
ALTER TABLE `details`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
