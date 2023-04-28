﻿namespace BetterFillSpheres
{
    public class Sphere
    {
        private Color Color { get; set; }
        private float Radius { get; set; }
        private uint TimesThrown { get; set; } = 0;
        
        public Sphere(Color color, float radius)
        {
            Color = color;
            Radius = radius;
            TimesThrown = 0;
        }

        /// <summary> Pops the ball by setting its radius to 0 </summary>
        public void Pop() => Radius = 0;
        
        /// <summary> Throws the Sphere in case it hasn't been popped </summary>
        public void Throw() => TimesThrown = Radius > 0 ? TimesThrown + 1 : TimesThrown;

        public override string ToString() => $"color:({Color}), radius:{Radius}, times thrown:{TimesThrown}";
    }
}