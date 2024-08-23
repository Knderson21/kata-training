namespace kata_training.Katas;

public class Kata7
{
    /*
There are pillars near the road. The distance between the pillars is the same and the width of the pillars is the same. Your function accepts three arguments:

number of pillars (≥ 1);
distance between pillars (10 - 30 meters);
width of the pillar (10 - 50 centimeters).
Calculate the distance between the first and the last pillar in centimeters (without the width of the first and last pillar).
    */

    public static int Pillars(int numPill, int dist, int width)
    {
        if (numPill == 1)
        {
            return 0;
        }

        dist *= 100;

        if (numPill == 2)
        {
            return dist;
        }

        return (dist * (numPill - 1)) + (width * (numPill - 2));
    }

    //alt solution 1:

    public static int Pillars1(int numPill, int dist, int width) =>
     numPill > 1 ? (numPill - 1) * dist * 100 + (numPill - 2) * width : 0;

    //alt solution 2:

    public static int Pillars2(int numPill, int dist, int width)
    {
        return Math.Max(0, (100 * dist + width) * --numPill - width);
    }
}