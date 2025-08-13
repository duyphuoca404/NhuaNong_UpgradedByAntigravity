// Decompiled with JetBrains decompiler
// Type: EncryptionKeyGenerator
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System;
using System.Security.Cryptography;
using System.Text;

#nullable disable
public class EncryptionKeyGenerator
{
  public static byte[] GenerateEncryptionKey(string password, string salt, int keySizeInBytes)
  {
    byte[] bytes1 = Encoding.UTF8.GetBytes(salt);
    byte[] bytes2 = Encoding.UTF8.GetBytes(password);
    byte[] numArray = new byte[bytes1.Length + bytes2.Length];
    Array.Copy((Array) bytes1, 0, (Array) numArray, 0, bytes1.Length);
    Array.Copy((Array) bytes2, 0, (Array) numArray, bytes1.Length, bytes2.Length);
    using (SHA256 shA256 = SHA256.Create())
    {
      byte[] hash = shA256.ComputeHash(numArray);
      byte[] destinationArray = new byte[keySizeInBytes];
      Array.Copy((Array) hash, (Array) destinationArray, Math.Min(keySizeInBytes, hash.Length));
      return destinationArray;
    }
  }
}
