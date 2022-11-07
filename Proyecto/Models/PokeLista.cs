using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Proyecto.Models
{
    public class PokeLista
    {
        [JsonProperty("count")]
        public long cantidad { get; set; }
        
        [JsonProperty("next")]
        public Uri siguiente { get; set; }
        [JsonProperty("previous")]
        public object anterior { get; set; }
        [JsonProperty("id")]
        public long idHabilidad { get; set; }
        [JsonProperty("nameAbility")]
        public string nombreHabilidad { get; set; }
        [JsonProperty("results")]
        public List<Pokemon> listaPokemones { get; set; }
    }

}
