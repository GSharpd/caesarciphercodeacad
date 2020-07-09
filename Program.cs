using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

      Console.WriteLine("Write your secret message:");

      string userMessage = Console.ReadLine();

      char[] secretMessage = userMessage.ToCharArray();

      char[] encryptedMessage = new char[secretMessage.Length];
     
      for (int i = 0; i < secretMessage.Length; i++)
      {
        char letter = secretMessage[i];

        int letterPos = Array.IndexOf(alphabet, letter);

        int encryptedLetter = (letterPos + 3) % alphabet.Length;

        char letterEncoded = alphabet[encryptedLetter];

        encryptedMessage[i] = letterEncoded;
      }

      string encodedMessage = String.Join("",encryptedMessage);

      Console.WriteLine($"{encodedMessage}");

      //static string Decrypt()
      //{
        
      //}
      
    }
  }
}