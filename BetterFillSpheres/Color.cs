namespace BetterFillSpheres
{
    public class Color
    {
        private byte Red { get; set; } = 0;
        private byte Blue { get; set; } = 0;
        private byte Green { get; set; } = 0;
        private byte Alpha { get; set; } = 0;
        private byte Grey => (byte)((Red + Blue + Red) / 3);
                            
        public Color(byte red, byte blue, byte green, byte alpha)
        {
            Red = red;
            Blue = blue;
            Green = green;
            Alpha = alpha;
        }
        
        public override string ToString() => $"r:{Red}, b:{Blue}, g:{Green}, a:{Alpha}";
    }
}