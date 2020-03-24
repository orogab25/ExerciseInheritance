using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseInheritance
{
    class Stack
    {
        private readonly Stack<object> stack = new Stack<object>();

        public void Push(object obj)
        {
            if (obj != null)
            {
                stack.Push(obj);
            }
            else
            {
                throw new InvalidOperationException("obj is null");
            }
        }

        public object Pop()
        {
            if (stack == null || stack.Count==0)
            {
                throw new InvalidOperationException("stack is empty");
            }
            return stack.Pop();
        }

        public void Clear()
        {
            stack.Clear();
        }
    }
}
