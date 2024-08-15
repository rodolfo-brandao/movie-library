CREATE TABLE "user" (
    id UUID NOT NULL PRIMARY KEY,
    username VARCHAR(50) UNIQUE NOT NULL,
    email VARCHAR(255) UNIQUE NOT NULL,
    "password" CHAR(32) NOT NULL,
    password_salt CHAR(24) NOT NULL,
    "role" VARCHAR(5) NOT NULL,
    created_on TIMESTAMPTZ NOT NULL,
    updated_on TIMESTAMPTZ NULL,
    is_disabled BOOLEAN NOT NULL
);

CREATE TABLE country (
    id UUID NOT NULL PRIMARY KEY,
    "name" VARCHAR(255) UNIQUE,
    iso_alpha3_code VARCHAR(4) UNIQUE NOT NULL,
    created_on TIMESTAMPTZ NOT NULL,
    updated_on TIMESTAMPTZ NULL,
    is_disabled BOOLEAN NOT NULL
);

CREATE TABLE director (
    id UUID NOT NULL PRIMARY KEY,
    country_id UUID NOT NULL,
    "name" VARCHAR(255) UNIQUE NOT NULL,
    date_of_birth DATE NOT NULL,
    created_on TIMESTAMPTZ NOT NULL,
    updated_on TIMESTAMPTZ NULL,
    is_disabled BOOLEAN NOT NULL,

    CONSTRAINT FK_country_director
        FOREIGN KEY (country_id)
            REFERENCES country(id)
);

CREATE TABLE movie (
    id UUID NOT NULL PRIMARY KEY,
    director_id UUID NOT NULL,
    country_id UUID NOT NULL,
    english_name VARCHAR(255) NOT NULL,
    original_name VARCHAR(255) NULL,
    release_year CHAR(4) NOT NULL,
    runtime_in_minutes SMALLINT NOT NULL,
    genres SMALLINT NOT NULL,
    created_on TIMESTAMPTZ NOT NULL,
    updated_on TIMESTAMPTZ NULL,
    is_disabled BOOLEAN NOT NULL,

    CONSTRAINT FK_director_movie
        FOREIGN KEY (director_id)
            REFERENCES director(id),

    CONSTRAINT FK_country_movie
        FOREIGN KEY (country_id)
            REFERENCES country(id)
);
