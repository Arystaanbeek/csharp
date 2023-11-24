using System;
using System.Collections;
using System.Collections.Generic;

class MusicCatalog
{
    Hashtable catalog = new Hashtable();

    public void AddDisk(string diskName)
    {
        if (!catalog.ContainsKey(diskName))
        {
            catalog.Add(diskName, new List<string>());
        }
    }

    public void RemoveDisk(string diskName)
    {
        if (catalog.ContainsKey(diskName))
        {
            catalog.Remove(diskName);
        }
    }

    public void AddSong(string diskName, string song)
    {
        if (catalog.ContainsKey(diskName))
        {
            var songs = (List<string>)catalog[diskName];
            songs.Add(song);
        }
    }

    public void RemoveSong(string diskName, string song)
    {
        if (catalog.ContainsKey(diskName))
        {
            var songs = (List<string>)catalog[diskName];
            songs.Remove(song);
        }
    }

    public void ShowDiskContents(string diskName)
    {
        if (catalog.ContainsKey(diskName))
        {
            Console.WriteLine($"Contents of Disk '{diskName}':");
            var songs = (List<string>)catalog[diskName];
            foreach (var song in songs)
            {
                Console.WriteLine(song);
            }
        }
    }

    public void ShowAllCatalog()
    {
        Console.WriteLine("Music Catalog:");
        foreach (DictionaryEntry disk in catalog)
        {
            Console.WriteLine($"Disk: {disk.Key}");
            var songs = (List<string>)disk.Value;
            foreach (var song in songs)
            {
                Console.WriteLine($"- {song}");
            }
        }
    }

    public void SearchByArtist(string artist)
    {
        Console.WriteLine($"Search results for artist '{artist}':");
        foreach (DictionaryEntry disk in catalog)
        {
            var songs = (List<string>)disk.Value;
            foreach (var song in songs)
            {
                if (song.ToLower().Contains(artist.ToLower()))
                {
                    Console.WriteLine($"- {song} on Disk '{disk.Key}'");
                }
            }
        }
    }
}

class Task5
{
    static void Main(string[] args)
    {
        MusicCatalog catalog = new MusicCatalog();

        catalog.AddDisk("Disk 1");
        catalog.AddDisk("Disk 2");

        catalog.AddSong("Disk 1", "Song 1 by Artist A");
        catalog.AddSong("Disk 1", "Song 2 by Artist B");
        catalog.AddSong("Disk 2", "Song 3 by Artist C");

        catalog.ShowAllCatalog();

        catalog.RemoveDisk("Disk 2");

        catalog.ShowAllCatalog();

        catalog.SearchByArtist("Artist B");
    }
}
