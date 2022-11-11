using static System.Console;

using System.Text.Json;
using static ShopProject.Shop.Helper;
using ShopProject.Models;



var db = File.ReadAllText("DemoDb/database.json");
var json = JsonSerializer.Deserialize<Db>(db);



MainApp();

void MainApp() 
{
    int enterData =  0;
    Tech product  = new Tech();
    int price     = 0;
    int range     = 0;
    int check     = 0;

    try 
    {
        WriteLine("Programm has been started!....");
        WriteLine("Пожалуйста выберите продукт ( введите 1 или 2 или 3) ");
        WriteLine("1 - Телефон");
        WriteLine("2 - Компьютер");
        WriteLine("3 - Телевизор");

    
        
        enterData = Convert.ToInt32(ReadLine());


        

  
        product = json.db[enterData - 1];
    
        Write("Цена продукта (стоимость продукта начинается от 100 сомони ): ");
        
        price = Convert.ToInt32(ReadLine());

        if (price < 100) 
        {
            WriteLine("Цена должна превышать 100 сомони");
            return;
        }
         WriteLine("Диапазон начинается с 3 месяцев до какого месяца хотите расширить диапазон \n выберите из -> [6,9,12,18,24] ");

        range = Convert.ToInt32(ReadLine());
        check = MainRange.First(i=>i == range);
        
    } 

    catch (FormatException ex)
    {
        WriteLine("Пожалуйста не введите символы, программа запрашивает число.");
        return;
    }
    catch when(enterData <= 0 || enterData > json.db.Length ) 
    {
        WriteLine("Введите 1 или 2 или 3 )");
        return;
    }
    catch when (check == 0) 
    {
        WriteLine("Пожалуйста выберите из деопазона [6,9,12,18,24]");
        WriteLine("Введите либо 6 или 9 или 12 или 18 или 24");
        return;
    }

    
  
   
    WriteLine("  \n\n    Результат: {0} с.",Shop(product,price,range));
    WriteLine("\n\n\n\n < --------------------------------- >");
    

}