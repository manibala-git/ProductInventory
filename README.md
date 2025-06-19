# ProductInventory

ProductInventory is an ASP.NET Core Web API project designed to manage product inventory efficiently. It demonstrates clean architecture principles with a layered structure including Controllers, Services, Repositories, and Data access. The application uses SQLite as the database and integrates AutoMapper for object mapping and Swagger for API documentation.

## 🚀 Features

- Create, Read, Update, and Delete (CRUD) operations for products
- Category management using custom value converters
- AutoMapper integration for DTO mapping
- Swagger/OpenAPI support for API documentation
- Clean architecture with separation of concerns

## 🛠 Technologies Used

- ASP.NET Core Web API
- Entity Framework Core with SQLite
- AutoMapper
- Swagger/OpenAPI
- C#
- Visual Studio / .NET CLI

## 📁 Project Structure

ProductInventory.Api/ ├── Controllers/ │ └── ProductController.cs ├── Data/ │ └── ApplicationDbContext.cs ├── Models/ │ └── Products.cs, Category.cs, DTOs, Requests ├── Repositories/ │ └── ProductRepository.cs ├── Services/ │ └── ProductService.cs ├── Program.cs ├── appsettings.json



## 🧰 Installation Instructions

1. **Clone the repository**:
   ```bash
   git clone https://github.com/manibala-git/ProductInventory.git
   cd ProductInventory

2. Open the project in Visual Studio or your preferred IDE.

3. Configure the database:

Ensure SQLite is installed.
Check the connection string in appsettings.json.
4. Run migrations (if applicable):

    dotnet ef migrations add InitialCreate
    dotnet ef database update

5. dotnet run



