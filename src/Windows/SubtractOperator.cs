namespace Notadesigner.Binaca
{
    public class SubtractOperator : IToken
    {
        public void Evaluate(Stack<int> stack)
        {
            var op2 = stack.Pop();
            var op1 = stack.Pop();
            stack.Push(op1 - op2);
        }
    }
}