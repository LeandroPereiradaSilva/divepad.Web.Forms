using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace DivePadConsoleWCF
{
    class Program
    {
        static void Main(string[] args)
        {

            using (ServiceHost servHost =
             new ServiceHost(
                typeof(Dive.Pad.WCF.Proj.UsuarioService),
                new Uri[] { new Uri("http://localhost:8078") }))


                {
             try
             {
               servHost.Description.Behaviors.Add(
                 new ServiceMetadataBehavior() { HttpGetEnabled = true });
               servHost.AddServiceEndpoint(
                 typeof(Dive.Pad.WCF.Proj.IUsuarioService), 
                 new BasicHttpBinding(),             
                 "Publicacao");
               servHost.Open();
               Console.WriteLine("O serviço está rodando. Pressione ENTER para interromper.");
               Console.ReadLine();
               servHost.Close();
             }
             catch (Exception ex)
             {
               Console.WriteLine("Houve um erro de comunicação. {0}", ex.Message);
               Console.ReadLine();
               servHost.Abort();
             }
           }
        }
    }
}
