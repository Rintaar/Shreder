using System;
using System.Collections.Generic;
using System.IO;

namespace ProfForTest
{
    public class Listing
    {
        public List<string> collection_folder = new List<string>();
        public List<string> collection_files = new List<string>();
        //Создание списка файлов и папок из указанной директории
        public void CreateCollection(string folder)
        {
            string[] files = Directory.GetFiles(@folder, "*.*");
            string[] dirs = Directory.GetDirectories(@folder, "*.*");
            foreach (string file in files)
                this.collection_files.Add(file);
            foreach (string dir in dirs)
                this.collection_folder.Add(dir);
        }
        public int Count()
        {
            return collection_files.Count + collection_folder.Count;
        }
        //Отображение полученной коллекции
        public void ViewCollection()
        {
            
            int i = 1;
            Console.WriteLine("Папки");
            foreach (string items in this.collection_folder)
            {
                Console.WriteLine(i.ToString() + ". " + Path.GetFileName(items));
                i++;
            }
            Console.WriteLine("Файлы");
            i = 1;
            foreach (string items in this.collection_files)
            {
                Console.WriteLine(i.ToString() + ". " + Path.GetFileName(items));
                i++;
            }
        }

        //Удаление имен из списка папок
        public void RemoveItemfromFolders(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                this.collection_folder.RemoveAt(array[i] - i - 1);
        }

        //Удаление имен из списка файлов
        public void RemoveItemfromFiles(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                this.collection_files.RemoveAt(array[i] - i - 1);
        }

        //Добавление имен в список файлов (добавляется через массив  нужных номеров)
        public void AddItemsfromFiles(Listing main, int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                this.collection_files.Add(main.collection_files[array[i]-1]);
            main.RemoveItemfromFiles(array);
        }

        //Добавление имен в список папок (добавляется через массив  нужных номеров)
        public void AddItemsfromFolders(Listing main, int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                this.collection_folder.Add(main.collection_folder[array[i] - 1]);
            main.RemoveItemfromFolders(array);
        }

        //Вернуть коллекцию файлов или папок
        public List<string> setfolderCollection()
        {
            return collection_folder;
        }
        public List<string> setfilesCollection()
        {
            return collection_files;
        }
    }
}
