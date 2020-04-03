using System.Runtime.Serialization;

namespace ECommerceLite.Models
{
    [DataContract]
    public class BaseModel
    {
        [DataMember]
        public int Id { get; set; }
    }
}
