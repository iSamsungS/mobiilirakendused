using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    [Activity(Label = "CalculatorActivity")]
    public class CalculatorActivity : Activity
    {
        EditText _firstEditText;
        EditText _secondEditText;
        TextView _answerText;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.calculator_layout);

            _firstEditText = FindViewById<EditText>(Resource.Id.firstNumberEditText);
            _secondEditText = FindViewById<EditText>(Resource.Id.secondNumberEditText);
            var addButton = FindViewById<Button>(Resource.Id.addButton);
            var subtractButton = FindViewById<Button>(Resource.Id.subtractButton);
            var multiplyButton = FindViewById<Button>(Resource.Id.multiplyButton);
            var divideButton = FindViewById<Button>(Resource.Id.divideButton);
            _answerText = FindViewById<TextView>(Resource.Id.answerTextView);

            addButton.Click += AddButton_Click;
            subtractButton.Click += subtractButton_Click;
            multiplyButton.Click += multiplyButton_Click;
            divideButton.Click += divideButton_Click;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {                                    
            var answer = int.Parse(_firstEditText.Text) + int.Parse(_secondEditText.Text);
            _answerText.Text = answer.ToString();
        }

        void subtractButton_Click(object sender, EventArgs e)
        {
            var answer = int.Parse(_firstEditText.Text) - int.Parse(_secondEditText.Text);
            _answerText.Text = answer.ToString();
        }
        void multiplyButton_Click(object sender, EventArgs e)
        {
            var answer = int.Parse(_firstEditText.Text) * int.Parse(_secondEditText.Text);
            _answerText.Text = answer.ToString();
        }
        void divideButton_Click(object sender, EventArgs e)
        {
            var answer = int.Parse(_firstEditText.Text) / int.Parse(_secondEditText.Text);
            _answerText.Text = answer.ToString();
        }
    }
}