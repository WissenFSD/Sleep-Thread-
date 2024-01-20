// See https://aka.ms/new-console-template for more information

// Derleyiciyi belirli bir zaman bekletmek için aşağıdaki komutu kullanabilirsiniz.

for (int i = 0; i < 100; i++)
{
    Console.WriteLine(i);


    //Thead.Sleep metodu derleyiciyi belirli bir süre bekletmek için kullanılır
    //MEtodun içerisi milisaniye cinsinden değer almaktadır. 

    Thread.Sleep(1000); // 1000 milisaniye 1 saniye eder
}

