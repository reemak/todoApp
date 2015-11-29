use TodoApp

go

alter proc Lists.getLists
as

begin

/*
exec lists.getlists
*/
	select name from listnames
end
