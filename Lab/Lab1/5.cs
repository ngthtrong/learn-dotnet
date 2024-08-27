using System;
namespace learn_dotnet.Lab.Lab1
{

    public class DictionaryPractice
    {
        private string name;
        private int id;
        Dictionary<int, string> students = new Dictionary<int, string>();
        public void ReadStudents()
        {
            do
            {
                name = Console.ReadLine();
                if (!Equals(name, ""))
                {
                    id = Convert.ToInt16(Console.ReadLine());
                    students.Add(id, name);
                }
            } while (!Equals(name, ""));
        }
        public void PrintStudents()
        {
            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine(student.Key + ": " + student.Value);
            }
        }
        public void ModifyStudents(int id, string newName)
        {
            if (students.ContainsKey(id) == true)
            {
                students[id] = newName;
            }
            else
            {
                Console.WriteLine("Not found student has id: " + id);
            }
        }

    }




}