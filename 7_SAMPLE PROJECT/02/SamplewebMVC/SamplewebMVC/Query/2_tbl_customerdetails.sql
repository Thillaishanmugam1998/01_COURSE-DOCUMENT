-- Create Table
CREATE TABLE tbl_customerdetails (
    id SERIAL PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    mobilenumber VARCHAR(15) NOT NULL,
    email VARCHAR(100) NOT NULL UNIQUE,
    address TEXT
);

-- Insert Data
INSERT INTO tbl_customerdetails (name, mobilenumber, email, address)
VALUES 
    ('John Doe', '1234567890', 'john.doe@example.com', '123 Main St, Anytown, USA'),
    ('Jane Smith', '0987654321', 'jane.smith@example.com', '456 Elm St, Othertown, USA');

-- Show Table Structure
SELECT * FROM tbl_customerdetails;

-- Delete Table
DROP TABLE IF EXISTS tbl_customerdetails;