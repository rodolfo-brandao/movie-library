-- USERS:
-- (for testing purposes only, the password hash value is "12345678")
INSERT INTO "user" (id, username, email, "password", password_salt, "role", created_on, updated_on, is_disabled)
VALUES ('6a5561cc-df87-487e-9966-2bfa342525d4', 'gman', 'gman@blackmesa.com', '83a6c7696be667964f0f42ac17f7fe93', 'c0695027b298c139700d002f', 'admin', NOW(), NULL, false);

INSERT INTO "user" (id, username, email, "password", password_salt, "role", created_on, updated_on, is_disabled)
VALUES ('15e1b955-c9f8-4cfd-bcc0-223f2814358e', 'gordon-freeman', 'gfreeman@blackmesa.com', '83a6c7696be667964f0f42ac17f7fe93', 'c0695027b298c139700d002f', 'user', NOW(), NULL, false);

-- COUNTRIES:
INSERT INTO country (id, "name", iso_alpha3_code, created_on, updated_on, is_disabled)
VALUES ('989adb5a-3434-4239-bfaa-8752dcd18e9b', 'United States of America', 'USA', NOW(), NULL, false);

INSERT INTO country (id, "name", iso_alpha3_code, created_on, updated_on, is_disabled)
VALUES ('90aa24a3-8cf4-48eb-8164-60351c748ebe', 'Japan', 'JPN', NOW(), NULL, false);

-- DIRECTORS:
INSERT INTO director (id, country_id, "name", date_of_birth, created_on, updated_on, is_disabled)
VALUES ('c11bfa47-b6a9-471e-a797-b9189d78d3bd', '989adb5a-3434-4239-bfaa-8752dcd18e9b', 'Francis Ford Coppola', '1939-04-07', NOW(), NULL, false);

INSERT INTO director (id, country_id, "name", date_of_birth, created_on, updated_on, is_disabled)
VALUES ('9e456246-54e9-48c0-9334-2c6eea386d6b', '90aa24a3-8cf4-48eb-8164-60351c748ebe', 'Hayao Miyazaki', '1941-01-05', NOW(), NULL, false);

-- MOVIES:
INSERT INTO movie (id, director_id, country_id, english_name, original_name, release_year, runtime_in_minutes, genres, created_on, updated_on, is_disabled)
VALUES ('0015f5e0-aead-4017-99a3-5d189f184fd8', 'c11bfa47-b6a9-471e-a797-b9189d78d3bd', '989adb5a-3434-4239-bfaa-8752dcd18e9b', 'Apocalypse Now', NULL, '1979', 147, 260, NOW(), NULL, false);

INSERT INTO movie (id, director_id, country_id, english_name, original_name, release_year, runtime_in_minutes, genres, created_on, updated_on, is_disabled)
VALUES ('2197bc6c-c63f-4b15-97a9-d51facdea2bc', '9e456246-54e9-48c0-9334-2c6eea386d6b', '90aa24a3-8cf4-48eb-8164-60351c748ebe', 'Spirited Away', '千と千尋の神隠し', '2001', 125, 18, NOW(), NULL, false);
