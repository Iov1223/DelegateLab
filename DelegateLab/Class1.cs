using System;
using System.IO;
using TextCopy;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLab
{
    class Journal
    {
        public static string NameOfStudent = "John Dow", Discipline = "Discipline";
        public static byte Mark = 0;
        public static string DateOfBirth = "";
        public static DateTime DateOfMark = DateTime.Now;
        private static string path = "Journal.txt";
        private string Hobby = "";

        public void SetDateOfBirth(string _date)
        {
            DateOfBirth = _date;
        }
        public string GetDateOfBirth()
        {
            return DateOfBirth;
        }
        public void PrintDateOfBirth()
        {
            Console.WriteLine("Date of birth: " + DateOfBirth);
        }
        public void SetDateOfMark()
        {
            DateOfMark = DateTime.Now;
        }
        public DateTime GetDateOfMark()
        {
            return DateOfMark;
        }
        public void PrintDateOfMark()
        {
            Console.WriteLine("Date of mark: " + DateOfMark);
        }
        public void SetHobby(string _hobby)
        {
            Hobby = _hobby;
        }
        public string GetHobby()
        {
            return Hobby;
        }
        public void PrintHobby()
        {
            Console.WriteLine("Hobby: " + Hobby);
        }
        public void SetMark(byte _mark)
        {
            Mark = _mark;
        }
        public byte GetMark()
        {
            return Mark;
        }
        public void PrintMark()
        {
            Console.WriteLine("Mark: " + Mark);
        }
        public void SetDiscipline(string _lesson)
        {
            Discipline = _lesson;
        }
        public string GetDiscipline()
        {
            return Discipline;
        }
        public void PrintDiscipline()
        {
            Console.WriteLine("Discipline: " + Discipline);
        }
        public void SetName(string _name)
        {
            NameOfStudent = _name;
        }
        public string GetName()
        {
            return NameOfStudent;
        }
        public void PrintName()
        {
            Console.WriteLine("Name of student: " + NameOfStudent);
        }
        public void WriteNameToFile()
        {
            string myDocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            path = myDocs + "\\" + path;
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("Name of student: " + NameOfStudent);
                sw.WriteLine("Date of birth: " + DateOfBirth);
                sw.WriteLine("Discipline: " + Discipline);
                sw.WriteLine("Mark: " + Mark );  
                sw.WriteLine("Date of mark: " + DateOfMark);
                sw.WriteLine("Hobby: " + Hobby + "\n");
            }               
            Console.WriteLine("Информация добавлена в файл {0}.", path);
        }
        public void CopyToClipboard()
        {
            ClipboardService.SetText(NameOfStudent);
            Console.WriteLine("Информация добавлена в буфер обмена.");
        }
        public string GetFromClipboard()
        {
            return ClipboardService.GetText();
        }
    }
}
