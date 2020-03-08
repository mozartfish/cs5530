
/*OLD INCORRECT SOLUTION*/
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


/*MY NEW CORRECT SOLUTION*/
CREATE TABLE Departments(
    dID INT UNSIGNED NOT NULL,
    Name varchar(255) NOT NULL,
    PRIMARY KEY(dID)
);

CREATE TABLE Rooms(
    RmNumber INT UNSIGNED NOT NULL,
    Capacity INT UNSIGNED NOT NULL,
    Primary Key (RmNumber)
    FOREIGN KEY (dID) REFERENCES Departments(dID)
);

CREATE TABLE Meetings(
    StartTime TIME NOT NULL,
    RmNumber INT NOT NULL,
    FOREIGN KEY (RmNumber) REFERENCES Rooms(RmNumber)
    Primary Key (StartTime, RmNumber)
);

CREATE TABLE People(
    SSN CHAR(12) NOT NULL,
    Name VARCHAR(255) NOT NULL,
    Primary Key(SSN)
);

CREATE TABLE Attends(
    SSN CHAR(12) NOT NULL,
    RmNumber INT NOT NULL,
    PRIMARY KEY (SSN, StartTime, RmNumber)
    FOREIGN KEY (StartTime, RmNumber) REFERENCES Meetings(StartTime, RmNumber),
    FOREIGN KEY (SSN) REFERENCES People(SSN)
);