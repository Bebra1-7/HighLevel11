//List
// `Add(x)`      | добавляет элемент в конец                                         |
// | `Remove(x)`   | удаляет первое найденное значение `x`, возвращает `true`/`false`  |
// | `RemoveAt(i)` | удаляет элемент с индексом `i`                                    |
// | `Contains(x)` | проверяет, есть ли значение в списке (`true`/`false`)             |
// | `IndexOf(x)`  | возвращает индекс первого вхождения, либо `-1`, если значения нет |
// | `Count`       | количество элементов 

//Dictionary
// `Add(key, value)`         | добавляет пару (если ключ уже есть — программа аварийно завершится)     |
// | `dictionary[key] = v`     | добавляет пару или меняет значение существующего ключа                  |
// | `ContainsKey(key)`        | проверяет, есть ли такой ключ                                           |
// | `TryGetValue(key, out v)` | безопасный поиск: возвращает `true`/`false` и записывает значение в `v` |
// | `Remove(key)`             | удаляет пару по ключу                                                   |
// | `Count`                   | количество пар                          

//Hashset
// Add(x)`      | добавляет элемент (если такой уже есть — набор не изменится) |
// | `Contains(x)` | проверяет наличие элемента                                   |
// | `Remove(x)`   | удаляет элемент                                              |
// | `Count`       | количество уникальных элементов         


// //=== Часть 1. List<T> ===
// List<string> students = ["Ivan", "Petr", "Anna"];
// Console.WriteLine(students.Count);
// students.Add("Nekit");
// students.Remove("Ivan");
// Console.WriteLine(students[0]);
// string inList = students.Contains("Nekit") ? "Yes" : "No";
// Console.WriteLine(inList);
// foreach (var item in students)
// {
//     Console.WriteLine(item);
// }
// // Они оба по индексу ищут элемент. В список можно добавлять элементы


// //=== Часть 2.  Dictionary<TKey,TValue>===

// Dictionary<string, double> prices = new()
// {
//     ["Хлеб"] = 45.5,
//     ["Молоко"] = 89
// };
// prices["Творог"] = 120;
// prices["Макароны"] = 65;
// prices["Хлопья"] = 100;

// Console.WriteLine(prices["Хлеб"]);
// prices["Хлеб"] = 50;
// Console.WriteLine(prices.ContainsKey("Молоко"));
// string input = Console.ReadLine();
// if (prices.TryGetValue(input, out double i))
// {
//     Console.WriteLine(i);
// }
// else Console.WriteLine("Tovar not in prices");
// foreach (var item in prices)
// {
//     Console.WriteLine($"Tovar: {item.Key}; Price: {item.Value}");
// }
// Console.WriteLine(prices["Несуществующий товар"]);
//Вывело что данный ключ не найден

// //=== Часть 3. HashSet<T>===

// string[] input = ["C#", "Git", "C#", "SQL", "Git", "C#"];

// HashSet<string> Languages = [];
// foreach (string item in input)
// {
//     Languages.Add(item);
// }
// Console.WriteLine($"Masive: {input.Length}; HashSet: {Languages.Count}");
// string technology = Console.ReadLine();
// Console.WriteLine(Languages.Contains(technology) ? "Принято" : "Нету такой текнолоджи");
// //In HasSet оказалось меньше элем. так, как повторки он убирает

// Часть 4.
//1. Коллекция: List Причина: Нам надо иметь только доступ к товарам, которые могут также повтор.
//2. Коллекция: Dictionary Причина: Нужно иметь телефон по которому нужно иметь имя(тел. более уникален, чем имя)
//3. Коллекция: HashSet Причина: Нам не нужно иметь повтор. уникальные теги

// //Итоговая задача
// List<string> nameGames = ["World of Tanks", "CS2", "GTA VI", "GTA V"];
// Console.Write("Input new game: ");
// string newGame = Console.ReadLine();
// nameGames.Add(newGame);
// for (int i = 0; i < nameGames.Count; i++)
// {
//     Console.WriteLine($"{i + 1}: {nameGames[i]}");
// }

// Dictionary<string, double> priceGame = new()
// {
//     ["World of Tanks"] = 1200,
//     ["CS2"] = 1000,
//     ["GTA VI"] = 5000,
//     ["GTA V"] = 800
// };
// Console.Write("Input game для output price: ");
// string gamePrice = Console.ReadLine();
// if (priceGame.TryGetValue(gamePrice, out double price))
// {
//     Console.WriteLine($"Price {gamePrice}: {price}");
// }
// else Console.WriteLine("Данной игры не найдено");

// HashSet<string> genre = [];
// Console.Write("Input genre games через ',':\n");
// string[] inputGenre = Console.ReadLine().Split(",");
// foreach (var item in inputGenre)
// {
//     genre.Add(item);
// }
// Console.WriteLine(genre.Count);

// Console.Write("Input  genre");
// Console.WriteLine(genre.Contains(Console.ReadLine()) ? "Есть в нашем списке" : "Нету в нашем списке");

//Самостоятельные задания

// //★ List<T>
// List<int> numbers = [2, 3, 4, 5, 2, 2, 5, 3];
// Console.Write("Введите число которое нужно убрать из списка: ");
// int num = int.Parse(Console.ReadLine());
// for (int i = 0; i < numbers.Count; i++)
// {
//     numbers.Remove(num);
// }

// // ★★ Dictionary
// Dictionary<string, int> s = new()
// {
//     ["Beard"] = 10,
//     ["Milk"] = 25,
//     ["Chicken"] = 9
// };
// if (s.TryGetValue(Console.ReadLine(), out int i))
// {
//     Console.WriteLine($"Кол-во: {i}");
// }
// else Console.WriteLine("Item not find");

//★★★ Выбор коллекции
//Библиотека
List<string> nameBook = ["Война и мир", "Горе от ума", "Преступление и наказание"];
foreach (var item in nameBook)
{
    Console.WriteLine(item);
}
//Исп. list для наименования книг(книги могут повтор.)
Dictionary<string, int> quantityBook = new()
{
    ["Война и мир"] = 10,
    ["Горе от ума"] = 5,
    ["Преступление и наказание"] = 15
};
foreach (var item in quantityBook)
{
    Console.WriteLine($"{item.Key}: {item.Value}");
}
//Исп. Dictionary чтобы иметь опр. кол-во книг 
HashSet<string> nameWriter = ["Толстой", "Достоевский", "Гоголь", "Грибоедов"];
foreach (var item in nameWriter)
{
    Console.WriteLine(item);
}
//Исп. HashSet, чтобы у нас не повторялись авторы(можно было бы и книги сюда поставить, но как по мне авторы более уникальны)