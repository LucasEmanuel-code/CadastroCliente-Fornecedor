using System.ComponentModel.DataAnnotations;
using System;
using System.Reflection.Metadata;
using Calculo;
using Classes;
using Diretorio;
using Funcoes;
using Tela;
using Componentes.cs;

namespace Helloword
{
 
    class Programa
    {
        static void Main(string[] args)
        {
            Menu.Criar();

        }
    }
}
#region Codigos de Teste das aulas de Orientação a Objetos 
/*class Animal
      {
          public string teste;
          public virtual string teste2()
          {
              return "";
          }
      }

      class Macaco : Animal
      {
          public override string teste2()
          {
              return "sss";
          }
      }*/
/* partial class Animal
{
    public string teste;
    partial void tt();

}

partial class Animal
{
    public string teste2;
    partial void tt()
    {
        Console.WriteLine("teste");
        }
}*/
//==============================================================
/*  Email.Instancia.Corpo = "bla bla bla";
           Email.Instancia.Titulo = "Chegou um Email para você";
           Email.Instancia.Origin = "bacalhau@muitobem.com.br";
           Email.Instancia.Destino = "zuzuzuzu@muitobem.com.br";

           Email.Instancia.EnviarEmail();

           var a = new Animal();
           a.teste = "";

           var c = new Cachorro();
           c.Idade = 1;
           Console.WriteLine(c.Idade);

           c.Idade2 = 1;

           Console.WriteLine(c.Idade2);*/

/*
var cachorro = new Cachorro();
cachorro.Latir();


Console.WriteLine("=======================Cadastro de usuario==========================");
usuario c = new usuario();
c.Nome = "Danilo 2";
c.Telefone = "23232323";
c.CPF = "333333";
c.Gravar();
foreach (Base cl in new usuario().Ler()) 
{
    Console.WriteLine(cl.Nome);
    Console.WriteLine(cl.Telefone);
    Console.WriteLine(cl.CPF);
    Console.WriteLine("============================================================");

}
Console.WriteLine("========================Cadastro de usuario===========================");
usuario u = new usuario();
u.Nome = "usuario";
u.Telefone = "323232";
u.CPF = "33333";
u.Gravar();

foreach (Base us in new usuario().Ler())
{
    Console.WriteLine(us.Nome);
    Console.WriteLine(us.Telefone);
    Console.WriteLine(us.CPF);
    Console.WriteLine("===================================================");
}
/*Ferramentas f = new Ferramentas();
bool d = f.ValidarCPF("sdsdsdss");

Console.WriteLine("======================Cadastro de usuario========================");
usuario u = new usuario();
u.Nome = "sss";
u.Telefone = "323232";
u.CPF = "33333";
u.Olhar();*/

/*foreach (usuario us in usuario.Lerusuarios())
{
    Console.WriteLine(us.Nome);
    Console.WriteLine(us.Telefone);
    Console.WriteLine(us.CPF);
    Console.WriteLine("===================================================");
}*/
#endregion