using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace PlantsDatabase
{
    public partial class Form1 : Form
    {
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Accepted_Symbol;
        private DataGridViewTextBoxColumn Synonym_Symbol;
        private DataGridViewTextBoxColumn Scientific_Name;
        private DataGridViewTextBoxColumn Common_Name;
        private DataGridViewTextBoxColumn State_and_Province;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Genus;
        private DataGridViewTextBoxColumn Family;
        private DataGridViewTextBoxColumn Duration;
        private DataGridViewTextBoxColumn Active_Growth_Period;
        private DataGridViewTextBoxColumn Flower_Color;
        private DataGridViewTextBoxColumn Temperature;
        private DataGridViewTextBoxColumn Bloom_Period;

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Accepted_Symbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Synonym_Symbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Scientific_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Common_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State_and_Province = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Family = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active_Growth_Period = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Flower_Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Temperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bloom_Period = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Accepted_Symbol,
            this.Synonym_Symbol,
            this.Scientific_Name,
            this.Common_Name,
            this.State_and_Province,
            this.Category,
            this.Genus,
            this.Family,
            this.Duration,
            this.Active_Growth_Period,
            this.Flower_Color,
            this.Temperature,
            this.Bloom_Period});
            this.dataGridView1.Location = new System.Drawing.Point(12, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1035, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // Accepted_Symbol
            // 
            this.Accepted_Symbol.HeaderText = "Accepted Symbol";
            this.Accepted_Symbol.Name = "Accepted_Symbol";
            // 
            // Synonym_Symbol
            // 
            this.Synonym_Symbol.HeaderText = "Synonym Symbol";
            this.Synonym_Symbol.Name = "Synonym_Symbol";
            // 
            // Scientific_Name
            // 
            this.Scientific_Name.HeaderText = "Scientific Name";
            this.Scientific_Name.Name = "Scientific_Name";
            // 
            // Common_Name
            // 
            this.Common_Name.HeaderText = "Common Name";
            this.Common_Name.Name = "Common_Name";
            // 
            // State_and_Province
            // 
            this.State_and_Province.HeaderText = "State And Province";
            this.State_and_Province.Name = "State_and_Province";
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            // 
            // Genus
            // 
            this.Genus.HeaderText = "Genus";
            this.Genus.Name = "Genus";
            // 
            // Family
            // 
            this.Family.HeaderText = "Family";
            this.Family.Name = "Family";
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Duration";
            this.Duration.Name = "Duration";
            // 
            // Active_Growth_Period
            // 
            this.Active_Growth_Period.HeaderText = "Active Growth Period";
            this.Active_Growth_Period.Name = "Active_Growth_Period";
            // 
            // Flower_Color
            // 
            this.Flower_Color.HeaderText = "Flower Color";
            this.Flower_Color.Name = "Flower_Color";
            // 
            // Temperature
            // 
            this.Temperature.HeaderText = "Temperature, Minimum (°F)";
            this.Temperature.Name = "Temperature";
            // 
            // Bloom_Period
            // 
            this.Bloom_Period.HeaderText = "Bloom Period";
            this.Bloom_Period.Name = "Bloom_Period";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1059, 562);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Plants Database";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }
    }
}

