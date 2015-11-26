using System;
using System.Security.Cryptography;
using System.Text;
using System.IO;
 
class TrippleDESCSPSample
{
 
    static void Main()
    {
        TripleDESCryptoServiceProvider tDESalg = new TripleDESCryptoServiceProvider();
        string sData = "Here is some data to encrypt.";
        string key = "Here is some more key";
        MD5 md5 = new MD5CryptoServiceProvider();
        tDESalg.Key = md5.ComputeHash(Encoding.Unicode.GetBytes(key));
        byte[] Data = EncryptTextToMemory(sData, tDESalg.Key, tDESalg.IV);
        Console.WriteLine(new ASCIIEncoding().GetString(Data));
        string Final = DecryptTextFromMemory(Data, tDESalg.Key, tDESalg.IV);
        Console.WriteLine(Final);
        Console.ReadLine();      
    }
 
    public static byte[] EncryptTextToMemory(string Data,  byte[] Key, byte[] IV)
    {
        MemoryStream mStream = new MemoryStream();
        CryptoStream cStream = new CryptoStream(mStream, new TripleDESCryptoServiceProvider().CreateEncryptor(Key, IV), CryptoStreamMode.Write);
        byte[] toEncrypt = new ASCIIEncoding().GetBytes(Data);
        cStream.Write(toEncrypt, 0, toEncrypt.Length);
        cStream.FlushFinalBlock();      
        byte[] ret = mStream.ToArray();
        cStream.Close();
        mStream.Close();
        return ret;
    }
 
    public static string DecryptTextFromMemory(byte[] Data,  byte[] Key, byte[] IV)
    {
        MemoryStream msDecrypt = new MemoryStream(Data);
        CryptoStream csDecrypt = new CryptoStream(msDecrypt, new TripleDESCryptoServiceProvider().CreateDecryptor(Key, IV), CryptoStreamMode.Read);
        byte[] fromEncrypt = new byte[Data.Length];
        csDecrypt.Read(fromEncrypt, 0, fromEncrypt.Length);
        return new ASCIIEncoding().GetString(fromEncrypt);       
    }
}
