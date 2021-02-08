namespace AutoTestFramework
{
    public static class Config
    {
        public static int ElementsWaitingTimeout = 5;
        public static string BaseURL = "http://testing.todorvachev.com";

        public static class Credentials
        {
            public static class Valid
            {
                public static string Email = "example@example.com";
                public static string Username = "Username";
                public static string Password = "password123!";
                public static string RepeatPassword = "password123!";
            }

            public static class Invalid
            {
                public static class Email
                {
                    
                }

                public static class Username
                {
                    public static string FourCharactors = "abcd";
                    public static string ThirteenCharactors = "abcdabcdabcda";
                    
                }

                public static class Password
                {
                    public static string FourCharactors = "abcd";
                    public static string ThirteenCharactors = "abcdabcdabcda";
                    
                }
            }
        }

        public static class MenuElements
        {
            public static string Introduction = "Introduction";
            public static string Selectors = "Selectors";
            public static string SpecialElements = "Special Elements";
            public static string TestCases = "Test Cases";
            public static string TestScenarios = "Test Scenarios";
            public static string About = "About";
        }

        public static class TestMessages
        {

        }

        public static class AlertMessages
        {
            public static string UsernameLengthOutOfRange = "User Id should not be empty / length be between 5 to 12";
            public static string PasswordLenghtOutOfRange = "Password should not be empty / length be between 5 to 12";
            public static string SuccessfulLogin = "Succesful login!";
        }
    }
}
