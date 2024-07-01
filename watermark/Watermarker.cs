using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Watermark
{

    public enum WatermarkPosition
    {
        Absolute,
        TopLeft,
        TopRight,
        TopMiddle,
        BottomLeft,
        BottomRight,
        BottomMiddle,
        MiddleLeft,
        MiddleRight,
        Center
    }

    public class Watermarker
    {
        private Image m_image;
        private Image m_originalImage;
        private Image m_watermark;
        private float m_opacity = 1.0f;
        private WatermarkPosition m_position = WatermarkPosition.Absolute;
        private int m_x = 0;
        private int m_y = 0;
        private Color m_transparentColor = Color.Empty;
        private RotateFlipType m_rotateFlip = RotateFlipType.RotateNoneFlipNone;
        private Padding m_margin = new Padding(0);
        private Font m_font = new Font(FontFamily.GenericSansSerif, 10);
        private Color m_fontColor = Color.Black;
        private float m_scaleRatio = 1.0f;

        // Получает изображение с нарисованными водяными знаками
        [Browsable(false)]
        public Image Image { get { return m_image; } }


        // Положение водяного знака относительно размеров изображения. 
        // Если выбрано значение Absolute, позиционирование водяного знака выполняется с помощью positionX и positionY
        // properties (0 by default)\n     
        public WatermarkPosition Position { get { return m_position; } set { m_position = value; } }


        // Координата водяного знака X (работает, если для свойства Position задано значение WatermarkPosition.Absolute)
        public int PositionX { get { return m_x; } set { m_x = value; } }


        // Координата водяного знака Y (работает, если для свойства Position задано значение WatermarkPosition.Absolute)
        public int PositionY { get { return m_y; } set { m_y = value; } }


        // Непрозрачность водяного знака. Может иметь значения от 0,0 до 1,0
        public float Opacity { get { return m_opacity; } set { m_opacity = value; } }

        // Поворот и переворачивание водяного знака
        public RotateFlipType RotateFlip { get { return m_rotateFlip; } set { m_rotateFlip = value; } }


        // Коэффициент масштабирования водяных знаков. Должен быть больше 0. Только для водяных знаков 
        public float ScaleRatio { get { return m_scaleRatio; } set { m_scaleRatio = value; } }


        // Шрифт добавляемого текста
        public Font Font { get { return m_font; } set { m_font = value; } }


        // Цвет добавляемого текста
        public Color FontColor { get { return m_fontColor; } set { m_fontColor = value; } }


        public Watermarker(Image image)
        {
            LoadImage(image);
        }


        // Сбрасывает изображение, удаляя все нарисованные водяные знаки
        public void ResetImage()
        {
            m_image = new Bitmap(m_originalImage);
        }


        // Конструкция
        public void DrawImage(string filename)
        {
            DrawImage(Image.FromFile(filename));
        }

        public void DrawImage(Image watermark)
        {

            if (watermark == null)
                throw new ArgumentOutOfRangeException("Watermark");

            if (m_opacity < 0 || m_opacity > 1)
                throw new ArgumentOutOfRangeException("Opacity");

            if (m_scaleRatio <= 0)
                throw new ArgumentOutOfRangeException("ScaleRatio");

            // Создает новый водяной знак с полями (если поля не указаны, возвращает исходный водяной знак).
            m_watermark = GetWatermarkImage(watermark);

            // Поворачивает и/или переворачивает водяной знак
            m_watermark.RotateFlip(m_rotateFlip);

            // Вычисляет положение водяного знака
            Point waterPos = GetWatermarkPosition();

            // прямоугольник водяного знака
            Rectangle destRect = new Rectangle(waterPos.X, waterPos.Y, m_watermark.Width, m_watermark.Height);

            ColorMatrix colorMatrix = new ColorMatrix(
                new float[][] {
                    new float[] { 1, 0f, 0f, 0f, 0f},
                    new float[] { 0f, 1, 0f, 0f, 0f},
                    new float[] { 0f, 0f, 1, 0f, 0f},
                    new float[] { 0f, 0f, 0f, m_opacity, 0f},
                    new float[] { 0f, 0f, 0f, 0f, 1}
                });
            ImageAttributes attributes = new ImageAttributes();
            // Установливает непрозрачность водяного знака
            attributes.SetColorMatrix(colorMatrix);
            // Установливает прозрачный цвет 
            if (m_transparentColor != Color.Empty)
            {
                attributes.SetColorKey(m_transparentColor, m_transparentColor);
            }

            // рисует водяной знак
            using (Graphics gr = Graphics.FromImage(m_image))
            {
                gr.DrawImage(m_watermark, destRect, 0, 0, m_watermark.Width, m_watermark.Height, GraphicsUnit.Pixel, attributes);
            }
        }

        public void DrawText(string text)
        {
            // Преобразует текст в изображение, чтобы мы могли использовать непрозрачность и т.д.
            Image textWatermark = GetTextWatermark(text);

            DrawImage(textWatermark);
        }

        private void LoadImage(Image image)
        {
            m_originalImage = image;
            ResetImage();
        }

        private Image GetTextWatermark(string text)
        {

            Brush brush = new SolidBrush(m_fontColor);
            SizeF size;

            // Определяет размер рамки для размещения текста с водяными знаками
            using (Graphics g = Graphics.FromImage(m_image))
            {
                size = g.MeasureString(text, m_font);
            }

            //  Создает новое растровое изображение для текста и, собственно, рисует текст
            Bitmap bitmap = new Bitmap((int)size.Width, (int)size.Height);
            bitmap.SetResolution(m_image.HorizontalResolution, m_image.VerticalResolution);

            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.DrawString(text, m_font, brush, 0, 0);
            }

            return bitmap;
        }

        private Image GetWatermarkImage(Image watermark)
        {

            // Создает новое растровое изображение с новыми размерами (размер + поля) и рисует водяной знак
            int newWidth = Convert.ToInt32(watermark.Width * m_scaleRatio);
            int newHeight = Convert.ToInt32(watermark.Height * m_scaleRatio);

            Rectangle sourceRect = new Rectangle(m_margin.Left, m_margin.Top, newWidth, newHeight);
            Rectangle destRect = new Rectangle(0, 0, watermark.Width, watermark.Height);

            Bitmap bitmap = new Bitmap(newWidth + m_margin.Left + m_margin.Right, newHeight + m_margin.Top + m_margin.Bottom);
            bitmap.SetResolution(watermark.HorizontalResolution, watermark.VerticalResolution);

            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.DrawImage(watermark, sourceRect, destRect, GraphicsUnit.Pixel);
            }

            return bitmap;
        }

        private Point GetWatermarkPosition()
        {
            int x = 0;
            int y = 0;

            switch (m_position)
            {
                case WatermarkPosition.Absolute:
                    x = m_x; y = m_y;
                    break;
                case WatermarkPosition.TopLeft:
                    x = 0; y = 0;
                    break;
                case WatermarkPosition.TopRight:
                    x = m_image.Width - m_watermark.Width; y = 0;
                    break;
                case WatermarkPosition.TopMiddle:
                    x = (m_image.Width - m_watermark.Width) / 2; y = 0;
                    break;
                case WatermarkPosition.BottomLeft:
                    x = 0; y = m_image.Height - m_watermark.Height;
                    break;
                case WatermarkPosition.BottomRight:
                    x = m_image.Width - m_watermark.Width; y = m_image.Height - m_watermark.Height;
                    break;
                case WatermarkPosition.BottomMiddle:
                    x = (m_image.Width - m_watermark.Width) / 2; y = m_image.Height - m_watermark.Height;
                    break;
                case WatermarkPosition.MiddleLeft:
                    x = 0; y = (m_image.Height - m_watermark.Height) / 2;
                    break;
                case WatermarkPosition.MiddleRight:
                    x = m_image.Width - m_watermark.Width; y = (m_image.Height - m_watermark.Height) / 2;
                    break;
                case WatermarkPosition.Center:
                    x = (m_image.Width - m_watermark.Width) / 2; y = (m_image.Height - m_watermark.Height) / 2;
                    break;
                default:
                    break;
            }

            return new Point(x, y);
        }


    }


}