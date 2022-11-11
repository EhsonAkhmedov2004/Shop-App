using static System.Console;
using ShopProject.Models;
namespace ShopProject.Shop
{
    public class Helper 
    {
        public static List<int> MainRange {get;set;} = new List<int>{3,6,9,12,18,24};
        public static int Shop(Tech product,int price,int range) 
        {
    

            var percent = MainRange.Where(i=>i > product.range[1] && i <= range).Count() * product.percent;

            var profit = (price * percent) / 100;

            var result = price + profit;
            WriteLine("\n\n\n\n < --------------------------------- >");
            WriteLine("Основной диапазон '{0}' длится от {1} до {2} месяцев",product.name,product.range[0],product.range[1]);
            WriteLine("\n\n    Ваш выбранный диапазон от 3 до {0} месяцев",range);
            WriteLine(" \n\n    Добавленный процент: + {0} %",percent);
            WriteLine("  \n\n    Доход: {0} c.",profit);
            

            return result;
        }

        }
}