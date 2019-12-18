----------------------------:Problem Description:----------------------------
-----------------------------------------------------------------------------

1.	Write an MDI application to simulate a simple text editor.  Allowing the user to create/open multiple documents, each in a separate child Form within the MDI Parent window.  For the text editor child form, use one big TextBox control with its Multiline property set to true or a RichTextBox control. You will require a SaveDialogue and OpenDialogue component in order to create/open a text file.
2.	The main startup form (MDI Parent) should have a MenuStrip with an Open menu item to open previously saved files in a childMDI Form; the child forms should have a MenuStrip with a Save menu item to save their text to a file.  Use the file handling that you previously learned about and display the name of the file in the form's title bar.
3.	Validate your text box in order to assure that text has been entered before attempting to save to a file.
4.	Add a toolbar and status bar to the application forms, and code toolbar icons for Close, Save, Open appropriately.
5.	Add a calendar DateTimePickerControl to your MDI Child form ToolBar menu selection. This will allow you to pick a date to concatenate to your written text.  Your written text should be followed with the following:\
	Date Written:   ..date from D_T_Picker..
