//1. Ввод строки
Console.Write("Введите строку: ");
string text = Console.ReadLine() ?? "";

//2. Вывод анализа
Console.WriteLine("\n>>> Анализ строки <<<");
Console.WriteLine($"Исходная строка: [{text}]");
Console.WriteLine($"Длина: {text.Length}");
Console.WriteLine($"Букв: {CountLetters(text)}");
Console.WriteLine($"Цифр: {CountDigits(text)}");
Console.WriteLine($"Пробелов: {CountCharacter(text, ' ')}");
Console.WriteLine($"Слов: {CountWords(text)}");
Console.WriteLine($"Без пробелов по краям: [{text.Trim()}]");
Console.WriteLine($"Верхний регистр: [{text.ToUpper()}]");
Console.WriteLine($"Замена пробелов: [{text.Replace(' ', '_')}]");

//3. Поиск символа
Console.Write("\nВведите один символ для поиска: ");
char target = Convert.ToChar(Console.ReadLine() ?? " ");

int index = FindCharacterIndex(text, target);
if (index == -1)
{
    Console.WriteLine("Символ не найден");
}
else
{
    Console.WriteLine($"Первый индекс: {index}");
}

//4. Самостоятельное задание (Вариант 2 - гласные)
Console.WriteLine($"\nКоличество гласных: {CountVowels(text)}");


//5. Методы
int CountCharacter(string str, char targetChar)
{
    int count = 0;
    foreach (char symbol in str)
    {
        if (symbol == targetChar) count++;
    }
    return count;
}

int CountDigits(string str)
{
    int count = 0;
    foreach (char symbol in str)
    {
        if (char.IsDigit(symbol)) count++;
    }
    return count;
}

int CountLetters(string str)
{
    int count = 0;
    foreach (char symbol in str)
    {
        if (char.IsLetter(symbol)) count++;
    }
    return count;
}

int FindCharacterIndex(string str, char targetChar)
{
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] == targetChar)
        {
            return i;
        }
    }
    return -1;
}

int CountWords(string str)
{
    string[] words = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    return words.Length;
}

int CountVowels(string str)
{
    int count = 0;
    string vowels = "аеёиоуыэюя";
    
    foreach (char symbol in str)
    {
        char lowerSymbol = char.ToLowerInvariant(symbol);
        if (vowels.Contains(lowerSymbol))
        {
            count++;
        }
    }
    return count;
}