using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDserver;



namespace SHINS
{
    internal class conx
    {
        [Obsolete]
        public static void Main(string[] args)
        {
            Connection1.IConnection a = (Connection1.IConnection)Activator.GetObject(typeof(ConxImpl), "tcp://localhost:8085/obj");
            Console.Write("Le client est prêt.....");
            a.Connecter();
            a.LoginValidation("123", "rasha", out bool res);
            if (res)
            {
                Console.WriteLine("login ");
            }
            else
            {
                Console.WriteLine("err");
            }
            _ = Console.ReadLine();
        }
    }
}
