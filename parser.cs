public static class Parser{

    private static Verb[] verbs;
    public static void SetVerbs(Verb[] setVerbs){verbs = setVerbs;}
    public static Verb[] GetVerbs(){return verbs;}
    public static void Parse(string playerInput){

        string[] tempSplitInput = playerInput.Split(" ");
        List<string> splitInput = new List<string>{};
        List<int> objects = new List<int>{};

        foreach(string s in tempSplitInput){

            if(!(s == ""))splitInput.Add(s);

        }
        
        int verbIndex = GameF.FindVerbIndex(splitInput[0]);

        if(verbIndex < 0){

            GameF.print("I don't know the verb \"" + splitInput[0] + "\".");
            return;

        }

        splitInput.RemoveAt(0);
        for(int i = 0; i < splitInput.Count; i++){

            int itemIndex = GameF.FindItemIndex(splitInput[i].ToLower());
            if(itemIndex == -1){

                GameF.print("I don't know the word \"" + splitInput[i] + "\".");
                return;

            }
            objects.Add(itemIndex);

        }

        verbs[verbIndex].function(objects.ToArray());

    }

}