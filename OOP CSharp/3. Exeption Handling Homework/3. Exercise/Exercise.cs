using System;

class Exercise
{
    static void Main()
    {
        Person stoyan = AddPerson("Stoyan", "Stoyanow", 40);        
        Person noName = AddPerson(string.Empty, "name", 24);
        Person noLastName = AddPerson("Petkan", null, 25);
        Person negativeAge = AddPerson("George", "Georgiev", -25);
        Person tooOldForThisProgram = AddPerson("Ivan", "Ivanov", 122);
    }

    private static Person AddPerson(string firstName, string lastName, int age)
    {
        try
        {
            Person temp = new Person(firstName, lastName, age);
            return temp;
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("Exeption thrown: {0}", ex.Message);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine("Exeption thrown: {0}", ex.Message);
        }
        return null;
    }
    
}
