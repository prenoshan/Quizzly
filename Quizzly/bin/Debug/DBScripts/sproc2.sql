if not exists (select * from sysobjects where name = 'sproc_getQs')

begin

exec dbo.sp_executesql @statement = N'

  create procedure sproc_getQs @testid int as

  select question

  from test_questions

  inner join question on question.id = test_questions.questionid

  where test_questions.testid = @testid;'

end