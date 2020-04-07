using System;
using System.Drawing;
using System.Windows.Forms;
using Accordeon.Properties;

namespace Accordeon
{
    public partial class FrmAccordeon : Form
    {
        public FrmAccordeon()
        {
            InitializeComponent();
            AccordeonMnu();
        }

        private void AccordeonMnu()
        {
            Font fm = new Font(Font.FontFamily, 11);
            Font fs = new Font(Font.FontFamily, 10);

            //  Main menu body
            FlowLayoutPanel flwMain = new FlowLayoutPanel() {
                BackColor = Color.Black,
                BorderStyle = BorderStyle.FixedSingle,
                FlowDirection = FlowDirection.TopDown,
                Dock = DockStyle.Left,
                Width = 250
            };

            PictureBox picLogo = new PictureBox()
            {
                Image = Resources.undo32,
                Height = 80,
                SizeMode = PictureBoxSizeMode.CenterImage,
                Width = flwMain.Width
            };

            Label lblMnu01 = new Label()
            {
                BackColor = Color.SteelBlue,
                Font = fm,
                ForeColor = Color.White,
                Height = 48,
                Image = Properties.Resources.kteatime_3, 
                ImageAlign = ContentAlignment.MiddleLeft,
                Margin = new Padding( 3, 1, 3, 1),
                Padding = new Padding( 12, 3, 0, 3),
                Text = "               Básico",
                TextAlign = ContentAlignment.MiddleLeft,
                Width = flwMain.Width
            };
            FlowLayoutPanel flwSub01 = new FlowLayoutPanel()
            {
                AutoSize = true,
                BackColor = Color.White,
                FlowDirection = FlowDirection.TopDown,
                Dock = DockStyle.Left,
                Visible = false,
                Width = 250
            };            
                Label lblSub0101 = new Label()
            {
                BackColor = Color.Transparent,
                Font = fs,
                ForeColor = Color.Black,
                Padding = new Padding(32, 1, 0, 1),
                Text = "Opcao de Tabelas 0101",
                TextAlign = ContentAlignment.MiddleLeft,
                Width = flwMain.Width
            };         
                Label lblSub0102 = new Label()
            {
                BackColor = Color.Transparent,
                Font = fs,
                ForeColor = Color.Black,
                Padding = new Padding(32, 1, 0, 1),
                Text = "Opcao de Tabelas 0102",
                TextAlign = ContentAlignment.MiddleLeft,
                Width = flwMain.Width
            };

            Label lblMnu02 = new Label()
            {
                BackColor = Color.SteelBlue,
                Font = fm,
                ForeColor = Color.White,
                Height = 48,
                Image = Properties.Resources.ktimer_3,
                ImageAlign = ContentAlignment.MiddleLeft,                
                Margin = new Padding(3, 1, 3, 1),
                Padding = new Padding(12, 3, 0, 3),
                Text = "               Intermediario",
                TextAlign = ContentAlignment.MiddleLeft,
                Width = flwMain.Width
            };
            FlowLayoutPanel flwSub02 = new FlowLayoutPanel()
            {
                AutoSize = true,
                BackColor = Color.White,
                FlowDirection = FlowDirection.TopDown,
                Dock = DockStyle.Left,
                Visible = false,
                Width = 250
            };
                Label lblSub0201 = new Label()
            {
                BackColor = Color.Transparent,
                Font = fs,
                ForeColor = Color.Black,
                Padding = new Padding(32, 1, 0, 1),
                Text = "Opcao de Tabelas 0201",
                TextAlign = ContentAlignment.MiddleLeft,
                Width = flwMain.Width
            };
                Label lblSub0202 = new Label()
            {
                BackColor = Color.Transparent,
                Font = fs,
                ForeColor = Color.Black,
                Padding = new Padding(32, 1, 0, 1),
                Text = "Opcao de Tabelas 0202",
                TextAlign = ContentAlignment.MiddleLeft,
                Width = flwMain.Width
            };

            Label lblMnu03 = new Label()
            {
                BackColor = Color.SteelBlue,
                Font = fm,
                ForeColor = Color.White,
                Height = 48,
                Image = Properties.Resources.kalzium,
                ImageAlign = ContentAlignment.MiddleLeft,
                Margin = new Padding(3, 1, 3, 1),
                Padding = new Padding(12, 3, 0, 3),
                Text = "               Avançado",
                TextAlign = ContentAlignment.MiddleLeft,
                Width = flwMain.Width
            };

            FlowLayoutPanel flwSub03 = new FlowLayoutPanel()
            {
                AutoSize = true,
                BackColor = Color.White,
                FlowDirection = FlowDirection.TopDown,
                Dock = DockStyle.Left,
                Visible = false,
                Width = 250
            };
            Label lblSub0301 = new Label()
            {
                BackColor = Color.Transparent,
                Font = fs,
                ForeColor = Color.Black,
                Padding = new Padding(32, 1, 0, 1),
                Text = "Opcao de Tabelas 0301",
                TextAlign = ContentAlignment.MiddleLeft,
                Width = flwMain.Width
            };
            Label lblSub0302 = new Label()
            {
                BackColor = Color.Transparent,
                Font = fs,
                ForeColor = Color.Black,
                Padding = new Padding(32, 1, 0, 1),
                Text = "Opcao de Tabelas 0302",
                TextAlign = ContentAlignment.MiddleLeft,
                Width = flwMain.Width
            };

            // Monta primeiro painel
            flwSub01.Controls.Add(lblSub0101);
            flwSub01.Controls.Add(lblSub0102);
            // Monta segundo painel
            flwSub02.Controls.Add(lblSub0201);
            flwSub02.Controls.Add(lblSub0202);
            // Monta segundo painel
            flwSub03.Controls.Add(lblSub0301);
            flwSub03.Controls.Add(lblSub0302);

            // Adiciona painel principal ao menu
            this.Controls.Add(flwMain);
            // Adiciona picture ao menu
            flwMain.Controls.Add(picLogo);
            // Primeiro Item
            flwMain.Controls.Add(lblMnu01);
            // Painel do primeiro item
            flwMain.Controls.Add(flwSub01);
            // Segundo item
            flwMain.Controls.Add(lblMnu02);
            // Painel do segundo item
            flwMain.Controls.Add(flwSub02);
            // Segundo item
            flwMain.Controls.Add(lblMnu03);
            // Painel do segundo item
            flwMain.Controls.Add(flwSub03);

            //  Handlers de eventos
            //  Documentacao Microsoft
            //  https://docs.microsoft.com/en-us/dotnet/api/system.eventhandler?view=netframework-4.8
            //
            lblMnu01.Click += (object sender, EventArgs e) => { flwSub01.Visible = !flwSub01.Visible; };
            lblMnu01.MouseHover += (object sender, EventArgs e) => { lblMnu01.BackColor = Color.Red; };
            lblMnu01.MouseLeave += (object sender, EventArgs e) => { lblMnu01.BackColor = Color.SteelBlue; };

            lblMnu02.Click += (object sender, EventArgs e) => { flwSub02.Visible = !flwSub02.Visible; };
            lblMnu02.MouseHover += (object sender, EventArgs e) => { lblMnu02.BackColor = Color.Red; };
            lblMnu02.MouseLeave += (object sender, EventArgs e) => { lblMnu02.BackColor = Color.SteelBlue; };

            lblMnu03.Click += (object sender, EventArgs e) => { flwSub03.Visible = !flwSub03.Visible; };
            lblMnu03.MouseHover += (object sender, EventArgs e) => { lblMnu03.BackColor = Color.Red; };
            lblMnu03.MouseLeave += (object sender, EventArgs e) => { lblMnu03.BackColor = Color.SteelBlue; };

            lblSub0101.Click += (object sender, EventArgs e) => {
                FrmF1 frmF1 = new FrmF1(); OpenFormInPanel(frmF1);
            };
            lblSub0102.Click += (object sender, EventArgs e) => {
                FrmF2 frmF2 = new FrmF2(); OpenFormInPanel(frmF2);
            };
        }

        private void OpenFormInPanel(Form f)
        {
            pnlMain.Controls.Clear();
            while (pnlMain.Controls.Count > 0)
            {
                Form g = (Form)pnlMain.Controls[0];
                g.Close();
            }

            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(f);
            f.Show();
        }

        private void FrmAccordeon_Load(object sender, EventArgs e)
        {

        }
    }
}
