using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tesla_Soft {
    public struct OutFrame {
        /*
         
                Ramka pierwsza     
             
        */
        // przesuniecia bitowe bajtu szczegolowego oldByte
        const int lightsMov = 6;
        const int laserFullMov = 5;
        const int laserLightMov = 4;
        const int cameraMov = 3;
        const int motorLDirectionMov = 2;
        const int motorRDirectionMov = 1;
        const int brakeMov = 0;

        // pola bajtu oldByte
        public bool lights;
        public bool laserFull;
        public bool laserLight;
        public bool camera;
        public bool motorLDirection;
        public bool motorRDirection;
        public bool brake;

        // przesuniecia bajtowe w obrebie ramki
        const int maskOneMov = 24;
        const int oldByteMov = 16;
        const int motorLSpeedMov = 8;
        const int motorRSpeedMov = 0;

        // zawartosc bajtowa ramki
        const byte maskOne = 36; // 0b00100100
        private byte oldByte;
        public byte motorLSpeed;
        public byte motorRSpeed;

        /*
         
                Ramka druga     
             
        */
        // przesuniecia bajtowe w obrebie ramki
        const int maskTwoMov = 24; 
        const int verticalTurretMov = 16;
        const int horizontalTurretMov = 8;
        const int sumMov = 0;

        // zawartosc bajtowa ramki

        const byte maskTwo = 73; // 0b01001001
        public byte verticalTurret;
        public byte horizontalTurret;
        private byte sum;
        
        private void GenData() {
            sum = (byte)(oldByte ^ motorLSpeed ^ motorRSpeed ^ verticalTurret ^ horizontalTurret);
            oldByte = (byte)((Convert.ToByte(lights) << lightsMov) + (Convert.ToByte(laserFull) << laserFullMov) +
                (Convert.ToByte(laserLight) << laserLightMov) + (Convert.ToByte(camera) << cameraMov) +
                (Convert.ToByte(motorLDirection) << motorLDirectionMov) + (Convert.ToByte(motorRDirection) << motorRDirectionMov) +
                (Convert.ToByte(brake) << brakeMov));
        }
        public int GetFrameTwo() {
            GenData();
            
            return (maskTwo << maskTwoMov) | (verticalTurret << verticalTurretMov) | (horizontalTurret << horizontalTurretMov) |
                (sum << sumMov);
        }
        public int GetFrameOne() {
            GenData();

            return (maskOne << maskOneMov) | (oldByte << oldByteMov) | (motorLSpeed << motorLSpeedMov) | (motorRSpeed << motorRSpeedMov);
        }
        public byte[] AllFrames() {
            byte[] frame;
            frame = new byte[8];
            GenData();
            frame[7] = sum;
            frame[6] = horizontalTurret;
            frame[5] = verticalTurret;
            frame[4] = maskTwo;
            frame[3] = motorRSpeed;
            frame[2] = motorLSpeed;
            frame[1] = oldByte;
            frame[0] = maskOne;
            return frame;
        }
    }
}
