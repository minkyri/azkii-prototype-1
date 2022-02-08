public class Game{

        private static Game instance;
        Player player;
        Location[] locations;
        Item[] items;

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
