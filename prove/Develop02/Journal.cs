using System;
using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry NewEntry)
    {
        _entries.Add(NewEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void LoadFromFile()
    {
        Console.WriteLine("What is the filename to load?");
        string fileName = Console.ReadLine();

        if (File.Exists(fileName))
        {
            _entries.Clear();
            string[] lines = System.IO.File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                string[] parts = line.Split(",");
                string date = parts[0];
                string promptText = parts[1];
                string entryText = parts[2];

                Entry entry = new Entry
                {
                    _date = date,
                    _promptText = promptText,
                    _entryText = entryText
                };
                _entries.Add(entry);
            }
            Console.WriteLine("Journal loaded successfully!\n");
        }
        else
        {
            Console.WriteLine("File not found.\n");
        }
        
    }

    public void SaveToFile()
    {
        Console.WriteLine("What is the filename to save?");
        string fileName = Console.ReadLine(); 

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
            }
        }
        Console.WriteLine("Journal saved successfully!\n");
    }
}