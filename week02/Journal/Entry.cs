using System;

public class Entry
{
    private string _date;
    private string _promptText;
    private string _entryText;

    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    // Propiedades públicas para acceder a los valores privados
    public string Date => _date;          // Acceso a la fecha
    public string Prompt => _promptText;  // Acceso al texto de la pregunta
    public string Text => _entryText;     // Acceso al texto del registro

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
    }
}