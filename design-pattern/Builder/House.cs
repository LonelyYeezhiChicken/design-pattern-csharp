namespace design_pattern.Builder
{
    internal class House
    {
        /// <summary>
        /// 門
        /// </summary>
        public string Door { get; set; }
        /// <summary>
        /// 牆
        /// </summary>
        public string Wall { get; set; }
        /// <summary>
        /// 窗戶
        /// </summary>
        public string Window { get; set; }

        public override string ToString()
        {
            return $"房子包含: {Door}、{Wall}、{Window}";
        }
    }
}
