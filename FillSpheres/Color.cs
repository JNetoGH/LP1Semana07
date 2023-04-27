namespace FillSpheres
{
    public class Color
    {
        private byte _red = 0;
        private byte _blue = 0;
        private byte _green = 0;
                            
        public Color(byte red, byte blue, byte green)
        {
            _red = red;
            _blue = blue;
            _green = green;
        }

        public byte GetRed() => this._red;
        public void SetRed(byte newValue) => this._red = newValue;

        public byte GetBlue() => this._blue;
        public void SetBlue(byte newValue) => this._blue = newValue;
        
        public byte GetGreen() => this._green;           
        public void SetGreen(byte newValue) => this._green = newValue;

    }
}