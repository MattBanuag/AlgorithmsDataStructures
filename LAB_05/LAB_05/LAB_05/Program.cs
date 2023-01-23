/*
    I believe the time complexity for this program is O(n).
    Instead of using a 'Foreach' to display the items in the queue, I used
    'String.Join'.
*/
using System.Linq;

bool isRunning = true;
string songChoice = "";
Queue<string> Playlist = new Queue<string>();

while (isRunning)
{
    Console.WriteLine("~ MUSIC PLAYER");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("\n1 - Add New Song");
    Console.WriteLine("2 - Play Song");
    Console.WriteLine("3 - Skip Next Song");
    Console.WriteLine("4 - Exit Program\n");
    Console.ResetColor();
    string choice = Console.ReadLine();

    // === USER CHOICES ===
    if(choice == "1")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("~ ADD SONG");
        Console.WriteLine("~ Press 'MAIN' to go back to main menu");
        Console.ResetColor();
        bool isAdding = true;

        while (isAdding)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("~ Song name: ");
            Console.ResetColor();
            string songName = Console.ReadLine().ToUpper();

            // String Validation
            if (songName.Length > 2)
            {
                if (songName == "MAIN")
                {
                    Console.Clear();
                    isAdding = false;
                }
                else if (!Playlist.Contains(songName))
                {
                    Playlist.Enqueue(songName);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"~ {songName} has been addded successfully.");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("~ ERROR: This song already exists in your playlist");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("~ ERROR: Song name has to be at least 3 characters");
                Console.ResetColor();
            }
        }
        
    } else if(choice == "2")
    {
        bool isPlaying = true;
        if (Playlist.Count == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("~ ERROR: There are no songs in your playlist\n");
            Console.ResetColor();
        } else
        {
            // Display Songs
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"~ {Playlist.Count} songs in playlist: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"~ [{String.Join(", ", Playlist)}]");
            while (isPlaying)
            {
                Console.Write("~ PLAY: ");
                Console.ResetColor();
                songChoice = Console.ReadLine().ToUpper();

                if(Playlist.Contains(songChoice))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"~ Now Playing, {songChoice}\n");
                    Console.ResetColor();
                    isPlaying = false;
                } else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("~ ERROR: This song is not in your playlist\n");
                    Console.ResetColor();
                }
            }
        }   
    } else if(choice == "3")
    {
        if(Playlist.Count == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("~ ERROR: No song is currently playing");
            Console.WriteLine("~ ERROR: Please play a song first");
            Console.ResetColor();
        } else
        {
            // Error in the syntax but this was my unifinished solution 
            // for LAB 5
            /*string position = Playlist.Count(songChoice);
            Console.WriteLine(Playlist.Skip());*/
        }
    } else if(choice == "4")
    {
        break;
    } else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("~ ERROR: This command does not exist");
        Console.ResetColor();
        continue;
    }
}
