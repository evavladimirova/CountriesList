namespace CountriesList
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void countryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cityComboBox.Items.Clear();


            string selectedCountry = countryComboBox.SelectedItem.ToString();


            if (selectedCountry != null)
            {
                switch (selectedCountry)
                {
                    case "Bulgaria":
                        cityComboBox.Items.Add("Sofia");
                        cityComboBox.Items.Add("Plovdiv");
                        cityComboBox.Items.Add("Burgas");
                        break;
                    case "Italy":
                        cityComboBox.Items.Add("Rome");
                        cityComboBox.Items.Add("Bologna");
                        cityComboBox.Items.Add("Venice");
                        break;
                    case "Spain":
                        cityComboBox.Items.Add("Madrid");
                        cityComboBox.Items.Add("Barcelona");
                        cityComboBox.Items.Add("Valencia");
                        break;
                    default:
                        break;
                }
            }
        }

        private void cityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void hobbiesGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void timeGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private string GetSelectedRadioButtonText()
        {
            foreach (RadioButton radioButton in timeGroupBox.Controls)
            {
                if (radioButton.Checked)
                {
                    return radioButton.Text;
                }
            }
            return string.Empty;
        }
        private void leftListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void moveToRightButton_Click(object sender, EventArgs e)
        {
         
            List<object> itemsToRemove = new List<object>();

            foreach (object selectedItem in leftListBox.SelectedItems)
            {
                rigthListBox.Items.Add(selectedItem);
                itemsToRemove.Add(selectedItem);
            }

            foreach (object itemToRemove in itemsToRemove)
            {
                leftListBox.Items.Remove(itemToRemove);
            }

        }

        private void moveToLeftButton_Click(object sender, EventArgs e)
        {
            List<object> itemsToRemove = new List<object>();

            foreach (object selectedItem in rigthListBox.SelectedItems)
            {
                if (!leftListBox.Items.Contains(selectedItem))
                {
                    leftListBox.Items.Add(selectedItem);
                }

                itemsToRemove.Add(selectedItem);
            }

            foreach (object itemToRemove in itemsToRemove)
            {
                rigthListBox.Items.Remove(itemToRemove);
            }
        }

        private void rigthListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void hobbie1CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;

            if (checkBox.Checked)
            {
                leftListBox.Items.Add(checkBox.Text);
            }
            else
            {
                leftListBox.Items.Remove(checkBox.Text);
            }
        }

        private void hobbie2checkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;

            if (checkBox.Checked)
            {
                leftListBox.Items.Add(checkBox.Text);
            }
            else
            {
                leftListBox.Items.Remove(checkBox.Text);
            }
        }

        private void hobbie3CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;

            if (checkBox.Checked)
            {
                leftListBox.Items.Add(checkBox.Text);
            }
            else
            {
                leftListBox.Items.Remove(checkBox.Text);
            }
        }

        private void hobbie4CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;

            if (checkBox.Checked)
            {
                leftListBox.Items.Add(checkBox.Text);
            }
            else
            {
                leftListBox.Items.Remove(checkBox.Text);
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string selectedCountry = countryComboBox.SelectedItem?.ToString();
            string selectedCity = cityComboBox.SelectedItem?.ToString();
            string selectedRadioButtonText = GetSelectedRadioButtonText();
            string selectedHobbies = string.Join(", ", rigthListBox.Items.Cast<object>().Select(item => item.ToString()));

            string message = $"Country: {selectedCountry}\nCity: {selectedCity}\nTime: {selectedRadioButtonText}\nHobby: {selectedHobbies}";
            MessageBox.Show(message, "Submitted Information");

            Close();
        }
    }
}
