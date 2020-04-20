Controller

```cs
- in construct
    _hotel = hotel


```

In service
```cs
public class HotelService : IhotelManager
{
    private static readonly HttpClient client = new HttpClient();
    // always make it static per class not the object because it will cause clutterness
    // brining in http library
    // 

    public Task<List<Hotel>> GetAllHotel()
    {
        //Get all the hotels from our 3rd party api
            Has o b
        // set my destination
        var destination = @"https://localhost:44320/api";
        string route = "hotels";

        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));


        // make my get call
        // add jsonserializer that is in the visual studio
        var streamTask = await client.GetStreamAsync($"{destination}/route");
        var repositories = await JsonSerializer.DeserializeAsync<List<`nameoftheclass`>>(streamTask);
        


        // receive my response

        // deserialize my response


        // send it back

    }
}
```

- has to run the api server running
-bringing in the hotel class to the model
- 

`Azure`

```cs //in hotel




```

web app api
1. right click and publish
2. app service create new
3. create profile
4. asyncsolution
5. create
6. publish 
7. /api/hotels/ -- page is not working
8. azure portal
9. app services
10. api solution 
11. configuration is where the 
12. connection string 
13. Sql database on left side 
14. create sql database
15. roesource group is name
16. database name `Hotelapi`
17. server create
18. server has to be unique
19. admin login make it people who can see it
20. @Bacon123!
21. no elastic pool
22. basic

34 connection string ado net
35. change passworld

"DefaultConnection": and paste the adonet

36. open package manager cosole and run `update-database`
37. sql server authentication

server
login password

38. properties
39. virtual ip address
back to the database
from asyn soultion
40. firewal rule
