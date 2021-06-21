using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace emailengineapi.Model
{
    public class JsonStructure
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        public Section Section { get; set; }

    }
    public class Section
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string CssClass { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Property { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string PropertyValue { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Section> ChildSections { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Style { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Element> Elements { get; set; }
    }
    public class Element
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "cssclass")]
        public string CssClass { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "property")]
        public string Property { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string PropertyValue { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "style")]
        public string Style { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "DataTypeCode")]
        public string DataTypeCode { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "link")]
        public string Link { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "imageUrl")]
        public string imageUrl { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Element> Elements { get; set; }
    }
}
