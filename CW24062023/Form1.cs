namespace CW24062023
{
	public partial class Form1 : Form
	{
		public Form1() {
			InitializeComponent();
		}

		private void button_Click(object sender, EventArgs e) {
			MessageBox.Show(
				$"Now is {new DateTime((int)numericYear.Value, (int)numericMounth.Value, (int)numericDay.Value).DayOfWeek}",
				"Day of week",
				MessageBoxButtons.OK,
				MessageBoxIcon.Information
			);
		}

		private void numeric_UdpateDay(object sender, EventArgs e) {
			numericDay.Maximum = DateTime.DaysInMonth((int)numericYear.Value, (int)numericMounth.Value);
		}
	}
}