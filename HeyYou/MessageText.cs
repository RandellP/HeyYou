using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeyYou
{
    public class MessageText
    {
        private Int32 Count = 0;
        //private string sText = "Hey You";

        public MessageText()
        {

        }

        public string getNextWord()
        {
            //update later to handle dynamic messages
            //jenkins should get this change.
            Count++;
            if (Count % 2 != 0)
            {
                return ("Hey");
            }
            else {
                return ("You");
            }
        }

    }
}
