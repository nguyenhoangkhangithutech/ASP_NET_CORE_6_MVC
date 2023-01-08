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
