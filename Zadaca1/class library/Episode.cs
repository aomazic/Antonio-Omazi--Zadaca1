using System;
using System.Collections.Generic;
using System.Text;

namespace class_library
{
    class Episode
    {
        private int viewers;
        private double ratingsum;
        private double maxrating;
        private double averagerating;
        public Episode()
        {

        }
        public Episode(int Aviewers, double Aratingsum, double Amaxrating)
        {
            viewers = Aviewers;
            ratingsum = Aratingsum;
            maxrating = Amaxrating;
        }
        public void AddView(double score)
        {
            viewers++;
            ratingsum += score;
            if (score > maxrating) maxrating = score;

        }

        public double GetMaxScore()
        
            { return maxrating; }

        
        public double GetAverageScore()
        {
            averagerating = ratingsum / viewers;
             return averagerating; 

        }
        public int GetViewerCount()
        {
             return viewers; 

        }


    }
}