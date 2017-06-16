using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tesla_Soft {
    class Turret {
        private const int min = 0;
        private const int max = 255;
        private const int center = 128;
        private Point _pos;
        public Point pos {
            get {
                return _pos;
            }
            set {
                int x = value.X;
                int y = value.Y;
                if(y < min) y = min;
                if(y > max) y = max;
                if(x < min) x = min;
                if(x > max) x = max;
                _pos = new Point(x, y);
            }
        }

        public Turret(Point pos) {
            this.pos = pos;
        }
        public void toLeft(int value) {
            pos = new Point(pos.X - value, pos.Y);
        }
        public void toRight(int value) {
            pos = new Point(pos.X + value, pos.Y);
        }
        public void toUp(int value) {
            pos = new Point(pos.X, pos.Y + value);
        }
        public void toDown(int value) {
            pos = new Point(pos.X, pos.Y - value);
        }
        public Turret() : this(new Point(center, center)) { }
    }
}
