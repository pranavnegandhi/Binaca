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

    document.addEventListener('keyup', event => {
        switch (event.key) {
            case '1':
                appendDigit(1);
                break;

            case '0':
                appendDigit(0);
                break;

            case '+':
                appendOperator('+');
                break;

            case '-':
                appendOperator('-');
                break;

            case '=':
            case 'Enter':
                compute();
                break;

            case 'c':
                clear();
                break;

            case 'C':
                clearExpression();
                break;
        }
    });

    let _infix = [];

    let _display;

    let _operation = null;

    let _operand = null;

    let _repeatBuffer = [];

    const clear = function () {
        _repeatBuffer = [];
        _infix.splice(0, _infix.length);
        setDisplay('0');
        _operation = null;
        _operand = null;
    };

    const clearExpression = function () {
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

        if (_repeatBuffer.length > 0) {
            /// Clear the repeat buffer
            _repeatBuffer.splice(0, _repeatBuffer.length);
            setDisplay('0');
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
            /// Clear the repeat buffer
            _repeatBuffer.splice(0, _repeatBuffer.length);
        } else if ('-' == operator) {
            _operation = new SubtractToken();

            _infix.push(_operand);
            _operand = null;
            /// Clear the repeat buffer
            _repeatBuffer.splice(0, _repeatBuffer.length);
        }
    };

    const compute = function () {
        if (null != _operation || null == _operand) {
            return;
        }

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

        /// Add the tokens from the repeat buffer if it is not empty
        if (_repeatBuffer.length > 0) {
            postfix = postfix.concat(_repeatBuffer);
        }

        /// Clear the infix buffer
        _infix.splice(0, _infix.length);

        _repeatBuffer = postfix.slice(-2);

        let result = appModel.evaluate(postfix);
        setDisplay(result.toString(2));
        _operand = new IntegerToken(result); /// Store the result for later use in the infix buffer
    }

    setDisplay('0');
};