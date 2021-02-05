CREATE TABLE Movies (
    Id SERIAL PRIMARY KEY,
    Title TEXT,
    Description TEXT, 
    Time1 VARCHAR, 
    Time2 VARCHAR
);

INSERT INTO
    Movies (Title, Description, Time1, Time2)
VALUES
    ('The Matrix', 'Sci-Fi Adventure; Will Neo choose the right pill?', '14:00', '18:00'),
    ('The Hangover', 'Comedy; What happens in Vegas stays in Vegas', '17:00', '22:00'),
    ('Titanic', 'Drama; She does let go Jack', '16:00', '20:00');