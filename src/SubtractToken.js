const SubtractToken = function() {
    const _type = 'subtractToken';

    const getType = () => _type;

    const evaluate = function(stack) {
        const op1 = stack.pop();
        const op2 = stack.pop();
        stack.push(op2 - op1);
    };

    return {
        getType: getType,
        evaluate: evaluate
    };
}