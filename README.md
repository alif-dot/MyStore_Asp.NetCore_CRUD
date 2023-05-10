# MyStore

![Screenshot (13)](https://github.com/alif-dot/MyStore_Asp.NetCore_CRUD/assets/62230465/68b76264-91e4-4033-837d-f458797d8dcd)

![Screenshot (14)](https://github.com/alif-dot/MyStore_Asp.NetCore_CRUD/assets/62230465/7c2cfb4f-8d22-4a18-b13e-3b12268e755e)

![Screenshot (15)](https://github.com/alif-dot/MyStore_Asp.NetCore_CRUD/assets/62230465/2273e299-ac4e-4ef4-b836-588ba7bb69c6)

***************************
SQL Queries to create the clients table and to insert rows: 
CREATE TABLE clients (
    id INT NOT NULL PRIMARY KEY IDENTITY,
    name VARCHAR (100) NOT NULL,
    email VARCHAR (150) NOT NULL UNIQUE,
    phone VARCHAR(20) NULL,
    address VARCHAR(100) NULL,
    created_at DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP
);

INSERT INTO clients (name, email, phone, address)
VALUES
('Bill Gates', 'bill.gates@microsoft.com', '+123456789', 'New York, USA'),
('Elon Musk', 'elon.musk@spacex.com', '+111222333', 'Florida, USA'),
('Will Smith', 'will.smith@gmail.com', '+111333555', 'California, USA'),
('Bob Marley', 'bob@gmail.com', '+111555999', 'Texas, USA'),
('Cristiano Ronaldo', 'cristiano.ronaldo@gmail.com', '+32447788993', 'Manchester, England'),
('Boris Johnson', 'boris.johnson@gmail.com', '+4499778855', 'London, England');
*****************************

An ASP.NET Core web application with SQL Server database connection and CRUD (Create, Read, Update, Delete) operations is a powerful and flexible solution for building web applications that require persistent storage and data manipulation capabilities. It leverages the features of ASP.NET Core and the relational database capabilities of SQL Server to provide a robust and scalable application architecture.

In this application, ASP.NET Core serves as the framework for building the web application, handling HTTP requests, and generating responses. It provides a modular and extensible approach to develop web applications, allowing you to organize your code into controllers, views, and models.

The SQL Server database is used as the backend storage for the application. It provides a reliable, scalable, and high-performance relational database management system. SQL Server supports structured query language (SQL) for interacting with the database, making it easy to perform CRUD operations such as creating new records, retrieving existing records, updating records, and deleting records.

To establish a connection between the ASP.NET Core web application and the SQL Server database, you can utilize the Entity Framework Core (EF Core). EF Core is an object-relational mapping (ORM) framework that simplifies database operations by mapping database entities to corresponding classes in your application. It abstracts away the complexities of database access, allowing you to work with entities and perform CRUD operations using familiar object-oriented programming techniques.

The CRUD operations can be implemented using EF Core's LINQ (Language Integrated Query) syntax. You can define models representing database entities and their relationships, create migrations to generate the necessary database schema, and use LINQ queries to perform CRUD operations on the entities.

For example, to create a new record, you can create an instance of the corresponding model, populate its properties with the desired data, and use EF Core to insert the entity into the database. To retrieve records, you can use LINQ queries to filter, sort, and project data from the database. Updating and deleting records involve modifying or removing the corresponding entities and saving the changes back to the database.

By combining ASP.NET Core, SQL Server, and EF Core, you can build a robust web application that seamlessly integrates with a SQL Server database. This architecture enables efficient data storage, retrieval, and manipulation, while providing a scalable and maintainable solution for managing your application's data.
