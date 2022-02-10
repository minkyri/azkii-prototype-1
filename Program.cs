// GameData.SetupGame();
// GameF.print(GameF.FindItemIndex(GameF.print("Enter name of existing item")).ToString());

PlayGame();

void PlayGame(){

    GameData.SetupGame();
    if(GameData.openingMessage != "")GameF.print(GameData.openingMessage);
    GameData.openingAction(new int[]{});

    do{

        Parser.Parse(GameF.Input(""));

    }while(!Game.GetInstance().isFinished);

    RestartGame();

}
void RestartGame(){

    switch(GameF.Input(GameData.restartMessage)){

        case "yes":

            PlayGame();
            break;

        case "y":

            PlayGame();
            break;

        case "yep":

            PlayGame();
            break;

        case "ye":

            PlayGame();
            break;

        case "yeah":

            PlayGame();
            break;

        default:

            GameF.print(GameData.quitMessage);
            break;
    
    }

}