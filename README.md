# CrudBuddy

An opportunity to assess a candidate's working ability in a .NET environment.

## The Task

We are excited to have you work on this project! Your goal is to implement CRUD (Create, Read, Update, Delete) operations for the **Product** entity in the CrudBuddy Web API. The API will be consumed by a frontend and eventually be part of a larger project — please complete this enhancement as if it were a real feature heading to production.

**The codebase is on the `develop` branch.**

### What's Already Set Up

- A .NET 10 Web API project with Entity Framework Core and SQLite
- A `Product` entity defined in `src/CrudBuddy.API/Data/Product.cs`
- A `ProductsContext` (EF Core DbContext) wired up and ready to use
- A pre-seeded SQLite database (`src/CrudBuddy.API/Data/products.db`) with sample data
- A `ProductController` with TODO comments outlining the expected operations

### What You Need to Implement

Implement the following operations in `ProductController.cs`:

- **Create** a product
- **Read** all products
- **Read** a single product by its ID
- **Update** a product
- **Delete** a product

We are intentionally not specifying routes, HTTP verbs, status codes, or response shapes — we want to see how you design the API.

## Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0) (this project targets `net10.0`)

## Getting Started

1. Clone the repository:

   ```bash
   git clone https://github.com/Kev8144/CrudBuddy.git
   ```

2. Navigate to the API project:

   ```bash
   cd CrudBuddy/src/CrudBuddy.API
   ```

3. Run the project:

   ```bash
   dotnet run
   ```

   The API will start and serve on the URLs shown in the console output. OpenAPI documentation is available in the development environment.

## Project Structure

We would love to see how you structure your project.

## Branch Structure

We would love to see how you get your changes into main.

## Deployment & Release

You can explain verbally how you would deploy this project.

## Notes

Feel free to add any information you deem relevant — your thought process, design decisions, trade-offs you considered, or enhancements you would add given more time.

## Technology

- .NET 10
- Entity Framework Core
- SQLite
