// See https://aka.ms/new-console-template for more information

using Constructor;

/*
Book book1 = new Book();
book1.title = "My new Writing";
book1.Author = "John jr";
book1.pages = 200;*/


//using Constructor
Book book2 = new Book("New Journey", "Riyan", 800);
Console.WriteLine(book2.title);

Book book3 = new Book();//constructor with no argument we have created in our Book class  isliye koi error nhi de raha 
