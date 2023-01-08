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
                Console.Write(item);
                Console.Write(" ");
            }
             
            Console.WriteLine();
        }

        public int Set(int item)
        {
            return stack[item];
        }
        public int Get_element(int item)
        {
            return stack[item];
        }

        public void Set_element(int item, int index)
        {
            stack.Insert(index, item);
        }

        public void Clear()
        {
            stack.Clear();
        }


     
        public void BinaryInsertionSort()
        {
            for (int i = 1; i < stack.Count; ++i) {
                int key = stack[i];
                int insertedPosition = findPosition(stack, 0, i - 1, key);

                for (int j = i - 1; j >= insertedPosition; --j) {
                    stack[j + 1] = stack[j];
                }

                stack[insertedPosition] = key;
            }

            stack.Reverse();
        }

        public static int findPosition(List<int> nums, int start, int end, int key) {
            while (start <= end) {
                int mid = start + (end - start) / 2;

                if (key < nums[mid]) {
                    end = mid - 1;
                } else {
                    start = mid + 1;
                }
            }

            return start;
        }
    }
}