namespace TextStats
{
    public class StatService
    {
        private readonly ILineReader _lineReader;

        public StatService(ILineReader lineReader)
        {
            _lineReader = lineReader;
        }

        public Stats GetStats(string searchWord)
        {
            var total = 0;
            var exactCount = 0;
            var ignoreCaseCount = 0;
            var searchWordUpper = searchWord.ToUpper();

            string line;

            while ((line = _lineReader.GetNextLineOrNull()) != null)
            {
                total++;
                if (line.Contains(searchWord)) exactCount++;
                if (line.ToUpper().Contains(searchWordUpper)) ignoreCaseCount++;
            }
            var result = new Stats(total, exactCount, ignoreCaseCount);
            return result;
        }


        //public static Stats GetStats(string filename, string searchWord)
        //{
        //    var fileStream = new FileStream(filename, FileMode.Open);
        //    var reader = new StreamReader(fileStream);

        //    var total = 0;
        //    var exactCount = 0;
        //    var ignoreCaseCount = 0;
        //    var searchWordUpper = searchWord.ToUpper();

        //    string line;

        //    while ((line = reader.ReadLine()) != null)
        //    {
        //        total++;
        //        if (line.Contains(searchWord)) exactCount++;
        //        if (line.ToUpper().Contains(searchWordUpper)) ignoreCaseCount++;
        //    }
        //    var result = new Stats(total, exactCount, ignoreCaseCount);
        //    return result;
        //}
    }
}
