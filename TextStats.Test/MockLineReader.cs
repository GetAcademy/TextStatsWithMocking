namespace TextStats.Test
{
    internal class MockLineReader : ILineReader
    {
        private string[] _lines;
        int _index;

        public MockLineReader(params string[] lines)
        {
            _lines = lines;
        }

        public string GetNextLineOrNull()
        {
            if (_index == _lines.Length) return null;
            var line = _lines[_index];
            _index++;
            return line;
        }
    }
}
