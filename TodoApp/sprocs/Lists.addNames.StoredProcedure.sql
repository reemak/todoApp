use TodoApp

go

alter proc Lists.addNames
@listName varchar(max)
as

begin

/*
exec lists.getlists
*/
	insert listnames
	select @listName
end
