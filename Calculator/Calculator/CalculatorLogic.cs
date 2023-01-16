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
    private String answer = "";
        private ArrayList foundNumbers = new ArrayList();
        private ArrayList foundOperators = new ArrayList();
        private char[] operators = { '+', '-', '/', '%', '*', '÷', '^', '√' };
    private char[] specialOperators = { '+', '-' };
        // private char[] brackets = { '(', ')' };
        private char[] numbers = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
        private int lastNumIndex = 0;

    public string Expression { get; set; }

    public CalculatorLogic(String expression) => Expression = expression;

         

public String Calculate()
    {
    bool hasOperator = false;
        if ((isOperator(Expression.ElementAt(0)) && !isSpecialOperator(Expression.ElementAt(0))) || isOperator(Expression.ElementAt(Expression.Length - 1)))
        {
            throw new Exception("Cannot have an operator at the beggining or end of expression.");
        } else if (Expression.ElementAt(0) == '.' || Expression.ElementAt(Expression.Length - 1) == '.') {
            throw new Exception("Cannot have a dot at the beggining or end of expression.");
        }

        for (int i = 0; i < Expression.Length; i++)
        {
                if (i > 0 && isOperator(Expression.ElementAt(i)))
                {
                    hasOperator = true;
                    if (i < (Expression.Length -1) && isOperator(Expression.ElementAt(i + 1)))
                    {
                        throw new Exception("Two operators cannot be next to each other.");
                    }
                    else if ((i > 0 && Expression.ElementAt(i - 1) == '.') || 
                    (i < (Expression.Length - 1) && Expression.ElementAt(i + 1) == '.'))
                    {
                        throw new Exception("Cannot have dot next to operator.");
                    } 
                    foundOperators.Add(i);
                } 
                else if (!isOperator(Expression.ElementAt(i)) 
                && !isNum(Expression.ElementAt(i)) && Expression.ElementAt(i) != '.') {
                    throw new Exception("Unknown Symbol");
                } 
            }
            if (hasOperator)
            {
                return "";
            } else
            {
            return Expression;
            }
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

