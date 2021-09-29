using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Ejemplo_1
{
    public partial class RegistroVendedor : System.Web.UI.Page
    {
        //Nuestra variable de coneccion
        SqlConnection con = null;
        string query = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            lblInsercion.Text = "";
        }

        //Insertamos los datos a la base de datos
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //Creamos la conexion a la bdd
                con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Ventas;Integrated Security=True");

                //Creamos la query de insercion
                query = "INSERT INTO Vendedor(Nombre,Dui,Sueldo) VALUES" +
                               "('" + txtVendedor.Text + "','" + txtDui.Text + "'," + Convert.ToDouble(txtSueldo.Text) + ")";

                //Mandamos el query a la cola
                SqlCommand comando = new SqlCommand(query, con);

                //Abrir la conexion
                con.Open();

                //Ejecutamos la query
                int status = comando.ExecuteNonQuery();

                if (status >= 1)
                {
                    lblInsercion.Text = "El valor se insertado correctamente";
                    txtVendedor.Text = "";
                    txtDui.Text = "";
                    txtSueldo.Text = "";
                }

            }
            catch(SqlException ex)
            {
                Console.WriteLine("Ha habido un error." + ex);
                lblInsercion.Text = "Ha habido un problema";
            }
            finally
            {
                con.Close();
                con = null;
            }
        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            //Dejar vacio el mensaje
            lblInsercion.Text = "";
            try
            {
                //Creamos nuestra conexion a la db
                con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Ventas;Integrated Security=True");

                //Creamos la query
                query = "SELECT * FROM Vendedor";

                //Declaramos nuestro query
                SqlCommand comando = new SqlCommand(query, con);

                //Abrimos la conexion
                con.Open();

                //Ejecutamos el comando
                SqlDataReader dataset = comando.ExecuteReader();

                //Leemos cada dato y lo trabajamos
                while (dataset.Read())
                {
                    //Creamos un TableRow y un TableCell
                    TableRow tr = new TableRow(); //Esto es igual a document.createElement('tr')
                    TableCell[] td = new TableCell[4]; //document.createElement('td')

                    //Inicializamos las TableCell
                    for (int i = 0; i < 4; i++)
                    {
                        td[i] = new TableCell();
                    }

                    //Creamos label nuevos 
                    Label lblIdVendedor = new Label();
                    Label lblNombre = new Label();
                    Label lblDui = new Label();
                    Label lblSueldo = new Label();

                    //Manejamos cada valor del Dataset
                    //Valores de IdVendedor
                    lblIdVendedor.Text = dataset["IdVendedor"].ToString();//Convertimos a Stirng el valor que viene de la db
                    td[0].Controls.Add(lblIdVendedor); //Esto es como un AppendChild
                    tr.Controls.Add(td[0]); //Este es tambien un appendChild

                    //Valores de Nombre
                    lblNombre.Text = dataset["Nombre"].ToString();//Convertimos a Stirng el valor que viene de la db
                    td[1].Controls.Add(lblNombre); //Esto es como un AppendChild
                    tr.Controls.Add(td[1]); //Este es tambien un appendChild

                    //Valores de Dui
                    lblDui.Text = dataset["Dui"].ToString();//Convertimos a Stirng el valor que viene de la db
                    td[2].Controls.Add(lblDui); //Esto es como un AppendChild
                    tr.Controls.Add(td[2]); //Este es tambien un appendChild

                    lblSueldo.Text = "$ "+ dataset["Sueldo"].ToString();//Convertimos a Stirng el valor que viene de la db
                    td[3].Controls.Add(lblSueldo); //Esto es como un AppendChild
                    tr.Controls.Add(td[3]); //Este es tambien un appendChild

                    tbMostrar.Controls.Add(tr); //Un appendChild del TableRow
                }

            }
            catch(SqlException ex)
            {
                Console.WriteLine("Ha habido un error." + ex);
            }
            finally
            {
                con.Close();
                con = null;
            }
            
        }

    }
}