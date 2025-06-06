-- Skrypt SQL do utworzenia tabel i dodania przykładowych danych
-- dla aplikacji BeerCollection w SQLite

-- Tworzenie tabeli Breweries
CREATE TABLE IF NOT EXISTS Breweries (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Name TEXT NOT NULL,
    Country TEXT NULL,
    City TEXT NULL     
);

-- Tworzenie tabeli Beers
CREATE TABLE IF NOT EXISTS Beers (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Name TEXT NOT NULL,
    BreweryId INTEGER NOT NULL, -- Klucz obcy wskazujący na tabelę Breweries
    BeerType TEXT NOT NULL,
    AlcoholContent REAL,
    Volume INTEGER,
    Price NUMERIC,
    Description TEXT NULL,      
    FOREIGN KEY (BreweryId) REFERENCES Breweries (Id) ON DELETE RESTRICT
);

-- Tworzenie tabeli Reviews
CREATE TABLE IF NOT EXISTS Reviews (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    BeerId INTEGER NOT NULL,
    ReviewerName TEXT NOT NULL,
    Rating INTEGER NOT NULL,
    Comment TEXT NULL,
    ReviewDate TEXT NOT NULL DEFAULT (STRFTIME('%Y-%m-%d %H:%M:%S', 'now', 'localtime')),
    FOREIGN KEY (BeerId) REFERENCES Beers (Id) ON DELETE CASCADE
);

-----------------------------------------------------------------------------
-- DODAWANIE PRZYKŁADOWYCH DANYCH
-----------------------------------------------------------------------------

-- 1. Dodaj przykładowe BROWARY
-- Zakładamy, że po wykonaniu tych INSERT-ów, 'Pinta' dostanie Id=1, 'AleBrowar' Id=2, itd.
-- Jest to prawdą, jeśli tabela Breweries jest pusta przed wykonaniem tych poleceń.
INSERT INTO Breweries (Name, Country, City) VALUES ('Pinta', 'Polska', 'Wieprz');
INSERT INTO Breweries (Name, Country, City) VALUES ('AleBrowar', 'Polska', 'Lębork');
INSERT INTO Breweries (Name, Country, City) VALUES ('Nepomucen', 'Polska', 'Szkaradowo');
INSERT INTO Breweries (Name, Country, City) VALUES ('Browar Stu Mostów', 'Polska', 'Wrocław');
INSERT INTO Breweries (Name, Country, City) VALUES
('Pinta', 'Polska', 'Wieprz'),
('AleBrowar', 'Polska', 'Lębork'),
('Nepomucen', 'Polska', 'Szkaradowo'),
('Browar Stu Mostów', 'Polska', 'Wrocław'),
('Trzech Kumpli', 'Polska', 'Tarnów'),
('Brokreacja', 'Polska', 'Kraków'),
('Perun', 'Polska', 'Warszawa'),
('Browar Zakładowy', 'Polska', 'Poniatowa'),
('Browar Spółdzielczy', 'Polska', 'Puck'),
('Raduga', 'Polska', 'Warszawa'),
('Browar Widawa', 'Polska', 'Chrząstawa Mała'),
('Browar Kazimierz', 'Polska', 'Zakrzów'),
('Browar Kingpin', 'Polska', 'Poznań'),
('Browar Golem', 'Polska', 'Poznań'),
('Browar Łańcut', 'Polska', 'Łańcut');


-- 2. Dodaj przykładowe PIWA, przypisując je do istniejących browarów za pomocą BreweryId
-- Pamiętaj, że wartości BreweryId (1, 2, 3, 4) odpowiadają kolejności dodawania browarów powyżej.
-- Jeśli dodasz browary w innej kolejności lub tabela nie była pusta, te ID mogą być inne.

-- Piwa z browaru Pinta (zakładamy, że Pinta ma Id=1)
INSERT INTO Beers (Name, BreweryId, BeerType, AlcoholContent, Volume, Price, Description) 
VALUES ('Atak Chmielu', 1, 'American IPA', 6.1, 500, 8.50, 'Pierwsza komercyjnie uwarzona AIPA w Polsce.');
INSERT INTO Beers (Name, BreweryId, BeerType, AlcoholContent, Volume, Price, Description) 
VALUES ('Pierwsza Pomoc', 1, 'Polski Pils', 4.2, 500, 7.00, 'Lekki i orzeźwiający pils.');

-- Piwa z browaru AleBrowar (zakładamy, że AleBrowar ma Id=2)
INSERT INTO Beers (Name, BreweryId, BeerType, AlcoholContent, Volume, Price, Description) 
VALUES ('Rowing Jack', 2, 'India Pale Ale', 6.2, 500, 9.00, 'Intensywnie chmielone IPA z cytrusowymi nutami.');

INSERT INTO Beers (Name, BreweryId, BeerType, AlcoholContent, Volume, Price, Description) 
VALUES ('Lady Blanche', 2, 'Witbier', 4.7, 500, 8.00, 'Belgijskie piwo pszeniczne z kolendrą i skórką pomarańczy.'); -- Przykład piwa niedostępnego

