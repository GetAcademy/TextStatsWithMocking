namespace TextStats
{
    internal class KeyboardLineReader : ILineReader
    {
        public string GetNextLineOrNull()
        {
            var line = Console.ReadLine();
            if (line.Length == 0) return null;
            return line;
        }
    }
}
