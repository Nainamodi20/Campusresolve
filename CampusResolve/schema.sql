CREATE DATABASE IF NOT EXISTS campus_resolve_db;
USE campus_resolve_db;

CREATE TABLE Usersinvp (
    user_id INT PRIMARY KEY AUTO_INCREMENT,
    username VARCHAR(100) NOT NULL UNIQUE,
    password VARCHAR(255) NOT NULL,
    created_at DATETIME DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE Staff (
    staff_id INT PRIMARY KEY AUTO_INCREMENT,
    username VARCHAR(100) NOT NULL UNIQUE,
    password VARCHAR(255) NOT NULL,
    created_at DATETIME DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE Admins (
    admin_id INT PRIMARY KEY AUTO_INCREMENT,
    username VARCHAR(100) NOT NULL UNIQUE,
    password VARCHAR(255) NOT NULL,
    created_at DATETIME DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE Complaints (
    complaint_id INT PRIMARY KEY AUTO_INCREMENT,
    user_id INT NOT NULL,
    title VARCHAR(255) NOT NULL,
    description TEXT NOT NULL,
    category VARCHAR(100) NOT NULL,
    custom_category VARCHAR(100) NULL,
    location VARCHAR(255) NOT NULL,
    priority ENUM('Low', 'Medium', 'High') NOT NULL,
    status ENUM('Pending', 'In Progress', 'Resolved') NOT NULL DEFAULT 'Pending',
    created_at DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (user_id) REFERENCES Usersinvp(user_id) ON DELETE CASCADE
);

CREATE TABLE Assignments (
    assignment_id INT PRIMARY KEY AUTO_INCREMENT,
    complaint_id INT NOT NULL,
    assigned_to INT NOT NULL,  -- References Staff
    deadline DATETIME NOT NULL,
    assigned_at DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (complaint_id) REFERENCES Complaints(complaint_id) ON DELETE CASCADE,
    FOREIGN KEY (assigned_to) REFERENCES Staff(staff_id) ON DELETE CASCADE
);

CREATE TABLE Status_Updates (
    update_id INT PRIMARY KEY AUTO_INCREMENT,
    complaint_id INT NOT NULL,
    status ENUM('Pending', 'In Progress', 'Resolved') NOT NULL,
    updated_by INT NOT NULL,  -- References Staff executing the update
    updated_at DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (complaint_id) REFERENCES Complaints(complaint_id) ON DELETE CASCADE,
    FOREIGN KEY (updated_by) REFERENCES Staff(staff_id) ON DELETE CASCADE
);

-- =============================================
-- Default Administrative Account
-- =============================================
INSERT INTO Admins (username, password) VALUES ('admin', 'admin123');
