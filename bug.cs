public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a property that is not initialized can lead to unexpected behavior.
        int value = MyProperty; // Uninitialized property
        Console.WriteLine(value); // May print 0 or throw exception
    }
}