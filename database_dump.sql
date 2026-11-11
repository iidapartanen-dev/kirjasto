-- MySQL dump 10.13  Distrib 8.0.44, for Win64 (x86_64)
--
-- Host: localhost    Database: kirjasto
-- ------------------------------------------------------
-- Server version	8.0.44

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `asiakas`
--

DROP TABLE IF EXISTS `asiakas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `asiakas` (
  `tunnus` char(7) NOT NULL,
  `enimi` varchar(15) DEFAULT NULL,
  `snimi` varchar(30) DEFAULT NULL,
  `koso` varchar(40) DEFAULT NULL,
  `pno` char(5) DEFAULT NULL,
  `ptp` varchar(30) DEFAULT NULL,
  `puh` varchar(20) DEFAULT NULL,
  `email` varchar(70) DEFAULT NULL,
  PRIMARY KEY (`tunnus`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `asiakas`
--

LOCK TABLES `asiakas` WRITE;
/*!40000 ALTER TABLE `asiakas` DISABLE KEYS */;
INSERT INTO `asiakas` VALUES ('AS00126','Matti','Meikäläinen','Katu 1','00100','Helsinki','0401111111','matti.meikalainen@gmail.com'),('AS00226','Liisa','Lahtinen','Polkutie 15','33100','Tampere','0501111112','liisa.lahtinen@gmail.com'),('AS00326','Kalle','Korhonen','Tie 9','20100','Turku','0402222222','kalle.korhonen@gmail.com'),('AS00426','Anna','Ahonen','Kuja 7','90100','Oulu','0502222222','anna.ahonen@gmail.com'),('AS00526','Petri','Päivinen','Raitti 3','15100','Lahti','0403333333','petri.paivinen@gmail.com'),('AS00626','Antti','Laitinen','Kivipolku 2','90500','Oulu','0503333333','antti.laitinen@gmail.com'),('AS00726','Antti','Karjalainen','Katajatie 12','40100','Jyväskylä','0404444444','antti.karjalainen@gmail.com'),('AS00826','Janne','Järvinen','Männiköntie 50','28100','Pori','0504444444','janne.järvinen@gmail.com'),('AS00926','Heikki','Jokinen','Lehmustie 28','33100','Tampere','0405555555','heikki.jokinen@gmail.com'),('AS01026','Anna','Rantanen','Kivipolku 21','80100','Joensuu','0505555555','anna.rantanen@gmail.com'),('AS01126','Ville','Korhonen','Koivukuja 14','00100','Helsinki','040666666','ville.korhonen@gmail.com'),('AS01226','Sari','Kinnunen','Koivukuja 7','90500','Oulu','050666666','sari.kinnunen@gmail.com'),('AS01326','Eeva','Nieminen','Niittytie 10','20100','Turku','0407777777','eeva.nieminen@gmail.com'),('AS01426','Matti','Koskinen','Vaahterakuja 21','33100','Tampere','0507777777','matti.koskinen@gmail.com'),('AS01526','Riikka','Lehtonen','Katajatie 59','28100','Pori','0408888888','riikka.lehtonen@gmail.com'),('AS01626','Sari','Järvinen','Lehmustie 41','15100','Lahti','0508888888','sari.jarvinen@gmail.com'),('AS01726','Johanna','Nieminen','Katajatie 36','28100','Pori','0409999999','johanna.nieminen@gmail.com'),('AS01826','Eeva','Heikkinen','Kuusitie 5','80100','Joensuu','0509999999','eeva.heikkinen@gmail.com'),('AS01926','Olli','Salminen','Koivukuja 37','33100','Tampere','0409999990','olli.salminen@gmail.com'),('AS02026','Sari','Hämäläinen','Haavikkokuja 19','20100','Turku','0509999990','sari.hamalainen@gmail.com'),('AS02126','Testi','Testinen','Testitie 5','05820','Hyvinkää','0401234567','testi@gmail.com'),('AS02226','Testi','Testinen','Testikatu 23','05820','Hyvinkää','0501234567','testinen@gmail.com'),('AS02326','Tyyppi','Tyyppinen','Tyyppitie 45','05820','Hyvinkää','0451234567','tyyppi@gmail.com'),('AS02526','Aku','Ankka','Ankkalinna 1','05820','Hyvinkää','0409996666','aku.ankka@gmail.com'),('AS02626','Anna','Mäkinen','Viistokatu 1','05820','Hyvinkää','0501231234','anna.makinen@gmail.com'),('AS02726','Testi','Testaus','Testikatu11','05820','Hyvinkää','092724874','testi.testaus@gmail.com'),('AS02826','Kalle','Määttä','Kotikatu 3','05820','Hyvinkää','0507689876','kall.maatta@gmail.com');
/*!40000 ALTER TABLE `asiakas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `kirja`
--

