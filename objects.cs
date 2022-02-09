public class Game{

        private static Game instance;
        public Player player;
        public Location[] locations;
        public Item[] items;

    private Game(){



    }
    public static Game GetInstance()
    {
        if (instance == null)
        {
            instance = new Game();
        }
        return instance;
    }

}
public class GameObj{

    public string name;

}
public class Location : GameObj{

    public string description;
    public int[] travelTable = new int[10];

    public Location(string setName, string setDescription, int[] setTravelTable){

        name = setName;
        description = setDescription;
        travelTable = setTravelTable;

    }

}
public class Item : GameObj{

    public string description;
    public int location;

    public Item(string setName, string setDescription,int setLocation){

        name = setName;
        location = setLocation;
        description = setDescription;

    }

}
public class Player : GameObj{

    public int location;

    public Player(string setName, int setLocation){

        name = setName;
        location = setLocation;

    }

}
public class Verb{

    public string word;
    public Action<int[]> function;

    public Verb(string setWord, Action<int[]> setFunction){

        word = setWord;
        function = setFunction;

    }

}