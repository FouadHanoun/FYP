using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinect2Sample
{
    class Sadness
    {
        private double HeadForward;
        private double SpineForward;

        public Sadness()
        {
            this.HeadForward = 0.0;
            this.SpineForward = 0.0;
        }

        public void set_SpineForward(double SpineForward)
        {
            this.SpineForward = SpineForward;
        }


        public double get_collapsedBody()
        {
            return (HeadForward + SpineForward) / 2;
        }
        public void set_headForward(double HeadForward)
        {
            this.HeadForward = HeadForward;
        }

        public double get_HeadForward()
        {
            return HeadForward;
        }

        public double get_SpineForward()
        {
            return SpineForward;
        }

        public int get_Sadness()
        {
            if (HeadForward > 0.3 && SpineForward > 0.3)
            {
                double CollapsedBody = (HeadForward + SpineForward) / 2;
                int pourcent = (int)(CollapsedBody * 100);
                return pourcent;
            }
            else
            {
                return 0;
            }
        }
    }
}
