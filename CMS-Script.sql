DROP TABLE Branch cascade constraints;

CREATE TABLE Branch
(BID number(3) primary key,
Address varchar2(50) not null);

CREATE TABLE Volunteer 
   (	"SSN" NUMBER(10,0) NOT NULL primary key, 
	"FNAME" VARCHAR2(10 BYTE) NOT NULL, 
	"LNAME" VARCHAR2(10 BYTE)NOT NULL, 
	"SEX" CHAR(1 BYTE), 
	"EMAIL" VARCHAR2(20 BYTE), 
	"MOBILE_NUMBER" NUMBER(12,0) NOT NULL, 
	"ADDRESS" VARCHAR2(50 BYTE)
   )