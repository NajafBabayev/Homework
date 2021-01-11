using System;
using System.Collections.Generic;
using System.Text;

namespace NadjafProject1
{
    class Singer: ISinger
    {
        public string NameSinger { get; set; }
        public string SurnameSinger { get; set; }
        public Singer(string namesinger, string surnamesinger)
        {
            NameSinger = namesinger;
            SurnameSinger = surnamesinger;
        }
        public void RecordSong()
        {
            Console.WriteLine($"{NameSinger} {SurnameSinger} \nJust singing...");
        }

    }
    class PopSinger: IPopSinger
    {
        public string NameSinger { get; set; }
        public string SurnameSinger { get; set; }
        public PopSinger(string namesinger, string surnamesinger)
        {
            NameSinger = namesinger;
            SurnameSinger = surnamesinger;
        }

        public void RecordSong()
        {
            Console.WriteLine($"{NameSinger} {SurnameSinger} \nRecording Pop song");
        }
    }
    class RockSinger: IRockSinger
    {
        public string NameSinger { get; set; }
        public string SurnameSinger { get; set; }
        public RockSinger(string namesinger, string surnamesinger)
        {
            NameSinger = namesinger;
            SurnameSinger = surnamesinger;
        }
        public void RecordSong()
        {
            Console.WriteLine($"{NameSinger} {SurnameSinger} \nRecording Rock song");
        }
        
    }
}
