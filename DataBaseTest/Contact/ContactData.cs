using DataBaseTest.Contact;
using System.Collections.Generic;

namespace DataBaseTest
{
    public class ContactData
    {
        public string Name;
        public string LastName;
        public string FirstName;
        private int UserInfoID;
        public List<ContactNumber> numberList = new List<ContactNumber>();
        public List<ContactNote> noteList = new List<ContactNote>();

        public ContactData() { }

        //public 
    }
}