use Training2023
select *from Siva_Role
create  table Siva_Role(
 Role_ID  int PRIMARY KEY IDENTITY,
    Name  varchar(22));
	insert into Siva_Role values('Admin'),('user');

select * from  Siva_gender;
CREATE TABLE Siva_gender (
  Gender_ID int PRIMARY KEY IDENTITY,
    NAME varchar(22));
	insert into Siva_gender values('male'),('female'),('others');

select *from Siva_Details;

CREATE TABLE siva_Details(
Register_Id  int PRIMARY KEY IDENTITY,
FirstName varchar(20),
LastName varchar(20),
Gender int foreign key references Siva_gender(ID),
Role int foreign key references Siva_Role(ID),
 CreateDate date DEFAULT GETDATE(),
 Moblie_number varchar (20),
 Email  varchar(20),
 Status varchar(22));