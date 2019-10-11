namespace ClassBoxData
{
    using System;

    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get => this.length;
            private set
            {
                ValidationSide(value, nameof(Length));
                this.length = value;
            }
        }

        public double Width
        {
            get => this.width;
            private set
            {
                ValidationSide(value, nameof(Width));
                this.width = value;
            }
        }

        public double Height
        {
            get => this.height;
            private set
            {
                ValidationSide(value, nameof(Height));
                this.height = value;
            }
        }

        private void ValidationSide(double value, string side)
        {
            if (value < 0)
            {
                throw new ArgumentException($"{side} cannot be zero or negative.");
            }
        }

        public double Volume => this.length * this.width * this.height;
        
        public double LateralSurfaceArea => 2 * (this.length* this.height +  this.width * this.height);
        
        public double SurfaceArea => 2 * (this.length * this.width) + this.LateralSurfaceArea;
        
    }
}
