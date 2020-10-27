using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;
using System.ComponentModel;
using System.Linq;

namespace XamarinMathsQuiz
{
    class GameManager
    {
        private List<Question> questions;
        private int score;
        private Question currentQuestion;
        private int questionCount;
        public int CorrectCount { get; set; }
        public int WrongCount { get; set; }

        public GameManager() {
            currentQuestion = new Question(5);
            questionCount++;
        }


        public Question getCurrentQuestion() {
            return this.currentQuestion;
        }

        public void generateQuestion() {
            currentQuestion = new Question(questionCount + 5 * 2);
            questionCount++;
        }

        public void checkAnswer(int answerArg) {
            if (answerArg == this.currentQuestion.getAnswer())
            {
                CorrectCount++;
            }
            else {
                WrongCount++;
            }
        }

        
    }
}
