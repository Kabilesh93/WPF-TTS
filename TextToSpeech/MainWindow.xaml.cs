using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
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

namespace TextToSpeech
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        string language = "English";
        private void TriggerSpeech_Click(object sender, RoutedEventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();

            if (language.Equals("Tamil"))
            {
                synth.SelectVoice("eSpeak-ta");
            }
            else if (language.Equals("Sinhala"))
            {
                synth.SelectVoice("eSpeak-si");
            }
            else if (language.Equals("Spanish"))
            {
                synth.SelectVoice("eSpeak-es");
            }
            else if (language.Equals("French"))
            {
                synth.SelectVoice("eSpeak-fr");
            }
            else
            {
                synth.SelectVoice("Microsoft Zira Desktop");
            }
            synth.Rate = -2;
            synth.Speak(Input_Text.Text);
        }

        private void SelectLanguage_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (SelectLanguage.SelectedItem.ToString().Split(new string[] { ": " }, StringSplitOptions.None).Last())
            {
                case "English":
                    Input_Text.Text = "Enter Text";
                    language = "English";
                    break;
                case "Tamil":
                    Input_Text.Text = "உரை உள்ளிடவும்";
                    language = "Tamil";
                    break;
                case "Sinhala":
                    Input_Text.Text = "පෙළ ඇතුළත් කරන්න";
                    language = "Sinhala";
                    break;
                case "Spanish":
                    Input_Text.Text = "පෙළ ඇතුළත් කරන්න";
                    language = "Spanish";
                    break;
                case "French":
                    Input_Text.Text = "පෙළ ඇතුළත් කරන්න";
                    language = "French";
                    break;

            }
        }
    }
}
