using System.Runtime.Serialization;

namespace ECommerceLiteAlexandre.Models
{
    [DataContract]
    public class BaseModel
    {
        [DataMember]
        public int Id { get; protected set; }
    }
}
