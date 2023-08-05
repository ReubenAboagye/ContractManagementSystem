USE gaayanenterprise;

-- creating a user table
CREATE TABLE users(
user_id INT AUTO_INCREMENT PRIMARY KEY,
username VARCHAR(20) NOT NULL,
salt VARCHAR(64) NOT NULL,
user_role VARCHAR(10) DEFAULT 'UNASSIGNED',
hashed_password VARCHAR(64) NOT NULL
);



-- *************************************************
 select * from users;
 USE gaayanenterprise;
 
 -- CREATING EMPLOYEE TABLE
	CREATE TABLE Employee(
    emp_id INT AUTO_INCREMENT PRIMARY KEY,
    emp_name VARCHAR(50) NOT NULL,
    emp_address VARCHAR(20) NOT NULL,
    emp_position VARCHAR(25) DEFAULT "Employee",
    department VARCHAR(30)
    );
    
