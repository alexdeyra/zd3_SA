﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UP_lesson1_z3
{
    struct Song
    {
        public string Author;
        public string Title;
        public string Filename;

        //конструктор структуры
        public Song(string author, string title, string filename)
        {
            Author = author;
            Title = title;
            Filename = filename;
        }
    }
    internal class Playlist
    {
        private List<Song> list;
        private int currentIndex;

        public Playlist()
        {
            list = new List<Song>();
            currentIndex = 0;
        }

        //Метод для получения текущей аудиозаписи
        public Song CurrentSong()
        {
            if (list.Count > 0)
                return list[currentIndex];
            else
                throw new IndexOutOfRangeException(
                    "Невозможно получить текущую аудиозапись для пустого плейлиста!");
        }

        //Метод для добавления аудиозаписи
        public void AddSong(Song song)
        {
            list.Add(song);
        }

        // Перегрузка метода для добавления аудиозаписи
        public void AddSong(string author, string title, string filename)
        {
            Song song = new Song(author, title, filename);
            list.Add(song);
        }

        //количество элементов в плэйлисте
        public int Count => list.Count;

        //метод для перехода к следующей песне
        public void NextSong()
        {
            if (list.Count > 0 && currentIndex+1 < list.Count)
            {
                currentIndex = currentIndex + 1;
            }
        }
        //метод для перехода к предыдущей песне
        public void BeforeSong()
        {
            if (list.Count > 0 && currentIndex - 1 >= 0)
            {
                currentIndex = currentIndex - 1;
            }
        }

        //переход к песне по индексу
        public string Index(int index)
        {
            if (index >= 0 && index < list.Count)
            {
                currentIndex = index;
                return "Песня готова к прослушиванию!";
            }
            else return "Нет песни с таким номером!";
        }

        //переход к началу плэйлиста
        public void Start()
        {
            currentIndex = 0;
        }

        //удаление плэйлиста
        public void Clear()
        {
            list.Clear();
            currentIndex = 0;
        }

        //удаление песни №1
        public void RemoveSong(int index)
        {
            if (index >= 0 && index < list.Count)
            {
                list.RemoveAt(index);
                if (currentIndex >= list.Count) currentIndex = list.Count - 1;
            }
        }

        //удаление песни №2
        public void RemoveSong(Song song)
        {
            int index = list.IndexOf(song);
            if (index != -1)
            {
                list.RemoveAt(index);
                if (currentIndex >= list.Count) currentIndex = list.Count - 1;
            }
        }

        public List<Song> GetSongs() // Метод для получения списка песен
        {
            return list;
        }
    }
}
