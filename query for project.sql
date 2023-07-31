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