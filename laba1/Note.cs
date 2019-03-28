using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    class Note
    {
        public string Notename { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Fathername { get; set; }
        public int Number { get; set; }
        public string Country { get; set; }
        public string BirthDate { get; set; }
        public string Organisation { get; set; }
        public string Position { get; set; }
        public string Else { get; set; }

        public Note()
        {
        }
        public void ShowAllFields()
        {
            Console.WriteLine(this.Notename);
            Console.WriteLine(this.Name);
            Console.WriteLine(this.Surname);
            EmptyCheck(this.Fathername);
            Console.WriteLine(this.Number);
            Console.WriteLine(this.Country);
            EmptyCheck(this.BirthDate);
            EmptyCheck(this.Organisation);
            EmptyCheck(this.Position);
            EmptyCheck(this.Else);
        }
        private void EmptyCheck(string str)
        {
            if(!str.Trim().Equals(""))
            {
                Console.WriteLine(str);
            }
            

        }
        public void ShowImportantFields()
        {
            Console.WriteLine(this.Notename);
            Console.WriteLine(this.Name);
            Console.WriteLine(this.Surname);
            Console.WriteLine(this.Number);
        }
    }
}
