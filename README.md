# Byte-Bakes

# Project Overview

This project focuses on developing an online pastry store application that allows customers to customize their orders based on dietary needs and preferences. Many traditional pastry shops lack an effective online presence or functionality that enables users to easily customize orders while considering their caloric intake and dietary restrictions. Our solution aims to provide an intuitive platform that facilitates seamless order placement and customization, ensuring that customers can enjoy their favorite treats without compromising their health goals.

## Key Features
- **Customizable pastries**: Users can choose flavors, ingredients, toppings, and dietary options like vegan or low-calorie.
- **Calorie tracking**: Integration of FDA-compliant calorie labeling to help users make informed choices.
- **Streamlined user experience**: An intuitive interface built using ASP.NET Core MVC for frontend development, and C# and MySQL for backend and database management.

## Technologies Used
- **Frontend**: ASP.NET Core MVC, HTML, CSS (Bootstrap), JS
- **Backend**: C#
- **Database**: MySQL, Azure Data Studio
- **ORM**: Entity Framework
- **Version Control**: Git & GitHub
- **Project Management**: Jira

## Design Patterns
- **Observer**: For newsletter subscribers.
- **Singleton**: For database access and session management.
- **Facade**: To simplify complex subsystems.
- **Builder**: For creating custom pastry orders.
- **Strategy**: For offering standard, healthy, or vegan options.
- **Adapter**: For payment gateway integration.
- **Chain of Responsibility**: For handling multiple object requests.

## Timeline
- **Proposal**: September 16th to September 30th
- **Requirements & Design**: October 1st to October 21st
- **Coding & Testing**: October 21st to November 25th
- **Final Presentation & Report**: November 25th to December 11th

## Installation
- **Clone**: Clone the repository from the main branch
- **MySQL Server**: Create a docker container for the MySQL server using these commands:
  ```bash
  docker run -d -e 'ACCEPT_EULA=Y' -e 'MSSQL_SA_PASSWORD=Pass123!' --name my-mssql-server -p 1433:1433 mcr.microsoft.com/mssql/server:2019-latest
  ```
- **Connection String**: Update the connection string in the appsettings.json file to this:
  ```bash
  "DefaultConnection": "Server=localhost,1433;Database=ByteBakesDb;User Id=sa;Password=Pass123!;TrustServerCertificate=true;"
  ```
- **Apply Migrations**: Run the following commands to set up the database schema:
  ```bash
  dotnet ef migrations add InitialCreate
  dotnet ef database update
  ```
- **Run the Application**: use the following commands to start the app:
  ```bash
  dotnet run
  ```
  You can also use these commands to run the app and allow auto reload when making changes:
  ```bash
  dotnet watch run
  ```

## Usage
- **Subscribe**: Navigate to the subscribe section and enter an email address
- **View Subscribers**: Query the database to view all subscribers:
  ```bash
  SELECT * FROM dbo.Subscribers;
  ```
  View uniqe subscribers:
  ```bash
  SELECT DISTINCT Email
  FROM dbo.Subscribers
  ORDER BY Email;
  ```
