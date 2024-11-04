use Andreinartistica

-- Insert data into Categories
INSERT INTO Categories (Name) VALUES 
('Painting'),
('Sculpture'),
('Photography'),
('Digital Art');

-- Insert data into Materials
INSERT INTO Materials (Name) VALUES 
('Oil Paint'),
('Acrylic Paint'),
('Clay'),
('Wood'),
('Digital File');

-- Insert data into Topics
INSERT INTO Topics (Name) VALUES 
('Nature'),
('Abstract'),
('Portrait'),
('Urban'),
('Fantasy');

-- Insert data into Techniques
INSERT INTO Techniques (Name) VALUES 
('Impressionism'),
('Surrealism'),
('Cubism'),
('Realism'),
('Expressionism');

-- Insert data into ArtPieces
INSERT INTO ArtPieces (Title, Category, Material, Topic, Technique, Elaborated, SubTopic, Location, Exhibited, Availability, State, Height, Width, Price, Subject) VALUES 
('Sunset Over the Mountains', 1, 1, 1, 1, '2022-05-10', NULL, 'Gallery A', NULL, 1, 'New', 40, 30, 150.00, 1), 
('The Thinker', 2, 3, 4, 2, '2020-01-15', NULL, 'Museum B', 'Exhibit 2020', 0, 'Used', 75, 50, 300.00, 2), 
('Abstract Dreams', 1, 2, 2, 3, '2023-03-01', NULL, 'Online', NULL, 1, 'New', 60, 40, 200.00, 1), 
('City Lights', 4, 5, 4, 4, '2021-10-05', NULL, 'Digital Gallery', NULL, 1, 'New', 1080, 720, 50.00, 3), 
('Portrait of a Lady', 1, 1, 3, 5, '2022-12-20', NULL, 'Private Collection', NULL, 1, 'New', 50, 35, 250.00, 1), 
('Wooden Sculpture of an Eagle', 2, 4, 1, 1, '2019-07-30', NULL, 'Park Exhibit', 'Nature Show', 1, 'New', 120, 80, 400.00, 2);
