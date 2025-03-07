# BethanysPieShopHRM

Module 6 Important Changes

Program.cs:
- We use AddDbContextFactory because in Blazor Server applications, using AddDbContext is not ideal since the same context would be shared across all components.

ApplicationState.cs
- ApplicationState is used to persist some data so that it can be accessed between unrelated components. This is not a Blazor thing, it is just a regular class injected through DI.
  This means that this data is lost on application restart.

Dependency Injection
- Classes higher in the hierarchy are injected into classes lower in the hierarchy. Hierarchy low to high goes: Component > Service > Repository > DbContext.
- The [Inject] tag injects an implementation just as if it was done by a constructor, except into a property instead of a private field.