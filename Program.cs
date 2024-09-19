using BasicOOP.AnimalFolder;
using BasicOOP.ErrorFolder;
using BasicOOP.PersonFolder;


namespace BasicOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonProgram.Run();
            ErrorProgram.Run();
            AnimalProgram.Run();
        }
    }
}
