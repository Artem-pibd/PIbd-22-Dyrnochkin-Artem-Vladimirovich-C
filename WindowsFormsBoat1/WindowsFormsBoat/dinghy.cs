using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsBoat
{
    class dinghy
    {
        //левая координата лодки
        private float _startPosX;
        //правая координата лодки
        private float _startPosY;
        //ширина окна отрисовки 
        private int _pictureWidth = 100;
        //высота окна отрисовки
        private int _pictureHeight = 60;
        //ширина отрисовки лодки
        private readonly int boatWidth = 50;
        //высота отрисовки лодки
        private readonly int boatHeight = 30;
        //максимальная скорость 
        public int MaxSpeed { private set; get; }
        //вес лодки
        public float Weight { private set; get; }
        //основной цвет кузова
        public Color MainColor { private set; get; }
        //дополнительный цвет
        public Color DopColor { private set; get; }
        //признак наличия мотора
        public bool Motor { private set; get; }
        //наличие спортивной полосы
        public bool SportLine { private set; get; }

        public dinghy(int maxSpeed, float weight, Color mainColor, Color dopColor, bool motor, bool sportLine)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Motor = motor;
            SportLine = sportLine;
        }

        //Установка позиции лодки
        // x - координата Х
        // у - координата У
        // wight - ширина
        // height - высота

        public void SetPosition(int x,int y,int wight,int height)
        {         
                _startPosX = x;
                _startPosY = y;
                _pictureWidth = wight;
                _pictureHeight = height;
        }

    
        public void MoveTransport(Direction direction)
        {

            float step = MaxSpeed * 100 / Weight;
            int otstupR = 210;
            int otstupL = 49;
            int otstupU = 120;
            int otstupD = 150;
            switch (direction)
            {
                //вправо
                case Direction.Right:

                    if (_startPosX + otstupR + step  < _pictureWidth - boatWidth) 
                    {                                            
                        _startPosX += step;
                    }
                    break;
                                     
                //влево
                case Direction.Left:
                    if (_startPosX + otstupL + step  > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY + otstupU + step   > 0) 
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + otstupD + step  < _pictureHeight - boatWidth)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        public void DrawTransport (Graphics g)
        {
            Pen pen = new Pen(Color.Red);
            //основа лодки
            SolidBrush myBoat = new SolidBrush(Color.Gray);
            g.FillPolygon(myBoat, new Point[]

            {
                new Point((int)_startPosX + 250,(int)_startPosY + 200),new Point((int)_startPosX + 100,(int)_startPosY + 200),
                new Point ((int)_startPosX + 100,(int)_startPosY + 200),new Point((int)_startPosX + 70,(int)_startPosY + 170),
                new Point ((int)_startPosX + 70,(int)_startPosY + 170),new Point((int)_startPosX + 130,(int)_startPosY + 160),
                new Point ((int)_startPosX + 130,(int)_startPosY + 160),new Point((int)_startPosX + 250,(int)_startPosY + 170),
                new Point ((int)_startPosX + 250,(int)_startPosY + 170),new Point((int)_startPosX + 260,(int)_startPosY + 180),
                new Point ((int)_startPosX + 260,(int)_startPosY + 180),new Point((int)_startPosX + 260,(int)_startPosY + 180),
            }
            );
            //дополнение лодки
            SolidBrush myBoat2 = new SolidBrush(Color.Red);
            g.FillPolygon(myBoat2, new Point[]
            {
                new Point((int)_startPosX + 130,(int)_startPosY + 160),new Point((int)_startPosX + 160,(int)_startPosY + 140),
                new Point((int)_startPosX + 160,(int)_startPosY + 140),new Point((int)_startPosX + 250,(int)_startPosY + 170),
            }
            );
            //полоса
            SolidBrush myBoat3 = new SolidBrush(Color.Red);
            g.FillPolygon(myBoat3, new Point[]
            {
                new Point((int)_startPosX + 85,(int)_startPosY + 185),new Point((int)_startPosX + 90,(int)_startPosY + 167),
                new Point((int)_startPosX + 255,(int)_startPosY + 178),new Point((int)_startPosX + 255,(int)_startPosY + 189),
            }
            );
            //подобие мотора
            SolidBrush myBoat4 = new SolidBrush(Color.Black);
            g.FillPolygon(myBoat4, new Point[]
            {
                new Point((int)_startPosX + 240,(int)_startPosY + 200),new Point((int)_startPosX + 255,(int)_startPosY + 190),
                new Point((int)_startPosX + 270,(int)_startPosY + 210),new Point((int)_startPosX + 260,(int)_startPosY + 210),
            }
            );




        }

    }
}
