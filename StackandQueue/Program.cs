using StackandQueue;

Console.WriteLine("Welcome to Stack and Queue");


//Stack and Pop
Stack stack = new Stack();
stack.StackPush(70);
stack.StackPush(30);
stack.StackPush(56);
stack.Display();
stack.Pop();
stack.Display();

Console.WriteLine("-----------------------------------------------");


//Peak
Stack stack1 = new Stack();
stack1.StackPush(70);
stack1.StackPush(30);
stack1.StackPush(56);
stack1.Peak();
stack1.Display();


