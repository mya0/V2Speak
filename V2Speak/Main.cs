using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;
using System.Windows.Forms;

namespace V2Speak {
    public partial class Main : Form {
        private readonly string[] voiceroid2Titles = new string[] { "VOICEROID2", "VOICEROID2*" };

        private ValuePattern v2Text;
        private InvokePattern v2PlayButton;
        public Main() {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e) {
            AutomationElementCollection elements = AutomationElement.RootElement.FindAll(TreeScope.Children, Condition.TrueCondition);
            AutomationElement v2element = null ;
            foreach (AutomationElement element in elements) {
                if(voiceroid2Titles.Contains(element.Current.Name)) {
                    v2element = element;
                    break;
                }
            }
            if(v2element == null) {
                MessageBox.Show("VOICEROID2が起動していません");
                Application.Exit();
            }
            v2Text = v2element.FindAll(TreeScope.Descendants, new PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.Edit))[0].GetCurrentPattern(ValuePattern.Pattern) as ValuePattern;
            AutomationElementCollection v2Elements = v2element.FindAll(TreeScope.Descendants, new PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.Button));
            foreach(AutomationElement element in v2Elements) {
                AutomationElement playtext = element.FindFirst(TreeScope.Descendants, new PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.Text));
                if(playtext != null && playtext.Current.Name == "再生") {
                    v2PlayButton = element.GetCurrentPattern(InvokePattern.Pattern) as InvokePattern;
                    break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            v2Text.SetValue(speakContent.Text);
            v2PlayButton.Invoke();
            Activate();
        }
    }
}
