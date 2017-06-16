using System;
using System.Drawing;

namespace Tesla_Soft {
    public enum Direction { Forward = 1, Backward = -1, Stop = 0 };
    public static class DirectionMethohs {
        public static Direction Negation(this Direction direction) {
            switch(direction) {
                case Direction.Backward: {
                    return Direction.Forward;
                }
                case Direction.Forward: {
                    return Direction.Backward;
                }
                default: {
                    return direction;
                } 
            }
        }
    }

    public class Motor {
        /*
         
                Pola     
             
        */
        private int _absSpeed { get; set; }
        private int _speedDirection { get; set; }
        public Direction direction { get; private set; }
        public int absSpeed {
            get { return _absSpeed; }
            private set {
                if(value < 0) {
                    direction = direction.Negation();
                    _absSpeed = Math.Abs(value);
                } else {
                    if(value == 0) direction = Direction.Stop;  
                    _absSpeed = value;
                }
                if(_absSpeed > _maxSpeed) _absSpeed = _maxSpeed;
                _speedDirection = absSpeed;
                if(direction == Direction.Backward) _speedDirection = -_speedDirection;
            }
        } // END public int speed
        public int speedDirection {
            get { return _speedDirection; }
            set {
                if(value > 0) direction = Direction.Forward;
                else if(value < 0) direction = Direction.Backward;
                absSpeed = Math.Abs(value);
                
            }
        }

        private int _maxSpeed;
        public int maxSpeed {
            get { return _maxSpeed; }

            set {
                if(value > 255) _maxSpeed = 255;
                else if(value < 0) _maxSpeed = 0;
                else _maxSpeed = value;
            }
        } // public int maxSpeed

        /*
         
            Operatory    
             
        */
        public static bool operator <(Motor MotorL, Motor MotorR) {
            return (MotorL.speedDirection < MotorR.speedDirection);
        }
        public static bool operator >(Motor MotorL, Motor MotorR) {
            return (MotorL.speedDirection > MotorR.speedDirection);
        }

        public static bool operator !=(Motor MotorL, Motor MotorR) {
            return (MotorL.speedDirection != MotorR.speedDirection);
        }
        public static bool operator ==(Motor MotorL, Motor MotorR) {
            return (MotorL.speedDirection == MotorR.speedDirection);
        }
        public override bool Equals(object obj) {
            if ((obj == null) || (GetType() != obj.GetType())) return false;
            Motor temp = (Motor)obj;
            return temp == this;
        } // END public override bool Equals
        public override int GetHashCode() {
            return _absSpeed ^ (int)direction ^ _speedDirection;
        }
        /*
         
                Metody     
             
        */

        public void Accelerate(int delta) { speedDirection += delta; }

        public void Brake(int brakeValue) {
            brakeValue = Math.Abs(brakeValue);
            if(brakeValue > absSpeed) absSpeed = 0;
            else  absSpeed -= brakeValue;
        }

        public override string ToString() {
            String temp = "";
            switch (direction) {
                case Direction.Stop: {
                    temp = "-";
                } break;
                case Direction.Forward: {
                    temp = "F";
                } break;
                case Direction.Backward: {
                    temp = "R";
                } break;
            }
            return String.Concat(temp, " ", absSpeed.ToString());
        } // END public override string ToString()

        public string ToString(bool isLeftDescryption) {
            if (isLeftDescryption) {
                String temp = "";
                switch(direction) {
                    case Direction.Stop: {
                            temp = "-";
                        }
                        break;
                    case Direction.Forward: {
                            temp = "F";
                        }
                        break;
                    case Direction.Backward: {
                            temp = "R";
                        }
                        break;
                }
                return String.Concat(absSpeed.ToString(), " ", temp);

            } else {
                return this.ToString();
            }
        }

        public int deltaAbsSpeed(Motor other) {
            if (this.direction != other.direction)
                return this.absSpeed + other.absSpeed;
            else 
            return Math.Abs(this.absSpeed - other.absSpeed);
        }

        public int deltaSpeedDirection(Motor other) {
            return Math.Abs(this.speedDirection - other.speedDirection);
        }
        /*

               Konstruktory     

       */
        public Motor(int speedDirection = 0, int maxSpeed = 255) {
            this.speedDirection = speedDirection;
            this.maxSpeed = maxSpeed;
        }
        public Motor(Motor motor) {
            //this.absSpeed = motor.absSpeed;
            //this.direction = motor.direction;
            this.maxSpeed = motor.maxSpeed;
            this.speedDirection = motor.speedDirection;
        }
    }
}