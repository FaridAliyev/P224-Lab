create database P224

use P224

create table [Group](
Id int primary key identity,
Name nvarchar(50) not null)

create table Student(
Id int primary key identity,
Name nvarchar(100) not null,
Surname nvarchar(100) not null,
Age int not null,
Gender nvarchar(20) not null,
Email nvarchar(100) unique,
Phone nvarchar(50) unique,
AddressId int references Address(Id))

create table [Address](
Id int primary key identity,
City nvarchar(100),
Country nvarchar(100),
AddressLine nvarchar(200))

create table StudentGroup(
Id int primary key identity,
GroupId int references [Group](Id),
StudentId int references Student(Id))

create table Teacher(
Id int primary key identity,
Name nvarchar(100) not null,
Surname nvarchar(100) not null,
Age int not null,
Gender nvarchar(20) not null,
Email nvarchar(100) unique,
Phone nvarchar(50) unique,
Salary decimal(10,2),
AddressId int references Address(Id))

create table TeacherGroup(
Id int primary key identity,
GroupId int references [Group](Id),
TeacherId int references Teacher(Id))


create table Points(
Id int primary key identity,
[Min] int,
[Max] int,
Grade nvarchar(5))

create table Project(
Id int primary key identity,
Name nvarchar(50))

create table StudentProject(
Id int primary key identity,
StudentId int references Student(Id),
ProjectId int references Project(Id),
Point int)

insert into [Group] values
('P224'),
('P222'),
('V216')

insert into [Address] values
('Baku','Azerbaijan','Lokbatan'),
('Goycay', 'Azerbaijan', 'Ortaliqdan'),
('Antalya', 'Turkey','Uqlovoy'),
('Goranboy','Azerbaijan','Kuncden')

insert into Student values
('Amil','Nuriyev',17,'Male','amilnurlu@yahoo.com','0506969696',2),
('David','Qayibov',15,'Male','davidqayib@gmail.com','0556969696',3),
('Farid','Aliyev',21,'Male','faridali@inbox.ru','0515477779',1),
('Sadiqxan','Qayxanov',24,'Male','sadiqxangaykhanov@hotmail.com','0519252121',1),
('Altan','Ibrahimli',27,'Male','altanibra@yandex.ru','0515253545',4)

insert into StudentGroup values
(1,1),
(1,3),
(1,5),
(2,1),
(2,2),
(3,1),
(1,4)

insert into Teacher values
('Kamran','Cebiyev',34,'Male','kamrancebi@yahoo.com','0709916987',4500,2),
('Hemid','Mammadov',47,'Male','hamidmammad@gmail.com','0999999998',3000,3),
('Farid','Aliyev',21,'Male','faridali@inbox.ru','0515477779',6000,1),
('Shehla','Mirzeyeva',26,'Female','shahlamirze@hotmail.com','0708735794',30,1),
('Huseyn','Ashurlu',23,'Male','huseynashurlu@gmail.com','0776642332',7000,4)

insert into TeacherGroup values
(1,1),
(1,3),
(1,5),
(2,1),
(2,2),
(3,1),
(1,4)

insert into Project values
('Front'),
('Console'),
('ASP.Net Core MVC'),
('Final'),
('API'),
('WinForm')

insert into Points values
(0,50,'F'),
(51,60,'E'),
(61,70,'D'),
(71,80,'C'),
(81,90,'B'),
(91,100,'A')

insert into StudentProject values
(1,1,90),
(1,2,65),
(1,3,31),
(1,4,69),
(1,5,78),
(1,6,22),
(2,1,70),
(2,2,66),
(2,3,52),
(2,4,43),
(2,5,34),
(2,6,27),
(3,1,11),
(3,2,28),
(3,3,33),
(3,4,48),
(3,5,75),
(3,6,91),
(4,1,100),
(4,2,100),
(4,3,100),
(4,4,100),
(4,5,100),
(4,6,100),
(5,1,6),
(5,2,16),
(5,3,26),
(5,4,56),
(5,5,76),
(5,6,86)

select * from Teacher

select (Name+' '+ Surname) 'Fullname' from Teacher

select AVG(Age) from Teacher

select (Name+' '+ Surname) 'Fullname' from Teacher where Age<(select AVG(Age) from Teacher)

Select Distinct(AddressId) from Teacher

select * from Teacher where age>25 and Salary>2500

select * from Teacher where age<25 or Gender='Female'

select * from Teacher where not age=23

select * from Teacher order by Age DESC

update Teacher set Salary=100 where name='Shehla'

delete from TeacherGroup where TeacherId=4

select Top 2 * from Teacher

select * from Teacher where Salary=(Select MAX(Salary) from Teacher)

select Count(*) from Teacher

select SUM(Salary) from Teacher

select * from Teacher where Email like 'h_m_d%'

select * from  Teacher where Age Between 23 and 47

select Name 'Ad' from Teacher

select s.Name,s.Surname,s.Age, g.Name 'Group' from Student s
join StudentGroup sg
on s.Id=sg.StudentId
join [Group] g
on sg.GroupId=g.Id

select s.Name,s.Surname,s.Age, pro.Name 'Project Name', p.Grade from Student s
join StudentProject sp
on s.Id=sp.StudentId
join Project pro
on sp.ProjectId=pro.Id
join Points p
on sp.Point between p.[Min] and p.[Max]

select Count(s.Name), g.Name 'Group' from Student s
join StudentGroup sg
on s.Id=sg.StudentId
join [Group] g
on sg.GroupId=g.Id
group by g.Name
having Count(s.Name)>1

select * from Teacher t where salary > ANY(Select Salary from Teacher)

select * into StudentBackup from Student

create trigger StudentTrigger
on Student
after Insert,Update,Delete
as
begin
	declare @newName nvarchar(100)
	declare @oldName nvarchar(100)

	declare @newSurname nvarchar(100)
	declare @oldSurname nvarchar(100)

	Select @newName=Name from inserted
	Select @oldName=Name from deleted

	Select @newSurname=Surname from inserted
	Select @oldSurname=Surname from deleted

	Insert into StudentAudit values (@newName,@oldName,@newSurname,@oldSurname,GETDATE())
end

create table StudentAudit(
NewName nvarchar(100),
OldName nvarchar(100),
NewSurname nvarchar(100),
OldSurname nvarchar(100),
ModifiedDate DateTime
)


select  * from Student

delete from Student where Id=2

delete from StudentGroup where StudentId=2

delete from StudentProject where StudentId=2

select * from StudentAudit

update Student set Surname='Aliyev', Name='Farid' where Id=3

insert into Student values
('Kamil','Quliyev',23,'Male','KamilQuliyev@gmail.com','0709980919',3)
















