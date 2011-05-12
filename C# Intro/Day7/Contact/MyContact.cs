using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contact
{
    public class MyContact
    {
       public static int contactID = 1;
        public int myContactID = 0;
        
        private string holdContactName;     // private place to hold contactName
        private string holdContactPhone;
        private string holdContactExt;

        public MyContact()
        {
            holdContactName = "Don't know";
            holdContactPhone = "Don't know";
            holdContactExt = "Don't know";

            myContactID = contactID;

            contactID++;
        }

        public MyContact(string inName, string inPhone, string inExt)
        {
            holdContactName = inName;
            holdContactPhone = inPhone;
            holdContactExt = inExt;

            myContactID = contactID;

            contactID++;
        }

        public string contactName
        {
            get
            {
                return holdContactName;
            }
            set
            {
                holdContactName = value;
            }
        }
        public string contactPhone
        {
            get
            {
                return holdContactPhone;
            }
            set
            {
                holdContactPhone = value;
            }
        }
        public string contactExt
        {
            get
            {
                return holdContactExt;
            }
            set
            {
                holdContactExt = value;
            }
        }

        public override string ToString()
        {
            return "Contact\n" + 
                "Number of objects created: " + contactID.ToString() + "\n" +
                  "Contact ID: " + myContactID.ToString() + "\n" +
                "Contact Name: " + holdContactName + "\n" +
                    "Contact Phone: " + holdContactPhone + "\n" +
                        "Contact Extension: " + holdContactExt + "\n" +
                            "\n\n";
        }           
    }
}
