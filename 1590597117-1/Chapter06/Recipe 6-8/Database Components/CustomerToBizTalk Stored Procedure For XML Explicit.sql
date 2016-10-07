if exists  (select * from sysobjects where name = 'CustomerToBizTalk' and type = 'P')
    drop proc CustomerToBizTalk
go
CREATE procedure CustomerToBizTalk
AS
/*
**
** Object: CustomerToBizTalk
**
** Description: Retrieves records from the Customer Table for the SQL Receive Adapter Recipe
**              shadow table.
**
*/
BEGIN

    /*Populate temp table with records that will be returned to caller*/
    Select top 1 CustomerID
		, CustomerName
		, Address
		, City
		, Region
		, PostalCode
		, RecordStatus
    Into	#TempCustomer
    From	Customer
	Where	RecordStatus = 1
		
    /*Update Status of retrieved record from Customer table*/
	Update	Customer
	Set		RecordStatus = 0
	Where	CustomerID = (select CustomerID from #TempCustomer)

    /*Return records to caller*/
	select	1	as Tag, NULL	as Parent
		, NULL	as [Customer!1!element]
		, CustomerID as [Customer!1!CustomerID!element]
		, CustomerName	as [Customer!1!CustomerName!element]
		, Address as [Customer!1!Address!element]
		, City as [Customer!1!City!element]
		, Region as [Customer!1!Region!element]
		, PostalCode as [Customer!1!PostalCode!element]
		, RecordStatus as [Customer!1!RecordStatus!element]
	from	#TempCustomer
	FOR XML EXPLICIT


    /*Set rowcount back to normal operation*/
    drop table #TempCustomer
END

go
grant execute on dbo.CustomerToBizTalk to public
go
