using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1743145_first_app
{
    public partial class Form1 : Form
    {
        string username = "abdulelah"; //username
        string myPassword = "1234"; //password

        bool loggedIn = false;

        int ThisAttempt = 1;
        int MaxAttempts = 3;
        public Form1()
        {
         
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (!loggedIn)
            {

                while (ThisAttempt <= MaxAttempts)
                {
                    if (txtUser.Text != username)
                    {
                        // username is incorrect
                        MessageBox.Show("Invalid username, " + (MaxAttempts - ThisAttempt) + " attempts remaining");
                        ThisAttempt++; //
                        return;
                    }
                    else
                    {   // username is correct
                        // so check password			
                        if (txtPassword.Text != myPassword)
                        {
                            // Incorrect password
                            ThisAttempt++;
                            MessageBox.Show("Incorrect password," + (MaxAttempts - ThisAttempt) + " attempts remaining");
                            return;
                        }
                        else
                        {
                            //Both are correct
                            ThisAttempt = 1; // reset the number of attempts
                            loggedIn = true;
                            // MessageBox.Show("Hi " + username + ", your login successful", "Welcome!!");                          




                            btnLogin.Text = "Logout";

                            break; // come out of while loop
                        }//endif

                    }//endif
                }//end while
            }
            else
            {
                btnLogin.Text = "Login";
                
                loggedIn = false;

                txtUser.Clear();
                txtPassword.Clear();


            }



        } //end login Button



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRadio_Click(object sender, EventArgs e)
        {
            frmRadio frm = new frmRadio();
            frm.ShowDialog();
        }
    }
}
