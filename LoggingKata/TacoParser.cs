namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();

      

        public ITrackable Parse(string line)
        {
            if (line==null)
            {
                return null;
            }

            var cells = line.Split(',');
            if (cells.Length < 3)
            {
                logger.LogError(null);
                return null; // TODO Implement
            }
            Point coords = new Point();
            TacoBell restaurant = new TacoBell();

            // grab the latitude from your array at index 0
            coords.Latitude = double.Parse(cells[0]);
            // grab the longitude from your array at index 1
            coords.Longitude = double.Parse(cells[1]);
            // grab the name from your array at index 2
            restaurant.Location = coords;
            restaurant.Name = cells[2];

            return restaurant;

            
        }
    }
}