using System;

namespace pomoFocus
{
  class Program
  {
    static void Main(string[] args)
    {
      //Start();
      Menu();
    }

    //static void Menu()
    static void Menu()
    {
      Console.Clear();
      Console.WriteLine("BEM VINDO AO POMOFOCUS");
      Console.WriteLine("VAMOS COMEÇAR, SELECIONE O FORMATO DE TEMPO DESEJADO: ");
      Console.WriteLine("OBS.: RECOMENDA-SE 25 MINUTOS E  5 MINUTOS DE INTERVALO ");
      Console.WriteLine("1 - SEGUNDOS");
      Console.WriteLine("2 - MINUTOS");
      Console.WriteLine("3 - HORAS");
      Console.WriteLine("0 - SAIR");
      var opcao = int.Parse(Console.ReadLine());
      int pomodoro = 1;
      if(opcao == 1)
      {
        Console.WriteLine("OK, AGORA INFORME QUANTOS SEGUNDOS DESEJA FICAR FOCADO: ");
        var segundos = int.Parse(Console.ReadLine());
        PreStart(pomodoro*segundos);
      }
      else if(opcao == 2)
      {
        Console.WriteLine("OK, AGORA INFORME QUANTOS MINUTOS DESEJA FICAR FOCADO: ");
        var minutos = int.Parse(Console.ReadLine());
        Start((pomodoro*minutos)*60);
      }
      else if (opcao == 3)
      {
        Console.WriteLine("OK, AGORA INFORME QUANTAS HORAS DESEJA FICAR FOCADO: ");
        var horas = int.Parse(Console.ReadLine());
        Start((pomodoro*horas)*3600);
      }
      else if (opcao == 0)
      {
        System.Environment.Exit(0);
      }
      else 
      {
        Console.WriteLine("ERRO!!! TENTE NOVAMENTE...");

      }

    }

    static void PreStart(int pomodoro)
    {
      Console.Clear();
      Console.WriteLine("SE PREPARE...");
      Thread.Sleep(1000);
      Console.WriteLine("COLOQUE O CELULAR EM MODO AVIÃO");
      Thread.Sleep(1000);
      Console.WriteLine("BONS ESTUDOS");
      Thread.Sleep(2500);
      
      Start(pomodoro);
    }
    static void Start (int pomodoro)
    {
      //int pomodoro = 1;
      int setBreak = 5;
      
      while(pomodoro > 0)
      {
        Console.Clear();
        pomodoro--;
        Console.WriteLine(pomodoro);
        Thread.Sleep(1000);
      }
      
      
      //Console.Clear();
      Console.WriteLine("TEMPO FINALIZADO, AGORA VOCÊ TEM 5 MINUTOS DE DESCANSO");
      Thread.Sleep(2500);
      while(setBreak > 0)
      {
        
        Console.Clear();
        setBreak--;
        Console.WriteLine(setBreak);
        Thread.Sleep(1000);
      }
       
    }
  }
}