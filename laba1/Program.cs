using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    class Notebook
    {
        static void Main(string[] args)
        {
            List<Note> list = new List<Note>();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Введите:\n1 чтобы добавить новую запись\n2 чтобы изменить запись\n3" +
                    " чтобы удалить запись\n4 чтобы просмотреть запись\n5 чтобы кратко просмотреть все записи" +
                    "\n6 чтобы закончить работу и закрыть приложение");
                Switch(Console.ReadLine(), list);
                
            }
        }
        static void Switch(string s, List<Note> list)
        {
            switch (s)
            {
                case "1":
                    CreateNewNote(list);
                    break;
                case "2":
                    ModifyNote(list);
                    break;
                case "3":
                    DeleteNote(list);
                    break;
                //case "4":
                //    ShowAllNotes(list);
                //    break;
                case "4":
                    ShowNote(list);
                    break;
                case "5":
                    ShowAllNotesBrief(list);
                    break;
                case "6":
                    Exit();
                    break;
            }
        }
        static void Exit()
        {
            Environment.Exit(1);
        }
        static void CreateNewNote(List<Note> list)
        {
            Note note = new Note();
            Fill(list, note);
            list.Add(note);
            PressAnyKey();
        }
        //static void ShowAllNotes(List<Note> list)
        //{
        //    foreach (var item in list)
        //    {
        //        Console.WriteLine(item.Notename);
        //    }
        //    PressAnyKey();
        //}
        static void ShowAllNotesBrief(List<Note> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item.Notename);
                item.ShowImportantFields();
                Console.WriteLine("----");
            }
            PressAnyKey();
        }
        static void ShowNote(List<Note> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(i + ":" + list[i].Notename);
            }
            Console.WriteLine("Введите номер записи которую хотите просмотреть");
            int x = Int32.Parse(Console.ReadLine());
            list[x].ShowAllFields();
            PressAnyKey();

            //показывание всех полей данного экземпляра 
        }
        static void DeleteNote(List<Note> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(i + ":" + list[i].Notename);
            }
            Console.WriteLine("Введите номер записи которую хотим удалить");
            int x = Int32.Parse(Console.ReadLine());
            list.RemoveAt(x);
        }
        static void ModifyNote(List<Note> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(i + ":" + list[i].Notename);
            }
            Console.WriteLine("Введите номер записи которую хотим редактировать");
            int b = Int32.Parse(Console.ReadLine());
            Fill(list, list[b]);
        }
        static void PressAnyKey()
        {
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
        static void Fill(List<Note> list, Note note)
        {
            Console.WriteLine("Поля с пометкой * необязательны к заполнению. Чтобы пропустить их заполнение нажмите enter");
            Console.WriteLine("Название записи:");
            
            TryAgain(out string notename);
            note.Notename = notename;
            Console.WriteLine("Имя:");
            TryAgain(out string name);
            note.Name = name;
            Console.WriteLine("Фамилия:");
            TryAgain(out string surname);
            note.Surname = surname;
            Console.WriteLine("Отчество*:");
            note.Fathername = Console.ReadLine();
            Console.WriteLine("Номер телефона:");
            while (true)
            {

                string a = Console.ReadLine();
                if (int.TryParse(a, out int n))
                {
                    note.Number = int.Parse(a);
                    break;
                }
                else
                {
                    Console.WriteLine("Вы не ввели число!");
                }
            }
            Console.WriteLine("Страна:");
            TryAgain(out string country);
            note.Country = country;
            Console.WriteLine("Дата рождения*:");
            note.BirthDate = Console.ReadLine();
            Console.WriteLine("Организация*:");
            note.Organisation = Console.ReadLine();
            Console.WriteLine("Должность*:");
            note.Position = Console.ReadLine();
            Console.WriteLine("Прочие заметки*:");
            note.Else = Console.ReadLine();
        }
        static void TryAgain(out string s)
        {
            
            while (true)
            {
                string a = Console.ReadLine();
                if (a.Trim().Equals(""))
                {
                    Console.WriteLine("Вы ничего не ввели!");

                }
                else
                {
                    s = a;
                    break;
                }
            }
        }
    }
}
