using System.Security.Cryptography;

int faces, sorteando;

Console.WriteLine("---Rolagem de Dado---\n");

Console.WriteLine("Quantas faces? ");
faces = Convert.ToInt32(Console.ReadLine());

sorteando = RandomNumberGenerator.GetInt32(1, faces +1);

Console.WriteLine($"\nRolagem: {sorteando}");
