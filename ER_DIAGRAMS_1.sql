CREATE TABLE Persons(
    SSN char(9) NOT NULL,
    Name varchar(255) NOT NULL,
    PRIMARY KEY(SSN)
);

CREATE TABLE Rooms(
    department varchar(255),
    room_number unsigned int NOT NULL,
    capacity unsigned int NOT NULL,
    PRIMARY KEY(room_number)
);

CREATE TABLE Meetings(
    start_time int NOT NULL,
    Person varchar(255),
    room_number unsigned int,
    FOREIGN KEY (room_number) REFERENCES Rooms(room_number),
    PRIMARY KEY(room_number, start_time)
);

CREATE TABLE Departments(
    room_number unsigned int NOT NULL,
    department_name varchar(255) NOT NULL,
    department_ID unsigned int NOT NULL,
    FOREIGN KEY (room_number) REFERENCES Rooms(room_number)
    PRIMARY KEY(department_id)
);