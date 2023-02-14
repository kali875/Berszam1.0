-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 14, 2023 at 04:06 PM
-- Server version: 10.4.25-MariaDB
-- PHP Version: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `calculating_salary`
--

-- --------------------------------------------------------

--
-- Table structure for table `allowances_table`
--

CREATE TABLE `allowances_table` (
  `ID` int(255) NOT NULL,
  `Allowances_ID` int(255) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `Criteria` int(255) NOT NULL,
  `Value` int(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `children_table`
--

CREATE TABLE `children_table` (
  `Customer_ID` int(255) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `Date_of_Birth` date NOT NULL,
  `Own` tinyint(1) DEFAULT NULL,
  `Rest_in_Peace` date DEFAULT NULL,
  `DurableSick` tinyint(1) NOT NULL,
  `School` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `children_table`
--

INSERT INTO `children_table` (`Customer_ID`, `Name`, `Date_of_Birth`, `Own`, `Rest_in_Peace`, `DurableSick`, `School`) VALUES
(5, 'Kokolino Janka', '2022-10-08', NULL, NULL, 0, 0),
(5, 'Kokolino András', '2019-05-12', NULL, NULL, 0, 0),
(4, 'Konye Dániel', '2022-03-20', NULL, NULL, 0, 0),
(4, 'Konye Tamás', '2018-03-20', NULL, NULL, 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `customers_legal_table`
--

CREATE TABLE `customers_legal_table` (
  `ID` int(255) NOT NULL,
  `Legal_ID` int(255) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `Criteria` varchar(255) NOT NULL,
  `Value` int(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `customers_table`
--

CREATE TABLE `customers_table` (
  `ID` int(255) NOT NULL,
  `CardWork_ID` int(255) NOT NULL,
  `FirstName` varchar(255) NOT NULL,
  `LastName` varchar(255) NOT NULL,
  `Identity_Number` varchar(255) NOT NULL,
  `Mother_Name` varchar(255) NOT NULL,
  `Date_of_Birth` date NOT NULL,
  `Place_of_Birth` varchar(255) NOT NULL,
  `Residence_City` varchar(255) NOT NULL,
  `Residence_Street` varchar(255) NOT NULL,
  `Residence_Housenumber` varchar(255) NOT NULL,
  `Residence_City_number` varchar(255) NOT NULL,
  `Distance` int(255) NOT NULL,
  `Wage_form_ID` int(255) NOT NULL,
  `TAJ_Number` int(255) NOT NULL,
  `Tax_Number` int(255) NOT NULL,
  `Educational_Attainment_ID` int(255) NOT NULL,
  `Holiday_Count` int(255) NOT NULL,
  `Single_Status` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `customers_table`
--

INSERT INTO `customers_table` (`ID`, `CardWork_ID`, `FirstName`, `LastName`, `Identity_Number`, `Mother_Name`, `Date_of_Birth`, `Place_of_Birth`, `Residence_City`, `Residence_Street`, `Residence_Housenumber`, `Residence_City_number`, `Distance`, `Wage_form_ID`, `TAJ_Number`, `Tax_Number`, `Educational_Attainment_ID`, `Holiday_Count`, `Single_Status`) VALUES
(1, 1001, 'Test', 'Bela', '241234JE', 'Test Irén', '1962-02-21', 'Budapest', 'Hatvan', 'Szabadság u.', '12', '2356', 30, 3, 112456012, 2147483647, 0, 15, 0),
(2, 1002, 'Bakancs', 'Jeno', '251639JE', 'Janka Magdolna', '1962-01-20', 'Székesfehérvár', 'Hatvan', 'Petőfi u.', '2', '2236', 30, 4, 122556032, 2147483647, 0, 20, 0),
(3, 1003, 'Munka', 'András', '261334JE', 'Szabad ildikó', '1960-08-24', 'Győr', 'Szentmiklós', 'Béke u.', '67', '5366', 20, 4, 143454062, 2147483647, 0, 25, 0),
(4, 1004, 'Konye', 'Maria', '248233JE', 'Tima Ildiko', '1987-06-06', 'Veszprém', 'Kavolyvölcs', 'Vörös u.', '12/2', '1955', 35, 5, 212436042, 2147483647, 0, 19, 0),
(5, 1005, 'kokolino', 'Megara', '259234JE', 'Say Sára', '1990-10-13', 'Komárom', 'Mesteri', 'Garaván u.', '78', '3735', 12, 6, 452436042, 2147483647, 0, 21, 0);

-- --------------------------------------------------------

--
-- Table structure for table `education_attainment_table`
--

CREATE TABLE `education_attainment_table` (
  `ID` int(255) NOT NULL,
  `Customers_ID` int(255) NOT NULL,
  `Name` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `education_attainment_table`
--

INSERT INTO `education_attainment_table` (`ID`, `Customers_ID`, `Name`) VALUES
(1, 2, 'Szakmunkás'),
(2, 1, 'Szakközép'),
(3, 3, 'Szakkmunkás'),
(4, 4, '8-általános'),
(5, 5, 'Bsc');

-- --------------------------------------------------------

--
-- Table structure for table `holiday_table`
--

CREATE TABLE `holiday_table` (
  `Customer_ID` int(255) NOT NULL,
  `Start_Holiday` date NOT NULL,
  `End_Holiday` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `holiday_table`
--

INSERT INTO `holiday_table` (`Customer_ID`, `Start_Holiday`, `End_Holiday`) VALUES
(5, '2022-09-06', '2022-09-13'),
(4, '2022-07-10', '2022-07-14');

-- --------------------------------------------------------

--
-- Table structure for table `married_table`
--

CREATE TABLE `married_table` (
  `Customer_ID` int(255) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `Start_Maried_Date` date NOT NULL,
  `End_Maried_Date` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `married_table`
--

INSERT INTO `married_table` (`Customer_ID`, `Name`, `Start_Maried_Date`, `End_Maried_Date`) VALUES
(5, 'koklino András', '2022-10-04', NULL),
(4, 'Konye Péter', '2022-08-09', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `schedules_table`
--

CREATE TABLE `schedules_table` (
  `ID` int(255) NOT NULL,
  `Customer_ID` int(255) NOT NULL,
  `Schedules_WorkTime` int(255) NOT NULL,
  `StartDate` date NOT NULL,
  `EndDate` date NOT NULL,
  `Salary` int(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `schedules_table`
--

INSERT INTO `schedules_table` (`ID`, `Customer_ID`, `Schedules_WorkTime`, `StartDate`, `EndDate`, `Salary`) VALUES
(1, 2, 8, '2016-12-05', '2030-11-13', 250000),
(2, 5, 4, '2022-01-02', '2030-11-13', 2000),
(3, 4, 12, '2015-07-06', '2030-11-13', 20000),
(4, 3, 6, '2020-10-13', '2031-11-18', 220000),
(5, 1, 8, '2018-11-13', '2030-11-13', 300000);

-- --------------------------------------------------------

--
-- Table structure for table `sick_table`
--

CREATE TABLE `sick_table` (
  `Customer_ID` int(255) DEFAULT NULL,
  `Start_Sick` date NOT NULL,
  `End_Sick` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `sick_table`
--

INSERT INTO `sick_table` (`Customer_ID`, `Start_Sick`, `End_Sick`) VALUES
(2, '2022-06-13', '2022-06-17'),
(4, '2022-09-12', '2022-09-16');

-- --------------------------------------------------------

--
-- Table structure for table `wage_from_table`
--

CREATE TABLE `wage_from_table` (
  `Wage_ID` int(255) NOT NULL,
  `Name` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `wage_from_table`
--

INSERT INTO `wage_from_table` (`Wage_ID`, `Name`) VALUES
(3, 'fixbér'),
(4, 'havibér'),
(5, 'Órabér'),
(6, 'Teljesitménybér');

-- --------------------------------------------------------

--
-- Table structure for table `working_time_table`
--

CREATE TABLE `working_time_table` (
  `CardWork_ID` int(255) NOT NULL,
  `Start_Work` datetime NOT NULL,
  `End_Work` datetime NOT NULL,
  `ID` int(255) NOT NULL,
  `Count` int(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `working_time_table`
--

INSERT INTO `working_time_table` (`CardWork_ID`, `Start_Work`, `End_Work`, `ID`, `Count`) VALUES
(1001, '2022-09-01 08:00:00', '2022-09-01 16:00:00', 445, 0),
(1001, '2022-09-02 08:00:00', '2022-09-02 16:00:00', 446, 0),
(1001, '2022-09-05 08:00:00', '2022-09-05 16:00:00', 447, 0),
(1001, '2022-09-06 08:00:00', '2022-09-06 16:00:00', 448, 0),
(1001, '2022-09-07 08:00:00', '2022-09-07 16:00:00', 449, 0),
(1001, '2022-09-08 08:00:00', '2022-09-08 16:00:00', 450, 0),
(1001, '2022-09-09 08:00:00', '2022-09-09 16:00:00', 451, 0),
(1001, '2022-09-12 08:00:00', '2022-09-12 16:00:00', 452, 0),
(1001, '2022-09-13 08:00:00', '2022-09-13 16:00:00', 453, 0),
(1001, '2022-09-14 08:00:00', '2022-09-14 16:00:00', 454, 0),
(1001, '2022-09-15 08:00:00', '2022-09-15 16:00:00', 455, 0),
(1001, '2022-09-16 08:00:00', '2022-09-16 16:00:00', 456, 0),
(1001, '2022-09-19 08:00:00', '2022-09-19 16:00:00', 457, 0),
(1001, '2022-09-20 08:00:00', '2022-09-20 16:00:00', 458, 0),
(1001, '2022-09-21 08:00:00', '2022-09-21 16:00:00', 459, 0),
(1001, '2022-09-22 08:00:00', '2022-09-22 16:00:00', 460, 0),
(1001, '2022-09-23 08:00:00', '2022-09-23 16:00:00', 461, 0),
(1001, '2022-09-26 08:00:00', '2022-09-26 16:00:00', 462, 0),
(1001, '2022-09-27 08:00:00', '2022-09-27 16:00:00', 463, 0),
(1001, '2022-09-28 08:00:00', '2022-09-28 16:00:00', 464, 0),
(1001, '2022-09-29 08:00:00', '2022-09-29 16:00:00', 465, 0),
(1001, '2022-09-30 08:00:00', '2022-09-30 16:00:00', 466, 0),
(1002, '2022-09-01 08:00:00', '2022-09-01 16:00:00', 467, 0),
(1002, '2022-09-02 08:00:00', '2022-09-02 16:00:00', 468, 0),
(1002, '2022-09-05 08:00:00', '2022-09-05 16:00:00', 469, 0),
(1002, '2022-09-06 08:00:00', '2022-09-06 16:00:00', 470, 0),
(1002, '2022-09-07 08:00:00', '2022-09-07 16:00:00', 471, 0),
(1002, '2022-09-08 08:00:00', '2022-09-08 16:00:00', 472, 0),
(1002, '2022-09-09 08:00:00', '2022-09-09 16:00:00', 473, 0),
(1002, '2022-09-12 08:00:00', '2022-09-12 16:00:00', 474, 0),
(1002, '2022-09-13 08:00:00', '2022-09-13 16:00:00', 475, 0),
(1002, '2022-09-14 08:00:00', '2022-09-14 16:00:00', 476, 0),
(1002, '2022-09-15 08:00:00', '2022-09-15 16:00:00', 477, 0),
(1002, '2022-09-16 08:00:00', '2022-09-16 16:00:00', 478, 0),
(1002, '2022-09-19 08:00:00', '2022-09-19 16:00:00', 479, 0),
(1002, '2022-09-20 08:00:00', '2022-09-20 16:00:00', 480, 0),
(1002, '2022-09-21 08:00:00', '2022-09-21 16:00:00', 481, 0),
(1002, '2022-09-22 08:00:00', '2022-09-22 16:00:00', 482, 0),
(1002, '2022-09-23 08:00:00', '2022-09-23 16:00:00', 483, 0),
(1002, '2022-09-26 08:00:00', '2022-09-26 16:00:00', 484, 0),
(1002, '2022-09-27 08:00:00', '2022-09-27 16:00:00', 485, 0),
(1002, '2022-09-28 08:00:00', '2022-09-28 16:00:00', 486, 0),
(1002, '2022-09-29 08:00:00', '2022-09-29 16:00:00', 487, 0),
(1002, '2022-09-30 08:00:00', '2022-09-30 16:00:00', 488, 0),
(1003, '2022-09-01 08:00:00', '2022-09-01 14:00:00', 489, 0),
(1003, '2022-09-02 08:00:00', '2022-09-02 14:00:00', 490, 0),
(1003, '2022-09-05 08:00:00', '2022-09-05 14:00:00', 491, 0),
(1003, '2022-09-06 08:00:00', '2022-09-06 14:00:00', 492, 0),
(1003, '2022-09-07 08:00:00', '2022-09-07 14:00:00', 493, 0),
(1003, '2022-09-08 08:00:00', '2022-09-08 14:00:00', 494, 0),
(1003, '2022-09-09 08:00:00', '2022-09-09 14:00:00', 495, 0),
(1003, '2022-09-12 08:00:00', '2022-09-12 14:00:00', 496, 0),
(1003, '2022-09-13 08:00:00', '2022-09-13 14:00:00', 497, 0),
(1003, '2022-09-14 08:00:00', '2022-09-14 14:00:00', 498, 0),
(1003, '2022-09-15 08:00:00', '2022-09-15 14:00:00', 499, 0),
(1003, '2022-09-16 08:00:00', '2022-09-16 14:00:00', 500, 0),
(1003, '2022-09-19 08:00:00', '2022-09-19 14:00:00', 501, 0),
(1003, '2022-09-20 08:00:00', '2022-09-20 14:00:00', 502, 0),
(1003, '2022-09-21 08:00:00', '2022-09-21 14:00:00', 503, 0),
(1003, '2022-09-22 08:00:00', '2022-09-22 14:00:00', 504, 0),
(1003, '2022-09-23 08:00:00', '2022-09-23 14:00:00', 505, 0),
(1003, '2022-09-26 10:00:00', '2022-09-26 16:00:00', 506, 0),
(1003, '2022-09-27 10:00:00', '2022-09-27 16:00:00', 507, 0),
(1003, '2022-09-28 10:00:00', '2022-09-28 16:00:00', 508, 0),
(1003, '2022-09-29 10:00:00', '2022-09-29 16:00:00', 509, 0),
(1003, '2022-09-30 10:00:00', '2022-09-30 16:00:00', 510, 0),
(1005, '2022-09-01 08:00:00', '2022-09-01 12:00:00', 511, 5),
(1005, '2022-09-02 08:00:00', '2022-09-02 12:00:00', 512, 3),
(1005, '2022-09-05 08:00:00', '2022-09-05 12:00:00', 513, 6),
(1005, '2022-09-06 08:00:00', '2022-09-06 12:00:00', 514, 4),
(1005, '2022-09-07 08:00:00', '2022-09-07 12:00:00', 515, 5),
(1005, '2022-09-08 08:00:00', '2022-09-08 12:00:00', 516, 2),
(1005, '2022-09-09 08:00:00', '2022-09-09 12:00:00', 517, 3),
(1005, '2022-09-12 10:00:00', '2022-09-12 14:00:00', 518, 5),
(1005, '2022-09-13 10:00:00', '2022-09-13 14:00:00', 519, 2),
(1005, '2022-09-14 10:00:00', '2022-09-14 14:00:00', 520, 3),
(1005, '2022-09-15 10:00:00', '2022-09-15 14:00:00', 521, 4),
(1005, '2022-09-16 10:00:00', '2022-09-16 14:00:00', 522, 5),
(1005, '2022-09-19 10:00:00', '2022-09-19 14:00:00', 523, 2),
(1005, '2022-09-20 10:00:00', '2022-09-20 14:00:00', 524, 2),
(1005, '2022-09-21 14:00:00', '2022-09-21 18:00:00', 525, 4),
(1005, '2022-09-22 14:00:00', '2022-09-22 18:00:00', 526, 1),
(1005, '2022-09-23 14:00:00', '2022-09-23 18:00:00', 527, 3),
(1005, '2022-09-26 14:00:00', '2022-09-26 18:00:00', 528, 2),
(1005, '2022-09-27 14:00:00', '2022-09-27 18:00:00', 529, 2),
(1005, '2022-09-28 14:00:00', '2022-09-28 18:00:00', 530, 4),
(1005, '2022-09-29 14:00:00', '2022-09-29 18:00:00', 531, 6),
(1005, '2022-09-30 14:00:00', '2022-09-30 18:00:00', 532, 3),
(1004, '2022-09-01 06:00:00', '2022-09-01 14:00:00', 533, 0),
(1004, '2022-09-02 06:00:00', '2022-09-02 14:00:00', 534, 0),
(1004, '2022-09-05 14:00:00', '2022-09-05 22:00:00', 535, 0),
(1004, '2022-09-06 14:00:00', '2022-09-06 22:00:00', 536, 0),
(1004, '2022-09-07 14:00:00', '2022-09-07 22:00:00', 537, 0),
(1004, '2022-09-08 14:00:00', '2022-09-08 22:00:00', 538, 0),
(1004, '2022-09-09 14:00:00', '2022-09-09 22:00:00', 539, 0),
(1004, '2022-09-12 22:00:00', '2022-09-13 06:00:00', 540, 0),
(1004, '2022-09-13 22:00:00', '2022-09-14 06:00:00', 541, 0),
(1004, '2022-09-14 22:00:00', '2022-09-15 06:00:00', 542, 0),
(1004, '2022-09-15 22:00:00', '2022-09-16 06:00:00', 543, 0),
(1004, '2022-09-16 22:00:00', '2022-09-17 06:00:00', 544, 0),
(1004, '2022-09-19 06:00:00', '2022-09-19 14:00:00', 545, 0),
(1004, '2022-09-20 06:00:00', '2022-09-20 14:00:00', 546, 0),
(1004, '2022-09-21 06:00:00', '2022-09-21 14:00:00', 547, 0),
(1004, '2022-09-22 06:00:00', '2022-09-22 14:00:00', 548, 0),
(1004, '2022-09-23 06:00:00', '2022-09-23 14:00:00', 549, 0),
(1004, '2022-09-26 14:00:00', '2022-09-26 22:00:00', 550, 0),
(1004, '2022-09-27 14:00:00', '2022-09-27 22:00:00', 551, 0),
(1004, '2022-09-28 14:00:00', '2022-09-28 22:00:00', 552, 0),
(1004, '2022-09-29 14:00:00', '2022-09-29 22:00:00', 553, 0),
(1004, '2022-09-30 14:00:00', '2022-09-30 22:00:00', 554, 0);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `allowances_table`
--
ALTER TABLE `allowances_table`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `children_table`
--
ALTER TABLE `children_table`
  ADD KEY `Customer_ID` (`Customer_ID`);

--
-- Indexes for table `customers_legal_table`
--
ALTER TABLE `customers_legal_table`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `customers_table`
--
ALTER TABLE `customers_table`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `CardWork` (`CardWork_ID`),
  ADD KEY `Wage_form_ID` (`Wage_form_ID`);

--
-- Indexes for table `education_attainment_table`
--
ALTER TABLE `education_attainment_table`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `Customers_ID` (`Customers_ID`);

--
-- Indexes for table `holiday_table`
--
ALTER TABLE `holiday_table`
  ADD KEY `Customers_ID` (`Customer_ID`);

--
-- Indexes for table `married_table`
--
ALTER TABLE `married_table`
  ADD KEY `Customer_ID` (`Customer_ID`);

--
-- Indexes for table `schedules_table`
--
ALTER TABLE `schedules_table`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `Customers_ID` (`Customer_ID`);

--
-- Indexes for table `sick_table`
--
ALTER TABLE `sick_table`
  ADD KEY `asdasd` (`Customer_ID`);

--
-- Indexes for table `wage_from_table`
--
ALTER TABLE `wage_from_table`
  ADD PRIMARY KEY (`Wage_ID`);

--
-- Indexes for table `working_time_table`
--
ALTER TABLE `working_time_table`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `Customers_ID` (`CardWork_ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `allowances_table`
--
ALTER TABLE `allowances_table`
  MODIFY `ID` int(255) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `customers_legal_table`
--
ALTER TABLE `customers_legal_table`
  MODIFY `ID` int(255) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `customers_table`
--
ALTER TABLE `customers_table`
  MODIFY `ID` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `education_attainment_table`
--
ALTER TABLE `education_attainment_table`
  MODIFY `ID` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `schedules_table`
--
ALTER TABLE `schedules_table`
  MODIFY `ID` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `wage_from_table`
--
ALTER TABLE `wage_from_table`
  MODIFY `Wage_ID` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `working_time_table`
--
ALTER TABLE `working_time_table`
  MODIFY `ID` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=555;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `children_table`
--
ALTER TABLE `children_table`
  ADD CONSTRAINT `children_table_ibfk_1` FOREIGN KEY (`Customer_ID`) REFERENCES `customers_table` (`ID`);

--
-- Constraints for table `education_attainment_table`
--
ALTER TABLE `education_attainment_table`
  ADD CONSTRAINT `education_attainment_table_ibfk_1` FOREIGN KEY (`Customers_ID`) REFERENCES `customers_table` (`ID`);

--
-- Constraints for table `holiday_table`
--
ALTER TABLE `holiday_table`
  ADD CONSTRAINT `holiday_table_ibfk_1` FOREIGN KEY (`Customer_ID`) REFERENCES `customers_table` (`ID`);

--
-- Constraints for table `married_table`
--
ALTER TABLE `married_table`
  ADD CONSTRAINT `married_table_ibfk_1` FOREIGN KEY (`Customer_ID`) REFERENCES `customers_table` (`ID`);

--
-- Constraints for table `schedules_table`
--
ALTER TABLE `schedules_table`
  ADD CONSTRAINT `schedules_table_ibfk_1` FOREIGN KEY (`Customer_ID`) REFERENCES `customers_table` (`ID`);

--
-- Constraints for table `sick_table`
--
ALTER TABLE `sick_table`
  ADD CONSTRAINT `sick_table_ibfk_1` FOREIGN KEY (`Customer_ID`) REFERENCES `customers_table` (`ID`);

--
-- Constraints for table `wage_from_table`
--
ALTER TABLE `wage_from_table`
  ADD CONSTRAINT `wage_from_table_ibfk_1` FOREIGN KEY (`Wage_ID`) REFERENCES `customers_table` (`Wage_form_ID`);

--
-- Constraints for table `working_time_table`
--
ALTER TABLE `working_time_table`
  ADD CONSTRAINT `working_time_table_ibfk_1` FOREIGN KEY (`CardWork_ID`) REFERENCES `customers_table` (`CardWork_ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
