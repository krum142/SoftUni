namespace ShoppingSpree.Exceptions
{
    public static class ExceptionMessage
    {
        public static string NegativeMoneyException =
            "Money cannot be negative";
        public static string NullOrEmptyNameException =
            "Name cannot be empty";
        public static string CannotAffordAProductException =
            "{0} can't afford {1}";
    }
}
