using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GUI_EA_Summer2021
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    /* DEMO
     *  1. Create classes (Player, Location, etc.)
     *  2. Add functionality so that the player can enter their name
     *       - when button is pressed ...
     *       - the name is saved to the Player instance
     *       - the canvas is hidden
     *       - the player information box is updated
     *  3. Create instances for the locations
     *        - each location should have a name, description, etc
     *        - random NPC
     *  4. Let player choose a location by typing a name (this is important for later!)
     *        - if there is a match then swap the big image to the location
     *        - load in the location's information in the location textbox
     *        
     *  Assignment      
     *  1. Create locations randomly (4)
     *  2. Instead of a visual map, replace the graphic with another textbox with the names of the locations
     *  3. Each location should give the player a souvenir
     *         - an instance of a new class (Item) added to the Player's inventory
     *         - only one souvenir per location (if player returns, no second one given)
     *         - once the player has collected all 4 souvenirs (one for each place) update player information
     *  
     *  Advanced
     *  1. Can you allow the player to interact with the random NPC? 
     *        - The player uses same text entry box to type in a location ("one text box to rule them all")
     *             -- Instead of hiding the canvas with the player name input box, it can be repurposed
     *        - Instead of automatically being given a souvenir, instead have the player "buy" one from the NPC
     *             -- Player should have currency amount
     *             -- NPC has an inventory with several items - only one is special as the souvenir
     *             
     *             
     *  NOTE
     *  You can have visuals "spawn" programatically that the player can click on and use as navigation
     *  However we are having the player type in a location with text as that is an easier solution for now
     *  
     */

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
