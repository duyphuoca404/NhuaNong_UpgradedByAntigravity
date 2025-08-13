// Decompiled with JetBrains decompiler
// Type: NhuaNong.Utils.EncryptionHelper
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

#nullable disable
namespace NhuaNong.Utils
{
  internal class EncryptionHelper
  {
    private static readonly string secur = "aFg2jKl1mNpQr3u5x8z2Cv4ExHp4v7y0";

    public static string Base64UrlEncode(byte[] bytes)
    {
      return Convert.ToBase64String(bytes).Replace('+', '-').Replace('/', '_').Replace("=", "");
    }

    public static byte[] Base64UrlDecode(string input)
    {
      int num = input.Length % 4;
      if (num > 0)
        input += new string('=', 4 - num);
      input = input.Replace('-', '+').Replace('_', '/');
      return Convert.FromBase64String(input);
    }

    public static string Encrypt(string plainText)
    {
      return EncryptionHelper.Base64UrlEncode(EncryptionHelper.EncryptFunction(plainText));
    }

    public static string Decrypt(string cipherText)
    {
      return EncryptionHelper.DecryptFunction(EncryptionHelper.Base64UrlDecode(cipherText));
    }

    public static byte[] EncryptFunction(string plainText)
    {
      using (Aes aes = Aes.Create())
      {
        aes.Key = Encoding.UTF8.GetBytes(EncryptionHelper.secur);
        aes.IV = ((IEnumerable<byte>) aes.Key).Take<byte>(16).ToArray<byte>();
        ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
        using (MemoryStream memoryStream = new MemoryStream())
        {
          using (CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream, encryptor, CryptoStreamMode.Write))
          {
            using (StreamWriter streamWriter = new StreamWriter((Stream) cryptoStream))
              streamWriter.Write(plainText);
          }
          return memoryStream.ToArray();
        }
      }
    }

    public static string DecryptFunction(byte[] cipherBytes)
    {
      using (Aes aes = Aes.Create())
      {
        aes.Key = Encoding.UTF8.GetBytes(EncryptionHelper.secur);
        aes.IV = ((IEnumerable<byte>) aes.Key).Take<byte>(16).ToArray<byte>();
        ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
        using (MemoryStream memoryStream = new MemoryStream(cipherBytes))
        {
          using (CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream, decryptor, CryptoStreamMode.Read))
          {
            using (StreamReader streamReader = new StreamReader((Stream) cryptoStream))
              return streamReader.ReadToEnd();
          }
        }
      }
    }

    public static string EncryptedXml(string pathXML)
    {
      string s1 = File.ReadAllText(pathXML);
      byte[] bytes = Encoding.UTF8.GetBytes(EncryptionHelper.secur);
      byte[] numArray = new byte[16];
      using (Aes aes = Aes.Create())
      {
        aes.Key = bytes;
        aes.IV = numArray;
        ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
        using (MemoryStream memoryStream = new MemoryStream())
        {
          using (CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream, encryptor, CryptoStreamMode.Write))
          {
            using (StreamWriter streamWriter = new StreamWriter((Stream) cryptoStream, Encoding.UTF8))
            {
              using (StringReader stringReader = new StringReader(s1))
              {
                string s2;
                while ((s2 = stringReader.ReadLine()) != null)
                {
                  string base64String = Convert.ToBase64String(encryptor.TransformFinalBlock(Encoding.UTF8.GetBytes(s2), 0, s2.Length));
                  streamWriter.WriteLine(base64String);
                }
              }
            }
          }
          return Convert.ToBase64String(memoryStream.ToArray());
        }
      }
    }

    public static string DecryptedXml(string pathXML)
    {
      string s = File.ReadAllText(pathXML);
      byte[] bytes = Encoding.UTF8.GetBytes(EncryptionHelper.secur);
      byte[] numArray = new byte[16];
      using (Aes aes = Aes.Create())
      {
        aes.Key = bytes;
        aes.IV = numArray;
        ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
        using (MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(s)))
        {
          using (CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream, decryptor, CryptoStreamMode.Read))
          {
            using (StreamReader streamReader = new StreamReader((Stream) cryptoStream))
            {
              StringBuilder stringBuilder = new StringBuilder();
              while (!streamReader.EndOfStream)
              {
                string str = Encoding.UTF8.GetString(Convert.FromBase64String(streamReader.ReadLine()));
                stringBuilder.AppendLine(str);
              }
              return stringBuilder.ToString();
            }
          }
        }
      }
    }
  }
}
