public static class Parser{

    private static Verb[] verbs;
    public static void SetVerbs(Verb[] setVerbs){verbs = setVerbs;}
    public static Verb[] GetVerbs(){return verbs;}
    public static void Parse(string playerInput){

        #region Split Input

            string[] tempSplitInput = playerInput.Split(" ");
            List<string> splitInput = new List<string>{};

            foreach(string s in tempSplitInput){

                if(!(s == ""))splitInput.Add(s);

            }

        #endregion
        
        int verbIndex = GameF.FindVerbIndex(splitInput[0]);

        if(verbIndex < 0){

            GameF.print("I don't know the verb \"" + verbs[verbIndex] + "\".");
            return;

        }

    }

}