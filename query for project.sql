USE gaayanenterprise;

-- creating a user table
CREATE TABLE users(
user_id INT AUTO_INCREMENT PRIMARY KEY,
username VARCHAR(20) NOT NULL,
salt VARCHAR(64) NOT NULL,
hashed_password VARCHAR(64) NOT NULL
);

-- stored procedure for inserting into users table
DELIMITER //
CREATE PROCEDURE insert_user(IN p_username VARCHAR(20), IN p_salt VARCHAR(64), IN p_hashed_password VARCHAR(64))
BEGIN
    INSERT INTO users(username, salt, hashed_password)
    VALUES (p_username, p_salt, p_hashed_password);
END //
DELIMITER ;

-- STORED PROCEDURE FOR UPDATING USERS TABLE
DELIMITER //
CREATE PROCEDURE update_user(IN p_user_id INT, IN p_username VARCHAR(20), IN p_salt VARCHAR(64), IN p_hashed_password VARCHAR(64))
BEGIN
    UPDATE users
    SET username = p_username,
        salt = p_salt,
        hashed_password = p_hashed_password
    WHERE user_id = p_user_id;
END //
DELIMITER ;

-- STORED PROCEDURE FOR DELETING USERS TABLE
DELIMITER //
CREATE PROCEDURE delete_user(IN p_user_id INT)
BEGIN
    DELETE FROM users
    WHERE user_id = p_user_id;
END //
DELIMITER ;

-- SELECTING RECORDS BY USERNAME
DELIMITER //
CREATE PROCEDURE select_user_by_username(IN p_username VARCHAR(20))
BEGIN
    SELECT * FROM users
    WHERE username = p_username;
END //
DELIMITER ;

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
    
-- stored procedure for deleting into employee table
DELIMITER //
CREATE PROCEDURE delete_employee(IN p_id INT)
BEGIN
    DELETE FROM Employee
    WHERE emp_id = p_id;
END //
DELIMITER ;

-- creating procedure for inserting employee
DELIMITER //
CREATE PROCEDURE insert_employee(IN p_name VARCHAR(50), IN p_address VARCHAR(20), IN p_position VARCHAR(25), IN p_department VARCHAR(30))
BEGIN
    INSERT INTO users(emp_name, emp_address, emp_position, department)
    VALUES (p_name, p_address, p_position, p_department);
END //
DELIMITER ;


-- creating procedure for updating employee
CREATE PROCEDURE update_employee(IN p_id INT, IN p_name VARCHAR(50), IN p_address VARCHAR(20), IN p_position VARCHAR(25), IN p_department VARCHAR(30))
BEGIN
    UPDATE  Employee
    SET emp_name = p_name, 
		emp_address = p_address, 
        emp_position = p_position, 
        department = p_department
    WHERE emp_id = p_id 
END //
DELIMITER ;