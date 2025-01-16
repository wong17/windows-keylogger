using Keylogger.Helpers.Enums;

namespace Keylogger.Helpers
{
    internal static class MouseButtonFilterHelper
    {
        public static Dictionary<string, MouseButtonFilter> MouseButtonFilters = new()
        {
            { "All", MouseButtonFilter.All },
            { "Left Button", MouseButtonFilter.LeftButton },
            { "Right Button", MouseButtonFilter.RightButton },
            { "Middle Button", MouseButtonFilter.MiddleButton },
            { "Left and Right Button", MouseButtonFilter.LeftAndRightButton },
            { "Left and Middle Button", MouseButtonFilter.LeftAndMiddleButton },
            { "Right and Middle Button", MouseButtonFilter.RightAndMiddleButton }
        };

        public static bool ShouldDisplayMouseButton(string mouseButton, MouseButtonFilter mouseButtonFilter)
        {
            return mouseButtonFilter switch
            {
                MouseButtonFilter.All => true,
                MouseButtonFilter.LeftButton => mouseButton.Contains("Left Button"),
                MouseButtonFilter.RightButton => mouseButton.Contains("Right Button"),
                MouseButtonFilter.MiddleButton => mouseButton.Contains("Middle Button"),
                MouseButtonFilter.LeftAndRightButton => mouseButton.Contains("Left Button") || mouseButton.Contains("Right Button"),
                MouseButtonFilter.LeftAndMiddleButton => mouseButton.Contains("Left Button") || mouseButton.Contains("Middle Button"),
                MouseButtonFilter.RightAndMiddleButton => mouseButton.Contains("Right Button") || mouseButton.Contains("Middle Button"),
                _ => false
            };
        }
    }
}