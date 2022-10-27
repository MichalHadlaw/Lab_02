namespace WebApplication1.Serwices.LAB2
{
    public class Calculate
    {
        public Calculate(int value1)
        {
            Value = value1;

        }
        private int Value { get; set; }
        public void Increase(int value)
        {
            value += value;
        }

        public void Decrease(int value)
        {
            value -= value;
        }
        public int GetValue()
        {
            return Value;
        }
    }
}
