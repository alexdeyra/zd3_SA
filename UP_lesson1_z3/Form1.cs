using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UP_lesson1_z3
{
    public partial class Form1 : Form
    {
        Playlist myPlaylist = new Playlist();
        string deleteSong = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void добавитьПеснюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //показываем элементы для ввода данных о песне 
            //label
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            //button
            button1.Visible = true;
            //textBox
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;

            //скрываем элементы для работы с плэйлистом
            //label
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            //button
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            //textBox
            textBox4.Visible = false;
            textBox5.Visible = false;
        }

        private void плэйлистToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //скрываем элементы для ввода данных о песне 
            //label
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            //button
            button1.Visible = false;
            //textBox
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;



            //показываем элементы для работы с плэйлистом
            //label
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            //button
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            //textBox
            textBox4.Visible = true;
            textBox5.Visible = true;
            UpdateSong();
        }

        private void button1_Click(object sender, EventArgs e) // Обработчик события для кнопки "Добавить песню"
        {
            string author = textBox1.Text;
            string title = textBox2.Text;
            string filename = textBox3.Text;
           

            if (author != "" && title != "" && filename != "")
            {
                if (author.Length > 1)
                {
                    if (filename.Length > 4)
                    {
                        myPlaylist.AddSong(author, title, filename);
                        UpdateSongList();
                        MessageBox.Show("Добавлена песня '" + title + "'");
                        //очищаем поля для нового ввода
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        UpdateSong();
                    }
                    else MessageBox.Show("Путь к файлу должен содержать не менее 5 символов!!");
                }
                else MessageBox.Show("Имя автора песни должно содержать не менее 2-х символов!");
            }
            else MessageBox.Show("Пожалуйста, проверьте, что вы заполнили все поля!");
        }

        //метод для вывода текущей песни
        private void UpdateSong()
        {
            //вызов метода для того, чтобы выяснить есть ли в плэйлисте песни или он пуст
            if (myPlaylist.Count > 0)
            {
                Song songNow = myPlaylist.CurrentSong();
                label5.Text = songNow.Author + "\n" + songNow.Title;
            }
            else
            {
                label5.Text = "Плейлист пуст!";
            }
        }

        private void button2_Click(object sender, EventArgs e) // Обработчик события для кнопки "Следующая песня"
        {
            myPlaylist.NextSong();
            UpdateSong();
        }

        private void button3_Click(object sender, EventArgs e) // Обработчик события для кнопки "Предыдущая песня"
        {
            myPlaylist.BeforeSong();
            UpdateSong();
        }

        private void button4_Click(object sender, EventArgs e) // Обработчик события для кнопки "Индекс песни"
        {
            var index = textBox4.Text;
            if (int.TryParse(index, out int ind))
            {
                MessageBox.Show(myPlaylist.Index(ind - 1));
                UpdateSong();
            }
        }

        private void button5_Click(object sender, EventArgs e) // Обработчик события для кнопки "Начать плейлист"
        {
            myPlaylist.Start();
            UpdateSong();
        }

        private void label5_Click(object sender, EventArgs e) // Обработчик события для клика по label5
        {
            if (myPlaylist.Count > 0)
            {
                Song currentSong = myPlaylist.CurrentSong();
                label7.Text = $"{currentSong.Author}\n{currentSong.Title}\n{currentSong.Filename}";
                deleteSong = $"{currentSong.Author}~{currentSong.Title}~{currentSong.Filename}";
            }
        }

        private void button6_Click(object sender, EventArgs e) // Обработчик события для кнопки "Удалить песню"
        {
            if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Пожалуйста, введите индекс для удаления.");
                return;
            }

            if (int.TryParse(textBox5.Text, out int index))
            {
                if (index >= 0 && index < myPlaylist.Count)
                {
                    myPlaylist.RemoveSong(index - 1);
                    MessageBox.Show("Песня удалена по индексу.");
                    textBox5.Clear();
                    Song currentSong = myPlaylist.CurrentSong();
                    myPlaylist.RemoveSong(currentSong);
                    UpdateSongList();
                    UpdateCurrentSong();
                    UpdateSong();
                }
                else
                {
                    MessageBox.Show("У вас нет столько песен!");
                }
            }
            else if (label7.Text != "")
            {
                string[] res = deleteSong.Split('~');
                Song songDelete = new Song(res[0], res[1], res[2]);
                myPlaylist.RemoveSong(songDelete);
                MessageBox.Show("Песня удалена по данным о песне.");
                label7.Text = "";
                UpdateSong();
            }
            else MessageBox.Show("Вы не выбрали песнюдля удаления!");
        }

        private void button7_Click(object sender, EventArgs e) // Обработчик события для кнопки "Очистить плейлист"
        {
            myPlaylist.Clear();
            UpdateSong();
            UpdateSongList();
            UpdateCurrentSong();

        }
        private void UpdateSongList() // Метод для обновления списка песен в ListBox
        {
            listBoxSongs.Items.Clear();
            foreach (var song in myPlaylist.GetSongs())
            {
                listBoxSongs.Items.Add($"{song.Author} - {song.Title}");
            }
        }
        private void UpdateCurrentSong() // Метод для обновления информации о текущей песне
        {
            if (myPlaylist.GetSongs().Count > 0)
            {
                Song currentSong = myPlaylist.CurrentSong();
                MessageBox.Show($"Текущая песня: {currentSong.Author} - {currentSong.Title}");
            }
        }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (myPlaylist.Count > 0)
            {
                Song currentSong = myPlaylist.CurrentSong();
                label7.Text = $"{currentSong.Author}\n{currentSong.Title}\n{currentSong.Filename}";
                deleteSong = $"{currentSong.Author}~{currentSong.Title}~{currentSong.Filename}";
            }
        }
    }
}
