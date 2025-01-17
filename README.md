# BethanysPieShopHRM
Module 4 Important Changes
EmployeeDetail.razor:
- @page "/employeedetail/{EmployeeId:int}" indicates the route will expect an int.
- @rendermode InteractiveServer activates interactivity so that the DOM can be dinamically updated using Blazor's Server mode.

EmployeeDetail.razor.cs:
- Uses OnInitialized because we need data before continuing. EmployeeOverview.razor.cs uses OnInitializedAsync because it doesn't need data loaded, since we can show a loading text meanwhile.

EmployeeOverview.razor:
- @attribute [StreamRendering(true)] activates Stream Rendering mode which allows to show a loading icon/text while the data is being fetched.

Program.cs:
- .AddInteractiveServerComponents() / .AddInteractiveServerRenderMode(); activate Blazor's Interactive Server mode.

