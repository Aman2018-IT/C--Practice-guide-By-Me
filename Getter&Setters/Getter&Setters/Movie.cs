using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getter_Setters
{
    internal class Movie
    {
        public string title;
        public string director;
        private string rating;



        public Movie(string title, string director, string rating)
        {
            this.title = title;
                this.director = director;
                this.Rating = rating;
        }

        public string Rating
        {
            get { return rating; }
            set {
               if(value=="G" ||value=="Pg" ||value=="R"||value=="Pg-13"||value=="NR" )
                {
                    rating = value;
                }
                else
                {
                    rating = "nr";
                }
            }
        }
    }
}
