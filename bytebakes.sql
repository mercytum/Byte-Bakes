-- Database: 'ByteBakes'


-- Create Tables for the ByteBakes Database 

-- Admin Table
CREATE TABLE 'admin' (
  'AdminID' INT NOT NULL,
  'FirstName' VARCHAR(45) NOT NULL,
  'LastName' VARCHAR(45) NOT NULL,
  'Username' VARCHAR(45) NOT NULL,
  'Password' VARCHAR(45) NOT NULL,
  'Phone' VARCHAR(45) NOT NULL,
  'Email' VARCHAR(45) NOT NULL,
    PRIMARY KEY('AdminID'),
      ON DELETE CASCADE,
      ON UPDATE NO ACTION);



-- Customer Table
CREATE TABLE 'customer' (
  'CustomerID' INT NOT NULL,
  'FirstName' VARCHAR(45) NOT NULL,
  'LastName' VARCHAR(45) NOT NULL,
  'Username' VARCHAR(45) NOT NULL,
  'Password' VARCHAR(45) NOT NULL,
  'Phone' VARCHAR(45) NOT NULL,
  'Email' VARCHAR(45) NOT NULL,
    PRIMARY KEY('CustomerID'),
      ON DELETE CASCADE
      ON UPDATE NO ACTION);




-- Orders Table
CREATE TABLE 'orders' (
  'OrderID' INT NOT NULL,
  'OrderNo' INT NOT NULL,
  'CustomerID' INT NOT NULL, 
    PRIMARY KEY('OrderID'),
    FOREIGN KEY('CustomerID') REFERENCES 'customer'('CustomerID'),
      ON DELETE CASCADE
      ON UPDATE NO ACTION);


