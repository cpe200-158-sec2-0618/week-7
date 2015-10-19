using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace twozerofoureight
{
    public partial class TwoZeroFourEightScoreView : Form, View
    {
        public TwoZeroFourEightScoreView()
        {
            InitializeComponent();
        }

        private void TwoZeroFourEightScoreView_Load(object sender, EventArgs e)
        {

        }

        private void lblscore2_Click(object sender, EventArgs e)
        {

        }

        public void Notify(Model m) 
        {
            UpdateScoreView(((TwoZeroFourEightModel)m).GetScore()); 
        }

        public void UpdateScoreView(int score) 
        {
            lblscore2.Text = "Score : " + score; 
        }

    }
}
