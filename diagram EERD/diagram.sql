SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

CREATE SCHEMA IF NOT EXISTS `mydb` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci ;
USE `mydb` ;

-- -----------------------------------------------------
-- Table `mydb`.`wydawnictwo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`wydawnictwo` (
  `idwydawnictwo` INT NOT NULL AUTO_INCREMENT,
  `nazwa_wyd` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idwydawnictwo`),
  UNIQUE INDEX `nazwa_wyd_UNIQUE` (`nazwa_wyd` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Gatunek`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Gatunek` (
  `idGatunek` INT NOT NULL AUTO_INCREMENT,
  `nazw_gat` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idGatunek`),
  UNIQUE INDEX `idGatunek_UNIQUE` (`idGatunek` ASC),
  UNIQUE INDEX `nazw_gat_UNIQUE` (`nazw_gat` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Ksiazka`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Ksiazka` (
  `idKsiazka` INT NOT NULL AUTO_INCREMENT,
  `idAutora` VARCHAR(45) NOT NULL,
  `tytul` VARCHAR(45) NOT NULL,
  `rok wydania` DATE NOT NULL,
  `wydawnictwo_idwydawnictwo` INT NOT NULL,
  `nr_ewidencyjny` VARCHAR(45) NOT NULL,
  `Gatunek_idGatunek` INT NOT NULL,
  PRIMARY KEY (`idKsiazka`),
  INDEX `fk_Ksiazka_wydawnictwo1_idx` (`wydawnictwo_idwydawnictwo` ASC),
  UNIQUE INDEX `nr_ewidencyjny_UNIQUE` (`nr_ewidencyjny` ASC),
  INDEX `fk_Ksiazka_Gatunek1_idx` (`Gatunek_idGatunek` ASC),
  CONSTRAINT `fk_Ksiazka_wydawnictwo1`
    FOREIGN KEY (`wydawnictwo_idwydawnictwo`)
    REFERENCES `mydb`.`wydawnictwo` (`idwydawnictwo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Ksiazka_Gatunek1`
    FOREIGN KEY (`Gatunek_idGatunek`)
    REFERENCES `mydb`.`Gatunek` (`idGatunek`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Autor`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Autor` (
  `idAutor` INT NOT NULL AUTO_INCREMENT,
  `Imie` VARCHAR(45) NULL,
  `Nazwisko` VARCHAR(45) NULL,
  PRIMARY KEY (`idAutor`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Autor_has_Ksiazka`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Autor_has_Ksiazka` (
  `Autor_idAutor` INT NOT NULL,
  `Ksiazka_idKsiazka` INT NOT NULL,
  PRIMARY KEY (`Autor_idAutor`, `Ksiazka_idKsiazka`),
  INDEX `fk_Autor_has_Ksiażka_Ksiażka1_idx` (`Ksiazka_idKsiazka` ASC),
  INDEX `fk_Autor_has_Ksiażka_Autor1_idx` (`Autor_idAutor` ASC),
  CONSTRAINT `fk_Autor_has_Ksiażka_Autor1`
    FOREIGN KEY (`Autor_idAutor`)
    REFERENCES `mydb`.`Autor` (`idAutor`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Autor_has_Ksiażka_Ksiażka1`
    FOREIGN KEY (`Ksiazka_idKsiazka`)
    REFERENCES `mydb`.`Ksiazka` (`idKsiazka`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Kod`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Kod` (
  `idKod` INT NOT NULL AUTO_INCREMENT,
  `kod` VARCHAR(45) NOT NULL,
  `miejscowosc` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idKod`),
  UNIQUE INDEX `kod_UNIQUE` (`kod` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Ulica`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Ulica` (
  `idUlica` INT NOT NULL AUTO_INCREMENT,
  `nazwa` VARCHAR(45) NOT NULL,
  `Kod_idKod` INT NOT NULL,
  PRIMARY KEY (`idUlica`),
  INDEX `fk_Ulica_Kod1_idx` (`Kod_idKod` ASC),
  CONSTRAINT `fk_Ulica_Kod1`
    FOREIGN KEY (`Kod_idKod`)
    REFERENCES `mydb`.`Kod` (`idKod`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Czytelnik`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Czytelnik` (
  `idCzytelnik` INT NOT NULL AUTO_INCREMENT,
  `imie` VARCHAR(45) NOT NULL,
  `nazwisko` VARCHAR(45) NOT NULL,
  `nazwa_urzytkownika` VARCHAR(45) NULL,
  `nr_budynku` VARCHAR(45) NOT NULL,
  `nr_mieszkania` VARCHAR(45) NULL,
  `telefon_kont` VARCHAR(45) NULL,
  `email` VARCHAR(45) NULL,
  `Ulica_idUlica` INT NOT NULL,
  `PESEL` VARCHAR(11) NULL,
  PRIMARY KEY (`idCzytelnik`),
  INDEX `fk_Czytelnik_Ulica1_idx` (`Ulica_idUlica` ASC),
  CONSTRAINT `fk_Czytelnik_Ulica1`
    FOREIGN KEY (`Ulica_idUlica`)
    REFERENCES `mydb`.`Ulica` (`idUlica`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Pracownik`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Pracownik` (
  `idPracownik` INT NOT NULL AUTO_INCREMENT,
  `imie` VARCHAR(45) NOT NULL,
  `nazwisko` VARCHAR(45) NOT NULL,
  `Ulica_idUlica` INT NOT NULL,
  `nr_budynku` VARCHAR(45) NOT NULL,
  `nr_miaszkania` VARCHAR(45) NULL,
  `telefon_kont` VARCHAR(45) NULL,
  `email` VARCHAR(45) NULL,
  `PESEL` VARCHAR(11) NULL,
  PRIMARY KEY (`idPracownik`, `Ulica_idUlica`),
  INDEX `fk_Pracownik_Ulica1_idx` (`Ulica_idUlica` ASC),
  CONSTRAINT `fk_Pracownik_Ulica1`
    FOREIGN KEY (`Ulica_idUlica`)
    REFERENCES `mydb`.`Ulica` (`idUlica`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Wypozyczone`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Wypozyczone` (
  `idWypozyczone` INT NOT NULL AUTO_INCREMENT,
  `data_wypozyczenia` DATE NOT NULL,
  `idKsiazka` INT NOT NULL,
  `idCzytelnik` INT NOT NULL,
  `idPracownik` INT NOT NULL,
  INDEX `idKsiazka_idx` (`idKsiazka` ASC),
  INDEX `idCzytelnik_idx` (`idCzytelnik` ASC),
  INDEX `idPracownik_idx` (`idPracownik` ASC),
  UNIQUE INDEX `idKsiazka_UNIQUE` (`idKsiazka` ASC),
  PRIMARY KEY (`idWypozyczone`),
  CONSTRAINT `idKsiazka`
    FOREIGN KEY (`idKsiazka`)
    REFERENCES `mydb`.`Ksiazka` (`idKsiazka`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `idCzytelnik`
    FOREIGN KEY (`idCzytelnik`)
    REFERENCES `mydb`.`Czytelnik` (`idCzytelnik`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `idPracownik`
    FOREIGN KEY (`idPracownik`)
    REFERENCES `mydb`.`Pracownik` (`idPracownik`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Rezerwacja`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Rezerwacja` (
  `idRezerwacja` INT NOT NULL AUTO_INCREMENT,
  `rezerwacja_od` DATETIME NULL,
  `rezerwacja_do` DATETIME NULL,
  `Ksiazka_idKsiazka` INT NOT NULL,
  `nr_kolejka` INT NOT NULL,
  `Czytelnik_idCzytelnik` INT NOT NULL,
  PRIMARY KEY (`idRezerwacja`),
  INDEX `fk_Rezerwacja_Ksiazka1_idx` (`Ksiazka_idKsiazka` ASC),
  INDEX `fk_Rezerwacja_Czytelnik1_idx` (`Czytelnik_idCzytelnik` ASC),
  CONSTRAINT `fk_Rezerwacja_Ksiazka1`
    FOREIGN KEY (`Ksiazka_idKsiazka`)
    REFERENCES `mydb`.`Ksiazka` (`idKsiazka`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Rezerwacja_Czytelnik1`
    FOREIGN KEY (`Czytelnik_idCzytelnik`)
    REFERENCES `mydb`.`Czytelnik` (`idCzytelnik`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Historia_Wpozyczen`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Historia_Wpozyczen` (
  `idHistoria_Wpozyczen` INT NOT NULL AUTO_INCREMENT,
  `Ksiazka_idKsiazka` INT NOT NULL,
  `wypozyczona_od` DATE NOT NULL,
  `wypozyczona_do` DATE NOT NULL,
  `Czytelnik_idCzytelnik` INT NOT NULL,
  PRIMARY KEY (`idHistoria_Wpozyczen`),
  INDEX `fk_Historia_Wpozyczen_Ksiazka1_idx` (`Ksiazka_idKsiazka` ASC),
  INDEX `fk_Historia_Wpozyczen_Czytelnik1_idx` (`Czytelnik_idCzytelnik` ASC),
  CONSTRAINT `fk_Historia_Wpozyczen_Ksiazka1`
    FOREIGN KEY (`Ksiazka_idKsiazka`)
    REFERENCES `mydb`.`Ksiazka` (`idKsiazka`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Historia_Wpozyczen_Czytelnik1`
    FOREIGN KEY (`Czytelnik_idCzytelnik`)
    REFERENCES `mydb`.`Czytelnik` (`idCzytelnik`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
