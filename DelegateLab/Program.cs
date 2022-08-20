using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLab
{
    class Program
    {
        delegate void Output();

        static void Choice(Journal myJournal)
        {
            Output _myOutput;
            Console.WriteLine("Вывести на экран? (Y) На экран и в файл (F)");
            string answer = Console.ReadLine();
            if (answer == "Y" | answer == "y")
            {
                _myOutput = myJournal.PrintName;
                _myOutput += myJournal.PrintDateOfBirth;
                _myOutput += myJournal.PrintDiscipline;
                _myOutput += myJournal.PrintMark;
                _myOutput += myJournal.PrintHobby;
                _myOutput += myJournal.PrintDateOfMark;               
                _myOutput();
            }
            else
            {
                if (answer == "F" | answer == "f")
                {
                    _myOutput = myJournal.PrintName;
                    _myOutput += myJournal.PrintDateOfBirth;
                    _myOutput += myJournal.PrintDiscipline;
                    _myOutput += myJournal.PrintMark;
                    _myOutput += myJournal.PrintDateOfMark;
                    _myOutput += myJournal.PrintHobby;
                    _myOutput += myJournal.WriteNameToFile;
                    _myOutput();
                }
                else
                {
                    _myOutput = myJournal.WriteNameToFile;
                }
            }
            
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Введите имя студента: ");
            var myJournal = new Journal();
            myJournal.SetName(Console.ReadLine());
            Console.WriteLine("Введите дату рождения студента: ");
            myJournal.SetDateOfBirth(Console.ReadLine());
            Console.WriteLine("Введите дисцеплину: ");
            myJournal.SetDiscipline(Console.ReadLine());
            Console.WriteLine("Введите оценку: ");
            byte myMark = Convert.ToByte(Console.ReadLine());
            myJournal.SetMark(myMark);
            Console.WriteLine("Введите хобби студента: ");
            myJournal.SetHobby(Console.ReadLine());
            Choice(myJournal);
        }
    }
}


