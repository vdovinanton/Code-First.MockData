## Information on Db structure migration
In the Package Manager Console write next commands:
> PM> Enable-Migrations -ProjectName "MockData.Entity" -StartUpProjectName "Mockdata"

Where keys ``` -ProjectName "project name in solution with DbContext" ```  ```-StartUpProjectName "startup project" ```

Аfter changing the structure of the object, enter:
> PM> Add-Migration AddOrderPrice -ProjectName "MockData.Entity" -StartUpProjectName "Mockdata"

> PM> Update-Database -ProjectName "MockData.Entity" -StartUpProjectName "Mockdata"

Where ``` AddOrderPrice ``` migration name






