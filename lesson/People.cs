using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson
{
    internal class People
    {
        private string m_FName;
        private string m_LName;

        public string FName { get { return m_FName; } set { m_FName = value; } }
        public string LName { get { return m_LName; } set { m_LName = value; } }

        public People()
        {

            m_FName = "TestFirstname";
            m_LName = "TestLastName";
        }

        public People(string fName, string lName)
        {
            m_FName = fName;
            m_LName = lName;

        }
    }
}
