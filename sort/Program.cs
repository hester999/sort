using System.Formats.Asn1;
using stack;


Stack s = new Stack();

bool flag = true;

while (flag)
{
    Console.WriteLine("1. Add element in stack");
    Console.WriteLine("2. Show element by index");
    Console.WriteLine("3. Show stack lenght");
    Console.WriteLine("4. Set the element by index");
    Console.WriteLine("5. Get the element by index");
    Console.WriteLine("6. Show all stack");
    Console.WriteLine("7. Sort stack");
    Console.WriteLine("8. Clear all stack");
    Console.WriteLine("9. Exit");
    Console.Write("Choose point menu: ");

    int answer = Int32.Parse(Console.ReadLine());

    switch (answer)
    {
        case 1:
            Console.WriteLine("do you want to enter several elements? y/n");
            string ans = Console.ReadLine();
            if (ans == "y" || ans == "Y")
            {
                Console.WriteLine("enter stack lenght");
                int stack_len = Int32.Parse(Console.ReadLine());

                for (int i = 0; i < stack_len; i++)
                {
                    Console.WriteLine("Enter element");
                    int element  = Int32.Parse(Console.ReadLine());
                    s.Push(element);
                }
            }
            else
            {int item = Int32.Parse(Console.ReadLine());
                s.Push(item);
            }
            break;  
        case 2:
            Console.WriteLine("Enter index");
            int index = Int32.Parse(Console.ReadLine());
            Console.WriteLine(s.Set(index));
            break;
            
        case 3:
            Console.WriteLine(s.Len());
            break;
        case 4:
            Console.WriteLine("enter element");
            int element_1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter position");
            int pos = Int32.Parse(Console.ReadLine());
            
            s.Set_element(element_1 , pos);
            break;
        case 5: 
            Console.WriteLine("Enter index");
            int index_1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine(s.Get_element(index_1));
            break;
        case 6:
            s.Show();
            break;
        case 7:
            s.BinaryInsertionSort();
            s.Show();
            break;
        case 8:
            s.Clear();
            break;
        case 9:
            flag = false;
            break;
    }
}







