namespace Carfactory
{
    class Car
    {
        protected readonly string _manufacturer;

        protected readonly string _model;

        public Car(int seats, int doors, string color, string manufacturer, string model)
        {
            _manufacturer = manufacturer;
            _model = model;

            Seats = seats;
            Doors = doors;
            Color = color;
        }

        public int Seats { get; }

        public int Doors { get; }

        public string Color { get; }

        public string Name => $"{_manufacturer} {_model}";

        public override string ToString()
        {
            return $"{Name} (Seats: {Seats}, Doors: {Doors}, Color: {Color})";
        }
    }
}
