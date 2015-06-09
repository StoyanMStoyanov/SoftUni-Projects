using System;
using System.Collections.Generic;

namespace Points
{
    public class Decart3DPoint
    {
        private readonly double[] startPoint = { 0, 0, 0 };
        //Fields
        private double xCoord;
        private double yCoord;
        private double zCoord;

        //Constructors
        public Decart3DPoint(double x, double y, double z)
        {
            this.XCoord = x;
            this.YCoord = y;
            this.ZCoord = z;
        }

        //Properties
        public double XCoord
        {
            get
            {
                return xCoord;
            }
            set
            {
                this.xCoord = value;
            }
        }
        public double YCoord
        {
            get
            {
                return yCoord;
            }
            set
            {
                this.yCoord = value;
            }
        }
        public double ZCoord
        {
            get
            {
                return zCoord;
            }
            set
            {
                this.zCoord = value;
            }
        }
        public double[] StartPoint
        {
            get
            {
                return this.startPoint;
            }
        }
        public double[] ThisPoint
        {
            get
            {
                return new double[] { this.xCoord, this.yCoord, this.zCoord };

            }
        }

        //Methods
        public override string ToString()
        {
            return string.Join(" ", new double[] { XCoord, YCoord, ZCoord });
        }
    }
}
