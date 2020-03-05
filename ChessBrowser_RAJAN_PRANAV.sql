CREATE TABLE `Players` (
  `Name` varchar(255) DEFAULT NULL,
  `Elo` int(10) unsigned DEFAULT NULL,
  `pID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`pID`),
  UNIQUE KEY `Name` (`Name`)
);

 CREATE TABLE `Events` (
  `Name` varchar(255) NOT NULL,
  `Site` varchar(255) NOT NULL,
  `Date` date NOT NULL,
  `eID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`eID`),
  UNIQUE KEY `Name` (`Name`,`Date`,`Site`)
);

CREATE TABLE `Games` (
  `Round` varchar(10) NOT NULL,
  `Result` char(1) NOT NULL,
  `Moves` varchar(2000) NOT NULL,
  `BlackPlayer` int(10) unsigned NOT NULL,
  `WhitePlayer` int(10) unsigned NOT NULL,
  `eID` int(10) unsigned NOT NULL,
  PRIMARY KEY (`eID`,`Round`,`WhitePlayer`,`BlackPlayer`),
  KEY `WhitePlayer` (`WhitePlayer`),
  KEY `BlackPlayer` (`BlackPlayer`),
  KEY `eID` (`eID`),
  CONSTRAINT `Games_ibfk_1` FOREIGN KEY (`WhitePlayer`) REFERENCES `Players` (`pID`),
  CONSTRAINT `Games_ibfk_2` FOREIGN KEY (`BlackPlayer`) REFERENCES `Players` (`pID`),
  CONSTRAINT `Games_ibfk_3` FOREIGN KEY (`eID`) REFERENCES `Events` (`eID`)
);


