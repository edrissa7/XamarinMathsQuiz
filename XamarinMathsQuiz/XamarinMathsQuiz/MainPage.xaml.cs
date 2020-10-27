using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinMathsQuiz
{
    public partial class MainPage : ContentPage
    {
        
        GameManager gameManager;
        public MainPage()
        {
            InitializeComponent();
             gameManager = new GameManager();
            correctLabel.Text = "Correct = " + gameManager.CorrectCount;
            wrongLabel.Text = "Wrong = " + gameManager.WrongCount;
            updateView();
              
          
        }

        private void But_Clicked(object sender, EventArgs e)
        {
         
            Button btn = (Button)sender;
            switch (btn.StyleId) {
                case "1":
                    gameManager.checkAnswer(int.Parse(But1.Text));
                    gameManager.generateQuestion();
                    updateView();
                    break;
                case "2":
                    gameManager.checkAnswer(int.Parse(But2.Text));
                    gameManager.generateQuestion();
                    updateView();
                    break;
                case "3":
                    gameManager.checkAnswer(int.Parse(But3.Text));
                    gameManager.generateQuestion();
                    updateView();
                    break;
                case "4":
                    gameManager.checkAnswer(int.Parse(But4.Text));
                    gameManager.generateQuestion();
                    updateView();
                    break;
            }
          
        }

           private void updateView() {
            

            But1.Text = gameManager.getCurrentQuestion().getAnswerArray()[0].ToString();
            But2.Text = gameManager.getCurrentQuestion().getAnswerArray()[1].ToString();
            But3.Text = gameManager.getCurrentQuestion().getAnswerArray()[2].ToString();
            But4.Text = gameManager.getCurrentQuestion().getAnswerArray()[3].ToString();

            questionText.Text = gameManager.getCurrentQuestion().getQuestionPhrase();

            correctLabel.Text = "Correct = " + gameManager.CorrectCount;
            wrongLabel.Text = "Wrong = " + gameManager.WrongCount;
        }
    }
}
