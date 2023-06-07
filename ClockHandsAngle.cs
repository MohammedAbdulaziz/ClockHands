/// <summary>
/// Calculates the lesser angle between the hour and minute hands of an analog clock.
/// </summary>
class ClockHandsAngle
{
    /// <summary>
    /// Entry point of the program.
    /// </summary>
    static void Main()
    {
        Console.WriteLine("Analog Clock Angle Calculator");

        // Get user input for hours
        Console.WriteLine("Enter the hour (1-12): ");
        int hours = Convert.ToInt32(Console.ReadLine());

        // Get user input for minutes
        Console.WriteLine("Enter the minutes (0-59): ");
        int minutes = Convert.ToInt32(Console.ReadLine());

        // Validate user input
        bool isValidInput = ValidateInput(hours, minutes);
        if (!isValidInput)
        {
            Console.WriteLine("Invalid input! Hours should be between 1-12 and minutes between 0-59.");
            return;
        }

        // Calculate the angle between the hour and minute hands
        double hourAngle = CalculateHourAngle(hours, minutes);
        double minuteAngle = CalculateMinuteAngle(minutes);
        double angle = CalculateClockAngle(hourAngle, minuteAngle);

        // Display the result
        Console.WriteLine($"The lesser angle between the hour and minute hands is: {angle} degrees.");
    }

    /// <summary>
    /// Validates the user input for hours and minutes.
    /// </summary>
    /// <param name="hours">The hour value.</param>
    /// <param name="minutes">The minute value.</param>
    /// <returns>True if the input is valid, otherwise false.</returns>
    static bool ValidateInput(int hours, int minutes)
    {
        bool isValidHours = hours >= 1 && hours <= 12;
        bool isValidMinutes = minutes >= 0 && minutes <= 59;
        return isValidHours && isValidMinutes;
    }

    /// <summary>
    /// Calculates the angle of the hour hand.
    /// </summary>
    /// <param name="hours">The hour value.</param>
    /// <param name="minutes">The minute value.</param>
    /// <returns>The angle of the hour hand.</returns>
    static double CalculateHourAngle(int hours, int minutes)
    {
        // Each hour mark on a clock represents 30 degrees (360 degrees / 12 hours)
        // The hour hand moves slightly based on the minutes as well: 0.5 degrees per minute
        return 30 * hours + 0.5 * minutes;
    }

    /// <summary>
    /// Calculates the angle of the minute hand.
    /// </summary>
    /// <param name="minutes">The minute value.</param>
    /// <returns>The angle of the minute hand.</returns>
    static double CalculateMinuteAngle(int minutes)
    {
        // Each minute mark on a clock represents 6 degrees (360 degrees / 60 minutes)
        return 6 * minutes;
    }

    /// <summary>
    /// Calculates the lesser angle between the hour and minute hands.
    /// </summary>
    /// <param name="hourAngle">The angle of the hour hand.</param>
    /// <param name="minuteAngle">The angle of the minute hand.</param>
    /// <returns>The lesser angle between the hour and minute hands.</returns>
    static double CalculateClockAngle(double hourAngle, double minuteAngle)
    {
        // Get the absolute difference between the two angles
        double angle = Math.Abs(hourAngle - minuteAngle);

        // Get the lesser angle between the two possible angles (clockwise and counterclockwise)
        angle = Math.Min(360 - angle, angle);

        return angle;
    }
}
