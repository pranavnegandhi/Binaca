const AppModel = function() {
    const evaluate = function(expression) {
        var stack = [];

        for (const token of expression) {
            token.evaluate(stack);
        }

        return stack.pop();
    };

    return {
        evaluate: evaluate
    };
}