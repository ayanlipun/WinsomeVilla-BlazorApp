namespace WisnomeVilla_Server.Model
{
    public class BlazorRoom
    {
        public int Id { get; set; }
        public string RoomName { get; set; }
        public bool IsActive { get; set; }
        public int Price  { get; set; }

        public List<BlazorRoomProp> BlazorRoomProps { get; set; }
    }
}
