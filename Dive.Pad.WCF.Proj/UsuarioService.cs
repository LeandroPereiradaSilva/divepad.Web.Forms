using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Dive.Pad.WCF.Proj.Models;
using Sicred.Data.BaseModel.UnitOfWorks;

namespace Dive.Pad.WCF.Proj
{



    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UsuarioService" in both code and config file together.
    public class UsuarioService : IUsuarioService
    {
        public String GetMessage(String name)
        {
            return "Hello world from " + name + "!";
        }

        public Usuario ValidaLogin(String user, String senha) {
            try
            {
                UnitOfWork unit = new UnitOfWork();
                var usuario = unit.Usuarios.Where(c => c.UsuarioAplica == user).FirstOrDefault();

                if (true)
                {

                }


                Usuario UsuarioVM = new Usuario();
                UsuarioVM.DataCriacao = usuario.DataCriacao;
                UsuarioVM.id = usuario.id;
                UsuarioVM.Imagem = usuario.Imagem;
                UsuarioVM.Nome = usuario.Nome;
                UsuarioVM.Senha = usuario.Senha;
                UsuarioVM.User = usuario.UsuarioAplica;
                //UsuarioVM.UsuarioFacebook = Convert.ToBoolean(usuario.UsuarioFacebook);




                return UsuarioVM;
            }
            catch (Exception)
            {

                throw;
            }






        }

        //IUsuarioService RetornaUsuario(String user) {

        //    IUsuarioService u = new IUsuarioService();
        //};
    }
}
