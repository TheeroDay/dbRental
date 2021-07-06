-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Jul 06, 2021 at 04:39 AM
-- Server version: 5.7.24
-- PHP Version: 7.2.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbrental`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_admin`
--

CREATE TABLE `tbl_admin` (
  `id_admin` int(5) NOT NULL,
  `nama_admin` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `username_admin` varchar(10) NOT NULL,
  `password_admin` varchar(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_admin`
--

INSERT INTO `tbl_admin` (`id_admin`, `nama_admin`, `email`, `username_admin`, `password_admin`) VALUES
(1, 'Zerolian', 'zero.lian@gmail.com', 'zero0', 'zero1234');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_driver`
--

CREATE TABLE `tbl_driver` (
  `id_driver` int(5) NOT NULL,
  `nama_driver` varchar(50) NOT NULL,
  `alamat_driver` varchar(225) NOT NULL,
  `no_telp` varchar(255) DEFAULT NULL,
  `status` enum('Aktif','Tidak Aktif') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_driver`
--

INSERT INTO `tbl_driver` (`id_driver`, `nama_driver`, `alamat_driver`, `no_telp`, `status`) VALUES
(0, '-', '-', NULL, 'Aktif'),
(1, 'Terry', 'Sleman, Yogyakarta', '08123456789', 'Aktif'),
(4, 'Whili', 'Denpasar Bali', '08123525355', 'Aktif'),
(5, 'Ferro', 'Jakarta', '08366372643', 'Aktif');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_jenismobil`
--

CREATE TABLE `tbl_jenismobil` (
  `kd_jenismobil` int(3) NOT NULL,
  `kd_mobil` int(3) NOT NULL,
  `seri_mobil` varchar(20) NOT NULL,
  `tahun_keluaran` varchar(5) NOT NULL,
  `harga` varchar(10) DEFAULT NULL,
  `nopol` varchar(10) NOT NULL,
  `status` enum('Aktif','Tidak Aktif') NOT NULL,
  `kepasitas_penumpang` int(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_jenismobil`
--

INSERT INTO `tbl_jenismobil` (`kd_jenismobil`, `kd_mobil`, `seri_mobil`, `tahun_keluaran`, `harga`, `nopol`, `status`, `kepasitas_penumpang`) VALUES
(1, 1, '7882428U9w7950', '2011', '20000', 'B 3674 S', 'Aktif', 6),
(2, 4, '2389g2bjh23', '2016', '400000', 'B 8343 SQ', 'Aktif', 8),
(3, 3, 'i3007923h7687', '2018', '500000', 'B 9221 AS', 'Aktif', 8),
(4, 4, '89234yigq9837', '2017', '500000', 'B 7733 Q', 'Aktif', 8);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_mobil`
--

CREATE TABLE `tbl_mobil` (
  `kd_mobil` int(3) NOT NULL,
  `merk` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_mobil`
--

INSERT INTO `tbl_mobil` (`kd_mobil`, `merk`) VALUES
(1, 'Avanza'),
(2, 'Terrios'),
(3, 'Pajero Sport'),
(4, 'Fortuner');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_transaksi`
--

CREATE TABLE `tbl_transaksi` (
  `id_transaksi` int(5) NOT NULL,
  `tgl_sewa` datetime DEFAULT NULL,
  `tgl_kembali` datetime DEFAULT NULL,
  `id_user` int(5) NOT NULL,
  `id_driver` int(5) DEFAULT NULL,
  `no_telp` varchar(255) DEFAULT NULL,
  `kd_jenismobil` int(3) NOT NULL,
  `lokasi` varchar(255) DEFAULT NULL,
  `hari` varchar(255) NOT NULL,
  `harga` varchar(255) NOT NULL,
  `total_harga` varchar(20) DEFAULT NULL,
  `Bayar` varchar(255) DEFAULT NULL,
  `Kembali` varchar(255) DEFAULT NULL,
  `tgl_Transaksi` date DEFAULT NULL,
  `status_pembayaran` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_transaksi`
--

INSERT INTO `tbl_transaksi` (`id_transaksi`, `tgl_sewa`, `tgl_kembali`, `id_user`, `id_driver`, `no_telp`, `kd_jenismobil`, `lokasi`, `hari`, `harga`, `total_harga`, `Bayar`, `Kembali`, `tgl_Transaksi`, `status_pembayaran`) VALUES
(6, '2021-06-26 00:00:00', '2021-06-30 00:00:00', 1, 1, '08123456789', 1, 'Bali', '4', '20000', '80000', '100000', '20000', '2021-08-14', 'Lunas'),
(39, '2021-06-26 00:00:00', '2021-06-30 00:00:00', 3, 1, '08123456789', 1, 'Bali', '4', '20000', '80000', '90000', '10000', '2021-07-06', 'Lunas'),
(40, '2021-06-26 00:00:00', '2021-06-30 00:00:00', 3, 0, '', 1, 'Jakarta', '4', '20000', '80000', NULL, NULL, '2021-07-06', 'Belum Lunas');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_user`
--

CREATE TABLE `tbl_user` (
  `id_user` int(5) NOT NULL,
  `nama_user` varchar(50) NOT NULL,
  `gender` enum('Laki-Laki','Perempuan') DEFAULT NULL,
  `alamat` varchar(225) DEFAULT NULL,
  `email` varchar(50) NOT NULL,
  `username_user` varchar(10) NOT NULL,
  `password_user` varchar(8) NOT NULL,
  `no_telp` varchar(13) NOT NULL,
  `no_ktp` varchar(20) NOT NULL,
  `foto_user` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_user`
--

INSERT INTO `tbl_user` (`id_user`, `nama_user`, `gender`, `alamat`, `email`, `username_user`, `password_user`, `no_telp`, `no_ktp`, `foto_user`) VALUES
(1, 'Zeroli', 'Laki-Laki', 'Sleman', 'zero0@zero.com', 'zero0zero', 'zero00', '0812345531', '7862387905230', ''),
(3, 'Helix', 'Laki-Laki', 'Jakarta', 'helix.0@gmail.com', 'helix00', 'helix00', '08123456789', '02346129641', 'C:;Users;88 komputer;Downloads;koas.jpg');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_admin`
--
ALTER TABLE `tbl_admin`
  ADD PRIMARY KEY (`id_admin`);

--
-- Indexes for table `tbl_driver`
--
ALTER TABLE `tbl_driver`
  ADD PRIMARY KEY (`id_driver`);

--
-- Indexes for table `tbl_jenismobil`
--
ALTER TABLE `tbl_jenismobil`
  ADD PRIMARY KEY (`kd_jenismobil`),
  ADD KEY `kd_mobil` (`kd_mobil`);

--
-- Indexes for table `tbl_mobil`
--
ALTER TABLE `tbl_mobil`
  ADD PRIMARY KEY (`kd_mobil`);

--
-- Indexes for table `tbl_transaksi`
--
ALTER TABLE `tbl_transaksi`
  ADD PRIMARY KEY (`id_transaksi`),
  ADD KEY `id_admin` (`id_user`,`id_driver`,`kd_jenismobil`),
  ADD KEY `kd_jenismobil` (`kd_jenismobil`),
  ADD KEY `id_driver` (`id_driver`);

--
-- Indexes for table `tbl_user`
--
ALTER TABLE `tbl_user`
  ADD PRIMARY KEY (`id_user`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_admin`
--
ALTER TABLE `tbl_admin`
  MODIFY `id_admin` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `tbl_driver`
--
ALTER TABLE `tbl_driver`
  MODIFY `id_driver` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `tbl_jenismobil`
--
ALTER TABLE `tbl_jenismobil`
  MODIFY `kd_jenismobil` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `tbl_mobil`
--
ALTER TABLE `tbl_mobil`
  MODIFY `kd_mobil` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `tbl_transaksi`
--
ALTER TABLE `tbl_transaksi`
  MODIFY `id_transaksi` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=41;

--
-- AUTO_INCREMENT for table `tbl_user`
--
ALTER TABLE `tbl_user`
  MODIFY `id_user` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbl_jenismobil`
--
ALTER TABLE `tbl_jenismobil`
  ADD CONSTRAINT `tbl_jenismobil_ibfk_1` FOREIGN KEY (`kd_mobil`) REFERENCES `tbl_mobil` (`kd_mobil`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Constraints for table `tbl_transaksi`
--
ALTER TABLE `tbl_transaksi`
  ADD CONSTRAINT `tbl_transaksi_ibfk_1` FOREIGN KEY (`id_user`) REFERENCES `tbl_user` (`id_user`) ON DELETE NO ACTION ON UPDATE CASCADE,
  ADD CONSTRAINT `tbl_transaksi_ibfk_4` FOREIGN KEY (`kd_jenismobil`) REFERENCES `tbl_jenismobil` (`kd_jenismobil`) ON DELETE NO ACTION ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
