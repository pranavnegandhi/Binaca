const IntegerToken = function(value) {
    const _type = 'integerToken';

    const getType = () => _type;

    const getValue = () => value;

    const evaluate = function(stack) {
        stack.push(value);
    };

    const toStringInternal = () => getValue().toString(2);

    return {
        'getType': getType,
        'getValue': getValue,
        'evaluate': evaluate,
        'toString': toStringInternal
    };
}