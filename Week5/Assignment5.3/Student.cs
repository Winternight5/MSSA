using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigntment5._3
{
    enum Serialize
    {
        Binary,
        XML,
        JSON
    }

    [Serializable]
    public class Student
    {
        public int Sid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string comment { get; set; }

        [NonSerialized]
        public string privateKey;
    }
}
