# F# Mutable Variable Bug

This example demonstrates unexpected behavior when using mutable variables within a function in F#. The `add` function modifies the input variables `x` and `y`, leading to results that might not be intuitive.

## How to Reproduce

1. Compile and run the code in `bug.fs`.
2. Observe the output. The values of `x` and `y` after calling `add` are not what one might expect given the function's operations.