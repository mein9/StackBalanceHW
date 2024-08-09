namespace StackBalanceHW
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter an expression to check if it's balanced, or press Enter to use the default example:");
            string input = Console.ReadLine();

            string expression = string.IsNullOrEmpty(input) ? "{[(2+3)*(5/2)]}" : input;  // Example expression or user input decided here

            bool result = IsBalanced(expression); // check if balanced

            Console.WriteLine($"Is the expression \"{expression}\" balanced? {result}");
        }

        public static bool IsBalanced(string expression)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char ch in expression)
            {
                // If the character is an opening parenthesis, push it onto the stack
                if (ch == '(' || ch == '{' || ch == '[')
                {
                    stack.Push(ch);
                }
                // If the character is a closing parenthesis, check for balance
                else if (ch == ')' || ch == '}' || ch == ']')
                {
                    if (stack.Count == 0)
                    {
                        // Stack is empty but we found a closing parenthesis, hence unbalanced
                        return false;
                    }

                    char top = stack.Pop();
                    if ((ch == ')' && top != '(') || (ch == '}' && top != '{') || (ch == ']' && top != '['))
                    {
                        // The closing parenthesis does not match the opening parenthesis
                        return false;
                    }
                }
            }

            // If the stack is empty, all parentheses were balanced; otherwise, not balanced
            return stack.Count == 0;
        }
    }
}
