using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace JuegoPOO
{
    public partial class Form1 : Form
    {
        Personaje jugador;
        Personaje enemigo;
        Random rnd = new Random();
        int vidaTotalJugador;
        int vidaTotalEnemigo;
        int rondasGanadas;
        string rutaImagenGuerrero;
        string rutaImagenMago;
        string rutaImagenArquero;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblJugador_Click(object sender, EventArgs e)
        {
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

            switch (cmbPersonaje.Text)
            {
                case "Guerrero":
                    ReiniciarJuego();
                    jugador = new Guerrero();
                    if (rutaImagenGuerrero != null)
                        CargarImagenJugador("idle");
                    else
                        CargarImagenJugador("idle");
                    break;
                case "Mago":
                    ReiniciarJuego();
                    jugador = new Mago();
                        if (rutaImagenMago != null)
                            CargarImagenJugador("idle");
                        else
                            CargarImagenJugador("idle");
                    break;
                case "Arquero":
                    ReiniciarJuego();
                    jugador = new Arquero();
                    if (rutaImagenArquero != null)
                        CargarImagenJugador("idle");
                    else
                        CargarImagenJugador("idle");
                    break;
                default:
                    MessageBox.Show("Selecciona un personaje");
                    break;
            }
            if (jugador != null)
            {
                lblJugador.Text = cmbPersonaje.Text;
                pbVidaJugador.Maximum = jugador.Vida;
                pbVidaJugador.Value = jugador.Vida;
                vidaTotalJugador = jugador.Vida;
                pbxJugador.Image = Image.FromFile($"{jugador.Nombre}/idle.gif");
                ttInfoPersonaje.SetToolTip(pbxJugador,
                 $"Nombre: {jugador.Nombre}\nVida: {jugador.Vida}\nAtaque: {jugador.Ataque}");

                if (rondasGanadas % 5 == 0 && rondasGanadas != 0)
                {
                    CrearEnemigo(new Boss());
                }
                else
                {
                    CrearEnemigo(new Personaje("Enemigo", 100, 15));
                }

            }

        }

        public void CrearEnemigo(Personaje nuevoEnemigo)
        {
            enemigo = nuevoEnemigo;
            lblEnemigo.Text = enemigo.Nombre;
            pbVidaEnemigo.Maximum = enemigo.Vida;
            pbVidaEnemigo.Value = enemigo.Vida;
            vidaTotalEnemigo = enemigo.Vida;
            pbxEnemigo.Image = Image.FromFile($"{enemigo.Nombre}/idle.gif");
        }

        private async void btnAtacar_Click(object sender, EventArgs e)
        {
            int daño = jugador.Atacar();
            enemigo.Vida -= daño;
            txtLog.AppendText($"Jugador hizo {daño} de daño\r\n");
            ActualizaBarrasDeVida();
            if (pbxJugador.ImageLocation == $"{jugador.Nombre}/idle.gif" && File.Exists($"{jugador.Nombre}/ataque.gif"))
            {
                CargarImagenJugador("ataque");
            }
            btnAtacar.Enabled = false;
            btnEspecial.Enabled = false;
            btnCurar.Enabled = false;
            await Task.Delay(1000);
            CargarImagenJugador("idle");

            ContraatacarEnemigo();

            btnAtacar.Enabled = true;
            btnEspecial.Enabled = true;
            btnCurar.Enabled = true;
            VerificarVictoria();
        }

        private async void btnEspecial_Click(object sender, EventArgs e)
        {
            int daño = jugador.Atacar() * 2;
            enemigo.Vida -= daño;
            txtLog.AppendText($"Jugador hizo {daño} de daño\r\n");
            ActualizaBarrasDeVida();
            if (pbxJugador.ImageLocation == $"{jugador.Nombre}/idle.gif" && File.Exists($"{jugador.Nombre}/ataque.gif"))
            {
                CargarImagenJugador("ataque");
            }
            btnAtacar.Enabled = false;
            btnEspecial.Enabled = false;
            btnCurar.Enabled = false;
            await Task.Delay(1000);
            CargarImagenJugador("idle");

            ContraatacarEnemigo();


            btnAtacar.Enabled = true;
            btnEspecial.Enabled = true;
            btnCurar.Enabled = true;
            VerificarVictoria();

        }
        public void VerificarVictoria()
        {

            if (enemigo.Vida <= 0)
            {
                rondasGanadas++;
                lblVictorias.Text = $"Batallas ganadas: {rondasGanadas}";
                btnAtacar.Enabled = false;
                btnEspecial.Enabled = false;
                btnCurar.Enabled = false;
                MessageBox.Show("¡Has ganado!");

            }
            else if (jugador.Vida <= 0)
            {
                btnAtacar.Enabled = false;
                btnEspecial.Enabled = false;
                btnCurar.Enabled = false;
                MessageBox.Show("Has perdido, más suerte a la próxima");

            }
        }

        public void ActualizaBarrasDeVida()
        {
            pbVidaJugador.Value = Math.Max(pbVidaJugador.Minimum, Math.Min(pbVidaJugador.Maximum, jugador.Vida));
            pbVidaEnemigo.Value = Math.Max(pbVidaEnemigo.Minimum, Math.Min(pbVidaEnemigo.Maximum, enemigo.Vida));
            lblVidaJugador.Text = $"{Math.Max(jugador.Vida, 0)}/{vidaTotalJugador}";
            lblVidaEnemigo.Text = $"{Math.Max(enemigo.Vida, 0)}/{vidaTotalEnemigo}";
        }

        public void ReiniciarJuego()
        {
            jugador = null;
            enemigo = null;
            lblJugador.Text = "Jugador";
            pbVidaJugador.Value = 0;
            pbVidaEnemigo.Value = 0;
            txtLog.Clear();
            btnAtacar.Enabled = true;
            btnEspecial.Enabled = true;
            btnCurar.Enabled = true;
            lblVidaJugador.Text = "Vida Jugador";
            lblVidaEnemigo.Text = "Vida Enemigo";
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            btnAtacar.Enabled = false;
            btnEspecial.Enabled = false;
            btnCurar.Enabled = false;
        }

        private async void btnCurar_Click(object sender, EventArgs e)
        {
            btnCurar.Enabled = false;
            btnAtacar.Enabled = false;
            btnEspecial.Enabled = false;

            int curacion = jugador.Curar();
            jugador.Vida += curacion;
            jugador.Vida = Math.Min(jugador.Vida, vidaTotalJugador);
            ActualizaBarrasDeVida();
            if (File.Exists($"{jugador.Nombre}/curar.gif"))
            {
                CargarImagenJugador("curar");
            }
            await Task.Delay(1000);
            CargarImagenJugador("idle");

            txtLog.AppendText($"Jugador se curó {curacion} puntos de vida\r\n");

            btnCurar.Enabled = true;
            btnAtacar.Enabled = true;
            btnEspecial.Enabled = true;
        }

        public async void ContraatacarEnemigo()
        {
            if (enemigo.Vida <= 0)
                return;

            if (enemigo is Boss && rnd.Next(1, 5) == 1)
            {
                enemigo.Vida += enemigo.Curar();
                enemigo.Vida = Math.Min(enemigo.Vida, vidaTotalEnemigo);
                txtLog.AppendText($"{enemigo.Nombre} se curó!\r\n");
            }

            int contra = rnd.Next(enemigo.Ataque - 5, enemigo.Ataque + 10);
            jugador.Vida -= contra;
            txtLog.AppendText($"{enemigo.Nombre} hizo {contra} de daño\r\n");
            ActualizaBarrasDeVida();

            if (File.Exists($"{enemigo.Nombre}/ataque.gif"))
            {
                pbxEnemigo.Image = Image.FromFile($"{enemigo.Nombre}/ataque.gif");
            }

            await Task.Delay(1000);
            pbxEnemigo.Image = Image.FromFile($"{enemigo.Nombre}/idle.gif");
        }

        private void cmbPersonaje_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public string ObtenerRutaSkin()
        {
            switch (jugador.Nombre)
            {
                case "Guerrero": return rutaImagenGuerrero;
                case "Mago": return rutaImagenMago;
                case "Arquero": return rutaImagenArquero;
                default: return null;
            }
        }

        public void CargarImagenJugador(string estado)
        {
            string skin = ObtenerRutaSkin();
            if (skin != null)
                pbxJugador.ImageLocation = skin;
            else
                pbxJugador.ImageLocation = $"{jugador.Nombre}/{estado}.gif";
        }
        private void btnSubirImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Selecciona una imagen";
            dialog.Filter = "Imágenes|*.jpg;*.png;*.gif";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                switch (cmbPersonaje.Text)
                {
                    case "Guerrero":
                        rutaImagenGuerrero = dialog.FileName;
                        break;
                    case "Mago":
                        rutaImagenMago = dialog.FileName;
                        break;
                    case "Arquero":
                        rutaImagenArquero = dialog.FileName;
                        break;
                }
                pbxJugador.ImageLocation = dialog.FileName;
            }
        }
    }
}
