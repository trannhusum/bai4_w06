using System.Diagnostics;

namespace bai4_w06
{
    public class Fan
    {
        public const int slow = 1;
        public const int medium = 2;
        public const int fast = 3;
        private int speed {  get; set; }
        private bool on {  get; set; }
        private double radius { get; set; }
        private string color { get; set; }

        public Fan()
        {
            speed = slow;
            on=false;
            radius = 5;
            color = "blue";
        }

        public Fan(int speed, bool on, double radius, string color)
        {
            this.speed = speed;
            this.on = on;
            this.radius = radius;
            this.color = color;
        }

        public string ToString()
        {
            if (on == true)
                return "Speed: " + speed+", Color: "+color+", Radius: "+radius+", fan is on";
            else
                return "Color: " + color + ", Radius: " + radius + ", fan is off";
        }
    }
}
