namespace design_pattern.Builder
{
    internal abstract class Builder
    {
        public abstract void BuildDoor();
        public abstract void BuildWall();
        public abstract void BuildWindow();
        public abstract House GetProduct();
    }

    internal class ConcreteBuilder : Builder
    {
        private House _product = new();

        public override void BuildDoor()
        {
            _product.Door = "門";
        }

        public override void BuildWall()
        {
            _product.Wall = "牆壁";
        }

        public override void BuildWindow()
        {
            _product.Window = "窗戶";
        }

        public override House GetProduct()
        {
            return _product;
        }
    }
}
