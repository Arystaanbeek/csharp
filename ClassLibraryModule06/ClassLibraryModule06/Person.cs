using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryModule06
{
    public class Person
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }

        public Person(string firstName, string lastName, int age, int id)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }
    }

    public static class PersonUtility
    {
        public static string GetPersonInfo(Person person)
        {
            string personInfo = $"Имя: {person.firstName}, Фамилия: {person.lastName}, Возраст: {person.age}, ID: {person.id}";
            return personInfo;
        }
    }
}