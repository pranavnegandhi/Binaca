const AppContext = function () {
    const buttonClearAll = document.querySelector('#buttonClearAll');
    buttonClearAll.addEventListener('click', () => clear());

    const buttonClearExpression = document.querySelector('#buttonClearExpression');
    buttonClearExpression.addEventListener('click', () => clearExpression());

    const buttonDigitOne = document.querySelector('#buttonDigitOne');
    buttonDigitOne.addEventListener('click', () => appendDigit('1'));

    const buttonDigitZero = document.querySelector('#buttonDigitZero');
    buttonDigitZero.addEventListener('click', () => appendDigit('0'));

    const buttonOperatorAdd = document.querySelector('#buttonOperatorAdd');
    buttonOperatorAdd.addEventListener('click', () => appendOperator('+'));

    const buttonOperatorSubtract = document.querySelector('#buttonOperatorSubtract');
    buttonOperatorSubtract.addEventListener('click', () => appendOperator('-'));

    const buttonEquals = document.querySelector('#buttonOperatorEquals');
    buttonEquals.addEventListener('click', () => compute());

    const digitDisplay = document.querySelector('#digitDisplay');

    const appModel = new AppModel();

    let _infix = [];

    let _display;

    let _operation = null;

    let _operand = null;

    const clear = function () {
        _infix.splice(0, _infix.length);
        setDisplay('0');
        _operation = null;
        _operand = null;
    };

    const clearExpression = function() {
        setDisplay('0');
        _operand = null;
    }

    const getDisplay = () => _display;

    const setDisplay = (value) => {
        _display = value.toString();
        digitDisplay.value = _display;
    };

    const appendDigit = function (value) {
        if (null != _operation) {
            setDisplay('0');

            /// Save the operator in the infix expression
            _infix.push(_operation);
            _operation = null;
        }

        /// Three-step process to display the number without leading zeros
        /// 1. Append the digit to the end of the display
        /// 2. Evaluate it as an int
        /// 3. Convert the result to a string and display it on screen
        var temp = getDisplay() + value;
        var result = parseInt(temp);
        /// Display the binary number
        setDisplay(result);

        /// Convert the binary number to decimal
        result = parseInt(temp, 2);
        /// Create an operand token and store in a field
        /// to be added later to the end of the infix list
        _operand = new IntegerToken(result);
    }

    const appendOperator = function (operator) {
        /// Check input values before allowing the operation
        if (null != _operation || null == _operand) {
            return;
        }

        if ('+' == operator) {
            _operation = new AddToken();

            _infix.push(_operand);
            _operand = null;
        } else if ('-' == operator) {
            _operation = new SubtractToken();

            _infix.push(_operand);
            _operand = null;
        }
    };

    const compute = function () {
        if (null != _operation || null == _operand) {
            return;
        }

        const op = new AddToken();

        _infix.push(_operand);
        _operand = null;

        var postfix = [];
        var stack = [];

        for (var i = 0; i < _infix.length; i++) {
            var token = _infix[i];

            if (token.getType() === 'integerToken') {
                postfix.push(token);
            } else if (token.getType() === 'addToken' ||
                        token.getType() === 'subtractToken') {
                while (stack.length > 0) {
                    var d = stack.pop();
                    postfix.push(d);
                }

                stack.push(token);
            }
        }

        while (stack.length > 0) {
            var d = stack.pop();
            postfix.push(d);
        }

        clear();

        let result = appModel.evaluate(postfix);
        setDisplay(result.toString(2));
        _operand = new IntegerToken(result);
    }

    setDisplay('0');

    return {
        getDisplay: getDisplay,
        setDisplay: setDisplay
    }
};