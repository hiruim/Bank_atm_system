CREATE DATABASE LANKA_PAY_BANK

USE LANKA_PAY_BANK

DROP DATABASE LANKA_PAY_BANK

CREATE TABLE Customer (
	Name	varchar(50)		NOT NULL,
	Mname	varchar(50)		NOT NULL,
	DoB		DATE	NOT NULL,
	Email	varchar(50)		NOT NULL,
	Mstatus		varchar(50)		NOT NULL,
	Address		varchar(50)		NOT NULL,
	city	varchar(50)		NOT NULL,
	Pin		varchar(50)		NOT NULL,
	State	varchar(50)		NOT NULL,
	AccType		varchar(50)		NOT NULL,
	CONSTRAINT pk_customer PRIMARY KEY(Pin)
	);

CREATE TABLE Balance (
	Pin		varchar(50)		NOT NULL,
	Balance		float,
	CONSTRAINT fk_pin FOREIGN KEY (Pin) REFERENCES Customer (Pin)
	);

DROP TABLE Balance
DROP TABLE Customer

