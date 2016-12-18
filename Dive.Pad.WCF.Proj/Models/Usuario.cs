using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace Dive.Pad.WCF.Proj.Models
{
    [DataContract]
    public class Usuario
    {
        [DataMember]
        public string Nome { get; set; }
        [DataMember]
        public string User { get; set; }
        [DataMember]
        public string Senha { get; set; }
        [DataMember]
        public DateTime DataCriacao { get; set; }
        [DataMember]
        public string Imagem { get; set; }
        [DataMember]
        public long id { get; set; }
        [DataMember]
        public string MensagemErro { get; set; }
        [DataMember]
        public long id_facebook { get; set; }
    }
}
