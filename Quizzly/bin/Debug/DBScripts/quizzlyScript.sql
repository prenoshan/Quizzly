
--creates userinfo table if not exists--

if not exists (select *

from Usr18005753ZengageDB.INFORMATION_SCHEMA.TABLES

where TABLE_NAME = 'userinfo')

begin

create table userinfo(

	id int primary key identity(1,1),
	usernames nvarchar(50),
	passwords nvarchar(50),
	userroles nvarchar(15)

);

end

--creates lecturer table if not exists--

if not exists (select *

from Usr18005753ZengageDB.INFORMATION_SCHEMA.TABLES

where TABLE_NAME = 'lecturer')

begin

create table lecturer(

	id int primary key identity(1,1),
	userid int,
	firstname nvarchar(50),
	surname nvarchar(50)

	foreign key(userid) references userinfo(id)
	
);

end

--creates student table if not exists--

if not exists (select *

from Usr18005753ZengageDB.INFORMATION_SCHEMA.TABLES

where TABLE_NAME = 'student')

begin

create table student(

	id int primary key identity(1,1),
	userid int,
	firstname nvarchar(50),
	surname nvarchar(50),
	
	foreign key(userid) references userinfo(id)

);

end

--creates test table if not exists--

if not exists (select *

from Usr18005753ZengageDB.INFORMATION_SCHEMA.TABLES

where TABLE_NAME = 'test')

begin

create table test(

	id int primary key identity(1,1),
	name nvarchar(100),
	qcount int

);

end

--creates question table if not exists--

if not exists (select *

from Usr18005753ZengageDB.INFORMATION_SCHEMA.TABLES

where TABLE_NAME = 'question')

begin

create table question(

	id int primary key identity(1,1),
	question nvarchar(max)
);

end

--creates test_questions table if not exists--

if not exists (select *

from Usr18005753ZengageDB.INFORMATION_SCHEMA.TABLES

where TABLE_NAME = 'test_questions')

begin

create table test_questions(

	id int primary key identity(1,1),
	testid int,
	questionid int,
	
	foreign key (questionid) references question(id),
	foreign key (testid) references test(id)
);

end

--creates answers table if not exists--

if not exists (select *

from Usr18005753ZengageDB.INFORMATION_SCHEMA.TABLES

where TABLE_NAME = 'answers')

begin

create table answers(

	ta_ID int primary key identity(1,1),
	testid int,
	questionid int,
	answers nvarchar(max),
	isCorrect nvarchar(10),

	foreign key (questionid) references question(id),
	foreign key (testid) references test(id)
	
);

end

--creates category table if not exists--

if not exists (select *

from Usr18005753ZengageDB.INFORMATION_SCHEMA.TABLES

where TABLE_NAME = 'category')

begin

create table category(

	id int primary key identity(1,1),
	name nvarchar(100),

);

insert into category(name)

values(N'Programming'),
	  (N'Web Development'),
	  (N'Maths'),
	  (N'English'),
	  (N'Science');

end

--creates test_category table if not exists--

if not exists (select *

from Usr18005753ZengageDB.INFORMATION_SCHEMA.TABLES

where TABLE_NAME = 'test_category')

begin

create table test_category(

	tc_ID int primary key identity(1,1),
	testid int,
	catid int,

	foreign key (testid) references test(id),
	foreign key (catid) references category(id)
);

end

--creates student_result table if not exists--

if not exists (select *

from Usr18005753ZengageDB.INFORMATION_SCHEMA.TABLES

where TABLE_NAME = 'student_result')

begin

create table student_result(

	st_ID int primary key identity(1,1),
	studid int,
	testid int,
	result int

	foreign key (studid) references student(id),
	foreign key (testid) references test(id)

);

end

--creates student_answers table if not exists--

if not exists (select *

from Usr18005753ZengageDB.INFORMATION_SCHEMA.TABLES

where TABLE_NAME = 'student_answers')

begin

create table student_answers(

sa_ID int identity(1,1) primary key,
testid int,
studid int,
questionid int,
answer nvarchar(max),

foreign key (testid) references test(id),
foreign key (studid) references student(id),
foreign key (questionid) references question(id)

);

end

