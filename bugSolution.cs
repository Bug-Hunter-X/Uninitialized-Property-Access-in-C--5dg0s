public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Initialize with a default value

    public ExampleClass(int value)
    {
        MyProperty = value;
    }

    public void MyMethod()
    {
        Console.WriteLine(this.MyProperty); // Now it's safe
    }
}