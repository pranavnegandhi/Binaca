namespace Notadesigner.Binaca
{
    public class AppModel
    {
        public void Clear()
        {

        }

        public int Evaluate(List<IToken> expression)
        {
            var stack = new Stack<int>();

            foreach (var token in expression)
            {
                token.Evaluate(stack);
            }

            return stack.Pop();
        }
    }
}