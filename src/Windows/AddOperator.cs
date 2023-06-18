namespace Notadesigner.Binaca
{
    public class AddOperator : IToken
    {
        public void Evaluate(Stack<int> stack)
        {
            var op1 = stack.Pop();
            var op2 = stack.Pop();
            stack.Push(op1 + op2);
        }
    }
}