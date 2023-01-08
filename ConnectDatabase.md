# Connection Database Step by step
## 1. Open appsettings.json
Add Connection String:

     "ConnectionStrings": {
        "url": "Data Source=.\\sqlexpress;Initial Catalog=<database_name>;Integrated Security=True"
      },

## 2. Define Database using for System

At Program.cs
Add this line:
  
      // add db for option builder

      builder.Services.AddDbContext<DbApp>(options =>
      {
          options.UseSqlServer(builder.Configuration.GetConnectionString("connectionString"));
      });
      
## 3. Add new folder Data and new Class DbApp
![image](https://user-images.githubusercontent.com/84958646/211192457-0f8bc779-ac75-4f1e-8de7-f22c2d85559b.png)

## 4. Add class entity in erd or classdiagram

## 5. Use FluentApi design 

## 6. Connect and test

