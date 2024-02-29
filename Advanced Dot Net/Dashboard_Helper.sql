Create Procedure PR_Dashboard_Counts
As
Begin
	Declare @StateCount int
	Select @StateCount = Count(*) from [LOC_State]

	Declare @CityCount int
	Select @CityCount = Count(*) from [LOC_City] where CityName like 'R%'

	Select 
		@StateCount as StateCount,
		@CityCount as CityCount
End

Create or Alter Procedure PR_Dashboard_StateWiseCityCount
as
Begin
	Declare @Temp Table
	(
		StateID int,
		StudentCount int
	)
	Insert into @Temp
	Select 
		StateID, Count(Distinct CityID) from LOC_City
		Group by StateID
	
	Select 
		LOC_State.StateID,
		LOC_State.StateName,
		tmp.StudentCount
	from LOC_State
	
	left outer join @Temp as tmp
	on tmp.StateID = LOC_State.StateID
End