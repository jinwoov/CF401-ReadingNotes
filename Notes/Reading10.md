# LINQ

- LINQ is language integrated query that you can use to query a data source and execute to you liking
- Using LINQ you can query object, SQL, XML
- All LINQ has to contain three parts
    1. Obatining the data source
    2. create a query
    3. Execute the query
- Data source in this context can array or data
- During the second phase the syntax that are used is
```
var queryLondonCustomers = from cust in customers
                           where cust.City == "London"
                           select cust;
```
- `from` define where the data source is 
- `where` filters the data
- `select` type of element that will be returned 
- `IQueryable<T>` are called queryable types and you can use it to query databasse as well. In the context of `t` it can be replace with database name followed by name of object.
- Usually query execution is deferred until you iterate over the query variable in `forEach` loop. This is called `deferrred execution`
- To execute the code immediately you can use `.ToList()` or `.ToArry` which will for the execution