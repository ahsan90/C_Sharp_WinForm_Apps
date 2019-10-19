------------------------------------:Pizza Ordering Application:----------------------------------------
--------------------------------------------------------------------------------------------------------

Requirements 1: Business Object – Pizza class

i.	Create a Pizza class which contains attributes for size, sauceType, an ingredient list (array or Collection), and a cost.
ii.	Create the getters/setters and the properties for each of these attributes.
iii.	Create a ToString() method which shows the pizza details.
iv.	Create a CalculateCost method which will calculate and set the cost based on the following information in Table 1.

This class should also have constants created for the ingredients that can be chosen for the pizza.  These should be contained in either an array or a collection.  When the program starts these should be used to build the list of ingredients that show up in the list box in the interface.  Note the class should be contained in a BusinessObjects folder.

Requirement 2:  Interface

Add a tab control to the application.  This should have three tab pages (Home, Pizza, Summary). 
The 'Home' tab page should contain an image related to pizza and the pizza shop name (which is based on your name ie. John Smith's Pizzaria).  When I run the program I should be able to tell who's submission it is based on the name of the business.  
The 'Pizza' tab page should contain the pizza ordering details. 
•	The user should be able to select pizza size (10", 12", or 14").  A control should be added which allows the user to select one of these three sizes.  
•	The user should be able to select their pizza sauce.  The two options are 'Regular' or 'Spicy'.  Regular should be selected by default.
•	The user should be able to select multiple toppings.  There should be at least 8 toppings to choose from.
•	There should be an "Add to Order" button on the 'Pizza' tab page.  When this is clicked, the program should validate that the size is selected.  
•	When the user Adds to Order, a pizza object should be created and added to a list of items which is a static attribute of the Pizza class (note this attribute is to be added to the Pizza class created above).


The 'Summary' tab page should provide a summary of the pizzas ordered so far.  When the 'Summary' tab page is selected, the collection of pizzas in the Pizza class should be used to build the summary information.  It should show each pizza on the order and a total cost.  It should have a 'Clear' button which will clear all pizzas on the current order.

Solution Approach:

Solution is provided based tradition windows form application. Object Oriented Programming technique is utilized in this solution where UI, Model and Logic layer are separated using different classes and its members.

A model class named Pizza is created to hold all the properties and other members including methods and constructor.

Another helper class named PizzaValidation is created for performing validation operation.

The whole program is solved based on the principle of multitier application. 
