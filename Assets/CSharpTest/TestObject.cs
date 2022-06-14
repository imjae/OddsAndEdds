namespace CShapTest
{
    public class TestObject
    {
        public int _a;
        public int _b;

        public int B { get => _b; set { _b = value; } }

        public int GetA()
        {
            return _a;
        }

        public void SetA(int a)
        {
            _a = a;
        }
    }
}