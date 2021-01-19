using System.Collections.Generic;

namespace GoRest.Models
{
    public class GetAllUsersModel
    {
            public int code { get; set; }
            public Meta meta { get; set; }
            public List<Data> data { get; set; }
    }
}
