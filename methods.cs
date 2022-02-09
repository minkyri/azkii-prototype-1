public static class VerbF{

    #region Directions
        public static void Go(int[] objects){}
        public static void GoNorth(int[] objects){}
        public static void GoNorthEast(int[] objects){}
        public static void GoEast(int[] objects){}
        public static void GoSouthEast(int[] objects){}
        public static void GoSouth(int[] objects){}
        public static void GoSouthWest(int[] objects){}
        public static void GoWest(int[] objects){}
        public static void GoNorthWest(int[] objects){}
        public static void GoUp(int[] objects){}
        public static void GoDown(int[] objects){}
        public static void Look(int[] objects){

        }

    #endregion

}
public static class ConsF{

    public static string print(string display){

        Console.WriteLine(display);
        Console.Write("\n> ");
        return Console.ReadLine();

    }

}