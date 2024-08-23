using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primera.NETyApp
{
    public class Media
    {
        public string Title { get; set; }
        private int parentRate;
        public virtual void Play()
        {
            Console.WriteLine($"Playing {Title}");
        }
        public override bool Equals(object obj)
        {
            var mediaObj = (Media)obj;
            if (mediaObj.Title == this.Title)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        protected bool ThisContentIsCorrectForThisAge(int age)
        {
            if (age >= parentRate)
            {
                return true;
            }
            else
            {
                return false;
            }
        }    
    }
}