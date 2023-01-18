using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Collections;
using org.matheval.Node;


class CalculatorLogic
{
    
    private ArrayList foundNumbers = new ArrayList();
    private ArrayList foundOperators = new ArrayList();
    private char[] operators = { '+', '-', '/', '%', '*', '÷', '^', '√' };
    private char[] specialOperators = { '+', '-' , '√' };
    private char[] numbers = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
    private int lastOpIndex = 0;

    public string Expression { get; set; }

    public CalculatorLogic(String expression) => Expression = expression;

         

    public String Parse()
    {
        if (Expression.Length == 0)
        {
            return "";
        }

        if ((isOperator(Expression.ElementAt(0)) && !isSpecialOperator(Expression.ElementAt(0))) || isOperator(Expression.ElementAt(Expression.Length - 1)))
        {
            throw new Exception("Cannot have an operator at the beggining or end of expression.");
        } else if (Expression.ElementAt(0) == '.' || Expression.ElementAt(Expression.Length - 1) == '.') {
            throw new Exception("Cannot have a dot at the beggining or end of expression.");
        }

        for (int i = 0; i < Expression.Length; i++)
        {
            if ((i > 0 || Expression.ElementAt(i) == '√') && isOperator(Expression.ElementAt(i)))
            {
                if (i < (Expression.Length -1) && (isOperator(Expression.ElementAt(i + 1)) && Expression.ElementAt(i+1) != '√'))
                {
                    throw new Exception("Two operators cannot be next to each other.");
                }
                else if ((i > 0 && Expression.ElementAt(i - 1) == '.') || 
                    (i < (Expression.Length - 1) && Expression.ElementAt(i + 1) == '.'))
                {
                    throw new Exception("Cannot have dot next to operator.");
                } 
                else
                {
                    StringBuilder numBuilder = new StringBuilder();
                        if (lastOpIndex == 0 && Expression.ElementAt(i) != '√')
                        {
                            for (int j = lastOpIndex; j < i; j++)
                            {
                                numBuilder.Append(Expression.ElementAt(j));
                            }
                        } 
                        else if (Expression.ElementAt(i) != '√')
                        {
                            for (int j = lastOpIndex + 1; j < i; j++)
                            {
                                numBuilder.Append(Expression.ElementAt(j));
                            }
                            
                        }
                    lastOpIndex = i;
                    if (numBuilder.Length != 0)
                    {
                        foundNumbers.Add(double.Parse(numBuilder.ToString()));
                    }
                }
                foundOperators.Add(Expression.ElementAt(i));
            } 
            else if (!isOperator(Expression.ElementAt(i)) 
            && !isNum(Expression.ElementAt(i)) && Expression.ElementAt(i) != '.') {
                throw new Exception("Unknown Symbol");
            } 
        }
        StringBuilder numBuilder2 = new StringBuilder();
        if (lastOpIndex == 0 && Expression.ElementAt(0) != '√')
        {
            for (int j = lastOpIndex; j < Expression.Length; j++)
            {
                numBuilder2.Append(Expression.ElementAt(j));
            }
        }
        else
        {
            for (int j = lastOpIndex+1; j < Expression.Length ; j++)
            {
                numBuilder2.Append(Expression.ElementAt(j));
            }
        }
        foundNumbers.Add(double.Parse(numBuilder2.ToString()));

        return calculate();
    }

    public string calculate()
    {
        for (int i = 0; i < foundOperators.Count; i++)
        {
            if ((char)foundOperators[i] == '+')
            {
                foundNumbers[i+1] = (double)foundNumbers[i] + (double)foundNumbers[i+1];
            }
            else if ((char)foundOperators[i] == '-')
            {
                foundNumbers[i + 1] = (double)foundNumbers[i] - (double)foundNumbers[i + 1];
            }
            else if ((char)foundOperators[i] == '*')
            {
                foundNumbers[i + 1] = (double)foundNumbers[i] * (double)foundNumbers[i + 1];
            }
            else if ((char)foundOperators[i] == '/' || (char)foundOperators[i] == '÷')
            {
                if ((double)foundNumbers[i + 1] == 0)
                {
                    throw new Exception("Cannot divide by zero.");
                }
                    foundNumbers[i + 1] = (double)foundNumbers[i] / (double)foundNumbers[i + 1];
            }
            else if ((char)foundOperators[i] == '%')
            {
                foundNumbers[i + 1] = (double)foundNumbers[i] % (double)foundNumbers[i + 1];
            }
            else if ((char)foundOperators[i] == '^')
            {
                foundNumbers[i + 1] = Math.Pow((double)foundNumbers[i], (double)foundNumbers[i + 1]);
            }
            else if ((char)foundOperators[i] == '√')
            {
                if (i+1 == foundNumbers.Count)
                {
                    foundNumbers.Add(0);
                }
                foundNumbers[i + 1] = Math.Sqrt((double)foundNumbers[i]);
            }
        }
        return foundNumbers[foundNumbers.Count-1].ToString();

    }

        public bool isOperator(char input)
        {
            bool result = false;
            foreach (char op in operators)
            {
                if (op == input)
                {
                    result = true;
                }
            }
            return result;
        }

        public bool isNum(char input)
        {
            bool result = false;
            foreach (char num in numbers)
            {
                if (num == input)
                {
                    result = true;
                }
            }
            return result;
        }


    public bool isSpecialOperator(char input)
    {
        bool result = false;
        foreach (char op in specialOperators)
        {
            if (op == input)
            {
                result = true;
            }
        }
        return result;
    }
}

