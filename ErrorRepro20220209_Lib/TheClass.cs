namespace A
{
    public class TheClass
    {
        // i added a comma to the parameter list - the error on the other side is misleading.
        public static bool MethodA(int x,) => true;
    }
}