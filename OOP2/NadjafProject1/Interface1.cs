using System;
using System.Collections.Generic;
using System.Text;

namespace NadjafProject1
{
    public interface ISinger
    {
        public virtual void Sing()
        {
            Console.WriteLine("Singing...");
        }
        virtual public void RecordSong()
        {

        }
        
    }
    public interface IPopSinger: ISinger
    {
        virtual void GoMoonWalk()
        {
            Console.WriteLine("Going MoonWalk");
        }
    }
    public interface IRockSinger : ISinger
    {
        void SwingGuitar()
        {
            Console.WriteLine("Swinging Guitar");
        }   
    }
}   
