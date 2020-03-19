using System;
using System.Collections.Generic;
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
using ManualDataBinding.Data;

namespace ManualDataBinding.UI
{
    /// <summary>
    /// Interaction logic for NoteEditor.xaml
    /// </summary>
    public partial class NoteEditor : UserControl
    {
        private Note note;
        /// <summary>
        /// The Note that will be edited by this control
        /// </summary>
        public Note Note
        {
            get { return note; }
            set
            {
                if (note != null) note.NoteChanged -= OnNoteChange;
                note = value;
                if (note != null)
                { 
                    note.NoteChanged += OnNoteChange;
                    OnNoteChange(note, new EventArgs());
                }
            }
        }

        public NoteEditor()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This function checks if the text within the note is changed it will grab from the Title and Body properties and set the text to user input
        /// </summary>
        /// <param name="sender">Text inputted by user</param>
        /// <param name="e">the event args</param>
        public void OnNoteChange(object sender, EventArgs e)
        {
            if (Note == null) return;
            Title.Text = Note.Title;
            Body.Text = Note.Body;
        }

        /// <summary>
        /// Needed for two way data binding this will set the title property of the Note to the text property of the label.
        /// </summary>
        /// <param name="sender">the button clicked</param>
        /// <param name="e">the event args for text changing</param>
        public void OnTitleChanged(object sender, TextChangedEventArgs e)
        {
            Note.Title = Title.Text;
        }

        /// <summary>
        /// Needed for two way data binding this will set the body property of the Note to the text property of the textbox.
        /// </summary>
        /// <param name="sender">text inserted</param>
        /// <param name="e">the event args for text changing</param>
        public void OnBodyChanged(object sender, TextChangedEventArgs e)
        {
            Note.Body = Body.Text;
        }
    }
}
