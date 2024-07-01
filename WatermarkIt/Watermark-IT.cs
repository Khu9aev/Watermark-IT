using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using Watermark;


namespace watermarkit
{
    public partial class MainForm : Form
    {
        private Watermarker m_watermarker;
        private OpenFileDialog m_ofd;

        public MainForm()
        {
            InitializeComponent();
            InitializeOpenFileDialog();
        }

        private void InitializeOpenFileDialog()
        {
            m_ofd = new OpenFileDialog
            {
                Filter = "Picture Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.tiff|All Files|*.*"
            };

        }

        private void BtnAddImage_Click(object sender, EventArgs e)
        {
            if (m_watermarker == null)
            {
                MessageBox.Show(this, "Пожалуйста, загрузите изображение", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textWatermark.Text == "")
            {
                MessageBox.Show(this, "Пожалуйста, выберите изображение водяного знака", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (checkReset.Checked)
            {
                m_watermarker.ResetImage();
            }

            try
            {
                m_watermarker.DrawImage(textWatermark.Text);
                picturePreview.Image = m_watermarker.Image;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAddText_Click(object sender, EventArgs e)
        {
            if (m_watermarker == null)
            {
                MessageBox.Show(this, "Пожалуйста, загрузите изображение", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textTextToAdd.Text == "")
            {
                MessageBox.Show(this, "Пожалуйста, укажите текст для водяного знака", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (m_watermarker != null)
            {

                if (checkReset.Checked)
                {
                    m_watermarker.ResetImage();
                }

                m_watermarker.DrawText(textTextToAdd.Text);
                picturePreview.Image = m_watermarker.Image;
            }
        }

        private void NormalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picturePreview.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void StretchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picturePreview.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void ZoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picturePreview.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void BtnSourceImage_Click(object sender, EventArgs e)
        {
            if (m_ofd.ShowDialog() == DialogResult.OK)
            {
                textSourceImage.Text = m_ofd.FileName;

                Image img = Image.FromFile(m_ofd.FileName);
                m_watermarker = new Watermarker(img);

                picturePreview.Image = img;
                propertyGrid.SelectedObject = m_watermarker;
            }
        }

        private void BtnResetImage_Click(object sender, EventArgs e)
        {
            if (m_watermarker != null)
            {
                m_watermarker.ResetImage();
                picturePreview.Image = m_watermarker.Image;
            }
        }

        private void BtnWatermark_Click(object sender, EventArgs e)
        {
            if (m_ofd.ShowDialog() == DialogResult.OK)
            {
                textWatermark.Text = m_ofd.FileName;
            }
        }

        private void SaveBnt_Click(object sender, EventArgs e)
        {
            if (picturePreview.Image != null)
            {
                //создание диалогового окна "Сохранить как..", для сохранения изображения
                SaveFileDialog savedialog = new SaveFileDialog
                {
                    Title = "Сохранить картинку как...",
                    //отображать ли предупреждение, если пользователь указывает имя уже существующего файла
                    OverwritePrompt = true,
                    //отображать ли предупреждение, если пользователь указывает несуществующий путь
                    CheckPathExists = true,
                    //список форматов файла, отображаемый в поле "Тип файла"
                    Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*",
                    //отображается ли кнопка "Справка" в диалоговом окне
                    ShowHelp = true
                };
                if (savedialog.ShowDialog() == DialogResult.OK) //если в диалоговом окне нажата кнопка "ОК"
                {
                    try
                    {
                        picturePreview.Image.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
