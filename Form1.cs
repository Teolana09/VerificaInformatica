namespace VerificaInformatica
{
    public partial class Form1 : Form
    {
        List<string> parole = new List<string>();
        string alfabeto = "abcdefghijklmnopqrstuvxyz";
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLeggiFile_Click(object sender, EventArgs e)
        {
            int k = 0;
            char[] Alfabeto = alfabeto.ToCharArray();
            string p = "";
            using (StreamReader sr = new StreamReader("testoInformatica.csv"))
            {
                while (!sr.EndOfStream)
                {
                    string riga = sr.ReadLine();
                    parole.Add(riga);
                }
            }

            for (int i = 0; i < parole.Count; i = i + 2)
            {
                char[] parola = parole[i].ToCharArray();
                for (int j = 0; j < parola.Length; j++)
                {
                    k = 0;
                    while (parola[j] != Alfabeto[k])
                    {
                        k++;
                    }
                    if (k > 2)
                    {
                        k -= 3;
                    }
                    else
                    {
                        k = Alfabeto.Length - (3 - k);
                    }
                }
                parola[i] = Alfabeto[k];
                for(int r = 0; r < parola.Length; r++)
                {
                    p = p + parola[r];
                }
                listParole.Items.Add(parole[i]);
            }
        }

        private void listParole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConverti_Click(object sender, EventArgs e)
        {
            
        }
    }
}
