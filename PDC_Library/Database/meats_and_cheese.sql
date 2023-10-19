-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 19, 2023 at 05:59 PM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET ITEM_NAMES utf8mb4 */;

--
-- Database:  publix deli nut calc 
--

-- --------------------------------------------------------

--
-- Table structure for table  MEATS_AND_CHEESES 
--

CREATE TABLE MEATS_AND_CHEESES (
  ID int(11) NOT NULL,
  SERVING_SIZE int(11) NOT NULL,
  ITEM_ITEM_NAME text NOT NULL,
  Calories int(11) NOT NULL,
  CARBS decimal(10,2) NOT NULL,
  FAT decimal(10,2) NOT NULL,
  PROTEIN  decimal(10,0) NOT NULL,
  SAT  decimal(10,0) NOT NULL,
  TRANS  decimal(10,0) NOT NULL,
  SODIUM  decimal(10,0) NOT NULL,
  CHOLESTEROL  decimal(10,0) NOT NULL
)

--
-- Dumping data for table  MEATS_AND_CHEESES 
--

INSERT INTO  MEATS_AND_CHEESES  ( ID ,  SERVING_SIZE ,  ITEM_NAME ,  Calories ,  CARBS , FAT,  PROTEIN ,  SAT ,  TRANS ,  SODIUM ,  CHOLESTEROL ) VALUES
(100, 2, "Boar\'s Head Ovengold Turkey", 60, 0.00, 1.00, 11, 0, 0, 360, 20),
(101, 2, "Boar\'s Head Lower SODIUM Turkey", 60, 0.00, 1.00, 12, 0, 0, 360, 30),
(102, 2, "Boar\'s Head Blackened Turkey Breast", 60, 2.00, 0.50, 12, 0, 0, 700, 30),
(103, 2, "Boar\'s Head Pitcraft Turkey", 60, 0.00, 2.00, 13, 0, 0, 500, 25),
(104, 2, "Boar\'s Head Salsalito Turkey", 60, 0.00, 0.50, 13, 0, 0, 480, 25),
(105, 2, "Boar\'s Head Cajun Turkey", 60, 1.00, 0.50, 13, 0, 0, 650, 25),
(106, 2, "Boar\'s Head Cracked Pepper Turkey Breast", 60, 0.00, 1.00, 13, 0, 0, 460, 30),
(107, 2, "Boar\'s Head Black Forest Turkey", 60, 0.00, 1.00, 13, 0, 0, 390, 25),
(108, 2, "Boar\'s Head Maple Glazed Honey Coat Turkey", 70, 2.00, 0.50, 14, 0, 0, 480, 30),
(109, 2, "Boar\'s Head Mesquite Wood Smoked Turkey Breast", 60, 0.00, 1.00, 12, 0, 0, 440, 25),
(110, 2, "Boar\'s Head No Salt Added Turkey", 70, 0.00, 1.00, 14, 0, 0, 55, 40),
(111, 2, "Boar\'s Head Pastrami Seasoned Turkey Breast", 60, 1.00, 1.00, 13, 0, 0, 460, 25);

--
-- Indexes for dumped tables
--

--
-- Indexes for table  MEATS_AND_CHEESES 
--
ALTER TABLE  MEATS_AND_CHEESES 
  ADD PRIMARY KEY ( ID );
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
