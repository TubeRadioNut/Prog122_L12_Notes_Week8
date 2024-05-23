using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prog122_L12_Notes_Week8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Character> characterNames = new List<Character>();
        public MainWindow()
        {
            InitializeComponent();//<--Don't delete this
            //We've changed out List<Sting> to List<Character> and populated it with 3 new characters
            //we have only added out player names so far
            characterNames.Add(new Character("Will","McDurken", 14, 9));
            characterNames.Add(new Character("Rafael", "Ragavan Quicksmith", 18, 16));
            characterNames.Add(new Character("Charles", "Conan", 10, 17));
            lvCharters.ItemsSource = characterNames;

        }//end of the MainWindow()

        private void btnDisplayInfo_Click(object sender, RoutedEventArgs e)
        {
            int selectedIndex = lvCharters.SelectedIndex;

            if(lvCharters.SelectedIndex != -1)
            {
                //Character selectedCharacter = (Character)lvCharters.SelectedItem;//Casting using()
                //Casting using 'as'
                Character selectedCharacter = lvCharters.SelectedItem as Character;

                MessageBox.Show(selectedCharacter.PlayerName);
            }
            else
            {
                MessageBox.Show("Select a row from the list view");
            }

            
        }
    }//End of class
}//End of namespace