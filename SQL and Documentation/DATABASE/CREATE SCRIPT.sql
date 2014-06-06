-- phpMyAdmin SQL Dump
-- version 3.5.8.1deb1
-- http://www.phpmyadmin.net
--
-- Main Server: MYSQL-SRV01		--Online
-- Primary Slave: NAS01 		--Online
-- Secondary Slave: WIN-SRV02 	--Online
-- Last Replication: 14 apr 2014 om 8:00
-- Replication to: NAS01, WIN-SRV02 
-- Genereertijd: 14 apr 2014 om 10:32
-- Serverversie: Ubuntu Server 12.04 LTS
-- PHP-versie: 5.4.9
-- RSYNC: 1


SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Databank: `wowhead`
--

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `Author`
--

CREATE TABLE IF NOT EXISTS `Author` (
  `Author_ID` 					int(11)		 NOT NULL AUTO_INCREMENT,
  `Name` 						varchar(40)	 NOT NULL,
  `Reputation` 					int(11)		 NOT NULL,
  PRIMARY KEY (`Author_ID`),
  UNIQUE KEY `Author_ID` (`Author_ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Gegevens worden uitgevoerd voor tabel `Author`
--

INSERT INTO `Author` (`Author_ID`, `Name`, `Reputation`) VALUES
(1, 'Wowhead', 500),
(2, 'Bertes', 0),
(3, 'Justin', 0),
(4, 'SquireKel', 0),
(5, 'Xabidar', 243);

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `Class`
--

CREATE TABLE IF NOT EXISTS `Class` (
  `Class_ID`					int(11)		 NOT NULL,
  `Menu_ID`						int(11)		 NOT NULL,
  `Name` 						varchar(20)	 NOT NULL,

  PRIMARY KEY (`Class_ID`),
  KEY `Menu_Naam` (`Menu_ID`),
  KEY `Menu_Naam_2` (`Menu_ID`),
  KEY `Menu_ID` (`Menu_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Gegevens worden uitgevoerd voor tabel `Class`
--

INSERT INTO `Class` (`Class_ID`, `Name`, `Menu_ID`) VALUES
(1, 1, 'Warlock'),
(2, 2, 'Rogue'),
(3, 3, 'Paladin'),
(4, 4, 'Death Knight');

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `Class_Itemcategory`
--

CREATE TABLE IF NOT EXISTS `Class_Itemcategory` (
  `Class_ID` 					int(11) 	NOT NULL,
  `Itemcategory_ID`				int(11)		NOT NULL,
  PRIMARY KEY (`Class_ID`,`Itemcategory_ID`),
  KEY `Itemcategory_ID` (`Itemcategory_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Gegevens worden uitgevoerd voor tabel `Class_Itemcategory`
--

INSERT INTO `Class_Itemcategory` (`Class_ID`, `Itemcategory_ID`) VALUES
(3, 3),
(1, 4),
(2, 4),
(3, 4),
(1, 5),
(2, 6),
(3, 6);

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `Comments`
--

CREATE TABLE IF NOT EXISTS `Comments` (
  `Comment_ID` 					int(11)		NOT NULL AUTO_INCREMENT,
  `Maincomment_ID` 				int(11) 	DEFAULT NULL,
  `Guide_ID` 					int(11)		NOT NULL,
  `Comment` 					int(11)		NOT NULL,
  `Vote` 						tinyint(1)	NOT NULL,
  `Report` 						varchar(11) NOT NULL,
  PRIMARY KEY (`Comment_ID`),
  KEY `Comment_ID` (`Comment_ID`),
  KEY `Maincomment_ID` (`Maincomment_ID`),
  KEY `Guide_ID` (`Guide_ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `Guide`
--

CREATE TABLE IF NOT EXISTS `Guide` (
  `Guide_ID` 					int(11) 		NOT NULL AUTO_INCREMENT,
  `Author_ID` 					int(11) 		NOT NULL,
  `Guidecategory_ID` 			int(11) 		NOT NULL,
  `Name` 						varchar(50) 	NOT NULL,
  `Omschrijving` 				varchar(9999) 	NOT NULL,
  `Date` 						datetime 		NOT NULL,
  `Rating` 						double 			DEFAULT NULL,
  PRIMARY KEY (`Guide_ID`),
  KEY `Author_D` (`Author_ID`),
  KEY `Category_ID` (`Guidecategory_ID`),
  KEY `Category_ID_2` (`Guidecategory_ID`),
  KEY `Guidecategory_ID` (`Guidecategory_ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=15 ;

--
-- Gegevens worden uitgevoerd voor tabel `Guide`
--

INSERT INTO `Guide` (`Guide_ID`, `Author_ID`, `Guidecategory_ID`, `Name`, `Omschrijving`, `Date`, `Rating`) VALUES
(4, 1, 3, 'Holy Paladin Guide', 'Holy Paladins are strong healers that bring powerful absorption effects ( Illuminated Healing) and versatile utility to every encounter. Paladins use both mana and Holy Power, a secondary resource, to fuel their spells; spending mana generates Holy Power, which can then be spent on potent "finishing" moves like Word of Glory or Light of Dawn. If you''ve just boosted a Holy Paladin to Level 90, this information should help you get up to speed so you can wield the Light, fill up health bars, and Judge everyone ASAP!', '2014-04-01 00:00:00', 0),
(5, 1, 3, 'Retribution Paladin |Guide', 'Retribution paladin is a damage-dealing class that couples off-healing and group utility with strong burst damage.', '0000-00-00 00:00:00', 0),
(6, 1, 3, 'Protection Paladin Guide', 'The protection paladin is a tank that focuses primarily on staying alive through self-healing and blocking, as well as offering exceptional group utility.', '0000-00-00 00:00:00', 4.5),
(9, 4, 4, 'The Sorting Hat - err, Guide [now MoP-approved!]', 'Choosing a Class by (Playing) Personality', '0000-00-00 00:00:00', NULL),
(10, 4, 4, 'Guide Writing for Dummies', 'Ever since the Guide option became available for regular users to create and publish their own guides, there''s been turmoil about formatting and content. It''s not my place to say what material should or should not be allowed as a guide, but I can provide some assistance on...beautifying your guide, so to speak. ', '0000-00-00 00:00:00', NULL),
(13, 5, 4, 'Heirloom List', 'Every single heirloom', '0000-00-00 00:00:00', 5),
(14, 1, 4, 'Leveling and RAF Tips', 'Recruit a Friend', '0000-00-00 00:00:00', 4.5);

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `Guidecategory`
--

CREATE TABLE IF NOT EXISTS `Guidecategory` (
  `Guidecategory_ID` 					int(11) 		NOT NULL,
  `Name` 								varchar(50) 	NOT NULL,
  PRIMARY KEY (`Guidecategory_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Gegevens worden uitgevoerd voor tabel `Guidecategory`
--

INSERT INTO `Guidecategory` (`Guidecategory_ID`, `Name`) VALUES
(1, 'Achievements'),
(2, 'Battle Pets'),
(3, 'Classes'),
(4, 'Miscellaneous');

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `Guide_Class`
--

CREATE TABLE IF NOT EXISTS `Guide_Class` (
  `Guide_ID` 							int(11) 	NOT NULL,
  `Class_ID` 							int(11) 	NOT NULL,
  KEY `Guide_ID` (`Guide_ID`),
  KEY `Spec_ID` (`Class_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Gegevens worden uitgevoerd voor tabel `Guide_Class`
--

INSERT INTO `Guide_Class` (`Guide_ID`, `Class_ID`) VALUES
(9, 3),
(9, 1),
(9, 2);

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `Guide_Item`
--

CREATE TABLE IF NOT EXISTS `Guide_Item` (
  `Item_ID` 							int(11) 	NOT NULL,
  `Guide_ID` 							int(11) 	NOT NULL,
  PRIMARY KEY (`Item_ID`,`Guide_ID`),
  KEY `Guide_ID` (`Guide_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Gegevens worden uitgevoerd voor tabel `Guide_Item`
--

INSERT INTO `Guide_Item` (`Item_ID`, `Guide_ID`) VALUES
(3, 13),
(3, 14);

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `Guide_Spec`
--

CREATE TABLE IF NOT EXISTS `Guide_Spec` (
  `Guide_ID` 							int(11) 	NOT NULL,
  `Spec_ID` 							int(11) 	NOT NULL,
  KEY `Guide_ID` (`Guide_ID`),
  KEY `Spec_ID` (`Spec_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Gegevens worden uitgevoerd voor tabel `Guide_Spec`
--

INSERT INTO `Guide_Spec` (`Guide_ID`, `Spec_ID`) VALUES
(4, 4),
(6, 6),
(5, 5);

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `Item`
--

CREATE TABLE IF NOT EXISTS `Item` (
  `Item_ID` 						int(30) 		NOT NULL AUTO_INCREMENT,
  `Itemcategory_ID` 				int(30) 		NOT NULL,
  `Quality_ID` 						int(11) 		NOT NULL,
  `Name` 							varchar(100) 	NOT NULL,
  `Omschrijving` 					varchar(9999) 	NOT NULL,
  `Level` 							int(3) 			NOT NULL,
  `Reqlevel` 						int(3) 			NOT NULL,
  PRIMARY KEY (`Item_ID`),
  KEY `Itemcategory_ID` (`Itemcategory_ID`),
  KEY `Quality_ID` (`Quality_ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=18 ;

--
-- Gegevens worden uitgevoerd voor tabel `Item`
--

INSERT INTO `Item` (`Item_ID`, `Itemcategory_ID`, `Quality_ID`, `Name`, `Omschrijving`, `Level`, `Reqlevel`) VALUES
(1, 6, 6, 'Warglaive of Azzinoth', 'Binds when picked up', 156, 70),
(3, 4, 8, 'Hellscream''s Razor', 'Binds to Battle.net account', 574, 90),
(8, 7, 4, 'Greaves of the Grand Paladin', 'BOP', 200, 80),
(10, 8, 3, 'Breastplate of the Lost Paladin', 'BOP', 0, 22),
(12, 5, 5, 'Trident of Corrupted Waters', '', 572, 90),
(15, 5, 5, 'Gaze of Arrogance', '', 572, 90),
(17, 5, 5, 'Drakebinder Greatstaff', '', 572, 90);

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `Itemcategory`
--

CREATE TABLE IF NOT EXISTS `Itemcategory` (
  `Itemcategory_ID` 				int(11) 		NOT NULL AUTO_INCREMENT,
  `Name` 							varchar(50) 	NOT NULL,
  `Omschrijving` 					varchar(9999) 	NOT NULL,
  PRIMARY KEY (`Itemcategory_ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=9 ;

--
-- Gegevens worden uitgevoerd voor tabel `Itemcategory`
--

INSERT INTO `Itemcategory` (`Itemcategory_ID`, `Name`, `Omschrijving`) VALUES
(3, '2h Sword', ''),
(4, 'Daggers', ''),
(5, 'Staff', ''),
(6, '1h Sword', ''),
(7, 'Plate boots', ''),
(8, 'Mail Chest', '');

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `MenuItem`
--

CREATE TABLE IF NOT EXISTS `MenuItem` (
  `Menu_ID` 						int(11) 		NOT NULL,
  `Parentmenu_ID` 					int(11) 		DEFAULT NULL,
  `Naam` 							varchar(20) 	NOT NULL,
  `Link` 							varchar(20) 	NOT NULL,
  `Header` 							varchar(20) 	NOT NULL,
  PRIMARY KEY (`Menu_ID`),
  KEY `Parentmenu_ID` (`Parentmenu_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Gegevens worden uitgevoerd voor tabel `MenuItem`
--

INSERT INTO `MenuItem` (`Menu_ID`, `Parentmenu_ID`, `Naam`, `Link`, `Header`) VALUES
(1, 5, 'Warlock', 'Warlock', 'Warlock'),
(2, 5, 'Rogue', 'Rogue', 'Rogue'),
(3, 5, 'Paladin', 'Paladin', 'Paladin'),
(4, 5, 'Death Knight', 'Death Knight', 'Death Knight'),
(5, NULL, 'Class', 'Class', 'Class');

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `Quality`
--

CREATE TABLE IF NOT EXISTS `Quality` (
  `Quality_ID` 						int(11) 		NOT NULL AUTO_INCREMENT,
  `Name` 							varchar(50) 	NOT NULL,
  `Color` 							varchar(50) 	NOT NULL,
  PRIMARY KEY (`Quality_ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=9 ;

--
-- Gegevens worden uitgevoerd voor tabel `Quality`
--

INSERT INTO `Quality` (`Quality_ID`, `Name`, `Color`) VALUES
(1, 'Poor', 'Grey'),
(2, 'Common', 'White'),
(3, 'Uncommon', 'Green'),
(4, 'Rare', 'Blue'),
(5, 'Epic', 'Purple'),
(6, 'Legendary', 'Orange'),
(7, 'Artifact', 'Yellow'),
(8, 'Heirloom', 'Yellow');

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `Spec`
--

CREATE TABLE IF NOT EXISTS `Spec` (
  `Spec_ID` 						int(11) 		NOT NULL,
  `Class_ID` 						int(11) 		NOT NULL,
  `Name` 							varchar(999) 	NOT NULL,
  PRIMARY KEY (`Spec_ID`),
  KEY `Class_ID` (`Class_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Gegevens worden uitgevoerd voor tabel `Spec`
--

INSERT INTO `Spec` (`Spec_ID`, `Class_ID`, `Name`) VALUES
(1, 1, 'Destruction'),
(2, 1, 'Affliction'),
(3, 1, 'Demonolgy'),
(4, 3, 'Holy'),
(5, 3, 'Retribution'),
(6, 3, 'Protection');

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `Spell`
--

CREATE TABLE IF NOT EXISTS `Spell` (
  `Spell_ID` 							int(11) 		NOT NULL AUTO_INCREMENT,
  `Spec_ID` 							int(11) 		NOT NULL,
  `Name` 								varchar(20) 	NOT NULL,
  `Omschrijving` 						varchar(9999)	NOT NULL,
  `Level` 								int(11) 		NOT NULL,
  PRIMARY KEY (`Spell_ID`),
  KEY `Spec_ID` (`Spec_ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=13 ;

--
-- Gegevens worden uitgevoerd voor tabel `Spell`
--

INSERT INTO `Spell` (`Spell_ID`, `Spec_ID`, `Name`, `Omschrijving`, `Level`) VALUES
(1, 1, 'Chaos Bolt', '10 Burning Embers	40 yd range', 42),
(2, 1, 'Incinerate', '', 10),
(3, 1, 'Immolate', '', 1),
(4, 2, 'Corruption', '', 3),
(5, 2, 'Unstable Affliction', '', 10),
(7, 4, 'Holy Shock', 'Heals target', 10),
(8, 6, 'Crusader Strike', '', 0),
(9, 6, 'Judgement', '', 0),
(10, 5, 'The Art of War', '', 0),
(11, 5, 'Hammer of Wrath', '', 0),
(12, 4, 'Word of Glory', '', 0);

--
-- Beperkingen voor gedumpte tabellen
--

--
-- Beperkingen voor tabel `Class_Itemcategory`
--
ALTER TABLE `Class_Itemcategory`
  ADD CONSTRAINT `Class_Itemcategory_ibfk_5` FOREIGN KEY (`Class_ID`) REFERENCES `Class` (`Class_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `Class_Itemcategory_ibfk_6` FOREIGN KEY (`Itemcategory_ID`) REFERENCES `Itemcategory` (`Itemcategory_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Beperkingen voor tabel `Comments`
--
ALTER TABLE `Comments`
  ADD CONSTRAINT `Comments_ibfk_1` FOREIGN KEY (`Maincomment_ID`) REFERENCES `Comments` (`Comment_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `Comments_ibfk_2` FOREIGN KEY (`Guide_ID`) REFERENCES `Guide` (`Guide_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Beperkingen voor tabel `Guide`
--
ALTER TABLE `Guide`
  ADD CONSTRAINT `Guide_ibfk_1` FOREIGN KEY (`Author_ID`) REFERENCES `Author` (`Author_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `Guide_ibfk_2` FOREIGN KEY (`Guidecategory_ID`) REFERENCES `Guidecategory` (`Guidecategory_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Beperkingen voor tabel `Guide_Class`
--
ALTER TABLE `Guide_Class`
  ADD CONSTRAINT `Guide_Class_ibfk_1` FOREIGN KEY (`Guide_ID`) REFERENCES `Guide` (`Guide_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `Guide_Class_ibfk_2` FOREIGN KEY (`Class_ID`) REFERENCES `Class` (`Class_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Beperkingen voor tabel `Guide_Item`
--
ALTER TABLE `Guide_Item`
  ADD CONSTRAINT `Guide_Item_ibfk_5` FOREIGN KEY (`Item_ID`) REFERENCES `Item` (`Item_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `Guide_Item_ibfk_6` FOREIGN KEY (`Guide_ID`) REFERENCES `Guide` (`Guide_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Beperkingen voor tabel `Guide_Spec`
--
ALTER TABLE `Guide_Spec`
  ADD CONSTRAINT `Guide_Spec_ibfk_1` FOREIGN KEY (`Guide_ID`) REFERENCES `Guide` (`Guide_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `Guide_Spec_ibfk_2` FOREIGN KEY (`Spec_ID`) REFERENCES `Spec` (`Spec_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Beperkingen voor tabel `Item`
--
ALTER TABLE `Item`
  ADD CONSTRAINT `Item_ibfk_7` FOREIGN KEY (`Quality_ID`) REFERENCES `Quality` (`Quality_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `Item_ibfk_8` FOREIGN KEY (`Itemcategory_ID`) REFERENCES `Itemcategory` (`Itemcategory_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Beperkingen voor tabel `MenuItem`
--
ALTER TABLE `MenuItem`
  ADD CONSTRAINT `MenuItem_ibfk_1` FOREIGN KEY (`Parentmenu_ID`) REFERENCES `MenuItem` (`Menu_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Beperkingen voor tabel `Spec`
--
ALTER TABLE `Spec`
  ADD CONSTRAINT `Spec_ibfk_5` FOREIGN KEY (`Class_ID`) REFERENCES `Class` (`Class_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Beperkingen voor tabel `Spell`
--
ALTER TABLE `Spell`
  ADD CONSTRAINT `Spell_ibfk_3` FOREIGN KEY (`Spec_ID`) REFERENCES `Spec` (`Spec_ID`) ON DELETE CASCADE ON UPDATE CASCADE;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;


--
--
--
--QUERY'S
--
--
--

--SPELLS
--- Destruction Warlock
Select Name As Spell
From Spell
Where Spec_ID IN
(
Select Spec_ID
From Spec
Where Name LIKE 'Destruction'
AND class_ID in
(
Select class_ID
From Class
Where Name LIKE 'Warlock'
)
) 

---Spells per spec
Select sp.Name As Spec,s.Name As Spell
From Class c, Spec sp, Spell s
where c.Class_ID = sp.Class_ID
And sp.Spec_ID = s.Spec_ID
AND c.Name Like 'Paladin'


--ZOEKEN NAAR EEN ITEM
---Volledig naam
Select Name 
FROM Item
Where Name Like "Hellscream's Razor"
UNION
SELECT Name 
From Class
Where Name Like "Hellscream's Razor"
UNION
SELECT Name 
From Spell
Where Name Like "Hellscream's Razor"
UNION

---Keyword
SELECT Name
From Class
Where Name Like "%Palad%"
UNION
Select Name
FROM Item
Where Name Like "%Palad%"
UNION
SELECT Name
From Spell
Where Name Like "%Palad%"


--GUIDE 
---Item
Select Name
From Guide
Where Guide_ID IN
(
Select Guide_ID
From Guide_Item
Where Item_ID IN
(
Select Item_ID
From Item
Where name LIKE "Hellscream's Razor"
)
)

---Spec
Select c.Name AS Class, sp.Name AS Spec,g.Name
From Class c, Spec sp, Guide g, Guide_Spec gs
where c.Class_ID = sp.Class_ID
And sp.Spec_ID = gs.Spec_ID
And gs.Guide_ID = g.Guide_ID
And c.Name LIKE 'paladin'

--FILTER
---Item (Itemlevel > 571, Staff, Epic)
Select Name, Level,Reqlevel
From Item
Where Quality_ID IN
(
Select Quality_ID
from Quality
Where Name= 'Epic'
)
AND Level > '571'
AND Itemcategory_ID IN
(
Select Itemcatogory_ID
From Itemcategory
Where Name= 'Staff'
