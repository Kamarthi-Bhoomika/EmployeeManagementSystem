create database EMSDb
use EMSDb

create table DeptMaster
( DeptCode int primary key,
DeptName nvarchar(50))

create table EmpProfile
(EmpCode int,
DateOfBirth DateTime,
EmpName nvarchar(50),
Email nvarchar(50),
DeptCode int foreign key references DeptMaster)

