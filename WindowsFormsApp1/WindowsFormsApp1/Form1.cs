using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region UI events

        private void cmdDeserialise_Click(object sender, EventArgs e)
        {
            //debugOutput(txtInput.Text);
            deserialiseJSON(txtInput.Text);
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            txtDebugOutput.Text = string.Empty;
        }

        #endregion

        #region json functions

        private void deserialiseJSON(string strJSON)
        {
            try
            {
                var jPersonComplex = JsonConvert.DeserializeObject<jsonPersonComplex>(strJSON);
                debugOutput("Here's our JSON object: " + jPersonComplex.ToString());
                debugOutput("Here's the First Name: " + jPersonComplex.firstname);
                debugOutput("Here's the street adress: " + jPersonComplex.adress.postcode);
                debugOutput("Here's the street adress: " + jPersonComplex.adress.street);


                //var jPerson = JsonConvert.DeserializeObject<dynamic>(strJSON);
                //debugOutput("Here's our JSON object: " + jPerson.ToString());
                //debugOutput("Here's the First Name: " + jPerson.firstname);
                //debugOutput("Here's the street adress: " + jPerson.adress.street);
            }
            catch (Exception ex)
            {
                debugOutput("We had a problem: " + ex.Message.ToString());
            }
        }

        #endregion


        #region Debug Output

        private void debugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                txtDebugOutput.Text = txtDebugOutput.Text + strDebugText + Environment.NewLine;
                txtDebugOutput.SelectionStart = txtDebugOutput.TextLength;
                txtDebugOutput.ScrollToCaret();
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message.ToString() + Environment.NewLine);
            }
        }

        #endregion
    }
}
