using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    

        



    public class Login
    {
        string usuario = "anthony";
        string password = "wow123";


       



        public void logear(string usuarioLog, string contraseñaLog)
        {
            DialogResult resultado;

            if (usuarioLog == String.Empty && contraseñaLog == String.Empty)
            {

                resultado = MessageBox.Show("Favor de llenar los campos vacios");
            }
            else

                if (usuarioLog == this.usuario && contraseñaLog == this.password)
                {

                    resultado = MessageBox.Show("Conectando al servidor....");
                    resultado = MessageBox.Show("Bienvenido a World War Craft");
                }
                else if (usuarioLog != this.usuario && contraseñaLog != this.password)
                {
                    resultado = MessageBox.Show("Usuario y contraseñas incorrectos!!!");

                }
                else if (usuarioLog != this.usuario)
                {
                    resultado = MessageBox.Show("Usuario incorrecto!!!");

                }
                else if (contraseñaLog != this.password)
                {
                    resultado = MessageBox.Show("contraseña incorrecta!!!");

                }

        }

    } 
}
