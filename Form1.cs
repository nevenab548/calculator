using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CEbutton_Click(object sender, EventArgs e)
        {
            InputText.Text = string.Empty;
            Result.Text = "Unesite izraz i pritisnite enter ili =";
            FokusirajText();
        }

        private void Zerobutton_Click(object sender, EventArgs e)
        {
            UbaciText("0");
            FokusirajText();
        }

        private void Onebutton_Click(object sender, EventArgs e)
        {
            UbaciText("1");
            FokusirajText();
        }

        private void Twobutton_Click(object sender, EventArgs e)
        {
            UbaciText("2");
            FokusirajText();
        }

        private void Threebutton_Click(object sender, EventArgs e)
        {
            UbaciText("3");
            FokusirajText();
        }

        private void Fourbutton_Click(object sender, EventArgs e)
        {
            UbaciText("4");
            FokusirajText();
        }

        private void Fivebutton_Click(object sender, EventArgs e)
        {
            UbaciText("5");
            FokusirajText();
        }

        private void Sixbutton_Click(object sender, EventArgs e)
        {
            UbaciText("6");
            FokusirajText();
        }

        private void Sevenbutton_Click(object sender, EventArgs e)
        {
            UbaciText("7");
            FokusirajText();
        }

        private void Eightbutton_Click(object sender, EventArgs e)
        {
            UbaciText("8");
            FokusirajText();
        }

        private void Ninebutton_Click(object sender, EventArgs e)
        {
            UbaciText("9");
            FokusirajText();
        }

        private void Dotbutton_Click(object sender, EventArgs e)
        {
            UbaciText(".");
            FokusirajText();
        }

        private void Divbutton_Click(object sender, EventArgs e)
        {
            UbaciText("/");
            FokusirajText();
        }

        private void Mulbutton_Click(object sender, EventArgs e)
        {
            UbaciText("*");
            FokusirajText();
        }

        private void Subbutton_Click(object sender, EventArgs e)
        {
            UbaciText("-");
            FokusirajText();
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            UbaciText("+");
            FokusirajText();
        }

        private void Eqbutton_Click(object sender, EventArgs e)
        {
            Racunaj();
        }

        private void Racunaj()
        {
            Result.Text = Parsuj();
            FokusirajText();
        }

        private string Parsuj()
        {
            try
            {

                var unos = InputText.Text;
                unos = unos.Replace(" ", "");
                var operacija = new Operacije();
                var leva = true;
                for(int i=0;i<unos.Length;i++)
                {
                    if ("0123456789.".Any(c => unos[i] == c))
                    {
                        if (leva)
                            operacija.LevaStrana = DodajBroj(operacija.LevaStrana, unos[i]);
                        else
                            operacija.DesnaStrana = DodajBroj(operacija.DesnaStrana, unos[i]);
                    }
                    else if ("+-*/%^".Any(c => unos[i] == c))
                    {
                        if (!leva)
                        {
                            var tipoperacije = VratiTip(unos[i]);
                            if (operacija.DesnaStrana.Length == 0)
                            {
                                if (tipoperacije != OperacijeEnum.Oduzimanje)
                                    throw new InvalidOperationException($"Greska! Nedozvoljena operacija");
                                operacija.LevaStrana += unos[i];
                            }
                            else
                            {
                                operacija.LevaStrana = RacunajOperaciju(operacija);
                                operacija.Op = tipoperacije;
                                operacija.DesnaStrana = string.Empty;
                            }
                        }
                        else {
                            var tipoperacije = VratiTip(unos[i]);
                            if (operacija.LevaStrana.Length == 0)
                            {
                                if (tipoperacije != OperacijeEnum.Oduzimanje)
                                    throw new InvalidOperationException($"Greska! Nedozvoljena operacija");
                                operacija.DesnaStrana += unos[i];
                            }
                            else
                            {
                                operacija.Op = tipoperacije;
                                leva = false;
                            }
                        }
                    }
                }
                return RacunajOperaciju(operacija);
            }
            catch(Exception e)
            {
                return e.Message;
            }
        }

        private string RacunajOperaciju(Operacije operacija)
        {
            double levo = 0;
            double desno = 0;
            if (string.IsNullOrEmpty(operacija.LevaStrana) || !double.TryParse(operacija.LevaStrana, out levo))
                throw new InvalidOperationException($"Greska! Leva strana nije broj!");
            if (string.IsNullOrEmpty(operacija.DesnaStrana) || !double.TryParse(operacija.DesnaStrana, out desno))
                throw new InvalidOperationException($"Greska! Desna strana nije broj!");
            try
            {
                switch(operacija.Op)
                {
                    case OperacijeEnum.Sabiranje:
                        return (levo + desno).ToString();
                    case OperacijeEnum.Oduzimanje:
                        return (levo - desno).ToString();
                    case OperacijeEnum.Mnozenje:
                        return (levo * desno).ToString();
                    case OperacijeEnum.Deljenje:
                        return (levo / desno).ToString();
                    case OperacijeEnum.MOD:
                        return (levo % desno).ToString();
                    case OperacijeEnum.Stepen:
                        return (Math.Pow(levo,desno)).ToString();
                    default:
                        throw new InvalidOperationException($"Greska! Nedozvoljena operacija!");
                }
            }
            catch(Exception)
            {
                throw new InvalidOperationException("Greska pri racunanju!");
            }
        }

        private OperacijeEnum VratiTip(char v)
        {
            switch(v)
            {
                case '+':
                    return OperacijeEnum.Sabiranje;
                case '-':
                    return OperacijeEnum.Oduzimanje;
                case '*':
                    return OperacijeEnum.Mnozenje;
                case '/':
                    return OperacijeEnum.Deljenje;
                case '%':
                    return OperacijeEnum.MOD;
                case '^':
                    return OperacijeEnum.Stepen;
                default:
                    throw new InvalidEnumArgumentException($"Greska! Nedozvoljena operacija {v}");
            }
        }

        private string DodajBroj(string trenutnibroj, char novikarakter)
        {
            if (novikarakter == '.' && trenutnibroj.Contains('.'))
                throw new InvalidOperationException($"Greska! Broj {trenutnibroj} vec sadrzi '.'");
            return trenutnibroj + novikarakter;
        }

        private void UbaciText(string v)
        {
            var start = InputText.SelectionStart;
            InputText.Text = InputText.Text.Insert(InputText.SelectionStart, v);
            InputText.SelectionStart = start + v.Length;
            InputText.SelectionLength = 0;
        }
        private void ObrisiText()
        {
            if (InputText.Text.Length < InputText.SelectionStart + 1)
                return;
                var start = InputText.SelectionStart;
                InputText.Text = InputText.Text.Remove(InputText.SelectionStart, 1);
            InputText.SelectionStart = start;
            InputText.SelectionLength = 0;
        }
        private void FokusirajText()
        {
            InputText.Focus();
        }
        private void Delbutton_Click(object sender, EventArgs e)
        {
            ObrisiText();
            FokusirajText();
        }

        private void InputText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
                Racunaj();
        }

        private void ModButton_Click(object sender, EventArgs e)
        {
            UbaciText("%");
            FokusirajText();
        }

        private void Degbutton_Click(object sender, EventArgs e)
        {
            UbaciText("^");
            FokusirajText();
        }
    }
}
