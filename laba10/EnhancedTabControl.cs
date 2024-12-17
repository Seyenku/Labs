using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace laba10
{
    public class EnhancedTabControl : TabControl
    {
        public bool VerticalTabs { get; set; } = false; // Вертикальные вкладки
        public bool VerticalText { get; set; } = false; // Текст вкладок вертикально
        public bool GradientTabs { get; set; } = false; // Градиентный стиль
        public bool RoundedTabs { get; set; } = true;  // Закругленные вкладки
        public ContextMenuStrip TabContextMenu { get; set; } // Контекстное меню для вкладок

        public EnhancedTabControl()
        {
            // Включаем пользовательскую отрисовку
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            DrawMode = TabDrawMode.OwnerDrawFixed;
            SizeMode = TabSizeMode.Fixed;

            ItemSize = new Size(100, 30); // Размер вкладок
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            for (int i = 0; i < TabPages.Count; i++)
            {
                var tabRect = GetTabRect(i);

                // Поворот вкладок для вертикального режима
                if (VerticalTabs)
                {
                    tabRect = new Rectangle(tabRect.X, tabRect.Y, ItemSize.Height, ItemSize.Width);
                    e.Graphics.TranslateTransform(tabRect.Left, tabRect.Bottom);
                    e.Graphics.RotateTransform(-90);
                }

                // Заливка вкладок (Solid или Gradient)
                using (Brush tabBrush = GradientTabs
                    ? new LinearGradientBrush(tabRect, TabPages[i].BackColor, Color.LightGray, LinearGradientMode.Horizontal)
                    : new SolidBrush(TabPages[i].BackColor))
                {
                    e.Graphics.FillRectangle(tabBrush, tabRect);
                }

                // Рисуем рамку вокруг вкладки
                using (var borderPen = new Pen(i == SelectedIndex ? Color.Black : Color.Gray, 2))
                {
                    if (RoundedTabs)
                    {
                        using (var path = GetRoundedRectanglePath(tabRect, 10))
                        {
                            e.Graphics.DrawPath(borderPen, path);
                        }
                    }
                    else
                    {
                        e.Graphics.DrawRectangle(borderPen, tabRect);
                    }
                }

                // Текст вкладок
                var text = TabPages[i].Text;
                var textColor = i == SelectedIndex ? Color.Black : Color.Gray;
                using (var textBrush = new SolidBrush(textColor))
                {
                    var textFormat = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                    if (VerticalText)
                    {
                        textFormat.FormatFlags = StringFormatFlags.DirectionVertical;
                    }
                    e.Graphics.DrawString(text, Font, textBrush, tabRect, textFormat);
                }

                // Сброс вращения графики
                if (VerticalTabs)
                {
                    e.Graphics.ResetTransform();
                }
            }
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            // Отображение контекстного меню при правом клике
            if (e.Button == MouseButtons.Right && TabContextMenu != null)
            {
                for (int i = 0; i < TabPages.Count; i++)
                {
                    if (GetTabRect(i).Contains(e.Location))
                    {
                        SelectedIndex = i; // Выбор вкладки
                        TabContextMenu.Show(this, e.Location);
                        break;
                    }
                }
            }
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);

            // Установка случайного цвета для новых вкладок
            if (e.Control is TabPage tabPage)
            {
                tabPage.BackColor = Color.FromArgb(
                    100 + (TabPages.Count * 15) % 155,
                    100 + (TabPages.Count * 30) % 155,
                    200
                );
            }
        }

        private GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius)
        {
            var path = new GraphicsPath();
            int diameter = radius * 2;

            // Верхний левый угол
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);

            // Верхний правый угол
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);

            // Нижний правый угол
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);

            // Нижний левый угол
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);

            path.CloseFigure();
            return path;
        }
    }
}