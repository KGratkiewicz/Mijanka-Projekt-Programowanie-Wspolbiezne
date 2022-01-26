using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DomainUpDown;
using static Train;
using static FractionAB;

namespace Mijanka
{
    
    public partial class Form1 : Form
    {
        private int simulationSpeed;
        private FractionAB fractionAB;
        private Train trainA;
        private Train trainB;
        private Train trainUp;
        private Train trainDown;

        public Form1()
        {
            this.simulationSpeed = 5;
            this.trainA = null;
            this.trainB = null;
            this.trainUp = null;
            this.trainDown = null;
            InitializeComponent();
            this.fractionAB = new FractionAB();
            //this.fractionAB.Simulation();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.trainA = this.fractionAB.getRailA().getTrain();
            this.trainB = this.fractionAB.getRailB().getTrain();
            this.trainUp = this.fractionAB.getDoubleRail().getTrainUp();
            this.trainDown = this.fractionAB.getDoubleRail().getTrainDown();

            if (this.trainA != null)
            {
                this.setLocationOfTrainA(this.trainA.getLocation(), this.trainA.getRail().getLength());
            }
            else
            {
                this.turnOffTrainA();
            }

            if (this.trainB != null)
            {
                this.setLocationOfTrainB(this.trainB.getLocation(), this.trainB.getRail().getLength());
            }
            else
            {
                this.turnOffTrainB();
            }

            if (this.trainUp != null)
            {
                this.setLocationOfTrainUp(this.trainUp.getLocation(), this.trainUp.getRail().getLength());
            }
            else
            {
                this.turnOffTrainUp();
            }

            if (this.trainDown != null)
            {
                this.setLocationOfTrainDown(this.trainDown.getLocation(), this.trainDown.getRail().getLength());
            }
            else
            {
                this.turnOffTrainDown();
            }
        }

        private void setLocationOfTrainA(int location, int size)
        {
            this.pictureTrainA.Visible = true;
            this.pictureTrainA.BackColor = (this.trainA.getSpeed() > 0) ? System.Drawing.Color.Red : System.Drawing.Color.Lime;
            this.pictureTrainA.Left = 40 + location;
        }

        private void turnOffTrainA()
        {
            this.pictureTrainA.Visible = false;
        }

        private void setLocationOfTrainB(int location, int size)
        {
            this.pictureTrainB.Visible = true;
            this.pictureTrainB.BackColor = (this.trainB.getSpeed() > 0) ? System.Drawing.Color.Red : System.Drawing.Color.Lime;
            this.pictureTrainB.Left = 640 + location;
        }

        private void turnOffTrainB()
        {
            this.pictureTrainB.Visible = false;
        }

        private void setLocationOfTrainUp(int location, int size)
        {
            this.pictureTrainUp.Visible = true;
            this.pictureTrainUp.BackColor = (this.trainUp.getSpeed() > 0) ? System.Drawing.Color.Red : System.Drawing.Color.Lime;
            this.pictureTrainUp.Left = 340 + location;
        }

        private void turnOffTrainUp()
        {
            this.pictureTrainUp.Visible = false;
        }

        private void setLocationOfTrainDown(int location, int size)
        {
            this.pictureTrainDown.Visible = true;
            this.pictureTrainDown.BackColor = (this.trainDown.getSpeed() > 0) ? System.Drawing.Color.Red : System.Drawing.Color.Lime;
            this.pictureTrainDown.Left = 340 + location;
        }

        private void turnOffTrainDown()
        {
            this.pictureTrainDown.Visible = false;
        }

        private void superFastAB_Click(object sender, EventArgs e)
        {
            this.fractionAB.createNewTrain(20);
        }

        private void fastAB_Click(object sender, EventArgs e)
        {
            this.fractionAB.createNewTrain(15);
        }

        private void normalAB_Click(object sender, EventArgs e)
        {
            this.fractionAB.createNewTrain(12);
        }

        private void slowAB_Click(object sender, EventArgs e)
        {
            this.fractionAB.createNewTrain(10);
        }

        private void superSlowAB_Click(object sender, EventArgs e)
        {
            this.fractionAB.createNewTrain(5);
        }

        private void superFastBA_Click(object sender, EventArgs e)
        {
            this.fractionAB.createNewTrain(-20);
        }

        private void fastBA_Click(object sender, EventArgs e)
        {
            this.fractionAB.createNewTrain(-15);
        }

        private void normalBA_Click(object sender, EventArgs e)
        {
            this.fractionAB.createNewTrain(-12);
        }

        private void slowBA_Click(object sender, EventArgs e)
        {
            this.fractionAB.createNewTrain(-10);
        }

        private void superSlowBA_Click(object sender, EventArgs e)
        {
            this.fractionAB.createNewTrain(-5);
        }

        private void buttonSuperFast_Click(object sender, EventArgs e)
        {
            this.fractionAB.createNewTrain(20);
            this.fractionAB.createNewTrain(-20);
        }

        private void buttonFast_Click(object sender, EventArgs e)
        {
            this.fractionAB.createNewTrain(15);
            this.fractionAB.createNewTrain(-15);
        }

        private void buttonNormal_Click(object sender, EventArgs e)
        {
            this.fractionAB.createNewTrain(12);
            this.fractionAB.createNewTrain(-12);
        }

        private void buttonSlow_Click(object sender, EventArgs e)
        {
            this.fractionAB.createNewTrain(10);
            this.fractionAB.createNewTrain(-10);
        }

        private void buttonSuperSlow_Click(object sender, EventArgs e)
        {
            this.fractionAB.createNewTrain(5);
            this.fractionAB.createNewTrain(-5);
        }
    }    
}
