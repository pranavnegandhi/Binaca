const IntegerToken = function(value) {
    const _type = 'integerToken';

    const getType = () => _type;

    evaluate = function(stack) {
        stack.push(value);
    };

    return {
        getType: getType,
        evaluate: evaluate
    };
}