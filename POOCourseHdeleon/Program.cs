using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOCourseHdeleon
{
    class Program
    {
        static void Main(string[] args)
        {
            /*          Cerveza oCerveza = new Cerveza(5, 6.5M,30);
                      oCerveza.Fermentacion();
                      Console.ReadLine();*/

            Leon oLeon = new Leon();
            oLeon.Correr();
            oLeon.Nombre = "Simba";

            Buitre oBuitre = new Buitre();
            oBuitre.Volar();
            oBuitre.Nombre = "Condorito";


        }
    }
}
