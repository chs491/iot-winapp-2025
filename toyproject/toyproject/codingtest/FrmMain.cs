using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace codingtest
{
    //public partial class FrmMain : Form
    //{
    //    private List<Player> players = new List<Player>();
    //    private int nextId = 1;
    //    public FrmMain()
    //    {
    //        InitializeComponent();
    //        UpdateGrid();
    //    }

    //    private void BtnAdd_Click(object sender, EventArgs e)
    //    {
    //        if (string.IsNullOrWhiteSpace(TxtName.Text) || string.IsNullOrWhiteSpace(TxtPosition.Text) || !int.TryParse(TxtAge.Text, out int age))
    //        {
    //            MessageBox.Show("모든 값을 정확히 입력해주세요.");
    //            return;
    //        }

    //        var player = new Player
    //        {
    //            Id = nextId++,
    //            Name = TxtName.Text,
    //            Position = TxtPosition.Text,
    //            Age = age
    //        };

    //        players.Add(player);
    //        UpdateGrid();
    //        ClearInputs();
    //    }

    //    private void btnDelete_Click(object sender, EventArgs e)
    //    {
    //        if (dataGridView1.CurrentRow != null)
    //        {
    //            int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
    //            var toRemove = players.FirstOrDefault(p => p.Id == id);
    //            if (toRemove != null)
    //            {
    //                players.Remove(toRemove);
    //                UpdateGrid();
    //            }
    //        }
    //    }

    //    private void UpdateGrid()
    //    {
    //        dataGridView1.DataSource = null;
    //        dataGridView1.DataSource = players;
    //    }

    //    private void ClearInputs()
    //    {
    //        TxtName.Text = "";
    //        TxtPosition.Text = "";
    //        TxtAge.Text = "";
    //    }

    //    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    //    {
    //        if (e.RowIndex < 0) return;

    //        var selectedRow = dataGridView1.Rows[e.RowIndex];
    //        int id = (int)selectedRow.Cells[0].Value;
    //        var player = players.FirstOrDefault(p => p.Id == id);

    //        if (player != null)
    //        {
    //            TxtName.Text = player.Name;
    //            TxtPosition.Text = player.Position;
    //            TxtAge.Text = player.Age.ToString();
    //            TxtBats.Text = player.AtBats.ToString();
    //            TxtHits.Text = player.Hits.ToString();
    //            TxtWalks.Text = player.Walks.ToString();
    //            TxtDoubles.Text = player.Doubles.ToString();
    //            TxtTriples.Text = player.Triples.ToString();
    //            TxtHomeruns.Text = player.HomeRuns.ToString();
    //            //TxtImagePath.Text = player.ImagePath;

    //        }
    //    }

    //}

    public partial class FrmMain : Form
    {
        private List<Player> players = new List<Player>();

        public FrmMain()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.MultiSelect = false;
            dataGridView2.Dock = DockStyle.Fill;

            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Name", DataPropertyName = "Name" });
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "AVG", DataPropertyName = "AVG" });
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "OPS", DataPropertyName = "OPS" });
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Position", DataPropertyName = "Position" });
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Age", DataPropertyName = "Age" });
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "AtBats", DataPropertyName = "AtBats" });
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Hits", DataPropertyName = "Hits" });
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Walks", DataPropertyName = "Walks" });
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Doubles", DataPropertyName = "Doubles" });
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Triples", DataPropertyName = "Triples" });
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "HomeRuns", DataPropertyName = "HomeRuns" });

            dataGridView2.DataSource = new BindingSource { DataSource = players };
        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            var player = new Player
            {
                Name = TxtName1.Text,
                Position = TxtPosition1.Text,
                Age = int.Parse(TxtAge1.Text),
                AtBats = int.Parse(TxtBats1.Text),
                Hits = int.Parse(TxtHits1.Text),
                Walks = int.Parse(TxtWalks1.Text),
                Doubles = int.Parse(TxtDoubles1.Text),
                Triples = int.Parse(TxtTriples1.Text),
                HomeRuns = int.Parse(TxtHomeruns1.Text)
            };

            players.Add(player);

            dataGridView2.DataSource = null;
            dataGridView2.DataSource = players;
        }

        private void btnDelete1_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                var selectedIndex = dataGridView2.SelectedRows[0].Index;
                if (selectedIndex >= 0 && selectedIndex < players.Count)
                {
                    players.RemoveAt(selectedIndex);
                    dataGridView2.DataSource = null;
                    dataGridView2.DataSource = players;
                }
            }
        }
    }

}
