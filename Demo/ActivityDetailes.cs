using System.Runtime.Serialization;

namespace Demo
{
    [DataContract]
    public class ActivityDetailes
    {
        [DataMember]
        public string Id
        {
            get; internal set;
        }

        [DataMember]
        public string Name
        {
            get; internal set;
        }

        internal int CaloriesPerHourse
        {
            get; set;
        }
    }
}
