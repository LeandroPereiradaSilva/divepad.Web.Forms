using Dive.Pad.WCF.Proj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Dive.Pad.WCF.Proj
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUsuarioService" in both code and config file together.
    [ServiceContract]
    public interface IUsuarioService
    {
        [OperationContract]
        String GetMessage(String name);

        [OperationContract]
        Usuario ValidaLogin(String user, String senha);

        //IUsuarioService RetornaUsuario(String user);




        //string Nome { get; set; }
        //string Usuario { get; set; }
        //string Senha { get; set; }
        //DateTime DataCriacao { get; set; }
        //string Imagem { get; set; }
        //long id { get; set; }
        //string MensagemErro { get; set; }
        //long id_facebook { get; set; }
    }
}
