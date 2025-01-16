using Keylogger.Helpers.Enums;

namespace Keylogger.Helpers
{
    internal static class MouseButtonFilterHelper
    {
        public static Dictionary<string, MouseButtonFilter> MouseButtonFilters = new()
        {
            { "All", MouseButtonFilter.All },
            { "Mouse Wheel", MouseButtonFilter.MouseWheel },
            { "Left Button", MouseButtonFilter.LeftButton },
            { "Right Button", MouseButtonFilter.RightButton },
            { "Middle Button", MouseButtonFilter.MiddleButton },
            { "Left and Right Button", MouseButtonFilter.LeftButtonAndRightButton },
            { "Left and Middle Button", MouseButtonFilter.LeftButtonAndMiddleButton },
            { "Right and Middle Button", MouseButtonFilter.RightButtonAndMiddleButton }
        };

        public static bool ShouldDisplayMouseButton(string mouseButton, MouseButtonFilter mouseButtonFilter)
        {
            return mouseButtonFilter switch
            {
                MouseButtonFilter.All => true,
                MouseButtonFilter.MouseWheel => mouseButton.Equals("[Wheel Forward]") || mouseButton.Equals("[Wheel Backward]"),
                MouseButtonFilter.LeftButton => mouseButton.Contains("Left Button"),
                MouseButtonFilter.RightButton => mouseButton.Contains("Right Button"),
                MouseButtonFilter.MiddleButton => mouseButton.Contains("Middle Button"),
                MouseButtonFilter.LeftButtonAndRightButton => mouseButton.Contains("Left Button") || mouseButton.Contains("Right Button"),
                MouseButtonFilter.LeftButtonAndMiddleButton => mouseButton.Contains("Left Button") || mouseButton.Contains("Middle Button"),
                MouseButtonFilter.RightButtonAndMiddleButton => mouseButton.Contains("Right Button") || mouseButton.Contains("Middle Button"),
                _ => false
            };
        }
    }
}