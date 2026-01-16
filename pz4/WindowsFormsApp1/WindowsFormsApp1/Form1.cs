using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_Shapes
{
    public partial class Form1 : Form
    {
        ShapeContainer container = new ShapeContainer();

        public Form1()
        {
            InitializeComponent();
        }


        private void UpdateList()
        {
            listBoxShapes.Items.Clear();
            foreach (var shape in container.GetAllShapes())
            {
                listBoxShapes.Items.Add(shape.GetInfo());
            }

            lblTotalArea.Text = "Загальна площа: " + container.GetTotalArea().ToString("F2");
        }

        private void btnAddCircle_Click(object sender, EventArgs e)
        {
            try
            {
                double r = double.Parse(txtParam1.Text);
                container.AddShape(new Circle(r));
                UpdateList();
            }
            catch { MessageBox.Show("Перевірте введення чисел"); }
        }

        private void btnAddRect_Click(object sender, EventArgs e)
        {
            try
            {
                double w = double.Parse(txtParam1.Text);
                double h = double.Parse(txtParam2.Text);
                container.AddShape(new Rectangle(w, h));
                UpdateList();
            }
            catch { MessageBox.Show("Перевірте введення чисел"); }
        }

        private void btnAddSquare_Click(object sender, EventArgs e)
        {
            try
            {
                double s = double.Parse(txtParam1.Text);
                container.AddShape(new Square(s));
                UpdateList();
            }
            catch { MessageBox.Show("Перевірте введення чисел"); }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBoxShapes.SelectedIndex != -1)
            {
                container.RemoveShape(listBoxShapes.SelectedIndex);
                UpdateList();
            }
        }
    }
}