USE pandabudget;
CREATE TABLE pandabudget.files_path (
  `INDEX` decimal(10, 0) NOT NULL DEFAULT 0,
  files_path_INDEX decimal(10, 0) NOT NULL DEFAULT 0,
  files_path_name varchar(255) NOT NULL DEFAULT '',
  FILES_PATH_ITEMS_CATEGORY varchar(255) NOT NULL DEFAULT '',
  PRIMARY KEY (`INDEX`)
)
ENGINE = INNODB,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_0900_ai_ci;

CREATE TABLE pandabudget.items (
  `INDEX` int NOT NULL AUTO_INCREMENT,
  items_INDEX decimal(10, 0) NOT NULL DEFAULT 0,
  items_projet_INDEX decimal(10, 0) NOT NULL DEFAULT 0,
  items_code varchar(255) NOT NULL DEFAULT '',
  items_name varchar(255) NOT NULL DEFAULT '',
  items_parent varchar(255) NOT NULL DEFAULT '',
  items_quantity decimal(10, 0) NOT NULL DEFAULT 1,
  items_unit decimal(10, 0) NOT NULL DEFAULT 1,
  items_price_total decimal(12, 2) NOT NULL DEFAULT 0.00,
  items_taxe decimal(12, 2) NOT NULL DEFAULT 20.00,
  items_taxe_value decimal(12, 2) NOT NULL DEFAULT 0.00,
  items_currency varchar(255) NOT NULL DEFAULT '',
  items_last_edit_date date DEFAULT '1900-01-01',
  PRIMARY KEY (`INDEX`)
)
ENGINE = INNODB,
AUTO_INCREMENT = 3,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_0900_ai_ci;

CREATE TABLE pandabudget.project (
  `INDEX` int NOT NULL AUTO_INCREMENT,
  PrOJECT_INDEX decimal(10, 0) NOT NULL DEFAULT 0,
  PrOJECT_CODE varchar(255) DEFAULT '',
  PrOJECT_NAME varchar(255) DEFAULT '',
  PrOJECT_CREAT_DATE date DEFAULT '1900-01-01',
  PrOJECT_STATUS varchar(255) DEFAULT '',
  PRIMARY KEY (`INDEX`)
)
ENGINE = INNODB,
AUTO_INCREMENT = 6,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_0900_ai_ci;