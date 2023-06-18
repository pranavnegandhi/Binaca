using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Notadesigner.Binaca
{
    public class AppContext : ApplicationContext, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private readonly AppModel _model = new();

        private readonly Form1 _mainForm = new();

        private readonly List<IToken> _infix = new();

        private IToken? _operation = null;

        private IToken? _operand = null;

        public AppContext()
        {
            /// Tie up the application lifetime to the
            /// state of the main form.
            MainForm = _mainForm;
            MainForm.CancelButton = _mainForm.ButtonClearAll;
            MainForm.AcceptButton = _mainForm.ButtonOperatorEquals;

            _mainForm.ButtonClearAll.Click += (sender, e) => Clear();
            _mainForm.ButtonDigitOne.Click += (sender, e) => AppendDigit('1');
            _mainForm.ButtonDigitZero.Click += (sender, e) => AppendDigit('0');
            _mainForm.ButtonOperatorAdd.Click += (sender, e) => AppendOperator('+');
            _mainForm.ButtonOperatorEquals.Click += Compute;

            var binding = new Binding(nameof(Form1.textBox1.Text), this, nameof(Display));
            _mainForm.textBox1.DataBindings.Add(binding);
        }

        private string _display = "0";

        public string Display
        {
            get => _display;

            set
            {
                if (_display == value)
                {
                    return;
                }

                _display = value;
                OnPropertyChanged();
            }
        }

        private void AppendDigit(char digit)
        {
            if (null != _operation)
            {
                Display = string.Empty;

                /// Save the operator in the infix expression
                _infix.Add(new AddOperator());
                _operation = null;
            }

            /// Three-step process to display the number without leading zeros
            /// 1. Append the digit to the end of the display
            /// 2. Evaluate it as an int
            /// 3. Convert the result to a string and display it on screen
            var temp = Display + digit;
            if (!int.TryParse(temp, out var result))
            {
                result = 0;
            }
            /// Display the binary number
            Display = result.ToString();

            /// Convert the binary number to decimal
            result = Convert.ToInt32(temp, 2);
            /// Create an operand token and store in a field
            /// to be added later to the end of the infix list
            _operand = new Int32Operand(result);
        }

        private void AppendOperator(char op)
        {
            /// Check input values before allowing the operation
            if (null != _operation || null == _operand)
            {
                return;
            }

            if ('+' == op)
            {
                _operation = new AddOperator();

                _infix.Add(_operand);
                _operand = null;
            }
        }

        private void Clear()
        {
            _infix.Clear();
            Display = "0";
            _operation = null;
            _operand = null;
        }

        private void Subtract(object? sender, EventArgs e)
        {
        }

        private void Compute(object? sender, EventArgs e)
        {
            if (null != _operation || null == _operand)
            {
                return;
            }

            _infix.Add(_operand);
            _operand = null;

            var postfix = new List<IToken>();
            var stack = new Stack<IToken>();

            for (var i = 0; i < _infix.Count; i++)
            {
                var token = _infix[i];

                if (token is Int32Operand)
                {
                    postfix.Add(token);
                }
                else if (token is AddOperator)
                {
                    while (stack.Count > 0)
                    {
                        var d = stack.Pop();
                        postfix.Add(d);
                    }

                    stack.Push(token);
                }
            }

            while (stack.Count > 0)
            {
                var d = stack.Pop();
                postfix.Add(d);
            }

            Clear();

            var result = _model.Evaluate(postfix);
            Display = Convert.ToString(result, 2);
        }

        private void OnPropertyChanged([CallerMemberName] string? name = default) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}