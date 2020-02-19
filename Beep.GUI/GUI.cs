using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beep.GUI
{
    public partial class GUI : Form
    {
        private bool repetir;

        public GUI()
        {
            InitializeComponent();
        }

        private async void Beepar(object sender, EventArgs e)
        {
            InverterRepetir(sender, e);

            ushort frequencia = Convert.ToUInt16(numFrequencia.Text);
            int duracao = Convert.ToInt32(numDuracao.Text);
            await Beep(frequencia, duracao);
        }

        private void InverterRepetir(object sender, EventArgs e)
        {
            repetir = !repetir;
        }

        private void AlternarFuncionalidadeBotao(object sender, EventArgs e)
        {
            if (chkSegurar.Checked)
            {
                btnBeepar.Click -= Beepar;
                btnBeepar.KeyDown += Beepar;
                btnBeepar.MouseDown += Beepar;
                btnBeepar.KeyUp += InverterRepetir;
            }
            else
            {
                btnBeepar.KeyDown -= Beepar;
                btnBeepar.KeyUp -= InverterRepetir;
                btnBeepar.MouseUp -= Beepar;
                btnBeepar.Click += Beepar;
                btnBeepar.
            }
        }

        public async Task Beep(ushort frequencia, int duracao)
        {
            Action action = () =>
            {
                while (this.repetir)
                {
                    Console.Beep(frequencia, duracao);
                }
            };

            var task = new TaskFactory();
            await task.StartNew(action);
        }
    }
}
