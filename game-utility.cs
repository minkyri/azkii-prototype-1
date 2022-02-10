public static class GameF{

    public static void print(string display){

        Console.WriteLine(display);

    }
    public static string Input(string display){

        print(display);
        Console.Write("> ");
        return Console.ReadLine();

    }
    public static int FindItemIndex(string name){

        Item[] items = Game.GetInstance().items;

        for(int i = 0; i < items.Length; i++){

            if(items[i].name == name){

                return i;

            }

        }

        return -1;

    }
    public static int FindVerbIndex(string word){

        Verb[] verbs = Parser.GetVerbs();

        for(int i = 0; i < verbs.Length; i++){

            if(verbs[i].word == word){

                return i;

            }

        }

        return -1;

    }
    public static bool IsConnectingLocation(int locationIndex){

        int[] connectingLocations = Game.GetInstance().locations[Game.GetInstance().player.location].travelTable;
        for(int i = 0; i < connectingLocations.Length; i++){

            if(connectingLocations[i] == locationIndex){

                return true;

            }

        }

        return false;

    }
    public static bool IsItemWithPlayer(int itemIndex){

        if(Game.GetInstance().items[itemIndex].location == Game.GetInstance().player.location){

            return true;

        }
        
        return false;

    }
    /*public static bool IsDirectionIndex(int itemIndex, int[] ){

        string[] possibleDirections = new string[]{

            "north",
            "northeast",
            "east",
            "southeast",
            "south",
            "southwest",
            "west",
            "northwest",
            "up",
            "down",

        };
        for(int i = 0; i < Game.GetInstance().items.Length; i++){

            foreach(string dir in possibleDirections){

                if(Game.GetInstance().items[i].name == dir){

                    return true;

                }

            }

        }

        return false;

    }*/

}