package exercise1.calculator;

import exercise1.complex.Complex;

public interface ICalculableFactory {
    Calculable create(Complex firstArg);
}
