﻿using System;

namespace Backend2.Services
{
    public interface ICalculatorService
    {
        int Add(int a, int b);
        int Sub(int a, int b);
        int Mul(int a, int b);
        int Div(int a, int b);
    }
}
