# BethanysPieShopHRM
Module 5 Important Changes
EmployeeCard.razor.cs:
- public Employee Employee needs the [Parameter] tag to be able to be passed in as a parameter.
- public EventCallback<Employee> EmployeeQuickViewClicked is used from a child component so that a parent component can act on it.

EmployeeOverview.razor:
- EmployeeQuickViewClicked="ShowQuickViewPopup" is a parent listening to the EventCallback on the child and passing the action to be run when triggered.
- @attribute [StreamRendering(true)] was commented out since that is only used when serving static content. Once interativity is needed it is replaced by @renderMode InteractiveServer.

QuickViewPopup.razor.cs
- OnParametersSet() runs whenever a parameter is changed and updates the view accordingly.

@renderMode InteractiveServer had to be added to QuickViewPopup, EmployeeCard and EmployeeOverview because they all have a parent-child relationship.