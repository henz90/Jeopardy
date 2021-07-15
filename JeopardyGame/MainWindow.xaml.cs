using JeopardyGame.Resources;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Net.Http;
using System.Windows;
using static JeopardyGame.Game;

namespace JeopardyGame
{
    public partial class MainWindow : Window
    {

        /*  NOTES:
         *  http://www.digitallycreated.net/Blog/61/combining-multiple-assemblies-into-a-single-exe-for-a-wpf-application
        */
        static HttpClient client = new HttpClient();

        static string path = null;
        static JsonData game = null;
        static int round = 0;
        static SoundPlayer player = new SoundPlayer(Properties.Resources.timer);
        bool sound = true;

        public static string GetRandomDate()
        {
            string date = "";
            Random random = new Random();

            int day = random.Next(1, 31);
            int month = random.Next(1, 12);
            int year = random.Next(1983, DateTime.Now.Year);

            if (month <= 9)
            {
                date += "0" + month + "/";
            }
            else
            {
                date += month + "/";
            }
            if (day <= 9)
            {
                date += "0" + day + "/";
            }
            else
            {
                date += day + "/";
            }

            date += year;

            return date;
        }

        static JsonData GetGame(string path)
        {
            JsonData game = null;

            var client = new RestClient("http://jarchive-json.glitch.me/game/" + path);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            var response = client.Execute(request);
            if (response.IsSuccessful)
            {
                game = JsonConvert.DeserializeObject<JsonData>(response.Content);
                if (game.message == Global.MissingGame + path || CheckGame(game))
                {
                    path = GetRandomDate();
                    game = GetGame(path);
                }             

                /*  TODO:   DATABASE INTEGRATION
                using (var db = new GameContext())
                {
                    if (!db.Jeopardy.Where(x => x.id == path).Select(x => x).ToString().Contains(path))
                    {
                        game.jeopardy[0].id = path;
                        game.doublejeopardy[0].id = path;
                        game.finaljeopardy.id = path;
                        db.Jeopardy.AddRange(game.jeopardy);
                        db.DoubleJeopardy.AddRange(game.doublejeopardy);
                        db.FinalJeopardy.Add(game.finaljeopardy);
                    }
                }
                */

                return game;
            }
            else
            {
                path = GetRandomDate();
                game = GetGame(path);
            }
            return game;
        }

        private static bool CheckGame(JsonData game)
        {
            List<string> unrevealedCategories = game.jeopardy.Where(x => x.clue == Global.Unrevealed).Select(x => x.category).ToList();
            List<string> mysteryAnswers = game.jeopardy.Where(x => x.answer == Global.Mystery).Select(x => x.category).ToList();
            if (unrevealedCategories.Any() || mysteryAnswers.Any())
            {
                return true;
            }
            return false;
        }

        public MainWindow()
        {
            InitializeComponent();
            JeopardyStart();
            player.Load();
            player.PlayLooping();
        }

