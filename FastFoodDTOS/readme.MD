-----------------------------:Problem Description:----------------------------
------------------------------------------------------------------------------

Scenario:\
You are establishing a fast food outlet and require a drive-thru ordering point-of-sale system in order to take a customers’ order and generate the purchase total owing.

Requirements:

1.	Create a 2-TierGUI WindowsFormApplication.(i.e. Presentation and Domain Business Layer).

Presentation Tier:\
2.	Create an appropriate design for aFast Food Drive-Thru Order System to accepta customers’ order with the following interface requirements:

i.	Add a MenuStrip with the following structure:

	File\    
		Exit\    
	Order\ 
		Order\
		Checkout Order\
	•Code Exitfunctionality from menu command option.\
	•Code Place Orderfunctionality of the menu according tostep 2ebelow.\
	•Code CheckoutOrder functionality of the menu according tostep 3 below
	
ii. User should be able to enter Customer: LastName&FirstName in separate TextBoxes
iii. Use CheckBoxesin a GroupBoxto allow meal typeselection, but the one person could order several different mealsand different respective quantities:(Hence:  Each item will require a separate quantity input area)\
	->Hamburger:  $5.00\
	->Sub:  $6.00iii\
	->Fish:  $8.00
	
iv. A ComboBox should be used to allow upsize/combo selectionoptions:

	->Meal only - Base price listed above.\
	->Combo Meal -	0.5 times base price, NOTE:  Selection applies to all items on the order.\
	->Upsize Combo Meal -	0.75times base price.

** Validate your data entry via simple MessageBoxs**

Business Tier:

v. Create a business class called Orderwith the required attributes to support steps 2 b/c/d as stated above.\
vi. Your class will require a parameterized constructor to support steps 2g and 3.\
vii .Your business class should contain a Calculate Order method, accessed upon selecting the menu option Place Order, where this business tier method will figure out:\
	-> Costvia aCASE structure for sections 2c/2dabove. HINT:ComboBox selected index is a good Integer to use in a Case Structure.\
viii. Your Checkout Order Menu Command shouldopen the Checkout Summary form in step 3.

3. Create a Checkout Order Summary formthat will be displayed upon clicking the CheckoutOrder command on the main Drive-ThruOrder form. This form should be designed in such a way to display allcustomer/orderinformation entered and calculated results, (via your business class object),in a user friendly readable manner.












