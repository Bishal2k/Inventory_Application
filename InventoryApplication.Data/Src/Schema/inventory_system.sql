-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 13, 2022 at 05:51 PM
-- Server version: 10.4.22-MariaDB
-- PHP Version: 8.0.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `inventory_system`
--

-- --------------------------------------------------------

--
-- Table structure for table `account`
--

CREATE TABLE `account` (
  `id` bigint(20) NOT NULL,
  `profile_id` bigint(20) NOT NULL,
  `amount_payable` decimal(10,0) NOT NULL DEFAULT 0,
  `amount_receiveable` decimal(11,0) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `account`
--

INSERT INTO `account` (`id`, `profile_id`, `amount_payable`, `amount_receiveable`) VALUES
(3, 3, '0', '0'),
(4, 4, '100000', '0'),
(5, 5, '0', '20800'),
(6, 6, '0', '2100');

-- --------------------------------------------------------

--
-- Table structure for table `bill`
--

CREATE TABLE `bill` (
  `id` bigint(20) NOT NULL,
  `profile_id` bigint(20) NOT NULL,
  `bill_date` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  `bill_timestamp` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `bill`
--

INSERT INTO `bill` (`id`, `profile_id`, `bill_date`, `bill_timestamp`) VALUES
(5, 5, '2022-07-09', '2022-07-09 05:53:16'),
(6, 5, '2022-07-09', '2022-07-09 05:56:51'),
(7, 6, '2022-07-10', '2022-07-10 05:12:54');

-- --------------------------------------------------------

--
-- Table structure for table `bill_items`
--

CREATE TABLE `bill_items` (
  `id` bigint(20) NOT NULL,
  `bill_id` bigint(20) NOT NULL,
  `product_id` bigint(20) NOT NULL,
  `quantity` int(11) NOT NULL,
  `rate` decimal(10,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `bill_items`
--

INSERT INTO `bill_items` (`id`, `bill_id`, `product_id`, `quantity`, `rate`) VALUES
(1, 5, 3, 8, '1300'),
(2, 6, 3, 8, '1300'),
(3, 7, 4, 10, '2100'),
(4, 7, 3, 1, '1100');

-- --------------------------------------------------------

--
-- Table structure for table `payment`
--

CREATE TABLE `payment` (
  `id` bigint(20) NOT NULL,
  `account_id` bigint(20) NOT NULL,
  `amount` decimal(10,0) NOT NULL,
  `payment_description` varchar(1000) COLLATE utf8mb4_unicode_ci NOT NULL,
  `payment_date` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  `payment_type` varchar(25) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `payment`
--

INSERT INTO `payment` (`id`, `account_id`, `amount`, `payment_description`, `payment_date`, `payment_type`) VALUES
(2, 4, '10000', 'ten thousand', '2022-07-10', 'PaymentTypePayed'),
(3, 6, '20000', 'twenty thousand', '2022-07-10', 'PaymentTypeReceived');

-- --------------------------------------------------------

--
-- Table structure for table `product`
--

CREATE TABLE `product` (
  `id` bigint(20) NOT NULL,
  `name` varchar(200) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `quantity` int(11) NOT NULL,
  `Weight` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `product`
--

INSERT INTO `product` (`id`, `name`, `quantity`, `Weight`) VALUES
(3, 'Product 1', 3, 25),
(4, 'Product 2', 40, 50);

-- --------------------------------------------------------

--
-- Table structure for table `product_entry`
--

CREATE TABLE `product_entry` (
  `id` bigint(20) NOT NULL,
  `profile_id` bigint(20) NOT NULL,
  `product_id` bigint(20) NOT NULL,
  `quantity` int(11) NOT NULL,
  `rate` decimal(10,0) NOT NULL,
  `bill_no` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  `entry_date` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  `vechile_no` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `product_entry`
--

INSERT INTO `product_entry` (`id`, `profile_id`, `product_id`, `quantity`, `rate`, `bill_no`, `entry_date`, `vechile_no`) VALUES
(1, 4, 3, 20, '1200', '1', '2022-07-09', '1023'),
(2, 4, 4, 50, '2000', '2', '2022-07-10', '1098');

-- --------------------------------------------------------

--
-- Table structure for table `profile`
--

CREATE TABLE `profile` (
  `id` bigint(20) NOT NULL,
  `name` varchar(200) COLLATE utf8mb4_unicode_ci NOT NULL,
  `contact` varchar(10) COLLATE utf8mb4_unicode_ci NOT NULL,
  `address` varchar(200) COLLATE utf8mb4_unicode_ci NOT NULL,
  `company_name` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `profile`
--

INSERT INTO `profile` (`id`, `name`, `contact`, `address`, `company_name`) VALUES
(3, 'Vendor 1', '9815989112', 'Jhapa', 'Vendor One Suppliers'),
(4, 'Vendor 2', '981581877', 'Haldibari', 'Vendor Two Suppliers'),
(5, 'Customer 1', '0987879665', 'Damak', 'CustomerOne Store'),
(6, 'Customer 2', '0985674321', 'Dhulabari', 'Customer2 traders');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `id` bigint(20) NOT NULL,
  `username` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`id`, `username`, `password`) VALUES
(1, 'bishal', 'bishal');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `account`
--
ALTER TABLE `account`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `uniqueProfileId` (`profile_id`);

--
-- Indexes for table `bill`
--
ALTER TABLE `bill`
  ADD PRIMARY KEY (`id`),
  ADD KEY `FK_Bill_Profile` (`profile_id`);

--
-- Indexes for table `bill_items`
--
ALTER TABLE `bill_items`
  ADD PRIMARY KEY (`id`),
  ADD KEY `FK_BillId_Item` (`bill_id`),
  ADD KEY `FK_BillItem_Product` (`product_id`);

--
-- Indexes for table `payment`
--
ALTER TABLE `payment`
  ADD PRIMARY KEY (`id`),
  ADD KEY `FK_Account_Payment` (`account_id`);

--
-- Indexes for table `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `product_entry`
--
ALTER TABLE `product_entry`
  ADD PRIMARY KEY (`id`),
  ADD KEY `FK_PE_ProfileId` (`profile_id`),
  ADD KEY `FK_PE_ProductId` (`product_id`);

--
-- Indexes for table `profile`
--
ALTER TABLE `profile`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `panUnique` (`company_name`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `account`
--
ALTER TABLE `account`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `bill`
--
ALTER TABLE `bill`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `bill_items`
--
ALTER TABLE `bill_items`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `payment`
--
ALTER TABLE `payment`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `product`
--
ALTER TABLE `product`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `product_entry`
--
ALTER TABLE `product_entry`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `profile`
--
ALTER TABLE `profile`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `account`
--
ALTER TABLE `account`
  ADD CONSTRAINT `FK_Account_Profile` FOREIGN KEY (`profile_id`) REFERENCES `profile` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `bill`
--
ALTER TABLE `bill`
  ADD CONSTRAINT `FK_Bill_Profile` FOREIGN KEY (`profile_id`) REFERENCES `profile` (`id`);

--
-- Constraints for table `bill_items`
--
ALTER TABLE `bill_items`
  ADD CONSTRAINT `FK_BillId_Item` FOREIGN KEY (`bill_id`) REFERENCES `bill` (`id`),
  ADD CONSTRAINT `FK_BillItem_Product` FOREIGN KEY (`product_id`) REFERENCES `product` (`id`);

--
-- Constraints for table `payment`
--
ALTER TABLE `payment`
  ADD CONSTRAINT `FK_Account_Payment` FOREIGN KEY (`account_id`) REFERENCES `account` (`id`);

--
-- Constraints for table `product_entry`
--
ALTER TABLE `product_entry`
  ADD CONSTRAINT `FK_PE_ProductId` FOREIGN KEY (`product_id`) REFERENCES `product` (`id`),
  ADD CONSTRAINT `FK_PE_ProfileId` FOREIGN KEY (`profile_id`) REFERENCES `profile` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
