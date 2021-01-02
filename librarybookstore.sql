-- phpMyAdmin SQL Dump
-- version 5.0.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 26, 2020 at 08:42 PM
-- Server version: 10.4.14-MariaDB
-- PHP Version: 7.2.34

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `librarybookstore`
--

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `Username` varchar(20) NOT NULL,
  `Password` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`Username`, `Password`) VALUES
('Ashish123', 'Ashish123@'),
('Mehedi345', 'Mehedi345#'),
('Samia234', 'Samia234@@'),
('Rasel890', 'Rasel890@#'),
('Munna45', 'Munna465$'),
('Jamal324', 'Jamal324!!'),
('Sanzida65', 'Sanzida453'),
('Ridita342', 'Ridita342&'),
('Fahim909', 'Fahim903'),
('Shakil', 'Shakil789'),
('Saba', 'Saba789#'),
('Sana280', 'Sana280@'),
('Samia67', 'Samia67@'),
('Ratul99', 'Ratul99#'),
('Ramisa46', 'Ramisa46@'),
('Rahim89', 'Rahim89#'),
('Raju789', 'Raju789@'),
('Minhaj978', 'Minhaj978!!'),
('Jaman234', 'Jaman234$$'),
('Raisa785', 'Raisa785##');

-- --------------------------------------------------------

--
-- Table structure for table `managerbookentry`
--

CREATE TABLE `managerbookentry` (
  `BookName` varchar(100) NOT NULL,
  `BookPublishYear` int(100) NOT NULL,
  `WriterName` varchar(100) NOT NULL,
  `QuantityOfBook` int(100) NOT NULL,
  `CatagoryName` varchar(100) NOT NULL,
  `EntryDate` date NOT NULL,
  `AvaliableBook` int(100) NOT NULL,
  `BorrowBook` int(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `managerbookentry`
--

INSERT INTO `managerbookentry` (`BookName`, `BookPublishYear`, `WriterName`, `QuantityOfBook`, `CatagoryName`, `EntryDate`, `AvaliableBook`, `BorrowBook`) VALUES
('In Search of Lost Time\r\n	\r\n', 1913, 'Marcel Proust', 50, 'Literature & Fiction', '2020-12-09', 30, 20),
('Ulysses\r\n', 1922, 'James Joyce', 30, 'Humanities', '2020-12-28', 20, 10),
('Gulliver’s Travels 	', 1726, 'Jonathan Swift', 25, 'Adventure', '2020-11-11', 16, 9),
('A Bend in the River	', 1979, 'VS Naipaul', 20, 'Fiction', '2020-11-03', 11, 9),
(' Midnight’s Children 	', 1981, 'Salman Rushdie', 18, 'Fantasy	', '0000-00-00', 7, 11),
('Housekeeping	', 1981, 'Marilynne Robinson', 22, 'Fiction	', '2020-10-09', 16, 6),
('Money: A Suicide Note	', 1984, 'Martin Amis', 19, 'Humor', '2020-02-23', 9, 10),
('The Beginning of Spring 	', 1988, 'Penelope Fitzgerald', 33, 'Fiction', '2020-01-16', 20, 13),
('Breathing Lessons 	', 1988, 'Anne Tyler', 12, 'Humor', '2010-12-17', 7, 5),
('Amongst Women 	', 1990, 'John McGahern', 3, 'Fiction	', '2020-12-20', 2, 1),
('Underworld 	', 1997, 'Don DeLillo', 10, 'Classics', '2012-10-03', 8, 2),
('Disgrace	', 1999, 'JM Coetzee', 20, 'Fiction	', '2019-12-14', 8, 12),
('True History of the Kelly Gang 	', 2000, 'Peter Carey', 13, 'Fiction', '2020-09-30', 10, 3),
('Under the Volcano	', 1947, 'Malcolm Lowry', 20, 'United States	', '2020-08-01', 16, 4),
('All the King’s Men', 1946, 'Robert Penn Warren', 15, 'Literature & Fiction', '2020-07-16', 10, 5),
('The Black Swan:The Impact of the Highly Improbable\r\n', 2007, 'Nassim Nicholas Taleb', 60, 'Non-fiction', '2018-12-17', 30, 30),
('You Are Not a Gadget\r\n', 2010, 'Jaron Lanier', 42, 'Fiction', '2020-05-03', 22, 20),
('Mendl Mann’s :The Fall of Berlin\r\n', 2020, ' Maurice Wolfthal', 25, 'History and Biography', '2020-12-09', 5, 20),
('The Social Life of Information\r\n', 2000, 'John Seely Brown,Paul Duguid', 40, 'Non-fiction', '2020-01-13', 10, 30),
('A Brief History of Time\r\n\r\n', 1988, 'Stephen Hawking', 50, 'Historical', '2020-12-16', 35, 15);

-- --------------------------------------------------------

--
-- Table structure for table `managerlogin`
--

CREATE TABLE `managerlogin` (
  `MUsername` varchar(100) NOT NULL,
  `MPassword` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `managerlogin`
--

INSERT INTO `managerlogin` (`MUsername`, `MPassword`) VALUES
('Mohim', 'mohim311'),
('Ratul', 'ratul432'),
('Rifat', 'rifat413'),
('Mehzabin', 'mehzabin812'),
('Radiath', 'radiath789'),
('Samia', 'samia970'),
('Minar', 'minar729'),
('Afzal', 'afzal496'),
('Renon', 'renon720'),
('Fariha', 'fariha324'),
('Maliha', 'maliha640'),
('Faiza', 'faiza444'),
('Ruby', 'ruby566'),
('Maisha', 'maisha900'),
('Mariam', 'mariam754'),
('Umama', 'umama986'),
('Maruf', 'maruf654'),
('Arif', 'arif952'),
('Safin', 'safin878'),
('Sami', 'sami876');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
