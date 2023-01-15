namespace design_pattern.AbstractFactory
{
    internal interface ICarFactory
    {
        /// <summary>
        /// 取得車輛實體
        /// </summary>
        /// <returns></returns>
        ICar CreateCar();
    }

    /// <summary>
    /// 跑車工廠
    /// </summary>
    internal class SportsCarFactory : ICarFactory
    {
        /// <summary>
        /// 取得車輛實體
        /// </summary>
        /// <returns></returns>
        public ICar CreateCar()
        {
            return new SportsCar();
        }
    }

    /// <summary>
    /// 家庭車工廠
    /// </summary>
    internal class FamilyCarFactory : ICarFactory
    {

        /// <summary>
        /// 取得車輛實體
        /// </summary>
        /// <returns></returns>
        public ICar CreateCar()
        {
            return new FamilyCar();
        }
    }
}
