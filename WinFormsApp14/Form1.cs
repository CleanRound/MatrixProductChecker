using System;
using System.Linq;
using System.Windows.Forms;

namespace PositiveElementsSquared
{
    public partial class Form1 : Form
    {
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateNewMatrix();
        }

        private void GenerateNewMatrix()
        {
            int rows = 5;
            int cols = 6;
            int[,] A = new int[rows, cols];

            dataGridView1.RowCount = rows;
            dataGridView1.ColumnCount = cols;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    A[i, j] = rand.Next(1, 6);
                    dataGridView1[j, i].Value = A[i, j];
                }
            }
        }

        private void btnGenerateNew_Click(object sender, EventArgs e)
        {
            GenerateNewMatrix();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int rows = dataGridView1.RowCount;
                int cols = dataGridView1.ColumnCount;
                int rowCountWithProdLessThan40 = 0;

                for (int i = 0; i < rows; i++)
                {
                    int product = 1;
                    for (int j = 0; j < cols; j++)
                    {
                        product *= Convert.ToInt32(dataGridView1[j, i].Value);
                    }
                    if (product < 40)
                    {
                        rowCountWithProdLessThan40++;
                    }
                }

                lblResult.Text = $"Rows with product < 40: {rowCountWithProdLessThan40}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
