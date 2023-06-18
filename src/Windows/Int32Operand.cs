namespace Notadesigner.Binaca
{
    public class Int32Operand : IToken
    {
        public Int32Operand(int value)
        {
            Value = value;
        }

        public int Value { get; init; }

        public void Evaluate(Stack<int> stack)
        {
            stack.Push(Value);
        }
    }
}