using Android.App;
using Android.Widget;
using Android.OS;

namespace Tictactoe
{
    [Activity(Label = "Tictactoe", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        Button b1, b2, b3, b4, b5, b6, b7, b8, b9, reset;
        int turn;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            b1 = FindViewById<Button>(Resource.Id.b1);
            b2 = FindViewById<Button>(Resource.Id.b2);
            b3 = FindViewById<Button>(Resource.Id.b3);
            b4 = FindViewById<Button>(Resource.Id.b4);
            b5 = FindViewById<Button>(Resource.Id.b5);
            b6 = FindViewById<Button>(Resource.Id.b6);
            b7 = FindViewById<Button>(Resource.Id.b7);
            b8 = FindViewById<Button>(Resource.Id.b8);
            b9 = FindViewById<Button>(Resource.Id.b9);
            reset = FindViewById<Button>(Resource.Id.reset);

            reset.Click += delegate {
                doReset();
            };
            b1.Click += delegate
            {
                if (b1.Text.Equals(""))
                {
                    if (turn == 0)
                    {
                        turn = 1;
                        b1.Text = "X";
                        getResult();

                    }
                    else
                    {
                        turn = 0;
                        b1.Text = "O";
                        getResult();
                    }
                }
            };


            b2.Click += delegate
            {
                if (b2.Text.Equals(""))
                {
                    if (turn == 0)
                    {
                        turn = 1;
                        b2.Text = "X";
                        getResult();

                    }
                    else
                    {
                        turn = 0;
                        b2.Text = "O";
                        getResult();
                    }
                }
            };


            b3.Click += delegate
            {
                if (b3.Text.Equals(""))
                {
                    if (turn == 0)
                    {
                        turn = 1;
                        b3.Text = "X";
                        getResult();

                    }
                    else
                    {
                        turn = 0;
                        b3.Text = "O";
                        getResult();
                    }
                }
            };


            b4.Click += delegate
            {
                if (b4.Text.Equals(""))
                {
                    if (turn == 0)
                    {
                        turn = 1;
                        b4.Text = "X";
                        getResult();

                    }
                    else
                    {
                        turn = 0;
                        b4.Text = "O";
                        getResult();
                    }
                }
            };


            b5.Click += delegate
            {
                if (b5.Text.Equals(""))
                {
                    if (turn == 0)
                    {
                        turn = 1;
                        b5.Text = "X";
                        getResult();

                    }
                    else
                    {
                        turn = 0;
                        b5.Text = "O";
                        getResult();
                    }
                }
            };


            b6.Click += delegate
            {
                if (b6.Text.Equals(""))
                {
                    if (turn == 0)
                    {
                        turn = 1;
                        b6.Text = "X";
                        getResult();

                    }
                    else
                    {
                        turn = 0;
                        b6.Text = "O";
                        getResult();
                    }
                }
            };


            b7.Click += delegate
            {
                if (b7.Text.Equals(""))
                {
                    if (turn == 0)
                    {
                        turn = 1;
                        b7.Text = "X";
                        getResult();

                    }
                    else
                    {
                        turn = 0;
                        b7.Text = "O";
                        getResult();
                    }
                }
            };


            b8.Click += delegate
            {
                if (b8.Text.Equals(""))
                {
                    if (turn == 0)
                    {
                        turn = 1;
                        b8.Text = "X";
                        getResult();

                    }
                    else
                    {
                        turn = 0;
                        b8.Text = "O";
                        getResult();
                    }
                }
            };


            b9.Click += delegate
            {
                if (b9.Text.Equals(""))
                {
                    if (turn == 0)
                    {
                        turn = 1;
                        b9.Text = "X";
                        getResult();

                    }
                    else
                    {
                        turn = 0;
                        b9.Text = "O";
                        getResult();
                    }
                }
            };

            }

        public void doReset () 
        {
            b1.Text = "";
            b2.Text = "";
            b3.Text = "";
            b4.Text = "";
            b5.Text = "";
            b6.Text = "";
            b7.Text = "";
            b8.Text = "";
            b9.Text = "";
        }
        public void getResult () {

            //Horizontal Checks
            if (b1.Text.Equals("X") && b2.Text.Equals("X") && b3.Text.Equals("X"))
            {
                Toast.MakeText(this, "X Player Wins", ToastLength.Long).Show();
                doReset();
            }
            if (b1.Text.Equals("O") && b2.Text.Equals("O") && b3.Text.Equals("O"))
            {
                Toast.MakeText(this, "O Player Wins", ToastLength.Long).Show();
                doReset();
            }
            if (b4.Text.Equals("X") && b5.Text.Equals("X") && b6.Text.Equals("X"))
            {
                Toast.MakeText(this, "O Player Wins", ToastLength.Long).Show();
                doReset();
            }
            if (b4.Text.Equals("O") && b5.Text.Equals("O") && b6.Text.Equals("O"))
            {
                Toast.MakeText(this, "O Player Wins", ToastLength.Long).Show();
                doReset();
            }
            if (b7.Text.Equals("X") && b8.Text.Equals("X") && b9.Text.Equals("X"))
            {
                Toast.MakeText(this, "O Player Wins", ToastLength.Long).Show();
                doReset();
            }
            if (b7.Text.Equals("O") && b8.Text.Equals("O") && b9.Text.Equals("O"))
            {
                Toast.MakeText(this, "O Player Wins", ToastLength.Long).Show();
                doReset();
            }
            //Horizontal Checks








            //Vertical Checks
            if (b1.Text.Equals("X") && b4.Text.Equals("X") && b7.Text.Equals("X"))
            {
                Toast.MakeText(this, "X Player Wins", ToastLength.Long).Show();
                doReset();
            }
            if (b1.Text.Equals("O") && b4.Text.Equals("O") && b7.Text.Equals("O"))
            {
                Toast.MakeText(this, "O Player Wins", ToastLength.Long).Show();
                doReset();
            }
            if (b2.Text.Equals("X") && b5.Text.Equals("X") && b8.Text.Equals("X"))
            {
                Toast.MakeText(this, "O Player Wins", ToastLength.Long).Show();
                doReset();
            }
            if (b2.Text.Equals("O") && b5.Text.Equals("O") && b8.Text.Equals("O"))
            {
                Toast.MakeText(this, "O Player Wins", ToastLength.Long).Show();
                doReset();
            }
            if (b3.Text.Equals("X") && b6.Text.Equals("X") && b9.Text.Equals("X"))
            {
                Toast.MakeText(this, "O Player Wins", ToastLength.Long).Show();
                doReset();
            }
            if (b3.Text.Equals("O") && b6.Text.Equals("O") && b9.Text.Equals("O"))
            {
                Toast.MakeText(this, "O Player Wins", ToastLength.Long).Show();
                doReset();
            }
            //Vertical Checks


            // Diagonal Checks
            if (b1.Text.Equals("X") && b5.Text.Equals("X") && b9.Text.Equals("X"))
            {
                Toast.MakeText(this, "X Player Wins", ToastLength.Long).Show();
                doReset();
            }
            if (b1.Text.Equals("O") && b5.Text.Equals("O") && b9.Text.Equals("O"))
            {
                Toast.MakeText(this, "O Player Wins", ToastLength.Long).Show();
                doReset();
            }

            if (b3.Text.Equals("X") && b5.Text.Equals("X") && b7.Text.Equals("X"))
            {
                Toast.MakeText(this, "X Player Wins", ToastLength.Long).Show();
                doReset();
            }
            if (b3.Text.Equals("O") && b5.Text.Equals("O") && b7.Text.Equals("O"))
            {
                Toast.MakeText(this, "O Player Wins", ToastLength.Long).Show();
                doReset();
            }
            //Diagonal Checks

        }
    }
}

