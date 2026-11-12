#nullable disable
using System.Windows.Forms;

namespace toli_bichig
{
    public class Word
    {
        public string En, Mn, Ru;
    }

    public partial class Form1 : Form
    {
        private readonly List<Word> words = new List<Word>();   // толь бичиг
        private readonly List<string> saved = new List<string>(); // санасан үгс
        private readonly List<Word> shown = new List<Word>();   // хүснэгтэд харагдаж буй

        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;
            txtSearch.TextChanged += (s, e) => LoadWords();
            cmbLang.SelectedIndexChanged += (s, e) => LoadWords();
            dgvWords.SelectionChanged += dgvWords_SelectionChanged;
            btnAdd.Click += btnAdd_Click;
            btnEdit.Click += btnEdit_Click;
            btnDelete.Click += btnDelete_Click;
            btnClear.Click += btnClear_Click;
            btnSave.Click += btnSave_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvWords.AutoGenerateColumns = false;
            dgvSaved.AutoGenerateColumns = false;
            dgvWords.AllowUserToAddRows = false;
            dgvSaved.AllowUserToAddRows = false;
            dgvWords.ReadOnly = true;
            dgvSaved.ReadOnly = true;

            cmbLang.DropDownStyle = ComboBoxStyle.DropDownList;
            if (cmbLang.Items.Count == 0)
                cmbLang.Items.AddRange(new object[] { "Бүгд", "Англи", "Монгол", "Орос" });
            cmbLang.SelectedIndex = 0;

            txtSearch.PlaceholderText = "Хайх үг...";
            LoadWords();
            LoadSaved();
        }

        // ===== Хүснэгт дүүргэх (хайлт + хэлээр шүүх) =====
        private void LoadWords()
        {
            if (cmbLang.SelectedIndex < 0) return;
            string q = txtSearch.Text.Trim().ToLower();
            int lang = cmbLang.SelectedIndex;   // 0 бүгд, 1 англи, 2 монгол, 3 орос

            shown.Clear();
            dgvWords.Rows.Clear();
            int no = 1;
            foreach (var w in words)
            {
                bool match = q == "" ||
                    ((lang == 0 || lang == 1) && w.En.ToLower().Contains(q)) ||
                    ((lang == 0 || lang == 2) && w.Mn.ToLower().Contains(q)) ||
                    ((lang == 0 || lang == 3) && w.Ru.ToLower().Contains(q));
                if (!match) continue;
                shown.Add(w);
                dgvWords.Rows.Add(no++, w.En, w.Mn, w.Ru);
            }
            UpdateStatus();
        }

        private void LoadSaved()
        {
            dgvSaved.Rows.Clear();
            foreach (var s in saved) dgvSaved.Rows.Add(s);
            UpdateStatus();
        }

        private void UpdateStatus()
        {
            lblStatus.Text = $"Нийт: {words.Count} үг · Санасан: {saved.Count}";
        }

        private Word Selected()
        {
            if (dgvWords.CurrentRow == null) return null;
            int i = dgvWords.CurrentRow.Index;
            return (i >= 0 && i < shown.Count) ? shown[i] : null;
        }

        private void dgvWords_SelectionChanged(object sender, EventArgs e)
        {
            var w = Selected();
            if (w == null) return;
            txtEn.Text = w.En;
            txtMn.Text = w.Mn;
            txtRu.Text = w.Ru;
        }

        private bool InputsValid()
        {
            if (string.IsNullOrWhiteSpace(txtEn.Text) &&
                string.IsNullOrWhiteSpace(txtMn.Text) &&
                string.IsNullOrWhiteSpace(txtRu.Text))
            {
                MessageBox.Show("Дор хаяж нэг хэл дээр үг оруулна уу.", "Анхааруулга",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // ===== Товчнууд =====
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!InputsValid()) return;
            words.Add(new Word
            {
                En = txtEn.Text.Trim(),
                Mn = txtMn.Text.Trim(),
                Ru = txtRu.Text.Trim()
            });
            ClearInputs();
            LoadWords();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var w = Selected();
            if (w == null)
            {
                MessageBox.Show("Эхлээд хүснэгтээс мөр сонгоно уу.");
                return;
            }
            if (!InputsValid()) return;
            w.En = txtEn.Text.Trim();
            w.Mn = txtMn.Text.Trim();
            w.Ru = txtRu.Text.Trim();
            LoadWords();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var w = Selected();
            if (w == null)
            {
                MessageBox.Show("Устгах мөрөө сонгоно уу.");
                return;
            }
            if (MessageBox.Show("Сонгосон үгийг устгах уу?",