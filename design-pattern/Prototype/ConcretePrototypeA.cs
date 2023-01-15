namespace design_pattern.Prototype
{
    internal interface IPrototype
    {
        IPrototype Clone();
    }

    internal class ConcretePrototypeA : IPrototype
    {
        public int x;
        public int y;
        public string? Name;

        /// <summary>
        ///  深拷貝介面
        /// </summary>
        /// <returns></returns>
        public IPrototype Clone()
        {
            return (IPrototype)MemberwiseClone();
        }

        public override string ToString()
        {
            return $"x = {x}, y = {y}, Name = {Name}";
        }
    }
}
