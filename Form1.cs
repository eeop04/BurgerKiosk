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

            // 리스트 박스가 포커스를 받지 못하도록 설정
            lstOrder.TabStop = false;

            // 라디오 버튼의 자동 선택 방지 (방향키 이동 시 자동 체크 방지)
            rdoHamBurger.AutoCheck = false;
            rdoBulgogiBurger.AutoCheck = false;
            rdoChickenBurger.AutoCheck = false;

            // 라디오 버튼을 마우스로 클릭하거나 스페이스바로 선택할 때 수동으로 체크
            rdoHamBurger.MouseClick += RdoGroup_MouseClick;
            rdoBulgogiBurger.MouseClick += RdoGroup_MouseClick;
            rdoChickenBurger.MouseClick += RdoGroup_MouseClick;

            // 체크박스 상태 변경 시 즉시 업데이트 연결
            chkPotato.CheckedChanged += (s, e) => UpdateOrderSummary();
            chkCola.CheckedChanged += (s, e) => UpdateOrderSummary();
            chkCheese.CheckedChanged += (s, e) => UpdateOrderSummary();
            chkSauce.CheckedChanged += (s, e) => UpdateOrderSummary();
        }

        // 라디오 버튼을 선택할 때 호출되는 함수
        private void RdoGroup_MouseClick(object sender, MouseEventArgs e)
        {
            if (sender is RadioButton rdo)
            {
                // 현재 클릭한 라디오버튼이 원래 선택되어 있었는지 확인
                bool wasChecked = rdo.Checked;

                // 일단 모두 선택 해제
                rdoHamBurger.Checked = false;
                rdoBulgogiBurger.Checked = false;
                rdoChickenBurger.Checked = false;

                // 원래 선택되어 있지 않았던 경우에만 다시 체크
                if (!wasChecked)
                {
                    rdo.Checked = true;
                }

                // 변경된 상태 즉시 업데이트
                UpdateOrderSummary();
            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            rdoHamBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;

            this.ActiveControl = null; 
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Enter 키로 주문
            if (keyData == Keys.Enter)
            {
                btnOrder.PerformClick();
                return true;
            }

            Control active = this.ActiveControl;

            // 스페이스바를 눌렀을 때 포커스된 라디오 버튼 수동 체크
            if (keyData == Keys.Space && active is RadioButton rdo)
            {
                bool wasChecked = rdo.Checked;
                rdoHamBurger.Checked = false;
                rdoBulgogiBurger.Checked = false;
                rdoChickenBurger.Checked = false;
                if (!wasChecked) rdo.Checked = true;

                // 변경된 상태 즉시 업데이트
                UpdateOrderSummary();
                return true;
            }

            // 그룹별 컨트롤 배열 정의
            Control[] mainGroup = new Control[] { rdoHamBurger, rdoBulgogiBurger, rdoChickenBurger };
            Control[] suvGroup = new Control[] { chkPotato, chkCola, chkCheese, chkSauce };
            Control[] listGroup = new Control[] { btnOrder, btnClear };

            // 1. Tab 키: 그룹박스 단위로 크게 이동
            if (keyData == Keys.Tab || keyData == (Keys.Tab | Keys.Shift))
            {
                bool forward = (keyData == Keys.Tab);
                Control targetControl = null;

                if (active == null)
                {
                    targetControl = forward ? mainGroup[0] : listGroup[0];
                }
                else if (active.Parent == grpMain)
                {
                    targetControl = forward ? suvGroup[0] : listGroup[0];
                }
                else if (active.Parent == grpSuv)
                {
                    targetControl = forward ? listGroup[0] : mainGroup[0];
                }
                else if (active.Parent == grpList || active == btnOrder || active == btnClear)
                {
                    targetControl = forward ? mainGroup[0] : suvGroup[0];
                }
                else
                {
                    targetControl = mainGroup[0];
                }

                if (targetControl != null)
                {
                    targetControl.Focus();
                }
                return true;
            }

            // 2. 방향키: 현재 속한 그룹박스 내에서만 포커스 이동 (무한 반복)
            if (keyData == Keys.Down || keyData == Keys.Right || keyData == Keys.Up || keyData == Keys.Left)
            {
                bool forward = (keyData == Keys.Down || keyData == Keys.Right);
                Control[] currentGroup = null;

                if (active != null)
                {
                    if (active.Parent == grpMain) currentGroup = mainGroup;
                    else if (active.Parent == grpSuv) currentGroup = suvGroup;
                    else if (active.Parent == grpList || active == btnOrder || active == btnClear) currentGroup = listGroup;
                }

                if (currentGroup != null)
                {
                    int currentIndex = Array.IndexOf(currentGroup, active);
                    if (currentIndex != -1)
                    {
                        int nextIndex = forward ? (currentIndex + 1) % currentGroup.Length 
                                                : (currentIndex - 1 + currentGroup.Length) % currentGroup.Length;
                        currentGroup[nextIndex].Focus();
                        return true; // 윈폼 기본 방향키 이동 무시
                    }
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void UpdateOrderSummary()
        {
            lstOrder.Items.Clear();
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

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (!rdoHamBurger.Checked && !rdoBulgogiBurger.Checked && !rdoChickenBurger.Checked)
            {
                lblTotalCost.ForeColor = Color.Red;
                lblTotalCost.Text = "메인 메뉴 하나 이상 선택해주세요.";
                return;
            }

            // 주문이 올바르게 완료된 경우 메시지 박스 등을 띄우거나 초기화할 수 있습니다.
            MessageBox.Show("주문이 완료되었습니다!\n\n" + lblTotalCost.Text, "주문 확인");
            btnClear.PerformClick(); // 주문 후 초기화
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
