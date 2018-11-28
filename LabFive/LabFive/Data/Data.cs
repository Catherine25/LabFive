using System;

namespace LabFive
{
    [Serializable]
    public class Data
    {
        //data
        public string Subject { get; set; }
        public string Student { get; set; }
        public int Mark { get; set; }

        //constructors
        public Data(string _sub, string _stu, int _m)
        {
            Subject = _sub;
            Student = _stu;
            Mark = _m;
        }
    }
}
