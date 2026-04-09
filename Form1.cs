namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rdoHamBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            rdoHamBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;

            this.ActiveControl = null; 
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (!rdoHamBurger.Checked && !rdoBulgogiBurger.Checked && !rdoChickenBurger.Checked)
            {
                lblTotalCost.ForeColor = Color.Red;
                lblTotalCost.Text = "메인 메뉴 하나 이상 선택해주세요.";
                return;
            }

            int totalCost = 0;

            if (rdoHamBurger.Checked)
            {
                lstOrder.Items.Add("햄버거 5,000원");
                totalCost += 5000;
            }
            else if (rdoBulgogiBurger.Checked)
            {
                lstOrder.Items.Add("불고기버거 4,000원");
                totalCost += 4000;
            }
            else if (rdoChickenBurger.Checked)
            {
                lstOrder.Items.Add("치킨버거 3,000원");
                totalCost += 3000;
            }

            if (chkPotato.Checked)
            {
                lstOrder.Items.Add("감자튀김 3,500원");
                totalCost += 3500;
            }
            if (chkCola.Checked)
            {
                lstOrder.Items.Add("콜라 2,500원");
                totalCost += 2500;
            }
            if (chkCheese.Checked)
            {
                lstOrder.Items.Add("치즈 추가 1,500원");
                totalCost += 1500;
            }
            if (chkSauce.Checked)
            {
                lstOrder.Items.Add("소스 추가 500원");
                totalCost += 500;
            }
            lblTotalCost.ForeColor = Color.Blue;
            lblTotalCost.Text = "총 금액: " + totalCost.ToString("#,##0") + "원";
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            rdoHamBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;

            chkPotato.Checked = false;
            chkCola.Checked = false;
            chkCheese.Checked = false;
            chkSauce.Checked = false;

            lstOrder.Items.Clear();
            lblTotalCost.ForeColor = Color.Black;
            lblTotalCost.Text = "총 금액 : 0원";
        }
        private void lblTotalCost_Click(object sender, EventArgs e)
        {

        }

        private void lstOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rdoHamBurger_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoBulgogiBurger_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoChickenBurger_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
