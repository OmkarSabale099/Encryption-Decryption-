using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDApp
{
    internal class Class1
    {
        public static void Encrypt()
        {
            EncryptionDecryptionData.EncryptFile(@"D:\WorkSpace\Data\Output.txt", @"D:\WorkSpace\Data\Input.txt", @"D:\WorkSpace\PGPKeys\publickey.asc", true, true);

        }

        public static void Decrypt() 
        {
            EncryptionDecryptionData.DecryptFile(@"D:\WorkSpace\Data\Output.txt", @"D:\WorkSpace\PGPKeys\privatekey.asc", "Pass@123".ToCharArray(), @"D:\WorkSpace\Data\DecryptedData.txt");

        }
    }
}
