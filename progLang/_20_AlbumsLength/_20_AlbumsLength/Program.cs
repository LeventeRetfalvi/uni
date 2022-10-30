using System;

namespace _20_AlbumsLength
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int trackCount;
            do
            {
                Console.Write("Enter the number of songs: ");
            } while (!int.TryParse(Console.ReadLine(), out trackCount) || trackCount < 1 || 100 < trackCount);

            int albumsLength = 0;
            int maxTrackIndex = 0;
            int maxTrackLength = 0;
            int minTrackLength = Int32.MaxValue;
            int minTrackIndex = 0;
            for (int i = 1; i <= trackCount; i++)
            {
                Console.WriteLine("Enter the #{0} song's length!", i);
                int trackMinutes;
                do
                {
                    Console.Write("minutes = ");
                } while (!int.TryParse(Console.ReadLine(), out trackMinutes) || trackMinutes < 0);

                int trackSeconds;
                do
                {
                    Console.Write("seconds = ");
                } while (!int.TryParse(Console.ReadLine(), out trackSeconds) || trackSeconds < 0 || 59 < trackSeconds);

                int trackLength = trackMinutes * 60 + trackSeconds;
                if (trackLength > maxTrackLength)
                {
                    maxTrackLength = trackLength;
                    maxTrackIndex = i;
                }

                if (trackLength < minTrackLength)
                {
                    minTrackLength = trackLength;
                    minTrackIndex = i;
                }

                albumsLength += trackLength;
            }

            int hour = albumsLength / 3600;
            int minutes = albumsLength % 3600 / 60;
            int seconds = albumsLength % 3600 % 60;

            Console.WriteLine("The length of the album is {0}:{1:00}:{2:00}", hour, minutes, seconds);

            int maxHours = maxTrackLength / 3600;
            int maxMinutes = maxTrackLength % 3600 / 60;
            int maxSeconds = maxTrackLength % 3600 % 60;
            Console.WriteLine("The longest song on the album is the #{3}, length of the song is {0}:{1:00}:{2:00}",
                maxHours, maxMinutes, maxSeconds, maxTrackIndex);

            int minHours = minTrackLength / 3600;
            int minMinutes = minTrackLength % 3600 / 60;
            int minSeconds = minTrackLength % 3600 % 60;
            Console.WriteLine("The shortest song on the album is the #{3}, length of the song is {0}:{1:00}:{2:00}",
                minHours, minMinutes, minSeconds, minTrackIndex);

            Console.ReadLine();
        }
    }
}