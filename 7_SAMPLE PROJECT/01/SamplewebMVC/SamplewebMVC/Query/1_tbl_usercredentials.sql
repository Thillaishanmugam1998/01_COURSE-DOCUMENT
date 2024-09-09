--Create a table
CREATE TABLE tbl_usercredentials (
    id SERIAL PRIMARY KEY,
    username VARCHAR(255) NOT NULL UNIQUE,
    password VARCHAR(255) NOT NULL,
    isdeleted BOOLEAN DEFAULT FALSE
);

--Insert a table
INSERT INTO tbl_usercredentials (username, password)
VALUES ('admin', '12345');

--Select a table
SELECT * FROM  tbl_usercredentials;

--Drop a table
DROP TABLE tbl_usercredentials;