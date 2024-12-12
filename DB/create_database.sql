-- Create the database
CREATE DATABASE IF NOT EXISTS ComputerManagementDB;

-- Switch to the newly created database
USE ComputerManagementDB;

-- Create the 'computers' table
CREATE TABLE IF NOT EXISTS computers (
    id INT AUTO_INCREMENT PRIMARY KEY,
    computer_name VARCHAR(255) NOT NULL,
    status ENUM('Online', 'Offline') NOT NULL DEFAULT 'Offline',
    processor VARCHAR(255) NOT NULL,
    ram VARCHAR(50) NOT NULL,
    storage VARCHAR(50) NOT NULL,
    graphics_card VARCHAR(255) NULL,
    operating_system VARCHAR(255) NOT NULL,
    last_updated TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
);

-- Insert some test data
INSERT INTO computers (computer_name, status, processor, ram, storage, graphics_card, operating_system)
VALUES
('Workstation A', 'Online', 'Intel Core i5-10400', '16GB', '256GB SSD', 'Intel UHD Graphics 630', 'Windows 10 Pro'),
('Workstation B', 'Offline', 'AMD Ryzen 5 3600', '8GB', '512GB SSD', 'NVIDIA GTX 1650', 'Windows 11 Pro');
