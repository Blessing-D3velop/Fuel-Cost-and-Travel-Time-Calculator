using System.Diagnostics;
using System.Globalization;

namespace Methodss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int speed;
        double distance, price, fuel;
        double fuelCost = 0.00, travelTime = 0.00;

        private void btnProceed_Click(object sender, EventArgs e)
        {
            try
            {
                //check if all inputs are entered
                if (String.IsNullOrEmpty(txtDistance.Text) || string.IsNullOrEmpty(txtFuel.Text) || string.IsNullOrEmpty(txtPrice.Text))
                {

                    MessageBox.Show("Please ensure that all the values are entered");
                    return;
                }
                if (string.IsNullOrEmpty(txtSpeed.Text))
                {
                    MessageBox.Show("Please ensure that all the values are entered");
                    return;
                }

                //check if the correct the inputs are enetred by preventing exception

                if (!double.TryParse(txtDistance.Text, out distance))
                {
                    MessageBox.Show("Invalid Distance");
                    txtDistance.Clear();
                    txtDistance.Focus();
                    return;
                }
                else if (!double.TryParse(txtFuel.Text, out fuel))
                {
                    MessageBox.Show("Invalid Fuel");
                    txtFuel.Clear();
                    txtFuel.Focus();
                    return;
                }
                else if (!double.TryParse(txtPrice.Text, out price))
                {
                    MessageBox.Show("Invalid Fuel Price");
                    txtPrice.Clear();
                    txtPrice.Focus();
                    return;
                }
                else if (!int.TryParse(txtSpeed.Text, out speed))
                {
                    MessageBox.Show("Invalid Speed");
                    txtSpeed.Clear();
                    txtSpeed.Focus();
                    return;
                }
                else
                {
                    //check if speed and fuel is not ZERO
                    if (fuel <= 0)
                    {
                        MessageBox.Show("Fuel consumption must be greater than zero");
                        txtFuel.Focus();
                        return;
                    }

                    if (speed <= 0)
                    {
                        MessageBox.Show("Speed must be greater than zero");
                        txtSpeed.Focus();
                        return;
                    }



                    //method call for fuel cost
                    fuelCost = fuelPrice(distance, fuel, price);

                    //method call for travel time
                    travelTime = timeTravel(distance, speed);

                    lblOutput.Visible = true;

                    //display the output
                    lblOutput.Text =
                    $"The estimated fuel cost is {fuelCost.ToString("C", CultureInfo.GetCultureInfo("en-US"))} " +
                    $"and the estimated travel time is {travelTime:F2} hours.";



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear the controls
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    (ctrl as TextBox).Clear();
                }
            }
            lblOutput.Text = "";
            lblOutput.Visible = false;
            txtDistance.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ask the user for confirmation
            DialogResult result = MessageBox.Show("Are you sure you want to exit?",
                                                  "Exit Confirmation",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            // If the user clicked Yes, close the form
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Thank you for using the App!");
                this.Close();
            }
            // If they clicked No, do nothing (the form remains open
        }
        private double fuelPrice(double distance, double fuel, double price)
        {
            //calculate fuel cost
            return (distance / fuel) * price;
        }
        private double timeTravel(double distance, int speed)
        {
            //calculate travel time
            return distance / (double)speed;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblOutput.Visible = false;
        }
    }

}
