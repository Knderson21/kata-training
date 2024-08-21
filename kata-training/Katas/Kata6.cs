namespace kata_training.Katas;

public class Kata6
{
    /*
     Our football team has finished the championship.
       
       Our team's match results are recorded in a collection of strings. Each match is represented by a string in the format "x:y", where x is our team's score and y is our opponents score.
       
       For example: ["3:1", "2:2", "0:1", ...]
       
       Points are awarded for each match as follows:
       
       if x > y: 3 points (win)
       if x < y: 0 points (loss)
       if x = y: 1 point (tie)
       We need to write a function that takes this collection and returns the number of points our team (x) got in the championship by the rules given above.
       
       Notes:
       
       our team always plays 10 matches in the championship
       0 <= x <= 4
       0 <= y <= 4
     */
    public static int TotalPoints(string[] games) {
        // insert magic here
        int total = 0;
        for(int i = 0; i < 10; i++)
        {
            int x = Convert.ToInt32(games[i][0]);
            int y = Convert.ToInt32(games[i][2]);
            if(x > y)
            {
                total += 3;
            }
            if(x == y)
            {
                total += 1;
            }
        }
        return total;
    }
    
    //alternate solutions:
    public static int TotalPoints2(string[] games) {
        int total = 0;
        foreach (string game in games) {
            if (game[0] > game[2])
                total += 3;
            else if (game[0] == game[2])
                total += 1;            
        }
        return total;
    }
    
    public static int TotalPoints3(string[] games)
    {
        return games.Sum(s => s[0] < s[2] ? 0 : s[0] == s[2] ? 1 : 3);
    }
}