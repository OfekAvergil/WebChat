using System.ComponentModel.DataAnnotations;

namespace WebAPI
{
    public class User
    {
        [Key]
        public string name { get; set; }
        public string nick { get; set; }

        [DataType(DataType.Password)]
        public string password { get; set; }

        public string image { get; set; }

        public List<Contact> chats { get; set; }

    }
}
