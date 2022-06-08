using System;
using System.Collections.Generic;

namespace StringCalculator
{


    /*

Instructions
Given a mathematical expression as a string you must return the result as a number.

Numbers
Number may be both whole numbers and/or decimal numbers. The same goes for the returned result.

Operators
You need to support the following mathematical operators:

Multiplication *
Division /
Addition +
Subtraction -
Operators are always evaluated from left-to-right, and * and / must be evaluated before + and -.

Parentheses
You need to support multiple levels of nested parentheses, ex. (2 / (2 + 3.33) * 4) - -6

Whitespace
There may or may not be whitespace between numbers and operators.

An addition to this rule is that the minus sign (-) used for negating numbers and parentheses will never be separated by whitespace. I.e., all of the following are valid expressions.

1-1    // 0
1 -1   // 0
1- 1   // 0
1 - 1  // 0
1- -1  // 2
1 - -1 // 2

6 + -(4)   // 2
6 + -( -4) // 10
And the following are invalid expressions

1 - - 1    // Invalid
1- - 1     // Invalid
6 + - (4)  // Invalid
6 + -(- 4) // Invalid
Validation
You do not need to worry about validation - you will only receive valid mathematical expressions following the above rules.

Eval
Using eval or similar functionality is disabled for most languages and will be considered cheating if used.
    */

    public class StringCal
    {
        private static double[] operandArr = new Double[2];
        private static string number = string.Empty;
        private static double result = 0;
        private static char sign = '\n';

        public static double Calc(string expression)
        {
            string trimExpression = expression.Trim().Replace(" ", "");

            return SimpleArithmetics(expression);
        }

        static double SimpleArithmetics(string innerExpression)
        {
            
            int k=1;
            for (int j = 0; j < innerExpression.Length; j++)
            {
                if(IsSign(innerExpression[j]))
                {
                    if(sign != '\n') sign = SignRule(sign, innerExpression[j]);

                    operandArr[0] = FoundNumber(number);
                    operandArr[1] = FoundNumber(number);

                    number = string.Empty;
                }
                else
                {
                    number += innerExpression[j].ToString();
                }   
                k++;
            }
            return result;
        }

        

        static double FoundNumber(string number)
        {

            if(!Double.TryParse(number, out double result))
            {
                return 0;
            }
            return result;
        }

        static char SignRule(char first, char second)
        {
            return (first, second) switch
            {
                ('+', '+') => '+',
                ('+', '-') => '-',
                ('-', '+') => '-',
                ('-', '-') => '+',
                _ => '\0'
            };
        }
        static bool IsSign(char sign)
        {
            return (sign) switch
            {
                ('+') => true,
                ('-') => true,
                ('*') => true,
                ('/') => true,
                _ => false
            };
        }

        static bool IsBracket(char sign)
        {
            return (sign) switch
            {
                ('(') => true,
                (')') => true,
                _ => false
            };
        }

        static double MultiplerPreceedence(double firstOperand, double secondOperand, char sign)
        {
            switch(sign)
            {
                case '*':
                    return Multiple(firstOperand, secondOperand);
                case '/':
                    return Divide(firstOperand, secondOperand);
                default:
                    return 0;
            }

        }
        static double Sum(double first, double second)
        {
            double result = operandArr[0] + operandArr[1];
            operandArr = new Double[2];
            sign = '\n';
            return result;

        }
        static double Subtract(double first, double second)
        {
            double result = operandArr[0] - operandArr[1];
            operandArr = new Double[2];
            sign = '\n';
            return result;
        }
        static double Multiple(double first, double second)
        {
            double result = operandArr[0] * operandArr[1];
            operandArr = new Double[2];
            sign = '\n';
            return result;
        }
        static double Divide(double first, double second)
        {
            double result = operandArr[0] / operandArr[1];
            operandArr = new Double[2];
            sign = '\n';
            return result;
        }
    }

}