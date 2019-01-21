using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{

    class Program
    {
        static void Main(string[] args)
        {
            Customer t = new Customer()
            {
                Name = "george",
                Age = 42
            };

            Console.Clear();
            int x = 10, y = 5;
            Dictionary<string, TextBox> textBoxes = new Dictionary<string, TextBox>();
            foreach (var propertyInfo in t.GetType().GetProperties())
            {

                foreach (var fieldInfo in propertyInfo.GetCustomAttributes<FieldInfo>())
                {
                    TextBox textBox;

                    textBox = new TextBox(t, fieldInfo, x, y, propertyInfo);
                    y += 2;
                    textBoxes.Add(propertyInfo.Name, textBox);
                }

            }
            var listOfTextBoxes = textBoxes
                .OrderBy(d => d.Value.Y)
                .Select(d => d.Value)
                .ToList();

            listOfTextBoxes.ForEach(tb => tb.Show());
            listOfTextBoxes.ForEach(tb => tb.Focus());

            Console.Clear();

            Console.WriteLine(textBoxes["Name"].Text);
            Console.WriteLine(textBoxes["Age"].Text);
            Console.WriteLine(textBoxes["Password"].Text);
            Console.ReadKey();
        }


    }
}
