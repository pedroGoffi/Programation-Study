using System;

namespace checkPassword
{
  class Checker
  {
    public static string[] parseLine(string line)
    {
      string[] ret = {"",""};
      string tmp = "";
      int index = 0;
      foreach(char w in line)
      {
        if (w != '|')
        {
          tmp += w;
        }
        else {
          ret[index] = tmp;
          tmp = "";
          index += 1;
        }
      }
      ret[index] = tmp;
      return ret;
    }
    public static bool checkPass()
    {
      string[] file = System.IO.File.ReadAllLines
      (@"Senhas.txt");
      Console.Write("Usuario: ");
      string nome   = Console.ReadLine();
      Console.Write("Senha: ");
      string senha  = Console.ReadLine();
      bool logIn = false;
      foreach(string line in file)
      {;
        string[] parsedLine = parseLine(line);
        string tmpUser = parsedLine[0];
        string tmpPwd = parsedLine[1];
        if (nome == tmpUser && senha == tmpPwd){
          Console.WriteLine("Bem vindo: {0}", nome);
          logIn = true;
          break;
        }
      }
      if (!logIn){
        return false;
      }
      return true;
    }
    public static void Main()
    {
      if(!checkPass()){
        Console.WriteLine("Usuario invalido!");
        return;
      }
    }
  }
}
