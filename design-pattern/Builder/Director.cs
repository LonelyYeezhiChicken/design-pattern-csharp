namespace design_pattern.Builder
{
    internal class Director
    {
        public static void Construct(Builder builder)
        {
            builder.BuildDoor();
            builder.BuildWall();
            builder.BuildWindow();
        }
    }
}
