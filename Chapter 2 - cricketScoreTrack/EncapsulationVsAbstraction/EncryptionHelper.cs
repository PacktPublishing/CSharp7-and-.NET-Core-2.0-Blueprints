using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationVsAbstraction
{
    public class EncryptionHelper
    {
        public string TextToEncrypt = "";
        public void Encrypt()
        {
            string salt = GenerateSalt();
            // Encrypt the text contained in the TextToEncrypt variable
            SaveToDatabase();
        }

        private string GenerateSalt()
        {
            return "";
        }           
        
        private void SaveToDatabase()
        {

        }
    }
}
