using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satan
{
    public partial class Form1 : Form
    {
        private List<Tuple<string, string>> concepts = new List<Tuple<string,string>>();
        private Panel _activePanel;
        private Panel _activeReviewPanel;
        private Tuple<int, string, string> _activeConceptTuple;

        private void ChangeActivePanel(Panel panel, Control controlToFocus = null)
        {
            _activePanel.Visible = false;
            _activePanel = panel;
            _activePanel.Visible = true;
            controlToFocus?.Focus();
        }

        private void ChangeActiveReviewPanel(Panel panel, Control controlToFocus = null)
        {
            _activeReviewPanel.Visible = false;
            _activeReviewPanel = panel;
            _activeReviewPanel.Visible = true;
            controlToFocus?.Focus();
        }

        private void ShowNextReview()
        {
            if(_activePanel!=panelReview) ChangeActivePanel(panelReview, buttonGrade);
            SQLiteConnection connection = new SQLiteConnection(@"Data Source = C:\Users\rafka_000\Documents\Databases\supernova.sqlite; VERSION = 3");
            connection.Open();
            SQLiteCommand command = new SQLiteCommand($"SELECT rowid, concept, summary FROM concepts WHERE (due<= '{DateTime.Now.ToString("yyyy-MM-dd HH:mm")}')", connection);
            SQLiteDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                _activeConceptTuple = new Tuple<int, string, string>(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                conceptLabel.Text = _activeConceptTuple.Item2;
                summaryLabel.Text = "Click 'Grade' to Review";
            }
            else
            {
                MessageBox.Show("It's over!");
                ChangeActivePanel(panelMenu, buttonMenuAdd);
                _activeConceptTuple = null;
            }
            connection.Close();
            ChangeActiveReviewPanel(panelStartReview);
            buttonGrade.Focus();
        }

        private static void Upload(List<Tuple<string, string>> list)
        {
            SQLiteConnection connection = new SQLiteConnection(@"Data Source = C:\Users\rafka_000\Documents\Databases\supernova.sqlite; VERSION = 3");
            SQLiteCommand command;
            connection.Open();
            foreach (Tuple<string,string> concept in list)
            {
                command = new SQLiteCommand($"INSERT INTO concepts (concept, summary, created, due) VALUES('{concept.Item1}', '{concept.Item2}', '{DateTime.Now.ToString("yyyy-MM-dd HH:mm")}', '{DateTime.Now.ToString("yyyy-MM-dd HH:mm")}')", connection);
                command.ExecuteNonQuery();
            }

            connection.Close();
        }

        private void ChangeDue(int conceptId, int interval)
        {
            SQLiteConnection connection = new SQLiteConnection(@"Data Source = C:\Users\rafka_000\Documents\Databases\supernova.sqlite; VERSION = 3");
            
            connection.Open();
            SQLiteCommand command = new SQLiteCommand($"UPDATE concepts SET due = '{DateTime.Now.AddDays(interval).ToString("yyyy-MM-dd HH:mm")}', lastTime = '{DateTime.Now.ToString("yyyy-MM-dd HH:mm")}'  WHERE (rowid == '{conceptId}')",connection);

            command.ExecuteNonQuery();
            connection.Close();
            ShowNextReview();
        }

        public Form1()
        {
            InitializeComponent(); //s
        }        

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!System.IO.Directory.Exists(@"C:\Users\rafka_000\Documents\Databases\supernova Back-up"))
            {
                System.IO.Directory.CreateDirectory(@"C:\Users\rafka_000\Documents\Databases\supernova Back-up");
            }
            System.IO.File.Copy(@"C:\Users\rafka_000\Documents\Databases\supernova.sqlite", @"C:\Users\rafka_000\Documents\Databases\supernova Back-up\supernova" + $"{DateTime.Now.ToString("yyyy-MM-dd_Hmmm")}"+ @".sqlite");
            _activePanel = panelMenu;
            _activePanel.Visible = true;
            _activeReviewPanel = panelStartReview;
            _activeReviewPanel.Visible = true;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(txtConcept.TextLength!=0)
                concepts.Add(Tuple.Create(txtConcept.Text, txtSummary.Text));            
            Upload(concepts);
            txtConcept.Focus();

            concepts.Clear();
            txtConcept.Clear();
            txtSummary.Clear();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.R))
            {
                ShowNextReview();
                return true;
            }
            if (keyData == (Keys.Control | Keys.A))
            {
                ChangeActivePanel(panelAdd, txtConcept);
                return true;
            }
            if (keyData == (Keys.Control | Keys.M))
            {
                ChangeActivePanel(panelMenu, buttonMenuAdd);
                return true;
            }
            if (keyData == Keys.D1 && _activePanel== panelReview && !manualTextBox.Focused)
            {
                firstButton.PerformClick();
                return true;
            }
            if (keyData == Keys.D2 && _activePanel == panelReview && !manualTextBox.Focused)
            {
                secondButton.PerformClick();
                return true;
            }
            if (keyData == Keys.D3 && _activePanel == panelReview && !manualTextBox.Focused)
            {
                thirdButton.PerformClick();
                return true;
            }
            if (keyData == Keys.D4 && _activePanel == panelReview && !manualTextBox.Focused)
            {
                fourthButton.PerformClick();
                return true;
            }
            
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonMenuReview.PerformClick();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void buttonMenuAdd_Click(object sender, EventArgs e)
        {
            ChangeActivePanel(panelAdd, txtConcept);
        }

        private void buttonMenuReview_Click(object sender, EventArgs e)
        {

            ChangeActiveReviewPanel(panelStartReview);
            if(_activePanel!=panelReview) ChangeActivePanel(panelReview);
            ShowNextReview();
        }

        private void firstButton_Click(object sender, EventArgs e)
        {
            buttonMenuReview.PerformClick();
            ChangeDue(_activeConceptTuple.Item1, 1);
        }

        private void secondButton_Click(object sender, EventArgs e)
        {
            buttonMenuReview.PerformClick();
            ChangeDue(_activeConceptTuple.Item1, 2);
        }

        private void thirdButton_Click(object sender, EventArgs e)
        {
            buttonMenuReview.PerformClick();
            ChangeDue(_activeConceptTuple.Item1, 3);
        }

        private void fourthButton_Click(object sender, EventArgs e)
        {
            buttonMenuReview.PerformClick();
            ChangeDue(_activeConceptTuple.Item1, 4);
        }

        private void buttonManual_Click(object sender, EventArgs e)
        {
            int newInterval;
            if(int.TryParse(manualTextBox.Text, out newInterval)) ChangeDue(_activeConceptTuple.Item1, newInterval);
            manualTextBox.Clear();
        }

        private void buttonGrade_Click(object sender, EventArgs e)
        {
            ChangeActiveReviewPanel(panelGradeReview, firstButton);
            summaryLabel.Text = _activeConceptTuple.Item3;
        }
    }
}   