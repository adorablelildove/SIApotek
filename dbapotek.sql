-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 10, 2021 at 05:35 AM
-- Server version: 10.4.11-MariaDB
-- PHP Version: 7.4.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbapotek`
--

-- --------------------------------------------------------

--
-- Table structure for table `tb_obat`
--

CREATE TABLE `tb_obat` (
  `IdObat` int(11) NOT NULL,
  `NamaObat` varchar(50) NOT NULL,
  `HBeli` int(12) NOT NULL,
  `HJual` int(12) NOT NULL,
  `Jumlah` int(11) NOT NULL,
  `TglExp` varchar(50) NOT NULL,
  `Perusahaan` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tb_obat`
--

INSERT INTO `tb_obat` (`IdObat`, `NamaObat`, `HBeli`, `HJual`, `Jumlah`, `TglExp`, `Perusahaan`) VALUES
(1, 'Paracetamol', 20000, 25000, 11, '26 May 2022', 'PT Bio Farma'),
(2, 'Bodrexin', 10000, 15000, 0, '29 May 2022', 'PT Balatif'),
(3, 'OBH', 21000, 26000, 3, '26 May 2022', 'PT Bio Farma'),
(4, 'Enervon-C', 50000, 55000, 9, '29 May 2022', 'PT Afiat');

-- --------------------------------------------------------

--
-- Table structure for table `tb_pegawai`
--

CREATE TABLE `tb_pegawai` (
  `IdPegawai` int(11) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `Password` varchar(50) NOT NULL,
  `Nama` varchar(50) NOT NULL,
  `TglLahir` varchar(50) NOT NULL,
  `NoTelp` varchar(20) NOT NULL,
  `Alamat` text NOT NULL,
  `Gaji` int(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tb_pegawai`
--

INSERT INTO `tb_pegawai` (`IdPegawai`, `Username`, `Password`, `Nama`, `TglLahir`, `NoTelp`, `Alamat`, `Gaji`) VALUES
(5, 'helviani', 'admin', 'Helviani', '31 May 2000', '23421', 'Jambi', 3000000);

-- --------------------------------------------------------

--
-- Table structure for table `tb_supplier`
--

CREATE TABLE `tb_supplier` (
  `IdSupplier` int(11) NOT NULL,
  `Nama` varchar(50) NOT NULL,
  `NoTelp` varchar(20) NOT NULL,
  `Fax` varchar(20) NOT NULL,
  `Alamat` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tb_supplier`
--

INSERT INTO `tb_supplier` (`IdSupplier`, `Nama`, `NoTelp`, `Fax`, `Alamat`) VALUES
(4, 'PT Afifarma', '01234', '01234', 'Jambi'),
(5, 'PT Afiat', '23421', '234123', 'Jakarta'),
(6, 'PT Balatif', '34242', '23432', 'Bengkulu'),
(7, 'PT Bernofarma', '314324', '2342243', 'Palembang'),
(8, 'PT Bio Farma', '32544', '56464', 'Surabaya'),
(9, 'PT Kimia Farma', '33242', '7695865', 'Bali');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tb_obat`
--
ALTER TABLE `tb_obat`
  ADD PRIMARY KEY (`IdObat`);

--
-- Indexes for table `tb_pegawai`
--
ALTER TABLE `tb_pegawai`
  ADD PRIMARY KEY (`IdPegawai`),
  ADD UNIQUE KEY `Username` (`Username`);

--
-- Indexes for table `tb_supplier`
--
ALTER TABLE `tb_supplier`
  ADD PRIMARY KEY (`IdSupplier`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tb_obat`
--
ALTER TABLE `tb_obat`
  MODIFY `IdObat` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT for table `tb_pegawai`
--
ALTER TABLE `tb_pegawai`
  MODIFY `IdPegawai` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `tb_supplier`
--
ALTER TABLE `tb_supplier`
  MODIFY `IdSupplier` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