DROP TABLE IF EXISTS `kirja`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `kirja` (
  `kirjatunnus` varchar(13) NOT NULL,
  `nimi` varchar(40) DEFAULT NULL,
  `sivut` int DEFAULT NULL,
  `vuosi` int DEFAULT NULL,
  `kieli` varchar(15) DEFAULT NULL,
  `muoto` varchar(20) DEFAULT NULL,
  `luokka` char(5) DEFAULT NULL,
  PRIMARY KEY (`kirjatunnus`),
  KEY `luokka` (`luokka`),
  CONSTRAINT `kirja_ibfk_1` FOREIGN KEY (`luokka`) REFERENCES `luokitus` (`ltun`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kirja`
--

LOCK TABLES `kirja` WRITE;
/*!40000 ALTER TABLE `kirja` DISABLE KEYS */;
INSERT INTO `kirja` VALUES ('0007123817','The Lord of the Rings',1146,1954,'Englanti','Pehmeä kantinen','84.5'),('9171332502','Utan misskund',722,1993,'Ruotsi','Pehmeä kantinen','84.3'),('9510040789','Peppi Pitkätossun tarina',292,1948,'Suomi','Kovakantinen','86.11'),('9510133450','Tuntematon sotilas',477,1954,'Suomi','Kovakantinen','84.2'),('9510144398','Muumilaakson marraskuu',173,1970,'Suomi','Pehmeä kantinen','84.2'),('9510144436','Näkymätön lapsi',167,1962,'Suomi','Pehmeä kantinen','84.2'),('9511079786','Kissan ensiapu',121,1984,'Suomi','Kovakantinen','67.45'),('9511201158','Kasvoton kuolema',327,2005,'Suomi','Kovakantinen','84.2'),('9511207830','Kennedyn aivot',427,2006,'Suomi','Kovakantinen','84.2'),('9513111466','Harry Potter ja viisasten kivi',335,1997,'Suomi','Kovakantinen','84.2'),('9513114724','Harry Potter ja salaisuuksien kammio',365,1998,'Suomi','Kovakantinen','84.2'),('9513117375','Harry Potter ja Azkabanin vanki',456,1999,'Suomi','Kovakantinen','84.2'),('9513120384','Harry Potter ja liekehtivä pikari',768,2000,'Suomi','Kovakantinen','84.2'),('9513135071','Harry Potter ja Feeniksin kilta',1050,2003,'Suomi','Kovakantinen','84.2'),('9516439969','Tanssinopettajan paluu',464,2002,'Suomi','Kovakantinen','84.2'),('951907810X','Englantilais-Suomalainen suursanakirja',1183,1974,'Suomi','Kovakantinen','87.03'),('9780099571827','Faceless Killers',304,2011,'Englanti','Pehmeä kantinen','84.5'),('9780441172696','Dune Messiah',331,1969,'Suomi','Pehmeä kantinen','84.5'),('9789113146577','Innan frosten',421,2026,'Ruotsi','Pehmeä kantinen','84.3'),('9789113146584','Mannen som log',340,2026,'Ruotsi','Pehmeä kantinen','84.3'),('9789510343425','Muumit. Sarjakuvaklassikot I',95,2008,'Suomi','Kovakantinen','85.32'),('9789510354049','Muumit. Sarjakuvaklassikot II',86,2009,'Suomi','Kovakantinen','85.32'),('9789510392317','Hobitti',328,1937,'Suomi','Kovakantinen','84.2'),('9789511229254','Kiinalainen',685,2008,'Suomi','Kovakantinen','84.2'),('9789511229650','Totta',332,2010,'Suomi','Kovakantinen','84.2'),('9789511232407','Hippu',28,1967,'Suomi','Kovakantinen','86.11'),('9789511236009','Tuhat loistavaa aurinkoa',399,2007,'Suomi','Pehmeä kantinen','84.2'),('9789511291725','Ruotsalaiset saappaat',495,2015,'Suomi','Kovakantinen','84.2'),('9789511370123','Suomen eläimet',387,2021,'Suomi','Pehmeä kantinen','58.0'),('9789511384267','Hymyilevä mies',371,1994,'Suomi','Pehmeä kantinen','84.2'),('9789512057726','Suomi Saksa Suomi',1461,2008,'Suomi','Pehmeä kantinen','87.03'),('9789512085071','Raja',399,2006,'Suomi','Pehmeä kantinen','84.2'),('9789512405558','Suuri unikirja',535,1993,'Suomi','Pehmeä kantinen','15.92'),('9789512417209','Peloton synnytys',196,2009,'Suomi','Kovakantinen','59.57'),('9789513140045','Harry Potter ja kuoleman varjelukset',828,2007,'Suomi','Kovakantinen','84.2'),('9789519768687','Kiskomatta paras',56,2003,'Suomi','Pehmeä kantinen','67.45'),('9789520401948','Harry Potter ja puoliverinen prinssi',698,2005,'Suomi','Kovakantinen','84.2'),('9789523546585','Sinussa näen minut',391,2024,'Suomi','Kovakantinen','14.8'),('9789523703605','Miu ja tunteikas päivä',16,2023,'Suomi','Pahvisivuinen','86.11'),('9789524597333','Muumipappa ja meri',182,1965,'Suomi','Pehmeä kantinen','84.2'),('9789526550145','Pohjolan eläinsukat',95,2025,'Suomi','Kovakantinen','65.43');
/*!40000 ALTER TABLE `kirja` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `kirjailija`
--

DROP TABLE IF EXISTS `kirjailija`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `kirjailija` (
  `tunnus` char(10) NOT NULL,
  `enimi` varchar(15) DEFAULT NULL,
  `snimi` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`tunnus`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kirjailija`
--

LOCK TABLES `kirjailija` WRITE;
/*!40000 ALTER TABLE `kirjailija` DISABLE KEYS */;
INSERT INTO `kirjailija` VALUES ('KTAFBHOS01','Khaled','Hosseini'),('KTFIBHEL01','Susanna','Heli'),('KTFIBHUR01','Raija','Hurme'),('KTFIBIKO01','Inka','Ikonen'),('KTFIBJAN01','Tove','Jansson'),('KTFIBKAR01','Lumi','Karmitsa'),('KTFIBLAI01','Lasse J.','Laine'),('KTFIBLIN02','Väinö','Linna'),('KTFIBLIV01','Heidi','Livingston'),('KTFIBMAU01','Tamara','Maunonen'),('KTFIBPES01','Maritta','Pesonen'),('KTFIBPÖY01','Julia','Pöyhönen'),('KTFIBPUL01','Riikka','Pulkkinen'),('KTFIBREK01','Ilkka','Rekiaro'),('KTFIBTAN01','Oili','Tanninen'),('KTGBBROW01','J.K.','Rowling'),('KTGEBKLE01','Rolf','Klemmt'),('KTNOBRUG01','Turid','Rugaas'),('KTSAATOL01','J.R.R.','Tolkien'),('KTSEBLIN01','Astrid','Lindgren'),('KTSEBMAN01','Henning','Mankell'),('KTUSBCLA01','Tom','Clancy'),('KTUSBHER01','Frank','Herbert'),('KTUSBRUB01','Sheldon','Rubin');
/*!40000 ALTER TABLE `kirjailija` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `kokoelma`
--

DROP TABLE IF EXISTS `kokoelma`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `kokoelma` (
  `nide` varchar(15) NOT NULL,
  `kirjatun` varchar(13) DEFAULT NULL,
  `lainassa` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`nide`),
  KEY `kirjatun` (`kirjatun`),
  CONSTRAINT `kokoelma_ibfk_1` FOREIGN KEY (`kirjatun`) REFERENCES `kirja` (`kirjatunnus`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kokoelma`
--

LOCK TABLES `kokoelma` WRITE;
/*!40000 ALTER TABLE `kokoelma` DISABLE KEYS */;
INSERT INTO `kokoelma` VALUES ('000712381701','0007123817',1),('917133250201','9171332502',0),('951004078901','9510040789',1),('951013345001','9510133450',0),('951014439801','9510144398',0),('951014439802','9510144398',0),('951014443601','9510144436',1),('951014443602','9510144436',0),('951107978601','9511079786',0),('951120783001','9511207830',0),('951120783002','9511207830',1),('951311146601','9513111466',1),('951311146602','9513111466',0),('951311472401','9513114724',1),('951311472402','9513114724',0),('951311737501','9513117375',1),('951311737502','9513117375',0),('951312038401','9513120384',1),('951312038402','9513120384',0),('951313507101','9513135071',1),('951313507102','9513135071',0),('951643996901','9516439969',0),('951643996902','9516439969',0),('951643996903','9516439969',1),('951907810X01','951907810X',0),('978009957182701','9780099571827',0),('978044117269601','9780441172696',0),('978911314657701','9789113146577',0),('978911314658401','9789113146584',0),('978951034342501','9789510343425',NULL),('978951034342502','9789510343425',NULL),('978951035404901','9789510354049',NULL),('978951035404902','9789510354049',NULL),('978951039231701','9789510392317',0),('978951122925401','9789511229254',0),('978951122965001','9789511229650',0),('978951123240701','9789511232407',0),('978951123600901','9789511236009',0),('978951129172501','9789511291725',0),('978951137012301','9789511370123',0),('978951138426701','9789511384267',0),('978951205772601','9789512057726',0),('978951208507101','9789512085071',0),('978951240555801','9789512405558',0),('978951241720901','9789512417209',1),('978951314004501','9789513140045',1),('978951314004502','9789513140045',0),('978951976868701','9789519768687',0),('978952354658501','9789523546585',1),('978952370360501','9789523703605',0),('978952459733301','9789524597333',0),('978952459733302','9789524597333',0),('978952655014501','9789526550145',1),('978952655014502','9789526550145',NULL),('978952655014503','9789526550145',NULL);
/*!40000 ALTER TABLE `kokoelma` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lainaus`
--

DROP TABLE IF EXISTS `lainaus`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `lainaus` (
  `lainanumero` char(9) NOT NULL,
  `lainaaja` char(7) DEFAULT NULL,
  `pvm` date DEFAULT NULL,
  PRIMARY KEY (`lainanumero`),
  KEY `lainaaja` (`lainaaja`),
  CONSTRAINT `lainaus_ibfk_1` FOREIGN KEY (`lainaaja`) REFERENCES `asiakas` (`tunnus`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lainaus`
--

LOCK TABLES `lainaus` WRITE;
/*!40000 ALTER TABLE `lainaus` DISABLE KEYS */;
INSERT INTO `lainaus` VALUES ('LN2601001','AS02026','2026-01-02'),('LN2601002','AS01926','2026-01-02'),('LN2601003','AS01826','2026-01-02'),('LN2601004','AS01726','2026-01-03'),('LN2601005','AS01626','2026-01-04'),('LN2601006','AS01526','2026-01-05'),('LN2601007','AS01426','2026-01-05'),('LN2601008','AS01326','2026-01-07'),('LN2601009','AS01226','2026-01-07'),('LN2601010','AS01126','2026-01-08'),('LN2601011','AS01026','2026-01-09'),('LN2601012','AS00926','2026-01-09'),('LN2601013','AS00826','2026-01-10'),('LN2601014','AS00726','2026-01-10'),('LN2601015','AS00626','2026-01-10'),('LN2601016','AS00526','2026-01-10'),('LN2601017','AS00426','2026-01-11'),('LN2601018','AS00326','2026-01-12'),('LN2601019','AS00226','2026-01-13'),('LN2601020','AS00126','2026-01-13'),('LN2604001','AS02126','2026-04-13'),('LN2604002','AS02226','2026-04-15'),('LN2604003','AS02326','2026-04-20'),('LN2604004','AS02326','2026-04-22'),('LN2604005','AS02326','2026-04-22'),('LN2604006','AS02326','2026-04-22'),('LN2604007','AS02326','2026-04-22'),('LN2604008','AS02226','2026-04-24'),('LN2604009','AS02226','2026-04-24'),('LN2604010','AS02126','2026-04-24'),('LN2604011','AS00226','2026-04-27'),('LN2604012','AS01426','2026-05-07'),('LN2604013','AS01826','2026-05-07'),('LN2604014','AS00226','2026-05-07'),('LN2604015','AS00226','2026-05-11');
/*!40000 ALTER TABLE `lainaus` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lainausrivi`
--

DROP TABLE IF EXISTS `lainausrivi`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `lainausrivi` (
  `rivinro` int NOT NULL AUTO_INCREMENT,
  `lainanum` char(9) DEFAULT NULL,
  `koktun` varchar(15) DEFAULT NULL,
  `palpvm` date DEFAULT NULL,
  `palautettu` date DEFAULT NULL,
  PRIMARY KEY (`rivinro`),
  KEY `koktun` (`koktun`),
  KEY `lainanum` (`lainanum`),
  CONSTRAINT `lainausrivi_ibfk_1` FOREIGN KEY (`koktun`) REFERENCES `kokoelma` (`nide`),
  CONSTRAINT `lainausrivi_ibfk_2` FOREIGN KEY (`lainanum`) REFERENCES `lainaus` (`lainanumero`)
) ENGINE=InnoDB AUTO_INCREMENT=87 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lainausrivi`
--

LOCK TABLES `lainausrivi` WRITE;
/*!40000 ALTER TABLE `lainausrivi` DISABLE KEYS */;
INSERT INTO `lainausrivi` VALUES (1,'LN2601001','978951123240701','2026-01-16','2026-04-20'),(2,'LN2601001','978952370360501','2026-01-16','2026-04-20'),(3,'LN2601002','978951123600901','2026-01-17','2026-04-20'),(4,'LN2601003','951014443601','2026-01-18','2026-04-20'),(5,'LN2601004','978951241720901','2026-01-19','2026-04-20'),(6,'LN2601005','978951205772601','2026-01-20','2026-04-20'),(7,'LN2601006','951311146601','2026-01-20','2026-04-20'),(8,'LN2601006','951311472401','2026-01-20','2026-04-20'),(9,'LN2601007','951907810X01','2026-01-20','2026-04-20'),(10,'LN2601008','978952459733301','2026-01-22','2026-04-20'),(11,'LN2601009','978951976868701','2026-01-22','2026-04-20'),(12,'LN2601010','978044117269601','2026-01-23','2026-04-20'),(13,'LN2601011','951107978601','2026-01-24','2026-04-20'),(14,'LN2601012','951013345001','2026-01-24','2026-04-20'),(15,'LN2604001','951014443601','2026-04-27','2026-04-20'),(16,'LN2604001','978952459733301','2026-04-27','2026-04-20'),(17,'LN2604002','917133250201','2026-04-29','2026-04-20'),(18,'LN2604002','951004078901','2026-04-29','2026-04-20'),(19,'LN2604002','951013345001','2026-04-29','2026-04-20'),(20,'LN2604002','951014439802','2026-04-29','2026-04-20'),(21,'LN2604002','951014443602','2026-04-29','2026-04-20'),(22,'LN2604002','951107978601','2026-04-29','2026-04-20'),(23,'LN2604002','951120783001','2026-04-29','2026-04-20'),(24,'LN2604002','951120783002','2026-04-29','2026-04-20'),(25,'LN2604002','951311146601','2026-04-29','2026-04-20'),(26,'LN2604002','951311146602','2026-04-29','2026-04-20'),(27,'LN2604002','951311472401','2026-04-29','2026-04-20'),(28,'LN2604002','951311472402','2026-04-29','2026-04-20'),(29,'LN2604002','951311737501','2026-04-29','2026-04-20'),(30,'LN2604002','951311737502','2026-04-29','2026-04-20'),(31,'LN2604002','951312038401','2026-04-29','2026-04-20'),(32,'LN2604002','951312038402','2026-04-29','2026-04-20'),(33,'LN2604002','951313507101','2026-04-29','2026-04-20'),(34,'LN2604002','951313507102','2026-04-29','2026-04-20'),(35,'LN2604002','951643996901','2026-04-29','2026-04-20'),(36,'LN2604002','951643996902','2026-04-29','2026-04-20'),(37,'LN2604002','951643996903','2026-04-29','2026-04-20'),(38,'LN2604002','951907810X01','2026-04-29','2026-04-20'),(39,'LN2604002','978009957182701','2026-04-29','2026-04-20'),(40,'LN2604002','978044117269601','2026-04-29','2026-04-20'),(41,'LN2604002','978911314657701','2026-04-29','2026-04-20'),(42,'LN2604002','978911314658401','2026-04-29','2026-04-20'),(43,'LN2604002','978951039231701','2026-04-29','2026-04-20'),(44,'LN2604002','978951122925401','2026-04-29','2026-04-20'),(45,'LN2604002','978951122965001','2026-04-29','2026-04-20'),(46,'LN2604002','978951123240701','2026-04-29','2026-04-20'),(47,'LN2604002','978951123600901','2026-04-29','2026-04-20'),(48,'LN2604002','978951129172501','2026-04-29','2026-04-20'),(49,'LN2604002','978951137012301','2026-04-29','2026-04-20'),(50,'LN2604002','978951138426701','2026-04-29','2026-04-20'),(51,'LN2604002','978951205772601','2026-04-29','2026-04-20'),(52,'LN2604002','978951208507101','2026-04-29','2026-04-20'),(53,'LN2604002','978951240555801','2026-04-29','2026-04-20'),(54,'LN2604002','978951241720901','2026-04-29','2026-04-20'),(55,'LN2604002','978951314004501','2026-04-29','2026-04-20'),(56,'LN2604002','978951314004502','2026-04-29','2026-04-20'),(57,'LN2604002','978951976868701','2026-04-29','2026-04-20'),(58,'LN2604002','978952354658501','2026-04-29','2026-04-20'),(59,'LN2604002','978952370360501','2026-04-29','2026-04-20'),(60,'LN2604002','978952459733302','2026-04-29','2026-04-20'),(61,'LN2604003','917133250201','2026-05-04','2026-04-20'),(62,'LN2604004','951014439801','2026-05-06','2026-04-22'),(63,'LN2604004','951014443601','2026-05-06','2026-04-22'),(64,'LN2604005','951004078901','2026-05-06','2026-04-22'),(65,'LN2604005','978951123240701','2026-05-06','2026-04-22'),(66,'LN2604006','000712381701','2026-05-06','2026-04-22'),(67,'LN2604006','951013345001','2026-05-06','2026-04-22'),(68,'LN2604007','951004078901','2026-05-06',NULL),(69,'LN2604007','951014443601','2026-05-06',NULL),(70,'LN2604008','951311146601','2026-05-08',NULL),(71,'LN2604008','951311472401','2026-05-08',NULL),(72,'LN2604008','951311737501','2026-05-08',NULL),(73,'LN2604008','951312038401','2026-05-08',NULL),(74,'LN2604008','951313507101','2026-05-08',NULL),(75,'LN2604009','978951314004501','2026-05-08',NULL),(76,'LN2604010','951120783002','2026-05-08',NULL),(77,'LN2604010','951643996903','2026-05-08',NULL),(78,'LN2604011','951107978601','2026-05-11','2026-05-07'),(79,'LN2604011','978951137012301','2026-05-11','2026-05-07'),(80,'LN2604011','978951976868701','2026-05-11','2026-05-07'),(81,'LN2604012','000712381701','2026-05-21',NULL),(82,'LN2604013','978951241720901','2026-05-21',NULL),(83,'LN2604013','978952354658501','2026-05-21',NULL),(84,'LN2604014','951014439802','2026-05-21','2026-05-11'),(85,'LN2604014','978951123600901','2026-05-21','2026-05-11'),(86,'LN2604015','978952655014501','2026-05-25',NULL);
/*!40000 ALTER TABLE `lainausrivi` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `luokitus`
--

DROP TABLE IF EXISTS `luokitus`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `luokitus` (
  `ltun` char(5) NOT NULL,
  `kuvaus` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ltun`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `luokitus`
--

LOCK TABLES `luokitus` WRITE;
/*!40000 ALTER TABLE `luokitus` DISABLE KEYS */;
INSERT INTO `luokitus` VALUES ('14.8','Ihmissuhteiden psykologia'),('15.92','Unikirjat'),('58.0','Eläintiede'),('59.57','Gynekologia'),('65.43','Neulonta'),('67.45','Lemmikkieläinten hoito'),('84.2','Suomenkielinen kertomakirjallisuus'),('84.3','Pohjoismainen kertomakirjallisuus'),('84.5','Englanninkielinen kertomakirjallisuus'),('85.32','Suomenkieliset sarjakuvat'),('86.11','Lastenkirjat'),('87.03','Sanakirjat');
/*!40000 ALTER TABLE `luokitus` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tekijä`
--

DROP TABLE IF EXISTS `tekijä`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tekijä` (
  `rivinro` int NOT NULL AUTO_INCREMENT,
  `ktun` varchar(13) DEFAULT NULL,
  `kirtun` char(10) DEFAULT NULL,
  PRIMARY KEY (`rivinro`),
  KEY `ktun` (`ktun`),
  KEY `kirtun` (`kirtun`),
  CONSTRAINT `tekijä_ibfk_1` FOREIGN KEY (`ktun`) REFERENCES `kirja` (`kirjatunnus`),
  CONSTRAINT `tekijä_ibfk_2` FOREIGN KEY (`kirtun`) REFERENCES `kirjailija` (`tunnus`)
) ENGINE=InnoDB AUTO_INCREMENT=48 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tekijä`
--

LOCK TABLES `tekijä` WRITE;
/*!40000 ALTER TABLE `tekijä` DISABLE KEYS */;
INSERT INTO `tekijä` VALUES (1,'9789511232407','KTFIBTAN01'),(2,'9510144436','KTFIBJAN01'),(3,'9510144398','KTFIBJAN01'),(4,'9789524597333','KTFIBJAN01'),(5,'9513111466','KTGBBROW01'),(6,'9513114724','KTGBBROW01'),(7,'9513117375','KTGBBROW01'),(8,'9513120384','KTGBBROW01'),(9,'9513135071','KTGBBROW01'),(10,'9513135071','KTGBBROW01'),(11,'9789513140045','KTGBBROW01'),(12,'9510040789','KTSEBLIN01'),(13,'9789523546585','KTFIBIKO01'),(14,'9789512085071','KTFIBPUL01'),(15,'9789511229650','KTFIBPUL01'),(16,'9789511236009','KTAFBHOS01'),(17,'0007123817','KTSAATOL01'),(18,'9789510392317','KTSAATOL01'),(19,'9789512417209','KTFIBHEL01'),(20,'9171332502','KTUSBCLA01'),(21,'9789512405558','KTFIBMAU01'),(22,'9789511370123','KTFIBLAI01'),(23,'9510133450','KTFIBLIN02'),(24,'9511079786','KTUSBRUB01'),(25,'9780441172696','KTUSBHER01'),(26,'9789519768687','KTNOBRUG01'),(27,'951907810X','KTFIBHUR01'),(28,'951907810X','KTFIBPES01'),(29,'9789512057726','KTFIBREK01'),(30,'9789512057726','KTGEBKLE01'),(31,'9789523703605','KTFIBPÖY01'),(32,'9789523703605','KTFIBLIV01'),(33,'9789511229254','KTSEBMAN01'),(34,'9789113146577','KTSEBMAN01'),(35,'9789511384267','KTSEBMAN01'),(36,'9789511291725','KTSEBMAN01'),(37,'9511201158','KTSEBMAN01'),(38,'9789113146584','KTSEBMAN01'),(39,'9780099571827','KTSEBMAN01'),(40,'9780099571827','KTSEBMAN01'),(41,'9511207830','KTSEBMAN01'),(42,'9511207830','KTSEBMAN01'),(43,'9516439969','KTSEBMAN01'),(44,'9789510343425','KTFIBJAN01'),(45,'9789510354049','KTFIBJAN01'),(46,'9789526550145','KTFIBKAR01'),(47,'9789526550145','KTFIBKAR01');
/*!40000 ALTER TABLE `tekijä` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-11-11 11:37:36
