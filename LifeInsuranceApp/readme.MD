-----------------------:Problem Description:----------------------
------------------------------------------------------------------


This program provides the solution of the following problem :

1.	Situations:  Life Insurance Salespersons are paid by commission of their sales. 
2.	Create a Windows Application form that uses text boxes to obtain the Sales Person's name (lastname, firstname in separate textboxes) and the insurance amount of the policy sold.  Include:

a.	Calculate button to display the commission dollar amount earned, as well the rate received based on the policy sales amount.  

b.	Summary button to display the total number count of policies, the total insurance dollars sold, and the total commission earned based on those individual sales for the salesperson being processed.  Also, include a running total of all  these totals for all salespersons processed and they should be listed in a section below the individual salesperson totals.  NOTE:  Once you move from one salesperson to a new salesperson the previous information and totals are reset, i.e. in the summary you only have the current salesperson summary and the running total showing everyone's totals.  

c.	Clear button should clear the current individual salesperson information from the summary window.

d.	Clear All button should clear the summary running totals of all sales persons after confirming the operation with the user.


3.	Include validation to check for missing data. If the user clicks on the Calculate button without first entering a Lastname/Firstname and the policy amount, display a message box indicating they is missing data.  Also, you need to make sure to not display a summary before any data is entered; you cannot calculate an average when no items have been calculated.  You can check the number of employees in the Summary event handler or disable the Summary button until the first order has been calculated.
4.	The following table provide the commission rate of based on policy amounts:

 
	Insurance Amount		  Commission Rate
	
	   <1000				0.5,
	  <100,000				0.1,
	 <1,000,000
		or				0.2
	 >1,000,000				
	

Solution Approach:

Solution is provided based tradition windows form application. Object Oriented Programming technique is utilized in this solution where UI, Model and Logic layer are separated using different classes and its members.

A model class named SalesPerson is created to hold all the properties and other members including methods and constructor.

Another helper class named SalesPersonUtility is created for performing logical operation(e.g adding or updating a salesperson object to the repository by meeting specific criteria). 

The whole program is solved based on the principle of multitier application. 


