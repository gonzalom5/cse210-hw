using System;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

public class RandomScripture
{
    private List<Scripture> _scriptures;
    private Random _random = new Random();

    public RandomScripture()
    {
        _scriptures = new List<Scripture>();

        _scriptures.Add(new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart and lean not unto thine own understanding; In all thy ways acknowledge him, and he shall direct thy paths."));

        _scriptures.Add(new Scripture(new Reference("1 Nephi", 3, 7), "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."));

        _scriptures.Add(new Scripture(new Reference("Alma", 5, 16, 17), "I say unto you, can you imagine to yourselves that ye hear the voice of the Lord, saying unto you, in that day: Come unto me ye blessed, for behold, your works have been the works of righteousness upon the face of the earth? Or do ye imagine to yourselves that ye can lie unto the Lord in that day," +
        "and say—Lord, our works have been righteous works upon the face of the earth—and that he will save you?"));
    }

    public Scripture GetRandomScripture()
    {
        int index = _random.Next(_scriptures.Count);
        return _scriptures[index];
    }
}