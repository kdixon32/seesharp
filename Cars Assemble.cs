using System;

static class AssemblyLine
{
    public const int defaultProduction = 221;
    public static double SuccessRate(int speed)
    {
        if ( speed == 0 )
        {
            return 0.0;
        }
        else if ( speed > 0 && speed < 5 )
        {
            return 1.0;
        }
        else if ( speed > 4 && speed < 9 )
        {
            return 0.90;
        }
        else if ( speed == 9)
        {
            return 0.80;
        }
        else
        {
            return 0.77;
        }
    }
    
    public static double ProductionRatePerHour(int speed)  => speed * defaultProduction * SuccessRate(speed);

    public static int WorkingItemsPerMinute(int speed) => (int)(speed * defaultProduction * SuccessRate(speed)) / 60;
}