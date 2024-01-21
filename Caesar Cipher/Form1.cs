using System.Drawing.Text;

namespace Caesar_Cipher
{
    public partial class homePage : Form
    {
        public homePage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Clear(); // clear
            shiftComboBox.SelectedIndex = -1; // clear box
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            string input = inputTextBox.Text; // takes in the text
            int cipherShift = shiftComboBox.SelectedIndex; // takes in the shift
            List<char> listToUse = listCreator(input);
            

        }

        static List<char> listCreator(string input) // ez function
        {
            input = input.ToLower(); // using to lower first just for ease. then will add capitals later.
            List<char> theInput = new List<char>();
            for (int i = 0; i < input.Length; i++)
            {
                theInput.Add(input[i]);
            }
            return theInput;
        }

        static public void shifter(List<char> list1, int shift) // we love procedural programming
        {
            string output; // not used yet
            string alphabetIndex = "abcdefghijklmnopqrstuvwxyz"; // when it loops around. idk how im gonna make this work




        }
    }
}
