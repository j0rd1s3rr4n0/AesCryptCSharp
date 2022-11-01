using System.Security.Cryptography;
using System.Text;

namespace AesCryptCSharp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
    class AES {
        /*
         * 
         * Característiques:
         *    • Xifrat de bloc: mida 128 bits.
         *    • Clau de xifrat de 128,192 o 256 bits.
         *
         *  IV (Vector inicialització):
         *    - 16 bytes (1 bloc) EVITA BLOCS IGUALS
         *  Clau (Key):
         *    - 256 bytes
         *
         *  Cipher mode (bit a bit):
         *      ECB: Cifra bloc a bloc 
         *      CBC: Cifra bloc amb bloc anterior i XOR( if 0->1 else 1->0)
         */
        public string Encrypt(string message, string pass, string salt)
        {
            try { 
                using (AesCryptoServiceProvider aes = new AesCryptoServiceProvider())
                {

                    /* 
                     * DeriveBytes --> Rfc2898DeriveBytes
                     * S'inicialitza una nova instancia de la clase Rfc2898DeriveBytes utilitzant una contrasenya,
                     * un valor "salt" i un numero d'iteraciones para derivar la clave.
                    */
                    DeriveBytes rgb = new Rfc2898DeriveBytes(pass, Encoding.Unicode.GetBytes(salt), 9);
                    /* 
                     * key GetBytes --> KeySize >> 3
                     * Retorna la clau pseudoaleatoria del aes.KeySize fent servir operadors bit a bit " >> 3 "
                     * El operador >> desplaza el operando izquierdo a la derecha el número de bits definido por el operando derecho.
                     * Entonces KeySize es tratado bit a bit internament ja fa un xor
                     * 
                    */
                    byte[] key = rgb.GetBytes(aes.KeySize >> 3);
                    /*
                     Fa exactament el mateix d'abans pero per a el Vector de inicialización aixi dons fent
                    */
                    byte[] iv = rgb.GetBytes(aes.BlockSize >> 3);
                
                    aes.Mode = CipherMode.CBC;
                    aes.Key = key;
                    aes.IV = iv;
                    ICryptoTransform encryptor = aes.CreateEncryptor();
                    byte[] data = Encoding.Unicode.GetBytes(message);
                    byte[] dataencrypt = encryptor.TransformFinalBlock(data, 0, data.Length);
                    return Convert.ToBase64String(dataencrypt);
                }
            }
            catch {
                return Encoding.Unicode.GetString(Encoding.ASCII.GetBytes("ERROR UNDEFINED"));
            }
        }
        public string Decrypt(string message, string pass, string salt)
        {
            try { 
                using (AesCryptoServiceProvider aes = new AesCryptoServiceProvider())
                {
                    //
                    DeriveBytes rgb = new Rfc2898DeriveBytes(pass, Encoding.Unicode.GetBytes(salt), 9);
                    //
                    byte[] key = rgb.GetBytes(aes.KeySize >> 3);
                    //
                    byte[] iv = rgb.GetBytes(aes.BlockSize >> 3);

                    aes.Mode = CipherMode.CBC;
                    aes.Key = key;
                    aes.IV = iv;
                    ICryptoTransform decryptor = aes.CreateDecryptor();
                    byte[] data = Convert.FromBase64String(message);
                    byte[] datadecrypt = decryptor.TransformFinalBlock(data, 0, data.Length);
                    return Encoding.Unicode.GetString(datadecrypt);
                }
            }
            catch {
                return Encoding.Unicode.GetString(Encoding.ASCII.GetBytes("ERROR UNDEFINED"));
            }
        }
    }
}