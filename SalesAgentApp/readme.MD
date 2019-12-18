-----------------------------:Problem Description:----------------------------
------------------------------------------------------------------------------

Scenario:

A Commission Income Agency needs a system to process sales agent commission incomes.


Requirements:	**Remember your internal documentation!

1.Create a multi-tiered GUI Window form application.i.e.Presentation and Business Domain Tiers.

2.Create an appropriate form to accept agent salesinformation with the following:

	-> Note:Everything is on one form, therefore when you click Calculate the results populate appropriate interface element objects in order to provide the information to the user.
	
	a.User should be able to enter their LastName, FirstName, ande-mail in separate TextBoxes.
	
	b.Use Radio buttons in a GroupBox to allow agenttype selection:\
		i. Junior Agent\
		ii. Agent\
		iii. Senior Agent
	c.A Textbox should be used for the sales amount being calculated.
	
	d.Create aBase Class AgentObject that will receive all the entered data with a calculate method for the commission levelsgiven the following formulas:NOTE:Create all classes within the solution, no need to implement .DLL
		i.Agent commission levels based on sales amount, the ranges are:
		
		1.Under $1,000: Rate of 2%\
		2.Between $1,000 and $5,000: Rate of 4%\
		3.Over $5,000: Rate of 6%
		
		ii.Calculatecommission income by multiplying the Sales Amount by Commission Rate.
		
		
		
		
	e. Create a derived Class for Junior Agentswith an overriddencalculate method.Hint:  Use a Boolean field in order to identify if they are a Junior Agentor not on the form interface that will be used in the method signature.
		
		i. The calculate methods fora Junior Agent will receive .5% LESS in commission compared to an agent.**At the respective commission level**
	
	f. Create aderived Class for Senior Agentswith an overridden calculate method.  Hint:  Use a Boolean field in order to identify if they are a Senior Agentor not on the form interface that will be used in the method signature.
		
		i. The calculate methods fora Senior Agent will give them an additional 1.5% in commission.**At the respective commission level**
	
	g.Add a Calculate Button that will use the appropriate base or derived calculation class method:i.Calculate the Commission Income on a given sales amount.
	
	h.Once calculated the information should be added to the existing form(i.e. Commission Rate / Commission Income)where you entered all the data, in disabled interfaceobjects (i.e. user cannot type in).For Junior or Senior agentsa message on the interface indicating theircommission rate breakdown is required