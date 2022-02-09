namespace B
{
    using A;

    public class TheOtherClass
    {
        private void MethodATest()
        {
            // this yields the error message: Error CS0246  The type or namespace name '{0}' could not be found(are you missing a using directive or an assembly reference?)
            // the MethodA method in TheClass in the class library project doesn't compile right now, because i added a comma at the end of the parameter list.
            TheClass.MethodA(1);
        }
    }

}