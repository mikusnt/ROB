using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tesla_Soft {
    public struct MovePoint {
        /*
         
            Metody     
             
        */
        public static bool isInside(Point centerPoint, Point point, int insideLength) {
            Size size = new Size();
            if(centerPoint.X > point.X) {
                size.Width = centerPoint.X - point.X;
            } else size.Width = point.X - centerPoint.X;

            if(centerPoint.Y > point.Y) {
                size.Height = centerPoint.Y - point.Y;
            } else size.Height = point.Y - centerPoint.Y;

            int length = (int)Math.Sqrt(size.Height * size.Height + size.Width * size.Width);
            if(length > insideLength) return false;
            else return true;
        } // END public static bool isInside

        private static int ValueMinusDeadValue(int value, int deadValue) {
            int ret = 0;
            if(value > 0) {
                ret = value - deadValue;
                if(ret < 0) ret = 0;
            } else if(value < 0) {
                ret = value + deadValue;
                if(ret > 0) ret = 0;
            }
            return ret;
        }
        public static Point PointMinusDeadBox(Point point, Point deadBox) {
            int retX, retY;

            retX = ValueMinusDeadValue(point.X, deadBox.X);
            retY = ValueMinusDeadValue(point.Y, deadBox.Y);
            return new Point(retX, retY);
        }
        public static int cutToCenter(int value, int maxValue) {
            maxValue = Math.Abs(maxValue);
            if(value > maxValue) return maxValue;
            else if(value < -maxValue) return -maxValue;
            else return value;
        }
        public static int onlyMinus(int value) {
            if(value < 0) return value;
            else return 0;
        }

        public static int onlyPlus(int value) {
            if(value > 0) return value;
            else return 0;
        }
    }
}
