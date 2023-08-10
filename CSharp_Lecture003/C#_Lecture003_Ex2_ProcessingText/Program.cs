// Дан текст. В тексте нужно все пробелы заменить черточками, буквы "к" заменить большими буквами "К", а большие "С" заменить маленькими "с"

Console.Clear();

Console.WriteLine("Введите текст, который нужно отформатировать.");
string text = Console.ReadLine();


string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == oldValue)
        {
            result = result + $"{newValue}";
        }
        else
        {
            result = result + $"{text[i]}";
        }
    }
    return result;
}

string newText = Replace(text, ' ', '_');
newText = Replace(text, 'К', 'к'); 
newText = Replace(text, 'с', 'С');

Console.WriteLine(newText);

Console.ReadKey();