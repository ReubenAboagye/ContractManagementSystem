USE gaayanenterprise;

-- creating a user table
CREATE TABLE users(
user_id INT AUTO_INCREMENT PRIMARY KEY,
username VARCHAR(20) NOT NULL,
salt VARCHAR(64) NOT NULL,
hashed_password VARCHAR(64) NOT NULL
);



-- *************************************************
 select username from users;
 USE gaayanenterprise;
 
 -- CREATING EMPLOYEE TABLE
	CREATE TABLE Employee(
    emp_id INT AUTO_INCREMENT PRIMARY KEY,
    emp_name VARCHAR(50) NOT NULL,
    emp_address VARCHAR(20) NOT NULL,
    emp_position VARCHAR(25) DEFAULT "Employee",
    department VARCHAR(30)
    );
    use gaayanenterprise;
-- CREATING  SALES TABLE
CREATE TABLE customer(
cus_id INT AUTO_INCREMENT PRIMARY KEY,
cus_name VARCHAR(50) NOT NULL,
cus_contact VARCHAR(20),
cus_address VARCHAR(50)
);

-- CREATING PAYMENT TABLE
CREATE TABLE payment(
pay_id INT AUTO_INCREMENT PRIMARY KEY,
pay_amount FLOAT NOT NULL,
pay_date DATETIME,
notes VARCHAR(100),
cus_id INT,
CONSTRAINT cus_payment FOREIGN KEY (cus_id) REFERENCES customer(cus_id)
);

-- CREATING THE SUPPLIER TABLE
CREATE TABLE supplier(
sup_id INT AUTO_INCREMENT PRIMARY KEY,
sup_name VARCHAR(50) NOT NULL,
sup_number VARCHAR(20) NOT NULL,
sup_address VARCHAR(50)
);

-- CREATING PRODUCT TABLE
CREATE TABLE product(
prod_id INT AUTO_INCREMENT PRIMARY KEY,
sup_id INT,
prod_desc VARCHAR(250),
prod_price FLOAT NOT NULL,
prod_qty INT,
prod_category VARCHAR(50),
prod_stock_date DATE NOT NULL,
notes VARCHAR(250),
CONSTRAINT sup_prod FOREIGN KEY (sup_id) REFERENCES supplier(sup_id)
);

-- CREATING ORDER TABLE
CREATE TABLE orders(
ord_id INT,
ord_date DATETIME,
prod_id INT,
ord_quantity INT,
CONSTRAINT prod_ord FOREIGN KEY (prod_id) REFERENCES product(prod_id)
);
alter table orders
add pa
