# SalesRegistryCSharp
Final project for C# II course

Sales registry allowing to add, edit and delete customer records, sort records, print invoices and sales reports for selected time period
Most companies have a need to maintain information about their customers and/ or sales.

The main purpose of the Customer Registry application is to enable company's personnel to add, edit and delete records containing information about its customers and sales details. 

All records are saved in XML file upon application closing, and records manipulations (add, edit, delete).

Additional features include:

- Sorting records by

- Customer's full name;
- Customer's country;
- Customer's email address;
- Product price;
- Payment date

- Displaying records for a selected month of the year;
- Displaying records for a selected year;
- Printing sales report for a selected month of the year (including print preview);
- Printing sales report for a selected year (including print preview);
- Printing an invoice for a selected customer (including print preview)

 ![interface](https://cloud.githubusercontent.com/assets/14193564/13039304/287eecd0-d395-11e5-9a2e-ac361c661f10.png)


Figure 1 Application Interface

# Usage Instructions

## Add Record

Pressing "Add Record" button will bring up a form where the information can be entered (see Figure 2)

![addrecord](https://cloud.githubusercontent.com/assets/14193564/13039302/28654af0-d395-11e5-8527-b60c37f45f9f.png)
 
Figure 2 Adding a New Record

First name, surname and email address are required fields and if those are not entered a corresponding warning message will be displayed.

![warningemail](https://cloud.githubusercontent.com/assets/14193564/13039299/285054ce-d395-11e5-957a-252e3b0c2aa8.png)
![warningname](https://cloud.githubusercontent.com/assets/14193564/13039301/285347f6-d395-11e5-892c-1b8b4b85f688.png)
 
Figure 3 Warning Message Examples

A product price is set according to the product name automatically thus the price field editing is disabled.

Expiry date is set automatically to be one year ahead of the payment date.

After all information had been filled and after pressing "OK" button the main window will be displayed again and the list of records will be updated to include the new record. The total number of customers and the total amount of sales will also be updated to reflect the changes made.

## Edit Record

In order to edit an existing record that record will need to be selected from the list first. If no record is being selected a warning message will appear.

![warningselectrecord](https://cloud.githubusercontent.com/assets/14193564/13039300/2851055e-d395-11e5-99bc-868c6692c453.png)
 
Figure 4 Warning Message: Record needs to be selected

After selecting a record and pressing "Edit Record" button a form will be shown containing all the information for the selected record and any required editing can be performed.

Pressing "Cancel" button will discard any changes made. In order to save changes the user needs to press "OK" button. The main window will be displayed and the changes will be reflected in the records list.

## Delete Record

In order to delete a record that record needs to be selected first otherwise a warning message will be shown. After choosing a record to be deleted a confirmation message will be shown to ensure that the record is not being deleted by accident.

![confirmdeleterecord](https://cloud.githubusercontent.com/assets/14193564/13039305/287f680e-d395-11e5-81e6-01fe54fe8aa8.png)
 
Figure 5 Confirmation Message Upon Record Deletion

All changes including adding, editing and deleting records are saved in an XML file enabling to continue working with the list of records the next time the application is started and ensuring that the information is not lost. On application start up any records stored in the XML file are retrieved and displayed.

## Sort Records

The records can be sorted by customer’s full name, country, email, product price and payment date by pressing buttons located above the aforementioned fields or from the menu Tools->Sort by.

![sort](https://cloud.githubusercontent.com/assets/14193564/13039297/284436da-d395-11e5-8227-c0a9c8c207c3.png)

Figure 6 Sorting Records

Records can also be sorted by certain month of a certain year by selecting the time period in the first date box located in the “Display Options” section. The month can be selected either by pressing left and right arrows or by clicking the month being displayed and selecting required month fron the drop down list.
It is also possible to display the records for the whole year by selecting the year from the second date box located in the “Display Options” section. The year can be chosen by pressing up and down arrows or by highlighting the year in the box and pressing up and down arrow buttons on the keyboard. 

![selectmonth](https://cloud.githubusercontent.com/assets/14193564/13039309/2898781c-d395-11e5-8e28-47891f8a9716.png)
![selectyear](https://cloud.githubusercontent.com/assets/14193564/13039296/28392c86-d395-11e5-9603-fc8f2117e108.png)

Figure 7 Selecting Time Period

The records for a selected time period can also be sorted by customer’s name, country, email, product price and payment date the same way as mentioned earlier. Once the records for selected time period had been sorted by some value, a blue refresh button will appear. Clicking this button will restore unsorted order of the records for the currently selected time period. In order to display all the records (unsorted) contained in the list a green refresh button can be pressed. Alternatively this action can be performed from the menu Tools->Restore Records to Original Order.



## Printing

The sales reports for the selected time periods and the invoices for a selected record can be printed from the application by pressing the corresponding buttons located in the “Printing Options” section or from the menu File->Print.

![printingoptions](https://cloud.githubusercontent.com/assets/14193564/13039469/33795c5e-d397-11e5-9661-69bd3f834723.png)

Figure 8 Printing Options

The sales reports and the invoices for selected records can also be previewed before printing. There is an option to adjust layout of the reports and invoices before printing by clicking “Enable editing button”. Generated documents can be sent for printing by clicking “Print” button. 

The sales reports and the invoices for selected records can also be previewed before printing by pressing the corresponding buttons or from the menu File->Print Preview.
![printmenu](https://cloud.githubusercontent.com/assets/14193564/13039308/288ca88e-d395-11e5-8b8b-dd8e1a18df8f.png)
![printpreviewmenu](https://cloud.githubusercontent.com/assets/14193564/13039306/288ba218-d395-11e5-8843-2fc3b79bd114.png)

Figure 9 Menu: Print and Print Preview

## UML Diagramm
![umldiagram](https://cloud.githubusercontent.com/assets/14193564/13039298/284e9c1a-d395-11e5-8875-8fcaa1e844b7.png)

## Class Diagram
![classdiagram](https://cloud.githubusercontent.com/assets/14193564/13039467/2bb54b5e-d397-11e5-9b30-ff295df2adae.png)
