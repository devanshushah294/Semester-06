Create Database ApiDemo
use ApiDemo

Create or Alter PROCEDURE API_Person_SelectAll
as
Begin
	Select [dbo].[Person].[PersonID],
	[dbo].[Person].[Name],
	[dbo].[Person].[Email],
	[dbo].[Person].[Contact]

	From [dbo].[Person]
	order by [dbo].[Person].[Name], [dbo].[Person].[Email]
End

Create or Alter PROCEDURE API_Person_SelectByID
@PersonID int
as
Begin
	Select [dbo].[Person].[PersonID],
	[dbo].[Person].[Name],
	[dbo].[Person].[Email],
	[dbo].[Person].[Contact]

	From [dbo].[Person]

	where [dbo].[Person].[PersonID] = @PersonID
End

Create or Alter PROCEDURE API_Person_DeleteByID
@PersonID int
as
Begin
	Delete from [dbo].[Person]
	where [dbo].[Person].[PersonID] = @PersonID
End

Create or Alter Procedure API_Person_Add
@Name varchar(50),
@Email varchar(50),
@Contact varchar(50)
as
Begin
	Insert into [dbo].[Person]([dbo].[Person].[Name],[dbo].[Person].[Email],[dbo].[Person].[Contact])
	values(@Name,@Email,@Contact)
End
Insert into person values('Diya','diya@gmail.com','9439932934')

Create or Alter Procedure API_Person_UpdateByID
@PersonID int,
@Name varchar(50),
@Email varchar(50),
@Contact varchar(50)
as
Begin
	Update [dbo].[Person] 
	set [dbo].[Person].[Name] = @Name,
		[dbo].[Person].[Contact] = @Contact,
		[dbo].[Person].[Email] = @Email
	where [dbo].[Person].[PersonID] = @PersonID
End