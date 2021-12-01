SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;

--
-- Datenbank: `db_euro_data`
--

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `test`
--

CREATE TABLE `test` (
                        `id` int NOT NULL,
                        `test_text` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Daten für Tabelle `test`
--

INSERT INTO `test` (`id`, `test_text`) VALUES
                                           (1, 'text1'),
                                           (2, 'text2');

--
-- Indizes der exportierten Tabellen
--

--
-- Indizes für die Tabelle `test`
--
ALTER TABLE `test`
    ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT für exportierte Tabellen
--

--
-- AUTO_INCREMENT für Tabelle `test`
--
ALTER TABLE `test`
    MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

COMMIT;