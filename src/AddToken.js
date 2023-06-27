const AddToken = function() {
    const _type = 'addToken';

    const getType = () => _type;

    const getValue = () => '+';

    const evaluate = function(stack) {
        const op1 = stack.pop();
        const op2 = stack.pop();
        stack.push(op1 + op2);
    };

    return {
        'getType': getType,
        'getValue': getValue,
        'evaluate': evaluate,
        'toString': getValue
    };
}