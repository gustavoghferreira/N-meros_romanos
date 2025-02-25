using System.Reflection.Metadata.Ecma335;

namespace Numeros_Romanos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int vUnit, vTen, vHundred, vThousand;
        private string selectTypeConvert = "ArabicToRoman";

        private void buttonInvert_Click(object sender, EventArgs e)
        {
            if (labelTypeN1.Text == "Arábico")
            {
                labelTypeN1.Text = "Romano";
                labelTypeN2.Text = "Arábico";

                selectTypeConvert = "RomanToArabic";
            }
            else
            {
                labelTypeN1.Text = "Arábico";
                labelTypeN2.Text = "Romano";

                selectTypeConvert = "ArabicToRoman";
            }
        }

        private void textBoxValue1_TextChanged(object sender, EventArgs e)
        {
            string[] units = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            string[] tens = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] hundreds = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] thousands = { "", "M", "MM", "MMM" };

            if (selectTypeConvert == "ArabicToRoman")
            {
                var value = textBoxValue1.Text;
                if (String.IsNullOrEmpty(textBoxValue1.Text))
                {
                    textBoxValue2.Text = "";
                    return;
                }

                var values = int.Parse(value);
                if (values <= 0 || values > 3999)
                {
                    MessageBox.Show("Valor fora da tolerância, digite números entre 1 e 3999");
                }

                vUnit = values % 10;
                vTen = (values / 10) % 10;
                vHundred = (values / 100) % 10;
                vThousand = (values / 1000);

                textBoxValue2.Text = thousands.ElementAtOrDefault(vThousand) + hundreds.ElementAtOrDefault(vHundred) +
                    tens.ElementAtOrDefault(vTen) + units.ElementAtOrDefault(vUnit);
            }
            else if (selectTypeConvert == "RomanToArabic")
            {
                int result = 0;
                string value = textBoxValue1.Text;

                static int romans(char r)
                {
                    if (r == 'I')
                        return 1;
                    if (r == 'V')
                        return 5;
                    if (r == 'X')
                        return 10;
                    if (r == 'L')
                        return 50;
                    if (r == 'C')
                        return 100;
                    if (r == 'D')
                        return 500;
                    if (r == 'M')
                        return 1000;
                    return -1;
                }

                for (int i = 0; i < value.Length; i++)
                {
                    int s1 = romans(value[i]);

                    if (i + 1 < value.Length)
                    {
                        int s2 = romans(value[i + 1]);

                        if (s1 >= s2)
                        {
                            result += s1;
                        }
                        else
                        {
                            result += (s2 - s1);
                            i++;
                        }
                    }
                    else
                    {
                        result += s1;
                    }
                }

                if(result == -1)
                {
                    MessageBox.Show("Valor não corresponde ao padrão romano.");
                }
                else
                {
                    textBoxValue2.Text = result.ToString();
                }
            }
        }
    }
}
