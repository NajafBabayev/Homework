using System;

namespace NadjafProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1) Bird qush = new Bird() { };
            // qush.GetInfo();
            // qush.Walk();
            // qush.Fly();


            //2) 
            //Library axundov = new Library();
            //Book b1 = new Book("Tolstoy", "Voyna i Mir", 1890);
            //Person Nadjaf = new Person("Nadjaf", "Babayev", 25);
            //Nadjaf.AddfavoriteBook(b1);
            //Console.WriteLine(Nadjaf.MyFavoriteBook);
            //Nadjaf.Info();

            //3)
            
            IPopSinger michael = new PopSinger("Michael", "Jackson");
            IRockSinger elvis = new RockSinger("Elvis","Presley");
            ISinger uzeyir = new Singer("Uzeyir", "Mehdizade");
            michael.RecordSong();
            michael.GoMoonWalk();
            elvis.RecordSong();
            elvis.SwingGuitar();
            uzeyir.RecordSong();
            
        }
    }

}
