/*
    Using Stacks and Queues where appropriate, create a simple 
    command line playlist app that allows a user to add a song to a playlist. 
    Provide commands to play the next song, skip the next song, or add a new 
    song to the playlist. Users should be able to rewind by one song many times 
    to play a previous track. 
*/
using System.Runtime.Serialization.Json;

bool isRunning = true;
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
            Console.Write("Song name: ");
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

    } else if(choice == "3")
    {

    } else if(choice == "4")
    {

    } else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("This command does not exist");
        Console.ResetColor();
        continue;
    }
}
