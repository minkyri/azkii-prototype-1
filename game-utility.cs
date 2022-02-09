public static class GameF{

    public static void print(string display){

        Console.WriteLine(display);

    }
    public static string Input(string display){

        print(display);
        Console.Write("\n> ");
        return Console.ReadLine();

    }
    public static int FindItemIndex(string name){

        Item[] items = Game.GetInstance().items;
        int idx = -1;

        for(int i = 0; i < items.Length && idx < 0; i++){

            if(items[i].name == name){

                idx = i;

            }

        }

        return idx;

    }
    public static int FindVerbIndex(string word){

        Verb[] verbs = Parser.GetVerbs();
        int idx = -1;

        for(int i = 0; i < verbs.Length && idx < 0; i++){

            if(verbs[i].word == word){

                idx = i;

            }

        }

        return idx;

    }

}