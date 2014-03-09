drop database testy;
SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

CREATE SCHEMA IF NOT EXISTS `testy` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci ;
USE `testy` ;

-- -----------------------------------------------------
-- Table `mydb`.`pracownicy`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `testy`.`pracownicy` (
  `id_pracownika` INT NOT NULL AUTO_INCREMENT,
  `Imie` VARCHAR(45) NULL,
  `Nazwisko` VARCHAR(45) NULL,
  PRIMARY KEY (`id_pracownika`))
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
