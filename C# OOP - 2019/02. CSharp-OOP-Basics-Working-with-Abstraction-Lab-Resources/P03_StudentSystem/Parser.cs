namespace P03_StudentSystem
{
    using System;

    public class Parser
    {
        public string Name { get; private set; }

        public string[] ParseCommand()
        {
            return Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
