/* TABLES */

CREATE TABLE user (
    id UNIQUEIDENTIFIER NOT NULL,
    username VARCHAR(50) NOT NULL,
    email VARCHAR(255) NOT NULL,
    [password] CHAR(32) NOT NULL,
    password_salt CHAR(16) NOT NULL,
    [role] VARCHAR(5) NOT NULL,
    created_on DATETIME2 NOT NULL,
    updated_on DATETIME2 NULL,
    is_disabled BIT NOT NULL
);

CREATE TABLE country (
    id UNIQUEIDENTIFIER NOT NULL,
    [name] VARCHAR(255),
    iso_alpha3_code VARCHAR(4) NOT NULL,
    created_on DATETIME2 NOT NULL,
    updated_on DATETIME2 NULL,
    is_disabled BIT NOT NULL
);

CREATE TABLE director (
    id UNIQUEIDENTIFIER NOT NULL,
    country_id UNIQUEIDENTIFIER NOT NULL,
    [name] VARCHAR(255) NOT NULL,
    date_of_birth DATE NOT NULL,
    created_on DATETIME2 NOT NULL,
    updated_on DATETIME2 NULL,
    is_disabled BIT NOT NULL
);

CREATE TABLE movie (
    id UNIQUEIDENTIFIER NOT NULL,
    director_id UNIQUEIDENTIFIER NOT NULL,
    country_id UNIQUEIDENTIFIER NOT NULL,
    english_name VARCHAR(255) NOT NULL,
    original_name VARCHAR(255) NULL,
    release_year CHAR(4) NOT NULL,
    runtime_in_minutes SMALLINT NOT NULL,
    genres SMALLINT NOT NULL,
    created_on DATETIME2 NOT NULL,
    updated_on DATETIME2 NULL,
    is_disabled BIT NOT NULL
);

/* PRIMARY KEY CONSTRAINTS */

ALTER TABLE user
    ADD CONSTRAINT PK_user
        PRIMARY KEY (id);

ALTER TABLE country
    ADD CONSTRAINT PK_country
        PRIMARY KEY (id);

ALTER TABLE director
    ADD CONSTRAINT PK_director
        PRIMARY KEY (id);

ALTER TABLE movie
    ADD CONSTRAINT PK_movie
        PRIMARY KEY (id);

/* FOREIGN KEY CONSTRAINTS */

ALTER TABLE director
    ADD CONSTRAINT FK_country_director
        FOREIGN KEY (country_id)
            REFERENCES country(id);

ALTER TABLE movie
    ADD CONSTRAINT FK_director_movie
        FOREIGN KEY (director_id)
            REFERENCES director(id);

ALTER TABLE movie
    ADD CONSTRAINT FK_country_movie
        FOREIGN KEY (country_id)
            REFERENCES country(id);