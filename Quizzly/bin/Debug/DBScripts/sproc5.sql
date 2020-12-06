if not exists (select * from sysobjects where name = 'sproc_Memo')

begin

exec dbo.sp_executesql @statement = N'

create procedure sproc_Memo @testid int, @studid int as

select question, answers, answer
  
  from answers

  inner join question on question.id = answers.questionid

  inner join student_answers on student_answers.questionid = answers.questionid

  where isCorrect = ''true''

  and answers.testid = @testid
  
  and student_answers.studid = @studid;'

 end