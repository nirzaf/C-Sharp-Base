// See https://aka.ms/new-console-template for more information

using System.Data.Common;

Console.WriteLine("Hello, World!");

BookRecord b1 = new()
{
   Id = 1,
   Name = "C# Fundamentals"
};

BookClass b2 = new()
{
   Id = 1,
   Name = "C# Fundamentals"
};


var name = BookStructWithStaticMethods.GetName("Fazrin", "farook");

var newName = BookStaticClass.GetName("Fazrin", "farook");
Console.WriteLine(name);
Console.WriteLine(newName);

BookChapterClass bc = new();

bc.GetBookRecord();

Console.ReadLine();



// public class NewBookClass(int Id, string Name);



// Console.WriteLine(b1);
//
//
// Console.WriteLine(b2);


//
// BookStruct b4 = new();
//
//
// var id = BookStaticClass.Id;

// if (b1 == b2)
// {
//    Console.WriteLine("both are same books");
// }
// else
// {
//    Console.WriteLine("both are different books"); 
// }


public class BookClass 
{
   public int Id { get; set; }
   public string Name { get; set; }

   public void GetBookRecord()
   {
      BookRecord b1 = new();
   }
}


public class BookChapterClass : BookClass
{
   public string ChapterName { get; set; }
}

public record BookRecord 
{
   public int Id { get; set; }
   public string Name { get; set; }
}


public struct BookStruct
{
   public int Id { get; set; }
   public string Name { get; set; }
}

public static class BookStaticClass
{
   public static int Id { get; set; }
   //public string Name { get; set; }
   
   public static string GetName(string FirstName, string SecondName)
   {
      return FirstName + " " + SecondName;
   }

   // public string GetAddress(string FirstAddress, string SecondAddress)
   // {
   //    return FirstAddress + " " + SecondAddress;
   // }
}

public struct BookStructWithStaticMethods
{
   public static int Id { get; set; }
   public string Name { get; set; }
   
   public static string GetName(string FirstName, string SecondName)
   {
      return FirstName + " " + SecondName;
   }
   
   public string GetAddress(string FirstAddress, string SecondAddress)
   {
      return FirstAddress + " " + SecondAddress;
   }
}