-- Categories Table
CREATE TABLE 'categories' (
  'CategoryID' INT NOT NULL,
  'CategoryName' VARCHAR(45) NOT NULL,
  UNIQUE INDEX 'CategoryName_UNIQUE'('CategoryName' ASC) VISIBLE,
  PRIMARY KEY('CategoryID');


-- Flour Table
CREATE TABLE 'flour'(
  'FlourID' INT NOT NULL,
  'FlourName' VARCHAR(45) NOT NULL,
  'FlourCalories' INT NOT NULL,
  UNIQUE INDEX 'FlourName_UNIQUE'('FlourName' ASC) VISIBLE,
  PRIMARY KEY('FlourID');



-- Sugar Table
CREATE TABLE 'sugar'(
  'SugarID' INT NOT NULL,
  'SugarName' VARCHAR(45) NOT NULL,
  'SugarCalories' INT NOT NULL,
  UNIQUE INDEX 'SugarName_UNIQUE'('SugarName' ASC) VISIBLE,
  PRIMARY KEY('SugarID');


--Milk Table
CREATE TABLE 'milk'(
  'MilkID' INT NOT NULL,
  'MilkName' VARCHAR(45) NOT NULL,
  'MilkCalories' INT NOT NULL,
  UNIQUE INDEX 'MilkName_UNIQUE'('MilkName' ASC) VISIBLE,
  PRIMARY KEY('MilkID');


--Frosting Table
CREATE TABLE 'frosting'(
  'FrostingID' INT NOT NULL,
  'FrostingName' VARCHAR(45) NOT NULL,
  'FrostingCalories' INT NOT NULL,
  UNIQUE INDEX 'FrostingName_UNIQUE'('FrostingName' ASC) VISIBLE,
  PRIMARY KEY('FrostingID');


--Butter Table
CREATE TABLE 'butter'(
  'ButterID' INT NOT NULL,
  'ButterName' VARCHAR(45) NOT NULL,
  'ButterCalories' INT NOT NULL,
  UNIQUE INDEX 'ButterName_UNIQUE'('ButterName' ASC) VISIBLE,
  PRIMARY KEY('ButterID');


-- Products Table
CREATE TABLE 'products'(
  'ProductID' INT NOT NULL,
  'CategoryID'  INT NOT NULL,
  'ProductName' VARCHAR(45) NOT NULL,
  'Description' TEXT NOT NULL,
-- Use ID's to get Calorie information
  'MilkID' INT NOT NULL,
  'FlourID' INT NOT NULL,
  'SugarID' INT NOT NULL,
  'ButterID' INT NOT NULL,
  'FrostingID' INT NOT NULL,
  'Price' MONEY NOT NULL, 
  'Qty' INT NOT NULL, 
  UNIQUE INDEX 'ProductName_UNIQUE'('ProductName' ASC) VISIBLE,
  PRIMARY KEY('ProductID'),
  CONSTRAINT 'CategoryID'
    FOREIGN KEY('CategoryID')
    REFERENCES 'categories' ('CategoryID'),
  CONSTRAINT 'MilkID'
    FOREIGN KEY('MilkID')
    REFERENCES 'milk' ('MilkID'),
  CONSTRAINT 'SugarID'
    FOREIGN KEY('SugarID')
    REFERENCES 'sugar' ('SugarID'),
  CONSTRAINT 'FlourID'
    FOREIGN KEY('FlourID')
    REFERENCES 'flour' ('FlourID'),
  CONSTRAINT 'ButterID'
    FOREIGN KEY('ButterID')
    REFERENCES 'butter' ('ButterID'),
  CONSTRAINT 'FrostingID'
    FOREIGN KEY('FrostingID')
    REFERENCES 'frosting' ('FrostingID');



-- Input an Admin into the Admin Table
SELECT * FROM admin;
INSERT INTO 'admin' ('AdminID', 'FirstName', 'LastName', 'Username', 'Password', 'Phone', 'Email') VALUES ('1', 'Erika', 'Valle-Baird', 'Airikuh', '123Happy', '7341234567', 'airikuh@umich.edu');

-- Input a Customer into the Customer Table
SELECT * FROM customer;
INSERT INTO 'customer' ('CustomerID', 'FirstName', 'LastName', 'Username', 'Password', 'Phone', 'Email') VALUES ('1', 'John', 'Doe', 'Johnny', 'Sunshine123', '7341234567', 'j.doe@gmail.com');


-- Create the Categories
SELECT * FROM categories;
INSERT INTO 'categories'('CategoryID', 'CategoryName') VALUES ('1', 'Bread');
INSERT INTO 'categories'('CategoryID', 'CategoryName') VALUES ('2', 'Cake');
INSERT INTO 'categories'('CategoryID', 'CategoryName') VALUES ('3', 'Pastry');
INSERT INTO 'categories'('CategoryID', 'CategoryName') VALUES ('4', 'Sweet');


SELECT * FROM flour;
INSERT INTO 'flour'('FlourID', 'FlourName', 'FlourCalories') VALUES ('1', 'All-Purpose', '455');
INSERT INTO 'flour'('FlourID', 'FlourName', 'FlourCalories') VALUES ('2', 'Almond', '180');
INSERT INTO 'flour'('FlourID', 'FlourName', 'FlourCalories') VALUES ('3', 'Gluten Free', '100');
INSERT INTO 'flour'('FlourID', 'FlourName', 'FlourCalories') VALUES ('4', 'Cake', '455');


SELECT * FROM sugar;
INSERT INTO 'sugar'('SugarID', 'SugarName', 'SugarCalories') VALUES ('1', 'Cane', '9');
INSERT INTO 'sugar'('SugarID', 'SugarName', 'SugarCalories') VALUES ('2', 'Truvia', '0');
INSERT INTO 'sugar'('SugarID', 'SugarName', 'SugarCalories') VALUES ('3', 'Coconut', '48');
INSERT INTO 'sugar'('SugarID', 'SugarName', 'SugarCalories') VALUES ('4', 'Granulated', '60');



SELECT * FROM milk;
INSERT INTO 'milk'('MilkID', 'MilkName', 'MilkCalories') VALUES ('1', 'Whole', '152');
INSERT INTO 'milk'('MilkID', 'MilkName', 'MilkCalories') VALUES ('2', 'Almond', '39');
INSERT INTO 'milk'('MilkID', 'MilkName', 'MilkCalories') VALUES ('3', 'Oat', '120');
INSERT INTO 'milk'('MilkID', 'MilkName', 'MilkCalories') VALUES ('4', 'Soy', '131');


SELECT * FROM frosting;
INSERT INTO 'frosting'('FrostingID', 'FrostingName', 'FrostingCalories') VALUES ('1', 'None', '0');
INSERT INTO 'frosting'('FrostingID', 'FrostingName', 'FrostingCalories') VALUES ('2', 'Buttercream', '140');
INSERT INTO 'frosting'('FrostingID', 'FrostingName', 'FrostingCalories') VALUES ('3', 'Whipped', '110');
INSERT INTO 'frosting'('FrostingID', 'FrostingName', 'FrostingCalories') VALUES ('4', 'Cream Cheese', '68');




SELECT * FROM butter;
INSERT INTO 'butter'('ButterID', 'ButterName', 'ButterCalories') VALUES ('1', 'Crisco', '110');
INSERT INTO 'butter'('ButterID', 'ButterName', 'ButterCalories') VALUES ('2', 'Salted', '102');
INSERT INTO 'butter'('ButterID', 'ButterName', 'ButterCalories') VALUES ('3', 'Unsalted', '102');
