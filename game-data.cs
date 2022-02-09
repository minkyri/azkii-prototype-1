public static class GameData{

    public static int nowhere = -1;
    public static int invoid = int.MaxValue;
    public static string restartMessage = "Would you like to play again?";
    public static string quitMessage = "Thanks for playing";
    public static string openingMessage = "\nWest of House\nYou are standing in an open field west of a white house, " + 
        "with a boarded front door.\nThere is a small mailbox here.";
    public static Action<int[]> openingAction = VerbF.Look;
    public static void SetupGame(){

        Game.GetInstance().isFinished = false;
        Game.GetInstance().player = new Player(GameF.Input("What's your name?"), 1);
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
            #region Directions

                new Item(
                
                    "north", 
                    "", 
                    invoid
                    
                ),
                new Item(
                
                    "northeast", 
                    "", 
                    invoid
                    
                ),
                new Item(
                
                    "east", 
                    "", 
                    invoid
                    
                ),
                new Item(
                
                    "southeast", 
                    "", 
                    invoid
                    
                ),
                new Item(
                
                    "south", 
                    "", 
                    invoid
                    
                ),
                new Item(
                
                    "southwest", 
                    "", 
                    invoid
                    
                ),
                new Item(
                
                    "west", 
                    "", 
                    invoid
                    
                ),
                new Item(
                
                    "northwest", 
                    "", 
                    invoid
                    
                ),
                new Item(
                
                    "up", 
                    "", 
                    invoid
                    
                ),
                new Item(
                
                    "down", 
                    "", 
                    invoid
                    
                ),

            #endregion
            #region Items

                new Item(//10 (zero indexing, after directions)
                
                    "golden watch", 
                    "a shiny golden watch with a large diamond in the centre", 
                    1
                    
                ),
                new Item(//11
                    
                    "sword", 
                    "a long and sharp sword with a comfortable handle", 
                    2
                    
                ),
                new Item(//12
                    
                    "hammer", 
                    "a rusty old hammer", 
                    3
                    
                )

            #endregion

        };

        Parser.SetVerbs(new Verb[]{

            new Verb("go", VerbF.Go)

        });

    }

}
public static class VerbF{

    #region Directions
        public static void Go(int[] objects){}
        public static void Look(int[] objects){}

    #endregion

}
