using System.Windows.Forms.DataVisualization.Charting;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtSentance.Text = Properties.Settings.Default.Sentance.ToString();
            this.Controls.Add(chart);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Sentance = txtSentance.Text;
            Properties.Settings.Default.Save();
            chart.Series.Clear();
            var sentance = txtSentance.Text;
            Dictionary<char, int> dic = Logic.FindFractionOfLetters(sentance);
            char[] chars = new char[dic.Count];
            float[] values = new float[dic.Count];
            string str = "";
            int iter = 0;
            foreach (var pair in dic)
            {
                chars[iter] = pair.Key;
                values[iter] = ((float)pair.Value / sentance.Length) * 100;
                str = string.Concat(str, $"{pair.Key}:{((float)pair.Value / sentance.Length) * 100}%\n");
                iter++;
            }
            if (str == "")
            {
                MessageBox.Show("В поле нет предложения");
            }
            else
            {
                MessageBox.Show(str);
            }
            Series series = new Series();
            for (int i = 0; i < dic.Count; i++)
            {
                series.Points.AddXY(chars[i].ToString(), values[i]);
            }
            series.ChartType = SeriesChartType.Pie;
            chart.Series.Add(series);
        }
    }
    public class Logic
    {
        public static Dictionary<char, int> FindFractionOfLetters(string str)
        {
            str = str.ToLower();
            Dictionary<char, int> dic = new Dictionary<char, int>();

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (!dic.ContainsKey(c))
                {
                    dic[c] = 1;
                }
                else
                {
                    dic[c] += 1;
                }
            }
            return dic;
        }
    }
}