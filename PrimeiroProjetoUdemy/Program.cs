﻿using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace PrimeiroProjetoUdemy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.BackgroundColor = ConsoleColor.Green;
            int op;

            do
            {
                op = Banco.CriadorDeMenu("Inicio", "Cadastro,Clientes cadastrados,Excluir cadastro,Sair");
                Banco.OpcoesDoMenu(1, op);
            }
            while (op != 4);

        }




    }
}