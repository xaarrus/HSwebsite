using System.ComponentModel.DataAnnotations;
using static System.Net.WebRequestMethods;

namespace HSwebsite.Models
{
    public class BookingModel
    {
        public class TagModel
        {
            public string Tag { get; set; }
        }
        public class BedModel 
        { 
            public bool Busy { get; set; }
            public Place BedPlace { get; set; }
            public enum Place { up, down }
        }
        public class RoomModel
        {
            public int RoomId { get; set; }
            public string RoomDescription { get; set; } = string.Empty;
            public string RoomImgUrl { get; set; } = "https://t-cf.bstatic.com/xdata/images/hotel/max1024x768/250205351.jpg?k=e39fdee8d4f63d15e4531bbc55deed12006e59ccadb8edc992af020afb9da84f&o=&hp=1";
            [Range(1,3, ErrorMessage = "Floor between 1-3")]
            public int Floor { get; set; }
            public IEnumerable<BedModel> BedList { get; set; } = new List<BedModel>();
            public IEnumerable<TagModel> TagList { get; set; } = new List<TagModel>();
            public bool Badroom { get; set; }
            public GenderValue Gender { get; set; }
            public enum GenderValue { Men, Wooman, ManAndWooman }
        }
    }
}
