SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

CREATE SCHEMA IF NOT EXISTS `Database` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci ;
USE `Database` ;

-- -----------------------------------------------------
-- Table `Database`.`movies`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Database`.`movies` (
  `movie_id` INT NOT NULL AUTO_INCREMENT ,
  `title` VARCHAR(100) NOT NULL ,
  `title_display` VARCHAR(45) NOT NULL ,
  `year` YEAR NULL ,
  `mpaa` VARCHAR(8) NULL DEFAULT NULL ,
  `minutes` INT NULL DEFAULT NULL ,
  `ave_rate` DECIMAL(4,2) NULL DEFAULT NULL ,
  `synopsis` VARCHAR(4500) NULL DEFAULT NULL ,
  PRIMARY KEY (`movie_id`) ,
  UNIQUE INDEX `movie_id_UNIQUE` (`movie_id` ASC) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Database`.`directors`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Database`.`directors` (
  `director_id` INT NOT NULL AUTO_INCREMENT ,
  `name` VARCHAR(100) NOT NULL ,
  PRIMARY KEY (`director_id`) ,
  UNIQUE INDEX `director_id_UNIQUE` (`director_id` ASC) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Database`.`cast`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Database`.`cast` (
  `cast_id` INT NOT NULL ,
  `name` VARCHAR(45) NOT NULL ,
  PRIMARY KEY (`cast_id`) ,
  UNIQUE INDEX `cast_id_UNIQUE` (`cast_id` ASC) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Database`.`tags`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Database`.`tags` (
  `tag` VARCHAR(40) NOT NULL ,
  PRIMARY KEY (`tag`) ,
  UNIQUE INDEX `tag_UNIQUE` (`tag` ASC) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Database`.`user`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Database`.`user` (
  `username` VARCHAR(50) NOT NULL ,
  `name` VARCHAR(45) NULL DEFAULT NULL ,
  PRIMARY KEY (`username`) ,
  UNIQUE INDEX `username_UNIQUE` (`username` ASC) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Database`.`movies_has_cast`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Database`.`movies_has_cast` (
  `movies_movie_id` INT NOT NULL ,
  `cast_cast_id` INT NOT NULL ,
  PRIMARY KEY (`movies_movie_id`, `cast_cast_id`) ,
  INDEX `fk_movies_has_cast_cast1_idx` (`cast_cast_id` ASC) ,
  INDEX `fk_movies_has_cast_movies_idx` (`movies_movie_id` ASC) ,
  CONSTRAINT `fk_movies_has_cast_movies`
    FOREIGN KEY (`movies_movie_id` )
    REFERENCES `Database`.`movies` (`movie_id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_movies_has_cast_cast1`
    FOREIGN KEY (`cast_cast_id` )
    REFERENCES `Database`.`cast` (`cast_id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Database`.`movies_has_directors`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Database`.`movies_has_directors` (
  `movies_movie_id` INT NOT NULL ,
  `directors_director_id` INT NOT NULL ,
  PRIMARY KEY (`movies_movie_id`, `directors_director_id`) ,
  INDEX `fk_movies_has_directors_directors1_idx` (`directors_director_id` ASC) ,
  INDEX `fk_movies_has_directors_movies1_idx` (`movies_movie_id` ASC) ,
  CONSTRAINT `fk_movies_has_directors_movies1`
    FOREIGN KEY (`movies_movie_id` )
    REFERENCES `Database`.`movies` (`movie_id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_movies_has_directors_directors1`
    FOREIGN KEY (`directors_director_id` )
    REFERENCES `Database`.`directors` (`director_id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Database`.`movies_has_tags`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Database`.`movies_has_tags` (
  `movies_movie_id` INT NOT NULL ,
  `tags_tag` VARCHAR(40) NOT NULL ,
  PRIMARY KEY (`movies_movie_id`, `tags_tag`) ,
  INDEX `fk_movies_has_tags_tags1_idx` (`tags_tag` ASC) ,
  INDEX `fk_movies_has_tags_movies1_idx` (`movies_movie_id` ASC) ,
  CONSTRAINT `fk_movies_has_tags_movies1`
    FOREIGN KEY (`movies_movie_id` )
    REFERENCES `Database`.`movies` (`movie_id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_movies_has_tags_tags1`
    FOREIGN KEY (`tags_tag` )
    REFERENCES `Database`.`tags` (`tag` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Database`.`user_has_movies`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Database`.`user_has_movies` (
  `movies_movie_id` INT NOT NULL ,
  `user_username` VARCHAR(50) NOT NULL ,
  `rating` DECIMAL(4,2) NULL DEFAULT NULL ,
  `watched` TINYINT(1) NULL DEFAULT FALSE ,
  `date_added` DATE NULL ,
  `redownoad` TINYINT(1) NULL DEFAULT FALSE ,
  `notes` VARCHAR(255) NULL DEFAULT NULL ,
  PRIMARY KEY (`movies_movie_id`, `user_username`) ,
  INDEX `fk_movies_has_user_user1_idx` (`user_username` ASC) ,
  INDEX `fk_movies_has_user_movies1_idx` (`movies_movie_id` ASC) ,
  CONSTRAINT `fk_movies_has_user_movies1`
    FOREIGN KEY (`movies_movie_id` )
    REFERENCES `Database`.`movies` (`movie_id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_movies_has_user_user1`
    FOREIGN KEY (`user_username` )
    REFERENCES `Database`.`user` (`username` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Database`.`genre`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Database`.`genre` (
  `genre` VARCHAR(45) NOT NULL ,
  PRIMARY KEY (`genre`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Database`.`movies_has_genre`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Database`.`movies_has_genre` (
  `movies_movie_id` INT NOT NULL ,
  `genre_genre` VARCHAR(45) NOT NULL ,
  PRIMARY KEY (`movies_movie_id`, `genre_genre`) ,
  INDEX `fk_movies_has_genre_genre1_idx` (`genre_genre` ASC) ,
  INDEX `fk_movies_has_genre_movies1_idx` (`movies_movie_id` ASC) ,
  CONSTRAINT `fk_movies_has_genre_movies1`
    FOREIGN KEY (`movies_movie_id` )
    REFERENCES `Database`.`movies` (`movie_id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_movies_has_genre_genre1`
    FOREIGN KEY (`genre_genre` )
    REFERENCES `Database`.`genre` (`genre` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;



SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
