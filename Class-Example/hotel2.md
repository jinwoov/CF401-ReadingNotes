
```cs
[Route ("api/Hotels/Rooms")]


[HttpGet, Route("{hotelID}/{roomID}")]
public async Task<ActionResult<HotelRooms>> GetHotelRooms(int id)
{
    var hotelRooms = await _context.GetHotelRoom(id);

    if (hotelRooms == null)
    {
        return NotFound();
    }

    return hotelRooms;
}
```