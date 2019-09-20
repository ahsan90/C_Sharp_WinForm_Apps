

Problem Description:

This program provides the solution of the following problem(Textbook: ch#5, Ex-2):

Ever heard of acid rain? This is rainfall with a very low pH. Write an
application that will enable you to display the pH level for a swimming
pool and whether an additive is needed or not. The pH is a measure of
how acidic or basic the water is and is typically given on a 0–14 scale.
Below 7.0 is defined as acidic, with 7 being neutral. Levels much above
7 are said to be basic or alkaline. Everything that enters a pool has a
pH value. To have pH in balance the water is adjusted with additions
of pH increasers (bases) or pH decreasers (acids) to achieve the range
of 7.2–7.8. Allow the user to input the pH level number. Display a message indicating the health (i.e., acidic, neutral, or alkaline) and whether an additive is required. If an additive is required, identify the type. The
water should be described as acidic, requiring bases, when the pH is
lower than 7. Consider the pH level as neutral for pH levels in the range
7–7.8 and alkaline, requiring acid for pH levels greater than 7.8. Display
an appropriate message when invalid values are entered.

Solution Approach:

The Problem is solved based on traditional Windows Form Application. The presentation layer is kept separated from logic layer. The components of the presentation layer include textbox input for entering pH level, buttons for executing and resetting the form, rich textbox for displaying results and few more other components. Appropriate validation is performed according to the program requirements.