        private void JeopardyStart()
        {
            clue.Visibility = Visibility.Collapsed;
            BtnEnable();

            tbCat1Clue1.Text = Global._200;
            tbCat2Clue1.Text = Global._200;
            tbCat3Clue1.Text = Global._200;
            tbCat4Clue1.Text = Global._200;
            tbCat5Clue1.Text = Global._200;
            tbCat6Clue1.Text = Global._200;

            tbCat1Clue2.Text = Global._400;
            tbCat2Clue2.Text = Global._400;
            tbCat3Clue2.Text = Global._400;
            tbCat4Clue2.Text = Global._400;
            tbCat5Clue2.Text = Global._400;
            tbCat6Clue2.Text = Global._400;

            tbCat1Clue3.Text = Global._600;
            tbCat2Clue3.Text = Global._600;
            tbCat3Clue3.Text = Global._600;
            tbCat4Clue3.Text = Global._600;
            tbCat5Clue3.Text = Global._600;
            tbCat6Clue3.Text = Global._600;

            tbCat1Clue4.Text = Global._800;
            tbCat2Clue4.Text = Global._800;
            tbCat3Clue4.Text = Global._800;
            tbCat4Clue4.Text = Global._800;
            tbCat5Clue4.Text = Global._800;
            tbCat6Clue4.Text = Global._800;

            tbCat1Clue5.Text = Global._1000;
            tbCat2Clue5.Text = Global._1000;
            tbCat3Clue5.Text = Global._1000;
            tbCat4Clue5.Text = Global._1000;
            tbCat5Clue5.Text = Global._1000;
            tbCat6Clue5.Text = Global._1000;

            path = GetRandomDate();
            game = GetGame(path);
            client.BaseAddress = new Uri("http://jarchive-json.glitch.me/game/");
            try
            {
                Title = path;
                tbCat1.Text = game.jeopardy[0].category;
                tbCat2.Text = game.jeopardy[1].category;
                tbCat3.Text = game.jeopardy[2].category;
                tbCat4.Text = game.jeopardy[3].category;
                tbCat5.Text = game.jeopardy[4].category;
                tbCat6.Text = game.jeopardy[5].category;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void DoubleJeopardyStart()
        {
            BtnEnable();

            tbCat1Clue1.Text = Global._400;
            tbCat2Clue1.Text = Global._400;
            tbCat3Clue1.Text = Global._400;
            tbCat4Clue1.Text = Global._400;
            tbCat5Clue1.Text = Global._400;
            tbCat6Clue1.Text = Global._400;

            tbCat1Clue2.Text = Global._800;
            tbCat2Clue2.Text = Global._800;
            tbCat3Clue2.Text = Global._800;
            tbCat4Clue2.Text = Global._800;
            tbCat5Clue2.Text = Global._800;
            tbCat6Clue2.Text = Global._800;

            tbCat1Clue3.Text = Global._1200;
            tbCat2Clue3.Text = Global._1200;
            tbCat3Clue3.Text = Global._1200;
            tbCat4Clue3.Text = Global._1200;
            tbCat5Clue3.Text = Global._1200;
            tbCat6Clue3.Text = Global._1200;

            tbCat1Clue4.Text = Global._1600;
            tbCat2Clue4.Text = Global._1600;
            tbCat3Clue4.Text = Global._1600;
            tbCat4Clue4.Text = Global._1600;
            tbCat5Clue4.Text = Global._1600;
            tbCat6Clue4.Text = Global._1600;

            tbCat1Clue5.Text = Global._2000;
            tbCat2Clue5.Text = Global._2000;
            tbCat3Clue5.Text = Global._2000;
            tbCat4Clue5.Text = Global._2000;
            tbCat5Clue5.Text = Global._2000;
            tbCat6Clue5.Text = Global._2000;

            try
            {
                tbCat1.Text = game.doublejeopardy[0].category;
                tbCat2.Text = game.doublejeopardy[1].category;
                tbCat3.Text = game.doublejeopardy[2].category;
                tbCat4.Text = game.doublejeopardy[3].category;
                tbCat5.Text = game.doublejeopardy[4].category;
                tbCat6.Text = game.doublejeopardy[5].category;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void FinalJeopardyStart()
        {
            clue.Visibility = Visibility.Visible;
            tbClue.Text = game.finaljeopardy.clue;
        }

        private void BtnEnable()
        {
            clue.IsEnabled = true;

            btnCat1Clue1.IsEnabled = true;
            btnCat1Clue2.IsEnabled = true;
            btnCat1Clue3.IsEnabled = true;
            btnCat1Clue4.IsEnabled = true;
            btnCat1Clue5.IsEnabled = true;

            btnCat2Clue1.IsEnabled = true;
            btnCat2Clue2.IsEnabled = true;
            btnCat2Clue3.IsEnabled = true;
            btnCat2Clue4.IsEnabled = true;
            btnCat2Clue5.IsEnabled = true;

            btnCat3Clue1.IsEnabled = true;
            btnCat3Clue2.IsEnabled = true;
            btnCat3Clue3.IsEnabled = true;
            btnCat3Clue4.IsEnabled = true;
            btnCat3Clue5.IsEnabled = true;

            btnCat4Clue1.IsEnabled = true;
            btnCat4Clue2.IsEnabled = true;
            btnCat4Clue3.IsEnabled = true;
            btnCat4Clue4.IsEnabled = true;
            btnCat4Clue5.IsEnabled = true;

            btnCat5Clue1.IsEnabled = true;
            btnCat5Clue2.IsEnabled = true;
            btnCat5Clue3.IsEnabled = true;
            btnCat5Clue4.IsEnabled = true;
            btnCat5Clue5.IsEnabled = true;

            btnCat6Clue1.IsEnabled = true;
            btnCat6Clue2.IsEnabled = true;
            btnCat6Clue3.IsEnabled = true;
            btnCat6Clue4.IsEnabled = true;
            btnCat6Clue5.IsEnabled = true;
        }

        private void Clue_Click(object sender, RoutedEventArgs e)
        {
            switch (round)
            {
                case 0:
                    clue.Visibility = Visibility.Collapsed;
                    break;
                case 1:
                    clue.Visibility = Visibility.Collapsed;
                    break;
                case 2:
                    tbClue.Text = game.finaljeopardy.clue;
                    round = 3;
                    break;
                case 3:
                    tbClue.Text = game.finaljeopardy.clue + ":\n\n" + game.finaljeopardy.answer.ToUpper();
                    clue.IsEnabled = false;
                    break;
            }
        }

        //  COLUMN 1
        private void tbCat1Clue1_Click(object sender, RoutedEventArgs e)
        {
            
            clue.Visibility = Visibility.Visible;
            switch (round)
            {
                case 0:
                    tbClue.Text = game.jeopardy[0].clue;
                    tbCat1Clue1.Text = game.jeopardy[0].answer;
                    break;
                case 1:
                    tbClue.Text = game.doublejeopardy[0].clue;
                    tbCat1Clue1.Text = game.doublejeopardy[0].answer;
                    break;
            }
            btnCat1Clue1.IsEnabled = false;
        }

        private void tbCat1Clue2_Click(object sender, RoutedEventArgs e)
        {
            clue.Visibility = Visibility.Visible;
            switch (round)
            {
                case 0:
                    tbClue.Text = game.jeopardy[6].clue;
                    tbCat1Clue2.Text = game.jeopardy[6].answer;
                    break;
                case 1:
                    tbClue.Text = game.doublejeopardy[6].clue;
                    tbCat1Clue2.Text = game.doublejeopardy[6].answer;
                    break;
            }
            btnCat1Clue2.IsEnabled = false;
        }

        private void tbCat1Clue3_Click(object sender, RoutedEventArgs e)
        {
            clue.Visibility = Visibility.Visible;
            switch (round)
            {
                case 0:
                    tbClue.Text = game.jeopardy[12].clue;
                    tbCat1Clue3.Text = game.jeopardy[12].answer;
                    break;
                case 1:
                    tbClue.Text = game.doublejeopardy[12].clue;
                    tbCat1Clue3.Text = game.doublejeopardy[12].answer;
                    break;
            }
            btnCat1Clue3.IsEnabled = false;
        }

        private void tbCat1Clue4_Click(object sender, RoutedEventArgs e)
        {
            clue.Visibility = Visibility.Visible;
            switch (round)
            {
                case 0:
                    tbClue.Text = game.jeopardy[18].clue;
                    tbCat1Clue4.Text = game.jeopardy[18].answer;
                    break;
                case 1:
                    tbClue.Text = game.doublejeopardy[18].clue;
                    tbCat1Clue4.Text = game.doublejeopardy[18].answer;
                    break;
            }
            btnCat1Clue4.IsEnabled = false;
        }

        private void tbCat1Clue5_Click(object sender, RoutedEventArgs e)
        {
            clue.Visibility = Visibility.Visible;
            switch (round)
            {
                case 0:
                    tbClue.Text = game.jeopardy[24].clue;
                    tbCat1Clue5.Text = game.jeopardy[24].answer;
                    break;
                case 1:
                    tbClue.Text = game.doublejeopardy[24].clue;
                    tbCat1Clue5.Text = game.doublejeopardy[24].answer;
                    break;
            }
            btnCat1Clue5.IsEnabled = false;
        }

        //  COLUMN 2
        private void tbCat2Clue1_Click(object sender, RoutedEventArgs e)
        {
            clue.Visibility = Visibility.Visible;
            switch (round)
            {
                case 0:
                    tbClue.Text = game.jeopardy[1].clue;
                    tbCat2Clue1.Text = game.jeopardy[1].answer;
                    break;
                case 1:
                    tbClue.Text = game.doublejeopardy[1].clue;
                    tbCat2Clue1.Text = game.doublejeopardy[1].answer;
                    break;
            }
            btnCat2Clue1.IsEnabled = false;
        }

        private void tbCat2Clue2_Click(object sender, RoutedEventArgs e)
        {
            clue.Visibility = Visibility.Visible;
            switch (round)
            {
                case 0:
                    tbClue.Text = game.jeopardy[7].clue;
                    tbCat2Clue2.Text = game.jeopardy[7].answer;
                    break;
                case 1:
                    tbClue.Text = game.doublejeopardy[7].clue;
                    tbCat2Clue2.Text = game.doublejeopardy[7].answer;
                    break;
            }
            btnCat2Clue2.IsEnabled = false;
        }

        private void tbCat2Clue3_Click(object sender, RoutedEventArgs e)
        {
            clue.Visibility = Visibility.Visible;
            switch (round)
            {
                case 0:
                    tbClue.Text = game.jeopardy[13].clue;
                    tbCat2Clue3.Text = game.jeopardy[13].answer;
                    break;
                case 1:
                    tbClue.Text = game.doublejeopardy[13].clue;
                    tbCat2Clue3.Text = game.doublejeopardy[13].answer;
                    break;
            }
            btnCat2Clue3.IsEnabled = false;
        }

        private void tbCat2Clue4_Click(object sender, RoutedEventArgs e)
        {
            clue.Visibility = Visibility.Visible;
            switch (round)
            {
                case 0:
                    tbClue.Text = game.jeopardy[19].clue;
                    tbCat2Clue4.Text = game.jeopardy[19].answer;
                    break;
                case 1:
                    tbClue.Text = game.doublejeopardy[19].clue;
                    tbCat2Clue4.Text = game.doublejeopardy[19].answer;
                    break;
            }
            btnCat2Clue4.IsEnabled = false;
        }

        private void tbCat2Clue5_Click(object sender, RoutedEventArgs e)
        {
            clue.Visibility = Visibility.Visible;
            switch (round)
            {
                case 0:
                    tbClue.Text = game.jeopardy[25].clue;
                    tbCat2Clue5.Text = game.jeopardy[25].answer;
                    break;
                case 1:
                    tbClue.Text = game.doublejeopardy[25].clue;
                    tbCat2Clue5.Text = game.doublejeopardy[25].answer;
                    break;
            }
            btnCat2Clue5.IsEnabled = false;
        }

        //  COLUMN 3
        private void tbCat3Clue1_Click(object sender, RoutedEventArgs e)
        {
            clue.Visibility = Visibility.Visible;
            switch (round)
            {
                case 0:
                    tbClue.Text = game.jeopardy[2].clue;
                    tbCat3Clue1.Text = game.jeopardy[2].answer;
                    break;
                case 1:
                    tbClue.Text = game.doublejeopardy[2].clue;
                    tbCat3Clue1.Text = game.doublejeopardy[2].answer;
                    break;
            }            
            btnCat3Clue1.IsEnabled = false;
        }

        private void tbCat3Clue2_Click(object sender, RoutedEventArgs e)
        {
            clue.Visibility = Visibility.Visible;
            switch (round)
            {
                case 0:
                    tbClue.Text = game.jeopardy[8].clue;
                    tbCat3Clue2.Text = game.jeopardy[8].answer;
                    break;
                case 1:
                    tbClue.Text = game.doublejeopardy[8].clue;
                    tbCat3Clue2.Text = game.doublejeopardy[8].answer;
                    break;
            }
            btnCat3Clue2.IsEnabled = false;
        }

        private void tbCat3Clue3_Click(object sender, RoutedEventArgs e)
        {
            clue.Visibility = Visibility.Visible;
            switch (round)
            {
                case 0:
                    tbClue.Text = game.jeopardy[14].clue;
                    tbCat3Clue3.Text = game.jeopardy[14].answer;
                    break;
                case 1:
                    tbClue.Text = game.doublejeopardy[14].clue;
                    tbCat3Clue3.Text = game.doublejeopardy[14].answer;
                    break;
            }
            btnCat3Clue3.IsEnabled = false;
        }

        private void tbCat3Clue4_Click(object sender, RoutedEventArgs e)
        {
            clue.Visibility = Visibility.Visible;
            switch (round)
            {
                case 0:
                    tbClue.Text = game.jeopardy[20].clue;
                    tbCat3Clue4.Text = game.jeopardy[20].answer;
                    break;
                case 1:
                    tbClue.Text = game.doublejeopardy[20].clue;
                    tbCat3Clue4.Text = game.doublejeopardy[20].answer;
                    break;
            }
            btnCat3Clue4.IsEnabled = false;
        }

        private void tbCat3Clue5_Click(object sender, RoutedEventArgs e)
        {
            clue.Visibility = Visibility.Visible;
            switch (round)
            {
                case 0:
                    tbClue.Text = game.jeopardy[26].clue;
                    tbCat3Clue5.Text = game.jeopardy[26].answer;
                    break;
                case 1:
                    tbClue.Text = game.doublejeopardy[26].clue;
                    tbCat3Clue5.Text = game.doublejeopardy[26].answer;
                    break;
            }
            btnCat3Clue5.IsEnabled = false;
        }

        //  COLUMN 4
        private void tbCat4Clue1_Click(object sender, RoutedEventArgs e)
        {
            clue.Visibility = Visibility.Visible;
            switch (round)
            {
                case 0:
                    tbClue.Text = game.jeopardy[3].clue;
                    tbCat4Clue1.Text = game.jeopardy[3].answer;
                    break;
                case 1:
                    tbClue.Text = game.doublejeopardy[3].clue;
                    tbCat4Clue1.Text = game.doublejeopardy[3].answer;
                    break;
            }
            btnCat4Clue1.IsEnabled = false;
        }

        private void tbCat4Clue2_Click(object sender, RoutedEventArgs e)
        {
            clue.Visibility = Visibility.Visible;
            switch (round)
            {
                case 0:
                    tbClue.Text = game.jeopardy[9].clue;
                    tbCat4Clue2.Text = game.jeopardy[9].answer;
                    break;
                case 1:
                    tbClue.Text = game.doublejeopardy[9].clue;
                    tbCat4Clue2.Text = game.doublejeopardy[9].answer;
                    break;
            }
            btnCat4Clue2.IsEnabled = false;
        }

        private void tbCat4Clue3_Click(object sender, RoutedEventArgs e)
        {
            clue.Visibility = Visibility.Visible;
            switch (round)
            {
                case 0:
                    tbClue.Text = game.jeopardy[15].clue;
                    tbCat4Clue3.Text = game.jeopardy[15].answer;
                    break;
                case 1:
                    tbClue.Text = game.doublejeopardy[15].clue;
                    tbCat4Clue3.Text = game.doublejeopardy[15].answer;
                    break;
            }
            btnCat4Clue3.IsEnabled = false;
        }

        private void tbCat4Clue4_Click(object sender, RoutedEventArgs e)
        {
            clue.Visibility = Visibility.Visible;
            switch (round)
            {
                case 0:
                    tbClue.Text = game.jeopardy[21].clue;
                    tbCat4Clue4.Text = game.jeopardy[21].answer;
                    break;
                case 1:
                    tbClue.Text = game.doublejeopardy[21].clue;
                    tbCat4Clue4.Text = game.doublejeopardy[21].answer;
                    break;
            }
            btnCat4Clue4.IsEnabled = false;
        }

        private void tbCat4Clue5_Click(object sender, RoutedEventArgs e)
        {
            clue.Visibility = Visibility.Visible;
            switch (round)
            {
                case 0:
                    tbClue.Text = game.jeopardy[27].clue;
                    tbCat4Clue5.Text = game.jeopardy[27].answer;
                    break;
                case 1:
                    tbClue.Text = game.doublejeopardy[27].clue;
                    tbCat4Clue5.Text = game.doublejeopardy[27].answer;
                    break;
            }
            btnCat4Clue5.IsEnabled = false;
        }

        //  COLUMN 5
        private void tbCat5Clue1_Click(object sender, RoutedEventArgs e)
        {
            clue.Visibility = Visibility.Visible;
            switch (round)
            {
                case 0:
                    tbClue.Text = game.jeopardy[4].clue;
                    tbCat5Clue1.Text = game.jeopardy[4].answer;
                    break;
                case 1:
                    tbClue.Text = game.doublejeopardy[4].clue;
                    tbCat5Clue1.Text = game.doublejeopardy[4].answer;
                    break;
            }
            btnCat5Clue1.IsEnabled = false;
        }

        private void tbCat5Clue2_Click(object sender, RoutedEventArgs e)
        {
            clue.Visibility = Visibility.Visible;
            switch (round)
            {
                case 0:
                    tbClue.Text = game.jeopardy[10].clue;
                    tbCat5Clue2.Text = game.jeopardy[10].answer;
                    break;
                case 1:
                    tbClue.Text = game.doublejeopardy[10].clue;
                    tbCat5Clue2.Text = game.doublejeopardy[10].answer;
                    break;
            }
            btnCat5Clue2.IsEnabled = false;
        }

        private void tbCat5Clue3_Click(object sender, RoutedEventArgs e)
        {
            clue.Visibility = Visibility.Visible;
            switch (round)
            {
                case 0:
                    tbClue.Text = game.jeopardy[16].clue;
                    tbCat5Clue3.Text = game.jeopardy[16].answer;
                    break;
                case 1:
                    tbClue.Text = game.doublejeopardy[16].clue;
                    tbCat5Clue3.Text = game.doublejeopardy[16].answer;
                    break;
            }
            btnCat5Clue3.IsEnabled = false;
        }

        private void tbCat5Clue4_Click(object sender, RoutedEventArgs e)
        {
            clue.Visibility = Visibility.Visible;
            switch (round)
            {
                case 0:
                    tbClue.Text = game.jeopardy[22].clue;
                    tbCat5Clue4.Text = game.jeopardy[22].answer;
                    break;
                case 1:
                    tbClue.Text = game.doublejeopardy[22].clue;
                    tbCat5Clue4.Text = game.doublejeopardy[22].answer;
                    break;
            }
            btnCat5Clue4.IsEnabled = false;
        }

        private void tbCat5Clue5_Click(object sender, RoutedEventArgs e)
        {
            clue.Visibility = Visibility.Visible;
            switch (round)
            {
                case 0:
                    tbClue.Text = game.jeopardy[28].clue;
                    tbCat5Clue5.Text = game.jeopardy[28].answer;
                    break;
                case 1:
                    tbClue.Text = game.doublejeopardy[28].clue;
                    tbCat5Clue5.Text = game.doublejeopardy[28].answer;
                    break;
            }
            btnCat5Clue5.IsEnabled = false;
        }

        //  COLUMN 6
        private void tbCat6Clue1_Click(object sender, RoutedEventArgs e)
        {
            clue.Visibility = Visibility.Visible;
            switch (round)
            {
                case 0:
                    tbClue.Text = game.jeopardy[5].clue;
                    tbCat6Clue1.Text = game.jeopardy[5].answer;
                    break;
                case 1:
                    tbClue.Text = game.doublejeopardy[5].clue;
                    tbCat6Clue1.Text = game.doublejeopardy[5].answer;
                    break;
            }
            btnCat6Clue1.IsEnabled = false;
        }

        private void tbCat6Clue2_Click(object sender, RoutedEventArgs e)
        {
            clue.Visibility = Visibility.Visible;
            switch (round)
            {
                case 0:
                    tbClue.Text = game.jeopardy[11].clue;
                    tbCat6Clue2.Text = game.jeopardy[11].answer;
                    break;
                case 1:
                    tbClue.Text = game.doublejeopardy[11].clue;
                    tbCat6Clue2.Text = game.doublejeopardy[11].answer;
                    break;
            }
            btnCat6Clue2.IsEnabled = false;
        }

        private void tbCat6Clue3_Click(object sender, RoutedEventArgs e)
        {
            clue.Visibility = Visibility.Visible;
            switch (round)
            {
                case 0:
                    tbClue.Text = game.jeopardy[17].clue;
                    tbCat6Clue3.Text = game.jeopardy[17].answer;
                    break;
                case 1:
                    tbClue.Text = game.doublejeopardy[17].clue;
                    tbCat6Clue3.Text = game.doublejeopardy[17].answer;
                    break;
            }
            btnCat6Clue3.IsEnabled = false;
        }

        private void tbCat6Clue4_Click(object sender, RoutedEventArgs e)
        {
            clue.Visibility = Visibility.Visible;
            switch (round)
            {
                case 0:
                    tbClue.Text = game.jeopardy[23].clue;
                    tbCat6Clue4.Text = game.jeopardy[23].answer;
                    break;
                case 1:
                    tbClue.Text = game.doublejeopardy[23].clue;
                    tbCat6Clue4.Text = game.doublejeopardy[23].answer;
                    break;
            }
            btnCat6Clue4.IsEnabled = false;
        }

        private void tbCat6Clue5_Click(object sender, RoutedEventArgs e)
        {
            clue.Visibility = Visibility.Visible;
            switch (round)
            {
                case 0:
                    tbClue.Text = game.jeopardy[29].clue;
                    tbCat6Clue5.Text = game.jeopardy[29].answer;
                    break;
                case 1:
                    tbClue.Text = game.doublejeopardy[29].clue;
                    tbCat6Clue5.Text = game.doublejeopardy[29].answer;
                    break;
            }
            btnCat6Clue5.IsEnabled = false;
        }

        private void NewGame_Click(object sender, RoutedEventArgs e)
        {
            round = 0;
            JeopardyStart();
        }


        private void DoubleJeopardy_Click(object sender, RoutedEventArgs e)
        {
            round = 1;
            DoubleJeopardyStart();
        }

        private void FinalJeopardy_Click(object sender, RoutedEventArgs e)
        {
            round = 2;
            FinalJeopardyStart();
        }

        private void StopMusic_Click(object sender, RoutedEventArgs e)
        {
            if (sound)
            {
                btnMusic.Header = Global.PlayMusic;
                player.Stop();
                sound = false;
            }
            else
            {
                btnMusic.Header = Global.StopMusic;
                sound = true;
                player.Play();
            }
            
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}