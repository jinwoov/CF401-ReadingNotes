```cs

return _context.Hotels.Include(x => x.HotelRooms)
                .ThenInclude(x => x.Rooms)
                .ThenInclude(x => x.RoomAmenities)
                .ThenInclude(e => e.Amenities)
                .ToList();

```


```cs
in hotelbyID
 var hotel = _context.Hotels.Where(x => hotelID == x.ID)
                Include(x => x.HotelRooms)
                .ThenInclude(x => x.Rooms)
                .ThenInclude(x => x.RoomAmenities)
                .ThenInclude(e => e.Amenities)
                .Single()
```

- After DTO

```cs
in hotelbyID

var hotelRooms = await _context.HotelRooms.Where(r => hotelID == x.ID)
                                    .Include(d => d.Room)
                                    .ThenInclude(x => x.RoomAmmenities)
                                    .ThenInlclude(a => a.Amenities)
                                    .ToListAsync();

List<HotelRoomDTO> room = new List<HotelRoomDTO>();

foreach (var hr in hotelRooms)
{
    room.Add(new HotelRoomDTO
    {
        Rate = hr.Rate,
        PetFriendly = hr.PetFriendly,
        RoomNumber = hr.RoomNumber,
        Room = new RoomDTO
        {
            
        }
    }
    )


}
```

- in hotel service in get hotel by idea

DTO: data transfer object
    - control what the user sees
    - for our hotel its usually good practice to have entity you have

sent to the end point and 

--- 
# lecture

