using System;

namespace LexerParser_CSharp {
  public class HelloWorld {
      public static void Main() 
      {
          Lexer lex = new Lexer();
          Console.WriteLine("--- Lexer Parser ---");
          Console.WriteLine("Veuillez entrer un calcul.");
          String result = Console.ReadLine();
          lex.parseText(result);
          Console.WriteLine(lex.ToString());
      }
  }
}
