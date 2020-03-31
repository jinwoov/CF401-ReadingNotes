# Database
- it the model class you have to add `System.ComponentModel.DataAnnotations`
- having to set `[Datatype(typegoesinhere)]` allow you to set only instructed data
- usig the stringLength sets the maximized length of string that will be store in the database
- To change the schema and change the database, you can
```
dotnet ef migrations add MaxLengthOnNames
```
to your console, then type
```
dotnet ef database update
```
to update the database
- another implementation you can put is column
- column tag can be attributed to specifies which column it belongs to in the database
- `[Required]` tag is used when you require field where it can't be null if info is not provided
- `[key]` is assigned to give to assign the foreign key which will be assigned by computer
- DBSM is database management system that stores data in such a way that it becomes easier to retrieve, manipulate and produce information
- The benefit of having the DBSM concept is that it is more relatable to real world entity and it creates less redundancy in values and brings consistency at the same time.
- DBMS can categorized in three components: administrators, designers, end users.
- Administrator maintain the DBMS and are responsible for administrating the database
- Designer - Designer are the group of people who actually on the designing part
- end users are who actually reap the benfits of having a DBMS.