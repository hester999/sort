namespace stack
{
    public class Stack
    {
        private List<int> stack;

        public Stack()
        {
            stack = new List<int>();
        }

        public void Push(int i)
        {
            stack.Add(i);
        }
        public int Len()
        {
            return stack.Count;
        }

        public void Show()
        {

            stack.Reverse();

            foreach (int item in stack)
            {
                Console.WriteLine(item);
            }

        }

        public int Get_element(int item)
        {
            return stack[item];
        }

        public void Set_element(int item, int index)
        {
            stack.Insert(index, item);
        }
    }
}