/*OLD INCORRECT SOLUTION*/
CREATE TABLE Players(
    player_name varchar(255) NOT NULL,
    elo_rank unsigned int NOT NULL,
    PRIMARY KEY (player_name)
);

CREATE TABLE Events(
    event_name varchar(255) NOT NULL,
    event_site varchar(255) NOT NULL,
    event_date varchar(255) NOT NULL,
    PRIMARY KEY (event_name, event_date)
);

CREATE TABLE Games(
    game_round unsigned int NOT NULL,
    game_result unsigned int NOT NULL,
    game_moves varchar(255),
    game_player_black char(5) NOT NULL,
    game_player_white char(5) NOT NULL,
    player_name varchar(255),
    FOREIGN KEY (player_name) REFERENCES Players(player_name),
    event_name varchar(255) NOT NULL,
    event_date varchar(255) NOT NULL,
    FOREIGN KEY (event_name, event_date) REFERENCES Events(event_name, event_date)
    PRIMARY KEY(game_round, game_player_black, game_player_white)
);

/*NEW CORRECT SOLUTION*/
CREATE TABLE Players(
    ELO UNSIGNED INT NOT NULL,
    Name VARCHAR(255) NOT NULL,
    Primary Key(Name)
);

CREATE TABLE Events(
    Name VARCHAR(255) NOT NULL,
    Site VARCHAR(255) NOT NULL,
    Date DATE NOT NULL,
    Primary Key(Name, Site, Date)
);

CREATE TABLE Games(
    Round UNSIGNED INTEGER NOT NULL,
    Result CHAR(1) NOT NULL,
    Moves VARCHAR (1000) INTEGER NOT NULL,
    BlackPlayer VARCHAR(255) NOT NULL,
    WhitePlayer VARCHAR(255) NOT NULL,
    Name VARCHAR(255) NOT NULL,
    Site VARCHAR(255) NOT NULL,
    Date DATE NOT NULL,
    Primary Key(BlackPlayer, WhitePlayer, Name, Site, Date, Round),
    FOREIGN KEY (BlackPlayer) REFERENCES Players(Name),
    FOREIGN KEY (WhitePlayer) REFERENCES Players(Name),
    FOREIGN KEY (Name, Site, Date) REFERENCES Events(Name, Site, Date)
);