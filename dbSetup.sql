CREATE TABLE IF NOT EXISTS accounts(
  id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name varchar(255) COMMENT 'User Name',
  email varchar(255) COMMENT 'User Email',
  picture varchar(255) COMMENT 'User Picture'
) default charset utf8mb4 COMMENT '';

CREATE TABLE IF NOT EXISTS cars(
  id INT NOT NULL PRIMARY KEY AUTO_INCREMENT COMMENT 'primary key',
  make VARCHAR(255) NOT NULL,
  model VARCHAR(255) NOT NULL,
  price MEDIUMINT NOT NULL,
  year SMALLINT NOT NULL DEFAULT 1990,
  hasTires BOOLEAN NOT NULL DEFAULT true,
  createdAt DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  updatedAt DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  color VARCHAR(8) DEFAULT '#FFFFFF'
) default charset utf8mb4 COMMENT 'emojis enabled 🦞';

CREATE TABLE IF NOT EXISTS houses(
  id INT NOT NULL PRIMARY KEY AUTO_INCREMENT COMMENT 'Primary Key',
  levels TINYINT NOT NULL,
  bedrooms TINYINT NOT NULL,
  bathrooms TINYINT NOT NULL,
  price INT NOT NULL,
  description VARCHAR(255) NOT NULL,
  imgUrl VARCHAR(500) NOT NULL
) default charset utf8mb4 COMMENT 'emojis enabled 🦞';

CREATE TABLE IF NOT EXISTS jobs(
  id INT NOT NULL PRIMARY KEY AUTO_INCREMENT COMMENT 'Primary Key',
  title VARCHAR(255) NOT NULL,
  description VARCHAR(255) NOT NULL,
  rate INT NOT NULL,
  company VARCHAR(255) NOT NULL,
  createdAt DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  updatedAt DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) default charset utf8mb4 COMMENT 'emojis enabled 🦞';


INSERT INTO houses(levels, bedrooms, bathrooms, price, description, imgUrl)
values(2, 4, 3, 500000, "It's a bigger house'", "https://images.unsplash.com/photo-1577495508326-19a1b3cf65b7?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=2274&q=80");

INSERT INTO cars(make, model, price, year, hasTires, color)
values('mazda', 'miata', 5000, 2005, true, DEFAULT) ;

INSERT INTO cars(make, model, price, year, hasTires)
values
('mazda', 'miata', 5000, 2005, true), 
('subaru', 'impreza', 13000, 2013, true);

INSERT INTO jobs(title, description, rate, company)
values('worker bee', 'making honey', 10, 'the hive'),
('lifeguard', 'saving lives', 20, 'the pool'),
('fireman', 'putting out fires', 75, 'burning places');

SELECT * FROM cars ORDER BY price DESC LIMIT 1;

SELECT * FROM cars WHERE make = 'mazda' AND model = 'miata';

SELECT * FROM cars WHERE id = 4;

UPDATE cars
SET 
model = 'rx-7', 
color = '#000000' 
WHERE id = 4;

DELETE FROM cars WHERE id = 1 ;

DROP TABLE jobs;