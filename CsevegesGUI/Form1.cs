
using Cseveges;
using System.Diagnostics;
using System.Text;

namespace CsevegesGUI {
    public partial class Form1 : Form {
        private List<Beszelgetes> calls = new ();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("./csevegesek.txt", Encoding.UTF8);
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                
                calls.Add(new Beszelgetes(sr.ReadLine()));
            }
            sr.Close();
            List<string> callers = new();
            List<string> calleds = new();


            foreach (var call in calls)
            {
                if (!callers.Contains(call.callerName)) { 
                    callers.Add(call.callerName);
                }
                if (!calleds.Contains(call.calledName))
                {
                    calleds.Add(call.calledName);
                }
            }
            callers.Sort();
            calleds.Sort();

            foreach (var caller in callers)
            {
                callerBox.Items.Add(caller);
            }
            callerBox.SelectedItem = callers[0];
            foreach (var called in calleds)
            {
                calledBox.Items.Add(called);
            }
            calledBox.SelectedItem = callers[calleds.Count-1];
        }

        private List<string> checkCalls(string caller, string called)
        {
            List<string> callList = new();
            foreach (var call in calls)
            {
                if (call.callerName.Equals(caller) && call.calledName.Equals(called))
                {
                    callList.Add($"{call.begin} --> {call.end}");
                }
            }
            return callList;
        }

        private void callerBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxChanged();
        }

        private void calledBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxChanged();
        }

        private void comboBoxChanged()
        {
            if (calledBox.Text == null || calledBox.Text == null) return;
            list.Items.Clear();
            if (checkCalls(callerBox.Text, calledBox.Text).Count == 0)
            {
                list.Items.Add("Nem történt beszélgetés.");
                return;
            }
            int index = 1;
            foreach (var callElement in checkCalls(callerBox.Text, calledBox.Text))
            {
                list.Items.Add($"{index++}. {callElement}");
            }
        }
    }
}