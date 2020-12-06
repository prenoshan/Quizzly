if not exists (select * from sysobjects where name = 'sproc_getAnswers')

begin

exec dbo.sp_executesql @statement = N'

create procedure sproc_getAnswers @questionid int as

select answers

from answers

inner join question on question.id = answers.questionid

where answers.questionid = @questionid;'

end