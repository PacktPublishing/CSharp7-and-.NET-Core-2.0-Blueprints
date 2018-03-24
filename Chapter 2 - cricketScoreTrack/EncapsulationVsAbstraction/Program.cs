using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationVsAbstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            EncryptionHelper encr = new EncryptionHelper();
            encr.TextToEncrypt = "Secret Text";
            encr.Encrypt();            
        }
    }
}
