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
using ManualDataBinding.Data;

namespace ManualDataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Create the note to add to our editor
        Note note = new Note();

        public MainWindow()
        {
            InitializeComponent();
            Editor.Note = note;
        }

        /// <summary>
        /// Event handler to create a new note and apply it to the editor
        /// </summary>
        /// <param name="sender">the button clicked</param>
        /// <param name="e">the event args</param>
        public void OnNewNote(object sender, RoutedEventArgs e)
        {
            note = new Note();
            Editor.Note = note;
        }

        /// <summary>
        /// Event handler to clear the context of the note
        /// </summary>
        /// <param name="sender">the button clicked</param>
        /// <param name="e">the event args</param>
        public void OnClearNote(object sender, RoutedEventArgs e)
        {
            note.Body = "";
        }

        /// <summary>
        /// Event handler to mutate the current note
        /// </summary>
        /// <param name="sender">the button clicked</param>
        /// <param name="e">the event args</param>
        public void OnMutateNote(object sender, RoutedEventArgs e)
        {
            note.Title = "Master Splinter";
            note.Body = "There is no monster more dangerous than a lack of compassion";
        }
    }
}
