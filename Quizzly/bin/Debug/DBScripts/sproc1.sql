if not exists (select * from sysobjects where name = 'sproc_getTests')

begin

exec dbo.sp_executesql @statement = N'

 create procedure sproc_getTests @category nvarchar(100) as

  select test.name

  from test

  inner join test_category on test_category.testid = test.id
  
  inner join category on category.id = test_category.catid

  where category.name = @category;'

end