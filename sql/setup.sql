-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Erstellungszeit: 17. Nov 2021 um 09:06
-- Server-Version: 10.4.17-MariaDB
-- PHP-Version: 8.0.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Datenbank: `lf8_profit`
--

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `mitarbeiter`
--

CREATE TABLE `mitarbeiter` (
                               `MNr` int(4) UNSIGNED ZEROFILL NOT NULL DEFAULT 0000,
                               `Name` varchar(30) NOT NULL DEFAULT '',
                               `Vorname` varchar(30) NOT NULL DEFAULT '',
                               `Strasse` varchar(30) DEFAULT '',
                               `PLZ` varchar(5) NOT NULL DEFAULT '',
                               `Ort` varchar(30) NOT NULL DEFAULT '',
                               `Telefon` varchar(30) DEFAULT '',
                               `Geschlecht` enum('m','w') NOT NULL DEFAULT 'm',
                               `eingestellt` date NOT NULL DEFAULT '1900-01-01',
                               `KFZ1` varchar(10) DEFAULT '',
                               `KFZ2` varchar(10) DEFAULT '',
                               `Abteilung` int(2) UNSIGNED ZEROFILL NOT NULL DEFAULT 00
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Daten für Tabelle `mitarbeiter`
--

INSERT INTO `mitarbeiter` (`MNr`, `Name`, `Vorname`, `Strasse`, `PLZ`, `Ort`, `Telefon`, `Geschlecht`, `eingestellt`, `KFZ1`, `KFZ2`, `Abteilung`) VALUES
                                                                                                                                                       (0100, 'Meier', 'Inge', 'Amselweg 11', '53101', 'Bonn', '0228/124578', 'w', '1995-01-01', 'BN-X123', 'BN-A 911', 02),
                                                                                                                                                       (0101, 'Schneider', 'Ute', 'Hauptstr. 17', '50012', 'Köln', '0221/215211', 'w', '1999-01-04', 'K-OK 777', NULL, 02),
                                                                                                                                                       (0105, 'Berg', 'Karin', 'Am Funkturm 156', '65203', 'Wiesbaden', '0611/928792', 'w', '1995-09-01', 'WI-AK 421', NULL, 04),
                                                                                                                                                       (0108, 'Wasser', 'Ute', 'Weststr. 20', '52074', 'Aachen', '0241/875554', 'w', '1995-12-01', 'AC-UW 222', 'AC-UW 333', 02),
                                                                                                                                                       (0200, 'Huber', 'Sepp', 'Bodenseestr. 123', '81243', 'München', '089/8744397', 'm', '1996-02-01', 'M-A 6666', 'M-A 7777', 02),
                                                                                                                                                       (0207, 'Schmitz', 'Hans', 'Siegburger Str. 51', '50679', 'Köln', '0221/814447', 'm', '1996-05-01', 'K-LR 333', NULL, 02),
                                                                                                                                                       (0209, 'Schmidt', 'Jürgen', 'Osdorfer Weg 7', '22607', 'Hamburg', '040/899899', 'm', '1996-05-01', 'HH-H111', NULL, 01),
                                                                                                                                                       (0611, 'Kammer', 'Ulrike', 'Hauptstr. 171', '52146', 'Würselen', '02405/712217', 'w', '1998-06-01', NULL, NULL, 01),
                                                                                                                                                       (0700, 'Meyer', 'Kurth', 'Jollystr. 99', '76137', 'Karlsruhe', '0721/9812124', 'm', '1996-09-15', 'KA-BU 55', 'KA-MK 917', 02),
                                                                                                                                                       (0701, 'Huber', 'Anke', 'Gabelsberger Str. 70', '86199', 'Augsburg', '0821/98666', 'w', '1996-12-01', 'A-VV 454', 'A-XX 123', 02),
                                                                                                                                                       (0710, 'Schmidt', 'Beate', 'Klosterstr. 1', '40211', 'Düsseldorf', '0211/363636', 'w', '1997-04-04', 'D-K 6767', 'D-K 6666', 03),
                                                                                                                                                       (0711, 'Bauer', 'Klaus', 'Spielhagenstr. 113', '30107', 'Hannover', '0511/833883', 'm', '1997-04-01', 'H-RR 309', 'H-ZU 777', 02),
                                                                                                                                                       (0777, 'Schmied', 'Olga', 'Ahralle 77', '53474', 'Bad Neuenahr-Ahrweiler', '02641/909090', 'w', '1986-09-17', 'AW-XY 34', NULL, 02),
                                                                                                                                                       (0788, 'Schnitt', 'Hannelore', 'Im Roßberg 123', '53505', 'Altenahr', '02643/996633', 'w', '1985-06-18', 'AW-ZA 13', 'AW-BB 13', 03),
                                                                                                                                                       (0800, 'Maier', 'Anton', 'Tiroler Weg 32', '79111', 'Freiburg', '0761/443444', 'm', '1997-06-01', 'FR-GG 373', NULL, 02),
                                                                                                                                                       (0802, 'Meier', 'Doris', 'Hauptstr.32', '98528', 'Suhl', '03681/440044', 'w', '1998-01-01', 'SUH-L 111', NULL, 02),
                                                                                                                                                       (0803, 'Schmidt', 'Barbara', 'Rößlerstr. 33', '09120', 'Chemnitz', '0371/525212', 'w', '1998-01-01', 'CH-GE 919', NULL, 01),
                                                                                                                                                       (0804, 'Muller', 'Hildegard', 'Altleubnitz 21', '01219', 'Dresden', '0351/788285', 'w', '1998-05-15', 'DR-DN 5421', NULL, 02),
                                                                                                                                                       (0805, 'Schmitt', 'Klaus', 'Vogelsanger Str.77', '50666', 'Köln', '0221/561112', 'm', '1998-06-01', 'K-Q 3456', NULL, 02),
                                                                                                                                                       (0806, 'Lausen', 'Werner', 'Münstereifeler Str. 22', '53879', 'Euskirchen', '02251/868657', 'm', '1999-01-01', 'EU-R 9999', NULL, 02),
                                                                                                                                                       (0807, 'Görner', 'Heidrun', 'Waldstr. 97', '51145', 'Köln-Porz', '02203/912778', 'w', '1998-06-01', 'K-P 5555', 'K-A 6666', 02),
                                                                                                                                                       (0809, 'Preuß', 'Karl', 'Peter-Paul-Str. 67', '52249', 'Eschweiler', '02403/151515', 'm', '1998-06-01', NULL, NULL, 02),
                                                                                                                                                       (0810, 'Müller', 'Bärbel', 'Levenstr. 88', '50259', 'Pulheim', '02238/980021', 'w', '1998-06-01', 'K-ZT 850', NULL, 01);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `projekt`
--

CREATE TABLE `projekt` (
                           `ProjNr` int(5) NOT NULL,
                           `Bezeichnung` varchar(50) NOT NULL DEFAULT '',
                           `Auftragswert` decimal(10,2) NOT NULL DEFAULT 0.00,
                           `bezahlt` decimal(10,2) DEFAULT 0.00,
                           `Beginn` date NOT NULL DEFAULT '1900-01-01',
                           `Ende` date DEFAULT NULL,
                           `Storno` tinyint(1) NOT NULL DEFAULT 0,
                           `Leiter` int(4) UNSIGNED ZEROFILL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Daten für Tabelle `projekt`
--

INSERT INTO `projekt` (`ProjNr`, `Bezeichnung`, `Auftragswert`, `bezahlt`, `Beginn`, `Ende`, `Storno`, `Leiter`) VALUES
                                                                                                                     (77, 'Umzug Stein AG', '50000.00', '12000.00', '2006-06-30', NULL, 0, 0100),
                                                                                                                     (78, 'Einrichtung Apache-WEB-Server, Moberg GmbH', '8000.00', '0.00', '2006-07-01', '2006-07-15', 0, 0810),
                                                                                                                     (79, 'Aufbau Intranet, Druckerei Wolff', '30000.00', '7500.00', '2006-09-01', NULL, 0, 0200),
                                                                                                                     (80, 'Vernetzung, Bau AG', '100000.00', NULL, '2006-07-01', '2006-07-31', 1, 0800),
                                                                                                                     (81, 'Vernetzung, Großmann', '24000.00', '5000.00', '2006-07-05', NULL, 0, 0100),
                                                                                                                     (82, 'DV-Labor, BBS III', '40000.00', '0.00', '2006-08-01', NULL, 0, 0101),
                                                                                                                     (84, 'Umzug Stadtanzeiger', '180000.00', '30000.00', '2006-08-01', NULL, 0, 0805),
                                                                                                                     (85, 'Umrüstung Neumann OHG', '12000.00', NULL, '2006-07-01', NULL, 1, 0700),
                                                                                                                     (86, 'Linux-Server, Stadtverwaltung Brühl', '15000.00', NULL, '2006-08-10', NULL, 0, 0809),
                                                                                                                     (87, 'Win-Server, Lacke Hansen', '30000.00', NULL, '2006-06-01', '2006-06-10', 1, 0803),
                                                                                                                     (88, 'Adabas-SQL-Server, MTech', '20000.00', '20000.00', '2006-09-01', NULL, 1, 0804),
                                                                                                                     (89, 'Office-Schulung, BATIX', '25000.00', NULL, '2006-10-01', NULL, 0, 0803),
                                                                                                                     (90, 'Umstellung Windows- auf Linux-Server, Zuckmann', '9500.00', NULL, '2006-10-08', NULL, 0, 0200),
                                                                                                                     (91, 'Schulung, Naumann & Co.', '5000.00', NULL, '2006-10-15', NULL, 0, 0810);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `projektmitarbeiter`
--

CREATE TABLE `projektmitarbeiter` (
                                      `ID` int(11) NOT NULL,
                                      `ProjNr` int(5) DEFAULT 0,
                                      `MNr` int(4) UNSIGNED ZEROFILL DEFAULT 0000,
                                      `Zeitanteil` int(4) NOT NULL DEFAULT 0 COMMENT 'Zeit in Stunden'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Daten für Tabelle `projektmitarbeiter`
--

INSERT INTO `projektmitarbeiter` (`ID`, `ProjNr`, `MNr`, `Zeitanteil`) VALUES
                                                                           (1, 77, 0100, 10),
                                                                           (2, 77, 0701, 5),
                                                                           (3, 77, 0805, 20),
                                                                           (4, 78, 0804, 6),
                                                                           (5, 78, 0810, 8),
                                                                           (6, 79, 0200, 10),
                                                                           (7, 79, 0701, 30),
                                                                           (8, 80, 0105, 20),
                                                                           (9, 80, 0108, 5),
                                                                           (10, 80, 0711, 3),
                                                                           (11, 80, 0800, 5),
                                                                           (12, 80, 0803, 5),
                                                                           (13, 80, 0804, 5),
                                                                           (14, 81, 0100, 3),
                                                                           (15, 81, 0806, 10),
                                                                           (16, 81, 0807, 10),
                                                                           (17, 81, 0809, 20),
                                                                           (18, 82, 0101, 5),
                                                                           (19, 82, 0207, 30),
                                                                           (20, 82, 0710, 5),
                                                                           (21, 84, 0108, 5),
                                                                           (22, 84, 0700, 3),
                                                                           (23, 84, 0710, 5),
                                                                           (24, 85, 0700, 35),
                                                                           (25, 86, 0804, 6),
                                                                           (26, 86, 0809, 10),
                                                                           (27, 88, 0101, 3),
                                                                           (28, 88, 0711, 5),
                                                                           (29, 88, 0804, 15),
                                                                           (30, 89, 0803, 20),
                                                                           (31, 89, 0807, 10),
                                                                           (32, 90, 0200, 5),
                                                                           (33, 90, 0802, 25),
                                                                           (34, 91, 0108, 8),
                                                                           (35, 91, 0800, 12),
                                                                           (36, 91, 0810, 5);

--
-- Indizes der exportierten Tabellen
--

--
-- Indizes für die Tabelle `mitarbeiter`
--
ALTER TABLE `mitarbeiter`
    ADD PRIMARY KEY (`MNr`),
  ADD KEY `Abteilung` (`Abteilung`),
  ADD KEY `Name` (`Name`);

--
-- Indizes für die Tabelle `projekt`
--
ALTER TABLE `projekt`
    ADD PRIMARY KEY (`ProjNr`),
  ADD UNIQUE KEY `Bezeichnung` (`Bezeichnung`),
  ADD KEY `Leiter` (`Leiter`);

--
-- Indizes für die Tabelle `projektmitarbeiter`
--
ALTER TABLE `projektmitarbeiter`
    ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `Zeitanteile` (`MNr`,`ProjNr`),
  ADD KEY `MNr` (`MNr`),
  ADD KEY `ProjNr` (`ProjNr`);

--
-- AUTO_INCREMENT für exportierte Tabellen
--

--
-- AUTO_INCREMENT für Tabelle `projektmitarbeiter`
--
ALTER TABLE `projektmitarbeiter`
    MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=37;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
