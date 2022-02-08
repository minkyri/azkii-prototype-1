class GameObj{

    public string name;
    public int location;

}
class Location : GameObj{

    public string description;
    public int[] travelTable = new int[10];

}
class Item : GameObj{

    public string description;

}
class Player : GameObj{



}
class Verb{

    public string word;
    public Func<Game, int[]> function;

    public Verb(string setWord, Func<Game, int[]> setFunction){

        word = setWord;
        function = setFunction;

    }

}