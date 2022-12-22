namespace WinFormlab1
{
    public partial class Form1 : Form
    {
        
        private void LoadData() {
            /*ImageList imagelist = new ImageList();
            imagelist.ImageSize = new Size(30, 30);
            imagelist.Images.Add(new Bitmap("image/bmw.jpg"));
            imagelist.Images.Add(new Bitmap("image/audi.png"));
            imagelist.Images.Add(new Bitmap("image/skoda.jpg"));

            Bitmap emptyImage = new Bitmap(30, 30);
            using (Graphics g = Graphics.FromImage(emptyImage)) { g.Clear(Color.White); }
            imagelist.Images.Add(new Bitmap(emptyImage));
            listView1.SmallImageList = imagelist;
            string[] firstNames = { "Иван", "Николай", "Егор" };

            // массив фамилий, которые будем выводить в listView1
            string[] lastNames = { "Иванов", "Николаев", "Егоров" };

            // добавляем строки в listView1
            for (int i = 0; i < firstNames.Length; i++)
            {
                // создадим объект ListViewItem (строку) для listView1
                ListViewItem listViewItem = new ListViewItem(new string[] { "", firstNames[i], lastNames[i] });

                // индекс изображения из imageList для данной строки listViewItem
                listViewItem.ImageIndex = i;

                // добавляем созданный элемент listViewItem (строку) в listView1
                listView1.Items.Add(listViewItem);*/
            }
        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void buttonSave1_Click_1(object sender, EventArgs e)
        {
            CargoT cargoT = GetValues();
            CreateTxtFile(cargoT);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}