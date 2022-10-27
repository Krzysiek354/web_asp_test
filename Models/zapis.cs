using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace WebApplication2.Models
{
    public class zapis
    {
        public zapis(string zmm) 
        {
            File.WriteAllText(@"C:\Users\Krzys\Desktop\studia_A\sem_4\prog_lab\zadanie_1\repozytorium_C#\WebApplication2\WebApplication2\do_pliku.txt",zmm);
        }
    }
}