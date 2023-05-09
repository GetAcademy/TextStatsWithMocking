using System.Net;
using System.Reflection.PortableExecutable;

namespace TextStats
{
    internal class WebLineReader : ILineReader

    {
        private readonly StreamReader _reader;

        public WebLineReader(string url)
        {
            var webClient = new WebClient();
            var webStream = webClient.OpenRead(url);
            _reader = new StreamReader(webStream);
        }

        public string GetNextLineOrNull()
        {
            return _reader.ReadLine();
        }
    }
}
