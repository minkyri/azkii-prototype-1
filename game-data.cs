public static class GameData{

    public static int nowhere = -1;
    public static int invoid = int.MaxValue;

    public static void SetupGame(){

        Game.GetInstance().player = new Player(ConsF.print("What's your name?"), 1);
        Game.GetInstance().locations = new Location[]{

            //N,NE,E,SE,S,SW,W,NW,U,D
            //1,2 ,3,4 ,5,6 ,7,8 ,9,10

            /*Parameters for Location class constructor are:

                Name (string)
                Description (string)
                Travel Table (int array, where each int is the index of the connected location)

            */
            new Location(//0
                
                "Inventory", 
                "", 
                new int[]{nowhere,nowhere,nowhere,nowhere,nowhere,nowhere,nowhere,nowhere,nowhere}
                
            ),
            new Location(//1

                "Kitchen", 
                "You are in the Kitchen!",
                new int[]{2,nowhere,3,nowhere,nowhere,nowhere,nowhere,nowhere,nowhere}
                
            ),
            new Location(//2

                "Living Room", 
                "You are in the Living Room!",
                new int[]{nowhere,nowhere,nowhere,3, 1,nowhere, 1,nowhere,nowhere}
                
            ),
            new Location(//3

                "Bathroom", 
                "You are in the Bathroom!",
                new int[]{nowhere,nowhere,nowhere,nowhere,nowhere,nowhere, 1, 2,nowhere}
                
            ),

        };
        Game.GetInstance().items = new Item[]{

            /*Parameters for Item class constructor are:

                Name (string)
                Description (string)
                Location (int = index of Location array)

            */
            new Item(//0
                
                "Golden Watch", 
                "a shiny golden watch with a large diamond in the centre", 
                1
                
            ),
            new Item(//1
                
                "Sword", 
                "a long and sharp sword with a comfortable handle", 
                2
                
            ),
            new Item(//2
                
                "Hammer", 
                "a rusty old hammer", 
                3
                
            )

        };

    }

}
