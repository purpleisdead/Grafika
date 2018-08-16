using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KomputarnaGrafika.Model;

namespace KomputarnaGrafika
{
    public partial class DrawForm : Form
    {
        private enum FigureType
        {
            Ellipse,
            Rectangle,
            Line,
            CustomExamFigure,
            TotalCustom,
            Select
        }
        
        PointF mouseDownPoint;
        PointF mouseUpPoint;
        PointF mouseMovedPoint;
        FigureType SelectedType = FigureType.Select;
        Pen Pen = new Pen(Color.Black, 1f);
        
        List<Figure> SelectedFigures = new List<Figure>();
        List<Figure> PaintedFigures = new List<Figure>();

        public DrawForm()
        {
            InitializeComponent();
        }

        public void DrawObject(object sender, PaintEventArgs e)
        {
            ListOfNamesComboBox.ComboBox.Items.Clear();
            ListOfNamesComboBox.ComboBox.Items.Add("");

            foreach (Figure figure in PaintedFigures)
            {
                figure.Draw(e.Graphics);
                ListOfNamesComboBox.ComboBox.Items.Add(figure.Name);
            }
            
            if (SelectedFigures.Count() == 1)
            {
                label4.Text = SelectedFigures[0].Matrix.Elements[0].ToString();
                label5.Text = SelectedFigures[0].Matrix.Elements[1].ToString();
                label6.Text = SelectedFigures[0].Matrix.Elements[2].ToString();
                label7.Text = SelectedFigures[0].Matrix.Elements[3].ToString();
                label8.Text = SelectedFigures[0].Matrix.Elements[4].ToString();
                label9.Text = SelectedFigures[0].Matrix.Elements[5].ToString();

                XTextBox.Text = SelectedFigures[0].RectF.X.ToString();
                YTextBox.Text = SelectedFigures[0].RectF.Y.ToString();
                HTextBox.Text = SelectedFigures[0].RectF.Height.ToString();
                WTextBox.Text = SelectedFigures[0].RectF.Width.ToString();
                panel1.Visible = true;
            }


            SelectedType = FigureType.Select;
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownPoint = new PointF(e.X, e.Y);
            mouseMovedPoint = new PointF(e.X, e.Y);

            if (SelectedFigures.Count > 0)
            {
                mouseMovedPoint.X = mouseDownPoint.X;
                mouseMovedPoint.Y = mouseDownPoint.Y;
            }

            if (SelectedType == FigureType.Select)
            {
                if (Control.ModifierKeys != Keys.Control)
                {
                    DeselectFigures();
                }

                for (int i = PaintedFigures.Count() - 1; i >= 0; i--)
                {
                    if (!PaintedFigures[i].IsSelected && PaintedFigures[i].IsInside(mouseDownPoint))
                    {
                        SelectedFigures.Add(PaintedFigures[i]);
                        PaintedFigures[i].IsSelected = true;
                        this.pictureBox.Refresh();
                        panel1.Visible = true;
                        break;
                    }
                }

                //foreach (var figure in PaintedFigures)
                //{
                //    if (!figure.IsSelected && figure.IsInside(mouseDownPoint))
                //    {
                //        SelectedFigures.Add(figure);
                //        figure.IsSelected = true;
                //        panel1.Visible = true;
                //        break;
                //    }
                //}

                if (SelectedFigures.Count == 0)
                {
                    panel1.Visible = false;
                }
                else if (SelectedFigures.Count > 1)
                {
                    PanelDefault();
                }
                else
                {
                    BorderdColorButton.BackColor = SelectedFigures[0].Pen.Color;
                    BorderColorDialog.Color = SelectedFigures[0].Pen.Color;
                    ThicknessNumericUpDown.Value = (decimal)SelectedFigures[0].Pen.Width;
                }
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (SelectedFigures.Count > 0)
                {
                    foreach (var figure in SelectedFigures)
                    {
                        float x = e.X - mouseMovedPoint.X;
                        float y = e.Y - mouseMovedPoint.Y;

                        if (x != 0)
                        {

                        }
                        
                        figure.Translate(x, y);
                    }

                    mouseMovedPoint.X = e.X;
                    mouseMovedPoint.Y = e.Y;


                    this.pictureBox.Refresh();
                }
            }

            
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            mouseUpPoint = new PointF(e.X, e.Y);

            if (SelectedType != FigureType.Select)
            {
                RectangleF rect = new RectangleF(Math.Min(mouseDownPoint.X, mouseUpPoint.X), Math.Min(mouseDownPoint.Y, mouseUpPoint.Y), Math.Abs(mouseDownPoint.X - mouseUpPoint.X), Math.Abs(mouseDownPoint.Y - mouseUpPoint.Y));

                switch (SelectedType)
                {
                    case FigureType.Rectangle:
                        RectangleFigure rectangle = new RectangleFigure(rect, Pen);
                        PaintedFigures.Add(rectangle);
                        break;
                    case FigureType.Ellipse:
                        ElipseFigure elipse = new ElipseFigure(rect, Pen);
                        PaintedFigures.Add(elipse);
                        break;
                    case FigureType.Line:
                        LineFigure line = new LineFigure(mouseDownPoint, mouseUpPoint, Pen);
                        PaintedFigures.Add(line);
                        break;
                    default:
                        break;
                }
                pictureBox.Focus();
                panel1.Visible = false;
                pictureBox.Refresh();
            }
            else
            {
                
            }
            
        }

        

