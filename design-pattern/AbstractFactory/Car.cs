namespace design_pattern.AbstractFactory
{
    internal interface ICar
    {
        string GetCarType();
    }

    class SportsCar : ICar
    {
        public string GetCarType()
        {
            return "Sports Car";
        }
    }

    class FamilyCar : ICar
    {
        public string GetCarType()
        {
            return "Family Car";
        }
    }

}
