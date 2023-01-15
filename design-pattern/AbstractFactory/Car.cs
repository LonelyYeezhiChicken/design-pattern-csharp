namespace design_pattern.AbstractFactory
{
    /// <summary>
    /// 車輛介面
    /// </summary>
    internal interface ICar
    {
        /// <summary>
        /// 取得車種
        /// </summary>
        /// <returns>車種</returns>
        string GetCarType();
    }

    /// <summary>
    /// 跑車
    /// </summary>
    internal class SportsCar : ICar
    {
        /// <summary>
        /// 取得車種
        /// </summary>
        /// <returns>跑車</returns>
        public string GetCarType()
        {
            return "Sports Car";
        }
    }

    /// <summary>
    /// 家庭式
    /// </summary>
    internal class FamilyCar : ICar
    {
        /// <summary>
        /// 取得車種
        /// </summary>
        /// <returns>家庭車</returns>
        public string GetCarType()
        {
            return "Family Car";
        }
    }

}
