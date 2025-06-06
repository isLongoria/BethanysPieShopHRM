# BethanysPieShopHRM

Module 8 Important Changes

- ICountryDataService and IJobCategoryDataService were moved to their correct folder.
- EmployeeOverview and its sub-components EmployeeCard and QuickViewPopup were moved to the client.
- IEmployeeDataService also needed to be moved to the client, if it wasn't then client code would not be aware of it.

EmployeeOverview.razor:
- Blazor by default will prerender the WASM component on the server, but only the HTML of it... no interactivity.
  When the interactive WASM has been downloaded, the prerendered HTML will be discarded and the WASM will be loaded.
  This makes the component being initialized twice... once when the server prerenders it, and twice when it is downloaded.
  This can lead to issues such as a small flicker when the WASM replaces the prerender, or variablies initialized twice.
  To fix this, we use @rendermode @(new InteractiveWebAssemblyRenderMode(prerender:false)) so that components are not prerendered.