        private void RectangleButton_Click(object sender, EventArgs e)
        {
            SelectedType = FigureType.Rectangle;

            DeselectFigures();

        }

        private void ElipseButton_Click(object sender, EventArgs e)
        {
            SelectedType = FigureType.Ellipse;

            DeselectFigures();
        }

        private void LineButton_Click(object sender, EventArgs e)
        {
            SelectedType = FigureType.Line;

            DeselectFigures();
        }

        private void BorderdColorButton_Click(object sender, EventArgs e)
        {
            BorderColorDialog.ShowDialog();
            BorderdColorButton.BackColor = BorderColorDialog.Color;

            foreach (var figure in SelectedFigures)
            {
                figure.ChangePenColor(BorderColorDialog.Color);
            }

            pictureBox.Refresh();
        }

        private void FillColorButton_Click(object sender, EventArgs e)
        {
            FillColorDialog.ShowDialog();
            FillColorButton.BackColor = FillColorDialog.Color;

            foreach (var figure in SelectedFigures)
            {
                //TODO fill color property
                pictureBox.Refresh();
            }
        }

        private void ThicknessNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if ((float)ThicknessNumericUpDown.Value == 0)
            {
                return;
            }

            foreach (var figure in SelectedFigures)
            {
                figure.ChangePenWidth((float)ThicknessNumericUpDown.Value);
                pictureBox.Refresh();
            }
        }

        private void DeselectFigures()
        {
            foreach (var selectedFigure in SelectedFigures)
            {
                selectedFigure.IsSelected = false;
            }
            SelectedFigures.Clear();
            
            PanelDefault();
        }

        private void PanelDefault()
        {
            FillColorDialog.Color = Color.White;
            FillColorButton.BackColor = Color.White;
            BorderColorDialog.Color = Color.Black;
            BorderdColorButton.BackColor = Color.Black;
            if (SelectedFigures.Count > 1)
            {
                ThicknessNumericUpDown.Value = 0;
            }
            else
            {
                ThicknessNumericUpDown.Value = 1;
            }
            Pen = new Pen(Color.Black, 1f);
        }

        private void PanelLoadSelected()
        {

        }

        private void Group_Click(object sender, EventArgs e)
        {
            if (SelectedFigures.Count() > 1)
            {
                Group group = new Group(this.SelectedFigures);

                foreach (var figure in SelectedFigures)
                {
                    this.PaintedFigures.Remove(figure);
                }

                foreach (var figure in group.GroupedFigures)
                {
                    this.SelectedFigures.Remove(figure);
                }

                SelectedFigures.Add(group);
                PaintedFigures.Add(group);
            }
        }

        private void Ungroup_Click(object sender, EventArgs e)
        {
            List<Group> tempListOfGroups = new List<Group>();

            foreach (var figrue in SelectedFigures)
            {
                if (figrue.GetType().ToString() == "KomputarnaGrafika.Model.Group")
                {
                    Group group = (Group)figrue;
                    tempListOfGroups.Add(group);
                }
            }

            foreach (var figure in tempListOfGroups)
            {
                PaintedFigures.Remove(figure);
                SelectedFigures.Remove(figure);

                foreach (var groupedFigure in figure.GroupedFigures)
                {
                    PaintedFigures.Add(groupedFigure);
                    SelectedFigures.Add(groupedFigure);
                }
            }
        }

        private void RotateValues_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void RotateButton_Click(object sender, EventArgs e)
        {
            foreach (var figure in this.SelectedFigures)
            {
                figure.RotateAt((float)RotateValues.Value);
            }

            this.pictureBox.Refresh();
        }

        private void ListOfNamesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = ListOfNamesComboBox.ComboBox.SelectedIndex;

            if (selectedIndex > 0)
            {
                this.NameTextBox.Text = this.PaintedFigures[selectedIndex - 1].Name;
                this.NameTextBox.ReadOnly = false;
                this.SelectedFigures.Clear();
                this.SelectedFigures.Add(this.PaintedFigures[selectedIndex - 1]);
                this.Refresh();
            }
            else
            {
                NameTextBox.ReadOnly = true;
                this.SelectedFigures.Clear();
            }
        }
    }
}
