create database Hotel

create table rooms(roomid int identity(1,1)primary key
			,roomnum int unique,
			roomtype varchar(20)not null,
			bed varchar(20)not null,
			price bigint not null
			,booked varchar(50) default 'NO');

select * from rooms

create table customer(
cid int identity(1,1) primary key,
cname varchar(100) not null,
mobile bigint not null,
nationality varchar(70) not null,
gender varchar(7) not null,
dob varchar(100) not null,
idproof varchar(100) not null,
address varchar(100) not null,
checkin varchar(100) not null,
checkout varchar(100) ,
chekout varchar(100) not null default 'NO',
roomid int not null references rooms(roomid));