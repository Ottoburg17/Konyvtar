CREATE DATABASE IF NOT EXISTS kolcsonzesek;

USE kolcsonzesek;

CREATE TABLE IF NOT EXISTS Kolcsonzesek (
    ID Int;
    KolcsonzokId INT,
    Iro VARCHAR(255),
    Mufaj VARCHAR(255),
    Cim VARCHAR(255),
);
