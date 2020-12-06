if not exists (select * from sysobjects where name = 'sproc_GetTestNames')

begin

exec dbo.sp_executesql @statement = N'

  create procedure sproc_GetTestNames @studid int as 
  
  select name 

  from test

  inner join student_result on student_result.testid = test.id
  
  inner join student on student.id = student_result.studid

  where studid = @studid;'

end