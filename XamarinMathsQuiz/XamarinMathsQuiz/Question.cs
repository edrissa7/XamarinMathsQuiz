using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinMathsQuiz
{
    class Question
    {
        private int firstNumber;
        private int secondNumber;
        private int answer;
        private int[] answerArray = new int[4];
        private int answerPosition;
        //private int upperLimit;
        private string questionPhrase;

        public Question(int upperLimit) {
            firstNumber = new Random().Next(upperLimit);
            secondNumber = new Random().Next(upperLimit);
            answer = firstNumber + secondNumber;
            questionPhrase = firstNumber + " + " + secondNumber + " = ";
            answerPosition = new Random().Next(4);
            

                this.answerArray[0] = answer + 1;
                this.answerArray[1] = answer + 4;
                this.answerArray[2] = answer + 7;
                this.answerArray[3] = answer + 2;

            ShuffleArray(this.answerArray);

                this.answerArray[answerPosition] = answer;           
                  

        }

        public int[] getAnswerArray() {
            return this.answerArray;
        }

        public void setQuestionPhrase(string questionPhrase) {
            this.questionPhrase = questionPhrase;
        }

        public string getQuestionPhrase() {
            return questionPhrase;
        }

        public int getAnswer() {
            return this.answer;
        }

        public void ShuffleArray(int[] array) {
            int randomIndex = new Random().Next(4);
            for (int i = 0; i < array.Length; i++) {
                int temp = array[randomIndex];
                array[randomIndex] = array[i];
                array[i] = temp;
            }
            
        }
    }
}
