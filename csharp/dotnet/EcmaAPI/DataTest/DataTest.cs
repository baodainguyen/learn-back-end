using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcmaAPI.Data
{
    public class DataTest
    {
        public List<Stream> Streams = new List<Stream>();

        public static DataTest Instance;

        public DataTest ()
        {
            for (var i = 2; i < 7; i++)
            {
                Streams.Add(new Stream() { 
                    Id = i,
                    Name = "DaiNB_" + i, 
                    Avatar = string.Format("https://www.w3schools.com/bootstrap4/img_avatar{0}.png", i)
                });
            }
        }

        public static DataTest GetInstance() {
            if (Instance != null)
            {
                return Instance;
            }

            Instance = new DataTest();
            return Instance;
        }

        public Stream FindStream(long id)
        {
            return Streams.Where(s => s.Id == id).FirstOrDefault();
        }
    }
}
