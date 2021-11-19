using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BubbleSort
{
    public partial class FormMain : Form
    {
        private int[] array;
        public FormMain()
        {
            InitializeComponent();
            textBoxSorted.Enabled = false;
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            textBoxSorted.Clear();

            string text = textBoxValues.Text;
            if (text.EndsWith(","))
            {
                MessageBox.Show("Incorrectly entered array.","Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string[] numbers = text.Split(",");
                array = new int[numbers.Length];

                for (int i = 0; i < numbers.Length; i++)
                    array[i] = int.Parse(numbers[i]);

                BubbleSort(array);

                ArrayVizualization(array);

                return;
            }
        }
        private void BubbleSort(int [] array)
        {
            int n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        var result = MessageBox.Show($"Swap between : {array[j]}(index {j}) and {array[j + 1]}(index {j + 1})");

                        if (result == DialogResult.OK)
                        {
                            int temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
                        textBoxSorted.Clear();
                        ArrayVizualization(array);
                    }
                }
            }
            textBoxSorted.Clear();
        }
        private void ArrayVizualization(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i == array.Length - 1)
                    textBoxSorted.Text += array[i].ToString();
                else
                    textBoxSorted.Text += array[i].ToString() + ",";
            }
        }
    }
}
