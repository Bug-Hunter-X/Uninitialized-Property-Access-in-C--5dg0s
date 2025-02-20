public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value;
    }

    public void MyMethod()
    {
        // Accessing a property that hasn't been initialized. 
        // This might not throw an exception immediately
        // but lead to unexpected behavior
        Console.WriteLine(this.MyProperty);
    }
}