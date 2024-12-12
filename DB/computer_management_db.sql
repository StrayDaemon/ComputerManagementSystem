-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 12, 2024 at 01:44 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `computer_management_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `computers`
--

CREATE TABLE `computers` (
  `id` int(11) NOT NULL,
  `computer_name` varchar(255) NOT NULL,
  `status` enum('Online','Offline') NOT NULL DEFAULT 'Offline',
  `processor` varchar(255) NOT NULL,
  `ram` varchar(50) NOT NULL,
  `storage` varchar(50) NOT NULL,
  `graphics_card` varchar(255) DEFAULT NULL,
  `operating_system` varchar(255) NOT NULL,
  `last_updated` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `computers`
--

INSERT INTO `computers` (`id`, `computer_name`, `status`, `processor`, `ram`, `storage`, `graphics_card`, `operating_system`, `last_updated`) VALUES
(12, 'Workstation A', 'Online', 'Intel Core i5-10400', '16GB', '256GB SSD', 'Intel UHD Graphics 630', 'Windows 10 Pro', '2024-12-11 15:49:15'),
(13, 'Workstation B', 'Offline', 'AMD Ryzen 5 3600', '8GB', '512GB SSD', 'NVIDIA GTX 1650', 'Windows 11 Pro', '2024-12-11 15:49:15'),
(14, 'Workstation C', 'Online', 'Intel Core i7-10700K', '32GB', '1TB SSD', 'NVIDIA RTX 3060', 'Ubuntu 22.04', '2024-12-11 15:49:15'),
(15, 'Workstation D', 'Online', 'AMD Ryzen 7 5800X', '16GB', '1TB HDD + 256GB SSD', 'NVIDIA RTX 3070', 'Windows 11 Home', '2024-12-11 15:49:15'),
(16, 'Workstation E', 'Offline', 'Intel Core i9-9900K', '32GB', '2TB SSD', 'NVIDIA RTX 2080 Ti', 'macOS Monterey', '2024-12-11 15:49:15'),
(17, 'Server X', 'Online', 'Intel Xeon E-2286M', '64GB', '4TB HDD', NULL, 'Windows Server 2019', '2024-12-11 15:49:15'),
(18, 'Server Y', 'Offline', 'AMD EPYC 7401P', '128GB', '8TB HDD', NULL, 'CentOS 8', '2024-12-11 15:49:15'),
(19, 'Workstation F', 'Online', 'Intel Core i5-11400', '16GB', '512GB SSD', 'Intel UHD Graphics 750', 'Windows 10 Home', '2024-12-11 15:49:15'),
(20, 'Workstation G', 'Offline', 'AMD Ryzen 3 3200G', '8GB', '1TB HDD', 'Radeon Vega 8', 'Windows 10 Pro', '2024-12-11 15:49:15'),
(21, 'Server Z', 'Online', 'Intel Xeon Gold 6230', '256GB', '16TB SSD', NULL, 'Ubuntu 20.04', '2024-12-11 15:49:15');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(255) NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `username`, `password`, `created_at`) VALUES
(1, '123', '$2a$11$xa52vDscgNnJF6lPsPQE4uKAXlceZUpQ8l7PH1frdZuU2gWEZPgAy', '2024-12-08 12:40:59'),
(2, 'test', '$2a$11$AKJY9WrGlmRa5Lw5AQ3zaufD1fOS5.eQyH2vKN.9dMoHOSKMxGjRC', '2024-12-10 13:57:08'),
(4, 'hello', '$2a$11$4XQiUOfSSRnIakiHvfhBB.OTiRkC0Fu/zOv.ZOnmcaBWlLs5rgHhG', '2024-12-11 08:40:37'),
(5, 'second', '$2a$11$twjbnUiv6Irb6BWap0TCEuGd2/koyzh/YucvTwsSmB7eUKUTPilPC', '2024-12-11 08:48:30'),
(6, 'yawa', '$2a$11$oo0uZP2VNEtIRxsnvWQd0u0rWG.Q5hmhIcArnzJ31qed.l68JqG2a', '2024-12-12 08:35:25'),
(7, 'Admin', '$2a$11$IrdbNDksjbT2cedA2360au7anLLyqLMt4PADZMHxTuSTTuHDqpe/2', '2024-12-12 09:23:20');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `computers`
--
ALTER TABLE `computers`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `username` (`username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `computers`
--
ALTER TABLE `computers`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
