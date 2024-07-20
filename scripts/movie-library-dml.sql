/* USER */

INSERT INTO user (id, username, [password], password_salt, [role], created_on, updated_on, is_disabled)
VALUES ('6a5561cc-df87-487e-9966-2bfa342525d4', 'admin-user', '83a6c7696be667964f0f42ac17f7fe93', 'c0695027b298c139700d002f', 'admin', GETDATE(), NULL, 0);

INSERT INTO TABLE user (id, username, [password], password_salt, [role], created_on, updated_on, is_disabled)
VALUES ('15e1b955-c9f8-4cfd-bcc0-223f2814358e', 'common-user', '83a6c7696be667964f0f42ac17f7fe93', 'c0695027b298c139700d002f', 'user', GETDATE(), NULL, 0);

/* COUNTRY */

INSERT INTO country (id, [name], iso_alpha3_code, created_on, updated_on, is_disabled)
VALUES ('989adb5a-3434-4239-bfaa-8752dcd18e9b', 'United States of America', 'USA', GETDATE(), NULL, 0);

INSERT INTO country (id, [name], iso_alpha3_code, created_on, updated_on, is_disabled)
VALUES ('90aa24a3-8cf4-48eb-8164-60351c748ebe', 'Japan', 'JPN', GETDATE(), NULL, 0);

/* DIRECTOR */

INSERT INTO director (id, country_id, [name], date_of_birth, created_on, updated_on, is_disabled)
VALUES ('c11bfa47-b6a9-471e-a797-b9189d78d3bd', '989adb5a-3434-4239-bfaa-8752dcd18e9b', 'Francis Ford Coppola', '1939-04-07', GETDATE(), NULL, 0);

INSERT INTO director (id, country_id, [name], date_of_birth, created_on, updated_on, is_disabled)
VALUES ('9e456246-54e9-48c0-9334-2c6eea386d6b', '90aa24a3-8cf4-48eb-8164-60351c748ebe', 'Hayao Miyazaki', '1941-01-05', GETDATE(), NULL, 0);

/* MOVIE */

INSERT INTO movie (id, director_id, country_id, english_name, ogirinal_name, release_year, runtime_in_minutes, genres, created_on, updated_on, is_disabled)
VALUES ('0015f5e0-aead-4017-99a3-5d189f184fd8', 'c11bfa47-b6a9-471e-a797-b9189d78d3bd', '989adb5a-3434-4239-bfaa-8752dcd18e9b', 'Apocalypse Now', NULL, '1979', 147, 260, GETDATE(), NULL, 0);

INSERT INTO movie (id, director_id, country_id, english_name, ogirinal_name, release_year, runtime_in_minutes, genres, created_on, updated_on, is_disabled)
VALUES ('2197bc6c-c63f-4b15-97a9-d51facdea2bc', '9e456246-54e9-48c0-9334-2c6eea386d6b', '90aa24a3-8cf4-48eb-8164-60351c748ebe', 'Spirited Away', '千と千尋の神隠し', '2001', 125, 18, GETDATE(), NULL, 0);