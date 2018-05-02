.NET to .NET Standard or .NET Core
----------------------------------
This is a simple demo showing the results of getting code from full .NET to .NET Standard.

1. The only project was `FullNetLibrary`, with all `.cs` files
2. Add a new Shared Class Library project named `SharedLibrary`
3. Copy all `.cs` files from `FullNetLibrary` to `SharedLibrary`
4. Delete all `.cs` files from `FullNetLibrary`
5. Add reference in `FullNetLibrary` to `SharedLibrary` using the Shared Projects tab in the Add Reference dialog
6. YOU ARE NOW WHERE YOU STARTED - so you can build the `FullNetLibrary` project _and have the exact same output dll as in step 1_
7. Add a new .NET Standard Class Library project named `NetStandardLibrary`
8. Add reference in `NetStandardLibrary` to `SharedLibrary` using the Shared Projects tab in the Add Reference dialog
9. In `NetStandardLibrary` add NuGet package reference to `Newtonsoft.Json`
10. In `NetStandardLibrary` add NuGet package reference to `Microsoft.EntityFrameworkCore`
11. Use the `NETSTANDARD2_0` compiler constant to add compiler directives to the `PersonFactory.cs` file so it contains the original EF code for the full .NET project, and new EF Core code for the netstandard project

The result is that the `FullNetLibrary` still builds the exact same code in the exact same way as before we started this exercise. And we now have a `NetStandardLibrary` that builds _most_ of the same code - the only differences being where we had to accomodate differences between full .NET and netstandard.