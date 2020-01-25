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