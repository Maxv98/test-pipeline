namespace test_application
{
    public static class Messager
    {
        public static string SayHello()
        {
            return "Hello, World!";
        }

        public static string SayHello(string name)
        {
            return $"Hello, {name}!";
        }

        public static string SayGoodbye()
        {
            return "Goodbye, World!";
        }

        public static string SayGoodbye(string name)
        {
            return $"Goodbye, {name}!";
        }
    }
}
