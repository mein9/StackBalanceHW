# StackBalanceHW
The task was to implement a method to check if parentheses in a given expression
are balanced using a stack data structure in C#. The solution involved creating a 
method named IsBalanced within a ParenthesisChecker class. This method utilized the Last-In-First-Out 
(LIFO) property of stacks to ensure that each opening parenthesis had a corresponding closing parenthesis 
and that they were correctly nested.The IsBalanced method iterates through each character in the expression.
If an opening parenthesis is encountered, it is pushed onto the stack. If a closing parenthesis is encountered, 
the method checks if the stack is not empty and if the top of the stack is the corresponding opening parenthesis.
If these conditions are met, the opening parenthesis is popped from the stack; otherwise, the expression is deemed
unbalanced. Finally, the method checks if the stack is empty to determine if the expression is balanced.Additionally,
a user interface was implemented in the Main method to allow users to input their own expressions or use a default
example. This was achieved by prompting the user for input and using the default expression if no input was provided.

Challenges and Solutions
One of the primary challenges encountered was ensuring the correct handling of different types of parentheses 
((), {}, []). This required careful checking of corresponding pairs using conditional statements. 
The solution involved a clear mapping of each closing parenthesis to its corresponding opening 
parenthesis.Another challenge was handling edge cases, such as empty strings and expressions with 
characters other than parentheses. These cases were addressed by iterating through the entire expression 
and only pushing or popping parentheses onto the stack, ignoring other characters.A minor issue arose when 
initializing variables, specifically ensuring that characters were correctly assigned. This was resolved by properly
initializing character variables using single quotes (e.g., char c = 'c';).Unit testing was crucial to verify the 
functionality of the IsBalanced method. Tests were written to cover various scenarios, 
including balanced and unbalanced expressions, nested parentheses, and expressions with additional characters.Overall,
the implementation was successful, and the challenges were overcome through careful planning, thorough testing, and iterative debugging.