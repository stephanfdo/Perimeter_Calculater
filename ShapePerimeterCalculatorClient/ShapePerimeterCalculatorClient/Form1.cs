using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ShapePerimeterCalculatorClient
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            hideParameters();

            //dropdown list of shapes
            comboBoxShapes.Items.Add("Circle");
            comboBoxShapes.Items.Add("Rectangle");
            comboBoxShapes.Items.Add("Triangle");
            //comboBoxShapes.DataSource = client
        }

        public void hideParameters()
        {
            //adjust parameter visibilities according to shape type
            textBoxParam1.Visible = false;
            textBoxParam2.Visible = false;
            textBoxParam3.Visible = false;
            textBoxParam1.Text = "0";
            textBoxParam2.Text = "0";
            textBoxParam3.Text = "0";
            paramLabel1.Visible = false;
            paramLabel2.Visible = false;
            paramLabel3.Visible = false;
        }

        //clearing method
        public void reset()
        {
            comboBoxShapes.Text = null;
            textBoxParam1.Clear();
            textBoxParam2.Clear();
            textBoxParam3.Clear();
            resultLabel.Text = "Result";
        }

        private void comboBoxShapes_SelectedIndexChanged(object sender, EventArgs e)
        {
            hideParameters();

            switch (this.comboBoxShapes.Text)
            {
                case "Circle":
                    textBoxParam1.Visible = true;
                    paramLabel1.Visible = true;
                    paramLabel1.Text = "Radius";

                    break;
                case "Rectangle":
                    textBoxParam1.Visible = true;
                    textBoxParam2.Visible = true;
                    paramLabel1.Visible = true;
                    paramLabel2.Visible = true;
                    paramLabel1.Text = "Length";
                    paramLabel2.Text = "Width";
                    break;
                case "Square":
                    textBoxParam1.Visible = true;
                    paramLabel1.Visible = true;
                    paramLabel1.Text = "Length";
                    break;
                case "Triangle":
                    textBoxParam1.Visible = true;
                    textBoxParam2.Visible = true;
                    textBoxParam3.Visible = true;
                    paramLabel1.Visible = true;
                    paramLabel2.Visible = true;
                    paramLabel3.Visible = true;
                    paramLabel1.Text = "Length 1";
                    paramLabel2.Text = "Length 2";
                    paramLabel3.Text = "Length 3";
                    break;
                default:
                    break;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            double length1 = Convert.ToDouble(textBoxParam1.Text);
            double length2 = Convert.ToDouble(textBoxParam2.Text);
            double length3 = Convert.ToDouble(textBoxParam3.Text);
            ShapeServiceReference.ShapeServiceSoapClient client = new ShapeServiceReference.ShapeServiceSoapClient();
            this.resultLabel.Text = client.ComputePerimeter(this.comboBoxShapes.Text, length1, length2, length3).ToString();
        }
    }
}