-- Piwo z browaru Nepomucen (zakładamy, że Nepomucen ma Id=3)
INSERT INTO Beers (Name, BreweryId, BeerType, AlcoholContent, Volume, Price, Description) 
VALUES ('Forest', 3, 'Forest IPA', 6.0, 500, 9.50, 'IPA z dodatkiem leśnych składników, takich jak pędy sosny.');

-- Piwo z Browaru Stu Mostów (zakładamy, że Browar Stu Mostów ma Id=4)
INSERT INTO Beers (Name, BreweryId, BeerType, AlcoholContent, Volume, Price, Description) 
VALUES ('Salamander AIPA', 4, 'American IPA', 6.5, 500, 9.20, 'Klasyczna AIPA z wyraźną goryczką.');
INSERT INTO Beers (Name, BreweryId, BeerType, AlcoholContent, Volume, Price, Description) VALUES
('Atak Chmielu', 1, 'American IPA', 6.1, 500, 8.50, 'Pierwsze polskie AIPA'),
('Pierwsza Pomoc', 1, 'Polski Pils', 4.2, 500, 7.00, 'Lekki pils'),
('Rowing Jack', 2, 'India Pale Ale', 6.2, 500, 9.00, 'Cytrusowe IPA'),
('Lady Blanche', 2, 'Witbier', 4.7, 500, 8.00, 'Belgijski styl'),
('Forest', 3, 'Forest IPA', 6.0, 500, 9.50, 'Leśne aromaty'),
('Salamander AIPA', 4, 'American IPA', 6.5, 500, 9.20, 'Goryczka i cytrusy'),
('Pils z Grodziska', 5, 'Pilsner', 5.0, 500, 7.50, 'Pils z nutą dymu'),
('Pan IPAni', 5, 'Session IPA', 4.9, 500, 8.20, 'Lekkie IPA'),
('Hard Bride', 6, 'Imperial IPA', 8.2, 500, 10.50, 'Owocowe chmiele'),
('The Teacher', 6, 'Stout', 6.5, 500, 9.00, 'Czekoladowy stout'),
('Black IPA', 7, 'Black IPA', 6.5, 500, 9.30, 'Ciemne, ale chmielowe'),
('Biurokrat', 8, 'APA', 5.5, 500, 7.90, 'Zbalansowane APA'),
('Miś Wojtek', 9, 'Honey Wheat', 5.8, 500, 8.40, 'Z miodem i pszenicą'),
('Metropolis', 10, 'NEIPA', 6.3, 500, 10.00, 'Soczyste NEIPA'),
('Rebel', 11, 'Barley Wine', 10.2, 330, 12.50, 'Mocne i słodowe');



-- 3. (Opcjonalnie) Dodaj przykładowe RECENZJE dla piw
-- Pamiętaj, że BeerId musi odpowiadać Id piw dodanych powyżej.

-- Recenzje dla 'Atak Chmielu' (zakładamy, że Atak Chmielu dostał Id=1)
INSERT INTO Reviews (BeerId, ReviewerName, Rating, Comment)
VALUES (1, 'Jan K.', 5, 'Absolutny klasyk, zawsze świetne!');
INSERT INTO Reviews (BeerId, ReviewerName, Rating, Comment)
VALUES (1, 'Anna P.', 4, 'Bardzo dobre, choć trochę za mocno chmielone dla mnie.');

-- Recenzje dla 'Rowing Jack' (zakładamy, że Rowing Jack dostał Id=3, bo drugie piwo Pinty to Id=2)
-- Aby to było pewne, najlepiej sprawdzić ID po wstawieniu piw lub użyć podzapytań,
-- ale dla prostoty skryptu zakładamy kolejność.
INSERT INTO Reviews (BeerId, ReviewerName, Rating, Comment)
VALUES (3, 'Piotr W.', 5, 'Jedno z moich ulubionych IPA!');
INSERT INTO Reviews (BeerId, ReviewerName, Rating, Comment) VALUES
(1, 'Jan K.', 5, 'Absolutny klasyk.'),
(1, 'Anna P.', 4, 'Trochę zbyt goryczkowe.'),
(2, 'Kuba W.', 3, 'Ok na lato.'),
(3, 'Ola L.', 5, 'Świetne IPA!'),
(4, 'Adam R.', 4, 'Delikatne i orzeźwiające.'),
(5, 'Tomek M.', 5, 'Unikalny smak lasu.'),
(6, 'Kamil B.', 5, 'Moc chmielu!'),
(7, 'Natalia J.', 4, 'Nie dla każdego.'),
(8, 'Łukasz M.', 5, 'Uwielbiam!'),
(9, 'Magda L.', 5, 'Mocno owocowe.'),
(10, 'Tomek K.', 4, 'Dobry stout.'),
(11, 'Bartek Z.', 3, 'Trochę zbyt palone.'),
(12, 'Iza G.', 5, 'Super zbalansowane.'),
(13, 'Mateusz D.', 4, 'Ciekawe połączenie.'),
(14, 'Wojtek H.', 5, 'Idealne NEIPA.'),
(15, 'Karolina C.', 5, 'Ciężkie ale wspaniałe.');
