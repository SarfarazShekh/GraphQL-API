# GraphQL-API

#### 1. Install All Necessary packeges 
     Install-Package Microsoft.EntityFrameworkCore
     Install-Package Microsoft.EntityFrameworkCore.SqlServer
     Install-Package Microsoft.EntityFrameworkCore.Tools    
###### Migration
         Add-Migration Initial
         Update-Database		 
		
#### 2. For Graph QL Server 
        Install-Package HotChocolate.AspNetCore
        Install-Package GraphQL.Server.Transports.AspNetCore

#### 3. Configure GraphQL Service And Endpoint:
	    Program.cs:
			builder.Services.AddGraphQLServer().AddQueryType<Query>();
			app.MapGraphQL("/graphql");
#### 4. For Applying Sorting, Projection, Filtering 
        HotChocolate.Data.EntityFramework
###### Update Program.cs
        builder.Services.AddGraphQLServer().AddQueryType<Query>().AddProjections().AddFiltering().AddSorting();
#### 5 Request Query 
	query{
		  superheroes{
			 name,
			 description,
			 superpowers(order: {superPower:DESC}){
				  superPower,
				  description
			}
		  }
		}	
