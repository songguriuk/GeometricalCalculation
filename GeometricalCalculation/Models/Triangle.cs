using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace GeometricalCalculation.Models
{
    public class Triangle
    {
        [JsonProperty(PropertyName = "triangleId")]
        public Guid TriangleId { get; set; }

        [JsonProperty(PropertyName = "base")]
        public Double Base { get; set; }

        [JsonProperty(PropertyName = "height")]
        public Double Height { get; set; }

        [JsonProperty(PropertyName = "area")]
        public Double Area { get; set; }
    }
}