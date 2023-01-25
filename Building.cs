using System;
namespace test
{
    public class Building
    {
        public string name;
        public int height;
        public int area;
        public string adress;

        public int FindVolume()
        {
            return height * area;
        }

    }
}

