using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGamingApp.Core.EnitityModel
{
    public class Base
    {
        public Base()
        {
            CreatedDate = DateTime.UtcNow;
        }
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "createdDate")]
        public DateTime CreatedDate { get; set; }
        [JsonProperty(PropertyName = "createdBy")]
        public string CreatedBy { get; set; }
        [JsonProperty(PropertyName = "updatedDate")]
        public DateTime? UpdatedDate { get; set; }
        [JsonProperty(PropertyName = "updatedBy")]
        public string UpdatedBy { get; set; }
        [JsonProperty(PropertyName = "deletedDate")]
        public DateTime? DeletedDate { get; set; }
        [JsonProperty(PropertyName = "deletedBy")]
        public string DeletedBy { get; set; }
        [JsonProperty(PropertyName = "isDeleted")]
        public bool IsDeleted { get; set; } 

    }
}
