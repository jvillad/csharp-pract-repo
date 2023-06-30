using BrewMachina.PractInventoryManagement;



WelcomeMessage();

Utilities.InitializeStock();
Utilities.ShowMainMenu();
Console.WriteLine("Application shutting down...");
Console.ReadLine();
#region Intro
static void WelcomeMessage()
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine
    (@"
____    __    ____  _______  __        ______   ______   .___  ___.  _______ 
\   \  /  \  /   / |   ____||  |      /      | /  __  \  |   \/   | |   ____|
 \   \/    \/   /  |  |__   |  |     |  ,----'|  |  |  | |  \  /  | |  |__   
  \            /   |   __|  |  |     |  |     |  |  |  | |  |\/|  | |   __|  
   \    /\    /    |  |____ |  `----.|  `----.|  `--'  | |  |  |  | |  |____ 
    \__/  \__/     |_______||_______| \______| \______/  |__|  |__| |_______|
                                                                             
.___________.  ______      .______   .______       ___________    __    ____ 
|           | /  __  \     |   _  \  |   _  \     |   ____\   \  /  \  /   / 
`---|  |----`|  |  |  |    |  |_)  | |  |_)  |    |  |__   \   \/    \/   /  
    |  |     |  |  |  |    |   _  <  |      /     |   __|   \            /   
    |  |     |  `--'  |    |  |_)  | |  |\  \----.|  |____   \    /\    /    
    |__|      \______/     |______/  | _| `._____||_______|   \__/  \__/     
                                                                             
.___  ___.      ___       ______  __    __   __  .__   __.      ___      
|   \/   |     /   \     /      ||  |  |  | |  | |  \ |  |     /   \     
|  \  /  |    /  ^  \   |  ,----'|  |__|  | |  | |   \|  |    /  ^  \    
|  |\/|  |   /  /_\  \  |  |     |   __   | |  | |  . `  |   /  /_\  \   
|  |  |  |  /  _____  \ |  `----.|  |  |  | |  | |  |\   |  /  _____  \  
|__|  |__| /__/     \__\ \______||__|  |__| |__| |__| \__| /__/     \__\ 
                                                                         ");
    Console.ResetColor();
    Console.WriteLine("Press enter key to start logging in:");

    Console.ReadLine();
    Console.Clear();
}
#endregion
