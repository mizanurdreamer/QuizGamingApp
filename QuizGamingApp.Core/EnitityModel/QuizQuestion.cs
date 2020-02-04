using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGamingApp.Core.EnitityModel
{
    public class QuizQuestion : Base
    {
        [JsonProperty(PropertyName = "questionText")]
        public string QuestionText { get; set; }
        [JsonProperty(PropertyName = "displayOrder")]
        public int DisplayOrder {get;set;}
    }
}
